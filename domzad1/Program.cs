// **Задача 25:** Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInt("Введите число A:   ");
int B = ReadInt("Введите натуральное число B:   ");

if (B > 0)
    Console.WriteLine($"Число {A} в степени {B} равно  = {Stepen(A, B)}");
else Console.WriteLine("Показатель не должен быть меньше 0");


int Stepen(int A, int B)
{
    int S = 1;
    int i = 0;
    while (i < B)
    {
        S *= A;
        i++;
    }
    return S;
}