
namespace WinForms_s4
{
    partial class FormularEditare
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
            this.groupBox = new System.Windows.Forms.GroupBox();
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
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelLimbaje);
            this.groupBox.Controls.Add(this.checkBoxPython);
            this.groupBox.Controls.Add(this.checkBoxJS);
            this.groupBox.Controls.Add(this.checkBoxDotnet);
            this.groupBox.Controls.Add(this.checkBoxJava);
            this.groupBox.Controls.Add(this.comboBoxIncadrare);
            this.groupBox.Controls.Add(this.labelIncadrare);
            this.groupBox.Controls.Add(this.dtpAngajat);
            this.groupBox.Controls.Add(this.labelDataAngajarii);
            this.groupBox.Controls.Add(this.tbAdresa);
            this.groupBox.Controls.Add(this.labelAdresa);
            this.groupBox.Controls.Add(this.tbVarsta);
            this.groupBox.Controls.Add(this.labelVarsta);
            this.groupBox.Controls.Add(this.tbDenumire);
            this.groupBox.Controls.Add(this.labelDenumire);
            this.groupBox.Location = new System.Drawing.Point(12, 25);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(319, 311);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Editare programator";
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
            // btnRenunta
            // 
            this.btnRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRenunta.Location = new System.Drawing.Point(210, 355);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(108, 44);
            this.btnRenunta.TabIndex = 3;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalveaza.Location = new System.Drawing.Point(21, 355);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(108, 44);
            this.btnSalveaza.TabIndex = 4;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormularEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 411);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.groupBox);
            this.Name = "FormularEditare";
            this.Text = "Formular editare";
            this.Load += new System.EventHandler(this.FormularEditare_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelLimbaje;
        private System.Windows.Forms.CheckBox checkBoxPython;
        private System.Windows.Forms.CheckBox checkBoxJS;
        private System.Windows.Forms.CheckBox checkBoxDotnet;
        private System.Windows.Forms.CheckBox checkBoxJava;
        private System.Windows.Forms.ComboBox comboBoxIncadrare;
        private System.Windows.Forms.Label labelIncadrare;
        private System.Windows.Forms.DateTimePicker dtpAngajat;
        private System.Windows.Forms.Label labelDataAngajarii;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnSalveaza;
    }
}