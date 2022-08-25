// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива");
int SizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[SizeArray];
RandomNumbers(numbers);
Console.WriteLine("Массив ");
PrintArray(numbers);
Console.WriteLine(String.Join(" ", ResultNumbers(numbers)));

int[] ResultNumbers(int[] numbers)
{
    int size = numbers.Length/2;
    if(numbers.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        result [i] = numbers[i] * numbers[numbers.Length - 1 - i];
    }
    if(numbers.Length % 2 == 1) result[size-1] = numbers[numbers.Length/2];
    return result;
}

void RandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = new Random().Next(1,10);
        }
}void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
        {
            Console.Write(numbers[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

