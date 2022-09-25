Console.Clear();
Console.WriteLine("Enter a 3 digits number:");
int number = int.Parse(Console.ReadLine());

int twoDigits = number % 100;
int secondDigit = twoDigits / 10;

Console.WriteLine(secondDigit);