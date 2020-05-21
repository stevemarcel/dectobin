using System;

namespace dectobin {
  class Program {
    static void Main (string[] args) {
      string input;
      string result;

      Console.Write ("\nEnter a base 10 number: ");
      input = Console.ReadLine ();

      int num = Convert.ToInt32 (input);
      result = "";

      while (num > 1) {
        int remainder = num % 2;
        result = Convert.ToString (remainder) + result;
        num /= 2;
      }

      result = Convert.ToString (num) + result;
      Console.WriteLine ("\nIn Binary: {0}", result);
    }
  }
}