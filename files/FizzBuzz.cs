public class FizzBuzz
{
    public static string Answer(int input)
    {
        if(input%3==0&&input%5==0){
            return "FizzBuzz";
        }
        return input.ToString();
    }
}
