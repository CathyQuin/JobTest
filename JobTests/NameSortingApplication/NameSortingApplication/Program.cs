using System;

namespace NameSortingApplication
{
    class Program
    {

        // Main
        static void Main(string[] args)
        {
            // Just checking all is well - delete last!
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Real start of program
            //string FileLocation = "C:/Users/Cathy/source/repos/JobTests/NameSortingApplication/NameSortingApplication/unsorted-names-list.txt";
            string FileLocation = "../../../unsorted-names-list.txt";
            string MyData = "";

            ListReader myListReader = new ListReader(FileLocation);
            MyData = myListReader.OutputList();

            Console.Write(MyData); // output to console
            // TODO - write data to txt file

            Console.ReadKey();

        } 
    }
}
