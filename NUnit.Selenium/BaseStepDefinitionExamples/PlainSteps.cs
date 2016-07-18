using System.IO;
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
            var currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var uri = string.Format("{0}\\testPages\\index.html", currentPath);
            I.Open(uri);
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
