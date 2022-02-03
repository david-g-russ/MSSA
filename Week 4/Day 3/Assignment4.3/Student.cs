using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._3
{
    enum GradeLevel
    {
        Sixth,
        Seventh,
        Eighth,
        Ninth,
        Tenth,
        Eleventh,
        Twelfth
    }

    enum MonthAdm
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }

    enum Grade
    {
        APlus,
        A,
        AMinus,
        BPlus,
        B,
        BMinus,
        CPlus,
        C,
        CMinus,
        DPlus,
        D,
        DMinus,
        F
    }

    internal struct Student
    {
        // public properties
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }

        public GradeLevel GradeLevel { get; set; }
        public Grade Grade { get; set; }
        public MonthAdm MonthAdm { get; set; }


    }
}
