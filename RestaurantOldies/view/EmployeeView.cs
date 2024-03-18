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
using RestaurantOldies.dataAccess;

namespace RestaurantOldies.view
{
    public partial class EmployeeView : Form
    {
        OrderDAO orderDAO;
        ItemDAO itemDAO;
        BillDAO billDAO;
        List<Bill> bills;
        List<Item> items;

        public EmployeeView()
        {
            orderDAO = new OrderDAO();
            itemDAO = new ItemDAO();
            billDAO = new BillDAO();
            InitializeComponent();
            InitializeBillGridView();
            InitializeItemDataGridView();
        }

        private void InitializeBillGridView()
        {
            bills = billDAO.GetAll();
            foreach (Bill bill in bills)
            {
                billGridView.Rows.Add(bill.id, bill.totalCost, bill.status, bill.date);
            }
        }


        private void InitializeItemDataGridView()
        {
            items = itemDAO.GetAll();
            foreach (Item item in items)
            {
                itemDataGridView.Rows.Add(item.id, item.name, item.price, item.quantity);
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            int billId = int.Parse((string)billIdtextBox.Text);
            int itemId = int.Parse((string)itemIdtextBox.Text);
            int quantity = int.Parse((string)quantitytextBox.Text);

            Bill bill = billDAO.GetById(billId);
            if (bill == null)
            {
                MessageBox.Show("Bill not found");
                return;
            }

            Item item = itemDAO.GetById(itemId);
            if (item == null)
            {
                MessageBox.Show("Item not found");
                return;
            }

            if (quantity > item.quantity)
            {
                MessageBox.Show("Quantity exceeded");
                return;
            }
            
            Order order = new Order(billId, itemId, quantity);
            if (orderDAO.Add(order, bill, item))
            {
                items.Clear();
                items = itemDAO.GetAll();
                itemDataGridView.Rows.Clear();
                foreach (Item i in items)
                {
                    itemDataGridView.Rows.Add(i.id, i.name, i.price, i.quantity);
                }

                bills.Clear();
                bills = billDAO.GetAll();
                billGridView.Rows.Clear();
                foreach (Bill b in bills)
                {
                    billGridView.Rows.Add(b.id, b.totalCost, b.status, b.date);
                }
            }
        }

        private void createBill_Click(object sender, EventArgs e)
        {
            Bill newBill = new Bill();
            billDAO.Add(newBill);
            bills.Clear();
            bills = billDAO.GetAll();
            billGridView.Rows.Clear();
            foreach (Bill bill in bills)
            {
                billGridView.Rows.Add(bill.id, bill.totalCost, bill.status, bill.date);
            }
        }

        private void updateBillButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bills.Count; i++)
            {
                if (bills[i].status.Equals((string)billGridView.Rows[i].Cells[2].Value))
                {
                    continue;
                }
                bills[i].status = (string)billGridView.Rows[i].Cells[2].Value;
                billDAO.Update(bills[i]);
            }
        }

        private void viewBillButton_Click(object sender, EventArgs e)
        {
            int billId = (int)billGridView.SelectedRows[0].Cells[0].Value;
            List<Order> orders = orderDAO.GetByBillId(billId);
            List<Item> items = new List<Item>();
            foreach (Order order in orders)
            {
                items.Add(itemDAO.GetById(order.itemId));
            }
            Console.WriteLine("Bill item view");
            BillItemView billItemView = new BillItemView(items);
            billItemView.Show();
        }
    }
}
