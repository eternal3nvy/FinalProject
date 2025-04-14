using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    class Criminal
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Nickname { get; private set; }
        public float Height { get; private set; }
        public string HairColor { get; private set; }
        public string EyeColor { get; private set; }
        public string DistinguishingMarks { get; private set; }
        public string Cityzenship { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Address { get; private set; }
        public List<string> Languages { get; private set; }
        public string CriminalProffession { get; private set; }
        public string LastCrime { get; private set; }

        public Criminal(string firstName, string lastName, string nickname, float height, string hairColor, 
            string eyeColor, string distinguishingMarks, string cityzenship, DateTime birthDate, string address, 
            List<string> languages, string criminalProffession, string lastCrime)
        {
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            DistinguishingMarks = distinguishingMarks;
            Cityzenship = cityzenship;
            BirthDate = birthDate;
            Address = address;
            Languages = languages;
            CriminalProffession = criminalProffession;
            LastCrime = lastCrime;
        }
    }
}
