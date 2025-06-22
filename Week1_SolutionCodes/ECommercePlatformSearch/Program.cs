using System;

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(103, "Mouse", "Electronics"),
            new Product(101, "Laptop", "Electronics"),
            new Product(105, "Notebook", "Stationery"),
            new Product(102, "Mobile", "Electronics"),
            new Product(104, "Pen", "Stationery")
        };

        int searchId = 105;

        // Linear Search
        var foundLinear = SearchAlgorithms.LinearSearch(products, searchId);
        Console.WriteLine("Linear Search Result: " + foundLinear);

        // Sort and then Binary Search
        SearchAlgorithms.SortById(products);
        var foundBinary = SearchAlgorithms.BinarySearch(products, searchId);
        Console.WriteLine("Binary Search Result: " + foundBinary);
    }
}