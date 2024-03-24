

namespace Project.DAL.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int Cost { get; set; }
        public string Discription { get; set; }

        //forkes
        public int BuildingId { get; set;}

        //navigation prop
        public Building Building { get; set; }
        public List<RenterService> RenterServices { get; set; }

    }
}
