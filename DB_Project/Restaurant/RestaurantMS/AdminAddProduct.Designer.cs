namespace RestaurantMS
{
    partial class AdminAddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refresh_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.product_sku_input = new System.Windows.Forms.TextBox();
            this.product_price_input = new System.Windows.Forms.NumericUpDown();
            this.adminAddProducts_clearBtn = new System.Windows.Forms.Button();
            this.adminAddProducts_deletebtn = new System.Windows.Forms.Button();
            this.adminAddProducts_updateBtn = new System.Windows.Forms.Button();
            this.adminAddProductd_addBtn = new System.Windows.Forms.Button();
            this.product_category_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.product_desc_input = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name_input = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_price_input)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 366);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 330);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data of Products:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refresh_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.product_sku_input);
            this.panel2.Controls.Add(this.product_price_input);
            this.panel2.Controls.Add(this.adminAddProducts_clearBtn);
            this.panel2.Controls.Add(this.adminAddProducts_deletebtn);
            this.panel2.Controls.Add(this.adminAddProducts_updateBtn);
            this.panel2.Controls.Add(this.adminAddProductd_addBtn);
            this.panel2.Controls.Add(this.product_category_combobox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.product_desc_input);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.product_name_input);
            this.panel2.Location = new System.Drawing.Point(12, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 291);
            this.panel2.TabIndex = 1;
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.YellowGreen;
            this.refresh_button.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refresh_button.Location = new System.Drawing.Point(1048, 178);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(123, 59);
            this.refresh_button.TabIndex = 22;
            this.refresh_button.Text = "REFRESH";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Sku:";
            // 
            // product_sku_input
            // 
            this.product_sku_input.Location = new System.Drawing.Point(174, 36);
            this.product_sku_input.Name = "product_sku_input";
            this.product_sku_input.Size = new System.Drawing.Size(216, 22);
            this.product_sku_input.TabIndex = 20;
            // 
            // product_price_input
            // 
            this.product_price_input.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.product_price_input.Location = new System.Drawing.Point(614, 36);
            this.product_price_input.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.product_price_input.Name = "product_price_input";
            this.product_price_input.Size = new System.Drawing.Size(207, 22);
            this.product_price_input.TabIndex = 19;
            // 
            // adminAddProducts_clearBtn
            // 
            this.adminAddProducts_clearBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.adminAddProducts_clearBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminAddProducts_clearBtn.Location = new System.Drawing.Point(923, 178);
            this.adminAddProducts_clearBtn.Name = "adminAddProducts_clearBtn";
            this.adminAddProducts_clearBtn.Size = new System.Drawing.Size(119, 59);
            this.adminAddProducts_clearBtn.TabIndex = 18;
            this.adminAddProducts_clearBtn.Text = "CLEAR";
            this.adminAddProducts_clearBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_clearBtn.Click += new System.EventHandler(this.adminAddProducts_clearBtn_Click);
            // 
            // adminAddProducts_deletebtn
            // 
            this.adminAddProducts_deletebtn.BackColor = System.Drawing.Color.YellowGreen;
            this.adminAddProducts_deletebtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_deletebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminAddProducts_deletebtn.Location = new System.Drawing.Point(772, 178);
            this.adminAddProducts_deletebtn.Name = "adminAddProducts_deletebtn";
            this.adminAddProducts_deletebtn.Size = new System.Drawing.Size(119, 59);
            this.adminAddProducts_deletebtn.TabIndex = 17;
            this.adminAddProducts_deletebtn.Text = "DELETE";
            this.adminAddProducts_deletebtn.UseVisualStyleBackColor = false;
            // 
            // adminAddProducts_updateBtn
            // 
            this.adminAddProducts_updateBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.adminAddProducts_updateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProducts_updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminAddProducts_updateBtn.Location = new System.Drawing.Point(629, 178);
            this.adminAddProducts_updateBtn.Name = "adminAddProducts_updateBtn";
            this.adminAddProducts_updateBtn.Size = new System.Drawing.Size(119, 59);
            this.adminAddProducts_updateBtn.TabIndex = 16;
            this.adminAddProducts_updateBtn.Text = "UPDATE";
            this.adminAddProducts_updateBtn.UseVisualStyleBackColor = false;
            this.adminAddProducts_updateBtn.Click += new System.EventHandler(this.adminAddProducts_updateBtn_Click);
            // 
            // adminAddProductd_addBtn
            // 
            this.adminAddProductd_addBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.adminAddProductd_addBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddProductd_addBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminAddProductd_addBtn.Location = new System.Drawing.Point(483, 178);
            this.adminAddProductd_addBtn.Name = "adminAddProductd_addBtn";
            this.adminAddProductd_addBtn.Size = new System.Drawing.Size(119, 59);
            this.adminAddProductd_addBtn.TabIndex = 15;
            this.adminAddProductd_addBtn.Text = "ADD";
            this.adminAddProductd_addBtn.UseVisualStyleBackColor = false;
            this.adminAddProductd_addBtn.Click += new System.EventHandler(this.adminAddProductd_addBtn_Click);
            // 
            // product_category_combobox
            // 
            this.product_category_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.product_category_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.product_category_combobox.FormattingEnabled = true;
            this.product_category_combobox.Items.AddRange(new object[] {
            "Startuese",
            "Mish",
            "Peshk",
            "Mesore",
            "Pije freskuese",
            "Alkool"});
            this.product_category_combobox.Location = new System.Drawing.Point(605, 112);
            this.product_category_combobox.Name = "product_category_combobox";
            this.product_category_combobox.Size = new System.Drawing.Size(216, 24);
            this.product_category_combobox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price (ALL):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description:";
            // 
            // product_desc_input
            // 
            this.product_desc_input.Location = new System.Drawing.Point(174, 154);
            this.product_desc_input.Name = "product_desc_input";
            this.product_desc_input.Size = new System.Drawing.Size(216, 96);
            this.product_desc_input.TabIndex = 9;
            this.product_desc_input.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name:";
            // 
            // product_name_input
            // 
            this.product_name_input.Location = new System.Drawing.Point(174, 96);
            this.product_name_input.Name = "product_name_input";
            this.product_name_input.Size = new System.Drawing.Size(216, 22);
            this.product_name_input.TabIndex = 7;
            // 
            // AdminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProduct";
            this.Size = new System.Drawing.Size(1233, 698);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_price_input)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_name_input;
        private System.Windows.Forms.ComboBox product_category_combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox product_desc_input;
        private System.Windows.Forms.Button adminAddProductd_addBtn;
        private System.Windows.Forms.Button adminAddProducts_updateBtn;
        private System.Windows.Forms.Button adminAddProducts_deletebtn;
        private System.Windows.Forms.Button adminAddProducts_clearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown product_price_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_sku_input;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}