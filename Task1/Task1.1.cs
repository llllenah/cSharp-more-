using System;

public class Program
{
    static int gcd(int firstNumber, int secondNumber){
       if (secondNumber == 0){
           return Math.Abs(firstNumber);
       }
       return gcd(secondNumber, firstNumber % secondNumber);
    }
    static int gcdOfThree(int firstNumber, int secondNumber, int thirdNumber){
        int gcdOfFirstAndSecond = gcd(firstNumber, secondNumber);
        return gcd(gcdOfFirstAndSecond, thirdNumber);
    }
    public static void Main()
    {
        Console.WriteLine("Введіть перше число");
        int firstNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введіть друге число");
        int secondNumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введіть третє число");
        int thirdNumber = int.Parse(Console.ReadLine());
        
        
        int gcd = gcdOfThree(firstNumber, secondNumber, thirdNumber);
        Console.WriteLine($"Найбільший спільний дільник = {gcd}");
    }
}

