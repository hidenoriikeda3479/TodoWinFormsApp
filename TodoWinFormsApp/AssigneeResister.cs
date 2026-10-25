using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoWinFormsApp.Const;
using TodoWinFormsApp.Data;
using TodoWinFormsApp.Models;

namespace TodoWinFormsApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AssigneeResister : Form
    {
        /// <summary>
        /// 画面を開いた時点の日時
        /// </summary>
        private DateTime _originalUpdatedAt;

        /// <summary>
        /// 編集対象の担当者ID(新規作成時はnull)
        /// </summary>
        private readonly string? _assigneeId;

        /// <summary>
        /// 部署作成・編集画面
        /// </summary>
        public AssigneeResister(string? assigneeId = null)
        {
            _assigneeId = assigneeId;
            InitializeComponent();
        }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AssigneeResister_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_assigneeId))
            {
                // 削除ボタンは無効にする
                buttonDelete.Enabled = false;
                textBoxAssigneeName.Focus();
                return;
            }

            try
            {
                SetBusy(true);

                await using var dbContext = new TodoDbContext();

                var assignee = await dbContext.TodoAssignees.FindAsync(_assigneeId);

                if (assignee == null)
                {
                    MessageBox.Show(this, "ほかのユーザーにより更新されています。最新の内容を再読み込みしてください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                _originalUpdatedAt = assignee.UpdatedAt; // 画面を開いた時点の日時を保持
                labelAssigneId.Text = assignee.AssigneeId;
                textBoxAssigneeName.Text = assignee.AssigneeName;
                textBoxEmail.Text = assignee.EmailAddress;
                // null合体演算子 「?? 型.値」でnullだった場合指定の値を入れてくれる
                textBoxDetail.Text = assignee.Note ?? string.Empty;
            }
            catch (Exception ex)
            {
                // 最初のデータ取得失敗なのでメッセージを変えた方が好ましい　ex:接続エラー再度お試しくださいなど
                ShowError("保存処理に失敗しました。入力内容を確認して再度お試しください。", ex);
            }
            finally
            {
                SetBusy(false);
            }
        }


        /// <summary>
        /// 戻るボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            // 削除するか確認
            var result = MessageBox.Show("この担当者を削除します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                SetBusy(true);

                await using var dbContext = new TodoDbContext();

                var assignee = await dbContext.TodoAssignees.FindAsync(_assigneeId);

                if (assignee == null)
                {
                    MessageBox.Show(this, "ほかのユーザーにより更新されています。最新の内容を再読み込みしてください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                // 日付チェック
                if (assignee.UpdatedAt != _originalUpdatedAt)
                {
                    MessageBox.Show("この担当者は既に他のユーザーによって更新されています。", "編集競合", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                dbContext.TodoAssignees.Remove(assignee);
                await dbContext.SaveChangesAsync();

                MessageBox.Show("担当者を削除しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                ShowError("削除処理に失敗しました。時間をおいて再度お試しください。", ex);
            }
            finally
            {
                SetBusy(false);
            }
        }

        /// <summary>
        /// 保存ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            // 入力情報
            var name = textBoxAssigneeName.Text.Trim();
            var mail = textBoxEmail.Text.Trim();
            var detail = textBoxDetail.Text.Trim();

            // 入力チェック
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("名前を入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAssigneeName.Focus();
                return;
            }
            else if (name.Length > 100)
            {
                MessageBox.Show("担当者名は100文字以内で入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAssigneeName.Focus();
                return;
            }
            else if (mail.Length > 254 || string.IsNullOrEmpty(mail) || !mail.Contains('@'))
            // メアドは任意なのでIsNullOrEmptyはどうにかする
            {
                MessageBox.Show("正しいメールアドレスを入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }
            else if (detail.Length > 500)
            {
                MessageBox.Show("備考は500文字以内で入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDetail.Focus();
                return;
            }


            // 接続
            await using var dbContext = new TodoDbContext();

            try
            {
                SetBusy(true);

                // assigneeidの有無
                if (string.IsNullOrEmpty(_assigneeId))
                {
                    var assigneeinformation = new TodoAssignee
                    {
                        AssigneeName = name,
                        EmailAddress = mail,
                        Note = string.IsNullOrEmpty(detail) ? null : detail,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        LoggedUserCode = "SYSTEM",
                        LoggedFunctionId = "ASG-EDT-001",
                        LogType = HistoryLogType.Insert,
                    };

                    dbContext.TodoAssignees.Add(assigneeinformation);
                    await dbContext.SaveChangesAsync();
                    MessageBox.Show("担当者を登録しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();

                }
                else
                {
                    var assignee = await dbContext.TodoAssignees.FindAsync(_assigneeId);

                    // 既に削除されている場合のチェック
                    if (assignee == null)
                    {
                        MessageBox.Show("他のユーザーによって削除されています。最新の内容を再読み込みしてください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.Cancel;
                        Close();
                        return;
                    }

                    // 日付チェック
                    if (assignee.UpdatedAt != _originalUpdatedAt)
                    {
                        MessageBox.Show("この担当者は既に他のユーザーによって更新されています。", "編集競合", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult = DialogResult.Cancel;
                        Close();
                        return;
                    }

                    assignee.AssigneeName = name;
                    assignee.EmailAddress = mail;　// 必須
                    assignee.Note = string.IsNullOrEmpty(detail) ? null : detail;
                    assignee.UpdatedAt = DateTime.Now;
                    assignee.LoggedUserCode = "SYSTEM";
                    assignee.LoggedFunctionId = "ASG-EDT-001";
                    assignee.LogType = HistoryLogType.Update;


                    await dbContext.SaveChangesAsync();
                    MessageBox.Show("担当者を登録しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                ShowError("保存処理に失敗しました", ex);
            }
            finally
            {
                SetBusy(false);
            }
        }

        /// <summary>
        /// エラー表示
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        private static void ShowError(string message, Exception exception)
        {
            MessageBox.Show(
                $"{message}{Environment.NewLine}{exception.Message}",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// 作業の監視
        /// </summary>
        /// <param name="isbusy"></param>
        private void SetBusy(bool isbusy)
        {
            UseWaitCursor = isbusy;
            buttonDelete.Enabled = !isbusy;
            buttonRestore.Enabled = !isbusy;
            buttonReturn.Enabled = !isbusy;
        }
    }
}
