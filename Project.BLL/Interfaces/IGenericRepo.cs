using Project.DAL.Entities;
using Project.PL.Controllers;


namespace Project.BLL.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
