using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project
{
    public class Subject:ICloneable,IComparable<Subject>
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }     //Navigation property to Exam class

        public Subject(int subjectId) : this(subjectId, "")
        {
        }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            Console.WriteLine("Choose exam type: 1) Final  2) Practical");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter exam time (minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter number of questions: ");
            int n = int.Parse(Console.ReadLine());

            if (type == 1)
                Exam = new FinalExam(time, n, this);
            else
                Exam = new PracticalExam(time, n, this);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Question {i + 1} ---");

                int qType = 2;
                if (type == 1)
                {
                    Console.WriteLine("Question type: 1) True/False  2) MCQ");
                    qType = int.Parse(Console.ReadLine());
                }

                Console.Write("Header: ");
                string header = Console.ReadLine();
                Console.Write("Body: ");
                string body = Console.ReadLine();
                Console.Write("Mark: ");
                int mark = int.Parse(Console.ReadLine());

                if (qType == 1)
                {
                    Console.Write("Is the statement true? (1 = True, 2 = False): ");
                    bool correct = int.Parse(Console.ReadLine()) == 1;
                    Exam.Questions[i] = new TrueFalseQuestion(header, body, mark, correct);
                }
                else
                {
                    Console.Write("Number of answers: ");
                    int count = int.Parse(Console.ReadLine());

                    Answer[] answers = new Answer[count];
                    for (int j = 0; j < count; j++)
                    {
                        Console.Write($"Answer {j + 1} text: ");
                        answers[j] = new Answer(j + 1, Console.ReadLine());
                    }

                    Console.Write("Right answer Id: ");
                    int rightId = int.Parse(Console.ReadLine());

                    Exam.Questions[i] = new MCQQuestion(header, body, mark, answers, answers[rightId - 1]);
                }
            }
        }

        public override string ToString()
        {
            return $"Subject {SubjectId}: {SubjectName}";
        }

        public object Clone()
        {
            return new Subject(SubjectId, SubjectName);
        }

        public int CompareTo(Subject other)
        {
            if (other == null) return 1;
            return SubjectId.CompareTo(other.SubjectId);
        }
    }
}
