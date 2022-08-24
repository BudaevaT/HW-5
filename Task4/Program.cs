// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int N=123;
int[] numbers = new int[N];
RandomNumbers(numbers);


int count=0;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]>10 && numbers[i]<99)
count++;
}

void RandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(0,200);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Массив");
PrintArray(numbers);
Console.WriteLine($"Количество чисел в отрезке от [10-99] = {count}");