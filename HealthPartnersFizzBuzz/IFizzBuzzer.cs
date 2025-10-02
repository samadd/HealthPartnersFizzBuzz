namespace HealthPartnersFizzBuzz;

public interface IFizzBuzzer
{
    public object Answer(int number);
    public void Present(object value);
    public IFizzBuzzer AddCondition(Func<int, bool> condition);
    public IFizzBuzzer AddPresenter(IFizzBuzzPresenter presenter);
}