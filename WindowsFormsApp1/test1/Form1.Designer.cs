namespace test1
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
            this.btn_changeColor = new System.Windows.Forms.Button();
            this.btn_image = new System.Windows.Forms.Button();
            this.lbl_welcomeMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_changeColor
            // 
            this.btn_changeColor.Location = new System.Drawing.Point(40, 64);
            this.btn_changeColor.Name = "btn_changeColor";
            this.btn_changeColor.Size = new System.Drawing.Size(115, 29);
            this.btn_changeColor.TabIndex = 0;
            this.btn_changeColor.Text = "ChangeColor";
            this.btn_changeColor.UseVisualStyleBackColor = true;
            this.btn_changeColor.Click += new System.EventHandler(this.btn_changeColor_Click);
            // 
            // btn_image
            // 
            this.btn_image.BackColor = System.Drawing.Color.White;
            this.btn_image.BackgroundImage = global::test1.Properties.Resources.drive_in_theater;
            this.btn_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_image.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_image.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_image.Location = new System.Drawing.Point(202, 123);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(293, 157);
            this.btn_image.TabIndex = 1;
            this.btn_image.Text = "HelloClickMe";
            this.btn_image.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_image.UseVisualStyleBackColor = false;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // lbl_welcomeMessage
            // 
            this.lbl_welcomeMessage.AutoSize = true;
            this.lbl_welcomeMessage.Location = new System.Drawing.Point(337, 306);
            this.lbl_welcomeMessage.Name = "lbl_welcomeMessage";
            this.lbl_welcomeMessage.Size = new System.Drawing.Size(0, 13);
            this.lbl_welcomeMessage.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 360);
            this.Controls.Add(this.lbl_welcomeMessage);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.btn_changeColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_changeColor;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Label lbl_welcomeMessage;
    }
}

