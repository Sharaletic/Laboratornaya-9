using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class MathematicalAnalysis : Discipline, IHaveFinalControll
    {
        public MathematicalAnalysis(string name)
        {
            this.name = name;
        }
        public double PassingScore { get; set; }
        public override string Check(Student student)
        {
            if (PassingScore <= student.finalControl[this])
            {
                return "Получает автомат по дисциплине Математический анализ";
            }
            else
            {
                return "Не получает автомат по дисциплине Математический анализ";
            }
        }
    }
}
