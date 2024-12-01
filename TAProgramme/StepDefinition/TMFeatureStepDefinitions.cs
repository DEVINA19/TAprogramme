using System;
using TechTalk.SpecFlow;

namespace TAProgramme.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"I logged into Turnup Portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to Time and Material Page]")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a Time Record")]
        public void WhenICreateATimeRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
