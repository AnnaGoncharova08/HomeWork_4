// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Zadacha25()
{
    Console.WriteLine("Введите первое число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число {numberA} в степени {numberB} равно: {FindPower(numberA, numberB)}");
}

int FindPower(int numberA, int numberB)
{
    int power = numberA;
    if (numberB == 0) return 1;
    if (numberB == 1) return numberA;
    for (int i = 2; i <= numberB; numberB--)
    {
       power = power * numberA;
    }
    return power;
}
Zadacha25();