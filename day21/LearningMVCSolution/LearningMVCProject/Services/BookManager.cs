using System;
using LearningMVCProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace LearningMVCProject.Services
{
    public class BookManager:IRepo<Book>
    {
        private PublicationContext _context;
        private ILogger<BookManager> _logger;

        public BookManager(PublicationContext context,ILogger<BookManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Book t)
        {
            try
            {
                _context.Books.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
                throw;
            }
        }

        public void Delete(Book t)
        {
            try
            {
                _context.Books.Remove(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }

        public Book Get(int id)
        {
            try
            {
                Book book = _context.Books.FirstOrDefault(b => b.Id == id);
                return book;
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public IEnumerable<Book> GetAll()
        {
            try
            {
                if (_context.Books.Count() == 0)
                    return null;
                return _context.Books.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public void Update(int id, Book t)
        {
            Book book = Get(id);
            if (book != null)
            {
                book.Title = t.Title;
                book.Price = t.Price;
            }
            _context.SaveChanges();
        }
    }
}
