using TrainingLine.Models;

namespace TrainingLine.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        } 

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string Title,string Author)
        {
            return DataSource().Where(x => x.Title.Contains(Title) || x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel(){Id=1,Title="MVC",Author="Mallu",Description="Model View Controller is a type to develope .Net Application"},
                new BookModel(){Id=1,Title=".Net",Author="Siddhu",Description=".Net is a framework used to develope fullstack application."},
                new BookModel(){Id=1,Title="Python",Author="Gowthu",Description="Python is a fast growing technology used in AI etc..."},
                new BookModel(){Id=1,Title="Mern",Author="Alfi",Description="MongoDB , ExpressJS , ReactJS , NodeJS it is a fullstack development !!!"}
            };
        }
    }
}
