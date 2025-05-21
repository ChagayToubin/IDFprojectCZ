using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    internal class IntelligenceDepartment
    {
        public Hamas hamas { get; set; }
        public IntelligenceDepartment(Hamas Hamass)
        {
            hamas = Hamass;
            AddMessage();
        }
        public void AddMessage()
        {
            Random rnd = new Random();

            List<string> message = new List<string>
            {
                "Buildings",
                "people",
                "armored vehicles",
                "open areas"

            };
            Console.WriteLine("");
            foreach (var item in hamas.ListTerrorist)
            {
                item.TimeLocatiom[DateTime.UtcNow] = message[rnd.Next(0, 4)];

            }
            Console.WriteLine("1234567890");

        }

    }
}
