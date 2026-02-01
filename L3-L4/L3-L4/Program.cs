using System.Text.RegularExpressions;

namespace L3_L4
{
    enum Day { MONDAY, TUESDAY, WEDNESDAY, SATTURDAY, SUNDAY}
    enum Grade { A = 5, B = 4, C = 3, D = 2, F = 1 }
    enum Direction { NORTH, SOUTH, EAST, WEST }

    internal class Program
    {
        public static string ReverseWords(string wordStr)
        {
            var reversedWords = wordStr.Split(' ').Reverse();
            return string.Join(" ", reversedWords);
        }

        public static bool IsValidPassword(string password)
        {
            var isLengthValid = password.Length > 8;
            var hasOneOrMoreDigits = new Regex(@"\d").IsMatch(password);
            var hasOneOrMoreBigLetter = new Regex(@"[A-Z]").IsMatch(password);

            return isLengthValid && hasOneOrMoreDigits && hasOneOrMoreBigLetter;
        }

        public static bool IsWeekend(Day day) {
            return day == Day.SATTURDAY || day == Day.SUNDAY;
        }

        public static Direction? getOppositeDir(Direction currDir)
        {
            switch (currDir)
            {
                case Direction.NORTH: return Direction.SOUTH;
                case Direction.SOUTH: return Direction.NORTH;
                case Direction.EAST: return Direction.WEST;
                case Direction.WEST: return Direction.EAST;
                default: return null;
            }
        }


        static void Main(string[] args)
        {
            // Exercise 1.2
            string input = "Я изучаю Шарпы";
            string result = ReverseWords(input);
            Console.WriteLine(result + "\n\t");

            // Exercise 2.2
            string password1 = "ncdkck";
            string password2 = "Password123";
            Console.WriteLine(password1 + ": " + IsValidPassword(password1));
            Console.WriteLine(password2 + ": " + IsValidPassword(password2) + "\n\t");

            // Exercise 3.1
            Console.WriteLine(IsWeekend(Day.MONDAY));
            Console.WriteLine(IsWeekend(Day.SATTURDAY) + "\n\t");

            // Exercise 3.2
            var gradeChecker = new GradeChecker((int)Grade.A);
            Console.WriteLine(gradeChecker.IsPassed() ? "Succeded" : "Failed");

            // Exercise 3.3
            Console.WriteLine(getOppositeDir(Direction.NORTH));
            Console.WriteLine(getOppositeDir((Direction)9));

            // Exercise 4.1
            var book = new Book();
            book.Author = "Vasya Pupkin";
            book.Title = "Crazy man";
            book.Pages = 333;
            book.Year = 2025;
            Console.WriteLine(book.GetInfo());

            // Exercise 4.3
            var rect1 = new Rectangle();
            //rect1.Width = -10;
            //rect1.Height = -10;

            var rect2 = new Rectangle();
            rect2.Width = 10;
            rect2.Height = 10;
            Console.WriteLine(rect2.GetArea() + " " + rect2.GetPerimeter() + " " + rect2.IsSquare());

            // Exercise 5.1
            var calc = new Calculator();
            Console.WriteLine(calc.Multiply(2.39238, 4.8328));
            Console.WriteLine(calc.Multiply(3, 4, 5));
        }
    }
}
