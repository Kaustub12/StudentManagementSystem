using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemProject
{
    internal class CreateInformation
    {
        public enum Classes
        {
            first =1,
            second =2, 
            third =3,
            fourth =4,
            fifth =5,
            sixth =6,
            seventh =7,
            eighth =8,
            nineth =9,    
            tenth =10,
            eleventh =11,
            twelveth =12
        }
       
        public async void AddStudentInfo(List<StudentRecords> Studentdata, List<int> UniqueNo)
        {
            Console.WriteLine("Please type Quit, if you want to return to MainMenu");
            Console.WriteLine("Add a Student Details!...");

            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Enter the first name of student: ");
            string firstName = ValidationMethods.GetValidString();

            Console.WriteLine("Enter the middle name of student: (Optional)");
            string middleName = ValidationMethods.GetValidStringOptional();

            Console.WriteLine("Enter the last name of student: ");
            string lastName = ValidationMethods.GetValidString();

            Console.WriteLine("Enter the age of student: ");
            int Age = 0;
            try
            {
                while (true)
                {
                    Age = ValidationMethods.GetValidNumber();
                    Console.WriteLine("Age "+Age);
                    if (Age > 3 && Age < 24)
                    {
                        Console.WriteLine("Student age is stored");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the Valid age between 3 to 24 !...");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           

            Console.WriteLine("Enter the address (only cities/localities) of student: ");
          
            string Address = Console.ReadLine();
            ValidationMethods.PerformTask(Address);

            Console.WriteLine("Enter the Hobbies in count of 1 to 7. !....");
            Console.WriteLine("Enter the 0 exit");
            
            List<string> HobbieList = new List<string>();
            string? input= null;
            while (true)
            {
                input = Console.ReadLine().Trim();
                ValidationMethods.PerformTask(input);
                if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Hobby cannot be empty, Please enter the hobbies in count of 1 to 7");
                }
                else
                {

                    if (input == "0" && HobbieList.Count == 0)
                    {
                        Console.WriteLine("Please enter at least one hobby.");
                    }
                    else if (input == "0" && HobbieList.Count > 0)
                    {
                        break;
                    }
                    else
                    {
                        if (ValidationMethods.isValidValue(input))
                        {
                            int count = HobbieList.Count;

                            if (count < 7 && ValidationMethods.isValidHobby(HobbieList, input) || !ValidationMethods.isValidHobby(HobbieList, input))
                            {
                                HobbieList.Add(input);
                                Console.WriteLine("please add atmost 7 hobbies, and for moving to the next Please press '0'...");
                            }
                            else
                            {
                                Console.WriteLine("Maximum of 7 hobbies reached.");
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Please add the valid hobby!...");
                        }

                    }
                }
            }

                    Console.WriteLine("Enter the class student study in (1-12).");
                    Classes StudentClass = (Classes)ValidationMethods.GetValidatedClass();
                    
                    Dictionary<String, int> SubjectMarks = new Dictionary<string, int>();

            Console.WriteLine("Enter the RollNo. of student: ");
            int Rollno = 0;
            bool isValidRollNo = false;

            while (!isValidRollNo)
            {
                Rollno = ValidationMethods.GetValidNumber();
                if (!UniqueNo.Contains(Rollno))
                {
                    UniqueNo.Add(Rollno);
                    isValidRollNo = true;
                    Console.WriteLine("The Rollno is unique and it is stored");
                }
                else
                {
                    Console.WriteLine("please select a unique roll no");
                }
            }

            string Stream = "";
                    try
                    {
                        if (Convert.ToInt32(StudentClass) > 10)
                        {
                            Console.WriteLine("Please select a stream from below list to continue.");
                            Console.WriteLine("1. Mathematics");
                            Console.WriteLine("2. Biology");
                            Console.WriteLine("3. Commerce");
                            Console.WriteLine("4. Arts");
                            string value = Console.ReadLine();
                            ValidationMethods.PerformTask(value);
                            int Choice = int.Parse(value);
                            
                            switch (Choice)
                            {
                                case 1:
                                    Stream = "mathematics";
                                    break;
                                case 2:
                                    Stream = "biology";
                                    break;
                                case 3:
                                    Stream = "commerce";
                                    break;
                                case 4:
                                    Stream = "arts";
                                    break;

                                default:
                                    Console.WriteLine("Please select a valid option");
                                    break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine("Enter Marks for respective subjects");
                    //string SubAndMark = Console.ReadLine().Trim();
                    try
                    {
                        SubjectMarks = ValidationMethods.ValidateSubject(Convert.ToInt32(StudentClass), Stream);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    //}

                    //DATE AND TIME ADDED
                    DateTime Now = DateTime.Now;
                    string DateAndTime = Now.ToString("dd-MMM-yy, HH:mm:ss");

                    StudentRecords std = new StudentRecords(firstName, middleName, lastName, Age, Address, HobbieList, StudentClass, Rollno, SubjectMarks, DateAndTime);
                   

                }
            
            
        

    }
}
