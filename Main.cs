//Dylan Grandjean
//Assignment 2 - Data Types App
//Introductory program to different data types and their interactibility

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Main
    {
        static void Main(string[] args)
        {
            //Variable instantiation
            //Part 1
            string fName = "Liam",
                   lName = "McKelly",
                   homeTown = "Geneva",
                   major = "Computer Studies",
                   hobby = "Progamming",
                   activity = "Running";

            //Part 2
            double totalBill = 80.0,
                   liquorPrice = 15.0,
                   tipPercentage = 0.2;

            //Calculate the amount of the bill and tip for part 2
            double billWithoutLiquor = totalBill - liquorPrice,
                   tip = billWithoutLiquor * tipPercentage;

            //Displays the variables from part 1 to the console
            Console.WriteLine("*****************************************" +
                              "\n*\tName: " + fName + " " + lName + "\\\t\t*" +
                              "\n*\tHometown: " + homeTown + "\\\t\t*" +
                              "\n*\tMajor: " + major + "\\\t*" +
                              "\n*\tHobby: " + hobby + "\\\t\t*" +
                              "\n*\tFavorite Activity: " + activity + "\\\t*" +
                              "\n*****************************************\n");

            //Displays the results from part 2 to the console
            Console.WriteLine("*****************************************" +
                              "\n*\tThe total bill is $" + billWithoutLiquor + "\t\t*" +
                              "\n*\tThe liquor amount is $" + liquorPrice + "\t*" +
                              "\n*\tThe tip amount is $" + tip + "\t\t*" +
                              "\n*****************************************");
            Console.Read();


        }
    }
}
