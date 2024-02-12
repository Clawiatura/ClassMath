//Random random = new Random();
//double  one = random.Next(0, 5);
//Console.Write("Введите число от 0 - 5:");
//double two = double.Parse(Console.ReadLine());
// if (two == one) Console.WriteLine("Победа");
// else Console.WriteLine("Поражение");



Console.WriteLine("Введите номер месяца");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите температуру");
double temp = double.Parse(Console.ReadLine()); 
switch (number)
{
    case 1:case 2: case 12:
        {
         if (temp > 0)
          Console.WriteLine(" дождливая зима");
  }; break;
  case 3: case 4: case 5: Console.WriteLine("Весна"); break;
  case 6: case 7: case 8: Console.WriteLine("Лето"); break;
  case 9: case 10: case 11: Console.WriteLine("Осень"); break;
            default: Console.WriteLine("Такого месяца нет"); break;

}

