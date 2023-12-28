
using BookMVC.Data;
using BookMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookMVC.Controllers
{
    public class BookController1 : Controller
    {
        //private readonly BookDbContext _bookRepository;

        //public BookController1(BookRepository bookrepository)
        //{
        //    _bookRepository = bookrepository;
        //}
        public List<Book> booksList = new List<Book>()
        {
            //new Book(){//bookName="SCience",bookAuthor="Einstien"},
            //new Book(){bookName="Maths",bookAuthor="Arybhatta"}


        };

        [HttpGet]
        public IActionResult Index()
        {
            var books = booksList;
            return View(books);
        }
       // [HttpGet]
        //public IActionResult Details(int id)
        //{
        //    var book = .GetBookById(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(book);
        //}
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            var newBook = new Book()
            {
                bookId =Guid.NewGuid(),
                bookName = book.bookName,
                bookAuthor = book.bookAuthor
            };
          
            booksList.Add(newBook);
            return RedirectToAction("Index");
        }
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var book = _bookRepository.GetBookById(id);
        //    return View(book);
        //}

        //[HttpPost]
        //public IActionResult Edit(Book book)
        //{
        //    _bookRepository.UpdateBook(book);
        //    return RedirectToAction("Edit");
        //}
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var book = _bookRepository.GetBookById(id);
        //    if (book == null)
        //    {
        //        return NotFound(); 
        //    }
        //    return View(book);
        //}

        //[HttpPost]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    _bookRepository.DeleteBook(id);
        //    return RedirectToAction("Index");
        //}


    }
}
