using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class ServiceRepo : GenericRepo<Service>,IServiceRepo
    {
        public ServiceRepo(ProjDbContext context) : base(context)
        {
        }
    }
}
