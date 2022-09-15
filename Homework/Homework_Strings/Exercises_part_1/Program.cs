string word = "w3schools";
if(word.Length > 0)
{
    Console.WriteLine(word.Remove(0, 1));
    Console.WriteLine(word.Remove(1, 1));
    Console.WriteLine(word.Remove(2, 1));

}

static string ChangePosition(string SomeWord)
{
    string lastLetter = SomeWord.Substring(SomeWord.Length - 1);
    SomeWord.ToCharArray();
    char firstLetter = SomeWord[0];
    string newWord =  SomeWord.Remove(SomeWord.Length - 1);

    newWord += firstLetter;
    string IntString = newWord.Remove(0, 1);
    string finalString = lastLetter + IntString;
    
    return finalString;
    
}

Console.WriteLine(ChangePosition("Golly")); 

static string AddFirstLetter(string SomeWord)
{
    SomeWord.ToCharArray();
    char firstLetter = SomeWord[0];
    string finalString = firstLetter + SomeWord + firstLetter;
    return finalString;
}

Console.WriteLine(AddFirstLetter("Old McDonald Had a Farm"));

static string ConvertToLowerCase(string SomeWord)
{
    return SomeWord.ToLower();
}

Console.WriteLine(ConvertToLowerCase("I'M SO CAPITALIZED. OR AM I?"));

static string LongestWord(string SomeWord)
{
    string[] newArr = SomeWord.Split(' ');
    string largestWord = newArr[0];
    for (int i = 1; i < newArr.Length - 1; i++)
    {
        if (newArr[i].Length > largestWord.Length)
        {
            largestWord = newArr[i];
        }
    }
    return largestWord;
    
}

Console.WriteLine(LongestWord("This is going to be fun.  Idiosincracy, apparently."));

static string ReverseWords(string SomeWord)
{
    string[] newArr = SomeWord.Split(' ');
    Array.Reverse(newArr);  
    string finalString = string.Join(' ', newArr);

    return finalString;
}

Console.WriteLine(ReverseWords("This is the end, my beautiful friend, The end."));

static string LastFourChars(string SomeWord)
{
    string newWord = SomeWord.Substring(SomeWord.Length - 4);
    if(SomeWord.Length < 4)
    {
        return SomeWord;
    }
    return newWord + newWord + newWord + newWord;

}

Console.WriteLine(LastFourChars("They say it's the way he bends lit."));

static bool StartsWithHello(string SomeWord)
{
    string[] newArr = SomeWord.Split(' ');
    if (newArr[0] == "Hello")
    {
        return true;
    }
    return false;
}

Console.WriteLine(StartsWithHello("Hello my name is Borat."));
Console.WriteLine(StartsWithHello("Hi my name is Borat."));

static string ContainsHP(string SomeWord)
{
    if(SomeWord.IndexOf("HP") == 1)
    {
        string newWord = SomeWord.Remove(1, 2);
        return newWord;
    }
    return "It doesn't contain HP";
}


Console.WriteLine(ContainsHP("PHP Tutorial"));

static string NewString(string SomeWord)
{
    char a = SomeWord[0];
    char b = SomeWord[1];
    string newString = a.ToString() + b.ToString();
    return newString;
}
Console.WriteLine(NewString("PHP"));

static bool ContainsW(string SomeWord)
{
    int counter = 0;
    char a = 'w';
    foreach (char c in SomeWord)
    {
        if(c == a)
        {
            counter++;
        }
    }
    if(counter > 0 && counter < 4)
    {
        return true;
    }
    return false;
}
Console.WriteLine(ContainsW("w3shools"));

static string ConvertFirstFourLetters(string SomeWord)
{
    if(SomeWord.Length < 4)
    {
        return SomeWord.ToUpper();
    }
    string newString = SomeWord.Substring(0, 4);
    string finalString = newString.ToLower() + SomeWord.Remove(0,4);
    return finalString;
}

Console.WriteLine(ConvertFirstFourLetters("FOUR DAYS OF OUR LIVES."));
Console.WriteLine(ConvertFirstFourLetters("tri"));

static string oddPositionString(string SomeWord)
{
    string newString = " ";
    for (int i = 0; i < SomeWord.Length - 1; i++)
    {
        if (i % 2 == 0)
        {
            newString += SomeWord[i];
        }
        
    }
    return newString;
}

Console.WriteLine(oddPositionString("w3resource"));