/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int [] randMass = new int[8];
Random rand = new Random();
for (int i = 0; i <= 7; i ++)
{
    randMass[i] = rand.Next(0, 2);
    Console.WriteLine("Элемент массива [" + i + "]" + " равен " + randMass[i]);
}

