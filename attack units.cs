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
        public int CurrentAmmunitionQuantity;
        public int AttacksAtSameTime;
        public string PoweredBy;
        public AttackUnits(string typeUnit, int fuelSupply, int currentAmmunitionQuantity, string typeBomb = null, int maximumArmaments = 1, int attacksAtSameTime = 1, string poweredBy = null)
        {
            TypeUnit = typeUnit.ToLower();
            FuelSupply = fuelSupply;
            TypeBomb = typeBomb;
            MaximumArmaments = maximumArmaments;
            CurrentAmmunitionQuantity = currentAmmunitionQuantity;
            AttacksAtSameTime = attacksAtSameTime;
            PoweredBy = poweredBy;
            if (typeUnit == "f16")
            {
                TypeBomb = "0.5 - 1 KG";
                EffectiveAgainst.Add(Locations[0]);
                PoweredBy = "pilot";
                MaximumArmaments = 8;

            }
            else if (typeUnit == "Hermes 460" || typeUnit == "zik")
            {
                TypeBomb = "";
                EffectiveAgainst.Add(Locations[1]);
                EffectiveAgainst.Add(Locations[2]);
                MaximumArmaments = 3;
            }
            else if (TypeUnit == "M109 Artillery")
            {
                TypeBomb = "explosive shells";
                EffectiveAgainst.Add(Locations[3]);
                AttacksAtSameTime = 3;
                MaximumArmaments = 40;
            }

        }
    }
}