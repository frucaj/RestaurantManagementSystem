using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RestaurantMS
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        int userRole;
        public LoginForm()
        {
            InitializeComponent();
            LoadRoleCombobox();
        }

        public void LoadRoleCombobox()
        {
            var roles = new Dictionary<int, string>
            {
                { 1, "Admin" },
                { 2, "Kamarier" }
            };

            roles_combobox.DataSource = new BindingSource(roles, null);
            roles_combobox.DisplayMember = "Value";
            roles_combobox.ValueMember = "Key";

            roles_combobox.SelectedItem = null;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }


        public bool emptyFields()
        {
            if (login_username.Text == "" || login_password.Text == "" || roles_combobox.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public bool VerifyPassword(string inputPassword, string storedHashedPassword)
        {
            // Hash the user's input password
            string hashedInputPassword = HashPassword(inputPassword);

            // Compare the hashed input password with the stored hashed password
            return hashedInputPassword == storedHashedPassword;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectAccount = "";
                        if (userRole == 1)
                        {
                            selectAccount = "SELECT * FROM Users WHERE username = @usern";
                        }
                        else
                        {
                            selectAccount = "SELECT * FROM Kamarier WHERE username = @usern";
                        }
                        using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                if (VerifyPassword(login_password.Text.Trim(), table.Rows[0]["password"].ToString()))
                                {
                                    MessageBox.Show("Logged in successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AdminMainForm adminForm = new AdminMainForm(userRole);
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Username/Passsword or there is no Admin's approval.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Passsword or there is no Admin's approval.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void roles_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roles_combobox.SelectedIndex != -1) 
            {
                var selectedItem = (KeyValuePair<int, string>)roles_combobox.SelectedItem;
                userRole = selectedItem.Key;
            }
        }
    }
}
