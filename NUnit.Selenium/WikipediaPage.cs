using FluentAutomation;

namespace NUnit.Selenium
{
	public class WikipediaPage : PageObject<WikipediaPage>
	{
		public WikipediaPage(FluentTest test) : base(test)
		{
			Url = "https://www.wikipedia.org/";
			At = () => I.Expect.Exists("title:contains('Wikipedia')");
		}
	}
}
