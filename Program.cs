/* ДОМАШНЕЕ ЗАДАНИЕ*/

/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
/*
int[,] CreateRandom2dArray(int row, int colum, int minValue, int maxValue)
{
    int[,] array = new int[row, colum];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < colum; j++)
        {
             array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
     return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");       
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void SortElementRow(int[,] array)
{
    for(int row = 0; row < array.GetLength(0); row++)
        for (int repeat = 0; repeat < array.GetLength(1); repeat++)
            for(int colum = 0; colum < array.GetLength(1) - 1; colum++)
                if(array[row, colum] < array[row, colum + 1])
                {
                    int temp = array[row, colum];
                    array[row, colum] = array[row, colum + 1];
                    array[row, colum + 1] = temp;
                }            
}
   
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());  
int[,] myArray = CreateRandom2dArray(row, colum, minValue, maxValue);
Show2dArray(myArray);
SortElementRow(myArray);
Show2dArray(myArray);
*/


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.*/

int[,] CreateRandom2dArray(int row, int colum, int minValue, int maxValue)
{
    int[,] array = new int[row, colum];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < colum; j++)
        {
             array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
     return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");       
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumRow(int[,] array, int maxValue)
{
    int minSumRowIndex = 0;
    int minSumRow = maxValue * array.GetLength(1);
    for(int row = 0; row < array.GetLength(0); row++)
    {    
        int sumRow = 0;
        for(int colum = 0; colum < array.GetLength(1); colum++)     
            sumRow = sumRow + array[row,colum]; 
        if(sumRow < minSumRow) 
        {
            minSumRow = sumRow;
            minSumRowIndex = row + 1;       
        }     
    }    
    return minSumRowIndex;
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int minValue  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());  
int[,] myArray = CreateRandom2dArray(row, colum, minValue, maxValue);
Show2dArray(myArray);
int resulte = MinSumRow(myArray, maxValue);
Console.WriteLine("Строка с наименьшей суммой элементов: " + resulte);


