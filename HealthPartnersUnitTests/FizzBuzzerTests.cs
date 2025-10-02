namespace HealthPartnersUnitTests;
using HealthPartnersFizzBuzz;

public class MockConditions
{
    public bool TestFizz(int number)
    {
        return number % 3 == 0;
    }

    public bool TestBuzz(int number)
    {
        return number % 5 == 0;
    }

    public bool TestFizzBuzz(int number)
    {
        return TestFizz(number) && TestBuzz(number);
    }
}

[TestFixture]
public class FizzBuzzerTests
{
    private FizzBuzzer fizzBuzzer;
    private MockConditions mockConditions;
    [SetUp]
    public void Setup()
    {
        fizzBuzzer = new FizzBuzzer();
        mockConditions = new MockConditions();
    }
    
    [Test]
    public void FizzBuzzerAnswersNumberWhenNoConditions()
    {
        var answer = fizzBuzzer.Answer(3);
        Assert.That(answer, Is.EqualTo(3));
    }
    
    [Test]
    public void FizzBuzzerAnswersNumberWhenConditionsDoNotObtain()
    {
        var answer = fizzBuzzer.Answer(2);
        Assert.That(answer, Is.EqualTo(2));
    }
    
    [Test]
    public void FizzBuzzerAnswersStringWhenConditionsDoObtain()
    {
        fizzBuzzer.AddCondition(mockConditions.TestFizz);
        var answer = fizzBuzzer.Answer(3);
        Assert.That(answer, Is.EqualTo("TestFizz"));
    }

    [Test]
    public void FizzBuzzerAnswersCorrectStringWhenCompoundConditionsObtain()
    {
        fizzBuzzer.AddCondition(mockConditions.TestFizzBuzz);
        fizzBuzzer.AddCondition(mockConditions.TestFizz);
        fizzBuzzer.AddCondition(mockConditions.TestBuzz);
        var answer = fizzBuzzer.Answer(15);
        Assert.That(answer, Is.EqualTo("TestFizzBuzz"));
    }
    
    [Test]
    public void FizzBuzzerAnswersCorrectStringGivenSpecifiedOrder()
    {
        fizzBuzzer.AddCondition(mockConditions.TestFizz);
        fizzBuzzer.AddCondition(mockConditions.TestFizzBuzz);
        fizzBuzzer.AddCondition(mockConditions.TestBuzz);
        var answer = fizzBuzzer.Answer(15);
        Assert.That(answer, Is.EqualTo("TestFizz"));
    }
}