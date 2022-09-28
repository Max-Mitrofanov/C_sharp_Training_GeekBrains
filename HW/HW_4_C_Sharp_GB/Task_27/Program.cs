// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int SumDigits(int num){
    int sum = 0;
    string numStr = num.ToString();
    for (int i = 0; i < numStr.Length; i++){
     sum += num % 10;
     num /= 10;
    }
    return sum;
}
Console.WriteLine(SumDigits(number));