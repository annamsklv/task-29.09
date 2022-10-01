// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3 7 22 2 78] -> 76

double [] InitArray(int demension)
{
    
    double[] arr = new double[demension];
    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

double Difference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
        if(arr[i] < min)
        {
            min = arr[i];
        }   
    }
    return(max-min);
}

// запрос размерности массива у пользователя
Console.WriteLine("Введите размерность массива");
int demension = int.Parse(Console.ReadLine()??"");
// заполнение массива
double [] arr = InitArray(demension);
// вывод массива на консоль
var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");
// подсчет разницы между максимальным и минимальным элементами массива
double diff = Difference(arr);
// вывод на консоль
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");