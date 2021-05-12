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
        bool valid = true;
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
            
            panel1.BackColor = Color.FromArgb(235, 48, 14);
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            errorProvider1.SetError(NameTb, "");
            NameTb.Clear();
        }

        private void PrenumeTb_Click(object sender, EventArgs e)
        {
           
            panel2.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            errorProvider1.SetError(PrenumeTb, "");
            PrenumeTb.Clear();
        }

        private void EmailTb_Click(object sender, EventArgs e)
        {
            
            panel3.BackColor = Color.FromArgb(235, 48, 14);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;

            //daca totul e ok, setez errProv pe ""
            errorProvider1.SetError(EmailTb, "");
            EmailTb.Clear();
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


        private void NameTb_Validating(object sender, CancelEventArgs e)
        {
            /*if(valid == false)
            {
                e.Cancel = true;
                errorProvider1.SetError(EmailTb, "Last name and First name are required fields.");
            }*/
        }

        private void PrenumeTb_Validating(object sender, CancelEventArgs e)
        {

        }


        //merg pe caz naspa, cand arunc avertismente (throw excep)
        private void ValidatingCode()
        {
            //daca nu s a introd nimic
            if(EmailTb.Text.Length == 0)
            {
                string message = "Email address is a required field.";
                string title = "Error";
                MessageBox.Show(message, title);
                throw new Exception(message);

            }
            //daca nu gaseste punct sau nu gaseste @ at arunca avertis (excep)
            //daca gaseste amandoua f||f = f sare peste excep
            else if(EmailTb.Text.IndexOf(".") == -1 || EmailTb.Text.IndexOf("@") == -1)
            {
                string message = "Email address must be valid address format." + "\nFor example: 'someone@example.com'";
                string title = "Error";
                MessageBox.Show(message, title);
                throw new Exception(message);
            }

            /*if(NameTb.Text.Length == 0 || PrenumeTb.Text.Length == 0)
            {
                string message = "Last name and First name are required fields.";
                string title = "Error";
                MessageBox.Show(message, title);
                valid = false;
                throw new Exception(message);
            }*/
        }

       

     
    }
}
