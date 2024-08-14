using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        [Test]
        public void isNameInListTrue()
        {
            // Set up
            CohortManager core = new CohortManager();
            List<string> cohorts = new List<string>();
            cohorts.Add("A");
            cohorts.Add("B");
            cohorts.Add("C");
            string cohortName = "A";

            // Execute
            bool result = core.search(cohorts, cohortName);

            //Verify
            Assert.That(result, Is.True);

        }

        [Test]
        public void isNameInListFalse()
        {

            // Set up
            CohortManager core = new CohortManager();
            List<string> cohorts = new List<string>();
            cohorts.Add("A");
            cohorts.Add("B");
            cohorts.Add("C");
            string cohortName = "D";

            // Execute
            bool result = core.search(cohorts, cohortName);

            //Verify
            Assert.That(result, Is.False);
        }
    }
}