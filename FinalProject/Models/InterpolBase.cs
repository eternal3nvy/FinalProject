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
        public List<ArchivedCriminal> Archive { get; private set; }

        public InterpolBase()
        {
            Criminals = new List<Criminal>();
            GroupDB = new Group();
            Archive = new List<ArchivedCriminal>();
        }

        public void AddCriminal(Criminal criminal)
        {
            criminal.Id = Criminals.Count == 0 ? 0 :Criminals.Max(c => c.Id) + 1;
            //criminal.Id = Archive.Count == 0 ? criminal.Id : Math.Max(criminal.Id, Archive.Max(c => c.Id) + 1);
            if (!String.IsNullOrEmpty(criminal.GroupName))
            {
                if (!GroupDB.groupDB.ContainsKey(criminal.GroupName.ToLower()))
                    MessageBox.Show($"New group created {criminal.GroupName}");
                
                GroupDB.AddMember(criminal.GroupName.ToLower(), criminal);
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
            //delete criminal from the group if has it
            if (!String.IsNullOrEmpty(criminal.GroupName))
                GroupDB.RemoveMember(criminal.GroupName, criminal);
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


        public List<Criminal> FindCriminal(string firstName, string lastName)
        {

            return Criminals.FindAll(c => c.FirstName.ToLower().IndexOf(firstName.Trim().ToLower()) != -1 &&
                                          c.LastName.ToLower().IndexOf(lastName.Trim().ToLower()) != -1);
        }

        public void SerializeData(string path)
        {
            string jsonCriminals = JsonSerializer.Serialize(Criminals);
            string jsonGroups = JsonSerializer.Serialize(GroupDB.groupDB);

            File.WriteAllLines(path, [jsonCriminals, jsonGroups]);
        }

        public void DeserializeData(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                if (lines.Length >= 1)
                {
                    var deserializedCriminals = JsonSerializer.Deserialize<List<Criminal>>(lines[0]);
                    if (deserializedCriminals != null)
                        Criminals = deserializedCriminals;
                }

                if (lines.Length >= 2)
                {
                    var deserializedGroups = JsonSerializer.Deserialize<Dictionary<string, List<Criminal>>>(lines[1]);
                    if (deserializedGroups != null)
                        GroupDB.groupDB = deserializedGroups;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deserializing data: " + ex.Message);
            }
        }


        public List<ICriminalInfo> AdvancedSearch(Criminal criteria, IEnumerable<ICriminalInfo> data)
        {
            IEnumerable<ICriminalInfo> query = data;
            //query is like a view in sql. it is not create new collection just uses filters WHERE
            //apply filters for each property if criteria is not empty
            if (!string.IsNullOrWhiteSpace(criteria.FirstName))
                query = query.Where(c => c.FirstName.Contains(criteria.FirstName, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(criteria.LastName))
                query = query.Where(c => c.LastName.Contains(criteria.LastName, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(criteria.Nickname))
                query = query.Where(c => c.Nickname.Contains(criteria.Nickname, StringComparison.OrdinalIgnoreCase));

            if (criteria.Height > 0)
                query = query.Where(c => c.Height == criteria.Height);

            if (!string.IsNullOrWhiteSpace(criteria.HairColor))
                query = query.Where(c => c.HairColor.Contains(criteria.HairColor, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(criteria.EyeColor))
                query = query.Where(c => c.EyeColor.Contains(criteria.EyeColor, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(criteria.DistinguishingMarks))
                query = query.Where(c => c.DistinguishingMarks.Contains(criteria.DistinguishingMarks, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(criteria.Citizenship))
                query = query.Where(c => c.Citizenship.Contains(criteria.Citizenship, StringComparison.OrdinalIgnoreCase));

            // Filter by BirthDate only if it's not default (01/01/2000)
            if (criteria.BirthDate != new DateTime(2000, 1, 1))
                query = query.Where(c => c.BirthDate.Date == criteria.BirthDate.Date);

            if (!string.IsNullOrWhiteSpace(criteria.Address))
                query = query.Where(c => c.Address.Contains(criteria.Address, StringComparison.OrdinalIgnoreCase));

            // Languages
            if (criteria.Languages != null && criteria.Languages.Count > 0)
            {
                var criteriaLangs = criteria.Languages
                    .Select(lang => lang.Trim().ToLower())
                    .Where(lang => !string.IsNullOrEmpty(lang))
                    .ToList();

                if (criteriaLangs.Count > 0)
                {
                    query = query.Where(c =>
                        c.Languages != null &&
                        criteriaLangs.All(cl =>
                            c.Languages
                                .Select(l => l.Trim().ToLower())
                                .Contains(cl)
                        )
                    );
                }
            }

            if (!string.IsNullOrWhiteSpace(criteria.CriminalProfession))
                query = query.Where(c => c.CriminalProfession.Contains(criteria.CriminalProfession, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(criteria.LastCrime))
                query = query.Where(c => c.LastCrime.Contains(criteria.LastCrime, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(criteria.GroupName))
                query = query.Where(c =>
                    c.GroupName != null &&
                    c.GroupName.Trim().ToLower() == criteria.GroupName.Trim().ToLower()
                );

            return query.ToList();
        }

        public void moveToArchive(Criminal criminal, string reason)
        {
            if (criminal == null) return;
            var archivedCriminal = new ArchivedCriminal(criminal, reason);
            Archive.Add(archivedCriminal);
            RemoveCriminal(criminal);
        }
    }
}
