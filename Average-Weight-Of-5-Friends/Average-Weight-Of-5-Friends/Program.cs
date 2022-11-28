// See https://aka.ms/new-console-template for more information
using System;

namespace OOP2_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            People Freind1 = new People { Name = "Chawakorn", Weight = 110 };
            People Freind2 = new People { Name = "Chadaporn", Weight = 45 };
            People Freind3 = new People { Name = "Metagorn", Weight = 66 };
            People Freind4 = new People { Name = "Netithorn", Weight = 52 };
            People Freind5 = new People { Name = "Akkarawit", Weight = 50 };
            int Allweight = (Freind1.Weight + Freind2.Weight + Freind3.Weight + Freind4.Weight + Freind5.Weight) / 5;
            Console.WriteLine(string.Format("Average weight of 5 friends : {0}", Allweight));
            Console.WriteLine(string.Format("Most weight is: {0} weight {1} Kg", Freind1.Name, Freind1.Weight));
            Console.WriteLine(string.Format("Less weight is: {0} weight {1} Kg", Freind2.Name, Freind2.Weight));
            Console.WriteLine(" Editor : Chadaporn Pinichsai ID : 653450281-9 ");
            Console.ReadKey();
        }
    }
    class People
    {
        public string Name;
        public int Weight;
    }
}
