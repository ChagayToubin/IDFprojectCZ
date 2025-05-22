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
}
