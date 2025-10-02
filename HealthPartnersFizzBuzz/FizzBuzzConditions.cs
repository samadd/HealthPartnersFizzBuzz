namespace HealthPartnersFizzBuzz;

public class FizzBuzzConditions
{
    private static readonly Func<int, Func<int, bool>> Factor = (factor) => (number) => number % factor == 0;

    public bool Fizz(int number)
    {
        return Factor(3)(number);
    }

    public bool Buzz(int number)
    {
        return Factor(5)(number);
    }

    public bool FizzBuzz(int number)
    {
        return Fizz(number) && Buzz(number);
    }
}