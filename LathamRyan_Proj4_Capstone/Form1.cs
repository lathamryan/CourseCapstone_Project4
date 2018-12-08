using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LathamRyan_Proj4_Capstone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //set default for class type group box
            rdbHybrid.Checked = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                //Perform check on data if present in all text box fields
                if (IsValidData())
                {
                    //Pull data from text boxes, convert to string and sent to variable for processing
                    string tempcourses = Convert.ToString(txtNmbrCrs.Text);
                    string tempfullname = Convert.ToString(txtFullNm.Text);

                    //Using RexEx to clean string because it grabs all punctuation 
                    string pattern = @"[\p{P}]";
                    string cleannumbercourses = Regex.Replace(tempcourses, pattern, "");
                    string cleanfullname = Regex.Replace(tempfullname, pattern, "");

                    //Send clean string back to text box
                    txtNmbrCrs.Text = cleannumbercourses.ToString();
                    txtFullNm.Text = cleanfullname.ToString();

                    //Gather all input data to send to the RegistrantInkake Class 
                    string numberofcoursesin = txtNmbrCrs.Text;
                    string fullnamein = txtFullNm.Text;
                    string datein = calRegDate.SelectionRange.Start.ToShortDateString();
                    string coursenumberin = cmbCrsSlct.SelectedValue.ToString();
                    string coursetypein = null;
                    bool isChecked = rdbHybrid.Checked;
                    if (isChecked)
                        coursetypein = rdbHybrid.Text;
                    else
                        coursetypein = rdbOnline.Text;

                    //Send clean input data to the RegistrantInkake Class 
                    RegistrantIntake.SetRegistrant(numberofcoursesin, fullnamein, datein, coursenumberin, coursetypein);
                }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Check if course type is null, to see if this is the first registration. Otherwise it will always not equal and throw exception. 
            if (RegistrantOutput.NumberOfCoursesOut == null)
            {
                WriteRegData();
            }
            //After establishing there is an initial entry, then check to see if equal(has changed). If so, throw message box exception with selection choices.
            else if (RegistrantIntake.NumberOfCoursesIn != RegistrantOutput.NumberOfCoursesOut)
            {
                DialogResult button = 
                    MessageBox.Show(
                        "The number of courses you're registering for has changed. Click OK to confirm these changes, or click Cancel to keep your original entry",
                        "Number of Courses",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Exclamation);
                //Sub if/else to determine what to do based on user's feedback. Either keep new value, or discard and reset with old value
                if (button == DialogResult.OK)
                {
                    RegistrantOutput.NumberOfCoursesOut = RegistrantIntake.NumberOfCoursesIn;
                    WriteRegData();
                }
                else
                {
                    RegistrantIntake.NumberOfCoursesIn = RegistrantOutput.NumberOfCoursesOut;
                    WriteRegData();
                }
            }
            //if nothing has changed continue to write registrant data
            else
            {
                WriteRegData();
            }
            
        }
        private void WriteRegData()
        {
            //Get data from RegistrantIntake Class and send to RegistrantOutput Class
            string numberofcoursesout = RegistrantIntake.NumberOfCoursesIn;
            string fullnameout = RegistrantIntake.FullNameIn;
            string dateout = RegistrantIntake.DateIn;
            string coursenumberout = RegistrantIntake.CourseNumberIn;
            string cousetypeout = RegistrantIntake.CourseTypeIn;
            RegistrantOutput.GetRegistrant(numberofcoursesout, fullnameout, dateout, coursenumberout, cousetypeout);

            //Write registrant data to text boxes
            txtNmbrCrsDsp.Text = RegistrantOutput.NumberOfCoursesOut;
            txtFullNmDsp.Text = RegistrantOutput.FullNameOut;
            txtRegDateDsp.Text = RegistrantOutput.DateOut;
            txtCrsSlctDsp.Text = RegistrantOutput.CourseNumberOut;
            txtCrsTypDsp.Text = RegistrantOutput.CourseTypeOut;
        }

        //IsValidData function from that calls Validator Class and IsPresent and IsInteger functions to check that text boxes were filled in and with valid data
        //This code was adapted from Chapter 12 of Murach's Product Maintenance application 
        private bool IsValidData()
        {
            return Validator.IsPresent(txtNmbrCrs) &&
                Validator.IsPresent(txtFullNm) &&
                Validator.IsInteger(txtNmbrCrs);
        }

        public static class Validator
        {
            private static string title = "Entry Error";

            public static string Title
            {
                get
                {
                    return title;
                }
                set
                {
                    title = value;
                }
            }
            public static bool IsPresent(TextBox textBox)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                return true;
            }
            public static bool IsInteger(TextBox textBox)
            {
                int number = 0;
                if (int.TryParse(textBox.Text, out number))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(textBox.Tag + " must be a whole number such as 1, 2, 3, etc.", Title);
                    textBox.Focus();
                    return false;
                }
            }
        }

        //This code is automatically generated when creating data binding with SQL database
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classRegDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.classRegDataSet.Course);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
