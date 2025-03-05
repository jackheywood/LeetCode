using BenchmarkDotNet.Attributes;

namespace Benchmarking;

public class Benchmark
{
    private static readonly char[] TestCases = ['I', 'V', 'X', 'L', 'C', 'D', 'M'];

    private static readonly ushort[] RomanValues = new ushort[256];

    static Benchmark()
    {
        RomanValues['I'] = 1;
        RomanValues['V'] = 5;
        RomanValues['X'] = 10;
        RomanValues['L'] = 50;
        RomanValues['C'] = 100;
        RomanValues['D'] = 500;
        RomanValues['M'] = 1000;
    }

    [Benchmark]
    public int SwitchMethod()
    {
        var sum = 0;
        foreach (var numeral in TestCases)
        {
            sum += GetRomanValueSwitch(numeral);
        }

        return sum;
    }

    [Benchmark]
    public int UshortArrayMethod()
    {
        var sum = 0;
        foreach (var numeral in TestCases)
        {
            sum += GetRomanValueUshortArray(numeral);
        }

        return sum;
    }

    private static int GetRomanValueSwitch(char numeral) => numeral switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => throw new ArgumentException("Invalid Roman numeral"),
    };

    private static int GetRomanValueUshortArray(char numeral) => RomanValues[numeral];
}
