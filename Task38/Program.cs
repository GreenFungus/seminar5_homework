// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

double GetMaxValue(double[] arr)
{
    double maxValue = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxValue) maxValue = arr[i];
    }
    return maxValue;
}

double GetMinValue(double[] arr)
{
    double minValue = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minValue) minValue = arr[i];
    }
    return minValue;
}


double[] array = CreateArrayRndDouble(5, -10.0, 10.0);
Console.Write("[");
PrintArray(array);
Console.Write("]");

double max = GetMaxValue(array);
double min = GetMinValue(array);
double diff = max - min;

Console.Write($" => {max} - {min} = {diff}");
