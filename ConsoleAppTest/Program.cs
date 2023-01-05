using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppTest
{
    public class StudentMarks
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int Marks { get; set; }

        void Mark()
        {
            var studentsMarks = new List<StudentMarks>();
            studentsMarks.Add(new StudentMarks { StudentId = 1, ExamId = 1, Marks = 50 });
            studentsMarks.Add(new StudentMarks { StudentId = 1, ExamId = 2, Marks = 30 });
            studentsMarks.Add(new StudentMarks { StudentId = 1, ExamId = 3, Marks = 60 });

            studentsMarks.Add(new StudentMarks { StudentId = 2, ExamId = 1, Marks = 30 });
            studentsMarks.Add(new StudentMarks { StudentId = 2, ExamId = 2, Marks = 40 });
            studentsMarks.Add(new StudentMarks { StudentId = 2, ExamId = 3, Marks = 50 });

            var s = studentsMarks.GroupBy(x => x.ExamId);
            var s1 = new List<StudentMarks>();
            foreach (var item in s)
            {
                item.OrderBy(x => x.Marks);
              
            }
            //            ExamaId StudentId
            //1              1
            //2               2
            //3               1


        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            var studentsMarks = new List<StudentMarks>();
            studentsMarks.Add(new StudentMarks { StudentId = 1, ExamId = 1, Marks = 50 });
            studentsMarks.Add(new StudentMarks { StudentId = 1, ExamId = 2, Marks = 30 });
            studentsMarks.Add(new StudentMarks { StudentId = 1, ExamId = 3, Marks = 60 });

            studentsMarks.Add(new StudentMarks { StudentId = 2, ExamId = 1, Marks = 30 });
            studentsMarks.Add(new StudentMarks { StudentId = 2, ExamId = 2, Marks = 40 });
            studentsMarks.Add(new StudentMarks { StudentId = 2, ExamId = 3, Marks = 50 });

            var studentMarksGroup = studentsMarks.OrderByDescending(x=>x.Marks).GroupBy(x => x.ExamId);
            var resultMarks = new List<StudentMarks>();
            foreach (var item in studentMarksGroup)
            {

                for (int i = 0; i < 1; i++)
                {
                    resultMarks.Add(item.FirstOrDefault());
                }

            }

            Console.WriteLine(" Student Id------ Exam Id");
            foreach (var item in resultMarks)
            {
                Console.Write(item.StudentId + "-------" + item.ExamId);
                Console.WriteLine();
            }

        }
    }
}
