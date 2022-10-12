// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,,] arr, int minValue, int maxValue)
{
  int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(minValue, maxValue);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(minValue, maxValue);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arr.GetLength(0); x++)
  {
    for (int y = 0; y < arr.GetLength(1); y++)
    {
      for (int z = 0; z < arr.GetLength(2); z++)
      {
        arr[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void PrintArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"x({i}) y({j}) ");
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write( $"z({k})={arr[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
int[,,] InitializateArray(int x, int y, int z)
{
    return new int[x, y, z];
}
int x = GetNumberFromConsole("Введите размерность массива x");
int y = GetNumberFromConsole("Введите размерность массива y");
int z = GetNumberFromConsole("Введите размерность массива z");
int[,,] array = InitializateArray(x,y,z);
int minValue = 10;
int maxValue = 100;
FillArray(array, minValue, maxValue);
PrintArray(array);