/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

using System;
using static System.Console;

Clear();
Write("введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

WriteLine($"Среднее арифметическое каждого столбца: {GetArithmeticalMean(array):f1}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        {        
            for (int j = 0; j < n; j++)
            {
                result [i, j] = new Random().Next(minValue, maxValue + 1);
            }   
        }
        return result;
}

double GetArithmeticalMean(int[,] array)
{    
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[j, i];
    }
    sum = sum / columns;
}
    return sum;
    Write(sum + "; ");
}
WriteLine(); 

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }   
            WriteLine(); 
    }
}

