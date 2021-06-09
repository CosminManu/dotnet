
namespace Fast_Food_demo
{
    partial class UserControlOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grBUserDetails = new System.Windows.Forms.GroupBox();
            this.PayBtn = new System.Windows.Forms.Button();
            this.TotalPayLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SumTotal = new System.Windows.Forms.Button();
            this.checkBoxAway = new System.Windows.Forms.CheckBox();
            this.checkBoxHere = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelDenumire = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.grBUserDetails.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBUserDetails
            // 
            this.grBUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBUserDetails.AutoSize = true;
            this.grBUserDetails.Controls.Add(this.PayBtn);
            this.grBUserDetails.Controls.Add(this.TotalPayLb);
            this.grBUserDetails.Controls.Add(this.label6);
            this.grBUserDetails.Controls.Add(this.SumTotal);
            this.grBUserDetails.Controls.Add(this.checkBoxAway);
            this.grBUserDetails.Controls.Add(this.checkBoxHere);
            this.grBUserDetails.Controls.Add(this.label3);
            this.grBUserDetails.Controls.Add(this.tbLastName);
            this.grBUserDetails.Controls.Add(this.labelVarsta);
            this.grBUserDetails.Controls.Add(this.tbFirstName);
            this.grBUserDetails.Controls.Add(this.labelDenumire);
            this.grBUserDetails.Location = new System.Drawing.Point(81, 49);
            this.grBUserDetails.Name = "grBUserDetails";
            this.grBUserDetails.Size = new System.Drawing.Size(356, 332);
            this.grBUserDetails.TabIndex = 4;
            this.grBUserDetails.TabStop = false;
            this.grBUserDetails.Text = "User details";
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.PayBtn.FlatAppearance.BorderSize = 0;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.Location = new System.Drawing.Point(30, 262);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(290, 37);
            this.PayBtn.TabIndex = 19;
            this.PayBtn.Text = "PAY";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            this.PayBtn.MouseHover += new System.EventHandler(this.PayBtn_MouseHover);
            // 
            // TotalPayLb
            // 
            this.TotalPayLb.AutoSize = true;
            this.TotalPayLb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPayLb.Location = new System.Drawing.Point(156, 206);
            this.TotalPayLb.Name = "TotalPayLb";
            this.TotalPayLb.Size = new System.Drawing.Size(0, 25);
            this.TotalPayLb.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 1);
            this.label6.TabIndex = 32;
            // 
            // SumTotal
            // 
            this.SumTotal.BackColor = System.Drawing.SystemColors.Control;
            this.SumTotal.FlatAppearance.BorderSize = 0;
            this.SumTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumTotal.ForeColor = System.Drawing.Color.Black;
            this.SumTotal.Location = new System.Drawing.Point(17, 191);
            this.SumTotal.Margin = new System.Windows.Forms.Padding(0);
            this.SumTotal.Name = "SumTotal";
            this.SumTotal.Size = new System.Drawing.Size(161, 51);
            this.SumTotal.TabIndex = 31;
            this.SumTotal.Text = "Total to pay: ";
            this.SumTotal.UseVisualStyleBackColor = false;
            // 
            // checkBoxAway
            // 
            this.checkBoxAway.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAway.Location = new System.Drawing.Point(159, 107);
            this.checkBoxAway.Name = "checkBoxAway";
            this.checkBoxAway.Size = new System.Drawing.Size(82, 35);
            this.checkBoxAway.TabIndex = 16;
            this.checkBoxAway.Text = "Away";
            this.checkBoxAway.UseVisualStyleBackColor = true;
            // 
            // checkBoxHere
            // 
            this.checkBoxHere.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHere.Location = new System.Drawing.Point(26, 107);
            this.checkBoxHere.Name = "checkBoxHere";
            this.checkBoxHere.Size = new System.Drawing.Size(82, 35);
            this.checkBoxHere.TabIndex = 14;
            this.checkBoxHere.Text = "Here";
            this.checkBoxHere.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 1);
            this.label3.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(83, 64);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(237, 20);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.MouseLeave += new System.EventHandler(this.tbLastName_MouseLeave);
            this.tbLastName.MouseHover += new System.EventHandler(this.tbLastName_MouseHover);
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Location = new System.Drawing.Point(14, 67);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(58, 13);
            this.labelVarsta.TabIndex = 2;
            this.labelVarsta.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(83, 24);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(237, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.MouseLeave += new System.EventHandler(this.tbFirstName_MouseLeave);
            this.tbFirstName.MouseHover += new System.EventHandler(this.tbFirstName_MouseHover);
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(14, 27);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(57, 13);
            this.labelDenumire.TabIndex = 0;
            this.labelDenumire.Text = "First Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(848, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // UserControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grBUserDetails);
            this.Name = "UserControlOrder";
            this.Size = new System.Drawing.Size(848, 450);
            this.grBUserDetails.ResumeLayout(false);
            this.grBUserDetails.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBUserDetails;
        private System.Windows.Forms.CheckBox checkBoxAway;
        private System.Windows.Forms.CheckBox checkBoxHere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.Label TotalPayLb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SumTotal;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
    }
}
