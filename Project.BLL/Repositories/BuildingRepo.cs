using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class BuildingRepo : GenericRepo<Building>,IBuildingRepo
    {
        public BuildingRepo(ProjDbContext context) : base(context)
        {
        }
    }
}
