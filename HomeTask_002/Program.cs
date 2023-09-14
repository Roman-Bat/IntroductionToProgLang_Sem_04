/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
// Получаем от пользователя число
int getNumber (string message)
{
    Console.Write(message);
    int getNumber = Convert.ToInt32(Console.ReadLine());
    return getNumber;
}
// Разделяем число на разряды и суммируем каждый разряд как число
int DigitSum (int number)
{
    int Digit = 0;
    while (number != 0)
    {
        Digit += number % 10;
        number /= 10; 
    }
    return Digit;
}
// тело программы
int number = getNumber("Введите число :");
Console.Write("Сумма всех разрядов числа равна: ");
Console.WriteLine(DigitSum(number));