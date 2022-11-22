// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
                        
int[,] array = GetArray(rows, columns);          
PrintArray(array);                                                   

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    int number = 1;
    int startPos = 0;
    if ((m % 2 != 0 && n % 2 !=0) && m != n)
    {
        while(startPos < result.GetLength(0)/2 && startPos < result.GetLength(1)/2)
        {
            for (int j = startPos; j < n-1; j++)
            {
                result[startPos, j] = number;
                number++;
            }
            for (int i = startPos; i < m-1; i++)
            {
                result[i, n-1] = number;
                number++;
            }
            for (int j = n-1; j > startPos; j--)
            {
                result[m-1, j] = number;
                number++;
            }
            for (int i = m-1; i > startPos; i--)
            {
                result[i, startPos] = number;
                number++;
            }
            startPos = startPos + 1;
            m = m - 1;
            n = n - 1;
        }
        if (result.GetLength(0) < result.GetLength(1))
        {
            int size = result.GetLength(1) - result.GetLength(0);
            for (int i = startPos; i < startPos + size + 1; i++)
            {
                result[result.GetLength(0) / 2, i] = number;
                number++;
            }
        }

        else
        {
            int size = result.GetLength(0) - result.GetLength(1);
            for (int i = startPos; i < startPos + size + 1; i++)
            {
                result[i, result.GetLength(1) / 2] = number;
                number++;
            }
        }
        return result;
    }
    else
    {
        while(startPos <= result.GetLength(0)/2 && startPos <= result.GetLength(1)/2)
        {
            for (int j = startPos; j < n-1; j++)
            {
                result[startPos, j] = number;
                number++;
            }
            for (int i = startPos; i < m-1; i++)
            {
                result[i, n-1] = number;
                number++;
            }
            for (int j = n-1; j > startPos; j--)
            {
                result[m-1, j] = number;
                number++;
            }
            for (int i = m-1; i > startPos; i--)
            {
                result[i, startPos] = number;
                number++;
            }
            startPos = startPos + 1;
            m = m - 1;
            n = n - 1;
        }
        if (result.GetLength(0) % 2 != 0 && result.GetLength(1) % 2 != 0)
        {
            result[result.GetLength(0) / 2, result.GetLength(1) / 2] = number;
        }
        return result;
    }        
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j], 3} ");
        }
        Console.WriteLine();
    }
}