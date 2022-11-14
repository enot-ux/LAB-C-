using System;
class HelloWorld {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    for (int i = 0; i < n; ++i) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = n - 1; i >= 0; i -= 1) {
        Console.WriteLine(arr[i]);
    }
  }
}