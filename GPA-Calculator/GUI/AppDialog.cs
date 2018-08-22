using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPA_Calculator.Util;

namespace GPA_Calculator.GUI
{
    public partial class AppDialog : Form
    {
        private List<TextBox> m_tbCourseNameList = new List<TextBox>();
        private List<TextBox> m_tbGradeList = new List<TextBox>();
        private List<TextBox> m_tbCreditsList = new List<TextBox>();

        public int LastCourseYLocation => CourseCount > 0 ?
            m_tbCourseNameList[CourseCount - 1].Location.Y  + m_tbCourseNameList[CourseCount - 1].Size.Height : 0;
        public int CourseCount = 0;
        public int LastTabIndex = 0;
        public GradeScale SelectedScale = new Util.FourPointGradeScale();
        
        
        public AppDialog()
        {
            InitializeComponent();
            CreateCourseRow();
        }


        private bool ValidateCourses()
        {
            return true;
        }

        private double GetGPAFromString(string grade)
        {
            double numericGrade;
            bool success = double.TryParse(grade, out numericGrade);
            if (success)
            {
                IEnumerable<double> minGrades = SelectedScale.GradeLowestNumericMapping.Keys
                    .OrderByDescending(d => d);
                foreach (double minGrade in minGrades)
                {
                    if (numericGrade >= minGrade)
                        return SelectedScale.GradeLowestNumericMapping[minGrade];
                }
            }

            grade = grade.ToUpper();
            IEnumerable<string> letterGrades = SelectedScale.GradeLetterMapping.Keys;
            foreach (string letterGrade in letterGrades)
            {
                if (grade == letterGrade)
                    return SelectedScale.GradeLetterMapping[letterGrade];
            }

            return -1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateCourses())
                return;

            int totalCredits = 0;
            foreach (TextBox tb in m_tbCreditsList)
                totalCredits += tb.Text != AppUtil.NULL_STR ? Convert.ToInt32(tb.Text) : 0;

            if (totalCredits <= 0)
            {
                tbGPA.Text = "No Credits!";
                return;
            }

            double totalWeightedGrade = 0;
            for (int i = 0; i < CourseCount; i++)
            {
                double courseWeightedGrade = GetGPAFromString(m_tbGradeList[i].Text)
                    * (m_tbCreditsList[i].Text != AppUtil.NULL_STR ? Convert.ToInt32(m_tbCreditsList[i].Text) : 0);
                totalWeightedGrade += courseWeightedGrade;
            }

            tbGPA.Text = Math.Round((totalWeightedGrade / totalCredits), 3, MidpointRounding.AwayFromZero).ToString();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CreateCourseRow();
            pnlCourses.ScrollControlIntoView(btnAddCourse);
        }
    }
}
