using April7.Models;
using System;

namespace April7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDataStructure<string> myDataStructure = new MyDataStructure<string>();

            myDataStructure.Add("Kamil");
            myDataStructure.Add("Hatamli");

            myDataStructure.Add("Hatam");

            for (int i = 0; i < myDataStructure.Length; i++)
            {
                Console.WriteLine(myDataStructure.GetArray[i]);
            }
        }
    }
}
