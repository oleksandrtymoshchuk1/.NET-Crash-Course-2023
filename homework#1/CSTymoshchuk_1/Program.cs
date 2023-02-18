using System;
using System.Xml.Linq;

//ЗАВДАННЯ 1
Console.Write("введіть поточний рік в форматі YYYY: ");
int year = Convert.ToInt32(Console.ReadLine());
Console.Write("введіть поточний місяць в форматі MM: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.Write("введіть поточну дату в форматі DD: ");
int day= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{day}/{month}/{year}");

//ЗАВДАННЯ 2
Console.Write("Введіть сторону a прямокутника в см: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть сторону b прямокутника в см: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Площа прямокутника = {a*b} см");

//ЗАВДАННЯ 3
Console.Write("Введіть радіус круга в см: ");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Площа круга = {r * r * 3.14} см");

//ЗАВДАННЯ 4
Console.Write("введіть кількість секунд: ");
int sec = Convert.ToInt32(Console.ReadLine());
int hour = sec / 3600;
int hour1 = sec % 360;
int minute = hour1 / 60;
int sec1 = (hour1% 60);
Console.WriteLine($"{hour} год.{minute}хв.{sec1}с.");



/*Console.Write("Введіть номер поточного місяця в форматі MM: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());*/