using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
    {
        private static void SectionTitle(string title)
        {
            WriteLine();
            ConsoleColor previousColor = ForegroundColor; // safe the default color
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine($"*** {title} ***");
            ForegroundColor = previousColor; // restore the default color
        }
    }
