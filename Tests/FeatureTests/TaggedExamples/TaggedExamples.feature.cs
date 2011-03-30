// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.FeatureTests.TaggedExamples
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Tagging Scenario Outline Examples")]
    public partial class TaggingScenarioOutlineExamplesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TaggedExamples.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tagging Scenario Outline Examples", "As a developer\r\nI would like to be able to tag examples of the scenario outline\r\n" +
                    "So that I can write bindings that behave differently for the variants", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Examples can be tagged")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        [NUnit.Framework.TestCaseAttribute("variant in non-tagged examples", "", new string[0])]
        [NUnit.Framework.TestCaseAttribute("variant in tagged examples", "examples_tag", new string[] {
                "examples_tag"})]
        public virtual void ExamplesCanBeTagged(string variant, string tag, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Examples can be tagged", System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(new string[] {
                                "tag1"}, exampleTags)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("I have a templated step for {0}", variant));
#line 9
 testRunner.When(string.Format("I tag the examples with tag {0}", tag));
#line 10
 testRunner.Then(string.Format("the execution should be scoped with tag {0}", tag));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Examples can be ignored")]
        [NUnit.Framework.CategoryAttribute("buildserver_exclude")]
        [NUnit.Framework.TestCaseAttribute("ignored variant", new string[0], Ignored=true)]
        public virtual void ExamplesCanBeIgnored(string variant, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Examples can be ignored", System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(new string[] {
                                "buildserver_exclude"}, exampleTags)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("I have invalid step");
#line 24
 testRunner.When("I tag the examples with @ignore");
#line 25
 testRunner.Then("the execution should be ignored");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
