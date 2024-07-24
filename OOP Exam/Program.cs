using System.Diagnostics;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main()
        {
            ///1. Createing Subject
            Subject Sub = new Subject(10, "C#");
            Sub.CreateExam();
            Console.Clear();
            Console.Write("Do U Want To Start Exam ? (Y For Yes - N For No) ");

            //Prompt user If Wants To Start the Exam?
            if(Console.ReadLine()?.Trim().ToLower() is ("y" or "yes"))
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Sub.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time is: {sw.Elapsed}");
            }

        }
    }
}
