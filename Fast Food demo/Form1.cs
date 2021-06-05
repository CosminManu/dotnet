using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fast_Food_demo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// boolean si Point pt moveForm
        /// </summary>
        bool drag = false;
        Point startPoint = new Point(0, 0);

        public Form1()
        {

            InitializeComponent();
            customizeDesign();                      //ascunde toate submeniurile
            SidePanel.Height = HomeBtn.Height;      //inaltimea sideP aceeasi ca buton home
            SidePanel.Top = HomeBtn.Top; 
            this.WindowState = FormWindowState.Normal;
            
            UserControl1 uc = new UserControl1();
            PanelUserControl.Controls.Add(uc);

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            SidePanel.Height = HomeBtn.Height;      //inaltimea sideP aceeasi ca buton home
            SidePanel.Top = HomeBtn.Top;

            UserControl1 uc = new UserControl1();   //aduce in fata UserControl1 la click pe btn
            PanelUserControl.Controls.Clear();      //curata panelul
            PanelUserControl.Controls.Add(uc);      //adauga Controlul1


        }

        private void EatInBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            SidePanel.Height = EatInBtn.Height;      //inaltimea sideP aceeasi ca buton 
            SidePanel.Top = EatInBtn.Top;

            UserControl2 uc2 = new UserControl2();  //aduce in fata UserControl2 la click pe btn
            PanelUserControl.Controls.Clear();      //curata panelul
            PanelUserControl.Controls.Add(uc2);     //adauga Controlul2

            
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            SidePanel.Height = OrderBtn.Height;      //inaltimea sideP aceeasi ca buton 
            SidePanel.Top = OrderBtn.Top;

            
        }

        private void DeliveryBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            SidePanel.Height = DeliveryBtn.Height;      //inaltimea sideP aceeasi ca buton 
            SidePanel.Top = DeliveryBtn.Top;


        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            SidePanel.Height = PaymentBtn.Height;      //inaltimea sideP aceeasi ca buton
            SidePanel.Top = PaymentBtn.Top;
            showSubMenu(panelSubMenuPayment);         //afis submeniul de la Payment
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            SidePanel.Height = AccountBtn.Height;      //inaltimea sideP aceeasi ca buton
            SidePanel.Top = AccountBtn.Top;

            UserControlAccount ucAC = new UserControlAccount();  //aduce in fata UserControl2 la click pe btn
            PanelUserControl.Controls.Clear();      //curata panelul
            PanelUserControl.Controls.Add(ucAC);     //adauga Controlul2

        }

        private void CashPayBtn_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void CardPayBtn_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
            //normal size when application starts
        }

        #region HideShow Submenus
        /// <summary>
        /// at beginning all submenus are hidden
        /// </summary>
        private void customizeDesign()
        {
            panelSubMenuPayment.Visible = false;
            //la fel si pt celelalte submeniuri
        }

        /// <summary>
        /// Hides all submenus
        /// </summary>
        private void hideSubMenu()
        {
            if (panelSubMenuPayment.Visible == true)
                panelSubMenuPayment.Visible = false;
        }

        /// <summary>
        /// show sub menu fct
        /// when 1 is already opened, all must become closed ->hideSubMenu()
        /// and then open the neccessary ones
        /// </summary>
        /// <param name="subMenu"></param>
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();                 //if submenu(param) is not visible, we hide all other subMenus
                subMenu.Visible = true;        //show the subMenu(param)
            }
            else
                subMenu.Visible = false;       //subMenus remains closed
        }
        #endregion


        #region CloseMaxMinim Form1
        /// <summary>
        /// implementare inchidere fereastra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// normal -> minimized -> normal
        /// maximized -> minimized -> maximized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;
            else if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// doesn t work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }
        #endregion


        #region MoveForm
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void userControl11_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void userControl11_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void userControl11_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion

        #region Social btns
        private void TripAdvisorBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.tripadvisor.com");
        }

        private void FbBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com");
        }

        private void InstaBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com");
        }
        #endregion
    }
}
