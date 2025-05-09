// See https://aka.ms/new-console-template for more information


int randomNumber = new Random().Next(1,1000);
int amountOfAttempts = 0;

Console.WriteLine("Enter the number to guess! ");
int start = Int32.Parse(Console.ReadLine());
while (start != randomNumber)
{
    if (start > randomNumber)
    {
        Console.WriteLine($"{start} is bigger!");
    }

    else if (start < randomNumber)
    {
        Console.WriteLine($"{start} is smaller!");
    }
    amountOfAttempts++;
    start = Int32.Parse(Console.ReadLine());
}

Console.WriteLine($"It took {amountOfAttempts} attempts to guess number - {start}!");
