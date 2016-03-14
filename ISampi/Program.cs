using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISampi
{
    interface IHighSchool
    {
        string School { get; set; }
        int Grade { get; set; }

        bool SenpaiNotice(IHighSchool senpai);

    }
    interface IMechPilot
    {
        string MechName { get; set; }
        int Attack { get; set; }
        int Defence { get; set; }

        void ItsaAngle(IMonster angle);

    }
    interface IMonster
    {
        int Level { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
