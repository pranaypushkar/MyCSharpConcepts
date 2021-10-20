namespace Rotation
{
  using System;
  using System.Linq;
  
  public class LeftArrayRotation
  {
     public void Rotate1()
    {
      int[] input = {1,2,3,4,5,6,7};
      int size = input.Length;
      int rotation = 2;
      // edge cases
      // if rotation == 0 => print same array
      // if rotation == size of array => print same array
      // if rotation % size == 0 => print same array 
      
      if(rotation == 0 || rotation == size || rotation % size == 0)
      {
        Array.ForEach(input, Console.WriteLine);
      }

      // Pre Processing
      if(rotation > size)
      {
        rotation = rotation % size;
      }

      for(int i = 0; i < rotation; i ++)
      {
        LeftRotateByOne(input, size);
      }

      Array.ForEach(input, Console.Write);
      Console.WriteLine();
    }

    private void LeftRotateByOne(int[] input, int size)
    {
      // index check of size-1
      int temp = input[0];
      for(int index = 0; index < size-1; index++)
      {
        input[index] = input[index + 1];
      }

      input[size-1] = temp;
    }

     public void Rotate2()
    {
      int[] input = {1,2,3,4,5,6,7};
      int size = input.Length;
      int rotation = 2;
      // edge cases
      // if rotation == 0 => print same array
      // if rotation == size of array => print same array
      // if rotation % size == 0 => print same array 
      
      if(rotation == 0 || rotation == size || rotation % size == 0)
      {
        Array.ForEach(input, Console.WriteLine);
      }

      // Pre Processing
      if(rotation > size)
      {
        rotation = rotation % size;
      }

       LeftRotate(input, size, rotation);
    }

    private void LeftRotate(int[] arr, int n, int k)
    {
        // To get the starting
        // point of rotated array
        int mod = k % n;
 
        // Prints the rotated array
        // from start position
        for (int i = 0; i < n; ++i)
            Console.Write(arr[(i + mod) % n] + " ");
 
        Console.WriteLine();
    }
  }
}

