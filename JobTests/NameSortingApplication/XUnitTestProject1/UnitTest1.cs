using System;
using Xunit;
using NameSortingApplication;

namespace XUnitTestForNameSorting {

    /* Testing Person class */
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

    /* Testing PersonList class */
    public class UT2TestPersonList {

        [Fact]
        public void ListObjectIsCreated() {

            PersonList TestList = new PersonList();
            int tempNum = TestList.Count();
            Assert.True(tempNum == 0); 
        }

        [Fact]
        public void ListObjectHasOneRecord() {

            PersonList TestList = new PersonList();
            string TestData1 = "Lady Madonna";
            TestList.AddPerson(TestData1);

            Assert.True(TestList.GetPersonPrintName(0) == TestData1);
        } 

        [Fact]
        public void ListObjectIsSorted() {
            PersonList TestList = new PersonList();

            string TestData1 = "Lady Madonna";
            string TestData2 = "Joe Andrew Smith";
            string TestData3 = "Apple Fruitcake";
            string TestData4 = "Lumpy Lumbah";
            string TestData5 = "Donny Dumbo";

            TestList.AddPerson(TestData1);
            TestList.AddPerson(TestData2);
            TestList.AddPerson(TestData3);
            TestList.AddPerson(TestData4);
            TestList.AddPerson(TestData5);

            TestList.SortList();

            Assert.True(TestList.GetPersonPrintName(0) == TestData5); // Dumbo, Donny
            Assert.True(TestList.GetPersonPrintName(1) == TestData3); // Fruitcake, Apple
            Assert.True(TestList.GetPersonPrintName(2) == TestData4); // Lumbah, Lumpy
            Assert.True(TestList.GetPersonPrintName(3) == TestData1); // Madonna, Lady
            Assert.True(TestList.GetPersonPrintName(4) == TestData2); // Smith, Joe Andrew

        }


    }

}
