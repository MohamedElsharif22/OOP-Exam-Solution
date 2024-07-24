using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    //Create constructor To intialize the values From the base Class
    internal class PracticalExam : Exam
    {

        public PracticalExam() 
        {
        
        }

        //Function That Creates The Exam
        public override void CreateExam()
        {
            try
            {
                BasicUserPrompt();

                for (int i = 0; i < NumsOfQuestions; i++)
                {
                    Questions[i] = new MCQuestion();
                    Console.WriteLine(Questions[i].Header);
                    Questions[i].CreateNewQustion(i + 1);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void ShowExam()
        {
            StartExam(out _, out _);
            try
            {
                Console.Clear();
                Console.WriteLine("Your answers:");

                //Practical Exam Shows the right answer after finishing the Exam.

                for (int i = 0, n = Questions.Length; i < n; i++)
                {
                    string CorrectAnswer = Questions[i].AnswerList[Questions[i].CorrectAnswer - 1].Text;
                    Console.WriteLine($"Q{i + 1} ) {Questions[i].question}: {CorrectAnswer}");
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
