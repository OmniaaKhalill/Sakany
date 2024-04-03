using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class RoomRepo : GenericRepo<Room>,IRoomRepo
    {
        public RoomRepo(ProjDbContext context) : base(context)
        {
        }
    }
}
