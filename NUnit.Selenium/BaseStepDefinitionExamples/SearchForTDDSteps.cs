using Specflow.FluentAutomation.Ext;
using TechTalk.SpecFlow;

namespace NUnit.Selenium
{
	[Binding]
	public class SearchForTDDSteps : StepDefinitionBase
	{
		[Given(@"I have entered bing\.com")]
		public void GivenIHaveEnteredBing_Com()
		{
			I.Open("http://bing.com");
		}

		[When(@"I enter TDD to the search field")]
		public void WhenIEnterTDDToTheSearchField()
		{
			I.Enter("TDD").In("#sb_form_q");
		}

		[When(@"I press enter")]
		public void WhenIPressEnter()
		{
			I.Press("{ENTER}");
		}

		[Then(@"the first link should be wiki")]
		public void ThenTheFirstLinkShouldBeWiki()
		{
			I.Assert.Exists("a[href='http://en.wikipedia.org/wiki/Test-driven_development']");
		}
	}
}
