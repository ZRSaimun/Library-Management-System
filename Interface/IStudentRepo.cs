using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   public interface IStudentRepo
    {
       bool InsertStudent(Student student, byte[] images);
       Student GetStudent(string id);
       List<Student> GetAllStudent();
       bool UpdateStudentBorrow(string studentID, int copies);
       bool InsertRecords(Student student);
       bool UpdateStudent(Student student);
       bool RemoveStudent(string studentId);
    }
}
