using Specflow.FluentAutomation.Ext;
using TechTalk.SpecFlow;

namespace NUnit.Selenium
{
    [Scope(Feature = "Plain testing")]
	[Binding]
	public class PlainSteps : StepDefinitionBase
	{
        [Given(@"I'm on the homepage")]
        public void GivenIMOnTheHomepage()
        {
            I.Open("http://localhost:9090/index.html");
        }

        [When(@"I click on the 2nd page link")]
        public void WhenIClickOnThe2NdPageLink()
        {
            I.Click("#page2");
        }

        [Then(@"I'm on the 2nd page")]
        public void ThenIMOnThe2NdPage()
        {
            I.Assert.Exists("#imonthesecondpage");
        }

    }
}
