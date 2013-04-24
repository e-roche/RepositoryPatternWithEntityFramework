using System;
using System.Data.Entity;
using RepositoryEntityFramework.DataAccess.Mapping;
using RepositoryEntityFramework.DataAccess.Model;

namespace RepositoryEntityFramework.DataAccess
{
    public class MyContext : DbContext, IDisposable
    {
        // Tablas BD
        public DbSet<User> User { get; set; }

        
        /// <summary>
        /// Constructor de clase
        /// </summary>
        /// <param name="connString">Cadena de conexión</param>
        public MyContext(string connString)
            : base(connString)
        {
            Database.SetInitializer<MyContext>(null); // Se establece el inicializador de la base de datos a null para usar Code First con una base de datos ya existente
        }

        /// <summary>
        /// Sobreescritura del evento OnModelCreating para añadir los mapeos manuales de las clases POCO usando Fluent API
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
