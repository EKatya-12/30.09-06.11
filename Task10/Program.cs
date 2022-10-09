// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastDigit = number / 10 % 10;
    Console.Write($"Последняя цифра числа => {lastDigit}");
}
else Console.Write("Число не трехзначное!");

// Console.WriteLine("Число" + number.ToString()[1]);
