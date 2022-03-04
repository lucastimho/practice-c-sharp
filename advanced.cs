using System;

public class Program
{
  static void advanced(int n, int p, int q)
  {
    for (int i = 1; i <= n; i++)
    {
      if ((i % p == 0) && (i % q == 0))
      {
        Console.WriteLine(Convert.ToString(i) + " HelloWorld");
      }
      else if (i % p == 0)
      {
        Console.WriteLine(Convert.ToString(i) + " Hello");
      }
      else if (i % q == 0)
      {
        Console.WriteLine(Convert.ToString(i) + " World");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
  public void Main(string[] args)
  {
    advanced(10, 2, 3);
  }
}