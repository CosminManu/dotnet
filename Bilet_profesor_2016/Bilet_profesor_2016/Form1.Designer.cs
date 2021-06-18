
namespace Bilet_profesor_2016
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salariu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Nume,
            this.Salariu});
            this.dgv.Location = new System.Drawing.Point(24, 61);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(345, 200);
            this.dgv.TabIndex = 0;
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Salariu
            // 
            this.Salariu.HeaderText = "Salariu";
            this.Salariu.Name = "Salariu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(411, 71);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(90, 25);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "Total salarii: ";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimareToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.toBDToolStripMenuItem});
            this.cms.Name = "cmx";
            this.cms.Size = new System.Drawing.Size(181, 92);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimareToolStripMenuItem.Text = "Imprimare";
            this.imprimareToolStripMenuItem.Click += new System.EventHandler(this.imprimareToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            // 
            // toBDToolStripMenuItem
            // 
            this.toBDToolStripMenuItem.Name = "toBDToolStripMenuItem";
            this.toBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toBDToolStripMenuItem.Text = "To BD";
            this.toBDToolStripMenuItem.Click += new System.EventHandler(this.toBDToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 339);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salariu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toBDToolStripMenuItem;
    }
}

