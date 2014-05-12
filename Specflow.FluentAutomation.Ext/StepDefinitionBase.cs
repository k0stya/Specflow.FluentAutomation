using FluentAutomation;
using FluentAutomation.Interfaces;
using TechTalk.SpecFlow;

namespace Specflow.FluentAutomation.Ext
{
	public abstract class StepDefinitionBase
	{
		protected FluentTest CurrentTest
		{
			get { return (FluentTest) ScenarioContext.Current[ScenarioContext.Current.ScenarioInfo.Title]; }
		}

		protected INativeActionSyntaxProvider I
		{
			get { return CurrentTest.I; }
		}

		protected object Provider
		{
			get { return CurrentTest.Provider; }
		}

		protected FluentSession Session
		{
			get { return CurrentTest.Session; }
		}
	}
}
