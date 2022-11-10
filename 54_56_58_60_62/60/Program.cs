/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int deep1 = InputInt("Введите размероность 1: ");
int deep2 = InputInt("Введите размероность 2: ");
int deep3 = InputInt("Введите размероность 3: ");
int count = 89;

if (deep1 * deep2 * deep3 > count)
{
    Console.Write("Массив слишком большой");
    return;
}

int [,,] res = newArr (deep1, deep2, deep3);

for (int i = 0; i < res.GetLength(0); i++)
{
    for(int j=0; j < res.GetLength(1); j++)
    {
        for (int k = 0; k < res.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {res[i,j,k]}");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,,] newArr(int size1, int size2, int size3)
{
    int[,,] array = new int [size1, size2, size3];
    int [] values = new int [count];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
    values[i] = num 
    ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = values[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}