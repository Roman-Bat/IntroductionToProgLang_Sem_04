/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456     --> 3
78      --> 2
89126   --> 5 12
*/
int MessageUser (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberLenght (int number)
{
    int numberLenght = number.ToString().Length;
    return numberLenght;
}

int number = MessageUser("Введите число А");
int numberLen = numberLenght(number);
Console.WriteLine("Вы ввели число - " + number);
Console.WriteLine("В числе " + numberLen + " разряда");