/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Напишите координату X первой точки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Y первой точки: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Z первой точки: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double a = Math. Sqrt((x - x2) * (x - x2) + (y - y2) * (y - y2) + (z - z2) * (z - z2));
Console.WriteLine("Расстояние между двумя точками: " + a);