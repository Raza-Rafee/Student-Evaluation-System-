namespace EvaluationSystem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsStudents = new System.Windows.Forms.ToolStripButton();
            this.tsGrades = new System.Windows.Forms.ToolStripButton();
            this.tsSubject = new System.Windows.Forms.ToolStripButton();
            this.tsCourses = new System.Windows.Forms.ToolStripButton();
            this.tsUsers = new System.Windows.Forms.ToolStripButton();
            this.tsPreRequisite = new System.Windows.Forms.ToolStripButton();
            this.tsReports = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFindstudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(70, 70);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStudents,
            this.tsGrades,
            this.tsSubject,
            this.tsCourses,
            this.tsUsers,
            this.tsPreRequisite,
            this.tsReports,
            this.toolStripSeparator1,
            this.tsFindstudent,
            this.toolStripSeparator2,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 92);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsStudents
            // 
            this.tsStudents.Image = ((System.Drawing.Image)(resources.GetObject("tsStudents.Image")));
            this.tsStudents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStudents.Name = "tsStudents";
            this.tsStudents.Size = new System.Drawing.Size(74, 89);
            this.tsStudents.Text = "Student";
            this.tsStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStudents.Click += new System.EventHandler(this.tsStudents_Click);
            // 
            // tsGrades
            // 
            this.tsGrades.Image = ((System.Drawing.Image)(resources.GetObject("tsGrades.Image")));
            this.tsGrades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGrades.Name = "tsGrades";
            this.tsGrades.Size = new System.Drawing.Size(74, 89);
            this.tsGrades.Text = "Grades";
            this.tsGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsGrades.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsSubject
            // 
            this.tsSubject.Image = ((System.Drawing.Image)(resources.GetObject("tsSubject.Image")));
            this.tsSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSubject.Name = "tsSubject";
            this.tsSubject.Size = new System.Drawing.Size(78, 89);
            this.tsSubject.Text = "Curriculumn";
            this.tsSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSubject.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsCourses
            // 
            this.tsCourses.Image = ((System.Drawing.Image)(resources.GetObject("tsCourses.Image")));
            this.tsCourses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCourses.Name = "tsCourses";
            this.tsCourses.Size = new System.Drawing.Size(74, 89);
            this.tsCourses.Text = "Courses";
            this.tsCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCourses.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsUsers
            // 
            this.tsUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsUsers.Image")));
            this.tsUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUsers.Name = "tsUsers";
            this.tsUsers.Size = new System.Drawing.Size(85, 89);
            this.tsUsers.Text = "Manage Users";
            this.tsUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUsers.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsPreRequisite
            // 
            this.tsPreRequisite.Image = ((System.Drawing.Image)(resources.GetObject("tsPreRequisite.Image")));
            this.tsPreRequisite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPreRequisite.Name = "tsPreRequisite";
            this.tsPreRequisite.Size = new System.Drawing.Size(81, 89);
            this.tsPreRequisite.Text = "Pre-Requisite";
            this.tsPreRequisite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPreRequisite.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tsReports
            // 
            this.tsReports.Image = ((System.Drawing.Image)(resources.GetObject("tsReports.Image")));
            this.tsReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReports.Name = "tsReports";
            this.tsReports.Size = new System.Drawing.Size(74, 89);
            this.tsReports.Text = "Reports";
            this.tsReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReports.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 92);
            // 
            // tsFindstudent
            // 
            this.tsFindstudent.Image = ((System.Drawing.Image)(resources.GetObject("tsFindstudent.Image")));
            this.tsFindstudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFindstudent.Name = "tsFindstudent";
            this.tsFindstudent.Size = new System.Drawing.Size(83, 89);
            this.tsFindstudent.Text = "Find Students";
            this.tsFindstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsFindstudent.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 92);
            // 
            // tsLogin
            // 
            this.tsLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLogin.Image = global::EvaluationSystem.Properties.Resources.log_open;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(74, 89);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 498);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curriculum Evaluation System | Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsStudents;
        private System.Windows.Forms.ToolStripButton tsGrades;
        private System.Windows.Forms.ToolStripButton tsSubject;
        private System.Windows.Forms.ToolStripButton tsCourses;
        private System.Windows.Forms.ToolStripButton tsUsers;
        private System.Windows.Forms.ToolStripButton tsPreRequisite;
        private System.Windows.Forms.ToolStripButton tsReports;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsFindstudent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

