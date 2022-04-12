﻿using static System.Console;
namespace SchoolsCore.Util

{
    public static class Printer
    {
        public static void DrawLine(int size = 10)
        {
            WriteLine("".PadLeft(size, '='));
        }

        public static void WriteTitle(string title)
        {
            var size = title.Length + 4;
            DrawLine(size);
            WriteLine($"| {title} |");
            DrawLine(size);
        }

        public static void Beep(int hz = 2000, int time = 500, int quantity = 1)
        {
            while (quantity-- > 0)
            {
                System.Console.Beep(hz, time);
            }
        }
    }
}