using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First message");
        logger2.Log("Second message");

        Console.WriteLine("Are both instances same? " +
            (logger1 == logger2 ? "Yes, singleton works" : "No, singleton failed"));
    }
}