using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NameSortingApplication {

     public class ListReader {

        private StreamReader MyReader;
        private PersonList MyList;
        private string NewPerson;
        private string PrintListData;

        // "./unsorted-names-list.txt"

        public ListReader(string FileLocation) {
            MyReader = new StreamReader(FileLocation);
            InputList();
        }

        private void InputList() {
            MyList = new PersonList();

            while ((NewPerson = MyReader.ReadLine()) != null) {
                MyList.AddPerson(NewPerson);
            }

            MyList.SortList();
        }

        public string OutputList() {
            PrintListData = MyList.PrintList();
            return PrintListData;
        }



    }
}
