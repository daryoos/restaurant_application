using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantOldies.dataAccess;
using RestaurantOldies.model;

namespace RestaurantOldies.view
{
    public partial class AdminView : Form
    {
        List<Item> items;
        ItemDAO itemDAO;
        UserDAO userDAO;
        public string username;
        public string password;
        public string name;

        public AdminView()
        {
            itemDAO = new ItemDAO();
            userDAO = new UserDAO();
            InitializeComponent();
            InitializeItemGridView();
        }

        private void InitializeItemGridView()
        {
            items = itemDAO.GetAll();
            foreach (Item item in items)
            {
                itemGridView.Rows.Add(item.id, item.name, item.price, item.quantity);
            }
            itemGridView.Columns[0].ReadOnly = true;
        }

        private void updateItemsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i].name = itemGridView.Rows[i].Cells[1].Value.ToString();
                items[i].price = (float)itemGridView.Rows[i].Cells[2].Value;
                items[i].quantity = (int)itemGridView.Rows[i].Cells[3].Value;
                itemDAO.Update(items[i]);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            for (int i = items.Count; i < itemGridView.Rows.Count - 1;  i++)
            {
                string name = (string)itemGridView.Rows[i].Cells[1].Value;
                float price = float.Parse((string)itemGridView.Rows[i].Cells[2].Value);
                int quantity = int.Parse((string)itemGridView.Rows[i].Cells[3].Value);
                Item item = new Item(name, price, quantity);
                itemDAO.Add(item);
                items.Clear();
                items = itemDAO.GetAll();
                itemGridView.Rows[i].Cells[0].Value = items[i].id.ToString();
            }
            
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemGridView.SelectedRows.Count; i++)
            {
                foreach (Item item in items)
                {
                    if (item.id == (int)itemGridView.Rows[i].Cells[0].Value)
                    {
                        itemGridView.Rows.RemoveAt(i);
                        itemDAO.Delete(item);
                        items.Remove(item);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createEmployeeAccountButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text; 
            string name = nameTextBox.Text;
            User user = new User(username, password, name, 0);
            userDAO.Add(user);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
