using System;
using System.Collections.Generic;
using System.Numerics;

if( (args?.Length ?? 0) == 0 )
{
    Console.WriteLine( "Nothing to do...");
    return;
}

BigInteger number = BigInteger.Parse(args[0]);
PrimeHelper primeHelper = new PrimeHelper();
var factors = primeHelper.GetPrimeFactors(number);

string result = string.Join("*", factors);
Console.WriteLine($"Result is {result}");

public class PrimeHelper
{
    // Naive prime factoring :-)
    public IEnumerable<BigInteger> GetPrimeFactors(BigInteger n)
    {
        if (n < 2)
        {
            throw new ArgumentOutOfRangeException("Numbers less than 2 don't have prime factors");
        }

        List<BigInteger> result = new List<BigInteger>();

        BigInteger divisor = 2;

        while (divisor <= n)
        {
            if (n % divisor == 0)
            {
                result.Add(divisor);
                n /= divisor;
            }
            else
            {
                divisor++;
            }
        }

        return result;
    }
}