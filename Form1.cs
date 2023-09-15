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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void enabled_menu()
        {
            tsLogin.Text = "Logout";
            tsStudents.Enabled = true;
            tsCourses.Enabled = true;
            tsGrades.Enabled = true;
            tsSubject.Enabled = true;
            tsUsers.Enabled = true;
            tsReports.Enabled = false;
            tsFindstudent.Enabled = false;
            tsPreRequisite.Enabled = true;
            tsLogin.Image = Properties.Resources.log_close;
        }

        public void disabled_menu()
        {
            tsLogin.Text = "Login";
            tsStudents.Enabled = false;
            tsCourses.Enabled = false;
            tsGrades.Enabled = false;
            tsSubject.Enabled = false;
            tsUsers.Enabled = false;
            tsReports.Enabled = false;
            tsFindstudent.Enabled = false;
            tsPreRequisite.Enabled = false;
            tsLogin.Image = Properties.Resources.log_open;
        }


        private void closefrm()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Close();

            }
        }
        private void showfrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();
        }

        private void tsStudents_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmStudent());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmGrades());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmCourse());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmSubjects());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmUsers());

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmPreRequisite ());
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmReports());
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            closefrm();
            showfrm(new frmFinstudents());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if(tsLogin.Text == "Login")
            {
                closefrm();
                showfrm(new frmLogin(this));
            }
            else
            {
                disabled_menu();
            }
        }
    }
}
