using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(4)]
    public void GivenNumberReturnNumber(int input)
    {
        // a simple example to start you off
        Assert.AreEqual(input.ToString(), FizzBuzz.Answer(input));
    }
    
    [Test]
    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void GivenMultipleOfThreeReturnFizz(int input)
    {
        Assert.AreEqual("Fizz", FizzBuzz.Answer(input));
    }
    
    [Test]
    [TestCase(5)]
    [TestCase(25)]
    public void GivenMultipleOfFiveReturnBuzz(int input)
    {
        Assert.AreEqual("Buzz", FizzBuzz.Answer(input));
    }
    
    [Test]
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(60)]
    public void GivenMultipleOfThreeAndFiveReturnFizzBuzz(int input)
    {
        Assert.AreEqual("FizzBuzz", FizzBuzz.Answer(input));
    }
}
