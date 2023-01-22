public class Program{
    public static void Main()
    {
        Console.WriteLine("lol");
    }
}

public class FizzBuzz
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
