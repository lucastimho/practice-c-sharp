using System;

public class Program
{
  static void simple(int n)
  {
    for (int i = 1; i <= n; i++)
    {
      if ((i % 5 == 0) && (i % 7 == 0))
      {
        Console.WriteLine(Convert.ToString(i) + " HelloWorld");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine(Convert.ToString(i) + " Hello");
      }
      else if (i % 7 == 0)
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
    simple(10);
  }
}