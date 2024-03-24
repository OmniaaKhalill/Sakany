
namespace Project.DAL.Entities
{
   public enum FloorTypeEnum
   {
        
        Residental,
        Commercial,
        Parking
   }
    public class Floor
    {
        public int FloorId { get; set; }
        public int  FloorNumbr { get; set;}
        public string FloorType { get; set; } = "Not Set";

        //forkes
        public int BuildingId { get; set; }

        //  //Navigation Prop
        public Building Building { get; set; }
        public List<Apartment> Apartments { get; set;}


    }
}
