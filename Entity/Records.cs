using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Records
    {
        private string studentID;
        private string bookID1;

        public string BookID1
        {
            get { return bookID1; }
            set { bookID1 = value; }
        }
        private string bookID2;

        public string BookID2
        {
            get { return bookID2; }
            set { bookID2 = value; }
        }
        private string bookID3;

        public string BookID3
        {
            get { return bookID3; }
            set { bookID3 = value; }
        }
        private string borrowDate;
        private string dueDate;

       public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
       
        public string BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }
        }
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
    }
}
