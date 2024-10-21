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
        public static void EditGenre(int id, string name)
        {
            Genre genreToEdit = db.Genres.FirstOrDefault(g => g.GenreID == id);
            genreToEdit.GenreName = name;
            genreToEdit.Updated = DateTime.Now;
            db.SaveChanges();
        }
        public static void AddGenre(string name)
        {
            Genre newGenre = new Genre();
            newGenre.GenreName = name;
            newGenre.Created = DateTime.Now;
            newGenre.Updated = DateTime.Now;
            db.Genres.Add(newGenre);
            db.SaveChanges();
        }
        public static void DeleteGenre(int id) {
            Genre genre = db.Genres.FirstOrDefault(gen => gen.GenreID == id);
            db.Genres.Remove(genre);
            db.SaveChanges();
        }
        public static int GetGenreFirstID()
        {
            if (db.Genres.Count() == 0)
            {
                return -1;
            }
            return db.Genres.First().GenreID;
        }
        public static int GetGenreCount()
        {
            return db.Genres.Count();
        }


    }
}
