using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Group
    {
        private readonly List<Criminal> members = new List<Criminal>();
        public string Name { get; private set; }

        public Group(string name)
        {
            Name = name;
        }

        public void AddMember(Criminal criminal)
        {
            members.Add(criminal);
        }

        public void RemoveMember(Criminal criminal)
        {
            members.Remove(criminal);
        }

        public List<Criminal> GetMembers()
        {
            return members;
        }

    }
}
