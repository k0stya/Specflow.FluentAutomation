using TechTalk.SpecFlow.Generator;
using TechTalk.SpecFlow.Utils;

namespace FluentAutomation.Generator.SpecflowPlugin.Providers
{
	public class MsTest2010GeneratorProvider : TechTalk.SpecFlow.Generator.UnitTestProvider.MsTest2010GeneratorProvider
	{
		public MsTest2010GeneratorProvider(CodeDomHelper codeDomHelper)
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
