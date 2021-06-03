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
using Fast_Food_demo.Modele;

namespace Fast_Food_demo
{

    /// <summary>
    /// https://www.youtube.com/watch?v=hxOB5ALWQMQ&list=WL&index=48
    /// https://www.youtube.com/watch?v=pde8dZEYIHA
    /// 
    /// conex entity framework (sem7 mp4 obre)
    /// https://drive.google.com/drive/folders/13Dx4TDaEVWCACQ_EJCjMoUeznoXjkoFH
    /// https://github.com/liviucotfas/ase-windows-applications-programming/blob/master/10%20-%20WinForms%20-%20Databases%20-%20EF.md
    /// conexiune la bdd SQLlite
    /// </summary>

    public partial class RegisterForm : Form
    {

        bool drag = false;
        Point startPoint = new Point(0, 0);
        private const string Connection = "Data Source=UserRegistrationDB.db";

        public RegisterForm()
        {
            InitializeComponent();
        }

        

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string nume = NumeTb.Text;
            string prenume = PrenumeTb.Text;
            string email = EmailTb.Text;
            string username = usernameTb.Text;
            string password = passwordTb.Text;

            Customer customer = new Customer(nume, prenume, email, username, password);
            addUser(customer);
            Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region TextBox click
        private void NumeTb_Click(object sender, EventArgs e)
        {
            if (NumeTb.Text == "Last name")
            {
                NumeTb.Clear();
            }
            panel1.BackColor = Color.FromArgb(235, 48, 14);
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            errorProvider1.SetError(NumeTb, "");
        }

        private void PrenumeTb_Click(object sender, EventArgs e)
        {
            if (PrenumeTb.Text == "First name")
            {
                PrenumeTb.Clear();
            }
            panel2.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            errorProvider1.SetError(PrenumeTb, "");
        }

        private void EmailTb_Click(object sender, EventArgs e)
        {
            if (EmailTb.Text == "E-mail")
            {
                EmailTb.Clear();
            }
            panel3.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;

            //daca totul e ok, setez errProv pe ""
            errorProvider1.SetError(EmailTb, "");
        }

        private void usernameTb_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text == "Username")
            {
                usernameTb.Clear();
            }
            panel4.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel5.BackColor = Color.White;

            errorProvider1.SetError(usernameTb, "");
        }

        private void passwordTb_Click(object sender, EventArgs e)
        {
            if (passwordTb.Text == "Password")
            {
                passwordTb.Clear();
            }
            passwordTb.PasswordChar = '*';
            panel5.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;

            errorProvider1.SetError(passwordTb, "");
        }
        #endregion

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

        #region Validating
        private void NumeTb_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ValidatingNames();
            }
            catch (Exception ex)
            {
                //utiliz nu poate face submit si se selecteaza nume de corectat
                e.Cancel = true;
                NumeTb.Select(0, NumeTb.Text.Length);
                errorProvider1.SetError(NumeTb, ex.Message);
            }
        }

        private void PrenumeTb_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ValidatingNames();
            }
            catch (Exception ex)
            {
                //utiliz nu poate face submit si se selecteaza prenume de corectat
                e.Cancel = true;
                PrenumeTb.Select(0, PrenumeTb.Text.Length);
                errorProvider1.SetError(PrenumeTb, ex.Message);
            }
        }

        private void EmailTb_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ValidatingCode();
            }
            catch (Exception ex)
            {
                //utiliz nu poate face submit si se selecteaza email de corectat
                e.Cancel = true;
                EmailTb.Select(0, EmailTb.Text.Length);
                errorProvider1.SetError(EmailTb, ex.Message);
            }
        }

        private void usernameTb_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if(usernameTb.Text.Length == 0)
                {
                    string message = "Username is a mandatory field.";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    throw new Exception(message);       //arunca exceptia pana cand e prinsa (try -> sare la catch)
                }
                else if (usernameTb.Text.Any(c => c < 47 && c > 34))                //Ascii
                {
                    string message = "Username can't contain special characters: " +
                                    "\n# $ % & * ( ) + - , .";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    throw new Exception(message);       //arunca exceptia pana cand e prinsa (try -> sare la catch)
                }
                else if (usernameTb.Text.Any(c => c < 65 && c > 58))
                {
                    string message = "Username can't contain special characters: " +
                                    "\n ; : + - < > = ? or @ ";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    throw new Exception(message);       
                }
            }
            catch(Exception ex)
            {
                e.Cancel = true; //the event is canceled
                usernameTb.Select(0, usernameTb.Text.Length);
                errorProvider1.SetError(usernameTb, ex.Message);
            }
        }

        private void passwordTb_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (passwordTb.Text.Length == 0)
                {
                    string message = "Password is a mandatory field.";
                    string title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    throw new Exception(message);       
                }
            }
            catch(Exception ex)
            {
                e.Cancel = true; 
                passwordTb.Select(0, passwordTb.Text.Length);
                errorProvider1.SetError(passwordTb, ex.Message);

            }
        }


        //merg pe caz naspa, cand arunc avertismente (throw excep)
        private void ValidatingCode()
        {
            //daca nu s a introd nimic
            if(EmailTb.Text.Length == 0 && ( NumeTb.Text.Length != 0 && PrenumeTb.Text.Length != 0) )
            {
                string message = "Email address is a required field.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception(message);

            }
            //daca nu gaseste punct sau nu gaseste @ atunci arunca avertis (excep)
            //daca gaseste amandoua f||f = f sare peste excep
            else if(EmailTb.Text.Length != 0 && (EmailTb.Text.IndexOf(".") == -1 || EmailTb.Text.IndexOf("@") == -1) )
            {
                string message = "Email address must be valid address format." + "\nFor example: 'someone@example.com'";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception(message);
            }
        }

        private void ValidatingNames()
        {
            if (NumeTb.Text.Length == 0)
            {
                string message = "Last name is required fields.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception(message);
            }
            else if (PrenumeTb.Text.Length == 0)
            {
                string message = "First name is required field.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception(message);
            }
            else if ( NumeTb.Text.Any(c => char.IsDigit(c)) || PrenumeTb.Text.Any(c => char.IsDigit(c)) )
            {
                string message = "Last name and first name are only character fields.";
                string title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new Exception(message);
            }
        }
        #endregion


        private void addUser(Customer c)        // CREATE
        {
            const string querySql = "insert into User(Nume, Prenume, Email, Username, Password)" +
                                   " values (@nume, @prenume, @email, @username, @password);" +
                                   "select last_insert_rowid()";

            using (SQLiteConnection conn = new SQLiteConnection(Connection))
            {
                conn.Open();
                var command = new SQLiteCommand(querySql, conn);
                command.Parameters.AddWithValue("@nume", c.Nume);
                command.Parameters.AddWithValue("@prenume", c.Prenume);
                command.Parameters.AddWithValue("@email", c.Email);
                command.Parameters.AddWithValue("@username", c.Username);
                command.Parameters.AddWithValue("@password", c.Password);

                c.ID = (long)command.ExecuteScalar();       //noul id ia urm valoare din tabela

            }
        }
    }
}
