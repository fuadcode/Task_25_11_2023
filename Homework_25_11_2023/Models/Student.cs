

namespace Homework_25_11_2023.Models
{
    public class Student
    {
        private static int counterId = 1;

        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname, double point)
        {

            Id = counterId++;
            Fullname = fullname;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Telebenin Id`si: {Id}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fullname: {Fullname}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Point: {Point}");
            Console.ResetColor();
        }
    }

}

