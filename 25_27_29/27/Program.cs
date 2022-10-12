/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = nCount(number);
sumN(number, count);

int nCount(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void sumN(int n, int count)
{
    int sum = 0;
    for (int i = 1; i <= count; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма всех цифр в числе {number} равна: {sum}");
}