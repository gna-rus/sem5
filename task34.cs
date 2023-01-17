/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();

int size = InputSizeArray(); // ввод размерности массива

int[] array = new int[size]; // создание массива
array = GetArrayNumber(size); // заполнение масспшива случайными числами от 100 до 999

int count = CoutingNumbers(array); // подсчет четных чисел в массиве
OutputArray(array, count); // вывод результата на экран

int InputSizeArray() // заполнение массива и обращение
{
    Console.WriteLine("Пожалуйста, введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

int[] GetArrayNumber(int size) // заполнение массива числами от 100 до 999 включительно
{
    var rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}
int CoutingNumbers(int[] arr) // подсчет кол-ва четных чисел через цикл
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

void OutputArray(int[] arr, int count) // вывод на экран результатов подсчета
{
    Console.WriteLine($"[{String.Join(", ", arr)}] -> {count}");
}