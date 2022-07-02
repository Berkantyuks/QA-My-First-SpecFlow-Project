using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} : {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");
        }

        [Then(@"the result should ""([^""]*)""")]
        public void ThenTheResultShould(string result)
        {
            Console.WriteLine($"{nameof(ThenTheResultShould)} : {result}");
        }

        [Given(@"Input following numbers for the calculator")]
        public void GivenInputFollowingNumbersForTheCalculator(Table table)
        {

            dynamic datas = table.CreateDynamicSet();
            foreach (var item in datas)
            {
                Console.WriteLine($"The Number is {item.Numbers}");
            }
            
        }

        [Then(@"See result and details")]
        public void ThenSeeResultAndDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"The Number is {data.Result} with details {data.Details}");
        }



    }

}