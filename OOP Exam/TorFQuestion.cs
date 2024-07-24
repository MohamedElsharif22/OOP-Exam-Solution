using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    //True Or False Type Exam
    internal class TorFQuestion : Question
    {
        
        public override Answers UserAnswer { get; set; }

        public TorFQuestion()
        {
            Header = "True | False Question.";
            AnswerList = new Answers[2]
            {
                new Answers() { Id = 1 , Text = "True"},
                new Answers() { Id = 2 , Text = "False"}
            
            };
            UserAnswer = new Answers();
        }



        //Function that Creates A new qustion and intialize it with the values
        public override void CreateNewQustion(int i)
        {
            int mark;
            int correctAns;
            bool Flag;

            do
            {
                Console.WriteLine($"Please Enter the body of the question {i}: ");
                question = Console.ReadLine().Trim();
            } while (question is null || question.Length == 0);

            do
            {
                Console.Write("Please Enter The Mark of Question: ");
                Flag = int.TryParse(Console.ReadLine()?.Trim(), out mark);
                if (mark <= 0)
                {
                    Console.WriteLine("Invalid Input");
                    Flag = false;
                }


            } while (!Flag);
            //Intialize property with Mark Value
            Mark = mark;
            

            do
            {
                Console.Write("Please Enter The Correct answer of the question ( 1 For True - 2 For false): ");
                Flag = int.TryParse(Console.ReadLine()?.Trim(), out correctAns);

                if(correctAns is not (1 or 2))
                {
                    Console.WriteLine("You can only enter 1 or 2.");
                    Flag = false;
                }
            } while (!Flag);

            CorrectAnswer = correctAns;
        }
    }
}
