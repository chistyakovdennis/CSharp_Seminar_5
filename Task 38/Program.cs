// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

class Program
{
    static void Main()
    {
        // Задаем длину массива
        int length = 10;

        // Создаем генератор случайных чисел
        Random random = new Random();

        // Создаем массив случайных вещественных чисел
        double[] array = new double[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.NextDouble() * 100; // Генерируем случайное вещественное число от 0 до 100
        }

        // Выводим массив
        Console.WriteLine("Массив случайных вещественных чисел:");
        foreach (double element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // Находим максимальный и минимальный элементы массива
        double max = array[0];
        double min = array[0];
        foreach (double element in array)
        {
            if (element > max)
            {
                max = element;
            }
            if (element < min)
            {
                min = element;
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Выводим результат
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    }
}
