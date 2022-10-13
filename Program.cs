// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
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
    Console.WriteLine(); 
}
int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}
int SumElemetsByLine(int[,] arr, int i)
{
  int sumLine = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumLine += arr[i,j];
  }
  return sumLine;
}
void MinimalSumElemetsLine(int [,] arr)
{
    int minSumLine = 0;
    int sumLine = SumElemetsByLine(arr, 0);
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tempSumLine = SumElemetsByLine(arr, i);
        if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumLine);
}
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintArray(array);
MinimalSumElemetsLine(array);