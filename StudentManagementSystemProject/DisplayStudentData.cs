using StudentManagementSystemProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemProject
{
    internal class DisplayStudentData
    {
        public static void ShowStudentData(List<StudentRecords> StudData, bool IsEveryTenSecs)
        {
            //THIS IS A DISPLAY FUNCTION, IT HAS AN ALTERNATE WHICH IS PRINT OBJECT FUNCTION IMPLEMENTED IN FilterDataImplementation know as **PrintObject**
            //bool StopThread = false;
            if (IsEveryTenSecs)
            {
                while (true)
                {
                    int Count = 1;
                    foreach (var Stud in StudData)
                    {
                        Thread t1 = new Thread(() =>
                        {
                            Console.WriteLine($"Student {Count}:");
                            Console.WriteLine(new string('-', 40));
                            Console.WriteLine($"Name       : {Stud.FirstName} {Stud.MiddleName} {Stud.LastName}");
                            Console.WriteLine($"Age        : {Stud.Age}");
                            Console.WriteLine($"Hobbies    : {string.Join(", ", Stud.Hobbies)}");
                            Console.WriteLine($"Address    : {Stud.Address}");
                            Console.WriteLine($"Class      : {Convert.ToInt32(Stud.Class)} Grade");
                            Console.WriteLine($"Roll No    : {Stud.RollNo}");
                            Console.WriteLine("Subjects   :");
                            foreach (var sub in Stud.SubjectMarks)
                            {
                                Console.Write($"     -{sub.Key} : {sub.Value}");
                                Console.WriteLine();
                            }

                            Console.WriteLine($"Date and Time at student registered: {Stud.AddedDateAndTime}");
                            Console.WriteLine(new string('-', 40));
                            Console.WriteLine();
                            Count++;
                        });

                        t1.Start();
                        Thread.Sleep(1000);
                        
                    }
                }
            }
            else
            {

                int Count = 1;
                foreach (var Stud in StudData)
                {
                    Console.WriteLine($"Student {Count}:");
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine($"Name       : {Stud.FirstName} {Stud.MiddleName} {Stud.LastName}");
                    Console.WriteLine($"Age        : {Stud.Age}");
                    Console.WriteLine($"Hobbies    : {string.Join(", ", Stud.Hobbies)}");
                    Console.WriteLine($"Address    : {Stud.Address}");
                    Console.WriteLine($"Class      : {Convert.ToInt32(Stud.Class)} Grade");
                    Console.WriteLine($"Roll No    : {Stud.RollNo}");
                    Console.WriteLine("Subjects   :");
                    foreach (var sub in Stud.SubjectMarks)
                    {
                        Console.Write($"     -{sub.Key} : {sub.Value}");
                        Console.WriteLine();
                    }

                    Console.WriteLine($"Date and Time at student registered: {Stud.AddedDateAndTime}");
                    Console.WriteLine(new string('-', 40));
                    Console.WriteLine();
                    Count++;
                }
            }
        }
    }
}
