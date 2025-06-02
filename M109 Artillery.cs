using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    public class M109Artillery : AttackUnits
    {
        public class Builder
        {
            public M109Artillery initUnit = new M109Artillery();


            public Builder SetFuel(int fuel)
            {
                initUnit.FuelSupply = fuel;
                return this;
            }

            public Builder SetCurrentArmamants(int current_armaments)
            {
                initUnit.CurrentArmamants = current_armaments;
                return this;
            }

            public Builder SetAttacksAtSameTime(int amount)
            {
                initUnit.AttacksAtSameTime = amount;
                return this;
            }

            public Builder SetTypeUnit(string name)
            {
                initUnit.TypeUnit = name;
                return this;
            }

            public Builder SetTypeBomb(string type_bomb)
            {
                initUnit.TypeBomb = type_bomb;
                return this;
            }

            public Builder SetPoweredBy(string Powered_by)
            {
                initUnit.PoweredBy = Powered_by;
                return this;
            }

            public AttackUnits Build()
            {
                initUnit.FuelSupply = 1;
                initUnit.MaximumArmaments = 40;
                initUnit.EffectiveAgainst.Add(initUnit.Locations[3]);
                return initUnit;
            }
        }
    }
}
