// **Задача 27:** Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInt("Введите число A:   ");
if (A > 0)
    Console.WriteLine($"Сумма цифр в числе {A} равна  = {Sum(A)}");
else Console.WriteLine($"Сумма цифр в числе {A} равна  = {-Sum(A)}");



int Sum(int S)
{
    int i = 0;
    while (S > 0 || S < 0)
    {
        i += S % 10;
        S = S / 10;
    }
    return i;
}