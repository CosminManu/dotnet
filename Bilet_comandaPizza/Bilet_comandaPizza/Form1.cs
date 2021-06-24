using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_comandaPizza
{
    public partial class Form1 : Form
    {
        List<ComandaPizza> listaComenzi = new List<ComandaPizza>();
        bool valid = true;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            tbNume.Clear();
            tbDurata.Clear();
            cbBlat.SelectedIndex = -1;
            listView1.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string blat = "";
            int durata = Convert.ToInt32(tbDurata.Text);
            try
            {
                if (string.IsNullOrWhiteSpace(tbNume.Text))
                {
                    valid = false;
                    MessageBox.Show("Nume e un camp obligatoriu");
                    throw new Exception("Nume e un camp obligatoriu");
                }
                else if (tbNume.Text.Any(c => c < 47 && c > 34))
                {
                    valid = false;
                    MessageBox.Show("Nume nu poate contine caractere speciale( # $ etc)");
                    throw new Exception("Nume nu poate contine caractere speciale( # $ etc)");
                }
                else
                {
                    nume = tbNume.Text;
                }

                if (tbDurata.Text == "")
                {
                    valid = false;
                    MessageBox.Show("Durata e un camp obligatoriu");
                    throw new Exception("Durata e un camp obligatoriu");
                }
                else
                {
                    durata = Convert.ToInt32(tbDurata.Text);
                }

                int index = cbBlat.SelectedIndex;
                if (index == 0)
                    blat = cbBlat.SelectedItem.ToString();
                else if (index == 1)
                    blat = cbBlat.SelectedItem.ToString();
                else if (index == 2)
                    blat = cbBlat.SelectedItem.ToString();
                else if (index == 3)
                    blat = cbBlat.SelectedItem.ToString();
                else
                    valid = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Form contains errors!");
            }

            if (valid)
            {
                ComandaPizza c = new ComandaPizza(nume, blat, durata);
                listaComenzi.Add(c);
            }
         
        }
    }
}
