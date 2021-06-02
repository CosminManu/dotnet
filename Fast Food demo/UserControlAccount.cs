using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fast_Food_demo.Modele;

namespace Fast_Food_demo
{
    public partial class UserControlAccount : UserControl
    {
        List<Customer> listaClienti = new List<Customer>();

        public UserControlAccount()
        {
            InitializeComponent();
        }


        /// <summary>
        /// op CREATE
        /// adauga instanta si salveaza undeva in spate
        /// la o conexiune SqlLite idk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool valid = true;                      
            string Nume = tbNume.Text;              //last Name (nume familie)
            string Prenume = tbPrenume.Text;        //first Name
            string Email = tbEmail.Text;
            string UserName = tbUsername.Text;
            string Password = tbPassword.Text;
            

            int number = 0;

            if (string.IsNullOrEmpty(Prenume) || string.IsNullOrWhiteSpace(Prenume))
            {
                valid = false;
                MessageBox.Show("Please fill first name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (valid)
            {
                for (int i = 0; i < Prenume.Length; i++)        //loopeaza in fiec carac al prenumelui
                {
                    if (char.IsNumber(Prenume[i]))
                    {
                        valid = false;
                        MessageBox.Show("First name contains digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (string.IsNullOrEmpty(Nume) || string.IsNullOrWhiteSpace(Nume))
            {
                valid = false;
                MessageBox.Show("Please fill last name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (valid)
            {
                for(int i = 0; i < Nume.Length; i++)        //loopeaza in fiec carac al numelui
                {
                    if (char.IsNumber(Nume[i]))
                    {
                        valid = false;
                        MessageBox.Show("Last name contains digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            if (string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Email))
            {
                valid = false;
                MessageBox.Show("Please fill email address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbEmail.Text.IndexOf(".") == -1 || tbEmail.Text.IndexOf("@") == -1)
            {
                valid = false;
                string message = "Email address must be valid address format." + "\nFor example: 'someone@example.com'";
                string title = "Error";
                MessageBox.Show(message, title);
            }

            DateTime birthDate = dtpBirth.Value;
            if (DateTime.Compare(birthDate, DateTime.Now) > 0)
            //daca birthDate > data actuala 
            {
                valid = false;
                MessageBox.Show("Please select your corect birth date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (string.IsNullOrEmpty(UserName) || string.IsNullOrWhiteSpace(UserName))
            {
                valid = false;
                MessageBox.Show("Please fill your username ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password))
            {
                valid = false;
                MessageBox.Show("Please fill your password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
     
            if (valid)
            {
                Customer c = new Customer(Nume, Prenume,
                    Email, birthDate, UserName, Password);
                //adaugare in  listaProg (var in clasa) clasa Collections
                //pt a popula apoi componenta c#
                listaClienti.Add(c);

                //implementare ca in seminar cu lvi in dreapta
                //sau salvare inf introduse in spate pe o baza de date






                MessageBox.Show("User information added ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

        }
        
        //nu e gata
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.ShowDialog();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            tbNume.Clear();
            tbPrenume.Clear();
            tbEmail.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            dtpBirth.Value = DateTime.Now;
        }
    }
}
