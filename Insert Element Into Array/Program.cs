using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Element_Into_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] stocks; ////Array Declaration Variable 
            Console.WriteLine("Enter the size of an array:");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine()); ////Get Input Value(SIZE) from the User
            stocks = new int[sizeOfArray]; ////Array Initilize 
            Console.WriteLine("Enter the Array Elements One By One");
            for (int i=0 ; i < sizeOfArray; i++)  ////i <= sizeOfArray INDEX was oustide the bounds of the array-EXCEPTION
            {
                stocks[i] = Convert.ToInt32(Console.ReadLine());  ////Inserting Values Entered By the User to Array
            }

            Console.WriteLine("Printing the Elements in Each Position of an Array");
            ////foreach (var item in stocks)
            ////{
            ////    Console.WriteLine(item);  ////Print Using ForEach Loop
            ////}

            for (int i=0; i < sizeOfArray; i++)
            { 
                Console.WriteLine("Position of "+ i + ": " +stocks[i]); ////Print Using For Loop
            }

            Console.WriteLine("$$QUIT$$");
            Console.ReadKey();
        }
    }}