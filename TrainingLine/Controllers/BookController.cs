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
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBook(int Id)
        {
            return _bookRepository.GetBookById(Id);
        }

        public List<BookModel> SearchBook(string name, string author) {
        
            return _bookRepository.SearchBooks(name, author);
        }
    }
}
