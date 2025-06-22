public class FinancialForecast
{
    // Using recursion
    public static double CalculateFutureValue(double presentValue, double growthRate, int periods)
    {
        if (periods == 0)
            return presentValue;

        return CalculateFutureValue(presentValue * (1 + growthRate), growthRate, periods - 1);
    }

    // Using iteration
    public static double CalculateFutureValueIterative(double presentValue, double growthRate, int periods)
    {
        double futureValue = presentValue;
        for (int i = 0; i < periods; i++)
        {
            futureValue *= (1 + growthRate);
        }
        return futureValue;
    }

    // Using memoization
    public static double CalculateFutureValueMemoized(double presentValue, double growthRate, int periods, double[] cache)
    {
        if (periods == 0)
            return presentValue;

        if (cache[periods] != 0)
            return cache[periods];

        cache[periods] = CalculateFutureValueMemoized(presentValue * (1 + growthRate), growthRate, periods - 1, cache);
        return cache[periods];
    }

}

// Extension method for nanoseconds
public static class StopwatchExtensions
{
    public static double TotalNanoseconds(this TimeSpan ts)
    {
        return ts.Ticks * (1000000000.0 / TimeSpan.TicksPerSecond);
    }
}

