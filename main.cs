using System;

class Program {
  public static void Main (string[] args) {
    // given
    int[] a = {1,2,3,4,5,6,7};
    int k = 2;
    int n = a.Length;

    // right rotation logic
    // If rotation is greater
    // than size of array
    k = k % n;
 
    for(int i = 0; i < n; i++)
    {
       if(i < k)
       {
            
           // Printing rightmost
           // kth elements
           Console.Write(a[n + i - k] + " ");
       }
       else
       {
            
           // Prints array after
           // 'k' elements
           Console.Write(a[i - k] + " ");
       }
    }
    Console.WriteLine();
  }
}