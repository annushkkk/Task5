using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface IEnrolle
    {
        string Name { get; set; }
        int StudyTime(Dictionary<int, int> allGroup);
        int TuitionFee(Dictionary<String,int> cost);

    }
}
