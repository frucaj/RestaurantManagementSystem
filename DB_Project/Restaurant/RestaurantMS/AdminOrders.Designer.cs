namespace RestaurantMS
{
    partial class AdminOrders
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
            this.porosi_listbox = new System.Windows.Forms.ListBox();
            this.open_orders = new System.Windows.Forms.Button();
            this.closed_orders = new System.Windows.Forms.Button();
            this.create_order = new System.Windows.Forms.Button();
            this.edit_order = new System.Windows.Forms.Button();
            this.tavolina_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kamarier_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.client_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.artikuj_listbox = new System.Windows.Forms.ListBox();
            this.totali_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.refresh_Button = new System.Windows.Forms.Button();
            this.payment_button = new System.Windows.Forms.Button();
            this.payment_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closed_order_paymentmethod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // porosi_listbox
            // 
            this.porosi_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porosi_listbox.FormattingEnabled = true;
            this.porosi_listbox.ItemHeight = 26;
            this.porosi_listbox.Location = new System.Drawing.Point(40, 84);
            this.porosi_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.porosi_listbox.Name = "porosi_listbox";
            this.porosi_listbox.Size = new System.Drawing.Size(268, 420);
            this.porosi_listbox.TabIndex = 0;
            this.porosi_listbox.SelectedIndexChanged += new System.EventHandler(this.porosi_listbox_SelectedIndexChanged);
            // 
            // open_orders
            // 
            this.open_orders.Location = new System.Drawing.Point(40, 44);
            this.open_orders.Margin = new System.Windows.Forms.Padding(2);
            this.open_orders.Name = "open_orders";
            this.open_orders.Size = new System.Drawing.Size(83, 36);
            this.open_orders.TabIndex = 1;
            this.open_orders.Text = "Active";
            this.open_orders.UseVisualStyleBackColor = true;
            this.open_orders.Click += new System.EventHandler(this.open_orders_Click);
            // 
            // closed_orders
            // 
            this.closed_orders.Location = new System.Drawing.Point(225, 44);
            this.closed_orders.Margin = new System.Windows.Forms.Padding(2);
            this.closed_orders.Name = "closed_orders";
            this.closed_orders.Size = new System.Drawing.Size(83, 36);
            this.closed_orders.TabIndex = 2;
            this.closed_orders.Text = "Closed";
            this.closed_orders.UseVisualStyleBackColor = true;
            this.closed_orders.Click += new System.EventHandler(this.closed_orders_Click);
            // 
            // create_order
            // 
            this.create_order.Location = new System.Drawing.Point(40, 509);
            this.create_order.Margin = new System.Windows.Forms.Padding(2);
            this.create_order.Name = "create_order";
            this.create_order.Size = new System.Drawing.Size(83, 36);
            this.create_order.TabIndex = 3;
            this.create_order.Text = "Create";
            this.create_order.UseVisualStyleBackColor = true;
            this.create_order.Click += new System.EventHandler(this.create_order_Click);
            // 
            // edit_order
            // 
            this.edit_order.Location = new System.Drawing.Point(127, 508);
            this.edit_order.Margin = new System.Windows.Forms.Padding(2);
            this.edit_order.Name = "edit_order";
            this.edit_order.Size = new System.Drawing.Size(94, 36);
            this.edit_order.TabIndex = 4;
            this.edit_order.Text = "Edit";
            this.edit_order.UseVisualStyleBackColor = true;
            this.edit_order.Click += new System.EventHandler(this.edit_order_Click);
            // 
            // tavolina_label
            // 
            this.tavolina_label.AutoSize = true;
            this.tavolina_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tavolina_label.Location = new System.Drawing.Point(614, 56);
            this.tavolina_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tavolina_label.Name = "tavolina_label";
            this.tavolina_label.Size = new System.Drawing.Size(0, 24);
            this.tavolina_label.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tavolina:";
            // 
            // kamarier_label
            // 
            this.kamarier_label.AutoSize = true;
            this.kamarier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kamarier_label.Location = new System.Drawing.Point(614, 109);
            this.kamarier_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kamarier_label.Name = "kamarier_label";
            this.kamarier_label.Size = new System.Drawing.Size(0, 24);
            this.kamarier_label.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kamarieri:";
            // 
            // client_label
            // 
            this.client_label.AutoSize = true;
            this.client_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_label.Location = new System.Drawing.Point(614, 153);
            this.client_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.client_label.Name = "client_label";
            this.client_label.Size = new System.Drawing.Size(0, 24);
            this.client_label.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Klient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Artikuj:";
            // 
            // artikuj_listbox
            // 
            this.artikuj_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artikuj_listbox.FormattingEnabled = true;
            this.artikuj_listbox.ItemHeight = 26;
            this.artikuj_listbox.Location = new System.Drawing.Point(520, 244);
            this.artikuj_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.artikuj_listbox.Name = "artikuj_listbox";
            this.artikuj_listbox.Size = new System.Drawing.Size(452, 212);
            this.artikuj_listbox.TabIndex = 14;
            // 
            // totali_label
            // 
            this.totali_label.AutoSize = true;
            this.totali_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totali_label.Location = new System.Drawing.Point(614, 480);
            this.totali_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totali_label.Name = "totali_label";
            this.totali_label.Size = new System.Drawing.Size(0, 24);
            this.totali_label.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Totali:";
            // 
            // refresh_Button
            // 
            this.refresh_Button.Location = new System.Drawing.Point(225, 508);
            this.refresh_Button.Margin = new System.Windows.Forms.Padding(2);
            this.refresh_Button.Name = "refresh_Button";
            this.refresh_Button.Size = new System.Drawing.Size(83, 36);
            this.refresh_Button.TabIndex = 17;
            this.refresh_Button.Text = "Refresh";
            this.refresh_Button.UseVisualStyleBackColor = true;
            this.refresh_Button.Click += new System.EventHandler(this.refresh_Button_Click_1);
            // 
            // payment_button
            // 
            this.payment_button.Location = new System.Drawing.Point(520, 585);
            this.payment_button.Margin = new System.Windows.Forms.Padding(2);
            this.payment_button.Name = "payment_button";
            this.payment_button.Size = new System.Drawing.Size(106, 60);
            this.payment_button.TabIndex = 18;
            this.payment_button.Text = "Paguaj";
            this.payment_button.UseVisualStyleBackColor = true;
            this.payment_button.Click += new System.EventHandler(this.payment_button_Click);
            // 
            // payment_combobox
            // 
            this.payment_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_combobox.FormattingEnabled = true;
            this.payment_combobox.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Check"});
            this.payment_combobox.Location = new System.Drawing.Point(692, 523);
            this.payment_combobox.Name = "payment_combobox";
            this.payment_combobox.Size = new System.Drawing.Size(164, 28);
            this.payment_combobox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 524);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Metoda e pageses:";
            // 
            // closed_order_paymentmethod
            // 
            this.closed_order_paymentmethod.AutoSize = true;
            this.closed_order_paymentmethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closed_order_paymentmethod.Location = new System.Drawing.Point(709, 524);
            this.closed_order_paymentmethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closed_order_paymentmethod.Name = "closed_order_paymentmethod";
            this.closed_order_paymentmethod.Size = new System.Drawing.Size(0, 24);
            this.closed_order_paymentmethod.TabIndex = 21;
            // 
            // AdminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closed_order_paymentmethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.payment_combobox);
            this.Controls.Add(this.payment_button);
            this.Controls.Add(this.refresh_Button);
            this.Controls.Add(this.totali_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.artikuj_listbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.client_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kamarier_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tavolina_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_order);
            this.Controls.Add(this.create_order);
            this.Controls.Add(this.closed_orders);
            this.Controls.Add(this.open_orders);
            this.Controls.Add(this.porosi_listbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminOrders";
            this.Size = new System.Drawing.Size(1125, 731);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox porosi_listbox;
        private System.Windows.Forms.Button open_orders;
        private System.Windows.Forms.Button closed_orders;
        private System.Windows.Forms.Button create_order;
        private System.Windows.Forms.Button edit_order;
        private System.Windows.Forms.Label tavolina_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kamarier_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label client_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox artikuj_listbox;
        private System.Windows.Forms.Label totali_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button refresh_Button;
        private System.Windows.Forms.Button payment_button;
        private System.Windows.Forms.ComboBox payment_combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label closed_order_paymentmethod;
    }
}
