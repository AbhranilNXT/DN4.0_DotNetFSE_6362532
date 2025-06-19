package com.example;

class Tester {
    public static void main(String[] args) {
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        logger1.log("First message");
        logger2.log("Second message");

        System.out.println(
                "Are both instances same? " + ((logger1 == logger2) ? "Yes, singleton works" : "No, singleton failed"));
    }
}
