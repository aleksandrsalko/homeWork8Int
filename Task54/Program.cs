﻿/*Задача 54: Задайте двумерный массив. 
  Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

int Input(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите m:");
int n = Input("Введите n:");

int [,] numbers = new int [m,n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
SortArray(numbers);
PrintArray(numbers);


void FillArrayRandomNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array [i,j] = Convert.ToInt32(new Random().Next(0, 20)) ;
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
  Console.WriteLine("");
  }
Console.WriteLine();
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++) 
      {
        for (int k = 0; k < array.GetLength(1) - j - 1; k++) 
        {
          if (array[i, k] > array[i, k + 1]) 
          {
            int temp = array[i, k];
            array[i, k] = array[i, k + 1];
            array[i, k + 1] = temp;
          }
        }
      }
    }
}

