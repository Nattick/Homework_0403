// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

using static Shares;

int n = Size("ВEnter array elements number: ");
int[] Print = ArrayRandom(n);
int max = maxElement(Print);
int min = minElement(Print);
Console.WriteLine("Max/Min differrence = " + (max - min));