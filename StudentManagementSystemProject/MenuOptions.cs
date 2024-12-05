using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystemProject
{
    public class MenuOptions
    {
        public static void MainMenuOptions()
        {
            Console.WriteLine("------------------------------- Main Menu Options -------------------------------------");
            Console.WriteLine("1. Add a New Student");
            Console.WriteLine("2. Get All Students");
            Console.WriteLine("3. Filter Students");
            Console.WriteLine("4. Find Students by Age Range (15-25)");
            Console.WriteLine("5. Find Class Topper");
            Console.WriteLine("6. Find Nth Topper in Class");
            Console.WriteLine("7. Display Classes with Students (Every 10 Seconds)");
            Console.WriteLine("0. Exit");
            
            Console.Write("Please select an option to perform: ");
           

        }

        public static void FilterMenu()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("1. Find by First Name.");
            Console.WriteLine("2. Find by Middle Name.");
            Console.WriteLine("3. Find by Last Name.");
            Console.WriteLine("4. Find by Address.");
            Console.WriteLine("5. Find by Hobby(s).");
            Console.WriteLine("6. Find by Class.");
            Console.WriteLine("7. Find by Date");
            Console.WriteLine("0. Exit");
            Console.WriteLine(new string('-', 30));
            Console.Write("Please select an option to perform: ");
        }
    }
}
