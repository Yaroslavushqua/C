/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("Введите a число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b число: ");
int b = int.Parse(Console.ReadLine());
naturalStpn(a, b);

void naturalStpn(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    Console.Write($"Результат возведения числа a: {a} в натуральную степерь числа b: {b} будет равен: {res}" );
}
