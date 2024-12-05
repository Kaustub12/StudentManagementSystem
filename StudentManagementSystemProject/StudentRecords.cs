using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemProject
{
    internal class StudentRecords
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public CreateInformation.Classes Class { get; set; }
        public int RollNo { get; set; }
        public Dictionary<string, int> SubjectMarks { get; set; }
        public List<string> Hobbies { get; set; }
        public string AddedDateAndTime { get; set; }


        public StudentRecords( string fname, string midName, string lname, int age, string address, List<string> hobbies, CreateInformation.Classes SClass, int rollNo, Dictionary<string, int> subMarks, string dateAndTime)
        {
            FirstName = fname;
            MiddleName = midName;
            LastName = lname;
            Age = age;
            Class = SClass;
            RollNo = rollNo;
            SubjectMarks = subMarks;
            Address = address;
            Hobbies = hobbies;
            AddedDateAndTime = dateAndTime;
        }

       
    }
}
