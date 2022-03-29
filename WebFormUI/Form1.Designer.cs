
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
            this.cbxCar = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.tbxModelSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.tbxDailyPrice = new System.Windows.Forms.TextBox();
            this.cbxModelYearAdd = new System.Windows.Forms.ComboBox();
            this.cbxColorId = new System.Windows.Forms.ComboBox();
            this.tbxModelAdd = new System.Windows.Forms.TextBox();
            this.cbxBrandId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCar
            // 
            this.dgwCar.AllowUserToOrderColumns = true;
            this.dgwCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCar.Location = new System.Drawing.Point(12, 265);
            this.dgwCar.Name = "dgwCar";
            this.dgwCar.RowHeadersWidth = 51;
            this.dgwCar.RowTemplate.Height = 29;
            this.dgwCar.Size = new System.Drawing.Size(668, 167);
            this.dgwCar.TabIndex = 0;
            this.dgwCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCar_CellClick);
            // 
            // cbxCar
            // 
            this.cbxCar.FormattingEnabled = true;
            this.cbxCar.Location = new System.Drawing.Point(16, 89);
            this.cbxCar.Name = "cbxCar";
            this.cbxCar.Size = new System.Drawing.Size(151, 28);
            this.cbxCar.TabIndex = 1;
            this.cbxCar.Tag = "Araç Model";
            this.cbxCar.Text = "Model Seç";
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(16, 45);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(151, 28);
            this.cbxBrand.TabIndex = 2;
            this.cbxBrand.Tag = "Araç Marka";
            this.cbxBrand.Text = "Marka Seç";
            this.cbxBrand.SelectedIndexChanged += new System.EventHandler(this.cbxBrand_SelectedIndexChanged);
            // 
            // tbxModelSearch
            // 
            this.tbxModelSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.tbxModelSearch.Location = new System.Drawing.Point(16, 158);
            this.tbxModelSearch.Name = "tbxModelSearch";
            this.tbxModelSearch.Size = new System.Drawing.Size(151, 27);
            this.tbxModelSearch.TabIndex = 3;
            this.tbxModelSearch.Tag = "Model Adında Ara";
            this.tbxModelSearch.TextChanged += new System.EventHandler(this.tbxModelSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxBrand);
            this.groupBox1.Controls.Add(this.tbxModelSearch);
            this.groupBox1.Controls.Add(this.cbxCar);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 252);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model Adında Ara";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteCar);
            this.groupBox2.Controls.Add(this.btnAddCar);
            this.groupBox2.Controls.Add(this.tbxDescription);
            this.groupBox2.Controls.Add(this.btnUpdateCar);
            this.groupBox2.Controls.Add(this.tbxDailyPrice);
            this.groupBox2.Controls.Add(this.cbxModelYearAdd);
            this.groupBox2.Controls.Add(this.cbxColorId);
            this.groupBox2.Controls.Add(this.tbxModelAdd);
            this.groupBox2.Controls.Add(this.cbxBrandId);
            this.groupBox2.Location = new System.Drawing.Point(200, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Araç Ekle";
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(160, 141);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(56, 45);
            this.btnDeleteCar.TabIndex = 8;
            this.btnDeleteCar.Text = "Sil";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(160, 26);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(56, 45);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "Ekle";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(6, 192);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(204, 27);
            this.tbxDescription.TabIndex = 5;
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(160, 82);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(56, 45);
            this.btnUpdateCar.TabIndex = 7;
            this.btnUpdateCar.Text = "Güncelle";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // tbxDailyPrice
            // 
            this.tbxDailyPrice.Location = new System.Drawing.Point(6, 158);
            this.tbxDailyPrice.Name = "tbxDailyPrice";
            this.tbxDailyPrice.Size = new System.Drawing.Size(142, 27);
            this.tbxDailyPrice.TabIndex = 4;
            // 
            // cbxModelYearAdd
            // 
            this.cbxModelYearAdd.FormattingEnabled = true;
            this.cbxModelYearAdd.Location = new System.Drawing.Point(6, 124);
            this.cbxModelYearAdd.Name = "cbxModelYearAdd";
            this.cbxModelYearAdd.Size = new System.Drawing.Size(142, 28);
            this.cbxModelYearAdd.TabIndex = 3;
            this.cbxModelYearAdd.Text = "Model Yılı";
            // 
            // cbxColorId
            // 
            this.cbxColorId.FormattingEnabled = true;
            this.cbxColorId.Location = new System.Drawing.Point(6, 91);
            this.cbxColorId.Name = "cbxColorId";
            this.cbxColorId.Size = new System.Drawing.Size(142, 28);
            this.cbxColorId.TabIndex = 2;
            this.cbxColorId.Text = "Araç Renk";
            // 
            // tbxModelAdd
            // 
            this.tbxModelAdd.Location = new System.Drawing.Point(6, 59);
            this.tbxModelAdd.Name = "tbxModelAdd";
            this.tbxModelAdd.Size = new System.Drawing.Size(142, 27);
            this.tbxModelAdd.TabIndex = 1;
            // 
            // cbxBrandId
            // 
            this.cbxBrandId.FormattingEnabled = true;
            this.cbxBrandId.Location = new System.Drawing.Point(6, 26);
            this.cbxBrandId.Name = "cbxBrandId";
            this.cbxBrandId.Size = new System.Drawing.Size(142, 28);
            this.cbxBrandId.TabIndex = 0;
            this.cbxBrandId.Text = "Araç Marka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCar;
        private System.Windows.Forms.ComboBox cbxCar;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.TextBox tbxModelSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.TextBox tbxDailyPrice;
        private System.Windows.Forms.ComboBox cbxModelYearAdd;
        private System.Windows.Forms.ComboBox cbxColorId;
        private System.Windows.Forms.TextBox tbxModelAdd;
        private System.Windows.Forms.ComboBox cbxBrandId;
    }
}

