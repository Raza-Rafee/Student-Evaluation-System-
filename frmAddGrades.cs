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
    public partial class frmAddGrades : Form
    {
        public frmAddGrades()
        {
            InitializeComponent();
        }

        private void txtaddgrades_TextChanged(object sender, EventArgs e)
        {
            double grades = double.Parse(txtaddgrades.Text);
            if( grades > 3 || grades < 0 ){
                txtaddgrades.Clear();
            } 
        }

        private void txtaddgrades_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtaddgrades_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
