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
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc,idno=0,courseid=0;

        private void tsAdd_Click(object sender, EventArgs e)
        {
            if (idno == 0)
            {
                MessageBox.Show("Pls enter id number.", "Idno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            else
            {
                Form frm = new frmViewCurriculum(idno, courseid);
                frm.ShowDialog();

            }
         
        }

        private void frmGrades_Load(object sender, EventArgs e)
        {
            sql = "Select CONCAT(`Firstname`,' ', `Lastname`) From tblstudent";
            SC.autocomplete(sql, txtSearch);
            txtSearch.Clear();
            txtSearch.Focus();
            tsAdd.Enabled = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tblstudent` s, `tblcourse` c " +
             " WHERE s.`CourseId`=c.`CourseId` " +
             " AND (`IdNo` LIKE '%" + txtSearch.Text +
             "%' OR  `Firstname`  LIKE '%" + txtSearch.Text +
             "%' OR  `Lastname` LIKE '%" + txtSearch.Text + "%' OR CONCAT(`Firstname`,' ', `Lastname`) LIKE '%" + txtSearch.Text + "%')";
            maxrow = SC.maxrow(sql);
            if( maxrow > 0)
            {
                foreach(DataRow r in SC.dt.Rows)
                {
                    lblName.Text = r.Field<string>("Firstname") + " " + r.Field<string>("MI") + " " + r.Field<string>("Lastname");
                    lblAddress.Text = r.Field<string>("HomeAddress");
                    lblCourse.Text = r.Field<string>("Course");
                    lblYearLevel.Text = r.Field<string>("YearLevel");
                    idno = int.Parse(r.Field<string>("IdNo"));
                    courseid = r.Field<int>("CourseId");

                    sql = "SELECT s.`SubjectId` ,`Subject`, `DescriptiveTitle`, `LecUnit`, `LabUnit`,`PreRequisite`,`Grades` " +
                    " FROM `tblsubject` s, `tblgrades` g  " +
                    " WHERE s.`SubjectId`=g.`SubjectId`  AND IdNo= '" + idno +
                    "' AND g.CourseId = " + courseid + " AND s.YearLevel = '" + lblYearLevel.Text + "'";
                    SC.Load_DTG(sql, dtgList);
                    tsAdd.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("No found Record!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblName.Text = "None";
                lblAddress.Text = "None";
                lblCourse.Text = "None";
                lblYearLevel.Text = "None";
                idno = 0;
                courseid = 0;
                dtgList.Columns.Clear();
                txtSearch.Clear();
                txtSearch.Focus();
                tsAdd.Enabled = false;
            }
               
        
        }
    }
}
