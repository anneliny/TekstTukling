
Menu();
void Menu()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1. Rotate text");
    Console.WriteLine("2. Change text");

    var input= Console.ReadLine();
    CheckUserInput(input);
}

void CheckUserInput(string input)
{
    if (input == "1")
    {
        Console.Clear();
        Console.WriteLine("Write something to rotate:");
        var text = Console.ReadLine();
        string rotatedText = RotateText(text);
        Console.Clear();
        Console.WriteLine("Rotated text: " + rotatedText);
    }
    else if (input == "2")
    {
        Console.Clear();
        Console.WriteLine("Write something to change the letter e to a:");
        var text = Console.ReadLine();
        string changedText = ChangeText(text);
        Console.Clear();
        Console.WriteLine("Changed text: " + changedText);
    }
    else
    {
        Console.Clear();
        Menu();
    }
}

static string RotateText(string reverseInput)
{
    char[] charArray = reverseInput.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

static string ChangeText(string changeInput)
{
    string newText = changeInput.Replace('e', 'a');
    return new string(newText);
}
