using static System.Console;

namespace CoreSchool.Utils
{
    public static class Printer
    {
        public static void DrawLine(int length = 15)
        {
            var newComputeLine = "".PadLeft(length, '=');
            WriteLine(newComputeLine);
        }

        public static void PrintTitle(string title)
        {
            int length = title.Length + 4;
            DrawLine(length);
            WriteLine($"| {title} |");
            DrawLine(length);
        }
    }
}