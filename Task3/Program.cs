// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер массива");
int SizeArray = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[SizeArray];
RandomNumbers(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    else if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
void RandomNumbers(double[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
        {
            numbers[j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
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
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");