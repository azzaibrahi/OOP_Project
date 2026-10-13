using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public class FinalExam : Exam
    { 
         //  additional properties 
        public int Grade { get; set; }
        public int TotalMarks { get; set; }

        //base constructor 
        public FinalExam(int time, int numberOfQuestions, Subject subject)
            : base(time, numberOfQuestions, subject)
        {
        }

        public override void ShowExam()
        {
            Grade = 0;          // reset on every run
            TotalMarks = 0;

            Console.WriteLine("---- Final Exam ---- ");
            foreach (Question q in Questions)
            {
                q.ShowQuestion();
                TotalMarks += q.Mark;

                Console.Write("Your answer (Id): ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == q.RightAnswer.AnswerId)
                    Grade += q.Mark;

                Console.WriteLine();
            }

            Console.WriteLine($"Your Grade: {Grade} / {TotalMarks}");
        }
          
        public override object Clone()
        {
            FinalExam copy = new FinalExam(Time, NumberOfQuestions, Subject);
            for (int i = 0; i < Questions.Length; i++)
                copy.Questions[i] = (Question)Questions[i].Clone();
            return copy;
        }

        public override string ToString()
        {
            return "[Final Exam] " + base.ToString();
        }
       

    }
}
