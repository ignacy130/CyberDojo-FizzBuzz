using NUnit.Framework;

[TestFixture]
public class HikerTest
{
    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(4)]
    [TestCase(0)]
    public void GivenNumberReturnNumber()
    {
        // a simple example to start you off
        Assert.AreEqual("1", FizzBuzz.Answer(1));
    }
    
    [Test]
    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void GivenMultipleOfThreeReturnFizz()
    {
        // a simple example to start you off
        Assert.AreEqual("Fizz", FizzBuzz.Answer());
    }
    
    [Test]
    [TestCase(5)]
    [TestCase(25)]
    public void GivenMultipleOfFiveReturnBuzz()
    {
        // a simple example to start you off
        Assert.AreEqual("Buzz", FizzBuzz.Answer());
    }
    
    [Test]
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(60)]
    public void GivenMultipleOfThreeAndFiveReturnFizzBuzz()
    {
        // a simple example to start you off
        Assert.AreEqual("FizzBuzz", FizzBuzz.Answer());
    }
}
