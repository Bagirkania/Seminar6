// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double[] FillArrayTask1()
{
 Random rnd = new Random();
 int Insert = Convert.ToInt32(Console.ReadLine());
 double[] array = new double[Insert];

for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100, 101);
}
return array;
}


void PrintArray(double[] array)
{
    Console.WriteLine("[" + String.Join("; ", array) + "]");
}

void task1()
{

Console.Clear();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь");
Console.Write("Введите массива чисел М: ");
double[] array = FillArrayTask1();
PrintArray(array);
int count = 0;
for(int i = 0; i < array.Length; i++)
{
 if(array[i] > 0) count++;
}
Console.WriteLine("Чисел больше 0 - " + count);
}
task1();




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

