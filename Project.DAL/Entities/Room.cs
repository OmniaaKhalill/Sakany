

namespace Project.DAL.Entities
{
    public enum RoomType
    {
        BedRoom,
        Dining,
        Kitchen,
        Bathroom 
    }
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }= "Not Set";
        public int? Area { get; set; }
        public  string Image {get; set; }

        //forkes
        public int ApartmentId { get; set; }

        //navigation prop
        public Apartment Apartment { get; set; }
    }
}
