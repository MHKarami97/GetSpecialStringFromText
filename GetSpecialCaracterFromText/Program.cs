using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace GetSpecialCaracterFromText
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<string>();

            var logFile = File.ReadAllLines(@"C:\Users\M-H-KARAMI\Downloads\1.xaml");

            foreach (var str in logFile)
            {
                var mcol = Regex.Matches(str, @">\b(.+?)\b<");

                foreach (Match m in mcol)
                {
                    list.Add(m.ToString().Replace("<", "").Replace(">", ""));
                }
            }

            File.WriteAllLines("SavedLists.txt", list);

            Console.WriteLine("Finish. Please enter any key");

            Console.ReadKey();
        }
    }
}
