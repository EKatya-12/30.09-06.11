//  Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int newV = 0;
int sum = 0;
while (number > 0)
{
    int dig = number % 10;//% берёт остаток от деления
    sum += dig;
    newV = newV * 10 + dig;
    number = number / 10;
}
Console.WriteLine("Сумма чисел " + sum);
Console.ReadKey();