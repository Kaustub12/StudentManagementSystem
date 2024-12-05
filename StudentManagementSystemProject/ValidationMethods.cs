using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace StudentManagementSystemProject
{
    internal static class ValidationMethods
    {
        static List<string> HobbieList = new List<string>();
        public static string GetValidString()
        {
            string input = "";
            string pattern = @"^[a-zA-Z]+$";
            while (true)
            {
                input = Console.ReadLine()?.Trim();
                PerformTask(input);

                if (!String.IsNullOrEmpty(input) || !String.IsNullOrWhiteSpace(input))
                {

                    if (IsValidString(input) && Regex.IsMatch(input,pattern))
                    {
                        return input;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid value, name should only contain letter. Avoid whitespace, symbols and numbers!");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid value, avoid leaving input empty!");

                }
            }
        }

        public static string GetValidStringOptional()
        {
            string input = "";
            string pattern = @"^[a-zA-Z]+$";
            while (true)
            {
                input = Console.ReadLine()?.Trim();
                if (input.ToLower() == "quit")
                {
                    DisplayMenuList displayMenuList = new DisplayMenuList();
                    displayMenuList.DisplayMenuOptions();
                }
                if ((input=="" || IsValidString(input) )|| (IsValidString(input) && Regex.IsMatch(input, pattern)))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("The value contains numeric and special symbol, Please enter the correct input!..");
                }
                
            }
            
        }

        public static int GetValidNumber()
        {
            int Validage;
            while (true)
            {
                string input = Console.ReadLine().Trim();
                if (input.ToLower() == "quit")
                {
                    DisplayMenuList displayMenuList = new DisplayMenuList();
                    displayMenuList.DisplayMenuOptions();
                }
                if (int.TryParse(input,out Validage) || Validage > 0)
                {
                    return Validage;
                }
                else
                {
                    Console.WriteLine("Please enter the numeric value!.....");
                }
                    
            }
            
        }

        public static bool IsValidString(this string input)
        {
           

            char[] CharOfInput = input.ToCharArray();

            foreach (char c in CharOfInput)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidValue(string input)
        {
            
            input = input.Replace(" ", "");

           
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }


        public static bool isValidHobby(List<string> Hobbies, string Hobby)
        {
            List<string> ValidHobbies = new List<string>
            {
            "football", "basketball","playing","piano","voilin","drum","outdoor","cooking","gaming","sports",
            "indoor", "tennis", "swimming", "running", "jogging",
            "cycling", "walking", "yoga", "pilates", "weightlifting", "crossfit",
            "aerobics", "hiking", "mountain climbing", "skiing", "snowboarding",
            "surfing", "skateboarding", "roller skating", "badminton", "table tennis",
            "golf", "volleyball", "baseball", "softball", "martial arts", "boxing",
            "wrestling", "fencing", "archery", "rowing", "kayaking", "canoeing",
            "sailing", "rock climbing", "scuba diving", "snorkeling", "fishing",
            "horseback riding", "camping", "backpacking", "bird watching", "stargazing",
            "orienteering", "geocaching", "gardening", "bonsai tree cultivation",
            "beekeeping", "foraging", "hunting", "mushroom hunting", "wildlife watching",
            "metal detecting", "painting", "drawing", "sculpting", "pottery", "photography",
            "graphic design", "fashion design", "jewelry making", "knitting", "crocheting",
            "sewing", "quilting", "embroidery", "calligraphy", "origami", "scrapbooking",
            "woodworking", "leatherworking", "metalworking", "glass blowing", "candle making",
            "soap making", "card making", "flower arranging", "singing", "playing guitar",
            "playing piano", "playing violin", "playing drums", "playing saxophone",
            "playing flute", "playing trumpet", "playing cello", "composing music",
            "songwriting", "djing", "audio mixing", "beatboxing", "acting", "theater",
            "stand-up comedy", "dancing", "performing magic tricks", "coding", "video game development",
            "3d modeling", "animation", "video editing", "podcasting", "blogging", "vlogging",
            "website design", "app development", "ui/ux design", "robotics", "drone piloting",
            "ethical hacking", "photo editing", "streaming", "reading", "writing", "creative writing",
            "poetry", "journaling", "learning new languages", "chess", "sudoku", "crosswords",
            "puzzle solving", "trivia games", "history research", "science experiments",
            "philosophy discussions", "meditation", "mindfulness", "cooking", "baking",
            "grilling", "barbecuing", "cake decorating", "brewing", "wine tasting",
            "home brewing", "cheesemaking", "pickling", "fermenting", "canning foods",
            "ice cream making", "chocolate making", "playing video games", "tabletop rpgs",
            "card games", "board games", "puzzle games", "escape room games", "fantasy sports",
            "stamp collecting", "coin collecting", "comic book collecting", "vinyl record collecting",
            "action figure collecting", "antique collecting", "toy collecting", "sports memorabilia collecting",
            "art collecting", "autograph collecting", "fossil collecting", "rock collecting",
            "model train collecting", "card collecting", "woodworking", "diy home projects",
            "upcycling", "sewing", "knitting", "candle making", "soap making", "pottery",
            "jewelry making", "model building", "volunteering", "community service", "mentoring",
            "public speaking", "charity work", "fundraising", "teaching", "youth leadership",
            "church involvement", "event planning", "organizing meetups", "environmental activism",
            "political campaigning", "advocacy", "traveling", "road trips", "exploring museums",
            "visiting historical sites", "photography while traveling", "cultural exchange",
            "eco-tourism", "adventure travel", "city tours", "food tasting tours",
            "off-roading", "meditation", "mindfulness practices", "yoga", "tai chi", "journaling",
            "self-care", "aromatherapy", "spiritual practices", "relaxation techniques"
            };

            if (ValidHobbies.Contains(Hobby.ToLower()))
            {
                Console.WriteLine("Hobby you have mentioned is contain in my data");
                return true;
            }
            else
            {
                if (IsValidString(Hobby.ToLower()))
                {
                    Console.WriteLine("Hobby you have mentioned is not contain in my data,I'm adding the hobby!...");
                    CreateNewHobby(Hobby.ToLower());
                    return true;
                }
               
                   
                    return false;
                
                
            }
           
        }

        public static void CreateNewHobby(string hobby)
        {
            
            HobbieList.Add(hobby);
            Console.WriteLine($"Hobby '{hobby}' added. Please add at most 7 hobbies. To finish, press '0'.");
        }

        public static int GetValidatedClass()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int SClass = int.Parse(input);
                    if (input.ToLower() == "quit")
                    {
                        DisplayMenuList displayMenuList = new DisplayMenuList();
                        displayMenuList.DisplayMenuOptions();
                        return 0;
                    }
                    if (SClass >= 1 && SClass <= 12)
                    {
                        return SClass;
                    }
                    else
                    {
                        Console.WriteLine("Please enter class between 1-12.");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public static void PrintObject(this StudentRecords Stud)
        {
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

        }

        public static async void PrintList(this List<StudentRecords> Students)
        {
            if (Students.Count > 0)
            {
                int Count = 1;
                foreach (var Stud in Students)
                {
                    Console.WriteLine($"Student {Count}:");

                    await Stud.PrintObjectAsync();
                    Count++;
                }
            }
            else
            {
                Console.WriteLine("Sorry, no data present...");
            }
        }
        public static async Task PrintObjectAsync(this StudentRecords Stud)
        {
            await PrintWithDelayAsync(new string('-', 40)+Environment.NewLine);
            await PrintWithDelayAsync($"Name       : {Stud.FirstName} {Stud.MiddleName} {Stud.LastName}" + Environment.NewLine);
            await PrintWithDelayAsync($"Age        : {Stud.Age}" + Environment.NewLine);
            await PrintWithDelayAsync($"Hobbies    : {string.Join(", ", Stud.Hobbies)}" + Environment.NewLine);
            await PrintWithDelayAsync($"Address    : {Stud.Address}" + Environment.NewLine);
            await PrintWithDelayAsync($"Class      : {Convert.ToInt32(Stud.Class)} Grade" + Environment.NewLine);
            await PrintWithDelayAsync($"Roll No    : {Stud.RollNo}" + Environment.NewLine);
            await PrintWithDelayAsync("Subjects   :" + Environment.NewLine);

            foreach (var sub in Stud.SubjectMarks)
            {
                await PrintWithDelayAsync($"     -{sub.Key} : {sub.Value}" + Environment.NewLine);
            }

            await PrintWithDelayAsync($"Date and Time at student registered: {Stud.AddedDateAndTime}" + Environment.NewLine);
            await PrintWithDelayAsync(new string('-', 40) + Environment.NewLine + Environment.NewLine);
        }

        public static async Task PrintWithDelayAsync(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);              // Print each character
                await Task.Delay(1);          // Delay of 50 milliseconds between each character
            }
        }
        public static void PerformTask(string input)
        {
            if (input.ToLower() == "quit")
            {
                DisplayMenuList displayMenuList = new DisplayMenuList();
                displayMenuList.DisplayMenuOptions();
            }
        }

        public static Dictionary<string, int> ValidateSubject(int SClass, string Stream)
        {
            Dictionary<string, int> SubjectAndMarks = new Dictionary<string, int>();

            // Lists of subjects for different class ranges and streams
            List<string> Class1To5 = new List<string> { "English", "Mathematics", "Environmental Studies", "Hindi", "Art and Craft" };
            List<string> Class6To10 = new List<string> { "English", "Mathematics", "Science", "Social Science", "Hindi" };
            List<string> Class11To12Maths = new List<string> { "Physics", "Chemistry", "Mathematics", "English" };
            List<string> Class11To12Bio = new List<string> { "Physics", "Chemistry", "Biology", "English" };
            List<string> Class11To12Commerce = new List<string> { "Accountancy", "Business Studies", "Economics", "Mathematics", "English" };
            List<string> Class11To12Arts = new List<string> { "History", "Geography", "Political Science", "Economics", "English" };

            // Variable to hold marks input by user
            int Marks = -1;

            // Validate subjects for Class 1 to 5
            if (SClass >= 1 && SClass <= 5)
            {
                foreach (string subject in Class1To5)
                {
                    Console.WriteLine($"Enter your marks (0-100) for {subject}: ");
                    while (Marks < 0 || Marks > 100)
                    {
                        try
                        {
                            Marks = int.Parse(Console.ReadLine());
                            if (Marks < 0 || Marks > 100)
                            {
                                Console.WriteLine("Please enter marks within range 0-100");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid input! Please enter marks within range 0-100");
                        }
                    }
                    SubjectAndMarks.Add(subject.ToLower(), Marks);
                    Marks = -1;  // Reset marks for the next subject
                }
            }
            // Validate subjects for Class 6 to 10
            else if (SClass >= 6 && SClass <= 10)
            {
                foreach (string subject in Class6To10)
                {
                    Console.WriteLine($"Enter your marks for {subject}: ");
                    while (Marks < 0 || Marks > 100)
                    {
                        try
                        {
                            Marks = int.Parse(Console.ReadLine());
                            if (Marks < 0 || Marks > 100)
                            {
                                Console.WriteLine("Please enter marks within range 0-100");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid input! Please enter marks within range 0-100");
                        }
                    }
                    SubjectAndMarks.Add(subject.ToLower(), Marks);
                    Marks = -1;
                }
            }
            // Validate subjects for Class 11 to 12 based on the stream
            else
            {
                List<string> classSubjects = null;

                if (Stream == "mathematics")
                {
                    classSubjects = Class11To12Maths;
                }
                else if (Stream == "biology")
                {
                    classSubjects = Class11To12Bio;
                }
                else if (Stream == "commerce")
                {
                    classSubjects = Class11To12Commerce;
                }
                else if (Stream == "arts")
                {
                    classSubjects = Class11To12Arts;
                }

                if (classSubjects != null)
                {
                    foreach (string subject in classSubjects)
                    {
                        Console.WriteLine($"Enter your marks for {subject}: ");
                        while (Marks < 0 || Marks > 100)
                        {
                            try
                            {
                                Marks = int.Parse(Console.ReadLine());
                                if (Marks < 0 || Marks > 100)
                                {
                                    Console.WriteLine("Please enter marks within range 0-100");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid input! Please enter marks within range 0-100");
                            }
                        }
                        SubjectAndMarks.Add(subject.ToLower(), Marks);
                        Marks = -1;
                    }
                }
            }

            // After entering the standard subjects, ask if the user wants to add custom subjects
            Console.WriteLine("\nDo you want to add any custom subjects? (yes/no): ");
            string addCustomSubjects = Console.ReadLine().ToLower();

            if (addCustomSubjects == "yes")
            {
                while (true)
                {
                    Console.WriteLine("\nEnter the custom subject name: ");
                    string customSubject = Console.ReadLine();

                    Console.WriteLine($"Enter marks for {customSubject} (0-100): ");
                    while (Marks < 0 || Marks > 100)
                    {
                        try
                        {
                            Marks = int.Parse(Console.ReadLine());
                            if (Marks < 0 || Marks > 100)
                            {
                                Console.WriteLine("Please enter marks within range 0-100");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid input! Please enter marks within range 0-100");
                        }
                    }
                    SubjectAndMarks.Add(customSubject.ToLower(), Marks);
                    Marks = -1;

                    // Ask if they want to add more custom subjects
                    Console.WriteLine("Do you want to add another custom subject? (yes/no): ");
                    string continueAdding = Console.ReadLine().ToLower();

                    if (continueAdding != "yes")
                    {
                        break;
                    }
                }
            }

            return SubjectAndMarks;
        }
    }
}
