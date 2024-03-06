using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laboratornaya_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Курченко Владислава");
            Student student2 = new Student("Казанцев Антон");
            Student student3 = new Student("Житникова Екатерина");
            Student student4 = new Student("Найданова Екатерина");
            List<Student> students = new List<Student>() { student1, student2, student3, student4 };

            MathematicalAnalysis mathematicalAnalysis = new MathematicalAnalysis("Математический анализ");
            mathematicalAnalysis.PassingScore = 4.8;
            Programming programming = new Programming("Программирование");
            programming.PractieCount = 10;
            History history = new History("История");
            history.PracticeCount = 5;
            List<Discipline> disciplines = new List<Discipline>() { mathematicalAnalysis, programming, history };

            student1.finalControl.Add(disciplines[0], 5);
            student1.practices.Add(disciplines[1], 10);
            student1.practices.Add(disciplines[2], 5);

            student2.finalControl.Add(disciplines[0], 4.8);
            student2.practices.Add(disciplines[1], 9);
            student2.practices.Add(disciplines[2], 5);

            student3.finalControl.Add(disciplines[0], 4.9);
            student3.practices.Add(disciplines[1], 10);
            student3.practices.Add(disciplines[2], 5);

            student4.finalControl.Add(disciplines[0], 4.5);
            student4.practices.Add(disciplines[1], 10);
            student4.practices.Add(disciplines[2], 4);

            Console.WriteLine("-------------------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine(student.name);
                foreach(var discipline in disciplines)
                {
                    if (discipline is IHaveAngryTeacher)
                    {
                        Console.WriteLine(discipline.Check(student));
                    }
                    else
                    {
                        Console.WriteLine(discipline.Check(student));
                    }
                }
                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
