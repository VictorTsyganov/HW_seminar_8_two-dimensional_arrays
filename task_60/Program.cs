// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Введите количество строк массива (max 4): ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива (max 4): ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество листов массива (max 4): ");
int pages = int.Parse(Console.ReadLine()!);
                        
int[,,] array = GetArray(rows, columns, pages, 10, 90);
Console.WriteLine(); 
Console.WriteLine("Исходно созданный массив.");         
PrintArray(array);                                                   
Console.WriteLine();
Console.WriteLine("Построчный вывод массива.");
PrintArrayLineByLine(array);


int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = Enumerable.Range(minValue, maxValue).ToArray();
    for (int i = 0; i < n; i++)
    {
        int j = random.Next(maxValue);
        int x = array[i];
        array[i] = array[j];
        array[j] = x;
    }
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                result[i, j, l] = array[array.Length-1];
                Array.Resize(ref array, array.Length - 1);
            } 
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int l = 0; l < inArray.GetLength(2); l++)
            {
                Console.Write($"{inArray[i, j, l]} ({i}, {j}, {l}) ");
            }
            Console.WriteLine(); 
        }
    }
}

void PrintArrayLineByLine(int[,,] inArray)
{
    for (int l = 0; l < inArray.GetLength(2); l++)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j, l]} ({i}, {j}, {l}) ");
            }
            Console.WriteLine(); 
        }
    }
}