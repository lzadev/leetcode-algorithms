
static int RomanToInteger(string roman)
{
    var romanValues = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    var result = 0;
    for (int i = 0; i < roman.Length; i++)
    {
        var current = roman[i];
        int value = romanValues[current];
        if (i + 1 < roman.Length && romanValues[roman[i + 1]] > value) result -= value;
        else result += value;
    }
    return result;
}

Console.WriteLine(RomanToInteger("MCMXCIV"));