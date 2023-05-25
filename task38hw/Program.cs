// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRnd(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble()*(max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double FindMinNumber(double[] arr)
{
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < minNum) minNum = arr[i]; 
    }
    return minNum;
}

double FindMaxNumber(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > maxNum) maxNum = arr[i]; 
    }
    return maxNum;
}

double DifferenceMaxMin(double maxNum, double minNum)
{
    double differenceMaxMin = maxNum - minNum;
    double sum = Math.Round(differenceMaxMin, 1);
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double min = 0;
double max = 100;

double[] array = CreateArrayRnd(size, min, max);
Console.Write("[");
PrintArrayDouble(array, ",");
Console.Write("]");

double maxNumber = FindMaxNumber(array);
double minNumber = FindMinNumber(array);

double difference = DifferenceMaxMin(maxNumber, minNumber);
Console.Write($" -> ");
Console.Write($"{difference}");