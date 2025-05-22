using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using IDFProject.attack_units;
using IDFProject;
namespace IDFProject.idf;

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
}
