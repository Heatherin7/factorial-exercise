using System;

namespace Factorial
{
  public class FactorialCalculator
  {
    /// <summary>
    /// returns the factorial of the value parameter.
    /// </summary>
    public int Factorial(int value)
    {
      if (value < 0)
      {
        throw new ArgumentOutOfRangeException();
      }

      if (value == 0)
      {
        return 0;
      }

      int answer = value;

      for (int i = value - 1; i > 1; i--)
      {
        answer *= i;
      }

      return answer;
    }
  }
}