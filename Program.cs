using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }
        public static void runApp()
        {
            string[] students = new string[5];
            students[0] = "Rahul";
            students[1] = "Sam";
            students[2] = "Aman";
            students[3] = "Sahil";
            students[4] = "Sunny";
        
            int currElem = 0;
            printViaRecursion(students, currElem);
        }

        public static void printViaRecursion(string[] arr, int currElem)
        {
            Console.WriteLine(arr[currElem]);
            if (currElem < arr.Length - 1)
                printViaRecursion(arr, currElem + 1);
        }

    }
}
