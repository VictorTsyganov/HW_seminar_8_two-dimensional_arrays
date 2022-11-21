// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
                        
int[,] array = GetArray(rows, columns, 0, 10);          
PrintTwoDimensionalArray(array);                                                   
Console.WriteLine();
int[] newArray = SumElenentsInRowArray(array);
PrintArray(newArray);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в сроке в матрице у строки: {FindMinIndex(newArray)}.");

void PrintArray(int[] arr)
{
    Console.WriteLine("Ниже показана сумма элементов каждой строки в матрице.");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintTwoDimensionalArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumElenentsInRowArray(int[,] inArray)
{
    int[] result = new int [inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            count = count + inArray[i, j];
        }
        result[i] = count;
    }
    return result;
}

int FindMinIndex (int[] collection)
{
    int minIndex = 0;
    int min = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
        if (min > collection[i])
        {
            min = collection[i];
            minIndex = i;
        }
    }
    return minIndex + 1;

}