using System;
using Xunit;
using NameSortingApplication;
using System.IO;

namespace XUnitTestForNameSorting
{
    public class UT1TestPerson
    {
        [Fact]
        public void PersonObjectIsCreatedWithPrintName()
        {
            string TestData = "Cathy Ferguson";

            Person TestPerson = CreateTestPerson(TestData);
            string TestPersonPrintName = TestPerson.GetPrintName();

            Assert.True(TestPersonPrintName == TestData);
        }

        [Fact]
        public void PersonObjectIsCreatedWithSortName()
        {
            string TestData = "Cathy Ferguson";
            string AnswerData = "Ferguson Cathy";

            Person TestPerson = CreateTestPerson(TestData);
            string TestPersonSortName = TestPerson.GetSortName();

            Assert.True(TestPersonSortName == AnswerData);
        }




        // Create a test Person object from string
        public Person CreateTestPerson(string inName)
        {
            Person newPerson = new Person(inName);
            return newPerson;
        }
    }
}
