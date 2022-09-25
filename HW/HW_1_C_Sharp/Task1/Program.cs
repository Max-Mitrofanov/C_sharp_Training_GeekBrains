Console.WriteLine("Enter first number: ");
string firstInput = Console.ReadLine();
int  firstNumber = int.Parse(firstInput);

Console.WriteLine("Enter second number: ");
string secondInput = Console.ReadLine();
int  secondNumber = int.Parse(secondInput);

Console.WriteLine("Enter third number: ");
string thirdInput = Console.ReadLine();
int  thirdNumber = int.Parse(thirdInput);

int max = firstNumber;

if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;

Console.WriteLine("Maximum number is "+max);





