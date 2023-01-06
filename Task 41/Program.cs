// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] Array(int numb)
{
    int [] arr = new int [numb];
    for (int i = 0; i<arr.Length; i++)
    {
        System.Console.Write($"Введите {i+1}й элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void ShowArray (int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

void Count (int[] arr)
{
    int sum = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i]>0){
        sum = sum + 1;
        }
    }
    System.Console.Write($"Количество элементов массива больше нуля: {sum} ");
}

Console.Write("Введите количество элементов массива: ");
int numb = Convert.ToInt32(Console.ReadLine());
int [] CreatedArray = Array(numb);
ShowArray(CreatedArray);
Count(CreatedArray);

