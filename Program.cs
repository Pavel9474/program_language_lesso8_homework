// Написать рекурсивный метод, рассчитывающий
//количество делителей числа
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void division (int n, int i = 1)
    {
        if (n % i == 0) 
            Console.Write(i + " ");
        if (i == n) return;
        division(n, ++i);
    }
    int n = GetNumberFromConsole("Введите число");
    division(n);