using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Criminal : ICriminalInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public decimal Height { get; set; }
        public string HairColor { get;  set; }
        public string EyeColor { get; set; }
        public string DistinguishingMarks { get; set; }
        public string Citizenship { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public List<string> Languages { get; set; }
        public string CriminalProfession { get; set; }
        public string LastCrime { get; set; }

        public string GroupName { get; set; }

        //shortinfo for listbox display
        public string ShortInfo => $"{FirstName} {LastName} ({Nickname}) {BirthDate.ToShortDateString()} - {CriminalProfession}";

        public Criminal(int id, string firstName, string lastName, string nickname, decimal height, string hairColor, 
            string eyeColor, string distinguishingMarks, string citizenship, DateTime birthDate, string address, 
            List<string> languages, string criminalProfession, string lastCrime, string groupName = "")
        {
            Id = id;
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
            Languages = languages ?? new List<string>();
            CriminalProfession = criminalProfession;
            LastCrime = lastCrime;
            GroupName = groupName;
        }

        public override string ToString()
        {
            return ShortInfo;
        }


        //override equals and GetHashCode methods for comparison
        public override bool Equals(object? obj)
        {
            if (obj is Criminal other)
                return Id == other.Id;
            return false;
        }

        public override int GetHashCode() => Id.GetHashCode();

    }
}
