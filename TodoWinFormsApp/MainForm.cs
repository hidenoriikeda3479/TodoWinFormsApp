using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonAssigneeList_Click(object sender, EventArgs e)
        {
            using (var form = new AssigneeList())
            {
                form.ShowDialog();
            }
        }

        private void ButtonTodoCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
