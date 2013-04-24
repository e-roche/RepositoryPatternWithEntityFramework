using System;
using System.Linq.Expressions;

namespace RepositoryEntityFramework.DataAccess.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        /// <summary>
        /// Encuentra un objeto por la expresión indicada
        /// </summary>
        /// <param name="predicate"></param>
        T Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Crea un nuevo objeto en la base de datos
        /// </summary>
        /// <param name="t">Nuevo objeto a crear</param>
        T Create(T t);

        /// <summary>
        /// Borra objetos de la base de datos en base a una expresión de filtrado
        /// </summary>
        /// <param name="predicate"></param>
        int Delete(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Actualiza los cambios del objeto en la base de datos
        /// </summary>
        /// <param name="t">Objeto a actualizar</param>
        int Update(T t);
    }
}
