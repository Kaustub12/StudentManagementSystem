using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemProject
{
    internal class FilterDataImplementation
    {
        public class FilterDataImplemetation
        {

            //Function which displays fiter menu.
            public void DisplayFilterMenu(List<StudentRecords> Students)
            {
                if (Students.Count > 0)
                {
                    while (true)
                    {
                        try
                        {
                            MenuOptions.FilterMenu();
                            int Choice = int.Parse(Console.ReadLine());

                            switch (Choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter the first name to get details of student");
                                    string Fname = ValidationMethods.GetValidString();
                                    Console.WriteLine("Filtering data...");
                                    FilterByFname(Students, Fname);
                                    break;

                                case 2:
                                    Console.WriteLine("Enter the middle name to get details of student");
                                    string Mname = ValidationMethods.GetValidStringOptional();
                                    Console.WriteLine("Filtering data...");
                                    FilterByMname(Students, Mname);
                                    break;

                                case 3:
                                    Console.WriteLine("Enter the last name to get details of student");
                                    string Lname = ValidationMethods.GetValidString();
                                    Console.WriteLine("Filtering data...");
                                    FilterByLname(Students, Lname);
                                    break;

                                case 4:
                                    Console.WriteLine("Enter address to get details of students");
                                    string Address = Console.ReadLine();
                                    Console.WriteLine("Filtering data...");
                                    FilterByAddress(Students, Address);
                                    break;

                                case 5:
                                    Console.WriteLine("Enter Hobby(s) to get details of students, Separate each hobby by comma(,)");
                                    string Hobby = Console.ReadLine();
                                    Console.WriteLine("Filtering data...");
                                    FilterByHobby(Students, Hobby);
                                    break;

                                case 6:
                                    Console.WriteLine("Enter Class(1-12) to get details of students");
                                    CreateInformation.Classes SClass = (CreateInformation.Classes)ValidationMethods.GetValidatedClass();
                                    FilterByClass(Students, SClass);
                                    break;

                                case 7:
                                    Console.WriteLine("Enter registration date(dd-mm-yyyy) of students ");
                                    string Date = Console.ReadLine();
                                    Console.WriteLine("Filtering data...");
                                    FilterByDate(Students, Date);
                                    break;

                                case 0:
                                    return;

                                default:
                                    Console.WriteLine("Please select a valid operation to perform.");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No data present, please enter student data to perform operation.");
                }


            }

            /*------------------------------FILTER FUNCTIONS-----------------------------------*/

            public void FilterByFname(List<StudentRecords> Students, string Fname)
            {
                int Count = 0;

                foreach (var StudObj in Students)
                {
                    if (StudObj.FirstName.ToLower() == Fname.ToLower())
                    {
                        ++Count;
                        Console.WriteLine($"Student {Count}:");
                        StudObj.PrintObject();
                    }
                }

                if (Count == 0)
                {
                    Console.WriteLine("No Data Found!");
                }
            }

            public void FilterByMname(List<StudentRecords> Students, string Mname)
            {
                int Count = 0;

                foreach (var StudObj in Students)
                {
                    if (StudObj.MiddleName.ToLower() == Mname.ToLower())
                    {
                        ++Count;
                        Console.WriteLine($"Student {Count}:");
                        StudObj.PrintObject();
                    }
                }

                if (Count == 0)
                {
                    Console.WriteLine("No Data Found!");
                }
            }
            public void FilterByLname(List<StudentRecords> Students, string Lname)
            {
                int Count = 0;

                foreach (var StudObj in Students)
                {
                    if (StudObj.LastName.ToLower() == Lname.ToLower())
                    {
                        ++Count;
                        Console.WriteLine($"Student {Count}:");
                        StudObj.PrintObject();
                    }
                }

                if (Count == 0)
                {
                    Console.WriteLine("No Data Found!");
                }
            }

            public void FilterByAddress(List<StudentRecords> Students, string Address)
            {
                int Count = 0;

                foreach (var StudObj in Students)
                {
                    if (StudObj.Address.ToLower() == Address.ToLower())
                    {
                        ++Count;
                        Console.WriteLine($"Student {Count}:");
                        StudObj.PrintObject();
                    }
                }

                if (Count == 0)
                {
                    Console.WriteLine("No Data Found!");
                }
            }

            public void FilterByClass(List<StudentRecords> Students, CreateInformation.Classes SClass)
            {
                Console.WriteLine("Want to filter by subject?");
                Console.WriteLine("Select YES or NO!");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2. No");
                bool IsValidInput = false;
                bool BySubject = false;
                while (!IsValidInput)
                {
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":

                            FilterBySubject(Students, SClass);
                            IsValidInput = true;
                            BySubject = true;
                            break;
                        case "2":
                            IsValidInput = true;
                            break;
                        default:
                            Console.WriteLine("Please select a valid option");
                            break;
                    }
                }
                if (!BySubject)
                {
                    int Count = 0;
                    foreach (var StudObj in Students)
                    {
                        if (StudObj.Class == SClass)
                        {
                            ++Count;
                            Console.WriteLine($"Student {Count}:");
                            StudObj.PrintObject();
                        }
                    }

                    if (Count == 0)
                    {
                        Console.WriteLine("No Data Found!");
                    }
                }

            }

            public void FilterBySubject(List<StudentRecords> Students, CreateInformation.Classes SClass)
            {

                List<string> Class1To5 = new List<string>
            {
            "English",
            "Mathematics",
            "Environmental Studies",
            "Hindi",
            "Art and Craft"
            };
                List<string> Class6To10 = new List<string>
            {
            "english",
            "mathematics",
            "science",
            "social science",
            "hindi"
            };
                List<string> Class11To12Maths = new List<string>{
             "physics",
            "chemistry",
            "mathematics",
            "english"
            };
                List<string> Class11To12Bio = new List<string>{
             "physics",
            "chemistry",
            "biology",
            "english"
            };
                List<string> Class11To12Commerce = new List<string>{
            "accountancy",
            "business studies",
            "economics",
            "mathematics",
            "english"
            };
                List<string> Class11To12Arts = new List<string>{
            "history",
            "geography",
            "political science",
            "economics",
            "english"
            };

                try
                {
                    int Class = Convert.ToInt32(SClass);
                    if (Class >= 1 && Class <= 5)
                    {
                        foreach (string subject in Class1To5)
                        {
                            Console.Write(subject.ToUpper() + ",");
                        }
                    }
                    else if (Class >= 6 && Class <= 10)
                    {
                        foreach (string subject in Class6To10)
                        {
                            Console.Write(subject.ToUpper() + ",");
                        }
                    }
                    else
                    {
                        HashSet<string> SubjectSet = new HashSet<string>();
                        Console.WriteLine("Select from the subjects mentioned below: ");
                        foreach (string subject in Class11To12Maths)
                        {
                            SubjectSet.Add(subject);
                        }
                        foreach (string subject in Class11To12Bio)
                        {
                            SubjectSet.Add(subject);
                        }
                        foreach (string subject in Class11To12Commerce)
                        {
                            SubjectSet.Add(subject);
                        }
                        foreach (string subject in Class11To12Arts)
                        {
                            SubjectSet.Add(subject);
                        }
                        foreach (string subject in SubjectSet)
                        {
                            Console.Write(subject.ToUpper() + ", ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Please enter a subject name");
                    string Subject = Console.ReadLine();
                    Console.WriteLine(Subject);
                    Console.WriteLine();
                    foreach (var Student in Students)
                    {

                        if (Student.Class == SClass && Student.SubjectMarks.ContainsKey(Subject.ToLower()))
                        {
                            Student.PrintObject();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public void FilterByHobby(List<StudentRecords> Students, string Hobbies)
            {
                try
                {
                    Hobbies = Hobbies.ToLower();
                    string[] Hobby = Hobbies.Split(',');
                    if (Hobby.Length == 1)
                    {
                        int FoundStudCount = 0;
                        foreach (StudentRecords Student in Students)
                        {
                            if (Student.Hobbies.Contains(Hobby[0].ToLower()))
                            {
                                Student.PrintObject();
                                FoundStudCount++;
                            }
                        }
                        if (FoundStudCount == 0)
                        {
                            Console.WriteLine("No Data Found");
                        }
                    }
                    else
                    {
                        int FoundStudCount = 0;
                        foreach (StudentRecords Student in Students)
                        {
                            int HobbyCount = 0;
                            foreach (string item in Hobby)
                            {
                                //Console.WriteLine($"{item}");
                                if (Student.Hobbies.Contains(item.ToLower().Trim()))
                                {
                                    HobbyCount++;
                                }
                            }
                            if (HobbyCount > 0)
                            {
                                Student.PrintObject();
                                FoundStudCount++;
                            }
                        }
                        if (FoundStudCount == 0)
                        {
                            Console.WriteLine("No Data Found");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public void FilterByDate(List<StudentRecords> Students, string Date)
            {
                int Count = 1;
                //int StudCount = 1;
                foreach (StudentRecords Student in Students)
                {
                    if (Student.AddedDateAndTime.Contains(Date))
                    {
                        Console.WriteLine($"Student {Count}");
                        Student.PrintObject();
                        Count++;
                    }
                }
                if (Count == 1)
                {
                    Console.WriteLine("No data found.");
                }
            }

            public static void GiveStudentsBetweenAge15To25(List<StudentRecords> Students)
            {
                try
                {
                    int Count = 1;
                    Console.WriteLine("Here are the data you asked for: ");
                    foreach (StudentRecords Student in Students)
                    {
                        if (Student.Age >= 15 && Student.Age <= 25)
                        {
                            Console.WriteLine($"Student: {Count++}");
                            Student.PrintObject();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public static Dictionary<StudentRecords, int> GetTopperList(List<StudentRecords> Students, int SClass)
            {
                //List<StudentData> TopperList = new List<StudentData>();

                Dictionary<StudentRecords, int> TopperList = new Dictionary<StudentRecords, int>();
                int IsPassVal = 35;
                try
                {
                    foreach (StudentRecords Student in Students)
                    {
                        int TotalMarks = 0;
                        int CountOfPassSubs = 0;
                        if (Convert.ToInt32(Student.Class) == SClass)
                        {
                            foreach (int Marks in Student.SubjectMarks.Values)
                            {
                                if (Marks >= IsPassVal)
                                {
                                    CountOfPassSubs++;
                                    TotalMarks += Marks;
                                }
                            }
                            if (CountOfPassSubs == Student.SubjectMarks.Count)
                            {
                                TopperList.Add(Student, TotalMarks);
                            }
                        }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Dictionary<StudentRecords, int> TopperListSorted = TopperList.OrderByDescending(Dict => Dict.Value).ToDictionary(Dict => Dict.Key, Dict => Dict.Value);
                return TopperListSorted;
            }

            public static void GetToppers(List<StudentRecords> Students, int SClass, int Case, int NthTopper)
            {

                Dictionary<StudentRecords, int> TopperListOfClass = GetTopperList(Students, SClass);

                if (Case == 5)
                {
                    int Count = 0;
                    foreach (StudentRecords Student in TopperListOfClass.Keys)
                    {   //Calculating percentage at the same time
                        Console.WriteLine($"Topper of Grade {SClass} with percentage of {(double)(TopperListOfClass[Student] / Student.SubjectMarks.Count)}");
                        Count++;
                        Student.PrintObject();
                        break;
                    }
                    if (Count == 0)
                    {
                        Console.WriteLine("No Data Found");
                    }
                }
                else
                {
                    if (NthTopper > TopperListOfClass.Count)
                    {
                        Console.WriteLine($"Please enter a position withing range 1 - {TopperListOfClass.Count}");
                        bool IsValid = false;
                        string Nth = "";
                        while (!IsValid)
                        {

                            Nth = Console.ReadLine();
                            if (!int.TryParse(Nth, out NthTopper))
                            {
                                Console.WriteLine("Please enter a valid number");
                            }
                            else
                            {
                                IsValid = true;
                            }
                        }
                    }


                    int Count = 0;
                    foreach (StudentRecords Student in TopperListOfClass.Keys)
                    {
                        Count++;
                        if (Count == NthTopper)
                        {
                            Console.WriteLine($"{Count}th position Topper of Grade {SClass} with percentage of  {(double)(TopperListOfClass[Student] / Student.SubjectMarks.Count)}");
                            Student.PrintObject();
                            break;
                        }
                    }
                }

            }

        }
    }
    }
