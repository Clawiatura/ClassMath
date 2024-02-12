Console.WriteLine("Введите радиус окружности: ");
double R = double.Parse(Console.ReadLine());
double Long = 2 * Math.PI * R;
double S = Math.PI * R * R;
Console.WriteLine($" Длина окружности - {Long:F2} Площадь окружности - {S:F2} ");
