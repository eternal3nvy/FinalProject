using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    class InterpolBase
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


        public void GenerateTestData()//todo: auto generation
        {
            Criminals.Add(new Criminal("John", "Doe", "Johnny", 180, "Brown", "Blue", "Tattoo on arm", "USA", new DateTime(1990, 1, 1), "123 Main St", new List<string> { "English" }, "Thief", "Robbery"));
            Criminals.Add(new Criminal("Jane", "Smith", "Janie", 165, "Black", "Green", "Scar on cheek", "Canada", new DateTime(1985, 5, 15), "456 Elm St", new List<string> { "English", "French" }, "Fraudster", "Identity Theft"));
        }

        public void Rehabilitate(Criminal criminal)
        {
            Archive.AddCriminalToArchive(criminal);
            Criminals.Remove(criminal);
        }

    }
}
