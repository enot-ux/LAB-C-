using System;
class HelloWorld {
  static void Main() {
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    int k = int.Parse(Console.ReadLine());
    int[,] arr = new int[n, m];
    for (int i = 0; i < Math.Min(n, m); ++i) {
        for (int j = 0; j < Math.Max(n, m); ++j) {
            arr[i, j] = int.Parse(Console.ReadLine());
        }
    }
    int ans = 0;
    for (int i = 0; i < Math.Min(n, m); ++i) {
        ans += arr[i, k];
    }
    Console.WriteLine(ans);
  }
}