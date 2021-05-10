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
    public partial class RegisterForm : Form
    {

        bool drag = false;
        Point startPoint = new Point(0, 0);

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Click(object sender, EventArgs e)
        {
        }

        private void NameTb_Click(object sender, EventArgs e)
        {
            NameTb.Clear();
            panel1.BackColor = Color.FromArgb(235, 48, 14);
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void PrenumeTb_Click(object sender, EventArgs e)
        {
            PrenumeTb.Clear();
            panel2.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void EmailTb_Click(object sender, EventArgs e)
        {
            EmailTb.Clear();
            panel3.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            //rfrm.Close();
            //Application.Exit();
            Close();
        }

        #region MoveRegister
        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion

        private void registerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
