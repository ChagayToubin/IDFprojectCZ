using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Idf
{
    internal class Hamas
    {
        public string DateOfEstablishment { get; set; }
        public string CurrentCommander { get; set; }

        public List<Terrorist> ListTerrorist = new List<Terrorist>();
        public Hamas(string dateOfEstablishment, string currentCommander, List<Terrorist> listTerrorist)
        {
            DateOfEstablishment = dateOfEstablishment;
            CurrentCommander = currentCommander;
            ListTerrorist = listTerrorist;
        }


    }

}

