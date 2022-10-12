// Написать рекурсивный метод, рассчитывающий
//количество делителей числа
int a=6;
division(a);
void division (int n, int i = 1)
    {
        if (n % i == 0) 
            Console.Write(i + " ");
        if (i == n) return;
        division(n, ++i);
    }