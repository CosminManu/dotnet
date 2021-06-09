using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Fast_Food_demo.Modele;
using Fast_Food_demo.UserControllers;

namespace Fast_Food_demo
{
    public partial class UserControlOrder : UserControl
    {
        int here, away;
        private const string Connection = "Data Source=OrderDB.db";
        const string querySql = "insert into Orders(Firstname, Lastname, Here, Away)" +
                                   " values (@firstname, @lastname, @here, @away);" +
                                   "select last_insert_rowid()";
        
        public UserControlOrder()
        {
            InitializeComponent();
            
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            if (checkBoxHere.Checked == true)
            {
                here = 1;
                away = 0;
            }
            else if (checkBoxAway.Checked == true)
            {
                here = 0;
                away = 1;
            }

            if (firstname == "" || lastname == "")
            {
                MessageBox.Show("Fill your personal data first!", "Error", MessageBoxButtons.OK);
            }
            else if (checkBoxAway.Checked == true && checkBoxHere.Checked == true)
            {
                MessageBox.Show("Cannot have both options. Please choose one", "Error", MessageBoxButtons.OK);
            }
            else if (checkBoxAway.Checked == false && checkBoxHere.Checked == false)
            {
                MessageBox.Show("Please check if here or away", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Order o = new Order(firstname, lastname, here, away);
                addOrder(o);
            }
            

        }

        #region statusStrip
        private void tbFirstName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusMessage.Text = "Enter your first name.";
        }

        private void tbFirstName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusMessage.Text = "Check if you have food here or take-away.";
        }

        private void tbLastName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusMessage.Text = "Enter your last name.";
        }

        private void tbLastName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusMessage.Text = "Check if you have food here or take-away.";
        }

        private void PayBtn_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusMessage.Text = "Ready to pay?";
        }
        #endregion

        /// <summary>
        /// SQLite connection to add details of an order
        /// to the db
        /// </summary>
        /// <param name="o"></param>
        private void addOrder(Order o)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Connection))
            {
                conn.Open();
                var command = new SQLiteCommand(querySql, conn);
                command.Parameters.AddWithValue("@firstname", o.firstname);
                command.Parameters.AddWithValue("@lastname", o.lastname);
                command.Parameters.AddWithValue("@here", o.here);
                command.Parameters.AddWithValue("@away", o.away);

                o.Id = (long)command.ExecuteScalar();       //noul id ia urm valoare din tabela
                MessageBox.Show("Thank you and enjoy your food!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       /*private void f()
        {
            var clasa = new UserControl2();
            foreach(Items it in clasa.foodList)
            {
                if (it.Denumire == "French Fries")
                {
                    toolStripStatusFries.Text = "French Fries: " + it.Cantitate;
                }
            }
        }*/
    }
}
