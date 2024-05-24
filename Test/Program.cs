using System;
using System.Linq;
using Test.Extensions;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1: Check for Balanced Brackets in an expression");
            Console.WriteLine("#####################################################");

            var problem1Input1 = "[()]{}{[()()] ()}";
            var problem1HasBalancedBrakets = problem1Input1.HasBalancedBrakets();
            var problem1Result1 = problem1HasBalancedBrakets ? "Balanced" : "Not Balanced";
            Console.WriteLine($"INPUT = {problem1Input1}");
            Console.WriteLine($"RESULT = {problem1Result1}");

            Console.WriteLine("#####################################################");

            var problem1Input2 = "[(])";
            var problem1Input2HasBalancedBrakets = problem1Input2.HasBalancedBrakets();
            var problem1Result2= problem1Input2HasBalancedBrakets ? "Balanced" : "Not Balanced";
            Console.WriteLine($"INPUT = {problem1Input2}");
            Console.WriteLine($"RESULT = {problem1Result2}");

            Console.WriteLine("#####################################################");
            Console.WriteLine("Problem 2: Single Number");
            Console.WriteLine("#####################################################");

            var problem2Input1 = new[] { 2, 2, 1 };
            var problem2Result1 = problem2Input1.GetUniqueValues();
            Console.WriteLine($"INPUT = {string.Join(",",problem2Input1)}");
            Console.WriteLine($"RESULT = {problem2Result1.First()}");

            Console.WriteLine("#####################################################");

            var problem2Input2 = new[] { 4, 1, 2, 1, 2 };
            var problem2Result2 = problem2Input2.GetUniqueValues();
            Console.WriteLine($"INPUT = {string.Join(",", problem2Input2)}");
            Console.WriteLine($"RESULT = {problem2Result2.First()}");

            Console.WriteLine("#####################################################");

            var problem2Input3 = new[] { 1 };
            var problem2Result3 = problem2Input3.GetUniqueValues();
            Console.WriteLine($"INPUT = {string.Join(",", problem2Input3)}");
            Console.WriteLine($"RESULT = {problem2Result3.First()}");

            Console.WriteLine("#####################################################");

            var problem2Input4 = new[] { 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 1, 2, 6, 6, 6, 6 };
            var problem2Result4 = problem2Input4.GetUniqueValues();
            Console.WriteLine($"INPUT = {string.Join(",", problem2Input4)}");
            Console.WriteLine($"RESULT = {problem2Result4.First()}");

            Console.WriteLine("#####################################################");
            Console.ReadLine();

        }
    }

}

