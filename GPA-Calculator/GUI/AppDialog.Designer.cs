namespace GPA_Calculator.GUI
{
    partial class AppDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Creates a row of text boxes for a new course
        /// </summary>
        private void CreateCourseRow()
        {
            SuspendLayout();

            System.Windows.Forms.TextBox newTbCourseName = new System.Windows.Forms.TextBox();
            newTbCourseName.Location = new System.Drawing.Point(lblCourseName.Location.X - pnlCourses.Location.X,
                LastCourseYLocation + 6);
            newTbCourseName.Name = "tbClassName" + CourseCount + 1;
            newTbCourseName.Size = new System.Drawing.Size(100, 22);
            newTbCourseName.TabIndex = ++LastTabIndex;
            pnlCourses.Controls.Add(newTbCourseName);
            m_tbCourseNameList.Add(newTbCourseName);

            System.Windows.Forms.TextBox newTbGrade = new System.Windows.Forms.TextBox();
            newTbGrade.Location = new System.Drawing.Point(lblGrade.Location.X - pnlCourses.Location.X,
                LastCourseYLocation + 6);
            newTbGrade.Name = "tbGrade" + CourseCount + 1;
            newTbGrade.Size = new System.Drawing.Size(100, 22);
            newTbGrade.TabIndex = ++LastTabIndex;
            pnlCourses.Controls.Add(newTbGrade);
            m_tbGradeList.Add(newTbGrade);

            System.Windows.Forms.TextBox newTbCredits = new System.Windows.Forms.TextBox();
            newTbCredits.Location = new System.Drawing.Point(lblCredits.Location.X - pnlCourses.Location.X,
                LastCourseYLocation + 6);
            newTbCredits.Name = "tbCredits" + CourseCount + 1;
            newTbCredits.Size = new System.Drawing.Size(100, 22);
            newTbCredits.TabIndex = ++LastTabIndex;
            pnlCourses.Controls.Add(newTbCredits);
            m_tbCreditsList.Add(newTbCredits);

            CourseCount++;
            btnAddCourse.Location = new System.Drawing.Point(btnAddCourse.Location.X, LastCourseYLocation + 6);
            btnAddCourse.TabIndex = LastTabIndex + 1;

            ResumeLayout();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbGPA = new System.Windows.Forms.TextBox();
            this.pnlCourses = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.pnlCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(13, 13);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(94, 17);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(188, 13);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 17);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Grade";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(359, 13);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(52, 17);
            this.lblCredits.TabIndex = 2;
            this.lblCredits.Text = "Credits";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(410, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbGPA
            // 
            this.tbGPA.Location = new System.Drawing.Point(505, 300);
            this.tbGPA.Name = "tbGPA";
            this.tbGPA.ReadOnly = true;
            this.tbGPA.Size = new System.Drawing.Size(100, 22);
            this.tbGPA.TabIndex = 5;
            // 
            // pnlCourses
            // 
            this.pnlCourses.AutoScroll = true;
            this.pnlCourses.Controls.Add(this.btnAddCourse);
            this.pnlCourses.Location = new System.Drawing.Point(10, 33);
            this.pnlCourses.Name = "pnlCourses";
            this.pnlCourses.Size = new System.Drawing.Size(589, 261);
            this.pnlCourses.TabIndex = 3;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(6, 3);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(91, 23);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // AppDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 397);
            this.Controls.Add(this.pnlCourses);
            this.Controls.Add(this.tbGPA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblCourseName);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "AppDialog";
            this.Text = "GPA Calculator";
            this.pnlCourses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbGPA;
        private System.Windows.Forms.Panel pnlCourses;
        private System.Windows.Forms.Button btnAddCourse;
    }
}

