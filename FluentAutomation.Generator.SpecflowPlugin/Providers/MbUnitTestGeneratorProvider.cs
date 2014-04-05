using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Utils;

namespace FluentAutomation.Generator.SpecflowPlugin.Providers
{
	public class MbUnitTestGeneratorProvider : TechTalk.SpecFlow.Generator.UnitTestProvider.MbUnitTestGeneratorProvider
	{
		public MbUnitTestGeneratorProvider(CodeDomHelper codeDomHelper) : base(codeDomHelper)
		{
		}

		public override void FinalizeTestClass(TestClassGenerationContext generationContext)
		{
			FluentAutomationGenerator.ModifyGeneratedClass(generationContext);
			base.FinalizeTestClass(generationContext);
		}
	}
}
