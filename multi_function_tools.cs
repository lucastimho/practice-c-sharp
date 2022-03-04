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
  static void xml(string xmlInput)
  {
    int last = xmlInput.Length;
    int count = 0;
    int bracket = 0;
    int slash = 0;
    foreach (char s in xmlInput)
    {
      if (s == '>')
      {
        break;
      }
      else
      {
        count += 1;
      }
    }
    foreach (char s in xmlInput)
    {
      if (s == '<')
      {
        bracket += 1;
      }
      else if (s == '/')
      {
        slash += 1;
      }
    }
    if ((xmlInput[1] == xmlInput[last - count]) && ((slash * 2) == bracket))
    {
      Console.WriteLine("\"xmlInput\" is well-formed XML.");
    }
    else if ((xmlInput[1] == xmlInput[last - count]) || ((slash * 2) == bracket))
    {
      Console.WriteLine("\"xmlInput\" has one or more errors.");
    }
    else
    {
      Console.WriteLine("Input does not appear to be XML.");
    }
  }
  public void Main(string[] args)
  {
    Console.WriteLine("What feature would you like to use: simple, advanced, fibonacci, or xml");
    string input = Console.ReadLine().ToLower();
    if (input == "simple")
    {
      Console.WriteLine("How many numbers would you like?");
      string n = Console.ReadLine();
      simple(Convert.ToInt32(n));
    }
    else if (input == "advanced")
    {
      Console.WriteLine("How many numbers would you like?");
      string n = Console.ReadLine();
      Console.WriteLine("What denominator would you like for hello?");
      string p = Console.ReadLine();
      Console.WriteLine("What denominator would you like for world?");
      string q = Console.ReadLine();
      advanced(Convert.ToInt32(n), Convert.ToInt32(p), Convert.ToInt32(q));
    }
    else if (input == "fibonacci")
    {
      Console.WriteLine("What position would you like to start at?");
      string start = Console.ReadLine();
      Console.WriteLine("What position would you like to end at?");
      string length = Console.ReadLine();
      fibonacci(Convert.ToInt32(start), Convert.ToInt32(length));
    }
    else if (input == "xml")
    {
      Console.WriteLine("Type in your xml code");
      string xmlInput = Console.ReadLine();
      xml(xmlInput);
    }
    else
    {
      Console.WriteLine("That is not a valid input, please try again.");
    }
  }
}