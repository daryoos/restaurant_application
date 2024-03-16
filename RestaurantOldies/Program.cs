using RestaurantOldies.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using RestaurantOldies.model;

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
            Application.Run(new Form1());

            UserDAO userDAO = new UserDAO();
            //userDAO.add(new User("daf", "dfsae", "adfaf", false));

            User user = new User(1, "sss", "sss", "sss", 0);
            userDAO.update(user);
        }
    }
}
