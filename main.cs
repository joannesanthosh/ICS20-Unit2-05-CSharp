// Created by: Joanne Santhosh
// Created on: Mar 2022
//
// This program calculates your salary

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculates your salary
        int numberOfHOursWorked;
        int hourlyRate;
        Console.WriteLine("This program calculates your salary.");
        Console.WriteLine("");

        Console.WriteLine("Enter the number of hours worked.");
        numberOfHOursWorked = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter the hourly rate.");
        hourlyRate = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");
        Console.WriteLine("Your take home salary is: $" + (numberOfHOursWorked * hourlyRate) * (1.00 - 0.18));
        Console.WriteLine("The government will take: $" + 0.18 * (numberOfHOursWorked * hourlyRate));
        numberOfHOursWorked.ToString("0.00"); // returns "0.50"  when decimalVar == 0.5m
        hourlyRate.ToString("0.00"); // returns "0.50"  when decimalVar == 0.5m
        Console.WriteLine("\nDone.");
    }
}