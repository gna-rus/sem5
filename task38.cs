/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();
int size = InputSizeArray(); // ввод размерности массива

int[] array = new int[size]; // создание массива
array = GetArrayNumber(size); // заполнение массива случайными числами от -100 до 100
int SumInArray = FindMaxInArray(array) + FindMinInArray(array); // поиск суммы МАХ и MIN чисел массива

OutputArray(array, SumInArray); // вывод результата на экран

int InputSizeArray() // заполнение массива и обращение
{
    Console.WriteLine("Пожалуйста, введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

int[] GetArrayNumber(int size) // заполнение массива числами от -100 до 100 включительно
{
    var rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

int FindMaxInArray(int[] arr) // поиск максимального числа в массиве
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
int FindMinInArray(int[] arr) // поиск минимально числа в массиве
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

void OutputArray(int[] arr, int sum) // вывод на экран результатов подсчета
{
    Console.WriteLine($"[{String.Join(" ", arr)}] -> {sum}");
}
