using Specflow.FluentAutomation.Ext;
using TechTalk.SpecFlow;

namespace NUnit.Selenium
{
	[Binding]
	public class SearchForWikiSteps
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

		[When(@"I click wiki link")]
		public void WhenIClickWikiLink()
		{
			var wikiPage = Pages.Get<SearchPage>().ClickOnWikiLink();
			Pages.Set(wikiPage);
		}

		[Then(@"the resulting view should contain wiki logo")]
		public void ThenTheResultingViewShouldContainWikiLogo()
		{
			Pages.Get<SearchPage>().ShouldContainWikiLogo();
		}

		[Then(@"the resulting page should be wikipedia")]
		public void ThenTheResultingPageShouldBeWikipedia()
		{
			Pages.Get<WikipediaPage>().At();
		}
	}
}
