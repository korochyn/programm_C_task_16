// Урок 5. Функции и одномерные массивы
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Ввод числа с экрана
int Promt (string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse (ReadInput);
    return result;
}
// Метод для получения случайных значений массива
int[] GenerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for(int i=0; i < Length; i++)
    {
        array[i] = random.Next(minValue,maxValue+1);
    }
    return array;
}
// Метод вывода массива
void PrintArray (int [] array)
{
    Console.Write("[");
    for(int i=0; i<array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}

// Метод вычисления суммы элементов, стоящих на нечётных позициях
int Odd_Pos (int [] array)
{
    int odd_pos_num =1;
    int result = 0;
     for(int i=0; i<array.Length; i++)
     {
       if (i == odd_pos_num) {result = result +array[i]; odd_pos_num=odd_pos_num+2;}
     }
    return result;
}



int length = Promt("Длинна массива: ");
int min = Promt("Начальное значение для диапазона случайного числа: ");
int max = Promt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray (length, min, max);
PrintArray (array);
int result = Odd_Pos(array);
Console.WriteLine(result);