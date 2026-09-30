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
    }
}
