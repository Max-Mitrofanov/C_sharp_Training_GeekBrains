// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = new int[5];

int[] fillArray (int[] arr){
    Random randGenerator = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = randGenerator.Next(-99,100);
}
    return arr;
}

int sumOdd (int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length - 1; i += 2) {
        sum += arr[i];
    }
    return sum;
}

void printArr(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" ] ");
}


printArr(fillArray(array));
Console.WriteLine(sumOdd(array));


