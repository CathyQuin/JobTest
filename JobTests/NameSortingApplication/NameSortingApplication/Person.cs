using System;
using System.Collections.Generic;
using System.Text;

namespace NameSortingApplication
{
    public class Person
    {

        // variables to hold print name (in/out)
        //               and sort name (for sorting list)
        private string PrintName { get; set; }
        private string SortName { get; set; }


        // Person object constructor
        // parameter is the print name as a string
        public Person(string inputName)
        {
            PrintName = inputName;
            CreateSortName();
        }


        // 
        private void CreateSortName()
        {
            string TempName = PrintName;

            // rearrange tempname - test data here now!!!


            TempName = "Ferguson Cathy";

            SortName = TempName;
        }

        public string GetPrintName()
        {
            return PrintName;
        }

        public string GetSortName()
        {
            return SortName;
        }
        
    }
}
