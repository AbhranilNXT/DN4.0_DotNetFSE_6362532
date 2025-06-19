package com.example.ecommerceplatformsearch;

public class Main {
    public static void main(String[] args) {
        Product[] products = {
                new Product(103, "Mouse", "Electronics"),
                new Product(101, "Laptop", "Electronics"),
                new Product(105, "Notebook", "Stationery"),
                new Product(102, "Mobile", "Electronics"),
                new Product(104, "Pen", "Stationery")
        };

        int searchId = 105;

        // Linear Search
        Product foundLinear = SearchAlgorithms.linearSearch(products, searchId);
        System.out.println("Linear Search Result: " + foundLinear);

        // Sort and then Binary Search
        SearchAlgorithms.sortById(products);
        Product foundBinary = SearchAlgorithms.binarySearch(products, searchId);
        System.out.println("Binary Search Result: " + foundBinary);
    }
}
