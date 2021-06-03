using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Fast_Food_demo
{
    public partial class LogInForm : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        private const string Connection = "Data Source=UserRegistrationDB.db";
        private string username;
        private string password;
        private string confirmPass;

        public LogInForm()
        {
            InitializeComponent();
        }

        
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            const string querySql = "SELECT Username, Password FROM User";
            
            if (validPass() == true)
            {
                using (SQLiteConnection conn = new SQLiteConnection(Connection))
                {
                    conn.Open();
                    var command = new SQLiteCommand(querySql, conn);    //init comanda cu queryul dat de mine

                    using (SQLiteDataReader sqlReader = command.ExecuteReader())
                    {
                        while (sqlReader.Read())        //cat timp citeste urm linie
                        {
                            username = (string)sqlReader["Username"];
                            password = (string)sqlReader["Password"];
                            confirmPass = (string)sqlReader["Password"];
                        }
                    }  
                }

                if (usernameTb.Text == username)
                {
                    if (passwordTb.Text == password)
                    {
                        this.Hide();
                        Form1 formularp = new Form1();
                        formularp.Show();
                        formularp.Closed += (s, args) => this.Close();      //exp lambda: creeaz func pe loc cand
                                                                                //form p e inchis
                                                                                //s, args parametri (obj sender, EventArgs)       
                    }
                    else
                    {
                        MessageBox.Show("Wrong password.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        passwordTb.Clear();
                        ConfirmPassTb.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username.", 
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    usernameTb.Clear();
                    //Application.Exit();
                }
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

            //validPass();
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

            //validPass();
          
        }


        /// <summary>
        /// functia verif daca a fost introd user
        /// parola si confirm parola
        /// </summary>
        /// <returns>true / false</returns>
        private bool validPass()
        {
            if(usernameTb.Text.Length == 0)
            {
                string message = "Username is mandatory.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (passwordTb.Text.Length == 0)
            {
                string message = "Password is mandatory.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (ConfirmPassTb.Text != passwordTb.Text)
            {
                string message = "Confirm password is not the same.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTb.Clear();
                ConfirmPassTb.Clear();
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
