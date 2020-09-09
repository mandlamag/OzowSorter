using System;
using System.Text;
using System.Text.RegularExpressions;
using Ardalis.GuardClauses;

public static class StringSorter
{

    // i could just call the individual functions instead of this
    public static string TrimAndSort(this string input)
    {
        Guard.Against.NullOrEmpty(input, nameof(input));

        return input.RemoveWhiteSpacesAndPunctuation().ToLower().ToSorted();

    }

    public static string RemoveWhiteSpacesAndPunctuation(this string input)
    {
        Guard.Against.NullOrEmpty(input, nameof(input));
        
        return Regex.Replace(input, @"[^\w]", string.Empty);
    }

    public static string ToSorted(this string input)
    {
        Guard.Against.NullOrEmpty(input, nameof(input));

        byte[] ascii = Encoding.ASCII.GetBytes(input);

        // I could use OrderBy here but it just felt like cheating.
        var sorted = SortBytesAscending(ascii);

        var results = string.Empty;

        foreach (byte c in sorted)
        {
            results += char.ConvertFromUtf32(c);
        }

        return results;
    }

    private static byte[] SortBytesAscending(byte[] asciiArray)
    {
        byte temp;

        for (int i = 0; i < asciiArray.Length - 1; i++)
        {
            for (int j = i + 1; j < asciiArray.Length; j++)
            {
                if (asciiArray[i] > asciiArray[j])
                {
                    temp = asciiArray[i];
                    asciiArray[i] = asciiArray[j];
                    asciiArray[j] = temp;
                }

            }
        }

        return asciiArray;
    }

}