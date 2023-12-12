using System;

class Program {
  public static void Main (string[] args) {
    const double x = 200;
    const double y = 150;
    const double z = 2;
    
    Console.WriteLine("Enter number of hours");
    var a = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter of Miles");
    var b = double.Parse(Console.ReadLine());

    Console.WriteLine("With a base rate of ${0}, ${1} per every hour, and ${2} per every mile, the moving fee is ${5} for {3} hours and {4} miles", x, y, z, a, b, (x + (y * a) + (z * b)));
  }
}