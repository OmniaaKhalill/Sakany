
namespace Project.DAL.Entities
{
    public enum ServiceStatusEnum
    {
        Requested,
        done
    }
    public class RenterService 
    {
        public int  RenterId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceStatus { get; set; } 
        //navigation prop
        public Renter Renter { get; set; }
        public Service Service { get; set; }
    }
}
