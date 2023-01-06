// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

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

Console.Write("Введите числа: ");
string numb = string.Empty;
numb = Convert.ToString(Console.ReadLine());
var CreatedArray = numb.Split(' ' , ',' , ':' , ';').Select(Int32.Parse).ToArray();
Count(CreatedArray);