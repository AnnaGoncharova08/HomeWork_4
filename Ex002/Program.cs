// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Zadacha27()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма цифр в числе {number} равна {FindSum(number)}");
}

int FindSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number%10;
        number = number/10;
    }
    return sum;
}
Zadacha27();