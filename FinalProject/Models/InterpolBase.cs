using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace FinalProject.Models
{
    public class InterpolBase
    {
        public List<Criminal> Criminals { get; private set; }
        public List<Group> Groups { get; private set; }
        public Archive Archive { get; private set; }

        public InterpolBase()
        {
            Criminals = new List<Criminal>();
            Groups = new List<Group>();
            Archive = new Archive();
        }

        public void AddCriminal(Criminal criminal)
        {
            Criminals.Add(criminal);
        }

        public void RemoveCriminal(Criminal criminal)
        {
            Criminals.Remove(criminal);
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }

        public void RemoveGroup(Group group)
        {
            Groups.Remove(group);
        }


        public void GenerateTestData()
        {
            Criminals.Add(new Criminal("John", "Doe", "Johnny", 180, "Brown", "Blue", "Tattoo on arm", "USA", new DateTime(1990, 1, 1), "123 Main St", new List<string> { "English" }, "Thief", "Robbery"));
            Criminals.Add(new Criminal("Jane", "Smith", "Janie", 165, "Black", "Green", "Scar on cheek", "Canada", new DateTime(1985, 5, 15), "456 Elm St", new List<string> { "English", "French" }, "Fraudster", "Identity Theft"));
        }

        public void GenerateTestData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Criminals.Add(new Criminal(
                    "name" + i, 
                    "lastName" + i,
                    "nickname" + i, 
                    150 + (i % 50), 
                    i % 2 == 0 ? "Brown" : "Black", 
                    i % 3 == 0 ? "Blue" : (i % 3 == 1 ? "Green" : "Brown"), 
                    "Distinguishing mark " + i, 
                    i % 2 == 0 ? "USA" : "Canada", 
                    new DateTime(1980 + (i % 30), 1 + (i % 12), 1 + (i % 28)), 
                    "Address " + i, 
                    new List<string> { i % 2 == 0 ? "English" : "French" },
                    i % 2 == 0 ? "Thief" : "Fraudster", 
                    i % 2 == 0 ? "Robbery" : "Identity Theft" 
                ));
            }
        }


        public void Rehabilitate(Criminal criminal)
        {
            Archive.AddCriminalToArchive(criminal);
            Criminals.Remove(criminal);
        }

        public List<Criminal> FindCriminal(string firstName, string lastName)
        {
            ////todo try catch
            //return Criminals.FindAll(c => c.FirstName.ToLower()== firstName.Trim().ToLower() 
            //&& c.LastName.ToLower() == lastName.Trim().ToLower());

            return Criminals.FindAll(c => c.FirstName.ToLower().IndexOf(firstName.Trim().ToLower()) != -1 &&
                                          c.LastName.ToLower().IndexOf(lastName.Trim().ToLower()) != -1);
        }

        public void SerializeData(string path)
        {
            string jsonCriminals = JsonSerializer.Serialize(Criminals);

            File.WriteAllLines(path, [jsonCriminals]);
        }

        public void DeserializeData(string path)
        {
            string jsonCriminals;
            try
            {
                jsonCriminals = File.ReadAllLines(path)[0];
                Criminals = JsonSerializer.Deserialize<List<Criminal>>(jsonCriminals);
            }
            catch(Exception ex)
            {
                Console.WriteLine("no data");
            }
            
        }
    }
}
