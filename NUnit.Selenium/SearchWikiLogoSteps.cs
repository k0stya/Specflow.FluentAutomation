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
			Pages.Get<SearchPage>().Go();
		}

		[Given(@"entered ""(.*)"" to the search box")]
		public void GivenEnteredToTheSearchBox(string searchText)
		{
			Pages.Get<SearchPage>().EnterSearchText(searchText);
		}

		[When(@"I click Images link")]
		public void WhenIClickImagesLink()
		{
			Pages.Get<SearchPage>().ClickImakesLink();
		}

		[Then(@"the resulting view should contain wiki logo")]
		public void ThenTheResultingViewShouldContainWikiLogo()
		{
			Pages.Get<SearchPage>().ShouldContainWikiLogo();
		}
	}
}
