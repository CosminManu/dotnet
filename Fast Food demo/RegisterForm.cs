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
    /// https://www.youtube.com/watch?v=hxOB5ALWQMQ&list=WL&index=48
    /// conexiune la bdd SQLlite
    /// </summary>

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

        private void NumeTb_Click(object sender, EventArgs e)
        {
            if (NumeTb.Text == "Nume")
            {
                NumeTb.Clear();
            }
            panel1.BackColor = Color.FromArgb(235, 48, 14);
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            errorProvider1.SetError(NumeTb, "");
        }

        private void PrenumeTb_Click(object sender, EventArgs e)
        {
            if (PrenumeTb.Text == "Prenume")
            {
                PrenumeTb.Clear();
            }
            panel2.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            errorProvider1.SetError(PrenumeTb, "");
        }

        private void EmailTb_Click(object sender, EventArgs e)
        {
            if (EmailTb.Text == "Email")
            {
                EmailTb.Clear();
            }
            panel3.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;

            //daca totul e ok, setez errProv pe ""
            errorProvider1.SetError(EmailTb, "");
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

        private void EmailTb_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ValidatingCode();
            }
            catch(Exception ex)
            {
                //utiliz nu poate face submit si se selecteaza email de corectat
                e.Cancel = true;
                EmailTb.Select(0, EmailTb.Text.Length);
                errorProvider1.SetError(EmailTb, ex.Message);
            }
        }


        private void NumeTb_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                ValidatingNames();
            }
            catch (Exception ex)
            {
                //utiliz nu poate face submit si se selecteaza email de corectat
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
                //utiliz nu poate face submit si se selecteaza email de corectat
                e.Cancel = true;
                PrenumeTb.Select(0, PrenumeTb.Text.Length);
                errorProvider1.SetError(PrenumeTb, ex.Message);
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
                MessageBox.Show(message, title);
                throw new Exception(message);

            }
            //daca nu gaseste punct sau nu gaseste @ atunci arunca avertis (excep)
            //daca gaseste amandoua f||f = f sare peste excep
            else if(EmailTb.Text.Length != 0 && (EmailTb.Text.IndexOf(".") == -1 || EmailTb.Text.IndexOf("@") == -1) )
            {
                string message = "Email address must be valid address format.";
                string title = "Error";
                MessageBox.Show(message, title);
                throw new Exception(message);
            }
        }

        private void ValidatingNames()
        {
            if (NumeTb.Text.Length == 0 || PrenumeTb.Text.Length == 0 )
            {
                string message = "Last name and First name are required fields.";
                string title = "Error";
                MessageBox.Show(message, title);
                throw new Exception(message);
            }
            else if(NumeTb.Text.Contains("0123456789") || PrenumeTb.Text.Contains("0123456789"))
            {
                string message = "Last name and First name are only character fields.";
                string title = "Error";
                MessageBox.Show(message, title);
                throw new Exception(message);
            }
        }

       

     
    }
}
