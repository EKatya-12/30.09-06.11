// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа: ");
int [] number = new int [3];
for (int i = 0; i < number.Length; i++)
{
    number [i] = Convert.ToInt32(Console.ReadLine());
}
int max = number [0];
for (int i = 0; i < number.Length; i++)
{
    if (max < number [i])
    {
        max = number[i];
    }
}
Console.WriteLine($"Максимальное число {max}");
