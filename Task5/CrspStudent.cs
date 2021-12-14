using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class CrspStudent : Student
    {
        String curatorsName;
        int additionalHours;

        public CrspStudent(string name, int group, string department, Dictionary<string, int> grades,string curatorsName, int additionalHours):base (name, group, department, grades)
        {
            this.curatorsName = curatorsName;
            this.additionalHours = additionalHours;
        }

        public int AdditionalHours { get => additionalHours; set => additionalHours = value; }
        public string CuratorsName { get => curatorsName; set => curatorsName = value; }

        public override int TuitionFee(Dictionary<string, int> cost)
        {
            Dictionary<String, int>.KeyCollection keyColl = cost.Keys;
            foreach (String s in keyColl)
            {
                if (s == Department) { return cost[s]; }  
            }
            return 0;
        }
        public double EmpPercentage(int studyT)
        {
           
            return Math.Round((double)AdditionalHours / studyT * 100); 
        }

        public override string ToString()
        {
            return "Name: " + Name + "; Group: " + Group + "; Department: " + Department + "; Grades: " + Grades["1s"]  + "; Curators name: " + CuratorsName + "; Additional hours: " + AdditionalHours;
            ;
        }
    }
}
