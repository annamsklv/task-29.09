// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int [] InitArray(int demension)
{
    
    int[] arr = new int[demension];
    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

int SumOfElementsInOddPositions(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
            sum += arr[i];
    }
    return sum;
}

// запрос размерности массива у пользователя
Console.WriteLine("Введите размерность массива");
int demension = int.Parse(Console.ReadLine()??"");
// заполнение массива
int [] arr = InitArray(demension);
// вывод массива на консоль
var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");
// подсчет суммы элементов массива с нечетными индексами
int sum = SumOfElementsInOddPositions(arr);
// вывод на консоль
Console.WriteLine($"Cуммa элементов массива с нечетными индексами: {sum}");