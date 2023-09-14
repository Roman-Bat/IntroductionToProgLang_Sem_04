/*
Задача 28:
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 --> 24
5 --> 120
*/
int MessageUser (string message)
{
    Console.WriteLine(message);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}
int Proizved (int N)
{
    int proizved = 1;
    for (int i = 1; i <= N; i ++)
    {
        proizved = proizved * i;
    }
    return proizved;
}

int N = MessageUser("Введите число N");
int proizved = Proizved(N);
Console.WriteLine("Произведение всех чисел от 1 до " + N + " = " + proizved);