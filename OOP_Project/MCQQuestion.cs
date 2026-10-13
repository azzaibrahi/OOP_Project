using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer)
       : base(header, body, mark, answerList, rightAnswer)
        {
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}: {Body} (Mark: {Mark})");
            foreach (Answer a in AnswerList)
                Console.WriteLine("   " + a);
        }

        public override object Clone()
        {
            Answer[] copiedAnswers = new Answer[AnswerList.Length];
            Answer copiedRight = null;

            for (int i = 0; i < AnswerList.Length; i++)
            {
                     copiedAnswers[i] = (Answer)AnswerList[i].Clone();
                if (AnswerList[i]   ==   RightAnswer)
                    copiedRight = copiedAnswers[i];
            }

            return new MCQQuestion(Header, Body, Mark, copiedAnswers, copiedRight);
        }

        public override string ToString()
        {
            return "[MCQ] " + base.ToString();
        }


    }
}
