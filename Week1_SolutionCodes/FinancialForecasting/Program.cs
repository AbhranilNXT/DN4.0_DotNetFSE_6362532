using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        double presentValue = 1000.0;
        double growthRate = 0.08;
        int periods = 30;

        // Recursive
        var sw1 = Stopwatch.StartNew();
        double recursive = FinancialForecast.CalculateFutureValue(presentValue, growthRate, periods);
        sw1.Stop();
        Console.WriteLine($"Future Value (Recursive): {recursive}");
        Console.WriteLine($"Time taken (Recursive): {sw1.Elapsed.TotalNanoseconds()} ns");

        // Iterative
        var sw2 = Stopwatch.StartNew();
        double iterative = FinancialForecast.CalculateFutureValueIterative(presentValue, growthRate, periods);
        sw2.Stop();
        Console.WriteLine($"Future Value (Iterative): {iterative}");
        Console.WriteLine($"Time taken (Iterative): {sw2.Elapsed.TotalNanoseconds()} ns");

        // Memoized
        double[] cache = new double[periods + 1];
        var sw3 = Stopwatch.StartNew();
        double memoized = FinancialForecast.CalculateFutureValueMemoized(presentValue, growthRate, periods, cache);
        sw3.Stop();
        Console.WriteLine($"Future Value (Memoized): {memoized}");
        Console.WriteLine($"Time taken (Memoized): {sw3.Elapsed.TotalNanoseconds()} ns");
    }
}