using FluentAutomation;
using TechTalk.SpecFlow;

namespace NUnit.Selenium
{
	[Binding]
	public class GlobalHooks
	{
		[BeforeScenario]
		public void BeforeScenario()
		{
			SeleniumWebDriver.Bootstrap(
			   SeleniumWebDriver.Browser.Chrome
		   );
		}

		[AfterScenario]
		public void AfterScenario()
		{
		}
	}
}
