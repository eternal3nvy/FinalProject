using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    class Archive
    {
        private readonly List<Criminal> criminals = new List<Criminal>();

        public void AddCriminalToArchive(Criminal criminal)
        {
            criminals.Add(criminal);
        }

        public void RemoveCriminalFromArchive(Criminal criminal)
        {
            criminals.Remove(criminal);
        }

        public List<Criminal> GetAllCriminalsFromArchive()
        {
            return criminals;
        }
    }
}
