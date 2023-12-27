using BookMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class BookController1 : Controller
    {
        private List<Book> _books = new List<Book>
    {
        new Book { bookId = 1, bookName = "Book 1", bookAuthor = "Author 1" },
        new Book { bookId = 2, bookName = "Book 2", bookAuthor= "Author 2" }
       
    };
        public IActionResult Index()
        {
            return View(_books);
        }
        public IActionResult Details(int id)
        {
            var book = _books.FirstOrDefault(b => b.bookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            
            book.bookId = _books.Max(b => b.bookId) + 1;
            _books.Add(book);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var book = _books.FirstOrDefault(b => b.bookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            var existingBook = _books.FirstOrDefault(b => b.bookId== book.bookId);
            if (existingBook != null)
            {
                existingBook.bookName = book.bookName;
                existingBook.bookAuthor = book.bookAuthor;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var book = _books.FirstOrDefault(b => b.bookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _books.FirstOrDefault(b => b.bookId== id);
            if (book != null)
            {
                _books.Remove(book);
            }
            return RedirectToAction("Index");
        }
    }
}
