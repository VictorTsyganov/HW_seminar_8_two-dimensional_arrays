// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
                        
int[,] firstArray = GetArray(rows, columns, 0, 10);          
PrintTwoDimensionalArray(firstArray);                                                   
Console.WriteLine();

int[,] secondArray = GetArray(columns, rows, 0, 10);          
PrintTwoDimensionalArray(secondArray);                                                   
Console.WriteLine();

int[,] newArray = MultiplicationTwoArray(firstArray, secondArray);
PrintTwoDimensionalArray(newArray);                                                   
Console.WriteLine();

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

int[,] MultiplicationTwoArray(int[,] inArrayOne, int[,] inArrayTwo)
{
    int[,] result = new int[inArrayOne.GetLength(0), inArrayTwo.GetLength(1)];
    for (int i = 0; i < inArrayOne.GetLength(0); i++)
    {
        int count = 0;
        int index = 0;
        while (index < inArrayTwo.GetLength(1))
        {    
            for (int j = 0; j < inArrayOne.GetLength(1); j++)
            {
                count = count + inArrayOne[i, j] * inArrayTwo[j, index];
            }
            result[i, index] = count;
            index++;
            count = 0;
        }
    }
    return result;
}

