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
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc;

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int level=0;

            string ay = cbosy.Text;

            if( txtSubject.Text == "")
            {
                UF.emptymessage();
            }
            else if(cboCourse.Text == "Select")
            {
                UF.emptymessage();
            }
            else if (cboSemester.Text == "Select")
            {
                UF.emptymessage();
            }
            else if (cboYearLevel.Text == "Select")
            {
                UF.emptymessage();
            }
        

            if( cboYearLevel.Text == "First")
            {
                level = 1;
            }
                else if (cboYearLevel.Text == "Second")
            {
                level = 2;
            }
            else if (cboYearLevel.Text == "Third")
            {
                level = 3;
            }
            else if (cboYearLevel.Text == "Fourth")
            {
                level = 4;
            }




            sql = "SELECT * FROM `tblprerequisite` WHERE  SubjectId=" + txtSubjectId.Text;
            maxrow = SC.maxrow(sql);
            if(maxrow > 0)
            {
                sql = "UPDATE  `tblprerequisite` SET `Pre1`='None', `Pre2`='None', `Pre3`='None', `Pre4`='None', `Pre5`='None', `Pre6`='None', `Pre7`='None', `Pre8`='None', `Pre9`='None' WHERE `SubjectId`=" + txtSubjectId.Text;
                SC.Execute_Query(sql);
            }
            else
            {
                sql = "INSERT INTO `tblprerequisite` (`SubjectId`, `Pre1`, `Pre2`, `Pre3`, `Pre4`, `Pre5`, `Pre6`, `Pre7`, `Pre8`, `Pre9`) " +
                 " VALUES (" + txtSubjectId.Text + ",'None','None','None','None','None','None','None','None','None')";
                SC.Execute_Query(sql);
            }

            sql = "SELECT * FROM `tblsubject` WHERE  SubjectId=" + txtSubjectId.Text; 
            maxrow = SC.maxrow(sql);
            if (maxrow > 0)
            {
                sql = "UPDATE `tblsubject` SET `Subject`='" + txtSubject.Text +
                  "', `DescriptiveTitle`='" + txtDesc.Text + "', `LecUnit`='" + txtLecUnit.Text +
                  "', `LabUnit`='" + txtLabUnit.Text + "', `CourseId`=" + cboCourse.SelectedValue + ", `Semester`='" + cboSemester.Text +
                 "', `YearLevel`='" + cboYearLevel.Text +
                 "', `PreRequisite`='" + cboPrerequisite.Text + "',Level=" + level + "  WHERE  SubjectId=" + txtSubjectId.Text;
                SC.Execute_CUD(sql, "error to execute query", "Subject has been updated in the database.");
                     
            }
            else
            {
                sql = "INSERT INTO `tblsubject` (`Subject`, `DescriptiveTitle`, `LecUnit`, `LabUnit`, `CourseId`,  `Semester`,`YearLevel`,  `PreRequisite`,Level) " +
                 " VALUES('" + txtSubject.Text + "','" + txtDesc.Text + "','" + txtLecUnit.Text + "','" + txtLabUnit.Text + "'," + cboCourse.SelectedValue + ",'" + cboSemester.Text +
                 "','" + cboYearLevel.Text + "', '" + cboPrerequisite.Text + "'," + level + " )";
                SC.Execute_CUD(sql, "error to execute query", "New Subject has been added in the database.");

                sql = "UPDATE `tblauto` SET `autoend`=`autoend`+ 1 WHERE `id`=1";
                SC.Execute_Query(sql);

            }
             

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE  FROM `tblprerequisite` WHERE `SubjectId`  = " + dtgList.CurrentRow.Cells[0].Value;
            SC.Execute_Query(sql);

            sql = "DELETE FROM `tblsubject` WHERE `SubjectId` = " + dtgList.CurrentRow.Cells[0].Value;
            SC.Execute_Query(sql);

            MessageBox.Show("Subject is already deleted");
            btnNew_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId AND Subject Like '%" + txtSearch.Text + "%'";
            SC.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            txtSubjectId.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
            txtSubject.Text = dtgList.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = dtgList.CurrentRow.Cells[2].Value.ToString();
            txtLabUnit.Text = dtgList.CurrentRow.Cells[4].Value.ToString();
            txtLecUnit.Text = dtgList.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UF.clearTxt(this);

            sql = "SELECT * FROM `tblauto` WHERE  `id`=1";
            SC.singleResult(sql);
            txtSubjectId.Text = SC.dt.Rows[0].Field<string>(1) + SC.dt.Rows[0].Field<int>(2);

            sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId";
            SC.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;
            sql = "Select CourseId,Course From tblcourse";
            SC.fiil_CBO(sql, cboCourse);
            cboCourse.Text = "Select";

            sql = "Select SubjectId,Subject From tblsubject";
            SC.fiil_CBO(sql, cboPrerequisite);
            cboPrerequisite.Text = "None";


            cbosy.Text = "Select";
            cboSemester.Text = "Select";
            cboYearLevel.Text = "Select";

        }
    }
}
