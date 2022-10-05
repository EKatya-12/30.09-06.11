// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] number = new int [num];
// number [0] = 1;
// for (int i = 1; int < number.Length; i++)
// {
//     number [i] = number [i-1]+1;
//     if(number [i] % 2 == 0)
//     {
//         Console.WriteLine($"Все целые числа {number [i]}")
//     }
// }


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Все четные числа в промежутке от {1} до {number}:");
for (int counter = 2; counter <= number; counter++)
if(counter % 2 == 0)
{
    Console.Write($"{counter} ");
    counter++;
}