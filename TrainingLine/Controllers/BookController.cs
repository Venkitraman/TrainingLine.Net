using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrainingLine.Models;
using TrainingLine.Repository;

namespace TrainingLine.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
                _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int Id)
        {
            var data = _bookRepository.GetBookById(Id);
            return View(data);
        }

        public List<BookModel> SearchBook(string name, string author) {
        
            return _bookRepository.SearchBooks(name, author);
        }
    }
}
