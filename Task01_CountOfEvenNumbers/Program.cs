// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] InitArray(int demension)
{
    
    int[] arr = new int[demension];
    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int CountOfEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
            
    }
    return count;
}
// запрос размерности массива у пользователя
Console.WriteLine("Введите размерность массива");
int demension = int.Parse(Console.ReadLine()??"");
// заполнение массива
int [] arr = InitArray(demension);
// вывод массива на консоль
var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");
// подсчет количества положительных элементов массива
int count = CountOfEvenNumbers(arr);
// вывод на консоль
Console.WriteLine($"Количество четных чисел в массиве: {count}");
