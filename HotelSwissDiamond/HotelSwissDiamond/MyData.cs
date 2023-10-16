using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSwissDiamond
{
    internal class MyData
    {
        public static List<User> Users = new List<User>();
        public static List<Clients> clients = new List<Clients>();

        public static void LoadUsers()
        {
            User user1 = new User();
            user1.Username = "blerona.ibrahimi";
            user1.Password = "1234";
            user1.Firstname = "Blerona";
            user1.Lastname = "Ibrahimi";
            user1.Email = "blerona.ibrahimi@umib.net";
            user1.StatusId = 1;
            Users.Add(user1);

            User user2 = new User();
            user2.Username = "lutfie.zeka";
            user2.Password = "1234";
            user2.Firstname = "Lutfie";
            user2.Lastname = "Zeka";
            user2.Email = "lutfie.zeka@umib.net";
            user2.StatusId = 1;
            Users.Add(user2);
        }
    }
}
