
namespace Project.DAL.Entities
{
    public enum ApartmentStatusEnum
    {
        Available,
        Rented
    }

    public class Apartment
    {
        public int ApartmentId { get; set; }
        public string ApartName { get; set; }
        public int Area { get; set;}
        public int Rent { get; set; }
        public string? Discription { get; set;}
        public string ApartmentStatus { get; set; }= "Not Set";
        //forkes
        public int FloorId { get; set; }
     

        //navigation prop
        public Floor Floor { get; set; }
        public Renter? Renter { get; set; }
        public List<Room> Rooms { get; set; }


    }
}
