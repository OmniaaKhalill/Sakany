using Project.DAL.Entities;


namespace Project.BLL.Interfaces
{
    public interface IGenericRepo<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}
