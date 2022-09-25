Console.Clear();

Console.Write("Please enter a day number (Between 1 and 7): ");

int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber > 0 && dayNumber <= 7 ) {
    if (dayNumber == 7 || dayNumber == 6) {
        Console.WriteLine("It's a weekend day!");
    }
    else {
        Console.WriteLine("It's a work day!");
    }
}
else {
    Console.WriteLine("Please try again and enter day number between 1 and 7");
}