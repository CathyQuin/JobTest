using System;
using System.Collections.Generic;
using System.Text;

namespace NameSortingApplication {

    /* -----------------------------------------------------------
     * Author:  Cathryn Gaye Ferguson (Cathy)
     * Date:    12 November 2018
     * Client:  Globalx - Application for Software Engineer Role
     * -----------------------------------------------------------
     * "Person" class:  Template for creating objects which 
     * represent a single person in the provided data.
     * 
     * Fields:  
     * Print Name (string, name as per provided data)
     * Sort Name (string, rearranged to facilitate sorting)
     * ------------------------------------------------------------
     */

    public class Person {

        // variables to hold print name (in/out)
        //           and sort name (for sorting list)
        private string PrintName;
        private string SortName;


        // Person object constructor
        // parameter is the print name as a string
        public Person(string inputName) {
            PrintName = inputName;
            CreateSortName();
        }


        // 
        private void CreateSortName() {
            string TempName = PrintName;

            // rearrange tempname
            int DivPos = TempName.LastIndexOf(" ");
            string GivenNames = TempName.Substring(0, DivPos);
            string SurName = TempName.Substring(DivPos + 1);
            TempName = SurName + " " + GivenNames;

            SortName = TempName;
        }


        public string GetPrintName() {
            return PrintName;
        }

        public string GetSortName() {
            return SortName;
        } 
    }
}
