// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Программа определяет расстояние между двумя точками в пространстве.");
Console.WriteLine("Для этого Вам необходимо ввести значения X, Y, Z. Для продолжения нажмите Enter.");
Console.ReadLine(); 

Console.Write("Введите значение X для точки А: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y для точки А: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Z для точки А: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение X для точки В: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y для точки В: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Z для точки В: ");
int Z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double AB = Math.Sqrt(Math.Pow(X2 - X1, 2 ) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine($"Расстояние между точками = {Math.Round(AB, 2)}");
Console.WriteLine();