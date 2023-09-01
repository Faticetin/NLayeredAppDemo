namespace Norhwind.WebFormsUI
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.txtUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.txtUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.cmbCategoryAdd = new System.Windows.Forms.ComboBox();
            this.txtProductAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.txtUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.txtUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.cmbCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.txtProductUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 160);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(794, 222);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriye Göre Ara";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(91, 21);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(204, 24);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProduct);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Adına Göre Ara";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(93, 21);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(204, 22);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.txtQuantityPerUnitAdd);
            this.groupBox3.Controls.Add(this.txtUnitsInStockAdd);
            this.groupBox3.Controls.Add(this.txtUnitPriceAdd);
            this.groupBox3.Controls.Add(this.cmbCategoryAdd);
            this.groupBox3.Controls.Add(this.txtProductAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Ürün Ekle ";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(410, 97);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(174, 32);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtQuantityPerUnitAdd
            // 
            this.txtQuantityPerUnitAdd.Location = new System.Drawing.Point(397, 65);
            this.txtQuantityPerUnitAdd.Name = "txtQuantityPerUnitAdd";
            this.txtQuantityPerUnitAdd.Size = new System.Drawing.Size(203, 22);
            this.txtQuantityPerUnitAdd.TabIndex = 9;
            // 
            // txtUnitsInStockAdd
            // 
            this.txtUnitsInStockAdd.Location = new System.Drawing.Point(397, 30);
            this.txtUnitsInStockAdd.Name = "txtUnitsInStockAdd";
            this.txtUnitsInStockAdd.Size = new System.Drawing.Size(203, 22);
            this.txtUnitsInStockAdd.TabIndex = 8;
            // 
            // txtUnitPriceAdd
            // 
            this.txtUnitPriceAdd.Location = new System.Drawing.Point(80, 102);
            this.txtUnitPriceAdd.Name = "txtUnitPriceAdd";
            this.txtUnitPriceAdd.Size = new System.Drawing.Size(217, 22);
            this.txtUnitPriceAdd.TabIndex = 7;
            // 
            // cmbCategoryAdd
            // 
            this.cmbCategoryAdd.FormattingEnabled = true;
            this.cmbCategoryAdd.Location = new System.Drawing.Point(80, 65);
            this.cmbCategoryAdd.Name = "cmbCategoryAdd";
            this.cmbCategoryAdd.Size = new System.Drawing.Size(217, 24);
            this.cmbCategoryAdd.TabIndex = 6;
            // 
            // txtProductAdd
            // 
            this.txtProductAdd.Location = new System.Drawing.Point(80, 30);
            this.txtProductAdd.Name = "txtProductAdd";
            this.txtProductAdd.Size = new System.Drawing.Size(215, 22);
            this.txtProductAdd.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Birim Adedi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stok Adedi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.txtQuantityPerUnitUpdate);
            this.groupBox4.Controls.Add(this.txtUnitsInStockUpdate);
            this.groupBox4.Controls.Add(this.txtUnitPriceUpdate);
            this.groupBox4.Controls.Add(this.cmbCategoryUpdate);
            this.groupBox4.Controls.Add(this.txtProductUpdate);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 585);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 142);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(410, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtQuantityPerUnitUpdate
            // 
            this.txtQuantityPerUnitUpdate.Location = new System.Drawing.Point(397, 65);
            this.txtQuantityPerUnitUpdate.Name = "txtQuantityPerUnitUpdate";
            this.txtQuantityPerUnitUpdate.Size = new System.Drawing.Size(203, 22);
            this.txtQuantityPerUnitUpdate.TabIndex = 9;
            // 
            // txtUnitsInStockUpdate
            // 
            this.txtUnitsInStockUpdate.Location = new System.Drawing.Point(397, 30);
            this.txtUnitsInStockUpdate.Name = "txtUnitsInStockUpdate";
            this.txtUnitsInStockUpdate.Size = new System.Drawing.Size(203, 22);
            this.txtUnitsInStockUpdate.TabIndex = 8;
            // 
            // txtUnitPriceUpdate
            // 
            this.txtUnitPriceUpdate.Location = new System.Drawing.Point(80, 102);
            this.txtUnitPriceUpdate.Name = "txtUnitPriceUpdate";
            this.txtUnitPriceUpdate.Size = new System.Drawing.Size(217, 22);
            this.txtUnitPriceUpdate.TabIndex = 7;
            // 
            // cmbCategoryUpdate
            // 
            this.cmbCategoryUpdate.FormattingEnabled = true;
            this.cmbCategoryUpdate.Location = new System.Drawing.Point(80, 65);
            this.cmbCategoryUpdate.Name = "cmbCategoryUpdate";
            this.cmbCategoryUpdate.Size = new System.Drawing.Size(217, 24);
            this.cmbCategoryUpdate.TabIndex = 6;
            // 
            // txtProductUpdate
            // 
            this.txtProductUpdate.Location = new System.Drawing.Point(80, 30);
            this.txtProductUpdate.Name = "txtProductUpdate";
            this.txtProductUpdate.Size = new System.Drawing.Size(215, 22);
            this.txtProductUpdate.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Birim Adedi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Stok Adedi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fiyat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kategori";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(669, 388);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 895);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox txtUnitsInStockAdd;
        private System.Windows.Forms.TextBox txtUnitPriceAdd;
        private System.Windows.Forms.ComboBox cmbCategoryAdd;
        private System.Windows.Forms.TextBox txtProductAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox txtUnitsInStockUpdate;
        private System.Windows.Forms.TextBox txtUnitPriceUpdate;
        private System.Windows.Forms.ComboBox cmbCategoryUpdate;
        private System.Windows.Forms.TextBox txtProductUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemove;
    }
}

