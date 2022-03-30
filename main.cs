// Created by: Zaida Hammel
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the perimeter of a square
        int Side;

        Console.WriteLine("This program calculates the perimeter of a square.");
        Console.WriteLine("");
        Console.Write("Enter the length of the side (cm): ");
        Side = Convert.ToInt32(Console.ReadLine());

        Double Perimeter = (Side) * 4;

        Console.WriteLine("");
        Console.Write("Perimeter of the square = " + Perimeter + " cm");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}