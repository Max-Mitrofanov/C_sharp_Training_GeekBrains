// Задача 41: Пользователь вводит с клавиатуры число M,
// потом вводит M чисел ЧЕРЕЗ ENTER.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("How many numbers do you want to enter? ");
int numberCount = int.Parse(Console.ReadLine());

int[] createArr (){
    int[] arr = new int[numberCount];
    for (int i = 0; i < arr.Length; i++){
        Console.Write("Enter a random number: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int countPositive (int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Numbers above zero: " + countPositive(createArr()));