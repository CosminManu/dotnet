using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_conferinta_paw
{
    public partial class FormEditare : Form
    {
        Lucrari lucrare;                // var locala (vizibila la celelalte comp clasa)
        public FormEditare(Lucrari l)
        {
            InitializeComponent();
            lucrare = l;
        }

        private void FormEditare_Load(object sender, EventArgs e)
        {
            textBox1.Text = lucrare.CodL.ToString();
            textBox2.Text = lucrare.DenumL;
            textBox3.Text = lucrare.Sectiune.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lucrare.CodL = Convert.ToInt32(textBox1.Text);          //ce modific setez in var locala
            lucrare.DenumL = textBox2.Text;
            lucrare.Sectiune = Convert.ToInt32(textBox3.Text);

            Close();
            MessageBox.Show("date salvate cu succes");
        }
    }
}
