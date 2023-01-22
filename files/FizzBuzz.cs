using System;

public class FizzBuzz
{
    public static string Answer()
    {
        for(var i=1;i<=100;i++){
            Console.WriteLine(FizzBuzzSolver.Answer(i));
        }
    }
}

public class FizzBuzzSolver
{
    public static string Answer(int input)
    {
        if(input%3==0&&input%5==0){
            return "FizzBuzz";
        }
        if(input%3==0){
            return "Fizz";
        }
        if(input%5==0){
            return "Buzz";
        }
        return input.ToString();
    }
}
