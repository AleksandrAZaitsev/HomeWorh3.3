﻿// Ввод координат А
System.Console.WriteLine("Введите координаты x точки А: ");

int[] coordsA = new int[3];

coordsA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты y точки A: ");

coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты z точки A: ");

coordsA[2] = Convert.ToInt32(Console.ReadLine());

// Ввод координат B

System.Console.WriteLine("Введите координаты x точки B: ");

int[] coordsB = new int[3];

coordsB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты y точки B: ");

coordsB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты z точки B: ");

coordsB[2] = Convert.ToInt32(Console.ReadLine());

int distanceX = (int) Math.Pow(coordsB[0]-coordsA[0], 2);
int distanceY = (int) Math.Pow(coordsB[1]-coordsA[1], 2);
int distanceZ = (int) Math.Pow(coordsB[2]-coordsA[2], 2);

double Result = Math.Sqrt (distanceX + distanceY + distanceZ);


System.Console.WriteLine(Math.Round(Result, 2));