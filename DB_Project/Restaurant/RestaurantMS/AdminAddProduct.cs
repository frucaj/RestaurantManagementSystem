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

namespace RestaurantMS
{
    public partial class AdminAddProduct : UserControl
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        public Panel MainPanel;

        public AdminAddProduct(Panel main_panel)
        {
            InitializeComponent();
            MainPanel = main_panel;
        }

        private void adminAddProductd_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields need to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectedProducts = "SELECT * FROM Products WHERE product_sku = @product_sku";
                        using (SqlCommand checkUsern = new SqlCommand(selectedProducts, connect))
                        {
                            // Daniel van brugen won't work
                            checkUsern.Parameters.AddWithValue("@product_sku", product_sku_input.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Product with sku "+ product_sku_input.Text.Trim() +" exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Products (Emri_artikullit, Pershkrimi_artikullit, Cmimi, Kategoria, product_sku) " +
                                    "VALUES(@Emri_artikullit, @Pershkrimi_artikullit, @Cmimi, @Kategoria, @product_sku)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@Emri_artikullit", product_name_input.Text);
                                    cmd.Parameters.AddWithValue("@Pershkrimi_artikullit", product_desc_input.Text);
                                    cmd.Parameters.AddWithValue("@Cmimi", product_price_input.Value);
                                    cmd.Parameters.AddWithValue("@Kategoria", product_category_combobox.SelectedItem);
                                    cmd.Parameters.AddWithValue("@product_sku", product_sku_input.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                            }
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

        public void clearFields()
        {
            product_name_input.Text = string.Empty;
            product_desc_input.Text = string.Empty;
            product_price_input.Value = 0;
            product_category_combobox.SelectedItem = null;
            product_sku_input.Text = string.Empty;
        }

        private void LoadData()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string query = "SELECT * FROM Products";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

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

        public bool emptyFields()
        {
            if (product_name_input.Text == "" || product_desc_input.Text == "" || product_price_input.Value == 0 || product_category_combobox.SelectedItem == null || product_sku_input.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void adminAddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                var productId = Convert.ToInt32(selectedRow.Cells["ID_Artikull"].Value);
                var productName = selectedRow.Cells["Emri_artikullit"].Value.ToString();
                var productDesc = selectedRow.Cells["Pershkrimi_artikullit"].Value.ToString();
                var price = Convert.ToInt32(selectedRow.Cells["Cmimi"].Value.ToString());
                var product_category = selectedRow.Cells["Kategoria"].Value.ToString();
                var productSku = selectedRow.Cells["product_sku"].Value.ToString();

                LoadPage(new EditProduct(productName, productDesc, productSku, price, productId, product_category, MainPanel));
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
    }
}
