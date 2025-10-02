using System.Collections.Immutable;
using HealthPartnersFizzBuzz;

var inputs = Enumerable.Range(1, 100);

var conditions = new FizzBuzzConditions();
var fizzBuzzer = new FizzBuzzer()
    .AddCondition(conditions.FizzBuzz)
    .AddCondition(conditions.Fizz)
    .AddCondition(conditions.Buzz)
    .AddPresenter(new FizzBuzzTextPresenter(Console.WriteLine));

inputs.ToImmutableList().ForEach(number =>
{
    var answer = fizzBuzzer.Answer(number);
    fizzBuzzer.Present(answer);
});
