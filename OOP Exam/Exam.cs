using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumsOfQuestions { get; set; }
        public Subject Subject { get; set; }
        public Question[] Questions { get; set; }



        //Abstarct Methods should be Created based on Child Needs inside child Class.
        public abstract void CreateExam();
        public abstract void ShowExam();

        //Fully Implemented To Take basic user prompts .
        public void BasicUserPrompt()
        {
            int QCount;
            int Extime;
            bool Flag;
           
            //Check validation of user input For "Exam time"
            do
            {
                Console.Write("Please Enter Time Of Exam in Minutes: ");
                Flag = int.TryParse(Console.ReadLine()?.Trim(), out Extime);
                if (Extime < 30 ||  Extime > 180)
                {
                    Console.WriteLine("Exam Time Must Be in rang of 30 to 180 minutes");
                    Flag = false;
                }

            } while (!Flag);
            
            //Assign Exam time to the object
            Time = Extime;

            //prompt user to enter
            do
            {
                Console.Write("Please Enter Count of questions u want to create: ");
                Flag = int.TryParse(Console.ReadLine()?.Trim(), out QCount);
                if(QCount <= 0)
                {
                    Console.WriteLine("Invalid input.");
                    Flag = false;
                }


            } while (!Flag);
            //Assign Question Count to the object
            NumsOfQuestions = QCount;

            Questions = new Question[NumsOfQuestions];

        }


        public void StartExam(out int TotalMark, out int FullMark)
        {
            int ToMark = 0, Fmark = 0;
            bool Flag;
            int ans;

            // Start Exam Qustions
            for (int i = 0, n = Questions.Length; i < n; i++)
            {
                Console.WriteLine($"==============================================\n{Questions[i].Header}\n{Questions[i].question}    (Mark: {Questions[i].Mark})");
                for (int j = 0, n1 = Questions[i].AnswerList.Length; j < n1; j++)
                {
                    Console.Write($"{Questions[i].AnswerList[j].Id}: {Questions[i].AnswerList[j].Text}                ");
                }
                Console.WriteLine("\n-----------------------------------------------");


                //prompt user to choose the correct answer.
                do
                {
                    Console.Write("Answer: ");
                    Flag = int.TryParse(Console.ReadLine(), out ans);
                    if (ans <= 0 || ans > Questions[i].AnswerList.Length)
                    {
                        Console.WriteLine("Invalid input.\nPlease Enter a vaild number.\n");
                        Flag = false;
                    }

                } while (!Flag );

                Questions[i].UserAnswer = Questions[i].AnswerList[ans - 1];


                //Check if Answer is Correct or Not
                if (ans == Questions[i].CorrectAnswer)
                {
                    ToMark += Questions[i].Mark;
                }
                Fmark += Questions[i].Mark;
            }
            FullMark = Fmark;
            TotalMark = ToMark;

        }


    }
}
