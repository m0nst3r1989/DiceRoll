using System;

public class Dice
{
    //this creates random numbers
    private static Random Num = new Random();
    private int diceSides;

    //creating a Diceside constructor 
    public Dice(int diceSides)
    {
        if (diceSides < 4 || diceSides > 20)
        {
            throw new ArgumentOutOfRangeException("Should be in the range of [4, 20] !");
        }
        this.diceSides = diceSides;
    }
    //creating a method tha returns the value of the number rolled
    public int rollDie()
    {
        return Num.Next(1, diceSides + 1);
    }
}

public class testRoll
{
    //This is the main method that will test dice roll
    public static void Main()
    {
        Dice num1 = new Dice(6);
        Dice num2 = new Dice(6);
        
        int num1Roll, num2Roll;
        int numOfRoll = 0;

        do
        {
            num1Roll = num1.rollDie();
            num2Roll = num2.rollDie();

            Console.WriteLine("Rolled [Dice 1: " + num1Roll + ", Dice 2: " + num2Roll + "]");

            ++numOfRoll;

        }while (num1Roll !=1 || num2Roll !=1);

        Console.WriteLine("\nIt took " + numOfRoll + "rolls to get snake eyes!");
    }
}