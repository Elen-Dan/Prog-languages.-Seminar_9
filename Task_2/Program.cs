/*
Задача 2**. 
Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Указание:
При заполнении массива использовать циклы.
*/

Console.Clear();
int[,] Matrix = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
    Matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

for (int m = 0; m < Matrix.GetLength(0); m++)
  {
    for (int n = 0; n < Matrix.GetLength(1); n++)
    {
      if (Matrix[m,n] / 10 <= 0)
      Console.Write($" {Matrix[m,n]} ");

      else Console.Write($"{Matrix[m,n]} ");
    }
    Console.WriteLine();
  }