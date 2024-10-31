using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Web.UI.WebControls;

namespace BookStore
{
    public class CRUD
    {
        private readonly BookStoreDB _db;

        public CRUD()
        {
            _db = new BookStoreDB();
        }

        // Validate user credentials
        public bool IsValidUser(string username, string password)
        {
            User user = _db.Users.FirstOrDefault(u => u.Username == username && u.UPassword == password);
            return user != null;
        }
        // Get user ID by username
        public int GetUserID(string username)
        {
            User user = _db.Users.FirstOrDefault(u => u.Username == username);
            return user?.UserID ?? -1;
        }
        // Get user role by id
        public string GetUserRole(int id)
        {
            User user = _db.Users.FirstOrDefault(u => u.UserID == id);
            return user?.Role;
        }
        // Get Name by id
        public string GetName(int id)
        {
            User user = _db.Users.FirstOrDefault(u => u.UserID == id);
            return user?.UName;
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
        // Get Genre Id by name
        public int GetGenreIdByName(string name)
        {
            Genre genre = _db.Genres.FirstOrDefault(g => g.GenreName == name);
            return genre?.GenreID ?? -1;
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
        //Get book price by ID
        public decimal GetBookPriceByID(int id)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookID == id);
            return book?.SalePrice ?? 0;
        }
        // Get book count
        public int GetBookCount()
        {
            return _db.Books.Count();
        }
        // get new book release
        public List<Book> GetnewBookRelease()
        {
            return _db.Books.OrderByDescending(b => b.PublishingDate).ToList();
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
        //Get autorId by Name
        public int GetAuthorIdByName(string name)
        {
            Author author = _db.Authors.FirstOrDefault(a => a.FullName == name);
            return author?.AuthorID ?? -1;
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
        //Get Publisher Id by name
        public int GetPublisherIdByName(string name)
        {
            Publisher publisher = _db.Publishers.FirstOrDefault(p => p.PublisherName == name);
            return publisher?.PublisherID ?? -1;
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

        // Add Book 

        public void AddBook(string name, int genreID, int authorID, int publisherID,DateTime publishDate,decimal costprice, decimal saleprice, int stock,int Pages, byte[] bookcover, bool isSequel)
        {
            if (bookcover == null)
            {
                bookcover = null;
            }
            Book newBook = new Book
            {
                Name = name,
                GenreID = genreID,
                AuthorID = authorID,
                PublisherID = publisherID,
                Stock = stock,
                BookCover = bookcover,
                IsSequel = isSequel,
                PublishingDate = publishDate,
                CostPrice = costprice,
                SalePrice = saleprice,
                Pages = Pages,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
            _db.Books.Add(newBook);
            _db.SaveChanges();
        }
        //Get book by title
        public List<Book> GetBooksByTitle(string word = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return _db.Books.ToList();
            }
            return _db.Books.Where(b => b.Name.ToLower().Contains(word.ToLower())).ToList();
        }
        //get book by author name
        public List<Book> GetBooksByAuthorName(string word = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return _db.Books.ToList();
            }
            return _db.Books.Where(b => b.Author.FullName.ToLower().Contains(word.ToLower())).ToList();
        }
        // Get book by Genre
        public List<Book> GetBooksByGenre(string word = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return _db.Books.ToList();
            }
            return _db.Books.Where(b => b.Genre.GenreName.ToLower().Contains(word.ToLower())).ToList();
        }
        // Get book cover by Id
        public byte[] GetBookCoverById(int id)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookID == id);
            return book?.BookCover;
        }

        //Delete book
        public void DeleteBook(int id)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookID == id);
            if (book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChanges();
            }
        }
        // Get first book ID
        public int GetBookFirstID()
        {
            return _db.Books.FirstOrDefault()?.BookID ?? -1;
        }
        //Get Book title by Id
        public string GetBookTitleById(int id)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookID == id);
            return book?.Name;
        }
        //Get book by Id
        public List<Book> GetBookById(int id)
        {
            return _db.Books.Where(b => b.BookID == id).ToList();
        }
        //Edit book
        public void EditBook(int id, string name, int genreID, int authorID, int publisherID, DateTime publishDate, decimal costprice, decimal saleprice, int stock, int Pages, bool isSequel)
        {
            Book bookToEdit = _db.Books.FirstOrDefault(b => b.BookID == id);
            if (bookToEdit != null)
            {
                bookToEdit.Name = name;
                bookToEdit.GenreID = genreID;
                bookToEdit.AuthorID = authorID;
                bookToEdit.PublisherID = publisherID;
                bookToEdit.PublishingDate = publishDate;
                bookToEdit.CostPrice = costprice;
                bookToEdit.SalePrice = saleprice;
                bookToEdit.Stock = stock;
                bookToEdit.Pages = Pages;
                bookToEdit.IsSequel = isSequel;
                bookToEdit.Updated = DateTime.Now;
                _db.SaveChanges();
            }
        }
        // Change book cover
        public void ChangeBookCover(int id, byte[] bookcover)
        {
                Book bookToEdit = _db.Books.FirstOrDefault(b => b.BookID == id);
                if (bookToEdit != null)
                {
                    bookToEdit.BookCover = bookcover;
                    _db.SaveChanges();
                }
        }
        //Get book Stock by Id
        public int GetBookStockById(int id)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookID == id);
            return book?.Stock ?? -1;
        }
        
        // Add new sale 
        public void AddSale(int saleId, int userID, decimal totalPrice)
        {
            Sale newSale = new Sale
            {
                SaleID = saleId,
                UserId = userID,
                TotalAmount = totalPrice,
                Created = DateTime.Now,
                Updated = DateTime.Now
            };
            _db.Sales.Add(newSale);
            _db.SaveChanges();
        }
        //Add new sale detail
        public void AddSaleDetail(int saleId, int bookId, int quantity,decimal discount, decimal price, decimal total)
        {
            SaleDetail newSaleDetail = new SaleDetail
            {
                SaleId = saleId,
                BookId = bookId,
                Discount = discount,
                Quantity = quantity,
                UnitPrice = price,
                TotalPrice = total,
            };
            _db.SaleDetails.Add(newSaleDetail);
            _db.SaveChanges();
        }
        // Get last sale Id
        public int GetLastSaleId()
        {
            return _db.Sales.OrderByDescending(s => s.SaleID).FirstOrDefault()?.SaleID ?? -1;
        }
        // Book stock decrease
        public void BookStockDecrease(int bookId, int quantity)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookID == bookId);
            if (book != null)
            {
                book.Stock -= quantity;
                _db.SaveChanges();
            }
        }
        //Book stock increase
        public void BookStockIncrease(int bookId, int quantity)
        {
            Book book = _db.Books.FirstOrDefault(b => b.BookID == bookId);
            if (book != null)
            {
                book.Stock += quantity;
                _db.SaveChanges();
            }
        }
        //Get best seller
        public List<SalesGroupByUser> GetbestSeller()
        {
            var groupedSales = _db.Sales
                                  .GroupBy(s => s.UserId)
                                  .Select(g => new SalesGroupByUser
                                  {
                                      UserId = g.Key,
                                      TotalSalesAmount = g.Sum(s => s.TotalAmount),                                    
                                  })
                                  .OrderByDescending(g => g.TotalSalesAmount)
                                  .ToList();

            return groupedSales;
        }
        // get popular author
        public List<PopularAuthor> GetPopularAuthors()
        {
            var popularAuthors = _db.SaleDetails
                                 .Join(_db.Books,
                                       saleDetail => saleDetail.BookId,
                                       book => book.BookID,
                                       (saleDetail, book) => new { saleDetail, book.AuthorID, saleDetail.Quantity })
                                 .GroupBy(x => x.AuthorID)
                                 .Select(g => new PopularAuthor
                                 {
                                     AuthorId = g.Key,
                                     TotalQuantitySold = (int)g.Sum(x => x.Quantity)
                                 })
                                 .OrderByDescending(g => g.TotalQuantitySold)
                                 .ToList();


            return popularAuthors;
        }
        // Get popular genre
        public List<popularGenre> GetPopularGenres()
        {
            var popularGenres = _db.SaleDetails
                                 .Join(_db.Books,
                                       saleDetail => saleDetail.BookId,
                                       book => book.BookID,
                                       (saleDetail, book) => new { saleDetail, book.GenreID, saleDetail.Quantity })
                                 .GroupBy(x => x.GenreID)
                                 .Select(g => new popularGenre
                                 {
                                     GenreId = g.Key,
                                     TotalQuantitySold = (int)g.Sum(x => x.Quantity)
                                 })
                                 .OrderByDescending(g => g.TotalQuantitySold)
                                 .ToList();


            return popularGenres;
        }
       
    }
    public class SalesGroupByUser
    {
        public int UserId { get; set; }
        public decimal TotalSalesAmount { get; set; }
    }
    public class PopularAuthor
    {
        public int AuthorId { get; set; }
        public int TotalQuantitySold { get; set; }
    }
    public class popularGenre 
    {
        public int GenreId { get; set; }
        public int TotalQuantitySold { get; set; }

    }

}
