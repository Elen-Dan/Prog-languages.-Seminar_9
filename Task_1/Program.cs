/*
Задача 1: 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон произвольных чисел: ");
int range = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Array[i, j] = new Random().Next(1, range);
        Console.Write($"{Array[i, j]} "); //вывод значений массива для примера
    }
    Console.WriteLine();
}
Console.WriteLine("- - - - - - - - - - - - -");
Console.WriteLine("Отсортированный массив:");

ReOrderArray(Array);

for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      Console.Write(Array[i, j] + " ");
    }
    Console.WriteLine();
  }

void ReOrderArray(int[,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      for (int k = 0; k < Array.GetLength(1) - 1; k++)
      {
        if (Array[i, k] < Array[i, k + 1])
        {
          int temp = Array[i, k + 1];
          Array[i, k + 1] = Array[i, k];
          Array[i, k] = temp;
        }
      }
    }
  }
}