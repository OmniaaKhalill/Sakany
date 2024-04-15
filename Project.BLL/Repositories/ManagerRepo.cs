using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class ManagerRepo : GenericRepo<Manager>,IManagerRepo
    {
        public ManagerRepo(ProjDbContext context) : base(context)
        {
        }
    }
}
