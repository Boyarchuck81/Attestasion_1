﻿// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
*/ 

Console.WriteLine("Введите координаты точки. X: ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки. Y: ");
int userY = Convert.ToInt32(Console.ReadLine());
if (userX>0 && userY>0) System.Console.WriteLine("Точка находится в первой четверти");
if (userX<0 && userY>0) System.Console.WriteLine("Точка находится во второй четверти");
if (userX<0 && userY<0) System.Console.WriteLine("Точка находится в третьей четверти");
if (userX>0 && userY<0) System.Console.WriteLine("Точка находится в четвертой четверти");
if (userX==0 || userY==0) System.Console.WriteLine("Точка не находится на на одной координатной четверти");