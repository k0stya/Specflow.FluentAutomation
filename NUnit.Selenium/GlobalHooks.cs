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
		        SeleniumWebDriver.Browser.Firefox
		        );
		}

		[AfterScenario]
		public void AfterScenario()
		{
		}
	}
}
