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
            User user = db.Users.FirstOrDefault(u => u.Username == username && u.UPassword == password);
            return user != null;
        }
        public static List<Genre> GetGenres(string word)
        {
            if (word == null || word == "")
            {
                return db.Genres.ToList();
            }
            else
            {
                return db.Genres.Where(g => g.GenreName.ToLower().Contains(word.ToLower())).ToList();
            }
        }


    }
}
