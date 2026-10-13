using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace OOP_Project
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Subject Subject { get; set; }

        protected Exam(int time, int numberOfQuestions, Subject subject)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Subject = subject;
            Questions = new Question[numberOfQuestions];
        }

        public abstract object Clone();

       
         public override string ToString()
        {
            return $"Time: {Time} min, Questions: {NumberOfQuestions}";
        }

        public int CompareTo(Exam other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return Time.CompareTo(other.Time);
            }



            }
    public abstract void ShowExam();
    }
    }

