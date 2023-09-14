/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int [] randMass = new int[8];
Random rand = new Random();

string main(int N)
{
for (int i = 0; i <= N; i ++)
{
    randMass[i] = rand.Next(0, 20);
    if (i < N) Console.Write(randMass[i] + ", ");
    else Console.Write(randMass[i]);
}
    return "";
}
Console.Write("Элементы массива [");
Console.Write(main(7));
Console.Write("]");