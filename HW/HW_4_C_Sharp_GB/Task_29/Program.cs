// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.Clear();
Console.WriteLine("Введите 8 случайных чисел: ");

int[] createArr (){
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = int.Parse(Console.ReadLine());
    }
    return  arr;
}

void printArr(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ]");
}
printArr(createArr());

