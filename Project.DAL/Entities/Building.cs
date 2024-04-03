

using Project.PL.Controllers;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.DAL.Entities
{
    public class Building: BaseEntity
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Area { get; set; }
        public string? Discription { get; set; }

        //Forkes

        public int OwnerId { get; set; }
        //Navigation Prop
        public  Manager Owner { get; set; }
        public List<Floor>? Floors { get; set;}
        public List<Service>? Services { get; set;}
    }
}
