using System.IO;
using FluentAutomation;

namespace NUnit.Selenium
{
	public class HomePage : PageObject<HomePage>
	{
		private const string SecondPageLink = "#page2";

		public HomePage(FluentTest test) : base(test)
		{
			var currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
			var uri = string.Format("{0}\\testPages\\index.html", currentPath);
			Url = uri;
			At = () => I.Expect.Exists(SecondPageLink);
		}

		public void ClickLinkToSecondPage()
		{
			I.Click(SecondPageLink);
		}
	}
}
