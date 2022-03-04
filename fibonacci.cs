using System;

public class Program
{
  static void fibonacci(int start, int length)
  {
    int[] fib = new int[length + 2];
    fib[0] = 1;
    fib[1] = 1;
    for (int i = 2; i <= length; i++)
    {
      fib[i] = fib[i - 1] + fib[i - 2];
    }
    for (int i = start; i < length; i++)
    {
      Console.WriteLine(fib[i - 1]);
    }
  }
  public void Main(string[] args)
  {
    fibonacci(4, 12);
  }
}