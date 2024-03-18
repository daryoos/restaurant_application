using RestaurantOldies.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using RestaurantOldies.model;
using RestaurantOldies.view;

namespace RestaurantOldies
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView());
            //Application.Run(new AdminView());
            //Application.Run(new EmployeeView());
            

            /*
            string startDate = "2024-02-18 20:20:05";
            string endDate = "2024-04-18 20:20:05";
            BillDAO billDAO = new BillDAO();
            List<Bill> bills = billDAO.GetAllBetweenDates(startDate, endDate);
            foreach (Bill bill in bills )
            {
                Console.WriteLine(bill.id);
            }
            */

            /*
            BillDAO billDAO = new BillDAO();
            List<Bill> bills = billDAO.GetAll();
            foreach (Bill bill in bills )
            {
                Console.WriteLine(bill.id);
            }
            */

            /*
            BillDAO billDAO = new BillDAO();
            Bill bill = billDAO.GetById(1);
            Console.WriteLine(bill.totalCost);
            bill.totalCost += 10;
            Console.WriteLine(bill.totalCost);
            billDAO.Update(bill);
            bill = billDAO.GetById(1);
            Console.WriteLine(bill.totalCost);
            */

            /*
            User user = new User("d", "d", "d", 0);
            UserDAO userDAO = new UserDAO();
            userDAO.Add(user);
            */

            /*
            Item item = new Item("ddd", 10, 2);
            ItemDAO itemDAO = new ItemDAO();
            itemDAO.Add(item);
            */

            /*
            UserDAO userDAO = new UserDAO();
            User user1 = userDAO.GetById(1);
            User user = userDAO.GetByUsername("sss");
            List<User> users = userDAO.GetAll();
            foreach (User user in users)
            {
                Console.WriteLine(user.id);
            }
            */
        }
    }
}
