﻿//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Задаем массив из 8 элементов

int [] array = new int [8];
int i = 0;
for(i=0; i<8; i++)
{
    array[i] = new Random().Next(0,1000);
}

// Выводим массив на экран
Console.WriteLine($"[{string.Join(",", array)}]");


