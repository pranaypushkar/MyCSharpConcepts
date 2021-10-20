namespace Rotation
{
  using System;
  using System.Linq;
  
  public class RightArrayRotation
  {
    public void Rotate()
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

      for(int index = 0; index < size; index++)
      {
        if(rotation > index) // bifurcate at index 2 (make use of rotation number)
        {
          Console.Write(input[size + index - rotation] + " ");
        }
        else
        {
          Console.Write(input[index - rotation] + " ");
        }
      }

        Console.WriteLine();
    }
  }
}