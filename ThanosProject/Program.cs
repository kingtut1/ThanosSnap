using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThanosProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string universeSizeAsString, names;
            int universeSizeAsInt;
            List<string> peopleInUniverse = new List<string>();
            List<string> bannedPeople = new List<string>();
            Ban ban = new Ban();
            Console.WriteLine("How many people is in your universe?");
            universeSizeAsString = Console.ReadLine();
            universeSizeAsInt = Convert.ToInt32(universeSizeAsString);
            for(int i = 0; i < universeSizeAsInt; i++)
            {
                Console.WriteLine("Enter a person's name from your universe.");
                names = Console.ReadLine();
                peopleInUniverse.Add(names);
            }
            bannedPeople = ban.BalanceUniverse(peopleInUniverse);
            Console.WriteLine("You all stand before Thanos awaiting your faith\nHe snaps");
            System.Threading.Thread.Sleep(3000);
            for(int i = 0; i < bannedPeople.Count; i++)
            {
                Console.WriteLine(bannedPeople.ElementAt(i));
            }
            Console.WriteLine("These souls had to be sacrificed to balance your universe");
            Console.ReadKey();
        }
    }
}
