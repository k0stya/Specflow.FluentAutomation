using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Utils;

namespace FluentAutomation.Generator.SpecflowPlugin.Providers
{
	public class MsTestGeneratorProvider : TechTalk.SpecFlow.Generator.UnitTestProvider.MsTestGeneratorProvider
	{
		public MsTestGeneratorProvider(CodeDomHelper codeDomHelper)
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
