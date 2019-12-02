using System;
using System.Collections.Generic;

namespace FirstHWASP
{
    public static class Service
    {

        public static void ShowStudent(Student student)
        {
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Average rating: {student.AverageMark}");
        }

        public static Student FindBestStudent(List<Student> students)
        {
            Student bestStudent = students[0];

            foreach (Student student in students)
            {
                if (student.AverageMark > bestStudent.AverageMark)
                {
                    bestStudent = student;
                }
            }

            return bestStudent;
        }

        public static Student FindWorstStudent(List<Student> students)
        {
            Student worstStudent = students[0];

            foreach (Student student in students)
            {
                if (student.AverageMark < worstStudent.AverageMark)
                {
                    worstStudent = student;
                }
            }

            return worstStudent;
        }

        public static double FindAverageMark(List<Student> students)
        {
            double sum = 0;

            foreach (Student student in students)
            {
                sum += student.AverageMark;
            }

            return sum / students.Count;
        }

        public static void AddStudent(List<Student> students)
        {
            Student newStudent = new Student()
            {
                Name = Information.SetName(),
                AverageMark = Information.SetAverageMark()
            };

            students.Add(newStudent);
        }
    }
}