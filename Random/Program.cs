//Console.WriteLine("Введите ваш возраст: ");
//byte age = byte.Parse(Console.ReadLine());
//Console.WriteLine("За кого будете болеть, если проиграете или будете не допущены?  \r\n 1 - Незнайка\r\n 2 -  Лунтик\r\n 3 - Карлсон\r\n 4 - Дядя Фёдор\r\n");
//byte number = byte.Parse(Console.ReadLine());
//switch (number)
//{
//    case 1: Console.WriteLine("А у тебя в животе арбуз вырастет!!!"); break;
//    case 2: Console.WriteLine("Я родился"); break;
//    case 3: Console.WriteLine("Я самый больной в мире человек, и мне больше ничего не надо.");break;
//    case 4: Console.WriteLine("Чтобы продать что-нибудь ненужное, нужно сначала купить что-нибудь ненужное, а у нас денег нет.");break;
//}
//if (age < 18) Console.WriteLine("Вы слишком молоды для участия в выборах");
//else if (age >18 && age <=35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
//     else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
//           else  Console.WriteLine("Ваш возраст слишком велик для участия в выборах.");

 
// На десятку 1.0

Random random = new Random();
int number = random.Next(1, 13);
switch (number)
{
    case 1: Console.WriteLine("Январь"); break;
    case 2: Console.WriteLine("Февраль"); break;
    case 3: Console.WriteLine("Март"); break;
    case 4: Console.WriteLine("Апрель"); break;
    case 5: Console.WriteLine("Май"); break;
    case 6: Console.WriteLine("Июнь"); break;
    case 7: Console.WriteLine("Июль"); break;
    case 8: Console.WriteLine("Август"); break;
    case 9: Console.WriteLine("Сентябрь"); break;
    case 10: Console.WriteLine("Октябрь"); break;
    case 11: Console.WriteLine("Ноябрь"); break;
    case 12: Console.WriteLine("Декабрь"); break;
} 
Console.WriteLine($"Угадайте сколько дней в этом месяце.");
int numbeUser = int.Parse(Console.ReadLine());
if(numbeUser == 31 && number ==1) Console.WriteLine("Вы победили");
else if(numbeUser == 31 && numbeUser == 2) Console.WriteLine("В этом месяце 29 дней");
     else if(numbeUser == 31 && numbeUser == 3) Console.WriteLine("Вы победили");
          else if (numbeUser == 31 && numbeUser == 4) Console.WriteLine("В этом месяце 30 дней");
               else if (numbeUser == 31 && numbeUser == 5) Console.WriteLine("Вы победили");
                    else if (numbeUser == 31 && numbeUser == 6) Console.WriteLine("В это месяце 30 дней");
                         else if (numbeUser == 31 && numbeUser == 7) Console.WriteLine("Вы победили");
                              else if (numbeUser == 31 && numbeUser == 8) Console.WriteLine("Вы победили");
                                   else if (numbeUser == 31 && numbeUser == 9) Console.WriteLine("В этом месяце 30 дней");
                                        else if (numbeUser == 31 && numbeUser == 10) Console.WriteLine("Вы победили");
                                             else if (numbeUser == 31 && numbeUser == 11) Console.WriteLine("В этом месяце 30 дней");
                                                  else if (numbeUser == 31 && numbeUser == 12) Console.WriteLine("Вы победили");

if (numbeUser == 30 && number == 1) Console.WriteLine("В этом месяце 31 день");
else if (numbeUser == 30 && number == 2) Console.WriteLine("В этом месяце 29 день");
     else if (numbeUser == 30 && number == 3) Console.WriteLine("В этом месяце 31 день");
          else if (numbeUser == 30 && number == 4) Console.WriteLine("Вы победили");
               else if (numbeUser == 30 && number == 5) Console.WriteLine("В этом месяце 31 день");
                    else if (numbeUser == 30 && number == 6) Console.WriteLine("Вы победили");
                         else if (numbeUser == 30 && number == 7) Console.WriteLine("В этом месяце 31 день");
                              else if (numbeUser == 30 && number == 8) Console.WriteLine("В этом месяце 31 день");
                                   else if (numbeUser == 30 && number == 9) Console.WriteLine("Вы победили");
                                        else if (numbeUser == 30 && number == 10) Console.WriteLine("В этом месяце 31 день");
                                             else if (numbeUser == 30 && number == 11) Console.WriteLine("Вы победили");
                                                  else if (numbeUser == 30 && number == 12) Console.WriteLine("В этом месяце 31 день");

if (numbeUser == 29 || numbeUser == 28 && number == 1) Console.WriteLine("В этом месяце 31 день");
else if (numbeUser == 29 || numbeUser == 28 && number == 2) Console.WriteLine("Вы победили");
     else if (numbeUser == 29 || numbeUser == 28 && number == 3) Console.WriteLine("В этом месяце 31 дней");
          else if (numbeUser == 29 || numbeUser == 28 && number == 4) Console.WriteLine("В этом месяце 30 дней");
               else if (numbeUser == 29 || numbeUser == 28 && number == 5) Console.WriteLine("В этом месяце 31 день");
                    else if (numbeUser == 29 || numbeUser == 28 && number == 6) Console.WriteLine("В этом месяце 30 дней");
                         else if (numbeUser == 29 || numbeUser == 28 && number == 7) Console.WriteLine("В этом месяце 31 день");
                              else if (numbeUser == 29 || numbeUser == 28 && number == 8) Console.WriteLine("В этом месяце 31 день");
                                   else if (numbeUser == 29 || numbeUser == 28 && number == 9) Console.WriteLine("В этом месяце 30 дней");
                                        else if (numbeUser == 29 || numbeUser == 28 && number == 10) Console.WriteLine("В этом месяце 31 день");
                                             else if (numbeUser == 29 || numbeUser == 28 && number == 11) Console.WriteLine("В этом месяце 30 дней");
                                                  else if (numbeUser == 29 || numbeUser == 28 && number == 12) Console.WriteLine("В этом месяце 31 день");




// 2.0

//Random random = new Random();
//int number = random.Next(1, 13);
//switch (number)
//{
//    case 1: Console.WriteLine("Январь"); break;
//    case 2: Console.WriteLine("Февраль"); break;
//    case 3: Console.WriteLine("Март"); break;
//    case 4: Console.WriteLine("Апрель"); break;
//    case 5: Console.WriteLine("Май"); break;
//    case 6: Console.WriteLine("Июнь"); break;
//    case 7: Console.WriteLine("Июль"); break;
//    case 8: Console.WriteLine("Август"); break;
//    case 9: Console.WriteLine("Сентябрь"); break;
//    case 10: Console.WriteLine("Октябрь"); break;
//    case 11: Console.WriteLine("Ноябрь"); break;
//    case 12: Console.WriteLine("Декабрь"); break;
//   default Console.WriteLine("Такого месяца нет"); break;
//}



