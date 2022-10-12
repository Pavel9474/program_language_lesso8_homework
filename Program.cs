// Напишите программу, которая заполнит спирально массив 4 на 
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillSpiralArray(int[,] arr)
{
int temp = 1;
int i = 0;
int j = 0;

while (temp <= arr.GetLength(0) * arr.GetLength(1))
{
  arr[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arr.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arr.GetLength(1) - 1)
    j--;
  else
    i--;
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
int m = 5;
int[,] array = InitializateArray(m,m);
FillSpiralArray(array);
PrintArray(array);