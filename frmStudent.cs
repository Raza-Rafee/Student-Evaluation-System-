using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow,inc;
        
        private void navigate_records(int inc)
        {
            sql = "SELECT IdNo FROM tblstudent";
            SC.singleResult(sql);

            if (SC.dt.Rows.Count > 0)
            {
                txt_sid.Text = SC.dt.Rows[inc].Field<string>(0);
            }
        }
        private void frmStudent_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }
        private void clearme()
        { 
            txt_fname.Clear();
            txt_lname.Clear();
            txt_mname.Clear();
            rch_address.Clear();
            cboCourse.Text = "Select";
            cboYearLevel.Text = "Select";
            txtPhoto.Clear();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            sql = "SELECT  `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`, Course,`YearLevel`  FROM `tblstudent` s, tblcourse c WHERE s.`CourseId`=c.`CourseId`";
            SC.Load_DTG(sql, dtg_ABorrowLists);
            PictureBox1.ImageLocation = "";
            clearme();
            txt_sid.Clear();

            sql = "SELECT  CourseId, Course FROM `tblcourse`";
            SC.fiil_CBO(sql, cboCourse);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            string gender;
            if (rdio_female.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            } 

            if ( txt_sid.Text == "" 
              || txt_fname.Text == "" || txt_lname.Text == "" 
              || txt_mname.Text == "" || cboCourse.Text == "Select" 
              || cboYearLevel.Text == "Select")
            {

                UF.emptymessage();

            }
            else
            {
                sql = "SELECT * FROM `tblstudent` WHERE `IdNo`='" + txt_sid.Text + "'";
                maxrow =  SC.maxrow(sql);

                if(maxrow > 0)
                {
                    sql = "update  tblstudent set  `Firstname`='" + txt_fname.Text
                          + "', `Lastname`='" + txt_lname.Text + "', `MI`='" + txt_mname.Text
                          + "', `HomeAddress`='" + rch_address.Text + "', `Sex`='" + gender
                          + "', `CourseId`='" + cboCourse.SelectedValue
                          + "', `YearLevel`='" + cboYearLevel.Text
                          + "', `StudentPhoto`='" + Path.GetFileName(PictureBox1.ImageLocation) + "' where `IdNo`='" + txt_sid.Text + "'";
                    SC.Execute_CUD(sql, "error to execute query", "Data has been updated in the database");
                }
                else
                {
                    sql = "insert into tblstudent (`IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, "
                        + "`Sex`, `CourseId`,YearLevel,  `StudentPhoto`) "
                        + "values ('" + txt_sid.Text + "','" + txt_fname.Text + "','" + txt_lname.Text
                        + "','" + txt_mname.Text + "','" + rch_address.Text
                        + "','" + gender + "','" + cboCourse.SelectedValue
                        + "','" + cboYearLevel.Text + "','" + Path.GetFileName(PictureBox1.ImageLocation) + "')";
                    SC.Execute_CUD(sql, "error to execute query", "New Data has been saved in the database");
                }

                sql = "SELECT * FROM `tblgrades` WHERE IdNo=" + txt_sid.Text +
                    " AND `YearLevel`='" + cboYearLevel.Text + "' AND `CourseId`=" + cboCourse.SelectedValue;
                maxrow = SC.maxrow(sql);

                if (maxrow == 0)
                {
                    sql = "SELECT * FROM `tblsubject` WHERE `CourseId`=" + cboCourse.SelectedValue;
                    SC.singleResult(sql);
                    foreach (DataRow r in SC.dt.Rows)
                    {
                        sql = "INSERT INTO `tblgrades` (`CourseId`, `IdNo`, `SubjectId`, `YearLevel`,`Sem`) " +
                            " VALUES (" + cboCourse.SelectedValue + ",'" + txt_sid.Text + "'," + r.Field<int>("SubjectId").ToString() +
                            ",'" + r.Field<string>("YearLevel") + "','" + r.Field<string>("Semester") + "')";
                        SC.Execute_Query(sql);
                    }

                }



                btn_New_Click(sender, e);

            }

             
           

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "Delete From tblstudent Where Idno = '" + dtg_ABorrowLists.CurrentRow.Cells[0].Value + "'";
            SC.Execute_CUD(sql, "error to execute query", "Data has been deleted in the database");

            btn_New_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (inc == 0)
            {
                MessageBox.Show("First Records.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (inc <= maxrow)
            {
                inc = inc - 1;
                navigate_records(inc);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (inc == maxrow)
            {
                MessageBox.Show("Last Records.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (inc >= 0)
            {
                inc = inc + 1;
                navigate_records(inc);
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            inc = maxrow;
            navigate_records(inc);
        }

        private void txt_sid_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tblstudent` s , tblcourse c WHERE s.`CourseId`=c.`CourseId` AND  `IdNo` = '" + txt_sid.Text + "'";
            maxrow = SC.maxrow(sql);

            if(maxrow > 0)
            {
                foreach(DataRow r in SC.dt.Rows)
                {
                    txt_fname.Text = r.Field<string>("Firstname");
                    txt_lname.Text = r.Field<string>("Lastname");
                    txt_mname.Text = r.Field<string>("MI");
                    rch_address.Text = r.Field<string>("HomeAddress");
                    cboCourse.SelectedValue = r.Field<int>("CourseId").ToString();
                    cboCourse.Text = r.Field<string>("Course");
                    cboYearLevel.Text = r.Field<string>("YearLevel");
                    PictureBox1.ImageLocation = Application.StartupPath + "\\StudentPhoto\\" + r.Field<string>("StudentPhoto");

                    if (r.Field<string>("Sex") == "Female") {
                        rdio_female.Checked = true;
                     } else {
                        rdio_male.Checked = true;
                     }
                } 

            }
            else
            {
                clearme();
            }
           
        }

        private void dtg_ABorrowLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_sid.Clear();
            txt_sid.Text = dtg_ABorrowLists.CurrentRow.Cells[0].Value.ToString();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog1.CheckFileExists = true; 
            OpenFileDialog1.CheckPathExists = true; 
            OpenFileDialog1.DefaultExt = "jpg"; 
            OpenFileDialog1.DereferenceLinks = true; 
            OpenFileDialog1.FileName = ""; 
            OpenFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"; 
            OpenFileDialog1.Multiselect = false; 
            OpenFileDialog1.RestoreDirectory = true;  
            OpenFileDialog1.Title = "Select a file to open";
            OpenFileDialog1.ValidateNames = true; 

            if(OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPhoto.Text = OpenFileDialog1.FileName;
                PictureBox1.ImageLocation = OpenFileDialog1.FileName;
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } 

        }

        private void txt_mname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            inc = 0;
            navigate_records(inc);
        }
    }
}
