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
                new BookModel(){Id=1,Title="MVC",Author="Ram"},
                new BookModel(){Id=1,Title=".Net",Author="Venkit"},
                new BookModel(){Id=1,Title="Python",Author="Vikram"},
                new BookModel(){Id=1,Title="Mern",Author="Hari"}
            };
        }
    }
}
