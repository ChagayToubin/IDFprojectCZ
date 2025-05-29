
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Idf;

namespace Idf
{
    internal  class InittialtionMain
    {         
        
        public static void initialization()
        {
            initializationTerroist();
            initializationhamas();
            initializationIntelligenceDepartment();
            initializationIdf();
            initializationAttackUnit();
            
        }
        public static void initializationhamas()
        {
           Manager.hamas = new Hamas("0000", "ali ali", Manager.listTerrorist);
        }
        public static void initializationIntelligenceDepartment()
        {
            Manager.IntelligenceDepartmentt = new IntelligenceDepartment(Manager.hamas);
        }
        
        public static void initializationIdf()
        {
            Manager.IDF = new IdfMain("1948", "zamir");
        }

        public static void initializationAttackUnit() 
        {
            Manager.IDF.AddAttackUnit(new AttackUnits("f16", 500, 8));
            Manager.IDF.AddAttackUnit(new AttackUnits("zik", 50, 3));
            Manager.IDF.AddAttackUnit(new AttackUnits("M109 Artillery", 500, 1));
           
        }
        public static void initializationTerroist()
        {
            Terrorist person1 = new Terrorist("Tariq Ahmad", 2, true, new List<string> { "Knife", "Handgun" });
            Manager.listTerrorist.Add(person1);   
            Terrorist person2 = new Terrorist("www", 5, true, new List<string> { "AK-47" });
            Manager.listTerrorist.Add(person2);
            Terrorist person3 = new Terrorist("Khaled Fadi", 100, true, new List<string> { "M16", "Knife", "AK-47" });
            Manager.listTerrorist.Add(person3);
            Terrorist person4 = new Terrorist("Hassan Hassan", 3, true, new List<string> { "Knife" });
            Manager.listTerrorist.Add(person4);
            Terrorist person5 = new Terrorist("Ibrahim Omar", 4, true, new List<string> { "Handgun", "M16" });
            Manager.listTerrorist.Add(person5);
            Terrorist person6 = new Terrorist("Ahmad Khaled", 2, true, new List<string> { "Knife", "AK-47" });
            Manager.listTerrorist.Add(person6);
            Terrorist person7 = new Terrorist("Ahmad Yasir", 1, true, new List<string> { "M16" });
            Manager.listTerrorist.Add(person7);
            Terrorist person8 = new Terrorist("Khaled Ali", 3, true, new List<string> { "Handgun", "M16", "AK-47" });
            Manager.listTerrorist.Add(person8);
            Terrorist person9 = new Terrorist("Hassan Nabil", 5, true, new List<string> { "Knife", "Handgun" });
            Manager.listTerrorist.Add(person9);
            Terrorist person10 = new Terrorist("Ahmad Ibrahim", 2, true, new List<string> { "M16", "AK-47", "Knife" });
            Manager.listTerrorist.Add(person10);
            Terrorist person11 = new Terrorist("Tariq Ali", 4, true, new List<string> { "AK-47", "Handgun" });
            Manager.listTerrorist.Add(person11);
            Terrorist person12 = new Terrorist("Ahmad Yasir", 1, true, new List<string> { "M16", "Knife" });
            Manager.listTerrorist.Add(person12);
            Terrorist person13 = new Terrorist("Fadi Omar", 1, true, new List<string> { "AK-47", "Knife" });
            Manager.listTerrorist.Add(person13);
            Terrorist person14 = new Terrorist("Hassan Fadi", 3, true, new List<string> { "Handgun" });
            Manager.listTerrorist.Add(person14);
            Terrorist person15 = new Terrorist("Tariq Khaled", 2, true, new List<string> { "Knife", "M16" });
            Manager.listTerrorist.Add(person15);
            Terrorist person16 = new Terrorist("Fadi Yasir", 1, true, new List<string> { "AK-47", "Knife", "Handgun" });
            Manager.listTerrorist.Add(person16);
            Terrorist person17 = new Terrorist("Ibrahim Ahmad", 4, true, new List<string> { "M16", "Handgun" });
            Manager.listTerrorist.Add(person17);
            Terrorist person18 = new Terrorist("Tariq Fadi", 5, true, new List<string> { "Knife", "AK-47" });
            Manager.listTerrorist.Add(person18);
            Terrorist person19 = new Terrorist("Ali Ahmad", 1, true, new List<string> { "M16", "Knife" });
            Manager.listTerrorist.Add(person19);
            Terrorist person20 = new Terrorist("Ahmad Ali", 3, true, new List<string> { "Handgun" });
            Manager.listTerrorist.Add(person20);
            Terrorist person21 = new Terrorist("Ali Yasir", 4, true, new List<string> { "M16", "Handgun", "Knife" });
            Manager.listTerrorist.Add(person21);
            Terrorist person22 = new Terrorist("Ahmad Hassan", 2, true, new List<string> { "Knife", "M16" });
            Manager.listTerrorist.Add(person22);
            Terrorist person23 = new Terrorist("Fadi Omar", 3, true, new List<string> { "Handgun", "AK-47" });
            Manager.listTerrorist.Add(person23);
            Terrorist person24 = new Terrorist("Tariq Ali", 1, true, new List<string> { "M16", "Knife", "AK-47" });
            Manager.listTerrorist.Add(person24);
            Terrorist person25 = new Terrorist("Ibrahim Khaled", 2, true, new List<string> { "AK-47", "Handgun" });
            Manager.listTerrorist.Add(person25);
            Terrorist person26 = new Terrorist("Ali Ali", 5, true, new List<string> { "Knife", "M16" });
            Manager.listTerrorist.Add(person26);
            Terrorist person27 = new Terrorist("Tariq Yasir", 1, true, new List<string> { "AK-47", "Knife", "Handgun" });
            Manager.listTerrorist.Add(person27);
            Terrorist person28 = new Terrorist("Omar Fadi", 4, true, new List<string> { "AK-47" });
            Manager.listTerrorist.Add(person28);
            Terrorist person29 = new Terrorist("Khaled Omar", 3, true, new List<string> { "Knife", "M16" });
            Manager.listTerrorist.Add(person29);
            Terrorist person30 = new Terrorist("Khaled Khaled", 5, true, new List<string> { "M16" });
            Manager.listTerrorist.Add(person30);
            Terrorist person31 = new Terrorist("Ali Ahmad", 4, true, new List<string> { "AK-47" });
            Manager.listTerrorist.Add(person31);
            Terrorist person32 = new Terrorist("Nabil Yasir", 2, true, new List<string> { "Handgun", "Knife" });
            Manager.listTerrorist.Add(person32);
            Terrorist person33 = new Terrorist("Fadi Khaled", 5, true, new List<string> { "Knife", "Handgun" });
            Manager.listTerrorist.Add(person33);
            Terrorist person34 = new Terrorist("Khaled Khaled", 2, true, new List<string> { "Handgun", "Knife" });
            Manager.listTerrorist.Add(person34);
            Terrorist person35 = new Terrorist("Ali Ahmad", 1, true, new List<string> { "Knife" });
            Manager.listTerrorist.Add(person35);
            Terrorist person36 = new Terrorist("Hassan Ahmad", 3, true, new List<string> { "M16", "AK-47" });
            Manager.listTerrorist.Add(person36);

        }
      

    }


}