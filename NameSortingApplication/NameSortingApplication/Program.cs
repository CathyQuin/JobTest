using System;
using System.IO;

namespace NameSortingApplication
{
    /* -----------------------------------------------------------
     * Author:  Cathryn Gaye Ferguson (Cathy)
     * Date:    12 November 2018
     * Email:   quin.tuplet.72@gmail.com
     * Client:  Globalx - Application for Software Engineer Role
     * -----------------------------------------------------------
     * Main class:  Responsible for the overall process.  It 
     * creates the ListReader (which loads and sorts the data), 
     * retrieves the output data, and writes it to the text file
     * and console.  It waits for a keystroke before exiting.
     * 
     * Fields: 
     * File Locations (input and output), as strings
     * 
     * Depends on: ListReader class
     * ------------------------------------------------------------
     */

    class Program
    {

        // Main Program
        static void Main(string[] args) {

            /* file names/locations for input and output text files */
            string InputFileLocation = "./unsorted-names-list.txt";
            string OutputFileLocation = "./sorted-names-list.txt"; 

            try {

                /* Instantiate reader and retrieve output data */
                ListReader myListReader = new ListReader(InputFileLocation);
                string MyData = myListReader.OutputList();

                /* Write output to text file */
                StreamWriter sw = new StreamWriter(OutputFileLocation);
                sw.Write(MyData);
                sw.Close();

                /* Write output to console (and wait to exit) */
                Console.Write(MyData);
                Console.Write("\nPress any key to exit");
                Console.ReadKey();

            } catch(FileNotFoundException e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        } 
    }
}
