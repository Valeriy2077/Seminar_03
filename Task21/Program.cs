﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] coordsA = new double[2];
double[] coordsB = new double[2];
// double[] 

System.Console.WriteLine("Введите координату X точки A:");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки A:");
coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X точки B:");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B:");
coordsA[1] = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow (coordsA[1] - coordsB[1],2) +
     Math.Pow (coordsA[0] - coordsB[0],2));

System.Console.WriteLine("Расстояние {}");