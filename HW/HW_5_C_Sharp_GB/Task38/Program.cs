// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] array = new int[5];

int[] fillArray (int[] arr){
    Random randGenerator = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = randGenerator.Next(-99,100);
}
    return arr;
}

void printArr(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ] -> ");
}

int calcDiff (int[] arr) {
    int max = 0;
    int min = 0;
    int dif = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    dif = max - min;
    return dif;
}

printArr(fillArray(array));
Console.WriteLine(calcDiff(array));