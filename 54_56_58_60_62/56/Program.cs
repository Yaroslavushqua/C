/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("Введите размер массива: ");
int A = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [A, A];
fillArrNum (array);
printArr (array);
int min = Int32.MaxValue;
int index = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    if (sum < min)
    {
        min = sum;
        index++;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов под номером: " + (index) + ", с суммой элементов равной: " + (min));

void fillArrNum(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,10);
        }
    }
}

void printArr (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine("");
    }
}
