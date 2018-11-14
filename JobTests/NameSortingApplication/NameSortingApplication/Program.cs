using System;
using System.IO;

namespace NameSortingApplication
{
    class Program
    {

        // Main
        static void Main(string[] args) {

            string InputFileLocation = "../../../unsorted-names-list.txt";
            string OutputFileLocation = "../../../sorted-names-list.txt";
            string MyData = "";

            ListReader myListReader = new ListReader(InputFileLocation);
            MyData = myListReader.OutputList();

            StreamWriter sw = new StreamWriter(OutputFileLocation);
            sw.Write(MyData);
            sw.Close();

            Console.Write(MyData); // output to console
            Console.Write("\nPress any key to exit");
            Console.ReadKey();

        } 
    }
}
