using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bilet_profesor_2016
{
    public partial class Form1 : Form
    {
        public readonly Profesor[] vect = new Profesor[5];       //vect de profesori, date constante => readonly
        private const string ConnectionString = "Data Source=ProfesorDatabase.db";

        public Form1()
        {
            InitializeComponent();
            vect[0] = new Profesor(100, "Popescu Ion", 50.6);
            vect[1] = new Profesor(200, "Ionescu Marcel", 40.5);
            vect[2] = new Profesor(300, "Ciurea Ionut", 80.65);
            vect[3] = new Profesor(400, "Dobrescu Marinela", 70.5);
            vect[4] = new Profesor(500, "Zurie Daniela", 90.78);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        //ex1 populare DGV
        private void populateDataGrid()
        {
            dgv.Rows.Clear();

            foreach (Profesor prof in vect)
            {
                int n = dgv.Rows.Add(new object[]
                {
                    prof.Marca,
                    prof.nume,
                    prof.Salariu
                });

                dgv.Rows[n].Tag = prof;
            }
        }

        //ex4 implem op+ si calcul total salarii profi
        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (Profesor p in vect)
            {
                total = total + p.Salariu;
            }
            textBox1.Text = total.ToString();
        }

        //ex 3 imprimare 
        private void dgv_MouseClick(object sender, MouseEventArgs e)        //implem eveniment de CLICK pe DataGrid => declansa contextMenu
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrint f = new FormPrint(vect);
            f.ShowDialog();                     //afiseaza form ca fereastra modala
        }

        //ex2 salvare in tabela tblProfesor
        private void toBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string querySql = "insert into tblProfesor(Marca, Nume, Salariu)" + 
                                    "values(@marca, @nume, @salariu);" + 
                                    "select last_insert_rowid()";

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var command = new SQLiteCommand(querySql, conn);

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    command.Parameters.AddWithValue("@marca", row.Cells[0].Value);
                    command.Parameters.AddWithValue("@nume", row.Cells[1].Value);
                    command.Parameters.AddWithValue("@salariu", row.Cells[2].Value);

                }
                conn.Close();
            }
        }

        //ex2 editare dgv
        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];      //din colectia dgv(toolbox) imi salvez linia selectata
                Profesor prof = (Profesor)row.Tag;

                FormEdit edit = new FormEdit(prof);             //setat DialoResult pe OK pe un btn din formularSecundar 
                //DialogResult res = edit.ShowDialog();

                if (edit.ShowDialog() == DialogResult.OK)
                {
                    populateDataGrid();
                    toBDToolStripMenuItem_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Alegeti un profesor din dgv.");
            }
        }

        //ex6 accelerator Alt + E
        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.E)
            {
                Close();
            }
        }

        //ex5 interfata IPremiere
    }
}
