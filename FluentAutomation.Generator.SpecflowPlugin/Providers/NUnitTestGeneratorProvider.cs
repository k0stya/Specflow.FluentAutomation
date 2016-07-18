using System.Diagnostics;
using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Utils;

namespace FluentAutomation.Generator.SpecflowPlugin.Providers
{
	public class 
        NUnitTestGeneratorProvider : TechTalk.SpecFlow.Generator.UnitTestProvider.NUnitTestGeneratorProvider
	{
		public NUnitTestGeneratorProvider(CodeDomHelper codeDomHelper)
			: base(codeDomHelper)
		{
		}

		public override void FinalizeTestClass(TestClassGenerationContext generationContext)
		{
            FluentAutomationGenerator.ModifyGeneratedClass(generationContext);
			base.FinalizeTestClass(generationContext);
		}
	}
}
