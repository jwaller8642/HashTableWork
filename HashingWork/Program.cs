using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingWork
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMap valleyNumToName = new HashMap();
            Dictionary<int, string> valleyNumToNameUsingDictionary = new Dictionary<int, string>();

            Console.WriteLine("Adding some entries");
            valleyNumToName.Put(12345, "James Kirk");
            valleyNumToName.Put(23456, "Benjamin Sisko");
            valleyNumToName.Put(34567, "Kathryn Janeway");
            valleyNumToName.Put(45678, "Jean-Luc Picard");
            valleyNumToName.Put(56789, "Jonathan Archer");

            Console.WriteLine("The filled hash table");
            Console.WriteLine(valleyNumToName);
            Console.WriteLine();
            Console.WriteLine(valleyNumToName.ShowArrays());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Get a single person out");
            Console.WriteLine("valleyNumToName.Get(45678)");
            Console.WriteLine(valleyNumToName.Get(45678));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Gonna put in two people that hash to the same location");
            valleyNumToName.Put(26189, "First Entry");
            valleyNumToName.Put(26092, "Second Entry");

            Console.WriteLine(valleyNumToName);
            Console.WriteLine();
            Console.WriteLine(valleyNumToName.ShowArrays());

            Console.WriteLine("******************************************************************");

            Console.WriteLine("Adding some entries");
            
            valleyNumToNameUsingDictionary.Add(12345, "James Kirk");
            valleyNumToNameUsingDictionary.Add(23456, "Benjamin Sisko");
            valleyNumToNameUsingDictionary.Add(34567, "Kathryn Janeway");
            valleyNumToNameUsingDictionary.Add(45678, "Jean-Luc Picard");
            valleyNumToNameUsingDictionary.Add(56789, "Jonathan Archer");

            Console.WriteLine("The filled hash table");
            foreach (int key in valleyNumToNameUsingDictionary.Keys)
            {
                Console.WriteLine(key + " => " + valleyNumToNameUsingDictionary[key]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Get a single person out");
            Console.WriteLine("valleyNumToName.Get(45678)");
            Console.WriteLine(valleyNumToNameUsingDictionary[45678]);
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Gonna put in two people that hash to the same location");
            valleyNumToNameUsingDictionary.Add(26189, "First Entry");
            valleyNumToNameUsingDictionary.Add(26092, "Second Entry");

            foreach (int key in valleyNumToNameUsingDictionary.Keys)
            {
                Console.WriteLine(key + " => " + valleyNumToNameUsingDictionary[key]);
            }

        }
    }
}
