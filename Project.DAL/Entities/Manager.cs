using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string WhatsAppNumber { get; set; }


        //Navigation Prop
        public List<Building> Buildings { get; set;}
    }
}
