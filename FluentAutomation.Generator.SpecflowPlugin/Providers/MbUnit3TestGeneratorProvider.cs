using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Utils;

namespace FluentAutomation.Generator.SpecflowPlugin.Providers
{
	public class MbUnit3TestGeneratorProvider: TechTalk.SpecFlow.Generator.UnitTestProvider.MbUnit3TestGeneratorProvider
	{
		public MbUnit3TestGeneratorProvider(CodeDomHelper codeDomHelper) : base(codeDomHelper)
		{
		}

		public override void FinalizeTestClass(TestClassGenerationContext generationContext)
		{
			FluentAutomationGenerator.ModifyGeneratedClass(generationContext);
			base.FinalizeTestClass(generationContext);
		}
	}
}
