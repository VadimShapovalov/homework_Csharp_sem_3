//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void KubChisel (int i, int x)
    {
        while (i <= x)
        {
            int a = i * i * i;
            Console.WriteLine(a);
            i++;
        }
    }

Console.WriteLine("Напишите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine("Кубы чисел от 1 до заданного: ");
KubChisel (i , x);
