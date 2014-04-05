using BoDi;
using FluentAutomation.Generator.SpecflowPlugin.Providers;
using TechTalk.SpecFlow.Generator.Configuration;
using TechTalk.SpecFlow.Generator.Plugins;

namespace FluentAutomation.Generator.SpecflowPlugin
{
	public class FluentAutomationTestGenerator : IGeneratorPlugin
	{
		public void RegisterDependencies(ObjectContainer container)
		{
			container.RegisterTypeAs<NUnitTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>("nunit");
			container.RegisterTypeAs<MbUnitTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>("mbunit");
			container.RegisterTypeAs<MbUnit3TestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>("mbunit.3");
			container.RegisterTypeAs<XUnitTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>("xunit");
			container.RegisterTypeAs<MsTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>("mstest.2008");
			container.RegisterTypeAs<MsTest2010GeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>("mstest.2010");
			container.RegisterTypeAs<MsTest2010GeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>("mstest");
		}

		public void RegisterCustomizations(ObjectContainer container, SpecFlowProjectConfiguration generatorConfiguration)
		{
			
		}

		public void RegisterConfigurationDefaults(SpecFlowProjectConfiguration specFlowConfiguration)
		{
		}
	}
}
