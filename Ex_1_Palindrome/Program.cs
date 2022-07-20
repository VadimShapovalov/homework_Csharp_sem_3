/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void Palindrome(int num)
{
    if(num < 100000 && num > 9999)
        {                
            int a = num % 10;
            int x = num / 10;
            int b = x % 10;
            int y = x / 10;
            int c = y % 10;
            int z = y / 10;
            int d = z % 10;
            int e = z / 10;
            int [] arr = new int [5];
            arr [0] = a;
            arr [1] = b;
            arr [2] = c;
            arr [3] = d;
            arr [4] = e;
            int [] arr2 = new int [5];
            arr2 [0] = arr [4];
            arr2 [1] = arr [3];
            arr2 [2] = arr [2];
            arr2 [3] = arr [1];
            arr2 [4] = arr [0];
            if (arr [0] == arr2 [0] && arr [1] == arr2 [1])
                {
                    Console.WriteLine("Число является палиндромом");
                }
            else
                {
                    Console.WriteLine("Число не является палиндромом");
                }
        }
    else
        {
            Console.WriteLine("Вы ввели не пятизначное число");
        }
}

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);