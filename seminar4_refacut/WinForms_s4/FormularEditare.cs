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
    public partial class FormularEditare : Form
    {
        Programator buff;       // var locala (vizibila la celelalte comp clasa)
        public FormularEditare(Programator p)
        {
            InitializeComponent();
            buff = p;               //buff(var locala) pointeaza spre aceeasi zona mem ca p
        }

        /// <summary>
        /// inchidem fereastra secundara (editare)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }

        //in oglinda ca la Editare
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            buff.Denumire = tbDenumire.Text;
            buff.Adresa = tbAdresa.Text;
            buff.Varsta = int.Parse(tbVarsta.Text);
            buff.DataAngajarii = dtpAngajat.Value;

            #region salvare index ComboBox incadrare
            int index = comboBoxIncadrare.SelectedIndex;
            if(index == 0)
            {
                buff.Incadrare = EIncadrare.NORMA_INTREAGA;
            }
            if (index == 1)
            {
                buff.Incadrare = EIncadrare.JUMATATE_DE_NORMA;
            }
            if (index == 2)
            {
                buff.Incadrare = EIncadrare.INTERN;
            }
            else
            {
                buff.Incadrare = EIncadrare.CONTRACTOR;
            }
            #endregion

            #region salvare lista Limbaje
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
            if (checkBoxPython.Checked)
            {
                limbaje.Add("Python");
            }
            buff.LimbajeProgramare = limbaje;

            //in functie de cate lb stie
            //se salveaza si se da salariu
            switch (limbaje.Count)
            {
                case 1:
                    buff.Salariu = 4500;
                    break;
                case 2:
                    buff.Salariu = 6500;
                    break;
                case 3:
                    buff.Salariu = 9000;
                    break;
                default:
                    buff.Salariu = 12000;
                    break;
            }
            #endregion

            Close();
            MessageBox.Show("Date salvate cu succes.", "Succes");
        }

        private void FormularEditare_Load(object sender, EventArgs e)
        {
            //preiau datele din formularul principal,
            //le setez pe campurile din form editare
            tbDenumire.Text = buff.Denumire;
            tbAdresa.Text = buff.Adresa;
            tbVarsta.Text = buff.Varsta.ToString();
            dtpAngajat.Text = buff.DataAngajarii.ToString();
            //EIncadrare incadrare = buff.Incadrare;

            if (buff.Incadrare == EIncadrare.NORMA_INTREAGA)
            {
                comboBoxIncadrare.SelectedIndex = 0;
            }
            else if(buff.Incadrare == EIncadrare.JUMATATE_DE_NORMA)
            {
                comboBoxIncadrare.SelectedIndex = 1;
            }
            else if (buff.Incadrare == EIncadrare.INTERN)
            {
                comboBoxIncadrare.SelectedIndex = 2;
            }
            else
            {
                comboBoxIncadrare.SelectedIndex = 3;        //EIncadrare.CONTRACTOR
            }

            //daca lista contine lb de prog
            //seteaza checkbox pe true
            List<string> lista = buff.LimbajeProgramare;
            if (lista.Contains("Java"))
            {
                checkBoxJava.Checked = true;
            }
            if (lista.Contains("Javascript"))
            {
                checkBoxJS.Checked = true;
            }
            if (lista.Contains(".NET"))
            {
                checkBoxDotnet.Checked = true;
            }
            if (lista.Contains("Python"))
            {
                checkBoxPython.Checked = true;
            }

        }
    }
}
