using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Idf
{
    internal class IntelligenceDepartment
    {
        public Hamas hamas { get; set; }
        public IntelligenceDepartment(Hamas Hamass)
        {
            hamas = Hamass;
            InitializationMessage();
        }
        //public static voidUpdateMessage
        public void InitializationMessage()
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
                conver = DateTime.UtcNow.ToString();
                Thread.Sleep(100);
                item.TimeLocatiom[conver] = message[rnd.Next(0, 4)];

            }
            //foreach(var item in hamas.ListTerrorist)
            //{
            //    Console.WriteLine(item.TimeLocatiom.First().Key +" " + item.TimeLocatiom.First().Value);
            //}
            //hamas.ListTerrorist[2].TimeLocatiom.First().Value.Add("check if work");check if work  
        }

    }
}
