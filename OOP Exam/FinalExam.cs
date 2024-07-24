using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class FinalExam : Exam
    {
        //Function That Creates The Exam And Check if user want it practical of Final
        public override void CreateExam()
        {
            //public variables
            int QuestionType;
            bool Flag ;

            try
            {
                //Prompt user for the basic Questions
                BasicUserPrompt();

                for (int i = 0; i < NumsOfQuestions; i++)
                {
                    //propmt user to choose the current question type.
                    do
                    {
                        Console.Write("Please Enter The type of Questions (1 For -> True or false , 2 for -> MCQ): ");
                        Flag = int.TryParse(Console.ReadLine()?.Trim(), out QuestionType);

                        if (QuestionType is not (1 or 2))
                        {
                            Console.WriteLine("You can only enter 1 or 2");
                            Flag = false;
                        }

                    } while (!Flag);
                    
                    
                    //Implement True or false functionality
                    if (QuestionType == 1) // If question type is true or false
                    {
                        Questions[i] = new TorFQuestion();
                        Console.WriteLine(Questions[i].Header);
                        Questions[i].CreateNewQustion(i + 1);

                    }
                    else if (QuestionType == 2) // If Question type is MCQ 
                    {
                        Questions[i] = new MCQuestion();
                        Console.WriteLine(Questions[i].Header);
                        Questions[i].CreateNewQustion(i + 1);

                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }

        public override void ShowExam()
        {
            
            StartExam(out int TotalMark, out int FullMark);
            try
            {
                Console.WriteLine("Your answers:");
                // Final Exam Shows the Questions, Answers and Grade. 
                for (int i = 0,n = Questions.Length; i < n; i++) 
                {
                    string CorrectAnswer = Questions[i].AnswerList[Questions[i].CorrectAnswer - 1].Text ;
                    Console.WriteLine($"Q{i + 1} ) {Questions[i].question}: {Questions[i].UserAnswer.Text}");
                }

                Console.WriteLine($"Your Grade is {TotalMark} of {FullMark}");

            }catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }

    
}
