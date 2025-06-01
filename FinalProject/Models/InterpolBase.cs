using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Windows.Forms;

namespace FinalProject.Models
{
    public class InterpolBase
    {
        public List<Criminal> Criminals { get; private set; }
        public Group GroupDB { get; private set; }
        public Archive Archive { get; private set; }

        public InterpolBase()
        {
            Criminals = new List<Criminal>();
            GroupDB = new Group();
            Archive = new Archive();
        }

        public void AddCriminal(Criminal criminal)
        {
            if (criminal == null)
            {
                throw new Exception("Criminal cannot be null");
            }    
            criminal.Id = Criminals.Max(c => c.Id) + 1;
            if (!String.IsNullOrEmpty(criminal.GroupName))
            {
                if (GroupDB.groupDB.ContainsKey(criminal.GroupName.ToLower()))
                {
                    GroupDB.AddMember(criminal.GroupName, criminal);
                }
                else
                {
                    MessageBox.Show($"New group created {criminal.GroupName}");
                }
            }
            Criminals.Add(criminal);
        }

        public void UpdateCriminal(Criminal criminal)
        {
            var existingCriminal = Criminals.FirstOrDefault(c => c.Id == criminal.Id);
            if (existingCriminal != null)
            {
                existingCriminal.FirstName = criminal.FirstName;
                existingCriminal.LastName = criminal.LastName;
                existingCriminal.Nickname = criminal.Nickname;
                existingCriminal.Height = criminal.Height;
                existingCriminal.HairColor = criminal.HairColor;
                existingCriminal.EyeColor = criminal.EyeColor;
                existingCriminal.DistinguishingMarks = criminal.DistinguishingMarks;
                existingCriminal.Citizenship = criminal.Citizenship;
                existingCriminal.BirthDate = criminal.BirthDate;
                existingCriminal.Address = criminal.Address;
                existingCriminal.Languages = criminal.Languages;
                existingCriminal.CriminalProfession = criminal.CriminalProfession;
                existingCriminal.LastCrime = criminal.LastCrime;
            }
        }

        public void RemoveCriminal(Criminal criminal)
        {
            Criminals.Remove(criminal);
        }



        public void GenerateTestData()
        {
            Criminals.Add(new Criminal(101,"John", "Doe", "Johnny", 180, "Brown", "Blue", "Tattoo on arm", "USA", new DateTime(1990, 1, 1), "123 Main St", new List<string> { "English" }, "Thief", "Robbery"));
            Criminals.Add(new Criminal(102, "Jane", "Smith", "Janie", 165, "Black", "Green", "Scar on cheek", "Canada", new DateTime(1985, 5, 15), "456 Elm St", new List<string> { "English", "French" }, "Fraudster", "Identity Theft"));
        }

        public void GenerateTestData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Criminals.Add(new Criminal(
                    i,
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
                var deserializedCriminals = JsonSerializer.Deserialize<List<Criminal>>(jsonCriminals);
                if (deserializedCriminals != null)
                {
                    Criminals = deserializedCriminals;
                }
                else
                {
                    Console.WriteLine("Deserialization resulted in null. No data was loaded.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deserializing data: " + ex.Message);
            }
        }

        public void GroupChange(Criminal criminal, string newGroupName)
        {
            if (criminal.GroupName != null && GroupDB.groupDB.ContainsKey(criminal.GroupName.ToLower()))
            {
                GroupDB.RemoveMember(criminal.GroupName, criminal);
            }
            criminal.GroupName = newGroupName;
            GroupDB.AddMember(newGroupName, criminal);
        }
    }
}
