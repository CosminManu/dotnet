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
    public partial class EditFoodForm : Form
    {
        Items buff;       // var locala (vizibila la celelalte comp clasa)
        public EditFoodForm(Items s)
        {
            InitializeComponent();
            buff = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }

        // Items <- EFood
        //buff de tip Items => tip efood => contine incadrari cbbox

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int n = comboBox1.SelectedIndex;
            if(n == 0)
            {
                buff.efood = EFood.french_fries;
                buff.Denumire = "French Fries";
                buff.Cantitate++;
                buff.Pret = 3.5;
            }
            else if(n == 1)
            {
                buff.efood = EFood.hamburger;
                buff.Denumire = "Hamburger";
                buff.Cantitate++;
                buff.Pret = 5.5;
            }
            else if (n == 2)
            {
                buff.efood = EFood.salad_box;
                buff.Denumire = "Salad Box";
                buff.Cantitate++;
                buff.Pret = 7;
            }
            else if (n == 3)
            {
                buff.efood = EFood.soda;
                buff.Denumire = "Soda";
                buff.Cantitate++;
                buff.Pret = 2;
            }
            else if (n == 4)
            {
                buff.efood = EFood.hot_wings;
                buff.Denumire = "Hot Wings";
                buff.Cantitate++;
                buff.Pret = 6.5;
            }
            else
            {
                buff.efood = EFood.choco_cake;
                buff.Denumire = "Choco Cake";
                buff.Cantitate++;
                buff.Pret = 12;
            }


            MessageBox.Show("Data saved succesfully.", "Succes");
            Close();
        }
    }
}
