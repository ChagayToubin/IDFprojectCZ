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
        public  void UpdateMessage(Hamas hamas)//צריך לקבל את המופע חמאס לזכור 
        {
            Console.WriteLine("enter a name to update informtion");
            string name_terroist = Console.ReadLine();
            
            bool check = false;
            foreach(var item in hamas.ListTerrorist)
            {
                check = (item.Name == name_terroist);
                if (check)
                {
                    Console.WriteLine("enter a message");
                    item.TimeLocatiom[DateTime.UtcNow.ToString()]=Console.ReadLine();
                    Console.WriteLine("The update success ");
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("לא נמצא מחבל בשם הזה");
            }


        }
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
                Thread.Sleep(123);
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
