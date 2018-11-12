using System;
using System.Collections.Generic;
using System.Text;

namespace NameSortingApplication {

    /* -----------------------------------------------------------
     * Author:  Cathryn Gaye Ferguson (Cathy)
     * Date:    12 November 2018
     * Client:  Globalx - Application for Software Engineer Role
     * -----------------------------------------------------------
     * "Person List" class:  Template for creating lists of Person 
     * objects which are sorted in alphabetical order by surname
     * then given name(s).
     * 
     * Fields:  
     * 
     * ------------------------------------------------------------
     */

    public class PersonList : List<Person>{

        private List<Person> MyList;

        public PersonList() {
            MyList = new List<Person>();
        }

        public void AddPerson(string inputName) {
            MyList.Add(new Person(inputName));
        }

        public void SortList() {
            MyList.Sort(delegate (Person a, Person b) {
                return a.GetSortName().CompareTo(b.GetSortName());
            });
        }

        public void PrintList() {
            Console.WriteLine(MyList[0].GetPrintName());
            Console.WriteLine(MyList[1].GetPrintName());
            Console.WriteLine(MyList[2].GetPrintName());
        }
    }
}
