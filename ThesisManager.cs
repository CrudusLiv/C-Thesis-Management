using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP101_Assignment
{
    public class ThesisManager
    {
        private static string[] theses = new string[20];
        private static string[] borrowedTheses = new string[20];

        public static string[] GetTheses()
        {
            return theses;
        }

        public static void AddThesis(string thesisInfo)
        {
            theses[theses.Length - 1] = thesisInfo;
        }

        public static bool IsThesisAvailable(string thesisID)
        {
            return !borrowedTheses.Contains(thesisID);
        }

    }
}
