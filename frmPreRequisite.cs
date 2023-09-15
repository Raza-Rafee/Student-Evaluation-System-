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
    public partial class frmPreRequisite : Form
    {
        public frmPreRequisite()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId AND Subject Like '%" + txtSearch.Text + "%'";
            SC.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT * FROM `tblsubject` WHERE `SubjectId`=" + dtgList.CurrentRow.Cells[0].Value;
            maxrow = SC.maxrow(sql);
            if (maxrow > 0)
            {
                txtSubject.Text = SC.dt.Rows[0].Field<string>("Subject");
                txtdesc.Text = SC.dt.Rows[0].Field<string>("DescriptiveTitle");
                txtYear.Text = SC.dt.Rows[0].Field<string>("YearLevel");
                txtSemester.Text = SC.dt.Rows[0].Field<string>("Semester");
                txtPreRequisite.Text = SC.dt.Rows[0].Field<string>("PreRequisite");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtSubject.Text == "")
            {
                MessageBox.Show("Select the Subject you want to update.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "UPDATE  `tblsubject` SET `PreRequisite` ='" + txtPreRequisite.Text.ToUpper() + "' WHERE `SubjectId` = " + dtgList.CurrentRow.Cells[0].Value;
            SC.Execute_CUD(sql, "error to execute query", "Subject Prerequisites have been updated.");
            frmPreRequisite_Load(sender, e);
        }

        private void frmPreRequisite_Load(object sender, EventArgs e)
        {
            sql = "SELECT SubjectId, `Subject` as 'CourseNo.', `DescriptiveTitle`, `LecUnit`, `LabUnit`,Course,`YearLevel`, `Semester`,   `PreRequisite` FROM `tblsubject` s,tblcourse c WHERE s.CourseId=c.CourseId";
            SC.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;
            txtPreRequisite.Clear();
            txtSemester.Clear();
            txtSubject.Clear();
            txtYear.Clear();
            txtdesc.Clear();
        }
    }
}
