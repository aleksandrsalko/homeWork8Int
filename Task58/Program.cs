/*Задача 58: Задайте две матрицы. 
  Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] matrixA = new int[4, 4];

FillArrayRandomNumbers(matrixA);
PrintArray(matrixA);

int[,] matrixB = new int[4, 4];

FillArrayRandomNumbers(matrixB);
PrintArray(matrixB);

int[,] matrixC = new int[4, 4];
ProductMatrix(matrixC);
PrintArray(matrixC);

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

void ProductMatrix(int[,] matrixC)
{
  for (int i = 0; i < matrixC.GetLength(0); i++)
  {
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixA.GetLength(1); k++)
      {
        sum += matrixA[i,k] * matrixB[k,j];
      }
      matrixC[i,j] = sum;
    }
  }
}
