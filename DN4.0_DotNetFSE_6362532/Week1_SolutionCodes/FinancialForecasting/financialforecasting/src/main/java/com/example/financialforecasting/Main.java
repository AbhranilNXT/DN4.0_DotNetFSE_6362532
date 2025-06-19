package com.example.financialforecasting;

public class Main {
    public static void main(String[] args) {
        double presentValue = 1000.0;
        double growthRate = 0.08;
        int periods = 30;

        // Timing and output for base recursion
        long startRecursive = System.nanoTime();
        double futureValueRecursive = FinancialForecast.calculateFutureValue(presentValue, growthRate, periods);
        long endRecursive = System.nanoTime();
        System.out.println("Future Value (Recursive): " + futureValueRecursive);
        System.out.println("Time taken (Recursive): " + (endRecursive - startRecursive) + " ns");

        // Timing and output for iteration
        long startIterative = System.nanoTime();
        double futureValueIterative = FinancialForecast.calculateFutureValueIterative(presentValue, growthRate,
                periods);
        long endIterative = System.nanoTime();
        System.out.println("Future Value (Iterative): " + futureValueIterative);
        System.out.println("Time taken (Iterative): " + (endIterative - startIterative) + " ns");

        // Timing and output for memoization
        double[] cache = new double[periods + 1];
        long startMemo = System.nanoTime();
        double futureValueMemoized = FinancialForecast.calculateFutureValueMemoized(presentValue, growthRate, periods,
                cache);
        long endMemo = System.nanoTime();
        System.out.println("Future Value (Memoized): " + futureValueMemoized);
        System.out.println("Time taken (Memoized): " + (endMemo - startMemo) + " ns");
    }
}