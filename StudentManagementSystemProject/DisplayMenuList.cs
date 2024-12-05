using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static StudentManagementSystemProject.CreateInformation;
using static StudentManagementSystemProject.FilterDataImplementation;

namespace StudentManagementSystemProject
{
    internal class DisplayMenuList
    {
        public delegate void OperationsDelegate();
        public static List<StudentRecords> DummyData()
        {
            List<StudentRecords> Students = new List<StudentRecords>
            {
            new StudentRecords("Uma", "U", "Scott", 5, "1818 Pine St", new List<string> { "drawing", "cycling" }, Classes.first, 21,
        new Dictionary<string, int>
        {
            { "english", 88 },
            { "mathematics", 82 },
            { "environmental studies", 84 },
            { "hindi", 80 },
            { "art and craft", 85 }
        }, DateTime.Now.ToString()),

        new StudentRecords("Victor", "V", "Hughes", 6, "1919 Elm St", new List<string> { "football", "reading" }, Classes.second, 22,
        new Dictionary<string, int>
        {
            { "english", 82 },
            { "mathematics", 85 },
            { "environmental studies", 80 },
            { "hindi", 78 },
            { "art and craft", 87 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Wendy", "W", "Morgan", 7, "2020 Oak St", new List<string> { "singing", "skating" }, Classes.third, 23,
        new Dictionary<string, int>
        {
            { "english", 80 },
            { "mathematics", 84 },
            { "environmental studies", 85 },
            { "hindi", 82 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Xander", "X", "Foster", 8, "2121 Cedar St", new List<string> { "swimming", "gaming" }, Classes.fourth, 24,
        new Dictionary<string, int>
        {
            { "english", 83 },
            { "mathematics", 88 },
            { "environmental studies", 80 },
            { "hindi", 84 },
            { "art and craft", 87 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Yara", "Y", "Peterson", 9, "2222 Birch St", new List<string> { "dancing", "chess" }, Classes.fifth, 25,
        new Dictionary<string, int>
        {
            { "english", 87 },
            { "mathematics", 90 },
            { "environmental studies", 86 },
            { "hindi", 83 },
            { "art and craft", 89 }
        }, DateTime.Now.ToString()),
        new StudentRecords("Alice", "A", "Smith", 7, "123 Main St", new List<string> { "drawing", "reading" }, Classes.second, 1,
        new Dictionary<string, int>
        {
            { "english", 85 },
            { "mathematics", 90 },
            { "hindi", 78 },
            { "environmental studies", 80 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Bob", "B", "Johnson", 8, "456 Elm St", new List<string> { "football", "gaming" }, Classes.second, 2,
        new Dictionary<string, int>
        {
            { "english", 78 },
            { "mathematics", 82 },
            { "hindi", 76 },
            { "environmental studies", 84 },
            { "art and craft", 80 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Charlie", "C", "Brown", 6, "789 Pine St", new List<string> { "photography", "hiking" }, Classes.second, 3,
        new Dictionary<string, int>
        {
            { "english", 82 },
            { "mathematics", 88 },
            { "hindi", 79 },
            { "environmental studies", 82 },
            { "art and craft", 86 }
        }, DateTime.Now.ToString()),

    new StudentRecords("David", "D", "Wilson", 7, "101 Maple St", new List<string> { "chess", "biking" }, Classes.second, 4,
        new Dictionary<string, int>
        {
            { "english", 80 },
            { "mathematics", 85 },
            { "hindi", 81 },
            { "environmental studies", 78 },
            { "art and craft", 84 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Eva", "E", "Davis", 8, "202 Birch St", new List<string> { "traveling", "cooking" }, Classes.second, 5,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 89 },
            { "hindi", 83 },
            { "environmental studies", 81 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    // Third Class
    new StudentRecords("Frank", "F", "Martinez", 9, "303 Cedar St", new List<string> { "swimming", "music" }, Classes.third, 6,
        new Dictionary<string, int>
        {
            { "english", 76 },
            { "mathematics", 88 },
            { "hindi", 82 },
            { "environmental studies", 79 },
            { "art and craft", 81 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Grace", "G", "Garcia", 10, "404 Oak St", new List<string> { "reading", "writing" }, Classes.third, 7,
        new Dictionary<string, int>
        {
            { "english", 85 },
            { "mathematics", 92 },
            { "hindi", 88 },
            { "environmental studies", 86 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Henry", "H", "Lopez", 9, "505 Spruce St", new List<string> { "fitness", "traveling" }, Classes.third, 8,
        new Dictionary<string, int>
        {
            { "english", 78 },
            { "mathematics", 81 },
            { "hindi", 80 },
            { "environmental studies", 82 },
            { "art and craft", 84 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Isla", "I", "Hernandez", 10, "606 Willow St", new List<string> { "yoga", "biking" }, Classes.third, 9,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 85 },
            { "hindi", 83 },
            { "environmental studies", 88 },
            { "art and craft", 87 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Jack", "J", "King", 9, "707 Cherry St", new List<string> { "drawing", "playing" }, Classes.third, 10,
        new Dictionary<string, int>
        {
            { "english", 83 },
            { "mathematics", 79 },
            { "hindi", 81 },
            { "environmental studies", 84 },
            { "art and craft", 82 }
        }, DateTime.Now.ToString()),

    // Fourth Class
    new StudentRecords("Katie", "K", "Moore", 11, "808 Walnut St", new List<string> { "painting", "skating" }, Classes.fourth, 11,
        new Dictionary<string, int>
        {
            { "english", 87 },
            { "mathematics", 86 },
            { "hindi", 80 },
            { "environmental studies", 79 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Leo", "L", "Anderson", 10, "909 Birch St", new List<string> { "coding", "reading" }, Classes.fourth, 12,
        new Dictionary<string, int>
        {
            { "english", 85 },
            { "mathematics", 82 },
            { "hindi", 89 },
            { "environmental studies", 84 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Mia", "M", "Thomas", 12, "1010 Maple St", new List<string> { "dancing", "photography" }, Classes.fourth, 13,
        new Dictionary<string, int>
        {
            { "english", 80 },
            { "mathematics", 90 },
            { "hindi", 86 },
            { "environmental studies", 88 },
            { "art and craft", 82 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Noah", "N", "Taylor", 11, "1111 Cedar St", new List<string> { "football", "gaming" }, Classes.fourth, 14,
        new Dictionary<string, int>
        {
            { "english", 82 },
            { "mathematics", 84 },
            { "hindi", 78 },
            { "environmental studies", 90 },
            { "art and craft", 85 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Olivia", "O", "Martin", 12, "1212 Spruce St", new List<string> { "cooking", "yoga" }, Classes.fourth, 15,
        new Dictionary<string, int>
        {
            { "english", 91 },
            { "mathematics", 83 },
            { "hindi", 88 },
            { "environmental studies", 86 },
            { "art and craft", 80 }
        }, DateTime.Now.ToString()),

    // Fifth Class
    new StudentRecords("Paul", "P", "Rodriguez", 13, "1313 Oak St", new List<string> { "swimming", "reading" }, Classes.fifth, 16,
        new Dictionary<string, int>
        {
            { "english", 84 },
            { "mathematics", 78 },
            { "hindi", 89 },
            { "environmental studies", 85 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Quinn", "Q", "Lewis", 14, "1414 Willow St", new List<string> { "traveling", "music" }, Classes.fifth, 17,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 81 },
            { "hindi", 82 },
            { "environmental studies", 84 },
            { "art and craft", 78 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Ryan", "R", "Lee", 12, "1515 Cherry St", new List<string> { "drawing", "running" }, Classes.fifth, 18,
        new Dictionary<string, int>
        {
            { "english", 78 },
            { "mathematics", 82 },
            { "hindi", 76 },
            { "environmental studies", 89 },
            { "art and craft", 84 }
        }, DateTime.Now.ToString()),

        new StudentRecords("Eve", "E", "Davis", 17, "202 Birch St", new List<string> { "traveling", "cooking" }, Classes.eleventh, 5,
            new Dictionary<string, int>
            {
                { "physics", 90 },
                { "chemistry", 85 },
                { "mathematics", 92 },
                { "english", 88 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Frank", "F", "Martinez", 18, "303 Cedar St", new List<string> { "swimming", "music" }, Classes.twelveth, 6,
            new Dictionary<string, int>
            {
                { "physics", 86 },
                { "chemistry", 89 },
                { "biology", 91 },
                { "english", 84 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Grace", "G", "Garcia", 16, "404 Oak St", new List<string> { "reading", "writing" }, Classes.eleventh, 7,
            new Dictionary<string, int>
            {
                { "accountancy", 87 },
                { "business studies", 92 },
                { "economics", 85 },
                { "mathematics", 79 },
                { "english", 90 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Henry", "H", "Lopez", 19, "505 Spruce St", new List<string> { "fitness", "traveling" }, Classes.twelveth, 8,
            new Dictionary<string, int>
            {
                { "history", 84 },
                { "geography", 85 },
                { "political science", 88 },
                { "economics", 82 },
                { "english", 86 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Isla", "I", "Hernandez", 15, "606 Willow St", new List<string> { "yoga", "biking" }, Classes.nineth, 9,
            new Dictionary<string, int>
            {
                { "physics", 89 },
                { "chemistry", 93 },
                { "biology", 91 },
                { "english", 87 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Jack", "J", "King", 6, "707 Cherry St", new List<string> { "drawing", "playing" }, Classes.second, 10,
            new Dictionary<string, int>
            {
                { "english", 80 },
                { "mathematics", 85 },
                { "environmental studies", 81 },
                { "hindi", 77 },
                { "art and craft", 89 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Katie", "K", "Moore", 9, "808 Walnut St", new List<string> { "painting", "skating" }, Classes.third, 11,
            new Dictionary<string, int>
            {
                { "english", 78 },
                { "mathematics", 88 },
                { "environmental studies", 80 },
                { "hindi", 82 },
                { "art and craft", 86 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Leo", "L", "Anderson", 13, "909 Birch St", new List<string> { "coding", "reading" }, Classes.seventh, 12,
            new Dictionary<string, int>
            {
                { "english", 83 },
                { "mathematics", 90 },
                { "science", 85 },
                { "social science", 81 },
                { "hindi", 86 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Mia", "M", "Thomas", 14, "1010 Maple St", new List<string> { "dancing", "photography" }, Classes.eighth, 13,
            new Dictionary<string, int>
            {
                { "english", 88 },
                { "mathematics", 84 },
                { "science", 86 },
                { "social science", 89 },
                { "hindi", 82 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Noah", "N", "Taylor", 11, "1111 Cedar St", new List<string> { "football", "gaming" }, Classes.sixth, 14,
            new Dictionary<string, int>
            {
                { "english", 79 },
                { "mathematics", 82 },
                { "science", 88 },
                { "social science", 80 },
                { "hindi", 85 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Olivia", "O", "Martin", 18, "1212 Spruce St", new List<string> { "cooking", "yoga" }, Classes.twelveth, 15,
            new Dictionary<string, int>
            {
                { "physics", 87 },
                { "chemistry", 92 },
                { "biology", 88 },
                { "english", 90 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Paul", "P", "Rodriguez", 21, "1313 Oak St", new List<string> { "swimming", "reading" }, Classes.twelveth, 16,
            new Dictionary<string, int>
            {
                { "accountancy", 85 },
                { "business studies", 88 },
                { "economics", 90 },
                { "mathematics", 82 },
                { "english", 89 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Quinn", "Q", "Lewis", 16, "1414 Willow St", new List<string> { "traveling", "music" }, Classes.eleventh, 17,
            new Dictionary<string, int>
            {
                { "history", 86 },
                { "geography", 89 },
                { "political science", 90 },
                { "economics", 85 },
                { "english", 92 }
            }, DateTime.Now.ToString()),

         new StudentRecords("Sophia", "S", "Walker", 15, "1616 Birch St", new List<string> { "dancing", "cooking" }, Classes.fifth, 19,
        new Dictionary<string, int>
        {
            { "english", 87 },
            { "mathematics", 83 },
            { "hindi", 85 },
            { "environmental studies", 86 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Tom", "T", "Hall", 13, "1717 Maple St", new List<string> { "chess", "gaming" }, Classes.fifth, 20,
        new Dictionary<string, int>
        {
            { "english", 79 },
            { "mathematics", 88 },
            { "hindi", 84 },
            { "environmental studies", 82 },
            { "art and craft", 89 }
        }, DateTime.Now.ToString()),

    // Sixth Class
    new StudentRecords("Uma", "U", "Young", 16, "1818 Cedar St", new List<string> { "reading", "running" }, Classes.sixth, 21,
        new Dictionary<string, int>
        {
            { "english", 88 },
            { "mathematics", 90 },
            { "hindi", 79 },
            { "environmental studies", 84 },
            { "art and craft", 85 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Vera", "V", "Hernandez", 15, "1919 Elm St", new List<string> { "swimming", "music" }, Classes.sixth, 22,
        new Dictionary<string, int>
        {
            { "english", 79 },
            { "mathematics", 84 },
            { "hindi", 82 },
            { "environmental studies", 87 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Will", "W", "Garcia", 16, "2020 Oak St", new List<string> { "gaming", "cooking" }, Classes.sixth, 23,
        new Dictionary<string, int>
        {
            { "english", 80 },
            { "mathematics", 82 },
            { "hindi", 83 },
            { "environmental studies", 81 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Xena", "X", "Thompson", 17, "2121 Pine St", new List<string> { "running", "reading" }, Classes.sixth, 24,
        new Dictionary<string, int>
        {
            { "english", 86 },
            { "mathematics", 87 },
            { "hindi", 80 },
            { "environmental studies", 85 },
            { "art and craft", 82 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Yara", "Y", "White", 18, "2222 Maple St", new List<string> { "swimming", "traveling" }, Classes.sixth, 25,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 88 },
            { "hindi", 81 },
            { "environmental studies", 79 },
            { "art and craft", 84 }
        }, DateTime.Now.ToString()),

    // Seventh Class
    new StudentRecords("Zara", "Z", "Lee", 19, "2323 Birch St", new List<string> { "art", "music" }, Classes.seventh, 26,
        new Dictionary<string, int>
        {
            { "english", 84 },
            { "mathematics", 89 },
            { "hindi", 85 },
            { "environmental studies", 82 },
            { "art and craft", 91 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Alex", "A", "Kim", 20, "2424 Cedar St", new List<string> { "football", "swimming" }, Classes.seventh, 27,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 88 },
            { "hindi", 79 },
            { "environmental studies", 81 },
            { "art and craft", 84 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Brian", "B", "Nguyen", 18, "2525 Maple St", new List<string> { "chess", "traveling" }, Classes.seventh, 28,
        new Dictionary<string, int>
        {
            { "english", 88 },
            { "mathematics", 84 },
            { "hindi", 86 },
            { "environmental studies", 83 },
            { "art and craft", 80 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Cathy", "C", "Perez", 19, "2626 Elm St", new List<string> { "reading", "dancing" }, Classes.seventh, 29,
        new Dictionary<string, int>
        {
            { "english", 85 },
            { "mathematics", 82 },
            { "hindi", 89 },
            { "environmental studies", 90 },
            { "art and craft", 81 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Derek", "D", "Rodriguez", 20, "2727 Oak St", new List<string> { "photography", "fitness" }, Classes.seventh, 30,
        new Dictionary<string, int>
        {
            { "english", 86 },
            { "mathematics", 91 },
            { "hindi", 80 },
            { "environmental studies", 87 },
            { "art and craft", 89 }
        }, DateTime.Now.ToString()),

    // Eighth Class
    new StudentRecords("Eva", "E", "Hall", 21, "2828 Pine St", new List<string> { "basketball", "traveling" }, Classes.eighth, 31,
        new Dictionary<string, int>
        {
            { "english", 83 },
            { "mathematics", 88 },
            { "hindi", 87 },
            { "environmental studies", 84 },
            { "art and craft", 82 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Finn", "F", "Lee", 22, "2929 Birch St", new List<string> { "drawing", "cooking" }, Classes.eighth, 32,
        new Dictionary<string, int>
        {
            { "english", 89 },
            { "mathematics", 84 },
            { "hindi", 82 },
            { "environmental studies", 80 },
            { "art and craft", 91 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Gina", "G", "Kim", 23, "3030 Maple St", new List<string> { "music", "dancing" }, Classes.eighth, 33,
        new Dictionary<string, int>
        {
            { "english", 85 },
            { "mathematics", 86 },
            { "hindi", 90 },
            { "environmental studies", 89 },
            { "art and craft", 83 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Henry", "H", "Brown", 24, "3131 Elm St", new List<string> { "gaming", "reading" }, Classes.eighth, 34,
        new Dictionary<string, int>
        {
            { "english", 87 },
            { "mathematics", 82 },
            { "hindi", 88 },
            { "environmental studies", 84 },
            { "art and craft", 80 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Isla", "I", "Williams", 25, "3232 Cedar St", new List<string> { "swimming", "photography" }, Classes.eighth, 35,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 83 },
            { "hindi", 84 },
            { "environmental studies", 89 },
            { "art and craft", 85 }
        }, DateTime.Now.ToString()),
    new StudentRecords("Leo", "L", "Taylor", 28, "3535 Pine St", new List<string> { "football", "reading" }, Classes.nineth, 38,
        new Dictionary<string, int>
        {
            { "english", 88 },
            { "mathematics", 84 },
            { "hindi", 86 },
            { "environmental studies", 79 },
            { "art and craft", 89 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Mia", "M", "Rodriguez", 29, "3636 Birch St", new List<string> { "drawing", "dancing" }, Classes.nineth, 39,
        new Dictionary<string, int>
        {
            { "english", 85 },
            { "mathematics", 90 },
            { "hindi", 83 },
            { "environmental studies", 84 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Noah", "N", "Wilson", 30, "3737 Cedar St", new List<string> { "gaming", "photography" }, Classes.nineth, 40,
        new Dictionary<string, int>
        {
            { "english", 89 },
            { "mathematics", 86 },
            { "hindi", 81 },
            { "environmental studies", 82 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    // Tenth Class
    new StudentRecords("Owen", "O", "White", 31, "3838 Maple St", new List<string> { "running", "swimming" }, Classes.tenth, 41,
        new Dictionary<string, int>
        {
            { "english", 80 },
            { "mathematics", 88 },
            { "hindi", 87 },
            { "environmental studies", 84 },
            { "art and craft", 85 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Paula", "P", "Davis", 32, "3939 Elm St", new List<string> { "drawing", "reading" }, Classes.tenth, 42,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 79 },
            { "hindi", 82 },
            { "environmental studies", 86 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Quinn", "Q", "Martinez", 33, "4040 Cedar St", new List<string> { "basketball", "traveling" }, Classes.tenth, 43,
        new Dictionary<string, int>
        {
            { "english", 89 },
            { "mathematics", 80 },
            { "hindi", 84 },
            { "environmental studies", 85 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Ryan", "R", "Clark", 34, "4141 Pine St", new List<string> { "music", "fitness" }, Classes.tenth, 44,
        new Dictionary<string, int>
        {
            { "english", 84 },
            { "mathematics", 82 },
            { "hindi", 81 },
            { "environmental studies", 90 },
            { "art and craft", 87 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Sara", "S", "Lewis", 35, "4242 Maple St", new List<string> { "dancing", "cooking" }, Classes.tenth, 45,
        new Dictionary<string, int>
        {
            { "english", 86 },
            { "mathematics", 89 },
            { "hindi", 88 },
            { "environmental studies", 82 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    // Eleventh Class
    new StudentRecords("Tina", "T", "Hernandez", 36, "4343 Birch St", new List<string> { "swimming", "gaming" }, Classes.eleventh, 46,
        new Dictionary<string, int>
        {
            { "english", 80 },
            { "mathematics", 78 },
            { "hindi", 85 },
            { "environmental studies", 89 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Uma", "U", "Thompson", 37, "4444 Cedar St", new List<string> { "photography", "traveling" }, Classes.eleventh, 47,
        new Dictionary<string, int>
        {
            { "english", 88 },
            { "mathematics", 90 },
            { "hindi", 82 },
            { "environmental studies", 86 },
            { "art and craft", 84 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Victor", "V", "Martinez", 38, "4545 Maple St", new List<string> { "reading", "music" }, Classes.eleventh, 48,
        new Dictionary<string, int>
        {
            { "english", 86 },
            { "mathematics", 89 },
            { "hindi", 84 },
            { "environmental studies", 85 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Wendy", "W", "Wilson", 39, "4646 Elm St", new List<string> { "running", "art" }, Classes.eleventh, 49,
        new Dictionary<string, int>
        {
            { "english", 84 },
            { "mathematics", 82 },
            { "hindi", 81 },
            { "environmental studies", 90 },
            { "art and craft", 87 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Xander", "X", "Garcia", 40, "4747 Cedar St", new List<string> { "basketball", "drawing" }, Classes.eleventh, 50,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 89 },
            { "hindi", 80 },
            { "environmental studies", 88 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    // Twelfth Class
    new StudentRecords("Yvonne", "Y", "Harris", 41, "4848 Pine St", new List<string> { "cooking", "gaming" }, Classes.twelveth, 51,
        new Dictionary<string, int>
        {
            { "english", 83 },
            { "mathematics", 88 },
            { "hindi", 89 },
            { "environmental studies", 84 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Zach", "Z", "Thompson", 42, "4949 Maple St", new List<string> { "swimming", "running" }, Classes.twelveth, 52,
        new Dictionary<string, int>
        {
            { "english", 88 },
            { "mathematics", 80 },
            { "hindi", 82 },
            { "environmental studies", 85 },
            { "art and craft", 86 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Abby", "A", "Martinez", 43, "5050 Cedar St", new List<string> { "traveling", "music" }, Classes.twelveth, 53,
        new Dictionary<string, int>
        {
            { "english", 85 },
            { "mathematics", 87 },
            { "hindi", 89 },
            { "environmental studies", 90 },
            { "art and craft", 88 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Ben", "B", "Lee", 44, "5151 Birch St", new List<string> { "drawing", "cooking" }, Classes.twelveth, 54,
        new Dictionary<string, int>
        {
            { "english", 90 },
            { "mathematics", 86 },
            { "hindi", 84 },
            { "environmental studies", 83 },
            { "art and craft", 85 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Cathy", "C", "Brown", 45, "5252 Elm St", new List<string> { "football", "fitness" }, Classes.twelveth, 55,
        new Dictionary<string, int>
        {
            { "english", 88 },
            { "mathematics", 87 },
            { "hindi", 86 },
            { "environmental studies", 89 },
            { "art and craft", 84 }
        }, DateTime.Now.ToString()),
    // Ninth Class
    new StudentRecords("Jack", "J", "Jones", 26, "3333 Cherry St", new List<string> { "running", "traveling" }, Classes.nineth, 36,
        new Dictionary<string, int>
        {
            { "english", 80 },
            { "mathematics", 78 },
            { "hindi", 87 },
            { "environmental studies", 85 },
            { "art and craft", 90 }
        }, DateTime.Now.ToString()),

    new StudentRecords("Kylie", "K", "Smith", 27, "3434 Oak St", new List<string> { "music", "cooking" }, Classes.nineth, 37,
        new Dictionary<string, int>
        {
            { "english", 79 },
            { "mathematics", 89 },
            { "hindi", 82 },
            { "environmental studies", 90 },
            { "art and craft", 81 }
        }, DateTime.Now.ToString()),

        new StudentRecords("Ryan", "R", "Lee", 10, "1515 Cherry St", new List<string> { "drawing", "running" }, Classes.fifth, 18,
            new Dictionary<string, int>
            {
                { "english", 84 },
                { "mathematics", 86 },
                { "environmental studies", 80 },
                { "hindi", 81 },
                { "art and craft", 88 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Sophia", "S", "Walker", 22, "1616 Birch St", new List<string> { "dancing", "cooking" }, Classes.twelveth, 19,
            new Dictionary<string, int>
            {
                { "physics", 89 },
                { "chemistry", 85 },
                { "mathematics", 93 },
                { "english", 91 }
            }, DateTime.Now.ToString()),

        new StudentRecords("Tyler", "T", "Hall", 19, "1717 Elm St", new List<string> { "gaming", "swimming" }, Classes.twelveth, 20,
            new Dictionary<string, int>
            {
                { "history", 83 },
                { "geography", 86 },
                { "political science", 87 },
                { "economics", 88 },
                { "english", 84 }
            }, DateTime.Now.ToString()),
        };
            return Students;
        }
        public void DisplayMenuOptions()
        {
            List<int> UniqueNo = new List<int>();
            List<StudentRecords> Studentdata = DummyData();

            while (true)
            {
                try
                {

                    MenuOptions.MainMenuOptions();
                    int Option = Convert.ToInt32(Console.ReadLine());

                    CreateInformation createInformation = new CreateInformation();
                    FilterDataImplemetation Filter = new FilterDataImplemetation();

                    switch (Option)
                    {
                        case 1:
                            //OperationsDelegate opDelegate = 
                            createInformation.AddStudentInfo(Studentdata,UniqueNo);
                            break;
                        case 2:
                            Console.WriteLine("Getting all data...");
                            Console.WriteLine(new string('-', 40));
                            ValidationMethods.PrintList(Studentdata);
                            Console.WriteLine(new string('-', 40));
                            break;
                        case 3:
                            Filter.DisplayFilterMenu(Studentdata);
                            break;
                        case 4:
                            Console.WriteLine("Fetching students between age 15 to 25....");
                            FilterDataImplemetation.GiveStudentsBetweenAge15To25(Studentdata);
                            break;
                        case 5:
                            Console.WriteLine("Please enter a class");

                            string Class = "";
                            int SClass = 0;
                            int count = 1;
                            do
                            {
                                Class = Console.ReadLine();
                            }
                            while (!int.TryParse(Class, out SClass));

                            Console.WriteLine("Fetching Topper of the class...");

                            FilterDataImplemetation.GetToppers(Studentdata, SClass, 5, 0);
                            break;
                        case 6:
                            Console.WriteLine("Please enter a class");

                            string ClassOfStud = "";
                            int SClassOfStud = 0;
                            string DummyPos = "";
                            int Position = 0;
                            bool IsValid = false;

                            while (!IsValid)
                            {
                                ClassOfStud = Console.ReadLine();
                                if (!int.TryParse(ClassOfStud, out SClassOfStud))
                                {
                                    Console.WriteLine("Please enter a valid number within range 1-12");
                                }
                                else
                                {

                                    if (SClassOfStud >= 1 && SClassOfStud <= 12)
                                    {
                                        Console.WriteLine("Please enter a position");
                                        DummyPos = Console.ReadLine();
                                        if (!int.TryParse(DummyPos, out Position))
                                        {
                                            Console.WriteLine("Please enter only numeric and within range 1-12.");
                                        }
                                        else
                                        {
                                            IsValid = true;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter within range 1-12");
                                    }

                                }
                            }
                            Console.WriteLine("Fetching Nth Topper of the class...");

                            FilterDataImplemetation.GetToppers(Studentdata, SClassOfStud, 6, Position);

                            break;

                        case 7:
                            Console.WriteLine("Printing Student data every 10 seconds");
                            DisplayStudentData.ShowStudentData(Studentdata, true);
                            
                            break;
                        case 0:
                            Console.WriteLine("See you soon...");
                            return;
                        default:
                            Console.WriteLine("Please Select an option listed above!");
                            break;

                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                }
            }
        }

      

        }
}
