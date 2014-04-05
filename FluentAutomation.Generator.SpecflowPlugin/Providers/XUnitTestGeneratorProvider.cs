using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Utils;

namespace FluentAutomation.Generator.SpecflowPlugin.Providers
{
	public class XUnitTestGeneratorProvider : TechTalk.SpecFlow.Generator.UnitTestProvider.XUnitTestGeneratorProvider
	{
		public XUnitTestGeneratorProvider(CodeDomHelper codeDomHelper) : base(codeDomHelper)
		{
		}

		public override void FinalizeTestClass(TestClassGenerationContext generationContext)
		{
			FluentAutomationGenerator.ModifyGeneratedClass(generationContext);
			base.FinalizeTestClass(generationContext);
		}
	}
}
