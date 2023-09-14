/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/
int MessageUser (string message)
{
    Console.WriteLine(message);
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}
int Summa (int A)
{
    int summa = 0;
    for (int i = 1; i <= A; i ++)
    {
        summa = summa + i;
    }
    return summa;
}

int A = MessageUser("Введите число А");
int summa = Summa(A);
Console.WriteLine("Сумма всех чисел от 1 до " + A + " = " + summa);
