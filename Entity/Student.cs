using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {

        private byte[] image;

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }


        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }



        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string dept;

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        private string year;

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        private int due;

        public int Due
        {
            get { return due; }
            set { due = value; }
        }
        private int borrowed;

        public int Borrowed
        {
            get { return borrowed; }
            set { borrowed = value; }
        }



    }
}
