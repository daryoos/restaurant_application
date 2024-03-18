using RestaurantOldies.dataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantOldies.model;

namespace RestaurantOldies.view
{
    public partial class LoginView : Form
    {
        public string username;
        public string password;
        public LoginView()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.GetByUsername(username);
            if (user is null)
            {
                MessageBox.Show("Login: Incorrect username");
                return;
            }
            if (!user.password.Equals(password))
            {
                MessageBox.Show("Login: Incorrect password");
                return;
            }
            if (user.isAdmin == 1)
            {
                Console.WriteLine("Admin login");
                this.Hide();
                AdminView adminView = new AdminView();
                adminView.Show();
            }
            else
            {
                Console.WriteLine("Employee login");
                this.Hide();
                EmployeeView employeeView = new EmployeeView();
                employeeView.Show();
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextBox.Text;
        }
    }
}
