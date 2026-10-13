using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public  class Answer : ICloneable, IComparable<Answer>
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(string answerText) 
        {
            AnswerText = answerText;
        }

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

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }

        public int CompareTo(Answer other)
        {
            if (other==  null) 
                return 1;

            return AnswerId.CompareTo(other.AnswerId);
        }



    }
}
