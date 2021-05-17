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
            bool valid = true;                      // form valid initial (flag)
            string Nume = tbNume.Text;      //ia inf de la textbox Denumire 
            string Prenume = tbPrenume.Text;
            string Email = tbEmail.Text;
            string UserName = tbUsername.Text;
            string Password = tbPassword.Text;

           
            if (string.IsNullOrEmpty(Nume) || string.IsNullOrWhiteSpace(Nume))
            {
                valid = false;
                MessageBox.Show("Please fill first name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(Prenume) || string.IsNullOrWhiteSpace(Prenume))
            {
                valid = false;
                MessageBox.Show("Please fill last name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Email))
            {
                valid = false;
                MessageBox.Show("Please fill email address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Email))
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
            else if (string.IsNullOrEmpty(UserName) || string.IsNullOrWhiteSpace(UserName))
            {
                valid = false;
                MessageBox.Show("Please fill your username ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password))
            {
                valid = false;
                MessageBox.Show("Please fill your password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int IndexIncadrare = comboBoxVarsta.SelectedIndex;
            EVarsta inc;                             // val by default
            if (IndexIncadrare == 0)
                inc = EVarsta.less_16_years;
            else if (IndexIncadrare == 1)
                inc = EVarsta.between_16_21_years;
            else
                inc = EVarsta.over_21_years;


            // VALIDARI
            if (valid)
            {
                Customer c = new Customer(Nume, Prenume,
                    Email, inc, UserName, Password);
                //adaugare in  listaProg (var in clasa) clasa Collections
                //pt a popula apoi componenta c#
                listaClienti.Add(c);

                /*//curatare lista (componenta c# din dreapta form)
                //evita chei duplicate (bag de mai multe ori acelasi prog)
                lvProgramatori.Items.Clear();

                //pt fiecare prog din lista de programatori (var in clasa)
                //adauga in lista de prog 'lvProg' (componenta de c#)
                foreach (Programator prog in listaProg)
                {
                    ListViewItem lwi = new ListViewItem(new String[]
                    {
                        prog.Denumire,
                        prog.Varsta.ToString(),
                        prog.Salariu.ToString()
                    });

                    lvProgramatori.Items.Add(lwi);
                }

                populeazaListView();*/
                MessageBox.Show("User information added ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        
            
        }
        
        //nu e gata
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
        }
    }
}
