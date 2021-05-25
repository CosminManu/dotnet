using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_s4.Modele;

namespace WinForms_s4
{
    public partial class FormularPrincipal : Form
    {
        List<Programator> listaProg = new List<Programator>();     // lista ob in care stocam instantele de obiecte
                                                                   //create din formular

        public FormularPrincipal()
        {
            InitializeComponent();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            CurataFormular();
        }

        //met se poate apela oricand avem nevoie de ea
        private void CurataFormular()
        {
            tbDenumire.Clear();
            tbAdresa.Clear();       //tbAdresa.Text = String.Empty;
            tbVarsta.Clear();

            dtpAngajat.Value = DateTime.Now;    //reseteaza la data si ora curenta
            checkBoxDotnet.Checked = false;
            checkBoxJava.Checked = false;
            checkBoxJS.Checked = false;
            checkBoxPython.Checked = false;

            comboBoxIncadrare.SelectedIndex = -1;
           // return an int (index) care nu se afla in enum
        }

        #region CRUD  
        /// <summary>
        /// partea de CREATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool valid = true;                      // form valid initial (flag)
            string Denumire = tbDenumire.Text;      //ia inf de la textbox Denumire 
            
            //verif daca stringul meu e null, gol sau are lungimea <2
            if(string.IsNullOrEmpty(Denumire) || string.IsNullOrWhiteSpace(Denumire)
                || Denumire.Length < 2)
            {
                valid = false;
            }

            //La valid = false se poate afisa casuta cu mesaj de err
            //messageErrBox
            // Parsare
            try
            {
                int _Varsta = int.Parse(tbVarsta.Text);      
                //converteste reprez text la nr intreg 32bit
                //necesara inconjurare try-catch (FormatException)
            }
            catch (Exception ex)
            {
                valid = false;
            }

            // TryParse
            int.TryParse(tbVarsta.Text, out int varsta);
            if(varsta == 0 || varsta <= 16)
            {
                valid = false;
            }

            DateTime dataAngajarii = dtpAngajat.Value;
            if (DateTime.Compare(dataAngajarii, DateTime.Now) > 0)  
                //daca data ang > data actuala 
            {
                valid = false;
            }

            int IndexIncadrare = comboBoxIncadrare.SelectedIndex;
            EIncadrare inc;                             // val by default
            if(IndexIncadrare == 0)
                inc = EIncadrare.NORMA_INTREAGA;
            else if (IndexIncadrare == 1)
                inc = EIncadrare.JUMATATE_DE_NORMA;
            else if (IndexIncadrare == 2)
                inc = EIncadrare.INTERN;
            else
                inc = EIncadrare.CONTRACTOR;

            List<String> limbaje = new List<string>();
            if (checkBoxJava.Checked)
            {
                limbaje.Add("Java");
            }
            if (checkBoxDotnet.Checked)
            {
                limbaje.Add(".NET");
            }
            if (checkBoxJS.Checked)
            {
                limbaje.Add("Javascript");
            }
            if(checkBoxPython.Checked)
            {
                limbaje.Add("Python");
            }

            // VALIDARI
            if (valid)
             {
                Programator p = new Programator(Denumire, varsta, 
                    tbAdresa.Text, dataAngajarii, inc, limbaje);

                //adaugare in  listaProg (var in clasa) clasa Collections
                //pt a popula apoi componenta c#
                listaProg.Add(p);

                //curatare lista (componenta c# din dreapta form)
                //evita chei duplicate (bag de mai multe ori acelasi prog)
                lvProgramatori.Items.Clear();

                //pt fiecare prog din lista de programatori (var in clasa)
                //adauga in lista de prog 'lvProg' (componenta de c#)
                foreach(Programator prog in listaProg)
                {
                    ListViewItem lwi = new ListViewItem(new String[] 
                    {
                        prog.Denumire, 
                        prog.Varsta.ToString(), 
                        prog.Salariu.ToString() 
                    });

                    lvProgramatori.Items.Add(lwi);   
                }

                populeazaListView();
                CurataFormular();
                MessageBox.Show("Programator introdus. ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else
            {
                MessageBox.Show("Formularul contine erori. ", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;
            }

        }

        // READ
        //citesc din lista si pun in listview
        //se poate apela dupa creare/stergere/update de instante
        //pt a repopula lv
        private void populeazaListView()
        {
            //curatare lista (componenta c# din dreapta form)
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
                // 3 pt ca atat contine listview

                lvProgramatori.Items.Add(lwi);
            }

        }

        //UPDATE 
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (lvProgramatori.SelectedItems.Count != 0)
            {
                Programator p = listaProg.ElementAt(lvProgramatori.SelectedIndices[0]);
                //selectez primul prog din listview selectat de user(cu indicele 0)

                //creez instaanta de formular editare
                //trecand ca param Programator p
                FormularEditare edit = new FormularEditare(p);      
                DialogResult dialogRes = edit.ShowDialog();

                //daca s a deschis cu succes
                if(dialogRes == DialogResult.OK)
                {
                    populeazaListView();
                } 
            }
            else if(lvProgramatori.Items.Count == 0)
            {
                MessageBox.Show("Lista nu contine instante","Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Alegeti un programator din lista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        //DELETE
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvProgramatori.SelectedItems.Count != 0)
            {
                //ma asigur ca e de acord cu stergerea
                if (DialogResult.Yes == MessageBox.Show("Doresti sa stergi instanta?", "Stergere programator", MessageBoxButtons.YesNo))
                {
                    listaProg.RemoveAt(lvProgramatori.SelectedIndices[0]);    //sterge din variab lista programat din listview

                    /*Programator p = lvProgramatori.SelectedItems[0].Tag as Programator;     //alternativa la indices
                    listaProg.Remove(p);*/

                    populeazaListView();
                    //citeste in list view
                }
            }
            else if (lvProgramatori.Items.Count == 0)
            {
                MessageBox.Show("Lista nu contine instante", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Alegeti un programator din lista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region ValidateAdresa
        private void tbAdresa_Validated(object sender, EventArgs e)
        {
            epAdresa.Clear();
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            String adresa = tbAdresa.Text;

            if (String.IsNullOrEmpty(adresa) || String.IsNullOrWhiteSpace(adresa) || adresa.Length < 3)
            {
                epAdresa.SetError((Control)sender, "Addresa > 3 caractere.");
                e.Cancel = true;
            }
        }


        #endregion


        #region ContextMenu
        private void lvProgramatori_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        //dublu clk se intra pe editare
        private void lvProgramatori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && lvProgramatori.FocusedItem.Bounds.Contains(e.Location))
            {
                btnEditeaza_Click(sender, e);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }
        #endregion

        
    }
}
