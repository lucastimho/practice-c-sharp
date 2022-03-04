using System;
// put 'using System.Linq;' when usging Min(), Max(), or Sum() on arrays
namespace ArraysApplication
{
  class Arrays
  {
    static void Main(string[] args)
    {
      string[] cars = { "Volvo", "BMV", "Ford", "Mazda" };
      int[] myNum = { 10, 20, 30, 40 };
      foreach (string i in cars)
      {
        Console.WriteLine(i);
      }
      Array.Sort(myNum);
    }
  }
}