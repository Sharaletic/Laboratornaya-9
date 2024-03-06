using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class History : Discipline, IHaveAngryTeacher
    {
        public History(string name)
        {
            this.name = name;
        }
        public int PracticeCount { get; set; }
        public override string Check(Student student)
        {
            if (PracticeCount == student.practices[this])
            {
                return "Автомат по дисциплине История получить нельзя";
            }
            else
            {
                return "Автомат по дисциплине История получить нельзя";
            }
        }
    }
}
