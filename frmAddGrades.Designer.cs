namespace EvaluationSystem
{
    partial class frmAddGrades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPreRequisite = new System.Windows.Forms.TextBox();
            this.lblGradeId = new System.Windows.Forms.Label();
            this.txtaddgrades = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblidno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPreRequisite
            // 
            this.txtPreRequisite.Location = new System.Drawing.Point(424, 35);
            this.txtPreRequisite.Name = "txtPreRequisite";
            this.txtPreRequisite.Size = new System.Drawing.Size(168, 20);
            this.txtPreRequisite.TabIndex = 19;
            // 
            // lblGradeId
            // 
            this.lblGradeId.AutoSize = true;
            this.lblGradeId.Location = new System.Drawing.Point(422, 80);
            this.lblGradeId.Name = "lblGradeId";
            this.lblGradeId.Size = new System.Drawing.Size(45, 13);
            this.lblGradeId.TabIndex = 18;
            this.lblGradeId.Text = "GradeId";
            // 
            // txtaddgrades
            // 
            this.txtaddgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddgrades.Location = new System.Drawing.Point(12, 45);
            this.txtaddgrades.MaxLength = 3;
            this.txtaddgrades.Name = "txtaddgrades";
            this.txtaddgrades.Size = new System.Drawing.Size(378, 45);
            this.txtaddgrades.TabIndex = 14;
            this.txtaddgrades.TextChanged += new System.EventHandler(this.txtaddgrades_TextChanged);
            this.txtaddgrades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddgrades_KeyDown);
            this.txtaddgrades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddgrades_KeyPress);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(6, 10);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(173, 32);
            this.lblSubject.TabIndex = 15;
            this.lblSubject.Text = "Add Grades ";
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new System.Drawing.Point(422, 25);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(41, 13);
            this.lblGrades.TabIndex = 16;
            this.lblGrades.Text = "Grades";
            // 
            // lblidno
            // 
            this.lblidno.AutoSize = true;
            this.lblidno.Location = new System.Drawing.Point(422, 58);
            this.lblidno.Name = "lblidno";
            this.lblidno.Size = new System.Drawing.Size(34, 13);
            this.lblidno.TabIndex = 17;
            this.lblidno.Text = "IDNO";
            // 
            // frmAddGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 102);
            this.Controls.Add(this.txtPreRequisite);
            this.Controls.Add(this.lblGradeId);
            this.Controls.Add(this.txtaddgrades);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.lblidno);
            this.Name = "frmAddGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Grades Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPreRequisite;
        internal System.Windows.Forms.Label lblGradeId;
        internal System.Windows.Forms.TextBox txtaddgrades;
        internal System.Windows.Forms.Label lblSubject;
        internal System.Windows.Forms.Label lblGrades;
        internal System.Windows.Forms.Label lblidno;
    }
}