using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc, idno, courseid;

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            sql = "Select * From tblsubject s, tblcourse c WHERE s.CourseId=c.CourseId AND Course LIKE '%" + txtCourse.Text + "%'";
            reports(sql, "Curriculum");
        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            sql = "SELECT  `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`,Course,`YearLevel` FROM `tblstudent` s, tblcourse c WHERE s.`CourseId`=c.`CourseId`";
            reports(sql, "ListStudents");
        }

        private void reports(string sql, string rptname)
        {

            try
            {

                SC.loadReports(sql);

                string reportname = rptname;


                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument(); ;

                string strReportPath = Application.StartupPath + "\\reports\\" + reportname + ".rpt";


                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(SC.dt);

                CrystalReportViewer1.ReportSource = reportdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }

        }
        private void frmReports_Load(object sender, EventArgs e)
        {

        }
    }
}
