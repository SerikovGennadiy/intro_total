var words = new string[] {
    "Hello", "2", "world", ":-)"
};

ShowWords(GetWordsLessThen(words, 3));


int HowManyWordsLessThen(string[] words, int wordLength)
{
    int result = 0;
    foreach(var word in words)
    {
        if(word.Length <= wordLength)
        {
            result++;
        }
    }
    return result;
}

string[] GetWordsLessThen(string[] words,  int wordLength) 
{
   string[] result = new string[HowManyWordsLessThen(words, wordLength)];
   
   int i = 0;
   foreach(var word in words)
    {
        if(word.Length <= wordLength)
        {
            result[i++] = word;
        }
    }
    return result;
}

void ShowWords(string[] words) 
{
    foreach(var word in words) 
    {
        System.Console.WriteLine(word);
    }
}

// words
//     .Where(word => word.Length <= 3)
//     .ToList()
//     .ForEach(word => Console.WriteLine(word));