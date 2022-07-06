/*Задача 56: Задайте прямоугольный двумерный массив. 
  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int[,] matrix = new int[3,4];
int indexMin = 0;
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
MinSumLine(indexMin);

void FillArrayRandomNumbers(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix [i,j] = Convert.ToInt32(new Random().Next(0, 5));
    }
  }
}

void PrintArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + " ");
    }
  Console.WriteLine("");
  }
Console.WriteLine();
}

void MinSumLine(int minSum)
{
  minSum = int.MaxValue;
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int sum = 0;
      sum += matrix[i, j];
      if (sum < minSum)
      {
        minSum = sum;
        indexMin = i;
      }
    }
  }

  Console.WriteLine("Строка с минимальной суммой элементов");
    for(int j = 0;j < matrix.GetLength(1);j++)
    {
      Console.Write(matrix[indexMin, j]);
      Console.Write(" ");
    }
  Console.WriteLine();
}

