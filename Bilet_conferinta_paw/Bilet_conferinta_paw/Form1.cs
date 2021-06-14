using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bilet_conferinta_paw
{
    public partial class Form1 : Form
    {
        List<Lucrari> lstLucrari = new List<Lucrari>();         //lista de ob in care stocam instantele create
        List<Sectiuni> lstSectiuni = new List<Sectiuni>();


        public Form1()
        {
            InitializeComponent();
        }

        //ex2 citiri fisier, populare Lvi si Cb
        public void citireFisierLucrari()
        {
            StreamReader sr = new StreamReader("lucrari.dat");      //creat prealabil Notepad, salvat bin\Debug
            string linie = "";
            char[] delimitator = { ',' };       // virgula = 1 char

            while (true)
            {
                linie = sr.ReadLine();
                if (linie == null)
                    break;
                string[] valori = linie.Split(delimitator);         //din linie delimitez val pana la virgula, intorduc in array
                Lucrari lucrare = new Lucrari(Convert.ToInt32(valori[0]), valori[1], Convert.ToInt32(valori[2]));
                lstLucrari.Add(lucrare);            //adaug in lista (comp C#)
            }
            sr.Close();
        }

        public void citireFisierSectiuni()
        {
            StreamReader sr = new StreamReader("sectiuni.dat");
            string linie = "";
            char[] delimitator = { ',' };       // virgula = 1 char

            while (true)
            {
                linie = sr.ReadLine();
                if(linie == null)
                {
                    break;
                }
                string[] valori = linie.Split(delimitator);
                Sectiuni sectiune = new Sectiuni(Convert.ToInt32(valori[0]), valori[1]);
                lstSectiuni.Add(sectiune);

            }
            sr.Close();
        }

        public void populareLucrariInListView()
        {
            foreach (Lucrari luc in lstLucrari)
            {
                ListViewItem lwi = new ListViewItem(new String[]
                {
                    luc.CodL.ToString(),
                    luc.DenumL,
                    luc.Sectiune.ToString()
                });
                lviLucrari.Items.Add(lwi);
            }
        }

        public void populareSectiuni()
        {
            foreach (Sectiuni sec in lstSectiuni)
            {
                cbSectiuni.Items.Add(sec.DenumS);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            citireFisierLucrari();
            populareLucrariInListView();
            citireFisierSectiuni();
            populareSectiuni();

        }

        //ex3 editare lucrare form secundar
        private void lviLucrari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lviLucrari.FocusedItem.Bounds.Contains(e.Location))
            {
                editareLucrare();
            }
        }

        private void editareLucrare()
        {
            if (lviLucrari.SelectedItems.Count != 0)        // daca lista contine lucrari
            {
                Lucrari l = lstLucrari.ElementAt(lviLucrari.SelectedIndices[0]);    //creeaza prima lucrare sel de mine din lvi

                FormEditare edit = new FormEditare(l);
                DialogResult d = edit.ShowDialog();

                if (d == DialogResult.OK)
                {
                    lviLucrari.Items.Clear();       //sterg elem din ListView si apoi repopuleaza
                    populareLucrariInListView();
                }

            }
            else if (lviLucrari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lista nu contine lucrari", "Eroare");
            }
            else
            {
                MessageBox.Show("Nu s-a selectat o lucrare.", "Eroare");
            }
        }
    }
}
