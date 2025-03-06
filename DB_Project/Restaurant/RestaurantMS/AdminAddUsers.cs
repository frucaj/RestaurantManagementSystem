using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
namespace RestaurantMS
{
    public partial class AdminAddUsers : UserControl
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        public Panel MainPanel;

        public AdminAddUsers(Panel main_panel)
        {
            InitializeComponent();
            InitializeComboBox();
            displayAddUsersData();
            MainPanel = main_panel;
        }

        public void InitializeComboBox()
        {
            var items = new Dictionary<int, string>
            {
                { 1, "Turni i pare" },
                { 2, "Turni i dyte" }
            };

            user_workinshift.DataSource = new BindingSource(items, null);
            user_workinshift.DisplayMember = "Value";
            user_workinshift.ValueMember = "Key";

            user_workinshift.SelectedItem = null;
        }

        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();
            dataGridView1.DataSource = listData;
        }


        public bool emptyFields()
        {
            if(user_name.Text == "" || user_lastname.Text == "" || username_textbox.Text == "" || user_password.Text == "" || user_phone.Text == "" || user_workinshift.SelectedItem == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if(emptyFields())
            {
                MessageBox.Show("All fields need to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectUsern = "SELECT * FROM Kamarier WHERE username = @username";
                        using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@username", username_textbox.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Username already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Kamarier (Emer_kamarier, Mbiemer_kamarier, username, Nr_celulari ,working_shift, password) " +
                                    "VALUES(@name, @lastname, @username, @phone, @working_shift, @password)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@name", user_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@lastname", user_lastname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", username_textbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phone", user_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@working_shift", GetWorkingShift());
                                    cmd.Parameters.AddWithValue("@password", HashPassword(user_password.Text.Trim()));

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                            }
                        }
                    }catch(Exception ex)
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

        public int GetWorkingShift()
        {
            if (user_workinshift.SelectedItem != null)
            {
                var selectedItem = (KeyValuePair<int, string>)user_workinshift.SelectedItem;
                int selectedKey = selectedItem.Key;
                string selectedValue = selectedItem.Value;

                return selectedKey;
            }
            return 0;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                var id= Convert.ToInt32(selectedRow.Cells["ID_Kamarier"].Value);
                var name = selectedRow.Cells["Emer_kamarier"].Value.ToString();
                var lastname = selectedRow.Cells["Mbiemer_kamarier"].Value.ToString();
                var username = selectedRow.Cells["username"].Value.ToString();
                var phone = selectedRow.Cells["Nr_celulari"].Value.ToString();
                var working_shift = Convert.ToInt32(selectedRow.Cells["working_shift"].Value);

                LoadPage(new EditUser(name, lastname, username, phone, working_shift, id, MainPanel));
            }
            else
            {
                MessageBox.Show("No row selected.");
            }
        }

        private void LoadPage(UserControl page)
        {
            // Clear the current view
            MainPanel.Controls.Clear();

            // Set the Dock property so the page fills the panel
            page.Dock = DockStyle.Fill;

            // Add the new page to the panel
            MainPanel.Controls.Add(page);
        }
        public void clearFields()
        {
            user_name.Text = string.Empty;
            user_lastname.Text = string.Empty;
            user_phone.Text = string.Empty;
            user_password.Text = string.Empty;
            user_workinshift.SelectedItem = null;
        }

        private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void adminAddUsers_deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a user to delete!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + user_name.Text.Trim()
                    + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM Kamarier WHERE ID_Kamarier = @id";
                            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(selectedRow.Cells["ID_Kamarier"].Value));

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    // Open the connection
                    connect.Open();

                    // SQL query to fetch data
                    string query = "SELECT * FROM Kamarier";

                    // Create a data adapter to fill a DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
