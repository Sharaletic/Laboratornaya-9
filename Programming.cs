using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class Programming : Discipline, IHavePractice
    {
        public Programming(string name)
        {
            this.name = name;
        }
        public int PractieCount { get; set; }
        public override string Check(Student student)
        {
            if (PractieCount <= student.practices[this])
            {
                return "Получает автомат по дисциплине Программирование";
            }
            else
            {
                return "Не получает автомат по дисциплине Программирование";
            }
        }
    }
}
