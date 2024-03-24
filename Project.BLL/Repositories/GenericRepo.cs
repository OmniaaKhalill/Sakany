using Project.BLL.Interfaces;
using Project.DAL.Entities;

namespace Project.BLL.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T>
    {
        public int Add(T entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
