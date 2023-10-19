using TrainingLine.Models;

namespace TrainingLine.Repository
{
    public class UserRepository 
    {
        private readonly BookDBContext _DbContext;
        public UserRepository()
        {
              _DbContext = new BookDBContext();
        }
        public bool Validate(string username, string password)
        {
            if (username != null && password != null)
            {
                var user= _DbContext.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
                if (user != null)
                {
                    return true;
                }
                    return false;
            }
            else
            {
                return false;
            }
        }

    }
}
