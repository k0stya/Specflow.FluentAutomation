using Specflow.FluentAutomation.Ext;
using TechTalk.SpecFlow;

namespace NUnit.Selenium
{
	[Scope(Feature = "Testing with page objects")]
	[Binding]
	public class PageObjectSteps
	{

		[Given(@"I'm on the homepage")]
		public void GivenIMOnTheHomepage()
		{
			Pages.Get<HomePage>().Go();
		}
		
		[When(@"I click on the 2nd page link")]
		public void WhenIClickOnThe2NdPageLink()
		{
			Pages.Get<HomePage>().ClickLinkToSecondPage();
		}
		
		[Then(@"I'm on the 2nd page")]
		public void ThenIMOnThe2NdPage()
		{
			Pages.Get<SecondPage>().At();
		}
	}
}
