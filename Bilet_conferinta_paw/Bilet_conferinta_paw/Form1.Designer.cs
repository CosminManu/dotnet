
namespace Bilet_conferinta_paw
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
            this.lviLucrari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSectiuni = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lviLucrari
            // 
            this.lviLucrari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lviLucrari.HideSelection = false;
            this.lviLucrari.Location = new System.Drawing.Point(58, 79);
            this.lviLucrari.Name = "lviLucrari";
            this.lviLucrari.Size = new System.Drawing.Size(329, 287);
            this.lviLucrari.TabIndex = 0;
            this.lviLucrari.UseCompatibleStateImageBehavior = false;
            this.lviLucrari.View = System.Windows.Forms.View.Details;
            this.lviLucrari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lviLucrari_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cod lucrare";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Denumire lucrare";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sectiune";
            this.columnHeader3.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sectiuni";
            // 
            // cbSectiuni
            // 
            this.cbSectiuni.FormattingEnabled = true;
            this.cbSectiuni.Location = new System.Drawing.Point(422, 180);
            this.cbSectiuni.Name = "cbSectiuni";
            this.cbSectiuni.Size = new System.Drawing.Size(181, 21);
            this.cbSectiuni.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 403);
            this.Controls.Add(this.cbSectiuni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lviLucrari);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviLucrari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSectiuni;
    }
}

