namespace WinForms_s4
{
    partial class FormularPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLimbaje = new System.Windows.Forms.Label();
            this.checkBoxPython = new System.Windows.Forms.CheckBox();
            this.checkBoxJS = new System.Windows.Forms.CheckBox();
            this.checkBoxDotnet = new System.Windows.Forms.CheckBox();
            this.checkBoxJava = new System.Windows.Forms.CheckBox();
            this.comboBoxIncadrare = new System.Windows.Forms.ComboBox();
            this.labelIncadrare = new System.Windows.Forms.Label();
            this.dtpAngajat = new System.Windows.Forms.DateTimePicker();
            this.labelDataAngajarii = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvProgramatori = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.epAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLimbaje);
            this.groupBox1.Controls.Add(this.checkBoxPython);
            this.groupBox1.Controls.Add(this.checkBoxJS);
            this.groupBox1.Controls.Add(this.checkBoxDotnet);
            this.groupBox1.Controls.Add(this.checkBoxJava);
            this.groupBox1.Controls.Add(this.comboBoxIncadrare);
            this.groupBox1.Controls.Add(this.labelIncadrare);
            this.groupBox1.Controls.Add(this.dtpAngajat);
            this.groupBox1.Controls.Add(this.labelDataAngajarii);
            this.groupBox1.Controls.Add(this.tbAdresa);
            this.groupBox1.Controls.Add(this.labelAdresa);
            this.groupBox1.Controls.Add(this.tbVarsta);
            this.groupBox1.Controls.Add(this.labelVarsta);
            this.groupBox1.Controls.Add(this.tbDenumire);
            this.groupBox1.Controls.Add(this.labelDenumire);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare programator";
            // 
            // labelLimbaje
            // 
            this.labelLimbaje.AutoSize = true;
            this.labelLimbaje.Location = new System.Drawing.Point(21, 244);
            this.labelLimbaje.Name = "labelLimbaje";
            this.labelLimbaje.Size = new System.Drawing.Size(114, 13);
            this.labelLimbaje.TabIndex = 9;
            this.labelLimbaje.Text = "Limbaje de programare";
            // 
            // checkBoxPython
            // 
            this.checkBoxPython.AutoSize = true;
            this.checkBoxPython.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPython.Location = new System.Drawing.Point(157, 283);
            this.checkBoxPython.Name = "checkBoxPython";
            this.checkBoxPython.Size = new System.Drawing.Size(65, 20);
            this.checkBoxPython.TabIndex = 13;
            this.checkBoxPython.Text = "Python";
            this.checkBoxPython.UseVisualStyleBackColor = true;
            // 
            // checkBoxJS
            // 
            this.checkBoxJS.AutoSize = true;
            this.checkBoxJS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxJS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJS.Location = new System.Drawing.Point(157, 260);
            this.checkBoxJS.Name = "checkBoxJS";
            this.checkBoxJS.Size = new System.Drawing.Size(86, 20);
            this.checkBoxJS.TabIndex = 12;
            this.checkBoxJS.Text = "Javascript";
            this.checkBoxJS.UseVisualStyleBackColor = true;
            // 
            // checkBoxDotnet
            // 
            this.checkBoxDotnet.AutoSize = true;
            this.checkBoxDotnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDotnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDotnet.Location = new System.Drawing.Point(21, 283);
            this.checkBoxDotnet.Name = "checkBoxDotnet";
            this.checkBoxDotnet.Size = new System.Drawing.Size(55, 20);
            this.checkBoxDotnet.TabIndex = 11;
            this.checkBoxDotnet.Text = ".NET";
            this.checkBoxDotnet.UseVisualStyleBackColor = true;
            // 
            // checkBoxJava
            // 
            this.checkBoxJava.AutoSize = true;
            this.checkBoxJava.FlatAppearance.BorderSize = 0;
            this.checkBoxJava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJava.Location = new System.Drawing.Point(21, 260);
            this.checkBoxJava.Name = "checkBoxJava";
            this.checkBoxJava.Size = new System.Drawing.Size(54, 20);
            this.checkBoxJava.TabIndex = 10;
            this.checkBoxJava.Text = "Java";
            this.checkBoxJava.UseVisualStyleBackColor = true;
            // 
            // comboBoxIncadrare
            // 
            this.comboBoxIncadrare.FormattingEnabled = true;
            this.comboBoxIncadrare.Items.AddRange(new object[] {
            "Norma intreaga",
            "Jumatate de norma",
            "Intern",
            "Contractor"});
            this.comboBoxIncadrare.Location = new System.Drawing.Point(9, 200);
            this.comboBoxIncadrare.Name = "comboBoxIncadrare";
            this.comboBoxIncadrare.Size = new System.Drawing.Size(261, 21);
            this.comboBoxIncadrare.TabIndex = 9;
            // 
            // labelIncadrare
            // 
            this.labelIncadrare.AutoSize = true;
            this.labelIncadrare.Location = new System.Drawing.Point(9, 184);
            this.labelIncadrare.Name = "labelIncadrare";
            this.labelIncadrare.Size = new System.Drawing.Size(52, 13);
            this.labelIncadrare.TabIndex = 8;
            this.labelIncadrare.Text = "Incadrare";
            // 
            // dtpAngajat
            // 
            this.dtpAngajat.Location = new System.Drawing.Point(9, 154);
            this.dtpAngajat.Name = "dtpAngajat";
            this.dtpAngajat.Size = new System.Drawing.Size(200, 20);
            this.dtpAngajat.TabIndex = 7;
            // 
            // labelDataAngajarii
            // 
            this.labelDataAngajarii.AutoSize = true;
            this.labelDataAngajarii.Location = new System.Drawing.Point(9, 138);
            this.labelDataAngajarii.Name = "labelDataAngajarii";
            this.labelDataAngajarii.Size = new System.Drawing.Size(72, 13);
            this.labelDataAngajarii.TabIndex = 6;
            this.labelDataAngajarii.Text = "Data angajarii";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(9, 109);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(261, 20);
            this.tbAdresa.TabIndex = 5;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            this.tbAdresa.Validated += new System.EventHandler(this.tbAdresa_Validated);
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(9, 95);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(40, 13);
            this.labelAdresa.TabIndex = 4;
            this.labelAdresa.Text = "Adresa";
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(9, 68);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(261, 20);
            this.tbVarsta.TabIndex = 3;
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Location = new System.Drawing.Point(9, 54);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(37, 13);
            this.labelVarsta.TabIndex = 2;
            this.labelVarsta.Text = "Varsta";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(9, 29);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(261, 20);
            this.tbDenumire.TabIndex = 1;
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(9, 14);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(52, 13);
            this.labelDenumire.TabIndex = 0;
            this.labelDenumire.Text = "Denumire";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(21, 330);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(89, 33);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(166, 330);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(89, 33);
            this.btnCurata.TabIndex = 2;
            this.btnCurata.Text = "Curata";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvProgramatori);
            this.groupBox2.Location = new System.Drawing.Point(331, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 307);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista programatori";
            // 
            // lvProgramatori
            // 
            this.lvProgramatori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvProgramatori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProgramatori.FullRowSelect = true;
            this.lvProgramatori.HideSelection = false;
            this.lvProgramatori.Location = new System.Drawing.Point(3, 16);
            this.lvProgramatori.Name = "lvProgramatori";
            this.lvProgramatori.Size = new System.Drawing.Size(315, 288);
            this.lvProgramatori.TabIndex = 0;
            this.lvProgramatori.UseCompatibleStateImageBehavior = false;
            this.lvProgramatori.View = System.Windows.Forms.View.Details;
            this.lvProgramatori.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvProgramatori_MouseClick);
            this.lvProgramatori.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProgramatori_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Denumire";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Varsta";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salariu";
            this.columnHeader3.Width = 72;
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(444, 330);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(89, 33);
            this.btnEditeaza.TabIndex = 4;
            this.btnEditeaza.Text = "editeaza";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(542, 330);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(89, 33);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(313, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 370);
            this.label1.TabIndex = 6;
            // 
            // epAdresa
            // 
            this.epAdresa.ContainerControl = this;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(118, 48);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // FormularPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularPrincipal";
            this.Text = "Formular principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epAdresa)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.DateTimePicker dtpAngajat;
        private System.Windows.Forms.Label labelDataAngajarii;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.ComboBox comboBoxIncadrare;
        private System.Windows.Forms.Label labelIncadrare;
        private System.Windows.Forms.Label labelLimbaje;
        private System.Windows.Forms.CheckBox checkBoxJava;
        private System.Windows.Forms.CheckBox checkBoxDotnet;
        private System.Windows.Forms.CheckBox checkBoxJS;
        private System.Windows.Forms.CheckBox checkBoxPython;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvProgramatori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epAdresa;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}

