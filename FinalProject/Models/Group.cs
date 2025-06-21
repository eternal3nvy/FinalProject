using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Group
    {
        public Dictionary<string, List<Criminal>> groupDB = new(); // todo: normilize <grupName, id>

        public void AddMember(string groupName, Criminal criminal)
        {
            groupName = groupName.ToLower().Trim();
            if (groupDB.ContainsKey(groupName))
                groupDB[groupName].Add(criminal);
            else
            {
                groupDB.Add(groupName, new List<Criminal>());
                groupDB[groupName].Add(criminal);
            }
            criminal.GroupName = groupName.ToLower();
        }

        public bool RemoveMember(string groupName, Criminal criminal)
        {
            var group = groupDB[groupName.ToLower()];

            // if only one member in group, remove group
            if (group.Count == 1 && group[0].Id == criminal.Id)
            {
                groupDB.Remove(groupName.ToLower());
                return true;
            }
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].Id == criminal.Id)
                {
                    group[i].GroupName = string.Empty;
                    group.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool ChangeGroup(Criminal criminal, string newGroupName, string oldGroupName)
        {
            if (RemoveMember(oldGroupName, criminal))
            {
                AddMember(newGroupName, criminal);
                return true;
            }
            return false;
        }

        public List<string> GetGroups() => groupDB.Keys.ToList();

        public List<Criminal> GetGroupMembers(string groupName)
        {
            groupName = groupName.ToLower().Trim();
            if (groupDB.ContainsKey(groupName))
                return groupDB[groupName];
            return new List<Criminal>();
        }

    }
}
