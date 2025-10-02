namespace HealthPartnersFizzBuzz;

public class FizzBuzzer: IFizzBuzzer
{
    private readonly List<Tuple<string, Func<int, bool>>> _conditions = new List<Tuple<string, Func<int, bool>>>();
    private readonly List<IFizzBuzzPresenter> _presenters = new List<IFizzBuzzPresenter>();
    public IFizzBuzzer AddCondition(Func<int, bool> condition)
    {
        return this;
    }

    public IFizzBuzzer AddPresenter(IFizzBuzzPresenter presenter)
    {
        return this;
    }

    public object Answer(int number)
    {
        throw new NotImplementedException();
    }

    public void Present(object value)
    {
        throw new NotImplementedException();
    }
}