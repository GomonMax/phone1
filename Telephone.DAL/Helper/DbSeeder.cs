using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephone.DAL.DBFiles;

namespace Telephone.DAL.Helper
{
    public static class DbSeeder
    {
        public static void SeedTelBook(MyContext context) 
        {
            if (context.persons.Count() == 0) 
            {
                context.persons.AddRange(new TelBookPerson[] 
                {
                new TelBookPerson { 
                    FirstName = "Vasiliy", 
                    SecondName = "Ivanov", 
                    LastName = "Olegovich", 
                    telNummer = "096413241245214456456456", 
                    Gender = false },
                new TelBookPerson { 
                    FirstName = "Nazar", 
                    SecondName = "Politaew",
                    LastName = "Lohovich", 
                    telNummer = "068454142335465435496",
                    Gender = true }
                });

                context.SaveChanges();
            }

        }
    }
}
