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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc, idno, courseid;

        private void btnsave_Click(object sender, EventArgs e)
        {
            if( txtCourse.Text == "")
            {
                UF.emptymessage();
            }
            else
            {
                sql = "Select * From tblcourse WHERE CourseId = " + courseid;
                maxrow = SC.maxrow(sql);
                if(maxrow > 0)
                {

                    sql = "UPDATE `tblcourse` SET `Course`='" + txtCourse.Text + "' WHERE CourseId=" + courseid;
                    SC.Execute_CUD(sql, "error to execute query", "Course has been updated in the database.");
                }
                else
                {
                    sql = "INSERT INTO `tblcourse` (`Course`) VALUES ('" + txtCourse.Text + "')";
                    SC.Execute_CUD(sql, "error to execute query", "New course has been saved in the database.");
                }
                btnnew_Click(sender, e);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "Delete From tblcourse WHERE CourseId=" + dtglist.CurrentRow.Cells[0].Value;
            SC.Execute_CUD(sql, "error to execute query", "Course has been deleted in the database.");
            btnnew_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * From tblcourse WHERE Course Like '%" + txtSearch.Text + "%'";
       SC.Load_DTG(sql, dtglist);
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            courseid = int.Parse(dtglist.CurrentRow.Cells[0].Value.ToString());
            txtCourse.Text = dtglist.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            courseid = 0;
            txtCourse.Clear();
            sql = "Select * From tblcourse";
            SC.Load_DTG(sql, dtglist);
        }
    }
}
