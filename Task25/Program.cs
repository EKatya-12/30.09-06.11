// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите числа А и В: ");
int number = int.Parse(Console.ReadLine());
int step = int.Parse(Console.ReadLine());
int newV = number;
for (int i = 0; i < step-1; i++)
{
    newV = newV * number;
}
Console.WriteLine("Число: " + newV);
Console.ReadKey();
