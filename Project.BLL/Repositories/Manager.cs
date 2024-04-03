using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class Manager : GenericRepo<DAL.Entities.Manager>,IManagerRepo
    {
        public Manager(ProjDbContext context) : base(context)
        {
        }
    }
}
