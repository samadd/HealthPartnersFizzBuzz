namespace HealthPartnersUnitTests;
using System;
using HealthPartnersFizzBuzz;

[TestFixture]
public class FizzBuzzTextPresenterTests
{
    [Test]
    public void FizzBuzzTextPresenterCreatesWithTextAction()
    {
        void StubAction(string str)
        {
        }
        Assert.DoesNotThrow(() => new FizzBuzzTextPresenter(StubAction));
    }
        
    [Test]
    public void FizzBuzzTextPresenterThrowsWithoutTextAction()
    {
        void StubAction(int val)
        {
        }
        var type = typeof(FizzBuzzTextPresenter);
        Assert.Throws<MissingMethodException>(() =>
            Activator.CreateInstance(type, StubAction));
    }

    [Test]
    public void FizzBuzzTextPresenterPresentsText()
    {
        void StubAction(string str)
        {
            Assert.Pass();
        }
        var presenter = new FizzBuzzTextPresenter(StubAction);
        presenter.Present("Fizz");
    }
        
    [Test]
    public void FizzBuzzTextPresenterThrowsWhenNoText()
    {
        void StubAction(string str)
        {
            Assert.Fail();
        }
        var presenter = new FizzBuzzTextPresenter(StubAction);
        String emptyParam = null;
        Assert.Catch(() => presenter.Present(emptyParam));
    }

    [Test]
    public void FizzBuzzTextPresenterPresentsNonTextType()
    {
        void StubAction(string str)
        {
            Assert.Pass();
        }
        var presenter = new FizzBuzzTextPresenter(StubAction);
        presenter.Present(new DateTime());
    }
}