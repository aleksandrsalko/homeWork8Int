/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int Input(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}

int x = Input("Введите x:");
int y = Input("Введите y:");
int z = Input("Введите z:");

int[,,] array3D = new int[x, y, z];

FillArrayRandomNumbers(array3D);
PrintArray(array3D);


void FillArrayRandomNumbers(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(-100, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(-100, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i,j,k] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k= 0; k < array.GetLength(2); k++)
      {
        Console.Write(array[i,j,k] + " ");
      } 
     Console.WriteLine("");
    }
  Console.WriteLine();
  }
}