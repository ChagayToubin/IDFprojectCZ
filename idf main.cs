using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Idf
{
    public class IdfMain
    {
        public string DateOfEstablishment { get; set; }
        public string CurrentCensus { get; set; }
        public List<AttackUnits> AtackUnits { get; set; } = new List<AttackUnits>();


        public IdfMain(string date_of_establishment, string current_census)
        {
            DateOfEstablishment = date_of_establishment;
            CurrentCensus = current_census;
        }

        public void AddAttackUnit(AttackUnits attack_unit)
        {
            AtackUnits.Add(attack_unit);
        }

        public void ShowAvailableUnits()
        {
            foreach (var unit in AtackUnits)
            {
                if (CheckAvailaiballUnit(unit))
                {
                    Console.WriteLine(unit.TypeUnit);
                }
            }
            Console.WriteLine("");
        }

        public AttackUnits SelectUnitByLocation(string location)
        {
            foreach (var i in AtackUnits)
            {
                if (i.EffectiveAgainst.Contains(location) && i.FuelSupply>0 && i.CurrentAmmunitionQuantity > 0)
                    return i;
            }
            return AtackUnits[0];
        }

        public bool Subarmament(AttackUnits unit, int num_armaments)
        {
            if (ArmamentCapacityTest(unit, num_armaments))
            {
                unit.CurrentAmmunitionQuantity -= num_armaments;

                return true;
            }
            else
            {

                Console.WriteLine($"There are not enough ammunition for the attack!! There are only {unit.CurrentAmmunitionQuantity} ammunition and you want to use {num_armaments} ammunition.");
                return false;
            }
        }

        public void AddingArmaments(AttackUnits unit, int num_armaments)
        {
            unit.CurrentAmmunitionQuantity += num_armaments;
        }

        public bool ArmamentCapacityTest(AttackUnits unit, int num_armaments)
        {
            return (unit.CurrentAmmunitionQuantity - num_armaments) >= 0 ? true : false;
        }

        public bool SubFuel(AttackUnits unit, int fuel_use)
        {
            if (unit.FuelSupply - fuel_use >= 0)
            {
                unit.FuelSupply -= fuel_use;

                return true;
            }
            else
            {

                Console.WriteLine($"There are not enough fuel for the attack!! There are only {unit.FuelSupply}, and you want to use {fuel_use}.");
                return false;
            }
        }

        public void AddingFuel(AttackUnits unit, int fuel_litters)
        {
            unit.FuelSupply += fuel_litters;
        }

        AttackUnits CreateAttackUnit(string Type_unit = null)
        {
            if (Type_unit == null)
            {
                Console.WriteLine("enter type unit");
                Type_unit = Console.ReadLine()!;
            }
            Console.WriteLine("enter fuel litters");
            int fuel = int.Parse(Console.ReadLine());
            Console.WriteLine("enter armamants");
            int armaments = int.Parse(Console.ReadLine()!);
            AttackUnits NewUnit = new AttackUnits(Type_unit, fuel, armaments);
            return NewUnit;
        }
        public static void PrepareUnits()
        {
            Manager.IDF.ShowAvailableUnits();
        }

        public void EditAttackUnit(string unit_name)
        {
            AttackUnits unit = new AttackUnits("unit_name", 100, 2);
            foreach (var i in AtackUnits)
            {
                if (i.TypeUnit == unit_name.ToLower())
                {
                    unit = i;
                }
            }
            Console.WriteLine("press 1 to create a new attack unit\npress 2 to add fuel\npress 3 to add armaments");
            switch (Console.ReadLine())
            {
                case "1":
                    AttackUnits New_unit = CreateAttackUnit(unit_name);
                    AddAttackUnit(New_unit);
                    break;

                case "2":
                    Console.WriteLine("enter nummber of litter");
                    AddingFuel(unit, int.Parse(Console.ReadLine()!));
                    break;

                case "3":
                    Console.WriteLine("enter a number of armaments");
                    AddingArmaments(unit, int.Parse(Console.ReadLine()!));
                    break;

            }

        }
       public static bool ExecuteStrike()
        {
            Terrorist person = IntelligenceDepartment.TheMostDangerous();

            string location = person.TimeLocatiom.Last().Value; //מצפה לקבל את המיקום של המחבל המיועד לתקיפה
            AttackUnits SelectedUnit = Manager.IDF.SelectUnitByLocation(location); //מקבל את האבייקט של כלי התקיפה
            if (!CheckAvailaiballUnit(SelectedUnit))
            {
                Console.WriteLine("No attack vehicle available. Please fill the attack vehicle with fuel and ammunition\n");
                return false;
            }

            Console.WriteLine(($"Attack tool to use {SelectedUnit.TypeUnit}"));
            int CurrentArmaments = AbsorptionOfArmaments(SelectedUnit);
            if (CurrentArmaments == -1)
            {
                return false;
            }
            int CurrentFuel = AbsorptionOfFuel(SelectedUnit);

            MENU.PrintRed("+-----------------ATTACK-------------------+");
            Console.Write("The attack will be launched by    ");
            MENU.PrintRed(SelectedUnit.TypeUnit);

            Console.Write("Recent intelligence announcements   ");
            MENU.PrintRed(person.TimeLocatiom.Last().Value);

            Console.Write("The terrorist  for the attack  ");
            MENU.PrintRed(person.Name);

            Console.Write("Attack planning time  ");
            MENU.PrintRed(DateTime.UtcNow.ToString());

            Console.Write("Number of munitions for attack   ");
            MENU.PrintRed($" {CurrentArmaments}");

            Console.Write("Liters of fuel remaining:   ");
            MENU.PrintRed($" {CurrentFuel} \n");



            person.Status = false;
            return true;
        }
        public static int AbsorptionOfArmaments(AttackUnits unit)
        {
            bool input_corect = false;
            while (!input_corect)
            {
                Console.WriteLine("enter number of Armaments to use. press 0 for exit to menu");
                int num = int.Parse(Console.ReadLine()!);
                if (num == 0)
                {
                    return -1;
                }
                input_corect = Manager.IDF.Subarmament(unit, num);
            }
            return unit.CurrentAmmunitionQuantity;

        }
        public static int AbsorptionOfFuel(AttackUnits unit)
        {
            bool input_corect = false;
            while (!input_corect)
            {
                Console.WriteLine("enter number of fuel to use");
                int num = int.Parse(Console.ReadLine());
                input_corect = Manager.IDF.SubFuel(unit, num);
            }
            return unit.FuelSupply;

        }

        public static bool CheckAvailaiballUnit(AttackUnits unit)
        {
            return unit.FuelSupply > 0 && unit.CurrentAmmunitionQuantity > 0 ? true : false;
        }

    }
}