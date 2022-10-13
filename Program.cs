// Написать рекурсивный метод, проверяющий равенство
//сумм цифр одного числа и второго числа
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int sum (int n)
{
    if (n/10!=0)
        return n%10+sum(n/10);
    else
        return n%10;
}
int a = GetNumberFromConsole("Введите число b");
int b = GetNumberFromConsole("Введите число a");
sum(a);
sum(b);
if (sum(a)==sum(b))
Console.WriteLine("Суммы цифр равны");
else
Console.WriteLine("Суммы цифр не равны");