using System;
using Rotation;
using Isomorphic;
using Elements;
using Try;

class Program 
{
  public static void Main (string[] args) 
  {
    int number = 5;
    // Top Edge case
    if(number < 0)
    {
        Console.WriteLine("Invalid Number");
    }

    Factorial factorial = new Factorial();
    Console.WriteLine(factorial.Calculate(number));
  }
}