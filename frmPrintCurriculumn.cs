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
    public partial class frmPrintCurriculumn : Form
    {
        public frmPrintCurriculumn(int courseid,int idno)
        {
            InitializeComponent();

            loadReports(courseid, idno);
        }

        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc, idno, courseid;

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

                crystalReportViewer1.ReportSource = reportdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }
             
        }

        private void loadReports(int courseid,int idno)
        {
            sql = "SELECT * FROM `tblsubject` s, `tblgrades` g, tblstudent st,tblcourse c " +
               " WHERE s.`SubjectId`=g.`SubjectId` AND g.`IdNo`=st.`IdNo` AND g.`CourseId`  = c.`CourseId` " +
               " AND c.CourseId=" + courseid + " AND g.IdNo='" + idno + "'";
            reports(sql, "StudentCurriculum");
        }

        private void frmPrintCurriculumn_Load(object sender, EventArgs e)
        {

        }
    }
}
