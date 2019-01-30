using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex47_ObseverGUI
{
    public class Pet : ISubscriber , IPublisher
    {
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string PetBreed { get; set; }
        public string PetDOB { get; set; }
        public string PetWeight { get; set; }
        public int OwnerID { get; set; }
    }
}
