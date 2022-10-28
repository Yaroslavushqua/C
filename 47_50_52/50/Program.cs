/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет
*/
Console.WriteLine("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [3,4];
fillArray(array);

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента на {n} строке и {m} столбце равно {array [n-1,m-1]}");

}

printArray(array);

void fillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j  < arr.GetLength(1); j++)
        {
            arr [i,j] = new Random ().Next(-100,100) / 10;
        }
    }
}

void printArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j  < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine("");
    }
}