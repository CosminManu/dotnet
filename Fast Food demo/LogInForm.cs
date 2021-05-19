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
    /// <summary>
    /// Problema la TAB
    /// nu se sterge 'password' se suprascrie inf
    /// 
    /// Daca e timp implementat afisare formRegister
    /// in fata celui LogIn (min 23 https://www.youtube.com/watch?v=kcrOAF473LM&list=WL&index=53&t=6s)
    /// </summary>


    public partial class LogInForm : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);

        public LogInForm()
        {
            InitializeComponent();
        }

        
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            // ...validari...

            if (validPass() == true)
            {
                this.Hide();
                Form1 formularp = new Form1();
                formularp.Show();
                formularp.Closed += (s, args) => this.Close();      //exp lambda: creeaz func pe loc cand
                                                                    //form p e inchis
                //this.Close();                                     //s, args parametri (obj sender, EventArgs)
            }
            else
            {
                MessageBox.Show("Sign in failed.");
            }
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rfrm = new RegisterForm();
            rfrm.ShowDialog();

        }

        private void usernameTb_Click(object sender, EventArgs e)
        {
            if(usernameTb.Text == "Username")
            {
                usernameTb.Clear();
            }
            
            panel1.BackColor = Color.FromArgb(235, 48, 14);
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void passwordTb_Click(object sender, EventArgs e)
        {
            if(passwordTb.Text == "Password")
            {
                passwordTb.Clear();
            }
            
            passwordTb.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;

            validPass();
        }

        private void ConfirmPassTb_Click(object sender, EventArgs e)
        {
            if (ConfirmPassTb.Text == "Confirm Password")
            {
                ConfirmPassTb.Clear();
            }
            
            ConfirmPassTb.PasswordChar = '*';
            panel3.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;

            validPass();
          
        }

        private bool validPass()
        {
            if (passwordTb.Text.Length != 0 && ConfirmPassTb.Text != passwordTb.Text)
            {
                string message = "Confirm password is not the same.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #region MoveLogIn
        private void LogInForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void LogInForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void LogInForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        #endregion

    }
}
