
namespace WebFormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwCar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCar
            // 
            this.dgwCar.AllowUserToOrderColumns = true;
            this.dgwCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCar.Location = new System.Drawing.Point(-1, 46);
            this.dgwCar.Name = "dgwCar";
            this.dgwCar.RowHeadersWidth = 51;
            this.dgwCar.RowTemplate.Height = 29;
            this.dgwCar.Size = new System.Drawing.Size(989, 188);
            this.dgwCar.TabIndex = 0;
            this.dgwCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCar_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 479);
            this.Controls.Add(this.dgwCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCar;
    }
}

