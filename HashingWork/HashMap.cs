using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingWork
{
    class HashMap
    {
        //Vars and constants needed
        private const int PRIMEVALUE = 97;
        int[] theKeys;
        string[] theValues;

        //Constructor
        public HashMap()
        {
            theKeys = new int[PRIMEVALUE];
            theValues = new string[PRIMEVALUE];
        }

        //overrided ToString method to print the entire hash table
        public override string ToString()
        {
            string returnString = "Key     => Value" + Environment.NewLine;
            returnString += "-------------------" + Environment.NewLine;
            for (int i=0; i < theKeys.Length; i++)
            {
                if (theKeys[i] != 0)
                {
                    returnString += theKeys[i].ToString().PadRight(5) + " => " 
                        + theValues[i] + Environment.NewLine;
                }
            }
            return returnString;
        }

        //Show all the places in the array.
        public string ShowArrays()
        {
            string returnString = "";
            returnString += "----------------------";
            for (int i=0; i< theKeys.Length; i++)
            {
                returnString += "[" + i + "] - " + theKeys[i] + " => " + theValues[i] +
                    Environment.NewLine;
            }
            return returnString;
        }

        //Method to get a value out based on a key
        public string Get(int Key)
        {
            int indexForValue = hashFunction(Key);
            return theValues[indexForValue];
        }

        //Method to put a new value into the hashmap based on the key
        public void Put(int Key, string Value)
        {
            int indexForValue = hashFunction(Key);
            theKeys[indexForValue] = Key;
            theValues[indexForValue] = Value;
        }


        //The magical hash function that does the mapping from a large number down to our prime size
        private int hashFunction(int key)
        {
            return key % PRIMEVALUE;
        }

    }
}
