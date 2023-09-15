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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc;

        private void frmUsers_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {

            if( txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
            {
                UF.emptymessage();
            }
            else
            {
                sql = "insert into tbluseraccount (`Fullname`, `User_name`, `Pass`, `UserType`) "
               + " values('" + txt_name.Text + "','" + txt_username.Text
               + "',sha1('" + txt_pass.Text + "'),'" + cbo_type.Text + "')";
                SC.Execute_CUD(sql,"error to execute query", "User has been saved in the database.");
                btn_New_Click(sender, e);
            }
            
       
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
            {
                UF.emptymessage();
            }
            else
            {
                sql = "update tbluseraccount set Fullname = '" + txt_name.Text + "', User_name = '" + txt_username.Text 
                            + "',Pass= sha1('" + txt_pass.Text + "'), UserType= '" + cbo_type.Text 
                            + "' where UserId = " + lbl_id.Text;
                SC.Execute_CUD(sql, "error to execute query", "User has been updated in the database.");
                btn_New_Click(sender, e);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM tbluseraccount WHERE UserId = " + lbl_id.Text;
            SC.Execute_CUD(sql, "error to execute query", "User has been deleted in the database.");
            btn_New_Click(sender, e);
        }

        private void dtg_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dtg_listUser.CurrentRow.Cells[1].Value.ToString();
            txt_username.Text = dtg_listUser.CurrentRow.Cells[2].Value.ToString();
            cbo_type.Text = dtg_listUser.CurrentRow.Cells[3].Value.ToString();

            btn_saveuser.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            lbl_id.Text = "id";
            UF.clearTxt(this);


            cbo_type.Text = "Administrator";
            SC.Load_DTG("Select UserId as 'ID' ,Fullname as 'Name',User_name as 'UserName',UserType as 'Type' From tbluseraccount", dtg_listUser);
            dtg_listUser.Columns[0].Visible = false;
            if( lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }

               
 
        }
    }
}
