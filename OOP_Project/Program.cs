namespace OOP_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C#");

            subject.CreateExam();

            Console.WriteLine("\nStarting the exam...\n");
            subject.Exam.ShowExam();
        }
    }
}
