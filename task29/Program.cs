// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int [] arr = new int[8];

Console.WriteLine ("Введите 8 чисел");

for (int i = 0; i < arr.Length; i++)

{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", arr) + "]");
