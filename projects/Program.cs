
do
{
    Console.WriteLine("Please enter a sentence:");
    string sent = Console.ReadLine();
    Console.WriteLine("What would you like to do with the sentence? (Count the total characters)");
    Console.WriteLine("                                             (Count the number of a certain character)");
    Console.WriteLine("                                             (Count the number of words)");
    string option = Console.ReadLine();
    if (option == "Count the total characters")
        Console.WriteLine($"The total characters in your sentence are {sent.Length}.");
    else if (option == "Count the number of a certain character")
    {
        Console.WriteLine("Which character would you like to know the number of in your sentence?");
        char charToCount = char.Parse(Console.ReadLine());
        int count = 0;
        foreach (char c in sent)
        {
            if (c == charToCount)
                count++;
        }
        Console.WriteLine($"There are {count} of your characters in the sentence.");
    }
    else if (option == "Count the number of words")
    {
        int count = 0;
        foreach (char k in sent)
        {
            if (k == ' ')
                count++;
        }
        Console.WriteLine($"There are {count + 1} words in the sentence.");
    }
} while (true);




