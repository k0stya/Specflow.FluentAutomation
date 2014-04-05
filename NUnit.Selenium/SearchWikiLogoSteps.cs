using System;
using FluentAutomation;
using Specflow.FluentAutomation.Ext;
using TechTalk.SpecFlow;

namespace NUnit.Selenium
{
	[Binding]
	public class SearchWikiLogoSteps
	{
		[Given(@"I navigated google")]
		public void GivenINavigatedGoogle()
		{
			SeleniumWebDriver.Bootstrap(
			   SeleniumWebDriver.Browser.Chrome
		   );

			Pages.Get<SearchPage>().Go();
		}

		[Given(@"entered ""(.*)"" to the search box")]
		public void GivenEnteredToTheSearchBox(string p0)
		{
			Pages.Get<SearchPage>().EnterSearchText(p0);
		}

		[When(@"I click Images link")]
		public void WhenIClickImagesLink()
		{
			Pages.Get<SearchPage>().ClickSearchButton();
		}

		[Then(@"the resulting view should contain wiki logo")]
		public void ThenTheResultingViewShouldContainWikiLogo()
		{
			Pages.Get<SearchPage>().ShouldContainWikiLogo();
		}
	}
}
