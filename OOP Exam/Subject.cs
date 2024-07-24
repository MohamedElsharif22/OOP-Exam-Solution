using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Subject : ICloneable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }
        public Subject(int id , string name) 
        {
            ID = id;
            Name = name;
        }

        //a Function That Creates needed Exam based on user Preference
        public void CreateExam()
        {
            //public variables
            int ExamType;
            bool Flag;   

            //prompt user to choose the type of the exam 
            do
            {
                Console.Write("Please Enter The type of the Exam you want to create (1 For Practical Exam, 2 For Final Exam): ");
                Flag = int.TryParse(Console.ReadLine().Trim(), out ExamType);

                if (ExamType is not (1 or 2))
                {
                    Console.WriteLine("You can only enter 1 or 2");
                    Flag = false;
                }

            }while (!Flag);

            //Prompt user to enter Exam Data.
            if(ExamType == 2) // Case user Choosed FinalExam
            {
                //Create an object from type Final Exam
                Exam = new FinalExam
                {
                    Subject = this
                };
                Exam.CreateExam();

            }else if (ExamType == 1) // Case user Choosed PracticalExam
            {
                Exam = new PracticalExam
                {
                    Subject = this
                };
                Exam.CreateExam();
            }


        }

        //Implementing IClonable InterFace To be able to take a coby inside Exam Class
        public object Clone()
        {
            return new Subject(ID, Name);
        }
    }
}
