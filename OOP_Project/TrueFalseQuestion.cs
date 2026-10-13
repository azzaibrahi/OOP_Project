using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, bool correctValue)
        : base(header, body, mark, null, null)
        {
            AnswerList = new Answer[]{new Answer(1, "True"), new Answer(2, "False")};
            RightAnswer = correctValue ? AnswerList[0] : AnswerList[1];
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}: {Body} (Mark: {Mark})");
            foreach (Answer a in AnswerList)
                Console.WriteLine("   " + a);
        }

        public override object Clone()
        {
            return new TrueFalseQuestion(Header, Body, Mark, RightAnswer.AnswerId == 1);
        }

        public override string ToString()
        {
            return "[True/False] " + base.ToString();
        }









    }
}
