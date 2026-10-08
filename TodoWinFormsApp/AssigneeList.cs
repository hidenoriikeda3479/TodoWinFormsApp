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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new AssigneeResister())
            {
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async Task SearchDepartmentAsync()
        {
            try
            {
                await using var dbContext = new TodoDbContext();

                var assingees = await dbContext.TodoAssignees
                    .OrderBy(TodoAssignee => TodoAssignee.AssigneeId)
                    .Select(TodoAssignee => new AssigneeListItem(
                        TodoAssignee.AssigneeId,
                        TodoAssignee.AssigneeName,
                        TodoAssignee.EmailAddress))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ほかのユーザーにより更新されています。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private sealed record AssigneeListItem(string Id, string Name, string ?Email);
    }
}
