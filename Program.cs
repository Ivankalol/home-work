﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// void ShowNumbers(int n)
// {
//     if(n >= 1)
//     {
//         Console.Write(n+" ");
//         ShowNumbers(n-1);
//     }
// }

// ShowNumbers(5);


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30





// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AckermannFunction (int numberM, int numberN)
// {
//     if (numberM == 0) return numberN + 1;
//     if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
//     if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
// return AckermannFunction(numberM, numberN);
// }

// Console.WriteLine(AckermannFunction(3,2));