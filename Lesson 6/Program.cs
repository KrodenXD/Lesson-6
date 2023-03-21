using System;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            Ref(ref t);
            Out(out t);
        }

        public static int Ref(ref int t)
        {
            t = t * t;
            return 0;
        }
        public static int Out(out int t)
        {
            t = ;
            return 0;
        }
    }
}
