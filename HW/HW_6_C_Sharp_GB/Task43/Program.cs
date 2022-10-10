// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.Write("Введите угловой коэффициент k для первой прямой: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите угловой коэффициент k для второй прямой: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите свободный коэффициент b для первой прямой: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите свободный коэффициент b для второй прямой: ");
int b2 = int.Parse(Console.ReadLine());

double[] calcIntersection (double k1, double k2, double b1, double b2){

    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    double[] arr = {x,y};
    return arr;
} 

void printArr(double[] arr){
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ] ");
}

printArr(calcIntersection(k1, k2, b1, b2));
