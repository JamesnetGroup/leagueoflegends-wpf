using System.Globalization;

namespace Jamesnet.Core;

public static class StringExtensions
{
    public static string ToPascal(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(input.ToLower()).Replace(" ", "");
    }
}
