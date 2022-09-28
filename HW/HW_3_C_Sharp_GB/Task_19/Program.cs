Console.Clear();
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void polyndromCheck (int number) {
    string stringNumber = number.ToString();
    int length = stringNumber.Length;
    int result = 0;
        for(int i = 0; i <= length / 2; i++){
            if (stringNumber[0 + i] == stringNumber[length - 1 - i]){
                result = 1;
            }
            else result = -1;
        }
    if (result > 0) Console.WriteLine(number + " is a polyndrom");
    else Console.WriteLine(number + " is NOT a polyndrom");
}
polyndromCheck(14212);
polyndromCheck(23432);
polyndromCheck(12821);
polyndromCheck(431282134);