namespace RestaurantMS
{
    partial class FormTest
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kamarier_label = new System.Windows.Forms.Label();
            this.order_products = new System.Windows.Forms.ListBox();
            this.products_combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.remove_bttn = new System.Windows.Forms.Button();
            this.create_bttn = new System.Windows.Forms.Button();
            this.reservation_combobox = new System.Windows.Forms.ComboBox();
            this.client_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reservation_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kamarieri:";
            // 
            // kamarier_label
            // 
            this.kamarier_label.AutoSize = true;
            this.kamarier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kamarier_label.Location = new System.Drawing.Point(456, 74);
            this.kamarier_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kamarier_label.Name = "kamarier_label";
            this.kamarier_label.Size = new System.Drawing.Size(0, 24);
            this.kamarier_label.TabIndex = 5;
            // 
            // order_products
            // 
            this.order_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_products.FormattingEnabled = true;
            this.order_products.ItemHeight = 26;
            this.order_products.Location = new System.Drawing.Point(9, 74);
            this.order_products.Margin = new System.Windows.Forms.Padding(2);
            this.order_products.Name = "order_products";
            this.order_products.Size = new System.Drawing.Size(310, 264);
            this.order_products.TabIndex = 6;
            // 
            // products_combobox
            // 
            this.products_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.products_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.products_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_combobox.FormattingEnabled = true;
            this.products_combobox.Location = new System.Drawing.Point(362, 245);
            this.products_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.products_combobox.Name = "products_combobox";
            this.products_combobox.Size = new System.Drawing.Size(244, 28);
            this.products_combobox.TabIndex = 15;
            this.products_combobox.SelectedIndexChanged += new System.EventHandler(this.products_combobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Artikuj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Totali:";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(451, 299);
            this.total_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(0, 24);
            this.total_label.TabIndex = 18;
            // 
            // remove_bttn
            // 
            this.remove_bttn.Location = new System.Drawing.Point(244, 359);
            this.remove_bttn.Margin = new System.Windows.Forms.Padding(2);
            this.remove_bttn.Name = "remove_bttn";
            this.remove_bttn.Size = new System.Drawing.Size(74, 45);
            this.remove_bttn.TabIndex = 19;
            this.remove_bttn.Text = "Remove";
            this.remove_bttn.UseVisualStyleBackColor = true;
            this.remove_bttn.Click += new System.EventHandler(this.remove_bttn_Click);
            // 
            // create_bttn
            // 
            this.create_bttn.Location = new System.Drawing.Point(9, 359);
            this.create_bttn.Margin = new System.Windows.Forms.Padding(2);
            this.create_bttn.Name = "create_bttn";
            this.create_bttn.Size = new System.Drawing.Size(74, 45);
            this.create_bttn.TabIndex = 20;
            this.create_bttn.Text = "Confirm";
            this.create_bttn.UseVisualStyleBackColor = true;
            this.create_bttn.Click += new System.EventHandler(this.create_bttn_Click);
            // 
            // reservation_combobox
            // 
            this.reservation_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.reservation_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.reservation_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_combobox.FormattingEnabled = true;
            this.reservation_combobox.Location = new System.Drawing.Point(13, 29);
            this.reservation_combobox.Margin = new System.Windows.Forms.Padding(2);
            this.reservation_combobox.Name = "reservation_combobox";
            this.reservation_combobox.Size = new System.Drawing.Size(244, 28);
            this.reservation_combobox.TabIndex = 21;
            this.reservation_combobox.SelectedIndexChanged += new System.EventHandler(this.reservation_combobox_SelectedIndexChanged);
            // 
            // client_label
            // 
            this.client_label.AutoSize = true;
            this.client_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_label.Location = new System.Drawing.Point(455, 114);
            this.client_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.client_label.Name = "client_label";
            this.client_label.Size = new System.Drawing.Size(0, 24);
            this.client_label.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Klienti:";
            // 
            // reservation_label
            // 
            this.reservation_label.AutoSize = true;
            this.reservation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_label.Location = new System.Drawing.Point(524, 160);
            this.reservation_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reservation_label.Name = "reservation_label";
            this.reservation_label.Size = new System.Drawing.Size(0, 24);
            this.reservation_label.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Reservation Time:";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 414);
            this.Controls.Add(this.reservation_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.client_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.reservation_combobox);
            this.Controls.Add(this.create_bttn);
            this.Controls.Add(this.remove_bttn);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.products_combobox);
            this.Controls.Add(this.order_products);
            this.Controls.Add(this.kamarier_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kamarier_label;
        private System.Windows.Forms.ListBox order_products;
        private System.Windows.Forms.ComboBox products_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Button remove_bttn;
        private System.Windows.Forms.Button create_bttn;
        private System.Windows.Forms.ComboBox reservation_combobox;
        private System.Windows.Forms.Label client_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label reservation_label;
        private System.Windows.Forms.Label label7;
    }
}