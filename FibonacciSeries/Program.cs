using System;

namespace FibonacciSeries {
  class Program {
    static void Main(string[] args) {
      int count = 10;
      if (args.Length == 1)
        int.TryParse(args[0], out count);

      int[] fibonacci = Fibonacci.CreateSeries(count);

      for (int i = 0; i < fibonacci.Length; i++) {
        Console.Out.Write(fibonacci[i]);
        Console.Out.Write(" ");
      }
      Console.Out.WriteLine();
    }
  }
}
