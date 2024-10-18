using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class MainClass
    {
        private static BookStoreEntities db = new BookStoreEntities();

        public static bool IsValidUser (string username, string password)
        {
            User user = new User();
           user = db.Users.Where(u => u.Username == username && u.UPassword == password).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
