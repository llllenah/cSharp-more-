using System;

public class Program
{
    static bool IsPrime(int number){
       if (number <= 1){
           return false;
       }
       for (int i = 2; i * i <= number; i++){
           if (number % i == 0){
               return false;
           }
       }
       return true;
    }
    static int theNearestPrime(int number){
        for (int i = 1; i < number; i++){
            if (IsPrime(number+i)){
                return number + i;
            }
            else if(IsPrime(number-i)){
                return number - i;
            }
        }
        return 2;
    }
    public static void Main()
    {
        Console.WriteLine("Введіть число");
        int number = int.Parse(Console.ReadLine());
        
        int theClosestPrime = theNearestPrime(number);
        Console.WriteLine($"Найближче просте число = {theClosestPrime}");
    }
}
