using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore
{
    public class CRUD
    {
        private readonly BookStoreDatabase _db;

        public CRUD()
        {
            _db = new BookStoreDatabase();
        }

        // Validate user credentials
        public bool IsValidUser(string username, string password)
        {
            User user = _db.Users.FirstOrDefault(u => u.Username == username && u.UPassword == password);
            return user != null;
        }

        // Get genres with optional search word
        public List<Genre> GetGenres(string word = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return _db.Genres.ToList();
            }
            return _db.Genres.Where(g => g.GenreName.ToLower().Contains(word.ToLower())).ToList();
        }

        // Edit an existing genre
        public void EditGenre(int id, string name)
        {
            Genre genreToEdit = _db.Genres.FirstOrDefault(g => g.GenreID == id);
            if (genreToEdit != null)
            {
                genreToEdit.GenreName = name;
                genreToEdit.Updated = DateTime.Now;
                _db.SaveChanges();
            }
        }

        // Add a new genre
        public void AddGenre(string name)
        {
            Genre newGenre = new Genre
            {
                GenreName = name,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
            _db.Genres.Add(newGenre);
            _db.SaveChanges();
        }

        // Delete an existing genre
        public void DeleteGenre(int id)
        {
            Genre genre = _db.Genres.FirstOrDefault(gen => gen.GenreID == id);
            if (genre != null)
            {
                _db.Genres.Remove(genre);
                _db.SaveChanges();
            }
        }

        // Get the first genre's ID
        public int GetGenreFirstID()
        {
            return _db.Genres.FirstOrDefault()?.GenreID ?? -1;
        }

        // Get the total number of genres
        public int GetGenreCount()
        {
            return _db.Genres.Count();
        }
        public string GetGenreName(int id)
        {
            Genre genre = _db.Genres.FirstOrDefault(g => g.GenreID == id);
            return genre?.GenreName;
        }

        public List<User> GetUser(string word = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return _db.Users.ToList();
            }
            return _db.Users.Where(u => u.UName.ToLower().Contains(word.ToLower())).ToList();
        }
        // Get User Count
        public int GetUserCount()
        {
            return _db.Users.Count();
        }
        // Add a new User
        public void AddUser(string name, string role)
        {
            User newuser = new User
            {
                UName = name,
                Role = role,
                Username = $"{name}{GetUserLastID()+1}",
                UPassword = "123",
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
            _db.Users.Add(newuser);
            _db.SaveChanges();
        }
        // Delete an existing User
        public void DeleteUser(int id)
        {
            User user = _db.Users.FirstOrDefault(u => u.UserID == id);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
        }
        // Get the first user ID
        public int GetUserFirstID()
        {
            return _db.Users.FirstOrDefault()?.UserID ?? -1;
        }
        public string GetUserName(int id)
        {
            User user = _db.Users.FirstOrDefault(u => u.UserID == id);
            return user?.UName;
        }
        // Get the Last user ID
        private int GetUserLastID()
        {
            return _db.Users.OrderByDescending(u => u.UserID).FirstOrDefault()?.UserID ?? -1;
            
        }
        // Edit an existing User
        public void EditUser(int id, string name, string role)
        {
            User userToEdit = _db.Users.FirstOrDefault(u => u.UserID == id);
            if (userToEdit != null)
            {
                userToEdit.UName = name;
                userToEdit.Role = role;
                userToEdit.Updated = DateTime.Now;
                _db.SaveChanges();
            }
        }


    }
}
