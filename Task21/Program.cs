﻿// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("\n\n"); 

Console.Write("ВВЕДИТЕ КООРДИНАТЫ ДВУХ ТОЧЕК: ");

Console.Write("\n\n");

Console.Write("x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("\n\n");

Console.Write("x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
  
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));

Console.Write("\n\n");

Console.WriteLine($"РАСТОЯНИЕ РАВНО: {d}");

Console.Write("\n\n");