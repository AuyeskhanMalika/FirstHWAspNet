using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstHWASP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool isFinish = false;

            while (true)
            {
                if (isFinish)
                {
                    break;
                }

                Console.Clear();

                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show Best Student");
                Console.WriteLine("3.Show Worst Student");
                Console.WriteLine("4.Find Average Mark");
                Console.WriteLine("5.Exit");

                string choice = Console.ReadLine().Trim();
                int choiceInt;

                if (int.TryParse(choice, out choiceInt))
                {
                    Console.Clear();

                    switch (choiceInt)
                    {
                        case 1:
                            Service.AddStudent(students);
                            break;
                        case 2:
                            Service.ShowStudent(Service.FindBestStudent(students));
                            Console.ReadKey();
                            break;
                        case 3:
                            Service.ShowStudent(Service.FindWorstStudent(students));
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine($"Average Mark: {Service.FindAverageMark(students)}");
                            Console.ReadKey();
                            break;
                        case 5:
                            isFinish = true;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Make the right choice");
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
