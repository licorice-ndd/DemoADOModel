using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModel.Models
{
    class Student
    { 
        public int StudentID { get; set; }
        public string RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }


        public Student(int studentID, string rollNumber, string firstName, string lastName, string midName)
        {
            StudentID = studentID;
            RollNumber = rollNumber;
            FirstName = firstName;
            LastName = lastName;
            MidName = midName;
        }
    }
}
