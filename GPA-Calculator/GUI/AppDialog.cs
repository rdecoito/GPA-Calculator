using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public AppDialog()
        {
            InitializeComponent();
            CreateCourseRow();
        }


        private bool ValidateCourses()
        {
            return true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateCourses())
                return;

            int totalCredits = 0;
            for (int i = 0; i < CourseCount; i++)
            {
                TextBox tb = m_tbCreditsList[i];
                totalCredits += tb.Text != Program.NULL_STR ? Convert.ToInt32(tb.Text) : 0;
            }
            if (totalCredits <= 0)
            {
                tbGPA.Text = "No Credits!";
                return;
            }

            double totalWeightedGrade = 0;
            for (int i = 0; i < CourseCount; i++)
            {
                double courseWeightedGrade = (m_tbGradeList[i].Text != Program.NULL_STR ?
                    double.Parse(m_tbGradeList[i].Text) : 0)
                    * (m_tbCreditsList[i].Text != Program.NULL_STR ? Convert.ToInt32(m_tbCreditsList[i].Text) : 0);
                totalWeightedGrade += courseWeightedGrade;
            }

            tbGPA.Text = Math.Round((totalWeightedGrade / totalCredits), 3).ToString();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CreateCourseRow();
            pnlCourses.ScrollControlIntoView(btnAddCourse);
        }
    }
}
