﻿/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры или задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись массивами.
Примеры:
["hello", "2", "world", ":)"] => ["2", ":)"]
["1234", "1567", "-2", "computer science"] => ["-2"]
["Russia", "Denmark", "Kazan"] => []  */

string[] mass = {"hello", "2", "world", ":)"};
Console.Write("["); 
    for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i].Length <= 3)
            {
                Console.Write($"'{mass[i]}'");
                if (i < mass.Length - 2)
                {
                    Console.Write(", ");
                } 
            }
        }
        Console.WriteLine("]");

// Вывод программы: ['2', ':)']
      
            
                