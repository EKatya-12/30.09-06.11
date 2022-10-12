//Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int oldV = number;
int newV = 0;
while (number > 0)
{
    int dig = number % 10;
    newV = newV * 10 + dig;
    number = number / 10;
}
if (newV == oldV)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
Console.ReadKey();