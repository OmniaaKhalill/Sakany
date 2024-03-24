

namespace Project.DAL.Entities
{
    public enum RentStatusEnum
    {
        Not_Paid,
        Paid
    }
    public class Renter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RentStatus { get; set; } = "Not Set";
        public DateOnly StartDate { get; set; }
        public DateOnly? EndDate { get; set;}
        public int ApartmentId { get; set; }

        //navigation prop
         public Apartment Apartment { get; set; }
        public List<RenterService> RenterServices { get; set; }



    }
}
