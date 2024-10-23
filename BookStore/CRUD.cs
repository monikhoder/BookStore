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
        // Get book count by Genre

        public int GetBookCountByGenreID(int id)
        {
            return _db.Books.Count(b => b.GenreID == id);
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
        // Get authors with optional search word
        public List<Author> GetAuthors(string word = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return _db.Authors.ToList();
            }
            return _db.Authors.Where(a => a.FullName.ToLower().Contains(word.ToLower())).ToList();
        }

        // Edit an existing author
        public void EditAuthor(int id, string name)
        {
            Author authorToEdit = _db.Authors.FirstOrDefault(a => a.AuthorID == id);
            if (authorToEdit != null)
            {
                authorToEdit.FullName = name;
                authorToEdit.Updated = DateTime.Now;
                _db.SaveChanges();
            }
        }

        // Add a new author
        public void AddAuthor(string name)
        {
            Author newAuthor = new Author
            {
                FullName = name,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
            _db.Authors.Add(newAuthor);
            _db.SaveChanges();
        }

        // Delete an existing author
        public void DeleteAuthor(int id)
        {
            Author author = _db.Authors.FirstOrDefault(a => a.AuthorID == id);
            if (author != null)
            {
                _db.Authors.Remove(author);
                _db.SaveChanges();
            }
        }

        // Get the first author's ID
        public int GetAuthorFirstID()
        {
            return _db.Authors.FirstOrDefault()?.AuthorID ?? -1;
        }

        // Get the total number of authors
        public int GetAuthorCount()
        {
            return _db.Authors.Count();
        }

        // Get the author's name by ID
        public string GetAuthorName(int id)
        {
            Author author = _db.Authors.FirstOrDefault(a => a.AuthorID == id);
            return author?.FullName;
        }
        //Get Book Count by Author ID
        public int GetBookCountByAuthorID(int id)
        {
            return _db.Books.Count(b => b.AuthorID == id);
        }

        // Get publishers with optional search word
        public List<Publisher> GetPublishers(string word = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return _db.Publishers.ToList();
            }
            return _db.Publishers.Where(p => p.PublisherName.ToLower().Contains(word.ToLower())).ToList();
        }

        // Edit an existing publisher
        public void EditPublisher(int id, string name)
        {
            Publisher publisherToEdit = _db.Publishers.FirstOrDefault(p => p.PublisherID == id);
            if (publisherToEdit != null)
            {
                publisherToEdit.PublisherName = name;
                publisherToEdit.Updated = DateTime.Now;
                _db.SaveChanges();
            }
        }

        // Add a new publisher
        public void AddPublisher(string name)
        {
            Publisher newPublisher = new Publisher
            {
                PublisherName = name,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
            _db.Publishers.Add(newPublisher);
            _db.SaveChanges();
        }

        // Delete an existing publisher
        public void DeletePublisher(int id)
        {
            Publisher publisher = _db.Publishers.FirstOrDefault(p => p.PublisherID == id);
            if (publisher != null)
            {
                _db.Publishers.Remove(publisher);
                _db.SaveChanges();
            }
        }

        // Get the first publisher's ID
        public int GetPublisherFirstID()
        {
            return _db.Publishers.FirstOrDefault()?.PublisherID ?? -1;
        }

        // Get the total number of publishers
        public int GetPublisherCount()
        {
            return _db.Publishers.Count();
        }

        // Get the publisher's name by ID
        public string GetPublisherName(int id)
        {
            Publisher publisher = _db.Publishers.FirstOrDefault(p => p.PublisherID == id);
            return publisher?.PublisherName;
        }
        // Get book count by publisher

        public int GetBookCountByPublisherID(int id)
        {
            return _db.Books.Count(b => b.PublisherID == id);
        }

    }
}
