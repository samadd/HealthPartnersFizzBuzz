namespace HealthPartnersFizzBuzz;

public class FizzBuzzTextPresenter(Action<string> action) : IFizzBuzzPresenter
{
    public void Present(object value)
    {
        var presentValue = value?.ToString();
        if (presentValue == null)
        {
            throw new ArgumentNullException("presentValue");
        }
        action.Invoke(presentValue);
    }
}
