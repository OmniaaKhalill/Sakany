using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class RenterRepo : GenericRepo<Renter>,IRenterRepo
    {
        public RenterRepo(ProjDbContext context) : base(context)
        {
        }
    }
}
