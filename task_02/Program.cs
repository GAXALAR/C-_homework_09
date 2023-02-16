Console.WriteLine ("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int x = 0;

if (m > n)
{
    x = m;
    m = n;
    n = x;

}


for (int i = m; i <= n; i++)
    
    {
            sum = sum + i;
    }
    

Console.WriteLine ($"Сумма натуральных элементов в промежутке от {m} до {n} равна: {sum}");