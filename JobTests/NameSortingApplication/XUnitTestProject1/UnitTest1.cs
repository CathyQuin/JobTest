using System;
using Xunit;
using NameSortingApplication;
using System.IO;

namespace XUnitTestForNameSorting {
    public class UT1TestPerson {

        [Fact]
        public void PersonObjectIsCreatedWithPrintName() {

            string TestData = "Cathy Ferguson";

            Person TestPerson = new Person(TestData);
            Assert.True(TestPerson.GetPrintName() == TestData);
        }

        [Fact]
        public void PersonObjectIsCreatedWithSortName() {

            string TestData = "Cathryn Gaye Ferguson";
            string AnswerData = "Ferguson Cathryn Gaye";

            Person TestPerson = new Person(TestData);
            Assert.True(TestPerson.GetSortName() == AnswerData);
        }
    }

    public class UT2TestPersonList {

        [Fact]
        public void ListObjectIsCreated() {

            PersonList TestList = new PersonList();
            string TestData1 = "Lady Madonna";
            string TestData2 = "Joe Andrew Smith";
            string TestData5 = "Donny Dumbo";

            TestList.AddPerson(TestData1);
            TestList.AddPerson(TestData2);
            //TestList.AddPerson("Apple Fruitcake");
            //TestList.AddPerson("Lumpy Lumbah");
            TestList.AddPerson(TestData5);

            TestList.SortList();

            //TestList.PrintList();

            Assert.True(TestList[0].GetPrintName() == "Donny Dumbo");



        }


    }

}
