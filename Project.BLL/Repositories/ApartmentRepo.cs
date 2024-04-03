using Project.BLL.Interfaces;
using Project.DAL.Context;
using Project.DAL.Entities;


namespace Project.BLL.Repositories
{
    public class ApartmentRepo : GenericRepo<Apartment>, IApartmentRepo
    {
        private readonly ProjDbContext _context;
        public ApartmentRepo(ProjDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Apartment> Available()
        {
           return  _context.Apartments.Where(a=>a.ApartmentStatus== "Available" || a.ApartmentStatus == "Not Set").ToList();
        }

        public IEnumerable<Apartment> Rented()
        {
            return _context.Apartments.Where(a => a.ApartmentStatus == "Rented").ToList();
        }
    }
}
