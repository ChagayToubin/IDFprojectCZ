using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    internal class Terrorist
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public bool Status { get; set; }

        public List<string> Weapon { get; set; } = new List<string>();

        public Dictionary<string, string> TimeLocatiom { get; set; } = new Dictionary<string, string>();//אמרנו שמפתח יהיה זמן כך יהיה ושנה מהכל ובערך יהיה הודעה עם מיקום
        public Terrorist(string name, int rank, bool status, List<string> weapon)
        {
            Name = name;
            Rank = rank;
            Status = status;
            Weapon = new(weapon);

        }

    }

}