// // Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший
// элемент массива.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}
void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}
void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); //Добавил чтобы вывод был красивее
}
int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}
int[,] FindPositionSmallElement(int[,] arr, int[,] position)
{
  int temp = arr[0, 0];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] <= temp)
      {
        position[0, 0] = i;
        position[0, 1] = j;
        temp = arr[i, j];
      }
    }
  }
  return position;
}
void DeleteLines(int[,] arr, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
  int k = 0, l = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
      {
        arrayWithoutLines[k, l] = arr[i, j];
        l++;
      }
    }
    l = 0;
    if (positionSmallElement[0, 0] != i)
    {
      k++;
    }
  }
}
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintArray(array);
int[,] positionSmallElement = new int[1, 2];
positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
DeleteLines(array, positionSmallElement, arrayWithoutLines);
PrintArray(arrayWithoutLines);