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
    public partial class BillItemView : Form
    {
        public BillItemView(List<Item> items)
        {
            InitializeComponent();
            InitializeItemGridView(items);
        }

        private void InitializeItemGridView(List<Item> items)
        {
            foreach (Item item in items)
            {
                itemGridView.Rows.Add(item.id, item.name, item.price);
            }
        }



        private void itemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
