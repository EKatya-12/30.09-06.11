// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите целое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// void NaturalNumbers(int num1, int num2)
// {

//     if (num1 == num2) Console.Write($"{num1} ");
//     if (num1 < num2)
//     {
//         Console.Write($"{num1} ");
//         NaturalNumbers(num1 + 1, num2);
//     }
//     if (num1 > num2)
//     {
//         Console.Write($"{num1} ");
//         NaturalNumbers(num1 - 1, num2);
//     }

// }

// NaturalNumbers(num1, num2);

Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int summ = 0;
void NaturalNumbers(int num1, int num2)
{

    if (num1 == num2) Console.Write($"{summ += num1}");
    if (num1 < num2)
    {
        summ += num1;
        NaturalNumbers(num1 + 1, num2);
    }
    if (num1 > num2)
    {
        summ += num1;
        NaturalNumbers(num1 - 1, num2);
    }

}
NaturalNumbers(num1, num2);
