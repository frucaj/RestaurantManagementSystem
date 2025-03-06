namespace RestaurantMS
{
    partial class AdminReservations
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
            this.reservations_listbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reserve_bitton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.client_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nr_persons_cb = new System.Windows.Forms.ComboBox();
            this.table_cb = new System.Windows.Forms.ComboBox();
            this.remove_reservation = new System.Windows.Forms.Button();
            this.reservation_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reservations_listbox
            // 
            this.reservations_listbox.FormattingEnabled = true;
            this.reservations_listbox.Location = new System.Drawing.Point(22, 64);
            this.reservations_listbox.Name = "reservations_listbox";
            this.reservations_listbox.Size = new System.Drawing.Size(364, 537);
            this.reservations_listbox.TabIndex = 0;
            this.reservations_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upcoming";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Closed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reserve_bitton
            // 
            this.reserve_bitton.Location = new System.Drawing.Point(679, 344);
            this.reserve_bitton.Name = "reserve_bitton";
            this.reserve_bitton.Size = new System.Drawing.Size(125, 67);
            this.reserve_bitton.TabIndex = 3;
            this.reserve_bitton.Text = "Reserve!";
            this.reserve_bitton.UseVisualStyleBackColor = true;
            this.reserve_bitton.Click += new System.EventHandler(this.reserve_bitton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(675, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. Persona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Table:";
            // 
            // client_cb
            // 
            this.client_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_cb.FormattingEnabled = true;
            this.client_cb.Location = new System.Drawing.Point(680, 204);
            this.client_cb.Name = "client_cb";
            this.client_cb.Size = new System.Drawing.Size(247, 28);
            this.client_cb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client:";
            // 
            // nr_persons_cb
            // 
            this.nr_persons_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_persons_cb.FormattingEnabled = true;
            this.nr_persons_cb.Location = new System.Drawing.Point(679, 51);
            this.nr_persons_cb.Name = "nr_persons_cb";
            this.nr_persons_cb.Size = new System.Drawing.Size(187, 28);
            this.nr_persons_cb.TabIndex = 10;
            this.nr_persons_cb.SelectedIndexChanged += new System.EventHandler(this.nr_persons_cb_SelectedIndexChanged);
            // 
            // table_cb
            // 
            this.table_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_cb.FormattingEnabled = true;
            this.table_cb.Location = new System.Drawing.Point(679, 124);
            this.table_cb.Name = "table_cb";
            this.table_cb.Size = new System.Drawing.Size(187, 28);
            this.table_cb.TabIndex = 11;
            // 
            // remove_reservation
            // 
            this.remove_reservation.Location = new System.Drawing.Point(22, 607);
            this.remove_reservation.Name = "remove_reservation";
            this.remove_reservation.Size = new System.Drawing.Size(80, 43);
            this.remove_reservation.TabIndex = 12;
            this.remove_reservation.Text = "Close";
            this.remove_reservation.UseVisualStyleBackColor = true;
            this.remove_reservation.Click += new System.EventHandler(this.remove_reservation_Click);
            // 
            // reservation_date
            // 
            this.reservation_date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reservation_date.Location = new System.Drawing.Point(678, 287);
            this.reservation_date.Name = "reservation_date";
            this.reservation_date.Size = new System.Drawing.Size(284, 20);
            this.reservation_date.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date:";
            // 
            // AdminReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reservation_date);
            this.Controls.Add(this.remove_reservation);
            this.Controls.Add(this.table_cb);
            this.Controls.Add(this.nr_persons_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.client_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reserve_bitton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reservations_listbox);
            this.Name = "AdminReservations";
            this.Size = new System.Drawing.Size(1500, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox reservations_listbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button reserve_bitton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox client_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nr_persons_cb;
        private System.Windows.Forms.ComboBox table_cb;
        private System.Windows.Forms.Button remove_reservation;
        private System.Windows.Forms.DateTimePicker reservation_date;
        private System.Windows.Forms.Label label4;
    }
}
