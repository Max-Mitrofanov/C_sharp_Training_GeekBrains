// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
Console.Clear();

Console.Write("Какое число возводим?: ");
int number = int.Parse(Console.ReadLine());

Console.Write("В какую степень возводим?: ");
int exp = int.Parse(Console.ReadLine());

int Power(int num, int exp) {
    int result = 1;
    for (int i = 1; i <= exp; i++){
        result = result * num;
    }
    return result;
}

Console.WriteLine("Результат: " + Power(number, exp));
