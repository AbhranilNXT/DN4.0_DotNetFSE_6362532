package com.example.financialforecasting;

public class FinancialForecast {

    // Using base recusrsion
    public static double calculateFutureValue(double presentValue, double growthRate, int periods) {
        if (periods == 0) {
            return presentValue;
        }
        return calculateFutureValue(presentValue * (1 + growthRate), growthRate, periods - 1);
    }

    // Using iteration
    public static double calculateFutureValueIterative(double presentValue, double growthRate, int periods) {
        double futureValue = presentValue;
        for (int i = 0; i < periods; i++) {
            futureValue *= (1 + growthRate);
        }
        return futureValue;
    }

    // Using memoization
    public static double calculateFutureValueMemoized(double presentValue, double growthRate, int periods,
            double[] cache) {
        if (periods == 0) {
            return presentValue;
        }
        if (cache[periods] != 0) {
            return cache[periods];
        }
        cache[periods] = calculateFutureValueMemoized(presentValue * (1 + growthRate), growthRate, periods - 1, cache);
        return cache[periods];
    }
}
