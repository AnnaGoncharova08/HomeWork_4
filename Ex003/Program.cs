// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19] 
// 6, 1, -33 -> [1, 6, -33]

void Zadacha29()
{
    int size = 8;
    int[] array = new int [size];
    array = FillArray(size);
    Console.WriteLine("Вывод массива");
    PrintArray(array);
    Sort(array);
    Console.WriteLine("Вывод отсортированного по модулю массива");
    PrintArray(array);
}

int[] FillArray(int size)
{
    int[] fillArray = new int [size];
    Random random = new Random();
   for (int i = 0; i < fillArray.Length; i++)
   {
        fillArray[i] = random.Next(-100, 100);
   }
    return fillArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
   {
        Console.Write(array[i] + " ");
   }
   Console.WriteLine();
}
void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minPosition]))
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
Zadacha29();