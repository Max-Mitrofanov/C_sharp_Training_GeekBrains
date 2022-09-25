Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

string stringNumber = number.ToString();

if ( stringNumber.Length > 2) {
    char thirdValue = stringNumber[2];
    Console.WriteLine(thirdValue);
}
else {
    Console.WriteLine("There is no third character in this number!");
}
