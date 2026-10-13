using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header   { get; set; }
       public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        protected Question(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        public abstract void ShowQuestion();
        public abstract object Clone();

        public override string ToString()
        {
            return $"{Header}: {Body} (Mark: {Mark})";
        }

        public int CompareTo(Question other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo (other.Mark);
        }
    }







}

