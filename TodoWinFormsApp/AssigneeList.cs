using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoWinFormsApp.Data;
using TodoWinFormsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoWinFormsApp
{
    public partial class AssigneeList : Form
    {
        public AssigneeList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private async void AssigneeList_Load(object sender, EventArgs e)
        {
            await SearchAssigneeAsync();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new AssigneeResister())
            {
                form.ShowDialog();
            }
        }

        private async Task SearchAssigneeAsync()
        {
            SetBusy(true);

            try
            {
                var searchText = SearchTextBox.Text.Trim();
                await using var dbContext = new TodoDbContext();

                var assingees = await dbContext.TodoAssignees
                    .Where(x => string.IsNullOrEmpty(searchText) || x.AssigneeName.Contains(searchText))
                    .OrderBy(x => x.AssigneeId)
                    .Select(x => new AssigneeListItem(
                        x.AssigneeId,
                        x.AssigneeName,
                        x.EmailAddress))
                    .ToListAsync();

                dataGridView1.DataSource = assingees;
            }
            catch (Exception)
            {
                MessageBox.Show("DB処理に失敗しました。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ヘッダーなど、部署データがない行は処理しない
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].DataBoundItem is not AssigneeListItem item)
            {
                return;
            }

            if (dataGridView1.Columns[e.ColumnIndex] == EditButtonColumn)
            {
                using var editForm = new AssigneeResister(item.Id);
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    await SearchAssigneeAsync();
                }
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            await SearchAssigneeAsync();
        }

        private void SetBusy(bool isBusy)
        {
            UseWaitCursor = isBusy;
            buttonSearch.Enabled = !isBusy;
            button1.Enabled = !isBusy;
            dataGridView1.Enabled = !isBusy;
            EditButtonColumn.ReadOnly = isBusy;
        }
        public sealed record AssigneeListItem(string Id, string Name, string? Email);
    }
}
