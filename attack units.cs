using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    public class AttackUnits
    {
        public List<string> Locations = new List<string> { "Buildings", "people", "armored vehicles", "open areas" };
        public List<string> EffectiveAgainst = new List<string>();
        public string TypeUnit;
        public int FuelSupply;
        public string TypeBomb;
        public int MaximumArmaments;
        public int CurrentArmamants;
        public int AttacksAtSameTime;
        public string PoweredBy;
    }
}