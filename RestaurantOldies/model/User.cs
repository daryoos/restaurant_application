using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOldies.model
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int isAdmin { get; set; }

        public User (string username, string password, string name, int isAdmin) {
            this.username = username;
            this.password = password;
            this.name = name;
            this.isAdmin = isAdmin;
        }
        public User(int id, string username, string password, string name, int isAdmin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.name = name;
            this.isAdmin = isAdmin;
        }
    }
}
