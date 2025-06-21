using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface ICriminalInfo
    {
        string FirstName { get; }
        string LastName { get; }
        string Nickname { get; }
        decimal Height { get; }
        string HairColor { get; }
        string EyeColor { get; }
        string DistinguishingMarks { get; }
        string Citizenship { get; }
        DateTime BirthDate { get; }
        string Address { get; }
        List<string> Languages { get; }
        string CriminalProfession { get; }
        string LastCrime { get; }
        string GroupName { get; }
    }
}
