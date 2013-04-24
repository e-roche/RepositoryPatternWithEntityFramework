using System;
using RepositoryEntityFramework.DataAccess;
using RepositoryEntityFramework.DataAccess.Model;
using RepositoryEntityFramework.DataAccess.Repository;

namespace RepositoryEntityFramework.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "your connection string";
            using (var dataContext = new MyContext(connString))
            {
                var userRepository = new Repository<User>(dataContext);

                User user = userRepository
                    .Find(c => c.Nombre.StartsWith("Rob"));

                Console.WriteLine("Nombre del usuario: {0} *", user.Nombre);

                Console.ReadKey();
            }
        }
    }
}
