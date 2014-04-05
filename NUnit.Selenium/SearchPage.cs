using FluentAutomation;

namespace NUnit.Selenium
{
	public class SearchPage : PageObject<SearchPage>
	{
		private const string SearchTextBox = "#gbqfq";
		private const string SearchButton = "#gsr";

		public SearchPage(FluentTest test) : base(test)
		{
			Url = "http://google.com";
			At = () => I.Expect.Exists(SearchTextBox);
		}

		public void EnterSearchText(string searchText)
		{
			I.Enter(searchText).In(SearchTextBox);
		}

		public void ClickSearchButton()
		{
			I.Click(SearchButton);
		}

		public void ShouldContainWikiLogo()
		{
			I.Expect.Text("Wiki Logo");
		}
	}
}
