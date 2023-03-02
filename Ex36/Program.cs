// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

using static Shares;
int n = Size("Enter array elements number ");
int [] Print = ArrayRandom (n);
int summ = sum(Print);
Console.WriteLine();
Console.WriteLine(summ);

