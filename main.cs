using System;
using Rotation;
using Isomorphic;
using Elements;
using Try;

class Program 
{
  public static void Main (string[] args) 
  {
    int[,] input = new int[,]
    {
      {0,0,0,0},
      {0,0,0,1},
      {0,0,0,0}
    };
int rowIndex = 0;
int columnIndex = 0;
bool isFound = false;
  for (int i = 0; i < input.GetLength(0); i++) 
    {
      for (int j = 0; j < input.GetLength(1); j++) 
      { 
        if(input[i,j] == 1)
        {
          rowIndex = i;
          columnIndex = j;
          isFound = true;
          break;
        }
        if(isFound)
        {
          break;
        }
      }
   }


  for (int i = 0; i < input.GetLength(0); i++) 
    {
      for (int j = 0; j < input.GetLength(1); j++) 
      {
       if(j == columnIndex)
         input[i, j] = 1;

        if(i == rowIndex)
         input[i, j] = 1;
      }
    }


    Console.WriteLine("Printing Matrix: ");
    for (int i = 0; i < input.GetLength(0); i++) 
    {
      for (int j = 0; j < input.GetLength(1); j++) 
      {
         Console.Write(input[i, j] + "\t");
      }
      Console.WriteLine();
    }
    Console.ReadLine();
  }
}