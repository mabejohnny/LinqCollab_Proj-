﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };


            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };


            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };


<<<<<<< HEAD
            ////Problem 5
=======
            //Problem 5
>>>>>>> 566db2958ed64e2c64590229005b02b4ab76b8c9
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
<<<<<<< HEAD

=======
            LinqProblems.RunProblem5(classGrades);
>>>>>>> 566db2958ed64e2c64590229005b02b4ab76b8c9

            ////--------------------
            ////Bonus Problem 1
            //string letters = "terrill";

            LinqProblems.RunProblem4(customers);
            Console.ReadLine();

        }
    }
}
