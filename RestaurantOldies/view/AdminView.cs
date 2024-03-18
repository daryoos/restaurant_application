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
using OfficeOpenXml;
using System.IO;

namespace RestaurantOldies.view
{
    public partial class AdminView : Form
    {
        List<Item> items;
        ItemDAO itemDAO;
        UserDAO userDAO;
        BillDAO billDAO;
        OrderDAO orderDAO;
        public string username;
        public string password;
        public string name;

        public AdminView()
        {
            itemDAO = new ItemDAO();
            userDAO = new UserDAO();
            billDAO = new BillDAO();
            orderDAO = new OrderDAO();
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

        private void firstDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBillButton_Click(object sender, EventArgs e)
        {
            using (var excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add("BillReport");

                worksheet.Cells[1, 1].Value = "Bill Id";
                worksheet.Cells[1, 2].Value = "Bill Total Cost";
                worksheet.Cells[1, 3].Value = "Bill Status";
                worksheet.Cells[1, 4].Value = "Bill Date";

                int row = 2;

                string startDate = firstDateTextBox.Text + " 00:00:00";
                string endDate = lastDateTextBox.Text + " 00:00:00";

                List<Bill> bills = billDAO.GetAllBetweenDates(startDate, endDate);
                Dictionary<int, int> itemCount = new Dictionary<int, int>();
                foreach (Item item in items)
                {
                    itemCount.Add(item.id, 0);
                }

                foreach (Bill bill in bills)
                {
                    worksheet.Cells[row, 1].Value = bill.id;
                    worksheet.Cells[row, 2].Value = bill.totalCost;
                    worksheet.Cells[row, 3].Value = bill.status;
                    worksheet.Cells[row, 4].Value = bill.date;

                    row++;

                    List<Order> orders = orderDAO.GetByBillId(bill.id);
                    foreach (Order order in orders)
                    {
                        itemCount[order.itemId] += order.quantity;
                    }
                }
                Item mostWantedItem = itemDAO.GetById(itemCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
                worksheet.Cells[1, 8].Value = "Item Id";
                worksheet.Cells[1, 9].Value = "Item Name";
                worksheet.Cells[1, 10].Value = "Item Price";
                worksheet.Cells[1, 11].Value = "Item Orders";

                worksheet.Cells[2, 8].Value = mostWantedItem.id;
                worksheet.Cells[2, 9].Value = mostWantedItem.name;
                worksheet.Cells[2, 10].Value = mostWantedItem.price;
                worksheet.Cells[2, 11].Value = itemCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;

                FileInfo excelFile = new FileInfo("BillReport.xlsx");
                excelPackage.SaveAs(excelFile);
            }
        }
    }
}
