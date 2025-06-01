using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Group
    {
        public Dictionary<string, List<Criminal>> groupDB = new();

        public void AddMember(string groupName, Criminal criminal)
        {
            if (groupDB.ContainsKey(groupName.ToLower()))
                groupDB[groupName.ToLower()].Add(criminal);
            else
            {
                groupDB.Add(groupName.ToLower(), new List<Criminal>());
                groupDB[groupName.ToLower()].Add(criminal);
            }
            criminal.GroupName = groupName.ToLower();
        }

        public void RemoveMember(int id)
        {
            foreach (var g in groupDB.Keys)
            {
                for (int i = 0; i < groupDB[g].Count; i++)
                {
                    if (groupDB[g][i].Id == id)
                    {
                        groupDB[g][i].GroupName = string.Empty;
                        groupDB[g].RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public void RemoveMember(string groupName, Criminal criminal)
        {
            var group = groupDB[groupName.ToLower()];
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].Id == criminal.Id)
                {
                    group[i].GroupName = string.Empty;
                    group.RemoveAt(i);
                    break;
                }
            }
        }

        //public List<Criminal> GetMembers()
        //{

        //}

    }
}
