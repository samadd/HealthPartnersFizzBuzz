namespace HealthPartnersUnitTests;

using HealthPartnersFizzBuzz;

[TestFixture]
public class FizzBuzzConditionsTests
{
    private FizzBuzzConditions _fizzBuzzConditions;
    [SetUp]
    public void Setup()
    {
        _fizzBuzzConditions = new FizzBuzzConditions();
    }

    [Test]
    public void IdentifiesNonFizz()
    {
        var results = new List<int>() { 1, 2, 4, 5 }.Select(v => _fizzBuzzConditions.Fizz(v));
        Assert.That(results, Is.All.False);
    }
    
    [Test]
    public void IdentifiesFizz()
    {
        var results = new List<int>() { 3, 6, 9, 12, 15 }.Select(v => _fizzBuzzConditions.Fizz(v));
        Assert.That(results, Is.All.True);
    }
    
    [Test]
    public void IdentifiesNonBuzz()
    {
        var results = new List<int>() { 1, 2, 4, 6 }.Select(v => _fizzBuzzConditions.Buzz(v));
        Assert.That(results, Is.All.False);
    }
    
    [Test]
    public void IdentifiesBuzz()
    {
        var results = new List<int>() { 5, 10, 15, 20 }.Select(v => _fizzBuzzConditions.Buzz(v));
        Assert.That(results, Is.All.True);
    }
    
    [Test]
    public void IdentifiesNonFizzBuzz()
    {
        var results = new List<int>() { 1, 2, 3, 4, 5, 6 }.Select(v => _fizzBuzzConditions.FizzBuzz(v));
        Assert.That(results, Is.All.False);
    }
    
    [Test]
    public void IdentifiesFizzBuzz()
    {
        var results = new List<int>() { 15, 30, 45 }.Select(v => _fizzBuzzConditions.FizzBuzz(v));
        Assert.That(results, Is.All.True);
    }
    
}