using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;


namespace Idf
{
    internal class Program
    {
        //public static List<Terrorist> listTerrorist = new List<Terrorist>();
        //public static Hamas hamas;
        //public static IntelligenceDepartment IntelligenceDepartmentt;
        //public static IdfMain IDF; 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Weweworld!");
            //initialization();
            InittialtionMain start = new InittialtionMain();

        }
    }
}
        //public static void initialization()
        //{
        //    initializationTerroist();
        //    initializationhamas();
        //    initializationIntelligenceDepartment();
        //    AttackUnit();
        //    Menu();
        //}
        //public static void Menu()
        //{
        //    ShowMainMenu();
        //}
        //static void ShowMainMenu()
        //{
        //    PrintRed("========== IDF Strategic Operations Menu ==========");
        //    Console.WriteLine("Welcome, Commander. Prepare to lead your team with precision.");
        //    Console.WriteLine("Choose an operation to begin:");
        //    Console.WriteLine("1. Intelligence Analysis");
        //    Console.WriteLine("2. Attack Readiness");
        //    Console.WriteLine("3. Target Prioritization");
        //    Console.WriteLine("4. Attack Execution");
        //    Console.WriteLine("5. Exit");
        //    Console.Write("Enter your choice (1-5): ");

        //    string input = Console.ReadLine();

        //    switch (input)
        //    {
        //        case "1":
        //            TheMostMessages();
        //            break;
        //        case "2":
        //            PrepareUnits();
        //            break;
        //        case "3":
        //            object d=TheMostDangerous();
        //            break;
        //        case "4":
        //            ExecuteStrike();
        //            break;
        //        case "5":
        //            Console.WriteLine("Exiting. Stay sharp, Commander.");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice. Try again.");
                   
        //            Console.ReadKey();
        //            Console.Clear();
        //            ShowMainMenu();
        //            break;
                    
        //    }
        //    Console.ReadKey();
        //    Console.Clear();
        //    ShowMainMenu();

        //}
        ////1
        //static void TheMostMessages()
        //{
        //    Terrorist Mostmessagetero = IntelligenceDepartmentt.hamas.ListTerrorist[0];
        //    int countTMost = 0;

        //    foreach (var item in IntelligenceDepartmentt.hamas.ListTerrorist)
        //    {
        //        if (countTMost < item.TimeLocatiom.Count)
        //        {
        //            countTMost = item.TimeLocatiom.Count;
        //            Mostmessagetero = item;
        //        }
        //    }
        //    Console.WriteLine(Mostmessagetero.Name);

        //}
        //2
//        static void PrepareUnits()
//        {
//            IDF.ShowAvailableUnits();
//        }
//        //3
//        static Terrorist TheMostDangerous()//חגי 
//        {
//            Terrorist Mostmessagetero= IntelligenceDepartmentt.hamas.ListTerrorist[0];
//            int MostDangerScore = 0;

//            foreach (var item in IntelligenceDepartmentt.hamas.ListTerrorist)
//            {
//                if (PointCalculation(item.Weapon, item.Rank) > MostDangerScore&&item.Status)
//                {
//                    Mostmessagetero = item;
//                    MostDangerScore = PointCalculation(item.Weapon, item.Rank);
//                }
//            }
//            static int PointCalculation(List<string> Weapon, int Rank)
//            {
//                int calculation = 0;
//                if (Weapon.Contains("Knife"))
//                {
//                    calculation += 1;
//                }
//                if (Weapon.Contains("Handgun"))
//                {
//                    calculation += 2;
//                }
//                if( (Weapon.Contains("AK-47") || Weapon.Contains("M16")))
//                {
//                    calculation += 3;
//                }
//                return calculation * Rank;
//            }
//            Console.WriteLine("the target of the attack"+" "+ Mostmessagetero.Name + "risk level" + MostDangerScore);
//            return Mostmessagetero;
//        }
//        //4
//        static void ExecuteStrike()
//        {
//            Terrorist person = TheMostDangerous();
//            Console.Clear();


//            string location =person.TimeLocatiom.Last().Value; //מצפה לקבל את המיקום של המחבל המיועד לתקיפה
//            AttackUnits SelectedUnit = IDF.SelectUnitByLocation(location); //מקבל את האבייקט של כלי התקיפה
//            Console.WriteLine(   ($" Attack tool to use {SelectedUnit.TypeUnit}"));
//            int input_uncorect = AbsorptionOfArmaments(SelectedUnit);
            

//            PrintRed("+-----------------ATTACK-------------------+");
//            Console.Write("The attack will be launched by    ");
//            PrintRed( SelectedUnit.TypeUnit);      

//            Console.Write("Recent intelligence announcements   ");
//            PrintRed(person.TimeLocatiom.Last().Value);
     
//            Console.Write("The terrorist  for the attack  ");
//            PrintRed(person.Name);

//            Console.Write("Attack planning time  ");
//            PrintRed(DateTime.UtcNow.ToString());

//            Console.Write("Number of munitions for attack   ");
//            PrintRed($" {input_uncorect}");

//            person.Status = false;



//        }



//        static void PrintRed(string message)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine(message);
//            Console.ResetColor(); // מחזיר לצבע ברירת מחדל
//        }
//        public static void initializationhamas()
//        {
//            hamas = new Hamas("0000", "ali ali", listTerrorist);
//        }
//        public static void initializationIntelligenceDepartment()
//        {
//            IntelligenceDepartmentt = new IntelligenceDepartment(hamas);
//        }
//        public static void initializationTerroist()
//        {

          

//            Terrorist person1 = new Terrorist("Tariq Ahmad", 2, true, new List<string> { "Knife", "Handgun" });
//            listTerrorist.Add(person1);
//            Terrorist person2 = new Terrorist("Omar Ali", 5, true, new List<string> { "AK-47" });
//            listTerrorist.Add(person2);
//            Terrorist person3 = new Terrorist("Khaled Fadi", 100, true, new List<string> { "M16", "Knife", "AK-47" });
//            listTerrorist.Add(person3);
//            Terrorist person4 = new Terrorist("Hassan Hassan", 3, true, new List<string> { "Knife" });
//            listTerrorist.Add(person4);
//            Terrorist person5 = new Terrorist("Ibrahim Omar", 4, true, new List<string> { "Handgun", "M16" });
//            listTerrorist.Add(person5);
//            Terrorist person6 = new Terrorist("Ahmad Khaled", 2, true, new List<string> { "Knife", "AK-47" });
//            listTerrorist.Add(person6);
//            Terrorist person7 = new Terrorist("Ahmad Yasir", 1, true, new List<string> { "M16" });
//            listTerrorist.Add(person7);
//            Terrorist person8 = new Terrorist("Khaled Ali", 3, true, new List<string> { "Handgun", "M16", "AK-47" });
//            listTerrorist.Add(person8);
//            Terrorist person9 = new Terrorist("Hassan Nabil", 5, true, new List<string> { "Knife", "Handgun" });
//            listTerrorist.Add(person9);
//            Terrorist person10 = new Terrorist("Ahmad Ibrahim", 2, true, new List<string> { "M16", "AK-47", "Knife" });
//            listTerrorist.Add(person10);
//            Terrorist person11 = new Terrorist("Tariq Ali", 4, true, new List<string> { "AK-47", "Handgun" });
//            listTerrorist.Add(person11);
//            Terrorist person12 = new Terrorist("Ahmad Yasir", 1, true, new List<string> { "M16", "Knife" });
//            listTerrorist.Add(person12);
//            Terrorist person13 = new Terrorist("Fadi Omar", 1, true, new List<string> { "AK-47", "Knife" });
//            listTerrorist.Add(person13);
//            Terrorist person14 = new Terrorist("Hassan Fadi", 3, true, new List<string> { "Handgun" });
//            listTerrorist.Add(person14);
//            Terrorist person15 = new Terrorist("Tariq Khaled", 2, true, new List<string> { "Knife", "M16" });
//            listTerrorist.Add(person15);
//            Terrorist person16 = new Terrorist("Fadi Yasir", 1, true, new List<string> { "AK-47", "Knife", "Handgun" });
//            listTerrorist.Add(person16);
//            Terrorist person17 = new Terrorist("Ibrahim Ahmad", 4, true, new List<string> { "M16", "Handgun" });
//            listTerrorist.Add(person17);
//            Terrorist person18 = new Terrorist("Tariq Fadi", 5, true, new List<string> { "Knife", "AK-47" });
//            listTerrorist.Add(person18);
//            Terrorist person19 = new Terrorist("Ali Ahmad", 1, true, new List<string> { "M16", "Knife" });
//            listTerrorist.Add(person19);
//            Terrorist person20 = new Terrorist("Ahmad Ali", 3, true, new List<string> { "Handgun" });
//            listTerrorist.Add(person20);
//            Terrorist person21 = new Terrorist("Ali Yasir", 4, true, new List<string> { "M16", "Handgun", "Knife" });
//            listTerrorist.Add(person21);
//            Terrorist person22 = new Terrorist("Ahmad Hassan", 2, true, new List<string> { "Knife", "M16" });
//            listTerrorist.Add(person22);
//            Terrorist person23 = new Terrorist("Fadi Omar", 3, true, new List<string> { "Handgun", "AK-47" });
//            listTerrorist.Add(person23);
//            Terrorist person24 = new Terrorist("Tariq Ali", 1, true, new List<string> { "M16", "Knife", "AK-47" });
//            listTerrorist.Add(person24);
//            Terrorist person25 = new Terrorist("Ibrahim Khaled", 2, true, new List<string> { "AK-47", "Handgun" });
//            listTerrorist.Add(person25);
//            Terrorist person26 = new Terrorist("Ali Ali", 5, true, new List<string> { "Knife", "M16" });
//            listTerrorist.Add(person26);
//            Terrorist person27 = new Terrorist("Tariq Yasir", 1, true, new List<string> { "AK-47", "Knife", "Handgun" });
//            listTerrorist.Add(person27);
//            Terrorist person28 = new Terrorist("Omar Fadi", 4, true, new List<string> { "AK-47" });
//            listTerrorist.Add(person28);
//            Terrorist person29 = new Terrorist("Khaled Omar", 3, true, new List<string> { "Knife", "M16" });
//            listTerrorist.Add(person29);
//            Terrorist person30 = new Terrorist("Khaled Khaled", 5, true, new List<string> { "M16" });
//            listTerrorist.Add(person30);
//            Terrorist person31 = new Terrorist("Ali Ahmad", 4, true, new List<string> { "AK-47" });
//            listTerrorist.Add(person31);
//            Terrorist person32 = new Terrorist("Nabil Yasir", 2, true, new List<string> { "Handgun", "Knife" });
//            listTerrorist.Add(person32);
//            Terrorist person33 = new Terrorist("Fadi Khaled", 5, true, new List<string> { "Knife", "Handgun" });
//            listTerrorist.Add(person33);
//            Terrorist person34 = new Terrorist("Khaled Khaled", 2, true, new List<string> { "Handgun", "Knife" });
//            listTerrorist.Add(person34);
//            Terrorist person35 = new Terrorist("Ali Ahmad", 1, true, new List<string> { "Knife" });
//            listTerrorist.Add(person35);
//            Terrorist person36 = new Terrorist("Hassan Ahmad", 3, true, new List<string> { "M16", "AK-47" });
//            listTerrorist.Add(person36);


//            //Console.WriteLine(hamas.CurrentCommander +"   " + hamas.ListTerrorist[0].Name);


//        }
//        public static void AttackUnit() //zalmen
//        {
//            IDF = new IdfMain("1948", "zamir");
//            IDF.AddAttackUnit(new AttackUnits("f16", 500, 8));
//            IDF.AddAttackUnit(new AttackUnits("zik", 50, 3));
//            IDF.AddAttackUnit(new AttackUnits("M109 Artillery", 500, 1));
//            foreach (var i in IDF.AtackUnits)
//            {

//                Console.WriteLine(i.TypeUnit);
//            }
//        }
//        public static int AbsorptionOfArmaments(AttackUnits unit)
//        {
//            bool input_uncorect = false;
//            while (!input_uncorect)
//            {
//                Console.WriteLine("enter number of Armaments to use");
//                int num = int.Parse(Console.ReadLine());
//                input_uncorect = IDF.Disarmament(unit, num);
//            }
//            return unit.CurrentAmmunitionQuantity;
         
//        }




//    }
//}
