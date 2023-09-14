/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int getNumber (string message)
{
    Console.Write(message);
    int getNumber = Convert.ToInt32(Console.ReadLine());
    return getNumber;
}

long exponentiation (int A, int B)
{
    long expo = 1;
    long uA = Convert.ToInt64(A);
    for (int i = 0; i < B; i++)
    {
        expo *= uA;
    }
    return expo;
     
}

int A = getNumber("Введите число А:");
int B = getNumber("Введите степень B:");
Console.WriteLine(exponentiation(A, B));