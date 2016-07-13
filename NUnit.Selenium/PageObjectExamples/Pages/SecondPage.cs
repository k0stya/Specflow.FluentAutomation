using FluentAutomation;

namespace NUnit.Selenium
{
	public class SecondPage : PageObject<SecondPage>
	{
		private const string SecondPageDiv = "#imonthesecondpage";

		public SecondPage(FluentTest test) : base(test)
		{
			At = () => I.Expect.Exists(SecondPageDiv);
		}
	}
}
