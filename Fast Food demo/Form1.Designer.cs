namespace Fast_Food_demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSubMenuPayment = new System.Windows.Forms.Panel();
            this.CardPayBtn = new System.Windows.Forms.Button();
            this.CashPayBtn = new System.Windows.Forms.Button();
            this.panelSubMenuEatIn = new System.Windows.Forms.Panel();
            this.SaladsBtn = new System.Windows.Forms.Button();
            this.DessertBtn = new System.Windows.Forms.Button();
            this.DrinksBtn = new System.Windows.Forms.Button();
            this.MealBtn = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.DeliveryBtn = new System.Windows.Forms.Button();
            this.EatInBtn = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FbBtn = new System.Windows.Forms.Button();
            this.TripAdvisorBtn = new System.Windows.Forms.Button();
            this.InstaBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.PrintingBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelUserControl = new System.Windows.Forms.Panel();
            this.ItemsListView = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinaliseBtn = new System.Windows.Forms.Button();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.panelSubMenuPayment.SuspendLayout();
            this.panelSubMenuEatIn.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubMenuPayment
            // 
            this.panelSubMenuPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelSubMenuPayment.Controls.Add(this.CardPayBtn);
            this.panelSubMenuPayment.Controls.Add(this.CashPayBtn);
            this.panelSubMenuPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPayment.Location = new System.Drawing.Point(0, 402);
            this.panelSubMenuPayment.Name = "panelSubMenuPayment";
            this.panelSubMenuPayment.Size = new System.Drawing.Size(222, 62);
            this.panelSubMenuPayment.TabIndex = 13;
            // 
            // CardPayBtn
            // 
            this.CardPayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CardPayBtn.FlatAppearance.BorderSize = 0;
            this.CardPayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardPayBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPayBtn.ForeColor = System.Drawing.Color.White;
            this.CardPayBtn.Location = new System.Drawing.Point(0, 34);
            this.CardPayBtn.Name = "CardPayBtn";
            this.CardPayBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CardPayBtn.Size = new System.Drawing.Size(222, 29);
            this.CardPayBtn.TabIndex = 3;
            this.CardPayBtn.Text = "Card";
            this.CardPayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CardPayBtn.UseVisualStyleBackColor = true;
            this.CardPayBtn.Click += new System.EventHandler(this.CardPayBtn_Click);
            // 
            // CashPayBtn
            // 
            this.CashPayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CashPayBtn.FlatAppearance.BorderSize = 0;
            this.CashPayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashPayBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPayBtn.ForeColor = System.Drawing.Color.White;
            this.CashPayBtn.Location = new System.Drawing.Point(0, 0);
            this.CashPayBtn.Name = "CashPayBtn";
            this.CashPayBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CashPayBtn.Size = new System.Drawing.Size(222, 34);
            this.CashPayBtn.TabIndex = 1;
            this.CashPayBtn.Text = "Cash";
            this.CashPayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CashPayBtn.UseVisualStyleBackColor = true;
            this.CashPayBtn.Click += new System.EventHandler(this.CashPayBtn_Click);
            // 
            // panelSubMenuEatIn
            // 
            this.panelSubMenuEatIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelSubMenuEatIn.Controls.Add(this.SaladsBtn);
            this.panelSubMenuEatIn.Controls.Add(this.DessertBtn);
            this.panelSubMenuEatIn.Controls.Add(this.DrinksBtn);
            this.panelSubMenuEatIn.Controls.Add(this.MealBtn);
            this.panelSubMenuEatIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEatIn.Location = new System.Drawing.Point(0, 177);
            this.panelSubMenuEatIn.Name = "panelSubMenuEatIn";
            this.panelSubMenuEatIn.Size = new System.Drawing.Size(222, 115);
            this.panelSubMenuEatIn.TabIndex = 12;
            // 
            // SaladsBtn
            // 
            this.SaladsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaladsBtn.FlatAppearance.BorderSize = 0;
            this.SaladsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaladsBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaladsBtn.ForeColor = System.Drawing.Color.White;
            this.SaladsBtn.Location = new System.Drawing.Point(0, 82);
            this.SaladsBtn.Name = "SaladsBtn";
            this.SaladsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SaladsBtn.Size = new System.Drawing.Size(222, 28);
            this.SaladsBtn.TabIndex = 5;
            this.SaladsBtn.Text = "Salads";
            this.SaladsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaladsBtn.UseVisualStyleBackColor = true;
            // 
            // DessertBtn
            // 
            this.DessertBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DessertBtn.FlatAppearance.BorderSize = 0;
            this.DessertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DessertBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DessertBtn.ForeColor = System.Drawing.Color.White;
            this.DessertBtn.Location = new System.Drawing.Point(0, 54);
            this.DessertBtn.Name = "DessertBtn";
            this.DessertBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.DessertBtn.Size = new System.Drawing.Size(222, 28);
            this.DessertBtn.TabIndex = 4;
            this.DessertBtn.Text = "Dessert and Refreshments";
            this.DessertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DessertBtn.UseVisualStyleBackColor = true;
            this.DessertBtn.Click += new System.EventHandler(this.OccupancyBtn_Click);
            // 
            // DrinksBtn
            // 
            this.DrinksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrinksBtn.FlatAppearance.BorderSize = 0;
            this.DrinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrinksBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinksBtn.ForeColor = System.Drawing.Color.White;
            this.DrinksBtn.Location = new System.Drawing.Point(0, 24);
            this.DrinksBtn.Name = "DrinksBtn";
            this.DrinksBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.DrinksBtn.Size = new System.Drawing.Size(222, 30);
            this.DrinksBtn.TabIndex = 3;
            this.DrinksBtn.Text = "Drinks";
            this.DrinksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DrinksBtn.UseVisualStyleBackColor = true;
            this.DrinksBtn.Click += new System.EventHandler(this.TablesBtn_Click);
            // 
            // MealBtn
            // 
            this.MealBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MealBtn.FlatAppearance.BorderSize = 0;
            this.MealBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MealBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealBtn.ForeColor = System.Drawing.Color.White;
            this.MealBtn.Location = new System.Drawing.Point(0, 0);
            this.MealBtn.Name = "MealBtn";
            this.MealBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MealBtn.Size = new System.Drawing.Size(222, 24);
            this.MealBtn.TabIndex = 1;
            this.MealBtn.Text = "Meal";
            this.MealBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MealBtn.UseVisualStyleBackColor = true;
            this.MealBtn.Click += new System.EventHandler(this.LocationsBtn_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(207, 70);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(15, 52);
            this.SidePanel.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Image = ((System.Drawing.Image)(resources.GetObject("RegisterBtn.Image")));
            this.RegisterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegisterBtn.Location = new System.Drawing.Point(0, 519);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(222, 55);
            this.RegisterBtn.TabIndex = 11;
            this.RegisterBtn.Text = "       ...";
            this.RegisterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 70);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(222, 52);
            this.HomeBtn.TabIndex = 10;
            this.HomeBtn.Text = "      Home";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentBtn.FlatAppearance.BorderSize = 0;
            this.PaymentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PaymentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("PaymentBtn.Image")));
            this.PaymentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentBtn.Location = new System.Drawing.Point(0, 347);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(222, 55);
            this.PaymentBtn.TabIndex = 9;
            this.PaymentBtn.Text = "      Payment";
            this.PaymentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderBtn.FlatAppearance.BorderSize = 0;
            this.OrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.Color.White;
            this.OrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("OrderBtn.Image")));
            this.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderBtn.Location = new System.Drawing.Point(0, 292);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(222, 55);
            this.OrderBtn.TabIndex = 7;
            this.OrderBtn.Text = "        Order";
            this.OrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // DeliveryBtn
            // 
            this.DeliveryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeliveryBtn.FlatAppearance.BorderSize = 0;
            this.DeliveryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DeliveryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DeliveryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryBtn.ForeColor = System.Drawing.Color.White;
            this.DeliveryBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeliveryBtn.Image")));
            this.DeliveryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryBtn.Location = new System.Drawing.Point(0, 464);
            this.DeliveryBtn.Name = "DeliveryBtn";
            this.DeliveryBtn.Size = new System.Drawing.Size(222, 55);
            this.DeliveryBtn.TabIndex = 6;
            this.DeliveryBtn.Text = "       Delivery";
            this.DeliveryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeliveryBtn.UseVisualStyleBackColor = true;
            // 
            // EatInBtn
            // 
            this.EatInBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EatInBtn.FlatAppearance.BorderSize = 0;
            this.EatInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.EatInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.EatInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EatInBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EatInBtn.ForeColor = System.Drawing.Color.White;
            this.EatInBtn.Image = ((System.Drawing.Image)(resources.GetObject("EatInBtn.Image")));
            this.EatInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EatInBtn.Location = new System.Drawing.Point(0, 122);
            this.EatInBtn.Name = "EatInBtn";
            this.EatInBtn.Size = new System.Drawing.Size(222, 55);
            this.EatInBtn.TabIndex = 5;
            this.EatInBtn.Text = "      Eat-In";
            this.EatInBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EatInBtn.UseVisualStyleBackColor = true;
            this.EatInBtn.Click += new System.EventHandler(this.EatInBtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelTop.Controls.Add(this.MaximizeBtn);
            this.panelTop.Controls.Add(this.CloseBtn);
            this.panelTop.Controls.Add(this.MinimizeBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(222, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(848, 20);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaximizeBtn.BackgroundImage")));
            this.MaximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Location = new System.Drawing.Point(748, 1);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(21, 20);
            this.MaximizeBtn.TabIndex = 17;
            this.MaximizeBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBtn.BackgroundImage")));
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(779, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 21);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.BackgroundImage")));
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.Location = new System.Drawing.Point(716, 1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(21, 21);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(254, 17);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(129, 143);
            this.panelLogo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Restaurants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fast Food";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "\"Your way\"";
            // 
            // FbBtn
            // 
            this.FbBtn.FlatAppearance.BorderSize = 0;
            this.FbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FbBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FbBtn.ForeColor = System.Drawing.Color.White;
            this.FbBtn.Image = ((System.Drawing.Image)(resources.GetObject("FbBtn.Image")));
            this.FbBtn.Location = new System.Drawing.Point(464, 65);
            this.FbBtn.Name = "FbBtn";
            this.FbBtn.Size = new System.Drawing.Size(46, 44);
            this.FbBtn.TabIndex = 12;
            this.FbBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FbBtn.UseVisualStyleBackColor = true;
            // 
            // TripAdvisorBtn
            // 
            this.TripAdvisorBtn.FlatAppearance.BorderSize = 0;
            this.TripAdvisorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TripAdvisorBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TripAdvisorBtn.ForeColor = System.Drawing.Color.White;
            this.TripAdvisorBtn.Image = ((System.Drawing.Image)(resources.GetObject("TripAdvisorBtn.Image")));
            this.TripAdvisorBtn.Location = new System.Drawing.Point(403, 64);
            this.TripAdvisorBtn.Name = "TripAdvisorBtn";
            this.TripAdvisorBtn.Size = new System.Drawing.Size(59, 44);
            this.TripAdvisorBtn.TabIndex = 13;
            this.TripAdvisorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TripAdvisorBtn.UseVisualStyleBackColor = true;
            // 
            // InstaBtn
            // 
            this.InstaBtn.FlatAppearance.BorderSize = 0;
            this.InstaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstaBtn.ForeColor = System.Drawing.Color.White;
            this.InstaBtn.Image = ((System.Drawing.Image)(resources.GetObject("InstaBtn.Image")));
            this.InstaBtn.Location = new System.Drawing.Point(518, 65);
            this.InstaBtn.Name = "InstaBtn";
            this.InstaBtn.Size = new System.Drawing.Size(44, 44);
            this.InstaBtn.TabIndex = 14;
            this.InstaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InstaBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.Location = new System.Drawing.Point(980, 40);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(47, 42);
            this.SettingsBtn.TabIndex = 15;
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.panelSideMenu.Controls.Add(this.SidePanel);
            this.panelSideMenu.Controls.Add(this.PrintingBtn);
            this.panelSideMenu.Controls.Add(this.RegisterBtn);
            this.panelSideMenu.Controls.Add(this.DeliveryBtn);
            this.panelSideMenu.Controls.Add(this.panelSubMenuPayment);
            this.panelSideMenu.Controls.Add(this.PaymentBtn);
            this.panelSideMenu.Controls.Add(this.OrderBtn);
            this.panelSideMenu.Controls.Add(this.panelSubMenuEatIn);
            this.panelSideMenu.Controls.Add(this.EatInBtn);
            this.panelSideMenu.Controls.Add(this.HomeBtn);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(222, 608);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelSideMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panelSideMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // PrintingBtn
            // 
            this.PrintingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PrintingBtn.FlatAppearance.BorderSize = 0;
            this.PrintingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintingBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintingBtn.ForeColor = System.Drawing.Color.White;
            this.PrintingBtn.Location = new System.Drawing.Point(36, 560);
            this.PrintingBtn.Name = "PrintingBtn";
            this.PrintingBtn.Size = new System.Drawing.Size(145, 28);
            this.PrintingBtn.TabIndex = 18;
            this.PrintingBtn.Text = "Print bill";
            this.PrintingBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 70);
            this.panel1.TabIndex = 14;
            // 
            // PanelUserControl
            // 
            this.PanelUserControl.Location = new System.Drawing.Point(222, 177);
            this.PanelUserControl.Name = "PanelUserControl";
            this.PanelUserControl.Size = new System.Drawing.Size(550, 400);
            this.PanelUserControl.TabIndex = 16;
            // 
            // ItemsListView
            // 
            this.ItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Quantity,
            this.Price});
            this.ItemsListView.HideSelection = false;
            this.ItemsListView.Location = new System.Drawing.Point(798, 136);
            this.ItemsListView.Name = "ItemsListView";
            this.ItemsListView.Size = new System.Drawing.Size(237, 440);
            this.ItemsListView.TabIndex = 17;
            this.ItemsListView.UseCompatibleStateImageBehavior = false;
            this.ItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 64;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // FinaliseBtn
            // 
            this.FinaliseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(230)))), ((int)(((byte)(78)))));
            this.FinaliseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinaliseBtn.FlatAppearance.BorderSize = 0;
            this.FinaliseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinaliseBtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinaliseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FinaliseBtn.Location = new System.Drawing.Point(838, 505);
            this.FinaliseBtn.Name = "FinaliseBtn";
            this.FinaliseBtn.Size = new System.Drawing.Size(175, 23);
            this.FinaliseBtn.TabIndex = 18;
            this.FinaliseBtn.Text = "Finalise";
            this.FinaliseBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeleteItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItemBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemBtn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItemBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteItemBtn.Location = new System.Drawing.Point(838, 536);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(175, 23);
            this.DeleteItemBtn.TabIndex = 19;
            this.DeleteItemBtn.Text = "Delete";
            this.DeleteItemBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1070, 608);
            this.Controls.Add(this.DeleteItemBtn);
            this.Controls.Add(this.FinaliseBtn);
            this.Controls.Add(this.ItemsListView);
            this.Controls.Add(this.PanelUserControl);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TripAdvisorBtn);
            this.Controls.Add(this.FbBtn);
            this.Controls.Add(this.InstaBtn);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panelSubMenuPayment.ResumeLayout(false);
            this.panelSubMenuEatIn.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button DeliveryBtn;
        private System.Windows.Forms.Button EatInBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FbBtn;
        private System.Windows.Forms.Button TripAdvisorBtn;
        private System.Windows.Forms.Button InstaBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.Panel panelSubMenuEatIn;
        private System.Windows.Forms.Button MealBtn;
        private System.Windows.Forms.Button DessertBtn;
        private System.Windows.Forms.Button DrinksBtn;
        private System.Windows.Forms.Panel panelSubMenuPayment;
        private System.Windows.Forms.Button CardPayBtn;
        private System.Windows.Forms.Button CashPayBtn;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrintingBtn;
        private System.Windows.Forms.Panel PanelUserControl;
        private System.Windows.Forms.ListView ItemsListView;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button SaladsBtn;
        private System.Windows.Forms.Button FinaliseBtn;
        private System.Windows.Forms.Button DeleteItemBtn;
    }
}

