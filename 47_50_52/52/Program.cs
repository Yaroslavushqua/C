/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array =  new int [n,m];
fillArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double srArf = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        srArf = (srArf + array[i,j]);
    }
    srArf = srArf / n;
    Console.Write(srArf + "; ");
}
Console.WriteLine();
printArray (array);


void fillArray(int[,] arr)
{
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,10);
        }
    }
}

void printArray(int[,] arr)
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