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
    public partial class FormPrint : Form
    {
        public readonly Profesor[] vect;
        public FormPrint(Profesor[] vPrimit)
        {
            InitializeComponent();
            vect = vPrimit;
        }

        private void FormPrint_Load(object sender, EventArgs e)     //la incarcarea formularului printare afis inf in textbox
        {
            foreach (Profesor prof in vect)
            {
                textBox1.Text += prof.Marca + " " + prof.nume + " " + prof.Salariu + "\r\n";
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)       // la PageSetup tb proprietatea de PrintDocument
        {                                                                               // la textBox => propr Multiline true
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;       //a = b

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;   // b = a
            }
        }


        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
                printPreviewControl1.Document = printDocument;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview." +
                    " Make sure you currently have access to a printer.");
            }
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font("Georgia", 20, FontStyle.Bold), Brushes.Black, 10, 10);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);
        }

        
    }
}
