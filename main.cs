using System;

class Program {
  public static void Main (string[] args) {
    const double x = 200;

    Console.WriteLine("Enter number of hours");
    var y = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter of Miles");
    var z = int.Parse(Console.ReadLine());

    Console.WriteLine("With a base rate of ${0}, $150 per every hour, and $2 per every mile, the moving fee is ${3} for {1} hours and {2} miles", x, y, z, (x + (y * 150) + (z * 2)));
  }
}