namespace Solutions;

public class RomanToInteger
{
    private static readonly ushort[] RomanValues = new ushort[256];

    static RomanToInteger()
    {
        RomanValues['I'] = 1;
        RomanValues['V'] = 5;
        RomanValues['X'] = 10;
        RomanValues['L'] = 50;
        RomanValues['C'] = 100;
        RomanValues['D'] = 500;
        RomanValues['M'] = 1000;
    }

    public static int RomanToIntForward(string s)
    {
        if (s.Length == 0) return 0;

        var firstNumeral = s[0];
        var firstValue = GetRomanValue(firstNumeral);
        if (s.Length == 1) return firstValue;

        var secondNumeral = s[1];

        // Check second numeral
        if (secondNumeral != firstNumeral)
        {
            var secondValue = GetRomanValue(secondNumeral);

            // Check cases like IV, IX, XL, XC, CD, CM
            if (secondValue > firstValue)
            {
                return secondValue - firstValue + RomanToIntForward(s[2..]);
            }

            // Continue parsing the rest of the string
            return firstValue + RomanToIntForward(s[1..]);
        }

        if (s.Length == 2) return firstValue * 2;

        var thirdNumeral = s[2];

        // Check third numeral
        if (thirdNumeral == firstNumeral)
        {
            return firstValue * 3 + RomanToIntForward(s[3..]);
        }

        return firstValue * 2 + RomanToIntForward(s[2..]);
    }

    public static int RomanToIntReverse(string s)
    {
        var total = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var currentValue = GetRomanValue(s[i]);

            // Can't repeat a character more than 3 times, so if
            // 3 times the current value is less than the running total,
            // we must have a case such as IV, IX, XL, XC, CD, CM
            if (3 * currentValue < total) total -= currentValue;
            else total += currentValue;
        }

        return total;
    }

    private static int GetRomanValue(char numeral) => RomanValues[numeral];
}
