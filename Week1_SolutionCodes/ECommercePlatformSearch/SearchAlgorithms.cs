using System;
using System.Diagnostics;

public class SearchAlgorithms
{
    // Linear Search
    public static Product LinearSearch(Product[] products, int targetId)
    {
        var stopwatch = Stopwatch.StartNew();

        foreach (var product in products)
        {
            if (product.ProductId == targetId)
            {
                stopwatch.Stop();
                Console.WriteLine($"Linear Search completed in {stopwatch.Elapsed.TotalNanoseconds()} nanoseconds");
                return product;
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"Linear Search completed in {stopwatch.Elapsed.TotalNanoseconds()} nanoseconds");
        return null;
    }

    // Binary Search
    public static Product BinarySearch(Product[] products, int targetId)
    {
        var stopwatch = Stopwatch.StartNew();

        int left = 0, right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int midId = products[mid].ProductId;

            if (midId == targetId)
            {
                stopwatch.Stop();
                Console.WriteLine($"Binary Search completed in {stopwatch.Elapsed.TotalNanoseconds()} nanoseconds");
                return products[mid];
            }
            else if (midId < targetId)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"Binary Search completed in {stopwatch.Elapsed.TotalNanoseconds()} nanoseconds");
        return null;
    }

    public static void SortById(Product[] products)
    {
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));
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