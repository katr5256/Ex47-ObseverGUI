using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex47_ObseverGUI
{
    public class Controller
    {
        Database DB = new Database();
        public void InsertPet(string PetName, string PetType, string PetBreed, string PetDOB, string PetWeight, int OwnerId)
        {

            Pet pet = new Pet();
            pet.PetName = PetName;
            pet.PetType = PetType;
            pet.PetBreed = PetBreed;
            pet.PetDOB = PetDOB;
            pet.PetWeight = PetWeight;
            pet.OwnerID = OwnerId;
            DB.InsertPet(pet);
        }

        public void InsertOwner(string OwnerFirstName, string OwnerLastName, string OwnerEmail, string OwnerPhone)
        {
            PetOwner petOwner = new PetOwner();
            petOwner.OwnerFirstName = OwnerFirstName;
            petOwner.OwnerLastName = OwnerLastName;
            petOwner.OwnerEmail = OwnerEmail;
            petOwner.OwnerPhone = OwnerPhone;
            DB.InsertOwner(petOwner);

        }

        public void FindOwnerByLastName(string lastName)
        {

        }
        public void FindOwnerByFirstName(string ownerEmail, string name)
        {

        }
    }
}
