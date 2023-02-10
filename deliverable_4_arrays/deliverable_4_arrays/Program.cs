/* Author: Khushi Udupi
 Date: 02/08/2023
Description: Demonstrating the use of arrays for computing the first 25 numbers of the fibonacci sequence,
where f(n) = f(n-2) +f(n-1)*/

using System;

namespace deliverable_4_arrays;
class Program
{
    static void Main(string[] args)
    {
        int[] fibonacci = new int[25];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (int i = 2; i < fibonacci.Length; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);

        }

        Console.ReadLine();
                
    }
}

