// Написать рекурсивный метод, проверяющий равенство
//сумм цифр одного числа и второго числа
int a=125;
int b=8;
sum(a);
sum(b);
if (sum(a)==sum(b))
Console.WriteLine("Суммы цифр равны");
else
Console.WriteLine("Суммы цифр не равны");
int sum (int n)
{
    if (n/10!=0)
        return n%10+sum(n/10);
    else
        return n%10;
}