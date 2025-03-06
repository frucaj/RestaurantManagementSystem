namespace RestaurantMS
{
    partial class EditProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.product_sku_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.product_desc_input = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name_input = new System.Windows.Forms.TextBox();
            this.product_price_input = new System.Windows.Forms.NumericUpDown();
            this.product_category_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_price_input)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Product Sku:";
            // 
            // product_sku_input
            // 
            this.product_sku_input.Location = new System.Drawing.Point(356, 64);
            this.product_sku_input.Name = "product_sku_input";
            this.product_sku_input.ReadOnly = true;
            this.product_sku_input.Size = new System.Drawing.Size(216, 22);
            this.product_sku_input.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Description:";
            // 
            // product_desc_input
            // 
            this.product_desc_input.Location = new System.Drawing.Point(356, 182);
            this.product_desc_input.Name = "product_desc_input";
            this.product_desc_input.Size = new System.Drawing.Size(216, 96);
            this.product_desc_input.TabIndex = 24;
            this.product_desc_input.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Name:";
            // 
            // product_name_input
            // 
            this.product_name_input.Location = new System.Drawing.Point(356, 124);
            this.product_name_input.Name = "product_name_input";
            this.product_name_input.Size = new System.Drawing.Size(216, 22);
            this.product_name_input.TabIndex = 22;
            // 
            // product_price_input
            // 
            this.product_price_input.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.product_price_input.Location = new System.Drawing.Point(755, 65);
            this.product_price_input.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.product_price_input.Name = "product_price_input";
            this.product_price_input.Size = new System.Drawing.Size(207, 22);
            this.product_price_input.TabIndex = 31;
            // 
            // product_category_combobox
            // 
            this.product_category_combobox.FormattingEnabled = true;
            this.product_category_combobox.Items.AddRange(new object[] {
            "Startuese",
            "Mish",
            "Peshk",
            "Mesore",
            "Pije freskuese",
            "Alkool"});
            this.product_category_combobox.Location = new System.Drawing.Point(746, 141);
            this.product_category_combobox.Name = "product_category_combobox";
            this.product_category_combobox.Size = new System.Drawing.Size(216, 24);
            this.product_category_combobox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Category: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Price (ALL):";
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.YellowGreen;
            this.back_button.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back_button.Location = new System.Drawing.Point(403, 355);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(169, 42);
            this.back_button.TabIndex = 34;
            this.back_button.Text = "< Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.YellowGreen;
            this.update_button.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_button.Location = new System.Drawing.Point(578, 355);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(169, 42);
            this.update_button.TabIndex = 33;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.product_price_input);
            this.Controls.Add(this.product_category_combobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_sku_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.product_desc_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_name_input);
            this.Name = "EditProduct";
            this.Size = new System.Drawing.Size(1500, 900);
            ((System.ComponentModel.ISupportInitialize)(this.product_price_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_sku_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox product_desc_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_name_input;
        private System.Windows.Forms.NumericUpDown product_price_input;
        private System.Windows.Forms.ComboBox product_category_combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button update_button;
    }
}
