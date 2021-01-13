using System;

class MainClass {
  public static void Main (string[] args) {
    double b, h, a;
    Console.WriteLine("Digite a base do triângulo");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura do triângulo");
    h = double.Parse(Console.ReadLine());
    a = b * h / 2;
    Console.WriteLine($"Área = {a:0.0}");
  }
}
