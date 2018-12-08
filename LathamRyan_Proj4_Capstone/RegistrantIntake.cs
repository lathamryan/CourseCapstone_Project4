using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LathamRyan_Proj4_Capstone
{   
    //first class created to hold registant input data
    public class RegistrantIntake
    {
        public static string NumberOfCoursesIn;
        public static string FullNameIn;
        public static string DateIn;
        public static string CourseNumberIn;
        public static string CourseTypeIn;

        //this function recieves the data passed 
        public static void SetRegistrant(string numberofcoursesin, string fullnamein, string datein, string coursenumberin, string coursetypein)
        {
            RegistrantIntake.NumberOfCoursesIn = numberofcoursesin;
            RegistrantIntake.FullNameIn = fullnamein;
            RegistrantIntake.DateIn = datein;
            RegistrantIntake.CourseNumberIn = coursenumberin;
            RegistrantIntake.CourseTypeIn = coursetypein;
        }
    }
}
