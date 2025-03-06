using System;
using System.Collections;
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
    public partial class FormTest : Form
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        int clientId, tavolinaId, orderTotal;
        int orderId;
        bool isFormEditing;

        public FormTest(bool isEdit, int porosiId = 0)
        {
            InitializeComponent();
            if (isEdit)
            {
                isFormEditing = isEdit;
                orderId = porosiId;
                LoadReservationComboBox();
                reservation_combobox.Enabled = false;
                LoadEditingData();
                LoadProductsComboBox();
            }
            else
            {
                LoadData();
            }
        }

        public void LoadEditingData()
        {
            string query = "SELECT * From Porosi Where ID_Porosi = @ID_Porosi";

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@ID_Porosi", orderId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SetReservationComboBox((int)reader["ID_Reservation"]);
                                kamarier_label.Text = getKamarierName(getKamarierId((int)reader["ID_Tavolina"]));
                                client_label.Text = getClientById((int)reader["ID_Klient"]);
                                PopulateArtikujListbox(reader["ID_Artikuj"].ToString());
                                reservation_label.Text = getReservationTime((int)reader["ID_Reservation"]);
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

        public string getReservationTime(int reservationId)
        {
            string query = "SELECT * From Rezervimet Where ID_Rezervime = @ID_Rezervime";
            try
            {
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Rezervime", reservationId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Data_Ora_Rezervimit"].ToString();
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

        public void SetReservationComboBox(int ID)
        {
            int selectedIndex = -1;
            for (int i = 0; i < reservation_combobox.Items.Count; i++)
            {
                if (((KeyValuePair<int, string>)reservation_combobox.Items[i]).Key == ID)
                {
                    selectedIndex = i;
                    break;
                }
            }
            if (selectedIndex != -1)
            {
                reservation_combobox.SelectedIndex = selectedIndex;
            }
        }

        public void PopulateArtikujListbox(string artikujList)
        {
            Array artikuj = artikujList.Split(',');
            if (artikuj.Length > 0)
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
                                        order_products.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Artikull"], (string)reader["Emri_artikullit"] + "       " + reader["Cmimi"].ToString()));
                                        CalculateAndUpdateTotal(artikullId);
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
                order_products.DisplayMember = "Value";
            }
        }

        public void LoadData()
        {
            LoadReservationComboBox();
            LoadProductsComboBox();
        }

        public void LoadReservationComboBox()
        {
            string query = "SELECT * From Rezervimet Where Statusi_rezervimit = @Statusi_rezervimit";

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Statusi_rezervimit", 1);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reservation_combobox.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Rezervime"], "Tavolina: " + getTavolinaById((int)reader["ID_Tavolina"])));
                            }
                            reservation_combobox.DisplayMember = "Value";
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


        //public void LoadTableComboBox()
        //{
        //    string query = "SELECT ID_Tavolina, Nr_Tavoline FROM Tavolina Where Status = @status";

        //    if (connect.State == ConnectionState.Closed)
        //    {
        //        try
        //        {
        //            connect.Open();

        //            using (SqlCommand command = new SqlCommand(query, connect))
        //            {
        //                command.Parameters.AddWithValue("@status", 1);

        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        tavolina_combobox.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Tavolina"], (string)reader["Nr_Tavoline"]));
        //                    }
        //                    tavolina_combobox.DisplayMember = "Value";
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //        finally
        //        {
        //            connect.Close();
        //        }
        //    }
        //}

        public void LoadProductsComboBox()
        {
            string query = "SELECT * FROM Products";

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products_combobox.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Artikull"], (string)reader["Emri_artikullit"] + "       " + reader["Cmimi"].ToString()));
                            }
                            products_combobox.DisplayMember= "Value";
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

        private List<KeyValuePair<int, string>> selectedItems = new List<KeyValuePair<int, string>>();


        private void products_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (products_combobox.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)products_combobox.SelectedItem;

                order_products.Items.Add(new KeyValuePair<int, string>(selectedItem.Key, selectedItem.Value ));
                order_products.DisplayMember = "Value";
                CalculateAndUpdateTotal(selectedItem.Key);
            }
        }

        public void CalculateAndUpdateTotal(int ID)
        {
            string query = "Select Cmimi From Products Where ID_Artikull = @ID_Artikull";
            bool closeAtEnd = false;
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                closeAtEnd = true;
            }
            try
            {

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@ID_Artikull", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            UpdateTotal(Convert.ToInt32(reader["Cmimi"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if(closeAtEnd)
            {
                connect.Close();
            }
        }

        public void UpdateTotal(int price)
        {
            int sum;
            if(total_label.Text == string.Empty)
            {
                sum = 0;
            }
            else
            {
                sum = Convert.ToInt32(total_label.Text);
            }
            sum += price;
            orderTotal = sum;
            total_label.Text = sum.ToString();
        }

        private void remove_bttn_Click(object sender, EventArgs e)
        {
            if (order_products.SelectedIndex >= 0)
            {
                KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)order_products.SelectedItem;
                string sumToRemove = new string(selectedItem.Value.Where(char.IsDigit).ToArray());
                UpdateTotal(-Convert.ToInt32(sumToRemove));
                order_products.Items.RemoveAt(order_products.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item from the listbox.");
            }
        }

        private void create_bttn_Click(object sender, EventArgs e)
        {
            if(order_products.Items.Count != 0)
            {
                if(emptyInputs())
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

                            string insertData = "INSERT INTO Porosi (Data_ora_porosise, Status_porosise, ID_Klient, ID_Tavolina, ID_Artikuj, Totali, ID_Reservation) " +
                                     "VALUES(@Data_ora_porosise, @Status_porosise, @ID_Klient, @ID_Tavolina, @ID_Artikuj, @Totali, @ID_Reservation)";
                            if(isFormEditing)
                            {
                                insertData = "Update Porosi Set ID_Artikuj = @ID_Artikuj, Totali = @Totali Where ID_Porosi = @ID_Porosi";
                            }
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                if (isFormEditing)
                                {
                                    cmd.Parameters.AddWithValue("@ID_Artikuj", getArtikujId());
                                    cmd.Parameters.AddWithValue("@Totali", orderTotal);
                                    cmd.Parameters.AddWithValue("@ID_Porosi", orderId);

                                }
                                else
                                {
                                    KeyValuePair<int, string> selectedReservation = (KeyValuePair<int, string>)reservation_combobox.SelectedItem;

                                    cmd.Parameters.AddWithValue("@Data_ora_porosise", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@Status_porosise", 1);
                                    cmd.Parameters.AddWithValue("@ID_Klient", clientId);
                                    cmd.Parameters.AddWithValue("@ID_Tavolina", tavolinaId);
                                    cmd.Parameters.AddWithValue("@ID_Artikuj", getArtikujId());
                                    cmd.Parameters.AddWithValue("@Totali", orderTotal);
                                    cmd.Parameters.AddWithValue("@ID_Reservation", selectedReservation.Key);
                                }

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
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
            else
            {
                MessageBox.Show("Empty order cannot be created!");
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

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void reservation_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(reservation_combobox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid reservation!");
            }
            else
            {
                KeyValuePair<int, string> selectedReservation = (KeyValuePair<int, string>)reservation_combobox.SelectedItem;

                string query = "SELECT * From Rezervimet Where ID_Rezervime = @ID_Rezervime";

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        using (SqlCommand command = new SqlCommand(query, connect))
                        {
                            command.Parameters.AddWithValue("@ID_Rezervime", selectedReservation.Key);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    client_label.Text = getClientById((int)reader["ID_Klient"]);
                                    kamarier_label.Text = getKamarierName(getKamarierId((int)reader["ID_Tavolina"]));
                                    reservation_label.Text = reader["Data_Ora_Rezervimit"].ToString();

                                    clientId = (int)reader["ID_Klient"];
                                    tavolinaId = (int)reader["ID_Tavolina"];
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

        public string getArtikujId()
        {
            if (order_products.Items.Count != 0)
            {
                string ids = "";
                foreach (KeyValuePair<int, string> item in order_products.Items)
                {
                    int key = item.Key;
                    ids += key.ToString() + ",";
                }
                return ids;
            }
            else
            {
                MessageBox.Show("Empty order cannot be created!");
                return "";

            }
        }

        public bool emptyInputs()
        {
            if(reservation_combobox.SelectedItem == null)
            {
                return true;
            }
            return false;
        }
    }
}
