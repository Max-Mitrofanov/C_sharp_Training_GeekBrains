Console.Clear();
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine());

void CubicNumber (int n) {
    double cube = 3;
    for (int i = 1; i <= n; i++) {
        Console.WriteLine(Math.Pow(i, cube));
    }
}
CubicNumber(number);