/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

using System;
using static System.Console;

Clear();
Write("введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
Write("введите число: ");
int number = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();

if (FindElement(array, number))
{
    WriteLine($"Ваше число: {number} присутствует в заданном массиве.");
}
else
{
     WriteLine("нет");
}
bool FindElement(int[,] array, int el)
{
    foreach (int item in array)
    {
        if (el == item) return true;
    }
    return false;
}

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }   
        Console.WriteLine(); 
    }
}

