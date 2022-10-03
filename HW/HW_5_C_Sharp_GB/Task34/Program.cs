// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] array = new int[5];

int[] fillArray (int[] arr){
    Random randGenerator = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = randGenerator.Next(100,1000);
}
return arr;
}


int countEven (int[] arr){
    int count = 0;
        for (int i = 0; i < arr.Length; i++){
            if (arr[i] % 2 == 0) count++;
        } 
    return count;
}

void printArr(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

fillArray(array);
printArr(array);
Console.Write(countEven(array));