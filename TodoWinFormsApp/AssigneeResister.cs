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
using TodoWinFormsApp.Data;
using TodoWinFormsApp.Models;

namespace TodoWinFormsApp
{
    public partial class AssigneeResister : Form
    {
        /// <summary>
        /// 編集対象の担当者ID(新規作成時はnull)
        /// </summary>
        private readonly int? _assigneeId;

        /// <summary>
        /// 部署作成・編集画面
        /// </summary>
        public AssigneeResister(int? assigneeId = null)
        {
            _assigneeId = assigneeId;
            InitializeComponent();
        }

        

        private void buttonReturn_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await using var dbContext = new TodoDbContext();
            var assignee = await dbContext.TodoAssignees.FindAsync();
        }

        private async void buttonRestore_Click(object sender, EventArgs e)
        {
            var id = labelAssigneId.Text;
            var name = textBoxAssigneeName.Text.Trim();
            var mail = textBoxEmail.Text.Trim();
            var detail = textBoxDetail.Text.Trim();
            


            
                if (name.Length == 0)
                {
                 MessageBox.Show("担当者名を入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 textBoxAssigneeName.Focus();
                 return;
                }
                else if(name.Length > 36)
                {
                 MessageBox.Show("担当者名は100文字以内で入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 textBoxAssigneeName.Focus();
                 return;
                }
                else if(mail.Length >254 && mail.Length == 0 && !mail.Contains('@'))
                {
                 MessageBox.Show("正しいメールアドレスを入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 textBoxAssigneeName.Focus();
                 return;
                }
                else if (detail.Length > 500)
                {
                 MessageBox.Show("備考は500文字以内で入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 textBoxAssigneeName.Focus();
                 return;
                }

            
            // 接続
            await using var dbContext = new TodoDbContext();

            

            try
            {
                SetBusy(true);

                if (_assigneeId.HasValue)
                {
                    // assigneeidの有無
                    var assignee = await dbContext.TodoAssignees.FindAsync(_assigneeId.Value);

                    if (assignee == null) 
                    {
                        MessageBox.Show("ほかのユーザーにより更新されています。最新の内容を再読み込みしてください。", "編集", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    
                    
                }
                else
                {
                    var assigneeinformation = new TodoAssignee
                    {
                        AssigneeName = name,
                        EmailAddress = mail,
                        Note = detail,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        LoggedUserCode = "SYSTEM",
                        LoggedFunctionId = "ASG-EDT-001",
                        LogType = 0
                    };

                    dbContext.TodoAssignees.Add(assigneeinformation);

                }
                await dbContext.SaveChangesAsync();
                MessageBox.Show("担当者を登録しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.OK;
                Close();
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

        private async void AssigneeResister_Shown(object sender, EventArgs e)
        {
            if (!_assigneeId.HasValue)
            {
                textBoxAssigneeName.Focus();
                return;
            }

            try
            {
                await using var dbContext = new TodoDbContext();


            }
            catch (Exception ex)
            {
                ShowError("保存処理に失敗しました。入力内容を確認して再度お試しください", ex);
                Close();
            }

        }

        private static void ShowError(string message, Exception exception)
        {
            MessageBox.Show(
                $"{message}{Environment.NewLine}{exception.Message}",
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void SetBusy(bool isbusy)
        {
            UseWaitCursor = isbusy;
            buttonDelete.Enabled = !isbusy;
            buttonRestore.Enabled = !isbusy;
            buttonReturn.Enabled = !isbusy;
        }
    }
}
