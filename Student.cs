using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_9
{
    public class Student
    {
        public string name {  get; set; }
        public Dictionary<Discipline, int> practices;
        public Dictionary<Discipline, double> finalControl;
        public Student(string name)
        {
            this.name = name;
            practices = new Dictionary<Discipline, int>();
            finalControl = new Dictionary<Discipline, double>();
        }
        
    }
}
