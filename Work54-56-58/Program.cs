void Zadacha54()
{
//Задача 54. Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Задача 54.");
Console.WriteLine();

    Console.WriteLine("Введите ширину массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите длину массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Двумерный массив:");

    int[,]numbers=new int[rows,columns];
    FillArray(numbers,-9,9);
    PrintArray(numbers);
    Console.WriteLine();
    Console.WriteLine("Массив, выстроенный по убыванию элементов в строке:");
    Console.WriteLine();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int x = 0; x < numbers.GetLength(1); x++)
        {
            for (int y = 0; y < numbers.GetLength(1)-1; y++)
            {
                if (numbers[i, y] < numbers[i, y + 1])
                {
                    int temp = numbers[i, y + 1];
                    numbers[i, y + 1] = numbers[i, y];
                    numbers[i, y] = temp;
                }
            }
        }
    }
    PrintArray(numbers);

}

void FillArray(int[,] matr, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();


    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++) 
            {
                matr[i,j]=rand.Next(minValue,maxValue);
            }
    Console.WriteLine();       
    } 
}

void PrintArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++) 
            {
            Console.Write($" {matr[i,j]}\t");
            }
    Console.WriteLine();       
    } 
}

void Zadacha56()
{
//Задача 56. Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Задача 56.");
Console.WriteLine();

    Console.WriteLine("Введите ширину массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите длину массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Двумерный массив:");

    int[,]numbers=new int[rows,columns];
    FillArray(numbers,-9,9);
    PrintArray(numbers);
    
    int sum =0;
    int min = 0;
    int line=0;

    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        line += numbers[0, i];
    }
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++) sum += numbers[i, j];
        if (sum < line)
        {
            line = sum;
            min = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Ответ: минимальная сумма элементов в строке {min + 1}.");
    
}

void Zadacha58()
{
//Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
Console.WriteLine();
Console.WriteLine("Задача 58.");
Console.WriteLine();

int n = 4;
int[,] numbers = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= numbers.GetLength(0) * numbers.GetLength(1))
{
    numbers[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < numbers.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= numbers.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > numbers.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintSpiralArray(numbers);

void PrintSpiralArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0) Console.Write($" {array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


}

Zadacha54();
Zadacha56();
Zadacha58();
