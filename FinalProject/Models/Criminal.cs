using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    class Criminal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public float Height { get; set; }
        public string HairColor { get;  set; }
        public string EyeColor { get; set; }
        public string DistinguishingMarks { get; set; }
        public string Citizenship { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public List<string> Languages { get; set; }
        public string CriminalProfession { get; set; }
        public string LastCrime { get; set; }

        public Criminal(string firstName, string lastName, string nickname, float height, string hairColor, 
            string eyeColor, string distinguishingMarks, string citizenship, DateTime birthDate, string address, 
            List<string> languages, string criminalProfession, string lastCrime)
        {
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            DistinguishingMarks = distinguishingMarks;
            Citizenship = citizenship;
            BirthDate = birthDate;
            Address = address;
            Languages = languages;
            CriminalProfession = criminalProfession;
            LastCrime = lastCrime;
        }

        public void JoinGroup(Group group)
        {
            group.AddMember(this);
        }

    }
}
