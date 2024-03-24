

namespace Project.DAL.Entities
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Area { get; set; }


        //Forkes
        public int OwnerId { get; set; }


        //Navigation Prop
        public  Owner? Owner { get; set; }
        public List<Floor>? Floors { get; set;}
        public List<Service>? Services { get; set;}
    }
}
