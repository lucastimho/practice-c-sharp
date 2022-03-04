using System;

namespace StringApplication
{
  class String
  {
    static void Main(string[] args)
    {
      string txt = "ABCDEFG";
      Console.WriteLine("The length is: " + txt.Length);
      Console.WriteLine(txt.ToUpper());
      Console.WriteLine(txt.ToLower());
      string firstName = "John";
      string lastName = "Doe";
      string name = string.Concat(firstName, lastName);
      // can always use the + method but this is just another method you could do
      Console.WriteLine(name);
      string name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);
      string txt = "We are the \"Vikings\" from the North.";
    }
  }
}