using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP101_Assignment
{
    public class Thesis
    {
        private string id;
        private string title;
        private string author;
        private int yearPublished;
        private static string[] borrowedTheses = new string[20];

        public Thesis(string id, string title, string author, int yearPublished)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.yearPublished = yearPublished;
        }

        public string GetId()
        {
            return id;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public int GetYearPublished()
        {
            return yearPublished;
        }

        public int CalculateFine(DateTime borrowDate)
        {
            int daysOverdue = (DateTime.Now - borrowDate).Days;
            int fine = 0;

            if (daysOverdue > 0)
            {
                fine = daysOverdue * 10;
            }

            return fine;
        }

        public bool IsAvailable()
        {
            // Check if the thesis is not in the borrowed theses array
            return !borrowedTheses.Contains(id);
        }
    }
}
