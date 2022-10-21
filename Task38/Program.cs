// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// var rnd = new Random();
// double max = 10.20, min = 3.14;
// int count = rnd.Next(3,10);//задаёт кол-во элементов
// double[] array = new double[count];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(rnd.NextDouble() * (max - min) + min,2);//заполняет      
//     Console.WriteLine(array[i]);
// }

// double maxim = array[0], minim = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (maxim < array[i])
//         maxim = array[i];
//     if (minim > array[i])
//         minim = array[i];
// }
// Console.WriteLine("Максимальное " + maxim);
// Console.WriteLine("Минимальное " + minim);
// double fin = Math.Round(maxim - minim,2);
// Console.WriteLine("Разница чисел: " + fin);


double[] CreateArrayRndDouble(int size, int min, int max)
{
    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);

    }
    return array;
}


void PrintArrayDouble (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void GetSumMaxMinElem(double[] array)
{
    double maxim = array[0];
    double minim = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (maxim < array[i]) maxim = array[i];
        if (minim > array[i]) minim = array[i];
    }
    Console.WriteLine($"Максимальный элемент = {maxim}");
    Console.WriteLine($"Минимальный элемент = {minim}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами = {maxim - minim}");
}
double[] arr = CreateArrayRndDouble(5, 1, 100);
PrintArrayDouble(arr);
GetSumMaxMinElem(arr);
