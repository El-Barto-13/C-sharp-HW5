


//Home Work 5

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateRandomArray(int size)
{
 int[] array = new int[size];
 for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
return array;
}
int CountEvenNumberInAnArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) count++;
    }
return count;
}
void DisplayArrayOnScreen(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array = CreateRandomArray(size);
DisplayArrayOnScreen(array);
Console.WriteLine();
Console.WriteLine(CountEvenNumberInAnArray(array));
*/



//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число для рандома: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число для рандома: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
return array;
}
int SumOddNumber(int[] array)
{
    int sum_of_array = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum_of_array = sum_of_array + array[i];
    }
return sum_of_array;
}
void DisplayArrayOnScreen(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array = CreateRandomArray(size, minValue, maxValue);
DisplayArrayOnScreen(array);
Console.WriteLine(SumOddNumber(array));
*/



//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число для рандома: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число для рандома: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().Next(minValue, maxValue+1) + new Random().NextDouble(), 2);
    }
return array;
}
void DisplayArrayOnScreen(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
double FindDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
                    max = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] array = CreateRandomArray(size, minValue, maxValue);
DisplayArrayOnScreen(array);
Console.WriteLine(FindDifference(array));
*/