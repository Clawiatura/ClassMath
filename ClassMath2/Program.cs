Console.Write("Введите значение катета: ");
double katet = double.Parse(Console.ReadLine());
Console.Write("Введите значение гипотенузы: ");
double gipot  = double.Parse(Console.ReadLine());
double katettoo = Math.Sqrt(gipot * 2 - katet * 2);

Console.WriteLine($"Значение второго катета = {katettoo}");