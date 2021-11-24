using TechTalk.SpecFlow;
using Xunit;

namespace Test.Spec.Steps
{

    public class Numbers
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Sum { get; set; }
    }

    [Binding]
    public sealed class CalculatorStepDefinitions
    {

       // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       private readonly ScenarioContext _scenarioContext;
       private Numbers _numbers;

       public CalculatorStepDefinitions(ScenarioContext scenarioContext)
       {
           _scenarioContext = scenarioContext;

           _numbers = new Numbers();
       }

       [Given("the first number is (.*)")]
       public void GivenTheFirstNumberIs(int number)
       {
           //TODO: implement arrange (precondition) logic
           // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
           // To use the multiline text or the table argument of the scenario,
           // additional string/Table parameters can be defined on the step definition
           // method.

            _numbers.First = number;
       }

       [Given("the second number is (.*)")]
       public void GivenTheSecondNumberIs(int number)
       {
           //TODO: implement arrange (precondition) logic
           // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
           // To use the multiline text or the table argument of the scenario,
           // additional string/Table parameters can be defined on the step definition
           // method.

           _numbers.Second = number;
        }

       [When("the two numbers are added")]
       public void WhenTheTwoNumbersAreAdded()
       {
           //TODO: implement act (action) logic

           _numbers.Sum = _numbers.First + _numbers.Second;
       }

       [Then("the result should be (.*)")]
       public void ThenTheResultShouldBe(int result)
       {
           Assert.Equal(_numbers.Sum, result);
       }
    }
}
