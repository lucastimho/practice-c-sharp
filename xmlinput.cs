using System;

public class Program
{
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
    xml("<root><parent><child>Hello</child></parent></root>");
  }
}