using System;
using System.Collections.Generic;

namespace Collection_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] strArray = {"Tim", "Martin", "Nikki", "Sara"};
            int [,] multiTable = new int[10,10];

            
            List<string> iceCream = new List<string>();
            iceCream.Add("Mint Chip");
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate Chip");
            iceCream.Add("Marrion Berry");
            iceCream.Add("Rocky Road");
            iceCream.Add("Chocolate Malted Crunch");

            Dictionary<string,string> myDict = new Dictionary<string,string>();

            loadBoolArr(new bool[10]);
            loadMultiTable(multiTable);
            manipulateIceCream(iceCream);

            loadDictWithNames(myDict, strArray);
            loadDictWithIceCreame(myDict, iceCream);
            printDict(myDict);
        }

        private static void printDict(Dictionary<string, string> myDict)
        {
            foreach (var entry in myDict){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }

        private static void loadDictWithIceCreame(Dictionary<string, string> myDict, List<string> iceCream)
        {
            Random rand = new Random();

            var keys = new List<string>(myDict.Keys);
            foreach (string key in keys){
                int num = rand.Next(0, iceCream.Count);
                myDict[key] = iceCream[num];
            }
        }

        private static void loadDictWithNames(Dictionary<string, string> myDict, string[] strArray)
        {
            for(int i = 0; i < strArray.Length; i++){
                myDict.Add(strArray[i], null);
            }
        }

        private static void manipulateIceCream(List<string> iceCream)
        {
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.Remove(iceCream[2]);
            Console.WriteLine(iceCream.Count);
        }

        private static void loadMultiTable(int[,] multiTable)
        {
            for(int col = 1; col <= multiTable.GetLength(0); col++){
                Console.Write('[');
                for(int row = 1; row <= multiTable.GetLength(1); row++){
                    multiTable[col-1, row-1] = col * row;
                    if(row==multiTable.GetLength(1)) Console.Write(string.Format("{0}", multiTable[col-1, row-1]));
                    else Console.Write(string.Format("{0},\t ", multiTable[col-1, row-1]));
                }
                Console.Write(']');
                Console.Write(Environment.NewLine);
            }
        }

        private static void loadBoolArr(bool [] boolArray){
            bool initVal = true;
            for(int i = 0; i < boolArray.Length; i++){
                boolArray[i] = initVal;
                initVal = !initVal;
                Console.WriteLine(boolArray[i]);
            }
        }
    }
}
