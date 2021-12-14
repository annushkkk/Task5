using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class OlympStudent : Student
    {
        int grant;
        Dictionary<String, int> tournmentRes;

        public OlympStudent(string name, int group, string department, Dictionary<string, int> grades,int grant, Dictionary<String, int> tournmentRes) : base(name, group, department, grades)
        {
            this.grant = grant;
            this.tournmentRes = tournmentRes;
        }

        public int Grant { get => grant; set => grant = value; }
        public Dictionary<string, int> TournmentRes { get => tournmentRes; set => tournmentRes = value; }

        public override int TuitionFee(Dictionary<string, int> cost)
        {
            Dictionary<String, int>.KeyCollection keyColl = cost.Keys;
            foreach (String s in keyColl)
            {
                if (s == Department) { return cost[s]; }
            }
            return 0;
        }
        /*public int SrchPlaceOnTourments(String tourment)
        {
            Dictionary<String, int>.KeyCollection keyColl = tournmentRes.Keys;
            foreach (string s in keyColl)
            {
                if (s == tourment) { return tournmentRes[s]; }
            }
            return 0;
        }*/
        public int LastWin()
        {
            return Grant;
        }
    }
}
