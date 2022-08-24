// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int SizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[SizeArray];
RandomNumbers(numbers);
int Sum = 0;
for (int i = 0; i < numbers.Length; i+=2)
{
    Sum = Sum + numbers[i];
}
void RandomNumbers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = new Random().Next(1,10);
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

Console.WriteLine("Массив ");
PrintArray(numbers);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {Sum}");