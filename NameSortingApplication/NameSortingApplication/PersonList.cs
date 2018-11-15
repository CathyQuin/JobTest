using System;
using System.Collections.Generic;
using System.Text;

namespace NameSortingApplication {

    /* -----------------------------------------------------------
     * Author:  Cathryn Gaye Ferguson (Cathy)
     * Date:    12 November 2018
     * Email:   quin.tuplet.72@gmail.com
     * Client:  Globalx - Application for Software Engineer Role
     * -----------------------------------------------------------
     * "Person List" class:  Template for creating a list of Person 
     * objects which are sorted in alphabetical order by Sort Name.
     * 
     * Object: My List (List<T>, where <T> is Person objects).
     * 
     * Depends on: Person class
     * ------------------------------------------------------------
     */

    public class PersonList {

        /* private object */
        private List<Person> MyList;


       /* -----------------------
        * PersonList constructor
        * ------------------------
        * Instantiates object with empty
        * List of Person objects.
        */
        public PersonList() {
            MyList = new List<Person>();
        }


        /* -----------------------------------
         * Getters to access functions and
         * attributes of the private List.
         * These are only used within this 
         * class or for unit testing.
         */
        
        /* returns count of list items */
        public int Count() { 
            return MyList.Count;
        }
        
        /* returns the Print Name of a list item by index */
        public string GetPersonPrintName(int inIndex) {
            return MyList[inIndex].GetPrintName();
        }


        /* ------------------------------------------
         * Modifiers to manipulate private List data
         */
        
        /* Adds new Person to List using parameter as Print Name */
        public void AddPerson(string inputName) {
            Person newPerson = new Person(inputName);
            MyList.Add(newPerson);
        }

        /* Sorts List alphabetically by Sort Name */
        public void SortList() {
            
            // I got this piece of code off the interwebz :)
            MyList.Sort(delegate (Person a, Person b) {
                return a.GetSortName().CompareTo(b.GetSortName());
            });
        }


        /* -----------------------------------------------
         * Outputs the complete List of Person data as a 
         * string with Print Names separated by line breaks.
         * This string can be used for any output process.
         */
        public string PrintList() {

            string PrintList = "";
            int PersonCount = Count();

            for (int i = 0; i < PersonCount; i++) {
                PrintList += GetPersonPrintName(i) + "\n";
            }

            return PrintList;
        }
    }
}
