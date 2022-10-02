// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = GetArray(10, 100, 1000);
int chet = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) chet++;
}
Console.WriteLine($"[{String.Join(", ", arr)}] -> {chet}");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] arr = GetArray(10, -100, 100);
// int sumNechet = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 != 0) sumNechet += arr[i];
// }
// Console.WriteLine($"[{String.Join(", ", arr)}] -> {sumNechet}");
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// double[] arr = GetDoubleArray(10, -5, 5);
// double min = arr[0];
// double max = arr[0];
// for (int i = 1; i < arr.Length; i++)
// {
//     if (arr[i] < min) min = arr[i];
//     if (arr[i] > max) max = arr[i];
// }
// double res = Math.Round(max - min, 2);
// Console.WriteLine($"[{String.Join(" ", arr)}] -> {res}");

// double[] GetDoubleArray(int size, int minValue, int maxValue)
// {
//     double[] res = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         double x = new Random().NextDouble();
//         res[i] = Math.Round(x * (maxValue - minValue) + minValue, 2);
//     }
//     return res;
// }