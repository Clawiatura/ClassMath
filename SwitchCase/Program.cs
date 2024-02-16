Console.WriteLine("Введите операцию: ");
char oper = char.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
double one = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double too = double.Parse(Console.ReadLine());

switch (oper)
{
    case '+': Console.WriteLine($"{one} + {too} = {one + too}"); break;
    case '-':Console.WriteLine($"{one} - {too} = {one - too}"); break;
    case '*': Console.WriteLine($"{one} * {too} = {one * too}"); break;
    case '/': Console.WriteLine($"{one} / {too} = {one / too}"); break;
}