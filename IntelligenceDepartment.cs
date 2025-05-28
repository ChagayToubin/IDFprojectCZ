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
        public void UpdateMessage(Hamas hamas)//צריך לקבל את המופע חמאס לזכור 
        {
            Console.WriteLine("enter a name to update informtion");
            string name_terroist = Console.ReadLine();

            bool check = false;
            foreach (var item in hamas.ListTerrorist)
            {
                check = (item.Name == name_terroist);
                if (check)
                {
                    Console.WriteLine("enter a message");
                    item.TimeLocatiom[DateTime.UtcNow.ToString()] = Console.ReadLine();
                    Console.WriteLine("The update success ");
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("No terrorist by that name was found.");
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

        }
       public static void TheMostMessages()
        {
            Terrorist Mostmessagetero = Manager.IntelligenceDepartmentt.hamas.ListTerrorist[0];
            int countTMost = 0;

            foreach (var item in Manager.IntelligenceDepartmentt.hamas.ListTerrorist)
            {
                if (countTMost < item.TimeLocatiom.Count)
                {
                    countTMost = item.TimeLocatiom.Count;
                    Mostmessagetero = item;
                }
            }
            Console.WriteLine(Mostmessagetero.Name + "\n");
        }
        public static Terrorist TheMostDangerous()
        {
            Terrorist Mostmessagetero = Manager.IntelligenceDepartmentt.hamas.ListTerrorist[0];
            int MostDangerScore = 0;

            foreach (var item in Manager.IntelligenceDepartmentt.hamas.ListTerrorist)
            {
                if (PointCalculation(item.Weapon, item.Rank) > MostDangerScore && item.Status)
                {
                    Mostmessagetero = item;
                    MostDangerScore = PointCalculation(item.Weapon, item.Rank);
                }
            }
            static int PointCalculation(List<string> Weapon, int Rank)
            {
                int calculation = 0;
                if (Weapon.Contains("Knife"))
                {
                    calculation += 1;
                }
                if (Weapon.Contains("Handgun"))
                {
                    calculation += 2;
                }
                if ((Weapon.Contains("AK-47") || Weapon.Contains("M16")))
                {
                    calculation += 3;
                }
                return calculation * Rank;
            }
            Console.WriteLine("the target of the attack" + " " + Mostmessagetero.Name + "risk level" + MostDangerScore + "\n");
            return Mostmessagetero;
        }
    }
}