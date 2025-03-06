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
using System.Xml.Linq;
using Telerik.SvgIcons;

namespace RestaurantMS
{
    public partial class EditProduct : UserControl
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        public int ProductId;
        public Panel MainPanel;

        public EditProduct(string productName, string productDesc, string productSku, int price, int productId, string product_category, Panel panel)
        {
            InitializeComponent();
            MainPanel = panel;
            clearFields();
            LoadData(productName, productDesc, productSku, price, product_category, productId);

        }

        public void clearFields()
        {
            product_name_input.Text = string.Empty;
            product_desc_input.Text = string.Empty;
            product_price_input.Value = 0;
            product_category_combobox.SelectedItem = null;
            product_sku_input.Text = string.Empty;
        }

        public void LoadData(string productName, string productDesc, string productSku, int price, string product_category, int productId)
        {
            product_name_input.Text = productName;
            product_desc_input.Text = productDesc;
            product_sku_input.Text = productSku;
            product_price_input.Value = (int)price;
            product_category_combobox.SelectedItem = product_category;
            ProductId = productId;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            LoadPage(new AdminAddProduct(MainPanel));
        }

        private void LoadPage(UserControl page)
        {
            MainPanel.Controls.Clear();

            page.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(page);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update product with sku: " + product_sku_input.Text
                    + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Products SET Emri_artikullit = @Emri_artikullit, Pershkrimi_artikullit = @Pershkrimi_artikullit, Cmimi = @Cmimi, Kategoria = @Kategoria WHERE ID_Artikull = @ID_Artikull";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Emri_artikullit", product_name_input.Text);
                                cmd.Parameters.AddWithValue("@Pershkrimi_artikullit", product_desc_input.Text);
                                cmd.Parameters.AddWithValue("@Cmimi", product_price_input.Value);
                                cmd.Parameters.AddWithValue("@Kategoria", product_category_combobox.SelectedItem);
                                cmd.Parameters.AddWithValue("@ID_Artikull", ProductId);

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
    }
}
