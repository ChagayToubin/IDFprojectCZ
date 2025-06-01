using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Idf;

namespace Idf
{
    internal class Manager
    {
        public static List<Terrorist> listTerrorist = new List<Terrorist>();
        public static Hamas hamas;
        public static IntelligenceDepartment IntelligenceDepartmentt;
        public static IdfMain IDF;


        public Manager()
        {
     
            InittialtionMain.initialization();
            
            MENU.Menu();


        }
        
    }
}
