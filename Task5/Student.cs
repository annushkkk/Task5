using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    abstract class Student:IEnrolle
    {
        public string Name { get; set ; }
        public string Department { get => department; set => department = value; }
        public Dictionary<string, int> Grades { get => grades; set => grades = value; }
        public int Group { get => group; set => group = value; }

        private int group;
        private string department ;
        private Dictionary<string, int> grades;

        protected Student(string name, int group, string department, Dictionary<string, int> grades)
        {
            Name = name;
            this.group = group;
            this.department = department;
            this.grades = grades;
        }

        public double AvgScore()
        {
            Dictionary<string, int>.KeyCollection keyColl = Grades.Keys;
            int Sum = 0;
            int Count = Grades.Count;
            foreach (string s in keyColl)
            {
                Sum += Grades[s];
            }
            double Avg = (double)Sum / Count;
            double Ravg = Math.Round(Avg,2);
            return Ravg;
        }

        public int StudyTime(Dictionary<int, int> allGroup)
        {
            Dictionary<int, int>.KeyCollection keyColl = allGroup.Keys;
            foreach (int s in keyColl)
            {
                if (s==Group) { return allGroup[s]; }
            }
            return 0;

        }

        abstract public int TuitionFee(Dictionary<string, int> cost);

        
    }
}
