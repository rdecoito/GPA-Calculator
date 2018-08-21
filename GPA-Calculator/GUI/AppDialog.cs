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


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //int totalCredits = m_credits1 + m_credits2 + m_credits3;
            //if (totalCredits <= 0)
            //{
            //    tbGPA.Text = "No Credits!";
            //    return;
            //}

            //double weightedGrade1 = m_credits1 * (tbGrade1.Text != "" ? double.Parse(tbGrade1.Text) : 0);
            //double weightedGrade2 = m_credits2 * (tbGrade2.Text != "" ? double.Parse(tbGrade2.Text) : 0);
            //double weightedGrade3 = m_credits3 * (tbGrade3.Text != "" ? double.Parse(tbGrade3.Text) : 0);

            //tbGPA.Text = ((weightedGrade1 + weightedGrade2 + weightedGrade3) / totalCredits).ToString();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            CreateCourseRow();
            pnlCourses.ScrollControlIntoView(btnAddCourse);
        }
    }
}
