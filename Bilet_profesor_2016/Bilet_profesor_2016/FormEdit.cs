using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_profesor_2016
{
    public partial class FormEdit : Form
    {
        Profesor prof;
        public FormEdit(Profesor profPrimit)
        {
            InitializeComponent();
            prof = profPrimit;
        }
        private void FormEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = prof.Marca.ToString();
            textBox2.Text = prof.nume;
            textBox3.Text = prof.Salariu.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            prof.Marca = Convert.ToInt32(textBox1.Text);
            prof.nume = textBox2.Text;
            prof.Salariu = Convert.ToDouble(textBox3.Text);
            Close();
            MessageBox.Show("Editare cu succes");
        }

        
    }
}
