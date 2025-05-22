using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Idf;

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
        foreach (var i in AtackUnits)
        {
            if (i.CurrentAmmunitionQuantity > 0)
            {
                Console.WriteLine(i.TypeUnit);
            }
        }
    }
    public AttackUnits SelectUnitByLocation(string location)
    {
        foreach (var i in AtackUnits)
        {
            if (i.EffectiveAgainst.Contains(location))
                return i;
        }
        return AtackUnits[0];
    }

    public void Disarmament(AttackUnits unit, int num_armaments)
    {
        if (ArmamentCapacityTest(unit, num_armaments))
        {
            unit.CurrentAmmunitionQuantity -= num_armaments;
        }
        else
            Console.WriteLine($"There are not enough ammunition for the attack!! You are requesting the use of {num_armaments} ammunition and the vehicle is only loaded with {unit.CurrentAmmunitionQuantity} ammunition.");
            
            

    }
    
    public void AmmunitionLoading(AttackUnits unit, int num_armaments)
    {
        unit.CurrentAmmunitionQuantity += num_armaments;
    }

    public bool ArmamentCapacityTest(AttackUnits unit, int num_armaments)
    {
        return (unit.CurrentAmmunitionQuantity - num_armaments) >= 0 ? true : false;
    }
}
