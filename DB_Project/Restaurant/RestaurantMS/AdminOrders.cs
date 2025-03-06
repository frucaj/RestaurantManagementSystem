using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantMS
{
    public partial class AdminOrders : UserControl
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        int selectedOrderId = 0;
        int viewByStatus = 1;
        int currentSelectedOrderId, currentSelectedOrderTotal;

        public AdminOrders()
        {
            InitializeComponent();
            LoadOrdersByStatus(1);
        }

        private void create_order_Click(object sender, EventArgs e)
        {
            FormTest formTest = new FormTest(false);
            formTest.ShowDialog();
        }

        private void edit_order_Click(object sender, EventArgs e)
        {
            if (porosi_listbox.Items.Count > 0) {
                KeyValuePair<int, string> selectedPorosi = (KeyValuePair<int, string>)porosi_listbox.SelectedItem;

                FormTest formTest = new FormTest(true, selectedPorosi.Key);
                formTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an order to edit!");
            }
        }

        public void LoadOrdersByStatus(int status)
        {
            if (connect.State == ConnectionState.Closed)
            {
                string query = "SELECT * FROM Porosi Where Status_porosise = @Status_porosise ORDER BY Data_ora_porosise ASC";
                porosi_listbox.Items.Clear();
                try
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Status_porosise", status);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                porosi_listbox.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Porosi"], "Tavolina: " + getTavolinaById((int)reader["ID_Tavolina"])));
                                while (reader.Read())
                                {
                                    porosi_listbox.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Porosi"], "Tavolina: " + getTavolinaById((int)reader["ID_Tavolina"])));
                                }
                                porosi_listbox.DisplayMember = "Value";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public string getTavolinaById(int ID)
        {
            string query = "SELECT Nr_tavoline FROM Tavolina Where ID_Tavolina = @ID_Tavolina";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Tavolina", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (string)reader["Nr_tavoline"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return "";
        }

        private void porosi_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (porosi_listbox.SelectedItems.Count > 0)
            {
                KeyValuePair<int, string> selectedPorosi = (KeyValuePair<int, string>)porosi_listbox.SelectedItem;
                artikuj_listbox.Items.Clear();
                selectedOrderId = selectedPorosi.Key;
                string query = "SELECT * From Porosi Where ID_Porosi = @ID_Porosi";

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        using (SqlCommand command = new SqlCommand(query, connect))
                        {
                            command.Parameters.AddWithValue("@ID_Porosi", selectedPorosi.Key);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    tavolina_label.Text = getTavolinaById((int)reader["ID_Tavolina"]);
                                    kamarier_label.Text = getKamarierName(getKamarierId((int)reader["ID_Tavolina"]));
                                    client_label.Text = getClientById((int)reader["ID_Klient"]);
                                    PopulateArtikujListbox(reader["ID_Artikuj"].ToString());
                                    totali_label.Text = reader["Totali"].ToString();

                                    currentSelectedOrderId = selectedPorosi.Key;
                                    currentSelectedOrderTotal = (int)reader["Totali"];
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            if(viewByStatus == 0)
            {
                getCurrentOrderPaymentMethod();
            }
        }

        public void PopulateArtikujListbox(string artikujList)
        {
            Array artikuj = artikujList.Split(',');
            if (artikuj.Length > 0 )
            {
                foreach (string i in artikuj)
                {
                    if (i != string.Empty)
                    {
                        int artikullId = Convert.ToInt32(i);

                        string query = "SELECT * FROM Products Where ID_Artikull = @ID_Artikull";

                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connect))
                            {
                                command.Parameters.AddWithValue("@ID_Artikull", artikullId);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        artikuj_listbox.Items.Add((string)reader["Emri_artikullit"] + "       " + (string)reader["Cmimi"].ToString() + " Leke");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        public string getClientById(int ID)
        {
            string query = "SELECT * FROM Klient Where ID_Klient = @ID_Klient";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Klient", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return (string)reader["Emer_Klienti"] + " " + (string)reader["Mbiemer_Klienti"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return "";
        }

        public int getKamarierId(int TavolinaID)
        {
            string query = "SELECT ID_Kamarier FROM Tavolina Where ID_Tavolina = @ID_Tavolina";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Tavolina", TavolinaID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["ID_Kamarier"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return 0;
        }

        public string getKamarierName(int Id)
        {
            string query = "Select Emer_Kamarier From Kamarier Where ID_Kamarier = @ID_Kamarier";
            try
            {

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Kamarier", Id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Emer_kamarier"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return "";
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
        }

        private void refresh_Button_Click_1(object sender, EventArgs e)
        {
            LoadOrdersByStatus(viewByStatus);
        }

        private void closed_orders_Click(object sender, EventArgs e)
        {
            viewByStatus = 0;
            LoadOrdersByStatus(viewByStatus);
            payment_button.Enabled = false;
            payment_combobox.Enabled = false;
            payment_combobox.SelectedIndex = -1;
            payment_combobox.Hide();
            closed_order_paymentmethod.Show();
            ClearInputs();
        }

        public void getCurrentOrderPaymentMethod()
        {
            if (connect.State == ConnectionState.Closed)
            {
                string query = "Select * From Pagesat Where ID_order = @ID_order";
                try
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@ID_order", currentSelectedOrderId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                closed_order_paymentmethod.Text = reader["Metoda_pageses"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void open_orders_Click(object sender, EventArgs e)
        {
            viewByStatus = 1;
            LoadOrdersByStatus(viewByStatus);
            payment_button.Enabled = true;
            payment_combobox.Enabled = true;
            payment_combobox.Show();
            closed_order_paymentmethod.Hide();
            closed_order_paymentmethod.Text = string.Empty;
            ClearInputs();
        }

        private void payment_button_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                string query = "Insert into Pagesat (Metoda_pageses, Shuma_paguar, Data_ora_pageses, ID_order) Values (@Metoda_pageses, @Shuma_paguar, @Data_ora_pageses, @ID_order)";
                porosi_listbox.Items.Clear();
                try
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Metoda_pageses", payment_combobox.SelectedItem);
                        command.Parameters.AddWithValue("@Shuma_paguar", currentSelectedOrderTotal);
                        command.Parameters.AddWithValue("@Data_ora_pageses", DateTime.Now);
                        command.Parameters.AddWithValue("@ID_order", currentSelectedOrderId);

                        command.ExecuteNonQuery();

                        updateOrder();
                        MessageBox.Show("Payment successful!");
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void ClearInputs()
        {
            tavolina_label.Text = string.Empty;
            kamarier_label.Text = string.Empty;
            client_label.Text = string.Empty;
            artikuj_listbox.Items.Clear();
            totali_label.Text = string.Empty;
            payment_combobox.SelectedIndex = -1;
        }

        public void updateOrder()
        {
            changeCurrentOrderStatus(0);
            int reservationId = getReservationIdByOrder();
            UpdateReservationStatus(0, reservationId);
            ChangeTableStatus(getTableIdByReservation(reservationId), 1);
        }

        public int getTableIdByReservation(int reservation_id)
        {
            string query = "Select * From Rezervimet Where ID_Rezervime = @ID_Rezervime";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Rezervime", reservation_id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (int)reader["ID_Tavolina"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return 0;
        }

        public void ChangeTableStatus(int TableID, int status)
        {
            string query = "Update Tavolina Set Status = @Status Where ID_Tavolina = @ID_Tavolina";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ID_Tavolina", TableID);


                    if (command.ExecuteNonQuery() <= 0)
                    {
                        MessageBox.Show("Something whent wrong!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void changeCurrentOrderStatus(int statusId)
        {
            string query = "Update Porosi Set Status_porosise = @Status_porosise Where ID_Porosi = @ID_Porosi";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Status_porosise", statusId);
                    command.Parameters.AddWithValue("@ID_Porosi", currentSelectedOrderId);


                    if (command.ExecuteNonQuery() <= 0)
                    {
                        MessageBox.Show("Something whent wrong!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void UpdateReservationStatus(int status, int ID)
        {
            string query = "Update Rezervimet Set Statusi_rezervimit = @Statusi_rezervimit Where ID_Rezervime = @ID_Rezervime";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Statusi_rezervimit", status);
                    command.Parameters.AddWithValue("@ID_Rezervime", ID);

                    if (command.ExecuteNonQuery() <= 0)
                    {
                        MessageBox.Show("Something whent wrong!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public int getReservationIdByOrder()
        {
            string query = "Select * From Porosi Where ID_Porosi = @ID_Porosi";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Porosi", currentSelectedOrderId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (int)reader["ID_Reservation"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return 0;
        }
    }
}
