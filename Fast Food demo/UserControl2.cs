using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fast_Food_demo.Modele;
using System.Data.SQLite;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;
using Fast_Food_demo.UserControllers;

namespace Fast_Food_demo.UserControllers
{
    public partial class UserControl2 : UserControl
    {
        //private const string Connection = "Data Source=ItemsDB.db";
        public List<Items> foodList = new List<Items>();
        string denum = "";
        double total = 0;
        int quantity = 0;


        public UserControl2()
        {
            InitializeComponent();
        }

        #region Food btns
        private void FriesAddBtn_Click(object sender, EventArgs e)
        {
            denum = FriesLb.Text;
            double.TryParse(label3.Text, out double price);
            quantity++;
            total += price;     //total isi pastreaza val la multe click

            Items s = new Items(denum, price, quantity, total);
            addItemToListview(s);
        }

        private void SaladAddBtn_Click(object sender, EventArgs e)
        {

            denum = SaladLb.Text;
            double.TryParse(label7.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity, total);
            addItemToListview(s);
        }

        private void WingsAddBtn_Click(object sender, EventArgs e)
        {
            denum = WingsLb.Text;
            double.TryParse(label4.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity, total);
            addItemToListview(s);
        }

        private void HamburgerBtn_Click(object sender, EventArgs e)
        {
            denum = HamburgerLb.Text;
            double.TryParse(label15.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity, total);
            addItemToListview(s);
        }

        private void CakeBtn_Click(object sender, EventArgs e)
        {
            denum = CakeLb.Text;
            double.TryParse(label11.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity, total);
            addItemToListview(s);
        }

        private void SodaBtn_Click(object sender, EventArgs e)
        {
            denum = SodaLb.Text;
            double.TryParse(label10.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity, total);
            addItemToListview(s);
        }
        #endregion


        #region ListView CRUD operations
        private void FinaliseBtn_Click(object sender, EventArgs e)
        {
            
            CalculateTotal();
            if(FoodListView.Items.Count != 0)
            {
                MessageBox.Show("Proceed to Order Part on the left side of the app", "Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There are no items in your food command. \nPlease choose your meal first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CREATE
        private void addItemToListview(Items s)
        {
            foodList.Add(s);
            FoodListView.Items.Clear();

            foreach (Items item in foodList)
            {
                ListViewItem lv = new ListViewItem(new String[]
                {
                    item.Cantitate.ToString(),
                    item.Denumire,
                    item.Pret.ToString()
                });

                FoodListView.Items.Add(lv);
                
            }

            populateItemToListView();
            CalculateTotal();
            //adaug item in lista, curat listview
            //creez cate un elem provenit din lista pt listview
            //adaug elem in listview

        }

        private void CalculateTotal()
        {
            double x = 0;
            foreach (Items item in foodList)
            {
                x += item.Pret;
            }

            populateItemToListView();
            TotalPayLb.Text = "€ " + x.ToString();
        }

        //READ
        private void populateItemToListView()
        {
            FoodListView.Items.Clear();

            foreach (Items item in foodList)
            {
                ListViewItem lv = new ListViewItem(new String[]
                {
                    item.Cantitate.ToString(),
                    item.Denumire,
                    item.Pret.ToString()
                });

                FoodListView.Items.Add(lv);
            }
        }

        //UPDATE
        private void EditItemToListView()
        {
            if (FoodListView.SelectedItems.Count != 0)      //daca am sel item din lvi
            {
                Items s = foodList.ElementAt(FoodListView.SelectedIndices[0]);      //imi ia obiectul din lista conform ce am sel

                EditFoodForm editare = new EditFoodForm(s);
                DialogResult dialogRes = editare.ShowDialog();

                if(dialogRes == DialogResult.OK)         // daca toata editarea a decurs cu succes READ DIN LISTA
                {
                    populateItemToListView();
                }
                else if (FoodListView.Items.Count == 0)          //daca nu sunt elem in lvi
                {
                    MessageBox.Show("There are no items in your food command.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("You need to choose an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //DELETE
        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            if(FoodListView.SelectedItems.Count != 0)       //daca am ales un item
            {
                if (DialogResult.Yes == MessageBox.Show("Do you wish to delete following item from list?", "Delete food", MessageBoxButtons.YesNo))
                {
                    foodList.RemoveAt(FoodListView.SelectedIndices[0]);
                    populateItemToListView();
                    CalculateTotal(); 
                }
            }
            else if(FoodListView.Items.Count == 0)          //daca nu sunt elem in lvi
            {
                MessageBox.Show("There are no items in your food command.",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("You need to choose an item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region ContextMenu
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItemToListView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItemBtn_Click(sender, e);     
        }

        private void FoodListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmstrip.Show(Cursor.Position.X, Cursor.Position.Y);     //afiseaza cmstrip in func de coord X si Y
            }
        }

        #endregion

        #region XML
        private void serialiseXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Items>));      //ctor fara parametri!
            FileStream stream = File.Create("newList.xml");
            serializer.Serialize(stream, foodList);
            stream.Close();
            MessageBox.Show("newList.xml file succesfully created.", "Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deserializeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Items>));

            try
            {
                FileStream stream = File.OpenRead("newList.xml");
                foodList = serializer.Deserialize(stream) as List<Items>;
                stream.Close();
                populateItemToListView();
                MessageBox.Show("Deserializzation of xml file succesfull.", "Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region TXT file
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save text file";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName);
                writer.Write("Denumire Cantitate Pret\n");

                foreach (Items it in foodList)
                {
                    writer.WriteLine(it.Denumire + " " + it.Cantitate + " " + it.Pret);
                }
                writer.Close();
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantitate_;
            double pret_;
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select your text file for import";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FoodListView.Items.Clear();
                foodList.Clear();

                StreamReader reader = new StreamReader(ofd.FileName);
                string line = reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        String[] tokens = line.Split(' ');

                        String denumire = tokens[0];

                        if(denumire == "French" || denumire == "Salad" || denumire == "Hot" || denumire == "Choco")
                        {
                            int.TryParse(tokens[2], out int cantitate);
                            cantitate_ = cantitate;
                            double.TryParse(tokens[3], out double pret);
                            pret_ = pret;
                        }
                        else
                        {
                            int.TryParse(tokens[1], out int cantitate);
                            cantitate_ = cantitate;
                            double.TryParse(tokens[2], out double pret);
                            pret_ = pret;
                        }
                        

                        Items i = new Items();
                        i.Denumire = denumire;
                        i.Cantitate = cantitate_;
                        i.Pret = pret_;

                        foodList.Add(i);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                reader.Close();
                populateItemToListView();
                CalculateTotal();
            }
        }
        #endregion

        #region Printing
        private void toolStripBtnPrint_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Consolas", 20);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);

            PageSettings settings = printDocument1.DefaultPageSettings;

            var totalDrawableWidth = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalDrawableHeight = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalDrawableWidth;
                totalDrawableWidth = totalDrawableHeight;
                totalDrawableHeight = temp;
            }

            int cellWidth = totalDrawableWidth / 2;
            int cellHeight = 40;

            int x = settings.Margins.Left;
            int y = 100;

            graphics.DrawString("Billing Receipt", font, brush, totalDrawableWidth / 3, y);

            y += 100;

            // desenare format cap de tabel
            graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
            graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);

            // desenare continut cap de tabel
            graphics.DrawString("Name", font, brush, x, y);
            graphics.DrawString("Price", font, brush, x + cellWidth, y);
            graphics.DrawString("Total", font, brush, x + cellWidth * 2, y);

            y += cellHeight;

            foreach (Items i in foodList)
            {
                // desenare celule
                graphics.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth, y, cellWidth, cellHeight);
                graphics.DrawRectangle(pen, x + cellWidth * 2, y, cellWidth, cellHeight);

                // desenare continut celule
                graphics.DrawString(i.Denumire, font, brush, x, y);
                graphics.DrawString(i.Pret.ToString(), font, brush, x + cellWidth, y);
                graphics.DrawString("€" + i.Total.ToString(), font, brush, x + cellWidth * 2, y);
                y += cellHeight;
            }
        }

        #endregion
    }
}
