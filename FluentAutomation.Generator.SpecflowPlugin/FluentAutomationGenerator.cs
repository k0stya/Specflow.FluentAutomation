using System.CodeDom;
using TechTalk.SpecFlow.Generator;

namespace FluentAutomation.Generator.SpecflowPlugin
{
	internal class FluentAutomationGenerator
	{
		internal static void ModifyGeneratedClass(TestClassGenerationContext generationContext)
		{
			AddBaseClass(generationContext);
			SaveTestClass(generationContext);
		}

		private static void SaveTestClass(TestClassGenerationContext generationContext)
		{
			generationContext.ScenarioInitializeMethod.Statements.Add(
				new CodeSnippetExpression("ScenarioContext.Current[ScenarioContext.Current.ScenarioInfo.Title] = this"));
        }

		private static void AddBaseClass(TestClassGenerationContext generationContext)
		{
			generationContext.TestClass.BaseTypes.Insert(0, new CodeTypeReference(typeof(FluentTest)));
		}
	}
}