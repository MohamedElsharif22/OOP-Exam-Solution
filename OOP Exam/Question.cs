using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string question { get; set; }
        public int Mark { get; set; }
        public Answers[] AnswerList { get; set; }
        public abstract Answers UserAnswer { get; set; }

        internal int CorrectAnswer { get; set; }


        public abstract void CreateNewQustion(int i);
    }
}
