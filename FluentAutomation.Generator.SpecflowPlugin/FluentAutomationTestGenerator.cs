using System;
using TechTalk.SpecFlow.Generator.Plugins;
using FluentAutomation.Generator.SpecflowPlugin.Providers;


namespace FluentAutomation.Generator.SpecflowPlugin
{
	public class FluentAutomationTestGenerator : IGeneratorPlugin
	{
		public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters)
		{
			generatorPluginEvents.CustomizeDependencies += this.GeneratorPluginEventsOnCustomizeDependencies;
		}
		
		private void GeneratorPluginEventsOnCustomizeDependencies(object sender, CustomizeDependenciesEventArgs customizeDependenciesEventArgs)
		{
			string unitTestProviderName = customizeDependenciesEventArgs.SpecFlowProjectConfiguration.GeneratorConfiguration.GeneratorUnitTestProvider;
			unitTestProviderName = unitTestProviderName.ToLower();
			
			switch (unitTestProviderName)
			{
				case "nunit":
				{
					customizeDependenciesEventArgs.ObjectContainer
						.RegisterTypeAs<NUnitTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>();
					break;
				}
				case "mbunit":
				{
					customizeDependenciesEventArgs.ObjectContainer
						.RegisterTypeAs<MbUnitTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>();
					break;
				}
				
				case "mbunit.3":
				{
					customizeDependenciesEventArgs.ObjectContainer
						.RegisterTypeAs<MbUnit3TestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>();
					break;
				}
				
				case "xunit":
				{
					customizeDependenciesEventArgs.ObjectContainer
						.RegisterTypeAs<XUnitTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>();
					break;
				}
				case "mstest.2008":
				{
					customizeDependenciesEventArgs.ObjectContainer
						.RegisterTypeAs<MsTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>();
					break;
				}
				case "mstest.2010":
				{
					customizeDependenciesEventArgs.ObjectContainer
						.RegisterTypeAs<MsTest2010GeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>();
					break;
				}
				case "mstest":
				{
					customizeDependenciesEventArgs.ObjectContainer
						.RegisterTypeAs<MsTestGeneratorProvider, TechTalk.SpecFlow.Generator.UnitTestProvider.IUnitTestGeneratorProvider>();
					break;
				}
				default:
				{
					throw new NotImplementedException(String.Format("Unsupported unit test provider: {0}", unitTestProviderName)); 
				}
			}
		
		}
	}
}
