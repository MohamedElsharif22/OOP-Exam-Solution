using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class MCQuestion : Question
    {
        public override Answers UserAnswer { get; set; }


        public MCQuestion() 
        {
            Header = "MCQ Question.";
            AnswerList = new Answers[3];
            UserAnswer = new();
        }


        public override void CreateNewQustion(int n)
        {
            try
            {
                //Used variables
                int mark;
                int correctAns = 0;
                bool Flag ;
                //propmt user to enter Question body
                do
                {
                    Console.WriteLine($"Please Enter the body of the question {n}: ");
                    question = Console.ReadLine().Trim();

                } while (question is null || question.Length == 0);

                //prompt user to enter mark of the question
                do
                {
                    Console.Write("Please Enter The Mark of Question: ");
                    Flag = int.TryParse(Console.ReadLine()?.Trim(), out mark);

                    if (mark <= 0 )
                    {
                        Console.WriteLine("Invalid Input");
                        Flag = false;
                    }


                } while (!Flag);
                Mark = mark;

                //Intializing answers array and asigning it with the values
                for (int i = 0, N = AnswerList.Length; i < N; i++)
                {
                    string answer;
                    do
                    {
                        Console.Write($"Please Enter Choice Num {i + 1}: ");
                        answer = Console.ReadLine()?.Trim();

                    } while (answer is null || answer.Length == 0);
                    
                    AnswerList[i] = new Answers()
                    {
                        Id = i + 1,
                        Text = answer,
                    };
                }

                //prompt user to define the correct answer.
                do
                {
                    Console.Write("Please Enter the Number of The Correct answer: ");
                    Flag = int.TryParse(Console.ReadLine()?.Trim(), out correctAns);

                    if (correctAns is not (1 or 2 or 3))
                    {
                        Console.WriteLine("\nYou can only enter 1 or 2 or 3.");
                        Flag = false;
                    }
                } while (!Flag);
                CorrectAnswer = correctAns;

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
