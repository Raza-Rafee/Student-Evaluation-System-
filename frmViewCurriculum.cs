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
    public partial class frmViewCurriculum : Form
    {
        public frmViewCurriculum(int idno, int courseid)
        {
            InitializeComponent();


            load_data(idno, courseid);

        }



        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc, idno, courseid;

        private void update_Grades(DataGridView dtg)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=" + row.Cells[0].Value;
                maxrow = SC.maxrow(sql);
                if (maxrow > 0)
                {
                    sql = "UPDATE `tblgrades` SET `Grades`=" + row.Cells[6].Value + " WHERE `GradesId`=" + row.Cells[0].Value;
                    SC.Execute_Query(sql);
                }

            }
        }

        private void btnViewCurriculum_Click(object sender, EventArgs e)
        {
            Form frm = new frmPrintCurriculumn( int.Parse( lblcoursId.Text),int.Parse( lblIdNo.Text));
            frm.ShowDialog();


                
        }
        private void dtg_enable_cell(DataGridView dtg,KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter && dtg.CurrentCell.ColumnIndex == 6)
            {
                e.Handled = true;
                DataGridViewCell cell = dtg.CurrentRow.Cells[6];
                dtg.CurrentCell = cell;
                dtg.BeginEdit(true);

                 
                sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId`  AND IdNo = " + lblIdNo.Text
                    + " AND  PreRequisite = '" +  dtg.CurrentRow.Cells[1].Value + "' AND Grades < 1 AND Grades > 3";
                maxrow = SC.maxrow(sql);
                if (maxrow > 0)
                {
                    MessageBox.Show("You take first the pre-requisite of this subject before adding grades on this subject.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtg.CurrentRow.Cells[6].Value = "";
                } 

            }
        }
        private void dtgFirstYearFirst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void dtgFirstYearFirst_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgFirstYearFirst, e);
          
        }

        private void dtgFourthYearFirst_CellToolTipTextChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgFirstYearSecond_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgFirstYearSecond, e);
        }

        private void dtgSecondYearFirst_KeyDown(object sender, KeyEventArgs e)
        {

            dtg_enable_cell(dtgSecondYearFirst, e);
        }

        private void dtgSecondYearSecond_KeyDown(object sender, KeyEventArgs e)
        {

            dtg_enable_cell(dtgSecondYearSecond, e);
        }

        private void dtgThirdYearFirst_KeyDown(object sender, KeyEventArgs e)
        {

            dtg_enable_cell(dtgThirdYearFirst, e);
        }

        private void dtgThirdYearSecond_KeyDown(object sender, KeyEventArgs e)
        {

            dtg_enable_cell(dtgThirdYearSecond, e);
        }

        private void dtgFourthYearFirst_KeyDown(object sender, KeyEventArgs e)
        {

            dtg_enable_cell(dtgFourthYearFirst, e);
        }

        private void dtgFourthYearSecond_KeyDown(object sender, KeyEventArgs e)
        { 
            dtg_enable_cell(dtgFourthYearSecond, e);
        }

        private void btnSubjectEnroll_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Dim row As DataGridViewRow
            //''''''''''''''first year

            update_Grades(dtgFirstYearFirst);

            update_Grades(dtgFirstYearSecond);


            //'''''''''''''''''Second Year

            update_Grades(dtgSecondYearFirst);

            update_Grades(dtgSecondYearSecond);


            //'''''''''''''''''Third Year

            update_Grades(dtgThirdYearFirst);

            update_Grades(dtgThirdYearSecond);


            //''''''''''''''''''''Fourth Year

            update_Grades(dtgFourthYearFirst);

            update_Grades(dtgFourthYearSecond);



            //''''''''''''''end

            MessageBox.Show("Grades has been updated.");

            load_data(int.Parse(lblIdNo.Text), courseid);
        }

        private void load_data(int idno ,int courseid)
        {



            sql = "SELECT * FROM `tblstudent`  s , `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND IdNo=" + idno;
            maxrow = SC.maxrow(sql);

            if (maxrow > 0)
            {
                courseid = SC.dt.Rows[0].Field<int>("CourseId");


                lblName.Text = SC.dt.Rows[0].Field<string>("Firstname") + " " + SC.dt.Rows[0].Field<string>("Lastname");
                lblCourse.Text = SC.dt.Rows[0].Field<string>("Course");
                lblYearLevel.Text = SC.dt.Rows[0].Field<string>("YearLevel");
                lblIdNo.Text = SC.dt.Rows[0].Field<string>("IdNo");
                lblSemester.Text = SC.dt.Rows[0].Field<string>("idno");


                // ' sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId` " +
                // '" AND s.`SubjectId`=g.`SubjectId` " +
                // '" AND g.`CourseId`=" + courseid + " AND g.YearLevel='First' AND Semester= 'First' AND IdNo=" + idno
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
               " AND g.`CourseId`=" + courseid + " AND g.YearLevel='First' AND Semester= 'First' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgFirstYearFirst);
                dtgFirstYearFirst.Columns[0].Visible = false;



                // 'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId` " +
                // '      " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='First' AND Semester= 'Second' " +
                // '      " AND g.`CourseId`=" + courseid + " AND IdNo=" + idno
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
               " AND g.`CourseId`=" + courseid + " AND g.YearLevel='First' AND Semester= 'Second' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgFirstYearSecond);
                dtgFirstYearSecond.Columns[0].Visible = false;


                // 'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`  " +
                // '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'First' " +
                // '     " AND g.`CourseId`=" + courseid + " AND IdNo=" + idno
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
               " AND g.`CourseId`=" + courseid + " AND g.YearLevel='Second' AND Semester= 'First' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgSecondYearFirst);
                dtgSecondYearFirst.Columns[0].Visible = false;

                // 'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`   " +
                // '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Second' AND Semester= 'Second' " +
                // '     " AND g.`CourseId`=" + courseid + " AND IdNo=" + idno
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
               " AND g.`CourseId`=" + courseid + " AND g.YearLevel='Second' AND Semester= 'Second' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgSecondYearSecond);
                dtgSecondYearSecond.Columns[0].Visible = false;


                // 'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`   " +
                // '    " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'First' " +
                // '    " AND g.`CourseId`=" + courseid +
                // '    " AND IdNo=" + idno
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
                 " AND g.`CourseId`=" + courseid + " AND g.YearLevel='Third' AND Semester= 'First' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgThirdYearFirst);
                dtgThirdYearFirst.Columns[0].Visible = false;

                // 'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`   " +
                // '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Third' AND Semester= 'Second' " +
                // '     " AND g.`CourseId`=" + courseid + " AND IdNo=" + idno 
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
               " AND g.`CourseId`=" + courseid + " AND g.YearLevel='Third' AND Semester= 'Second' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgThirdYearSecond);
                dtgThirdYearSecond.Columns[0].Visible = false;

                // 'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`  " +
                // '   " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'First' " +
                // '   " AND g.`CourseId`=" + courseid + " AND IdNo=" + idno
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
               " AND g.`CourseId`=" + courseid + " AND g.YearLevel='Fourth' AND Semester= 'First' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgFourthYearFirst);
                dtgFourthYearFirst.Columns[0].Visible = false;

                // 'sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,CONCAT(  `Pre1` ,  ',',  `Pre2` ,  ',',  `Pre3` ,  ',',  `Pre4` ,  ',',  `Pre5` ,  ',',  `Pre6` ,  ',',  `Pre7` ,  ',',  `Pre8` ,  ',',  `Pre9` )  as 'PreRequisite',Grades FROM `tblsubject` s,  `tblprerequisite` p, `tblgrades` g WHERE  s.`SubjectId` = p.`SubjectId`  " +
                // '     " AND s.`SubjectId`=g.`SubjectId` AND g.YearLevel='Fourth' AND Semester= 'Second' " +
                // '     " AND g.`CourseId`=" + courseid + " AND IdNo=" + idno
                sql = "SELECT GradesId,`Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,  `PreRequisite` ,Grades FROM `tblsubject` s,`tblgrades` g WHERE  s.`SubjectId`=g.`SubjectId` " +
               " AND g.`CourseId`=" + courseid + " AND g.YearLevel='Fourth' AND Semester= 'Second' AND IdNo=" + idno;
                SC.Load_DTG(sql, dtgFourthYearSecond);
                dtgFourthYearSecond.Columns[0].Visible = false;

                lblcoursId.Text = courseid.ToString();

                   
            }
            else
            {
                MessageBox.Show("Id number is not registered.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                  
              
        }

        private void frmViewCurriculum_Load(object sender, EventArgs e)
        {

        }
    }
}
