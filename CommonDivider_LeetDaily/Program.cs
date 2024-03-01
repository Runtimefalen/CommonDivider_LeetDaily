class MyClass
{
    // Ограничения 1 < x <1000 ENG UPPERCASE
    static string a = "ABA"; // LEET    ABC ABCABCABC ABAB  ABA
    static string b = "ABABA"; // CODE  AB  ABAB    ABABABAB  ABABA

    static void Main()
    {
        var s = GcdOfStrings(a, b);
    }

    private static async Task<string> GcdOfStrings(string str1, string str2)
    {
        var maxDivider = "";

        var maxLength = str1.Length >= str2.Length ? str1.Length : str2.Length;
        for (var i = 1; i < maxLength -1; i++)
        {
            var first = await Finder(str1, i);
            var second = await Finder(str2, i);
            
                if (first == null || second == null)
                    break;
            
            if (first.Equals(second))
            {
                if (ValidateDivider(str1, first) && ValidateDivider(str2, second))
                {
                    maxDivider = first;
                }
            }
        }
        maxDivider = maxDivider.Length == 1 ? String.Empty : maxDivider;
        if (maxDivider.Equals(""))
        {
            Console.WriteLine("No dividers!");
        }

        Console.WriteLine(maxDivider);
        return maxDivider;
    }
    
    private static async Task<string?> Finder(string @string, int i)
    {
        if (@string.Length < i)
            return null;
        
        return @string.Substring(0, i);
    }

    static bool ValidateDivider(string word, string substring)
    {
        var unitString = word[..substring.Length];
        
        while (word.Length > 0 && word.Length >= unitString.Length)
        {
            if (word[..substring.Length] == unitString)
            {
                word = word.Substring(substring.Length, word.Length - substring.Length);
            }
            else 
                return false;
        }

        if (word.Length != 0)
            return false;
        return true;
    }
}