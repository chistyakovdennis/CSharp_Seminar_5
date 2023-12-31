﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

class Program
{
    static void Main()
    {
        // Создаем объект генератора случайных чисел
        Random random = new Random();

        // Задаем размер массива
        int size = 10;

        // Создаем и заполняем массив случайными положительными трехзначными числами
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Выводим массив
        Console.WriteLine("Массив случайных положительных трехзначных чисел:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Переменная для хранения количества четных чисел
        int evenCount = 0;

        // Перебираем все элементы массива
        for (int i = 0; i < size; i++)
        {
            // Проверяем, является ли текущий элемент чётным
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат
        Console.WriteLine("Количество четных чисел в массиве: " + evenCount);
    }
}
