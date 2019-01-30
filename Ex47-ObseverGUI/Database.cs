using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ex47_ObseverGUI
{
    public class Database : ISubscriber
    {

        private static string conntectionString =
                "Server = ealSQL1.eal.local; Database = A_DB12_2018; User Id = A_STUDENT12; Password = A_OPENDB12;";


        public void InsertPet(Pet pet)
        {
            using (SqlConnection con = new SqlConnection(conntectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("InsertPet", con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.Add(new SqlParameter("@PetName", pet.PetName));
                    cmd1.Parameters.Add(new SqlParameter("@PetType", pet.PetType));
                    cmd1.Parameters.Add(new SqlParameter("@PetBreed", pet.PetBreed));
                    cmd1.Parameters.Add(new SqlParameter("@PetDOB", pet.PetDOB));
                    cmd1.Parameters.Add(new SqlParameter("@PetWeight", pet.PetWeight));
                    cmd1.Parameters.Add(new SqlParameter("@OwnerID", pet.OwnerID));

                    cmd1.ExecuteNonQuery();
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }

        public void InsertOwner(PetOwner petOwner)
        {
            using (SqlConnection con = new SqlConnection(conntectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("InsertPet_Owner", con);
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.Add(new SqlParameter("@OwnerFirstName", petOwner.OwnerFirstName));
                    cmd1.Parameters.Add(new SqlParameter("@OwnerLastName", petOwner.OwnerLastName));
                    cmd1.Parameters.Add(new SqlParameter("@OwnerPhone", petOwner.OwnerPhone));
                    cmd1.Parameters.Add(new SqlParameter("@OwnerEmail", petOwner.OwnerEmail));

                    cmd1.ExecuteNonQuery();
                }

                catch (SqlException e)
                {
                    Console.WriteLine("Hovsa " + e.Message);
                }
            }
        }
    }
}
