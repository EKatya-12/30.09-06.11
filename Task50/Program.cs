// Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите две позиции");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
           else Console.Write($"{matrix[i, j], 4}"); 
        }
        Console.WriteLine("|");
    }
}

// bool NumberInMatrix(int[,] matrix)
// {
//     return (number1 <= matrix.GetLength(0) && number2 <= matrix.GetLength(1));
// }


if(number1 > matrix.GetLength(0) || number2 > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента в массиве нет");
}
else
{
    Console.WriteLine("Элемент: " + matrix[number1-1,number2-1]);
}

int[,] array2D = CreateMatrixRndInt (3, 4, 1, 10);
PrintMatrix(array2D);


