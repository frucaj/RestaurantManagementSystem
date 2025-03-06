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
    public partial class EditUser : UserControl
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        public int UserId;
        public Panel MainPanel;

        public EditUser(string name, string lastname, string username, string user_phone, int user_workingshift, int ID, Panel panel)
        {
            InitializeComponent();
            InitializeComboBox();
            MainPanel = panel;
            clearFields();
            LoadData(name, lastname, username, user_phone, user_workingshift, ID);
        }

        public void clearFields()
        {
            user_name.Text = string.Empty;
            user_lastname.Text = string.Empty;
            user_phone_input.Text = string.Empty;
            user_workinshift.SelectedItem = null;
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
        }

        public void LoadData(string name, string lastname, string username, string user_phone, int user_workingshift, int ID)
        {
            user_name.Text = name;
            user_lastname.Text = lastname;
            username_textbox.Text = username;
            user_phone_input.Text = user_phone;
            user_workinshift.SelectedValue = user_workingshift;
            UserId = ID;
        }

        public bool emptyFields()
        {
            if (user_name.Text == "" || user_lastname.Text == "" || username_textbox.Text == "" || user_phone_input.Text == "" || user_workinshift.SelectedItem == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update Username: " + user_name.Text.Trim()
                    + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Kamarier SET Emer_kamarier = @name, Mbiemer_kamarier = @lastname, username = @username, Nr_celulari = @phone, working_shift = @workingshift WHERE ID_Kamarier = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@name", user_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@lastname", user_lastname.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", username_textbox.Text.Trim());
                                cmd.Parameters.AddWithValue("@phone", user_phone_input.Text.Trim());
                                cmd.Parameters.AddWithValue("@workingshift", GetWorkingShift());
                                cmd.Parameters.AddWithValue("@id", UserId);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void back_button_Click(object sender, EventArgs e)
        {
            LoadPage(new AdminAddUsers(MainPanel));
        }

        private void LoadPage(UserControl page)
        {
            MainPanel.Controls.Clear();

            page.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(page);
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
