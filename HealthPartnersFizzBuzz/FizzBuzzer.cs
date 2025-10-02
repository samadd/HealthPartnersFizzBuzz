namespace HealthPartnersFizzBuzz;
using System.Reflection;

public class FizzBuzzer: IFizzBuzzer
{
    private readonly List<Tuple<string, Func<int, bool>>> _conditions = new List<Tuple<string, Func<int, bool>>>();
    private readonly List<IFizzBuzzPresenter> _presenters = new List<IFizzBuzzPresenter>();
    public IFizzBuzzer AddCondition(Func<int, bool> condition)
    {
        var funcName = condition.GetMethodInfo().Name;
        _conditions.Add(new Tuple<string, Func<int, bool>> (funcName, condition));
        return this;
    }

    public IFizzBuzzer AddPresenter(IFizzBuzzPresenter presenter)
    {
        _presenters.Add(presenter);
        return this;
    }

    public object Answer(int number)
    {
        foreach (var condition in _conditions)
        {
            if (condition.Item2(number))
            {
                return condition.Item1;
            }
        }

        return number;
    }

    public void Present(object value)
    {
        _presenters.ForEach(presenter => presenter.Present(value));
    }
}
