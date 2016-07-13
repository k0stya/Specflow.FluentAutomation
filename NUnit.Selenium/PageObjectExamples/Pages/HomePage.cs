using FluentAutomation;

namespace NUnit.Selenium
{
	public class HomePage : PageObject<HomePage>
	{
	    private const string SecondPageLink = "#page2";

		public HomePage(FluentTest test) : base(test)
		{
			Url = "http://localhost:9090/index.html";
			At = () => I.Expect.Exists(SecondPageLink);
		}


	    public void ClickLinkToSecondPage()
	    {
	        I.Click(SecondPageLink);
	    }
	}
}
