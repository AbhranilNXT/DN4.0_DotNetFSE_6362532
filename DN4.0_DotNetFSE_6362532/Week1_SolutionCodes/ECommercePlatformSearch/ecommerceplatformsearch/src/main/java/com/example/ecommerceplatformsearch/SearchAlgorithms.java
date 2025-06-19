package com.example.ecommerceplatformsearch;

import java.util.Arrays;
import java.util.Comparator;

public class SearchAlgorithms {

    // Linear Search
    public static Product linearSearch(Product[] products, int targetId) {
        long startTime = System.nanoTime();
        for (Product product : products) {
            if (product.getProductId() == targetId) {
                long endTime = System.nanoTime();
                System.out.printf("Linear Search completed in %d nanoseconds\n", (endTime - startTime));
                return product;
            }
        }
        long endTime = System.nanoTime();
        System.out.printf("Linear Search completed in %d nanoseconds\n", (endTime - startTime));
        return null;
    }

    // Binary Search
    public static Product binarySearch(Product[] products, int targetId) {
        long startTime = System.nanoTime();
        int left = 0;
        int right = products.length - 1;

        while (left <= right) {
            int mid = (left + right) / 2;
            int midId = products[mid].getProductId();

            if (midId == targetId) {
                long endTime = System.nanoTime();
                System.out.printf("Binary Search completed in %d nanoseconds\n", (endTime - startTime));
                return products[mid];
            } else if (midId < targetId) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        long endTime = System.nanoTime();
        System.out.printf("Binary Search completed in %d nanoseconds\n", (endTime - startTime));
        return null;
    }

    public static void sortById(Product[] products) {
        Arrays.sort(products, Comparator.comparingInt(Product::getProductId));
    }
}
