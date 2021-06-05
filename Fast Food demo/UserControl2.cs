using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fast_Food_demo.Modele;

namespace Fast_Food_demo
{
    public partial class UserControl2 : UserControl
    {
        List<Items> foodList = new List<Items>();
        string denum = "";
        double total = 0;
        int quantity = 0;


        public UserControl2()
        {
            InitializeComponent();
            FriesAddBtn.Click += new EventHandler(clickedButton);
        }

        private void clickedButton(object sender, EventArgs e)  // ????????? (cantit devine 0 dupa click alt item)
        {


        }

        #region Food btns
        private void FriesAddBtn_Click(object sender, EventArgs e)
        {
            denum = FriesLb.Text;
            double.TryParse(label3.Text, out double price);
            quantity++;
            total += price;     //total isi pastreaza val la multe click

            Items s = new Items(denum, price, quantity);
            addItemToListview(s);
        }

        private void SaladAddBtn_Click(object sender, EventArgs e)
        {

            denum = SaladLb.Text;
            double.TryParse(label7.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity);
            addItemToListview(s);
        }

        private void WingsAddBtn_Click(object sender, EventArgs e)
        {
            denum = WingsLb.Text;
            double.TryParse(label4.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity);
            addItemToListview(s);
        }

        private void HamburgerBtn_Click(object sender, EventArgs e)
        {
            denum = HamburgerLb.Text;
            double.TryParse(label15.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity);
            addItemToListview(s);
        }

        private void CakeBtn_Click(object sender, EventArgs e)
        {
            denum = CakeLb.Text;
            double.TryParse(label11.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity);
            addItemToListview(s);
        }

        private void SodaBtn_Click(object sender, EventArgs e)
        {
            denum = SodaLb.Text;
            double.TryParse(label10.Text, out double price);
            quantity++;
            total += price;

            Items s = new Items(denum, price, quantity);
            addItemToListview(s);
        }
        #endregion

        private void FinaliseBtn_Click(object sender, EventArgs e)
        {
            double t = CalculateTotal();
            TotalPayLb.Text = "€ " + t.ToString();
        }


        #region ListView operations
        private void addItemToListview(Items s)
        {
            foodList.Add(s);

            //curatare lista (componenta c# din dreapta form)
            //evita chei duplicate (bag de mai multe ori acelasi prog)
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

            //adaug item in lista, curat listview
            //creez cate un elem provenit din lista pt listview
            //adaug elem in listview
        }

        private double CalculateTotal()
        {
            double x = 0;
            foreach (Items item in foodList)
            {
                item.Total = total;
                x = item.Total;
            }

            return x;
        }

        #endregion

    }
}
