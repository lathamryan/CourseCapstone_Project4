using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LathamRyan_Proj4_Capstone
{
    public class RegistrantOutput
    {
        public static string NumberOfCoursesOut;
        public static string FullNameOut;
        public static string DateOut;
        public static string CourseNumberOut;
        public static string CourseTypeOut;

        public static void GetRegistrant(string numberofcoursesout, string fullnameout, string dateout, string coursenumberout, string coursetypeout)
        {
            RegistrantOutput.NumberOfCoursesOut = numberofcoursesout;
            RegistrantOutput.FullNameOut = fullnameout;
            RegistrantOutput.DateOut = dateout;
            RegistrantOutput.CourseNumberOut = coursenumberout;
            RegistrantOutput.CourseTypeOut = coursetypeout;
        }
    }
}