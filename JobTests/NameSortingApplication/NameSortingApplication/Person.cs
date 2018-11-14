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
     * "Person" class:  Template for creating objects which 
     * represent a single person (or name) in the provided data.
     * 
     * Fields:  
     * Print Name (string, name as per provided data and output)
     * Sort Name (string, rearranged to facilitate sorting)
     * 
     * Depends on: None
     * ------------------------------------------------------------
     */

    public class Person {

        /* private data fields */
        private string PrintName; // original/display name format
        private string SortName;  // modified name for sorting only


        /* -----------------------------------------
         * Person constructor
         * -----------------------------------------
         * as per specs, inputName must contain
         * one surname and at least one given name. 
         */
        public Person(string inputName) {
            PrintName = inputName;
            CreateSortName();
        }

        
        /* -----------------------------------
         * Getters (only) for private fields 
         */
        public string GetPrintName() {
            return PrintName;
        }
        public string GetSortName() {
            return SortName;
        }


        /* --------------------------------------------
         * Private method to split name into surname
         * and given name(s), and reverse the order,
         * to facilitate sorting by surname first, then
         * by given names. This is only called by the
         * constructor at instatiation of Person objects.
         */
        private void CreateSortName() {
            int DivPos = PrintName.LastIndexOf(" "); // find last space character
            string GivenNames = PrintName.Substring(0, DivPos); // given names are before it
            string SurName = PrintName.Substring(DivPos + 1); // surname is after it
            SortName = SurName + " " + GivenNames; // swap names and store
        }
    }
}
