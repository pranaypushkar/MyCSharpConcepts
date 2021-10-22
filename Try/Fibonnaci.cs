namespace Try
{
  public class Factorial
  {
    //calculating factorial in recusive fashion
    public int Calculate(int number)
    {
      // Edge cases
      if(number == 1 || number == 0)
      {
        return 1;
      }

      return number * Calculate(number-1);
    }
  }
}