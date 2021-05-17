using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_demo
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbEmail.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            comboBoxVarsta.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }
    }
}
