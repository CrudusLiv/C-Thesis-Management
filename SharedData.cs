using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DIP101_Assignment
{
    public class SharedData
    {
        // Declare the shared arrays
        private static string[] students = new string[20];
        private static string[] theses = new string[20];
        private static List<string> availableTheses = new List<string>();
        private static string[] borrowedTheses = new string[20];

        private static int[] fines = new int[20];

        // Getters and setters for the shared arrays
        public static string[] Students { get { return students; } }
        public static string[] Theses { get { return theses; } }
        public static List<string> AvailableTheses { get { return availableTheses; } }
        public static string[] BorrowedTheses { get { return borrowedTheses; } }
        public static int[] Fines { get { return fines; } }

        // Method to correct the borrow date format in the borrowedTheses array
        public static string CorrectBorrowDateFormat(string borrowedThesis)
        {
            // Check if the borrowed thesis is not null
            if (borrowedThesis != null)
            {
                Console.WriteLine($"Processing borrowed thesis: {borrowedThesis}");
                string[] borrowDateParts = borrowedThesis.Split(',');

                // Check if the borrow date format is invalid
                if (!DateTime.TryParseExact(borrowDateParts[2], "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    Console.WriteLine($"Invalid borrow date format found: {borrowedThesis}");
                    // Try to parse and correct the borrow date format
                    if (DateTime.TryParse(borrowDateParts[2], out DateTime parsedDate))
                    {
                        borrowDateParts[2] = parsedDate.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        Console.WriteLine($"Unable to parse the date: {borrowDateParts[2]}");
                        // You may want to handle this case based on your application's requirements
                        // For now, let's assume you want to set it to a default value.
                        borrowDateParts[2] = DateTime.Now.ToString("MM/dd/yyyy");
                    }
                }

                // Join the corrected parts back into a string
                string correctedThesis = string.Join(",", borrowDateParts);

                return correctedThesis;
            }

            return null;
        }
    }
}



