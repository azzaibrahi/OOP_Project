using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public  class Answer : ICloneable, IComparable<Answer>
    {          //Properties
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        //Constructors
        public Answer(string answerText) 
        {
            AnswerText = answerText;
        }
        //chain constructor
        public Answer(int answerId) : this("")
        {
            AnswerId = answerId;
        }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"AnswerId :: {AnswerId}, AnswerText :: {AnswerText}";
        }
                    // clone method to create a copy 
        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
        // CompareTo method to compare two Answer objects based on AnswerId
        public int CompareTo(Answer other)
        {
            if (other==  null) 
                return 1;

            return AnswerId.CompareTo(other.AnswerId);
        }



    }
}
