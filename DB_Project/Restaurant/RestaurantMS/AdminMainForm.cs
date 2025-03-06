using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMS
{
    public partial class AdminMainForm : Form
    {
        int userRole;
        public AdminMainForm(int user_role)
        {
            InitializeComponent();
            userRole = user_role;
            if (user_role != 1)
            {
                staff_button.Hide();
                products_button.Hide();
                register_users_button.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        private void staff_button_Click(object sender, EventArgs e)
        {
            LoadPage(new AdminAddUsers(main_panel));
        }

        private void LoadPage(UserControl page)
        {
            // Clear the current view
            main_panel.Controls.Clear();

            // Set the Dock property so the page fills the panel
            page.Dock = DockStyle.Fill;

            // Add the new page to the panel
            main_panel.Controls.Add(page);
        }

        private void products_button_Click(object sender, EventArgs e)
        {
            LoadPage(new AdminAddProduct(main_panel));
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            LoadPage(new AdminOrders());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new AdminReservations());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadPage(new Register());
        }
    }
}