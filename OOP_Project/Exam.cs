using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace OOP_Project
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {        
              //Properties
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Subject Subject { get; set; }      //Nevegational property to Subject class

        protected Exam(int time, int numberOfQuestions, Subject subject)
        {
            Time = time;
               NumberOfQuestions = numberOfQuestions;
           Subject = subject;
            Questions = new Question[numberOfQuestions];
        }

       

       
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


        public abstract object Clone();
    }
    }

