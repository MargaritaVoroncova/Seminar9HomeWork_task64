﻿/* Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N 
от большего к меньшему.*/

Console.WriteLine("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int firstUserNumber, int secondUserNumber)
{
    if(firstUserNumber < secondUserNumber)
    { 
        return $"{secondUserNumber} " + NumbersRec(firstUserNumber, secondUserNumber - 1);
    }
    else
    { 
         return $"{firstUserNumber} ";
    }
}

Console.WriteLine(NumbersRec(firstUserNumber, secondUserNumber));
