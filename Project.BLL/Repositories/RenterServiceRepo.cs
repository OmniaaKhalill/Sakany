using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class RenterServiceRepo : GenericRepo<RenterService>,IRenterServiceRepo
    {
        public RenterServiceRepo(ProjDbContext context) : base(context)
        {
        }
    }
}
