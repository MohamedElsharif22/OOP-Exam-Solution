using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Answers
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string this[int Id]
        {
            get { return this.Text; }
        }
    }
}
