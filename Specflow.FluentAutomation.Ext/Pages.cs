using System;
using FluentAutomation;
using TechTalk.SpecFlow;

namespace Specflow.FluentAutomation.Ext
{
	public static class Pages
	{
		public static T Get<T>()
			where T : PageObject<T>
		{
			T page;
			if (!ScenarioContext.Current.TryGetValue(typeof(T).FullName, out page))
			{
				var currentTest = (FluentTest)ScenarioContext.Current[ScenarioContext.Current.ScenarioInfo.Title];
				page = (T)Activator.CreateInstance(typeof(T), currentTest);
				ScenarioContext.Current.Set(page, typeof(T).FullName);
			}

			return page;
		}

		public static void Set<T>(T page)
			where T : PageObject<T>
		{
			ScenarioContext.Current.Set(page, typeof(T).FullName);
		}
	}
}
