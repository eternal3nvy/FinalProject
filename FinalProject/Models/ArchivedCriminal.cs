using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ArchivedCriminal : ICriminalInfo
    {
        public Criminal Criminal { get; set; }
        public DateTime ArchiveDate { get; private set; }
        public string Reason { get; set; }

        public string FirstName => Criminal.FirstName;

        public string LastName => Criminal.LastName;

        public string Nickname => Criminal.Nickname;

        public decimal Height => Criminal.Height;

        public string HairColor => Criminal.HairColor;

        public string EyeColor => Criminal.EyeColor;

        public string DistinguishingMarks => Criminal.DistinguishingMarks;

        public string Citizenship => Criminal.Citizenship;

        public DateTime BirthDate => Criminal.BirthDate;

        public string Address => Criminal.Address;

        public List<string> Languages => Criminal.Languages;

        public string CriminalProfession => Criminal.CriminalProfession;

        public string LastCrime => Criminal.LastCrime;

        public string GroupName => Criminal.GroupName;

        public ArchivedCriminal(Criminal criminal, string reason)
        {
            Criminal = criminal;
            ArchiveDate = DateTime.Now;
            Reason = reason;
        }

        public override string ToString() =>
            $"{Criminal.FirstName} {Criminal.LastName} - archive data: {ArchiveDate}";

  
    }
}
