using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [Test]
    public void GivenMultipleOfThreeReturnFizz()
    {
        // a simple example to start you off
        Assert.AreEqual("Fizz", FizzBuzz.Answer());
    }
    
    [Test]
    public void GivenMultipleOfFiveReturnBuzz()
    {
        // a simple example to start you off
        Assert.AreEqual("Buzz", FizzBuzz.Answer());
    }
    
    [Test]
    public void GivenMultipleOfThreeAndFiveReturnFizzBuzz()
    {
        // a simple example to start you off
        Assert.AreEqual("FizzBuzz", FizzBuzz.Answer());
    }
}
