using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions, Subject subject)
                : base(time, numberOfQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("===== Practical Exam =====");
            foreach (Question q in Questions)
            {
                q.ShowQuestion();
                Console.Write("Your answer (Id): ");
                Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("===== Right Answers =====");
            foreach (Question q in Questions)
            {
                Console.WriteLine($"{q.Header}: {q.RightAnswer}");
            }
        }

        public override object Clone()
        {
            PracticalExam copy = new PracticalExam(Time, NumberOfQuestions, Subject);
            for (int i = 0; i < Questions.Length; i++)

                copy.Questions[i] = (Question)Questions[i].Clone();  // Deep copy and Casting

            return copy;
        }

        public override string ToString()
        {
            return "[Practical Exam] " + base.ToString();
        }




    }
}
