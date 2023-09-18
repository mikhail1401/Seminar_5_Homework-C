Console.WriteLine("Task 34");
// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[12];

int countOfEven = 0;

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + ", ");

    if(array[i]%2==0) countOfEven++;
}

Console.WriteLine($"\nThere are {countOfEven} even numbers in the array.");

Console.WriteLine("\nTask 36");
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, -89, 6] -> 0

int[] array2 = new int[11];

int sumOfOddInd = 0;

for (int i=0; i<array2.Length; i++)
{
    array2[i] = new Random().Next(-100, 101);
    Console.Write(array2[i] + ", ");

    if(i%2!=0) sumOfOddInd=sumOfOddInd+array2[i];
}

Console.WriteLine($"\nThe sum of elements on odd positions is {sumOfOddInd}");


Console.WriteLine("\nTask 38");
// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76
// NB: вещественные числа, это плавающие числа типа double.

double[] array3 = new double[9];

double maxElement = double.MinValue;
double minElement = double.MaxValue;

for (int i=0; i<array3.Length; i++)
{
    // array3[i] = (new Random().NextDouble() * 100);
    array3[i] = (new Random().NextDouble() + new Random().Next(-100, 101));
    Console.Write(array3[i] + "; ");

    if (array3[i] > maxElement) maxElement = array3[i];
    if (array3[i] < minElement) minElement = array3[i];
}

double result = maxElement - minElement;

Console.WriteLine($"\nThe max element in the array: {maxElement}, and the min: {minElement}.");
Console.WriteLine($"The difference between them equals {result}.");
