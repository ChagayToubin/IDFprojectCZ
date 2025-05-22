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
            string conver;
            foreach (var item in hamas.ListTerrorist)
            {
                conver = DateTime.UtcNow.ToString("s"); // פורמט סטנדרטי וזיהוי אחיד

                if (!item.TimeLocatiom.ContainsKey(conver))
                {
                    item.TimeLocatiom[conver] = new List<string>(); // יצירת רשימה חדשה למפתח הזה
                }

                item.TimeLocatiom[conver].Add(message[rnd.Next(0, 4)]);

            }
            //hamas.ListTerrorist[2].TimeLocatiom.First().Value.Add("check if work");check if work
        }

    }
}
