namespace FibonacciSeries {
  public class Fibonacci {
    public static int[] CreateSeries(int count) {
      int[] fibonacci = new int[count];
      fibonacci[0] = 0;
      fibonacci[1] = 1;

      for (int i = 2; i < count; i++) {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
      }
      return fibonacci;
    }
  }
}
