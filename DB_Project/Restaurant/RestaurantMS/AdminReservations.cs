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
    public partial class AdminReservations : UserControl
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);

        public AdminReservations()
        {
            InitializeComponent();
            LoadData();
            table_cb.Items.Clear();
            table_cb.Enabled = false;
            reservations_listbox.Items.Clear();
            LoadUpcomingReservations(1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            table_cb.Enabled = false;
            LoadNrPersonsComboBox();
            LoadClientsComboBox();
        }

        public void LoadNrPersonsComboBox()
        {
            var items = new Dictionary<int, string>
            {
                { 2, "2" },
                { 4, "4" },
                { 8, "8" },
                { 10, "10" }
            };

            nr_persons_cb.DataSource = new BindingSource(items, null);
            nr_persons_cb.DisplayMember = "Value";
            nr_persons_cb.ValueMember = "Key";

            nr_persons_cb.SelectedItem = null;
        }

        public void LoadClientsComboBox()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                string query = "SELECT ID_Klient, Emer_Klienti FROM Klient";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                client_cb.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Klient"], (string)reader["Emer_Klienti"]));
                            }
                            client_cb.DisplayMember = "Value";
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

        private void nr_persons_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nr_persons_cb.SelectedItem != null)
            {
                LoadTavolinaComboBox();
            }
        }

        public void LoadTavolinaComboBox()
        {
            table_cb.Items.Clear();
            KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)nr_persons_cb.SelectedItem;

            string query = "SELECT ID_Tavolina, Nr_tavoline FROM Tavolina Where Status = @Status AND Kapaciteti = @Kapaciteti";

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Status", 1);
                        command.Parameters.AddWithValue("@Kapaciteti", selectedItem.Key);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                table_cb.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Tavolina"], (string)reader["Nr_tavoline"] + ""));
                                while (reader.Read())
                                {
                                    table_cb.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Tavolina"], (string)reader["Nr_tavoline"] + ""));
                                }
                                table_cb.DisplayMember = "Value";
                                table_cb.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("No available tables");
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

        private void reserve_bitton_Click(object sender, EventArgs e)
        {
            if (emptyInputs())
            {
                MessageBox.Show("Make sure all inputs are selected!");
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        KeyValuePair<int, string> selectedNrPeople = (KeyValuePair<int, string>)nr_persons_cb.SelectedItem;
                        KeyValuePair<int, string> selectedTableNumber = (KeyValuePair<int, string>)table_cb.SelectedItem;
                        KeyValuePair<int, string> selectedClient = (KeyValuePair<int, string>)client_cb.SelectedItem;

                        string insertData = "INSERT INTO Rezervimet (Data_Ora_Rezervimit, Nr_personave, Statusi_rezervimit, ID_Klient, ID_Tavolina) " +
                                    "VALUES(@Data_Ora_Rezervimit, @Nr_personave, @Statusi_rezervimit, @ID_Klient, @ID_Tavolina)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@Data_Ora_Rezervimit", reservation_date.Value);
                            cmd.Parameters.AddWithValue("@Nr_personave", selectedNrPeople.Key);
                            cmd.Parameters.AddWithValue("@Statusi_rezervimit", 1);
                            cmd.Parameters.AddWithValue("@ID_Klient", selectedClient.Key);
                            cmd.Parameters.AddWithValue("@ID_Tavolina", selectedTableNumber.Key);

                            cmd.ExecuteNonQuery();
                            clearInputs();
                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ChangeTableStatus(selectedTableNumber.Key, 0);
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void clearInputs()
        {
            nr_persons_cb.SelectedItem = null;
            table_cb.SelectedItem = null;
            client_cb.SelectedItem = null;
        }

        public void ChangeTableStatus(int TableID, int status)
        {
            bool closeAtEnd = false;
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                closeAtEnd = true;  
            }
            string query = "Update Tavolina Set Status = @Status Where ID_Tavolina = @ID_Tavolina";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ID_Tavolina", TableID);


                    if (command.ExecuteNonQuery() > 0)
                    {
                    }
                    else
                    {
                        MessageBox.Show("Something whent wrong!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (closeAtEnd)
                {
                    connect.Close() ;
                }
            }
        }

        public bool emptyInputs()
        {
            if (nr_persons_cb.SelectedItem == null || table_cb.SelectedItem == null || client_cb.SelectedItem == null)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservations_listbox.Items.Clear();
            LoadUpcomingReservations(1);
        }

        public void LoadUpcomingReservations(int status)
        {
            if (connect.State == ConnectionState.Closed)
            {
                string query = "SELECT * FROM Rezervimet Where Statusi_rezervimit = @Statusi_rezervimit ORDER BY Data_Ora_Rezervimit ASC";
                try
                {
                    connect.Open();
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Statusi_rezervimit", status);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reservations_listbox.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Rezervime"], "Tavolina: " + getTavolinaById((int)reader["ID_Tavolina"]) + " | Klienti: " + getClientById((int)reader["ID_Klient"]) + " | " + reader["Data_Ora_Rezervimit"]));
                                while (reader.Read())
                                {
                                    reservations_listbox.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Rezervime"], "Tavolina: " + getTavolinaById((int)reader["ID_Tavolina"]) + " | Klienti: " + getClientById((int)reader["ID_Klient"]) + " | " + reader["Data_Ora_Rezervimit"]));
                                }
                                reservations_listbox.DisplayMember = "Value";
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
                        while(reader.Read())
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

        private void button2_Click(object sender, EventArgs e)
        {
            reservations_listbox.Items.Clear();
            LoadUpcomingReservations(0);
        }

        private void remove_reservation_Click(object sender, EventArgs e)
        {
            if (reservations_listbox.SelectedIndex >= 0)
            {
                KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)reservations_listbox.SelectedItem;
                UpdateReservationStatus(0, selectedItem.Key);
                reservations_listbox.Items.RemoveAt(reservations_listbox.SelectedIndex);
                int tavolinaID = getTavolinaByReservationId(selectedItem.Key);
                ChangeTableStatus(tavolinaID, 1);
            }
            else
            {
                MessageBox.Show("Please select a reservation to remove!");
            }
        }

        public int getTavolinaByReservationId(int reservationId)
        {
            string query = "Select ID_Tavolina From Rezervimet Where ID_Rezervime = @ID_Rezervime";
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connect))
                        {
                            command.Parameters.AddWithValue("@ID_Rezervime", reservationId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    return (int)reader["ID_Tavolina"];
                                }
                            }
                        }
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
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
            return 0;
        }
        public void UpdateReservationStatus(int status, int ID)
        {
            string query = "Update Rezervimet Set Statusi_rezervimit = @Statusi_rezervimit Where ID_Rezervime = @ID_Rezervime";
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Statusi_rezervimit", status);
                        command.Parameters.AddWithValue("@ID_Rezervime", ID);


                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something whent wrong!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
