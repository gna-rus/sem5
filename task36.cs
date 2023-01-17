/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();
int size = InputSizeArray(); // ввод размерности массива

int[] array = new int[size]; // создание массива
array = GetArrayNumber(size); // заполнение масспшива случайными числами от -100 до 100
int SumInArray = CoutingSum(array);
OutputArray(array, SumInArray);

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

int CoutingSum(int[] arr) //подсчет суммы через цикл элементов, расположенных на нечетных позициях
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

void OutputArray(int[] arr, int sum) // вывод на экран результатов подсчета
{
    Console.WriteLine($"[{String.Join(", ", arr)}] -> {sum}");
}
