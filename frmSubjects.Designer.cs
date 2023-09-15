namespace EvaluationSystem
{
    partial class frmSubjects
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
            this.Label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.cboYearLevel = new System.Windows.Forms.ComboBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.txtLecUnit = new System.Windows.Forms.TextBox();
            this.txtLabUnit = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.cboPrerequisite = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.cbosy = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(586, 245);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(61, 17);
            this.Label11.TabIndex = 85;
            this.Label11.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(653, 244);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 20);
            this.txtSearch.TabIndex = 84;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(372, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboSemester
            // 
            this.cboSemester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "First",
            "Second"});
            this.cboSemester.Location = new System.Drawing.Point(576, 99);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(211, 21);
            this.cboSemester.TabIndex = 82;
            this.cboSemester.Text = "Select";
            // 
            // cboYearLevel
            // 
            this.cboYearLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboYearLevel.FormattingEnabled = true;
            this.cboYearLevel.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.cboYearLevel.Location = new System.Drawing.Point(576, 70);
            this.cboYearLevel.Name = "cboYearLevel";
            this.cboYearLevel.Size = new System.Drawing.Size(211, 21);
            this.cboYearLevel.TabIndex = 79;
            this.cboYearLevel.Text = "Select";
            // 
            // cboCourse
            // 
            this.cboCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(576, 44);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(211, 21);
            this.cboCourse.TabIndex = 78;
            this.cboCourse.Text = "Select";
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(486, 71);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(84, 17);
            this.Label8.TabIndex = 74;
            this.Label8.Text = "Year Level :";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(494, 99);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(76, 17);
            this.Label7.TabIndex = 73;
            this.Label7.Text = "Semester :";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(509, 45);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(61, 17);
            this.Label6.TabIndex = 75;
            this.Label6.Text = "Course :";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Location = new System.Drawing.Point(453, 214);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 72;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.Location = new System.Drawing.Point(291, 214);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 71;
            this.btnNew.Text = "Clear";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(210, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtgList
            // 
            this.dtgList.AllowUserToAddRows = false;
            this.dtgList.AllowUserToDeleteRows = false;
            this.dtgList.AllowUserToResizeColumns = false;
            this.dtgList.AllowUserToResizeRows = false;
            this.dtgList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgList.Location = new System.Drawing.Point(12, 270);
            this.dtgList.Name = "dtgList";
            this.dtgList.RowHeadersVisible = false;
            this.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgList.Size = new System.Drawing.Size(876, 260);
            this.dtgList.TabIndex = 67;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(210, 73);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(216, 64);
            this.txtDesc.TabIndex = 66;
            this.txtDesc.Text = "";
            // 
            // txtLecUnit
            // 
            this.txtLecUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLecUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecUnit.Location = new System.Drawing.Point(210, 143);
            this.txtLecUnit.Name = "txtLecUnit";
            this.txtLecUnit.Size = new System.Drawing.Size(75, 23);
            this.txtLecUnit.TabIndex = 68;
            // 
            // txtLabUnit
            // 
            this.txtLabUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLabUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabUnit.Location = new System.Drawing.Point(210, 172);
            this.txtLabUnit.Name = "txtLabUnit";
            this.txtLabUnit.Size = new System.Drawing.Size(75, 23);
            this.txtLabUnit.TabIndex = 69;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(111, 146);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(93, 17);
            this.Label5.TabIndex = 61;
            this.Label5.Text = "Lecture Unit :";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(87, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(117, 17);
            this.Label3.TabIndex = 60;
            this.Label3.Text = "Descriptive Title :";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(131, 175);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(73, 17);
            this.Label4.TabIndex = 63;
            this.Label4.Text = "Lab. Unit :";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(117, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 17);
            this.Label1.TabIndex = 62;
            this.Label1.Text = "Course No .:";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(210, 44);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(216, 23);
            this.txtSubject.TabIndex = 65;
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSubjectId.Enabled = false;
            this.txtSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectId.Location = new System.Drawing.Point(210, 44);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(216, 23);
            this.txtSubjectId.TabIndex = 64;
            // 
            // cboPrerequisite
            // 
            this.cboPrerequisite.FormattingEnabled = true;
            this.cboPrerequisite.Items.AddRange(new object[] {
            "First",
            "Second"});
            this.cboPrerequisite.Location = new System.Drawing.Point(519, 342);
            this.cboPrerequisite.Name = "cboPrerequisite";
            this.cboPrerequisite.Size = new System.Drawing.Size(211, 21);
            this.cboPrerequisite.TabIndex = 80;
            this.cboPrerequisite.Text = "None";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(412, 343);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(101, 17);
            this.Label9.TabIndex = 76;
            this.Label9.Text = "Pre Requisite :";
            // 
            // cbosy
            // 
            this.cbosy.FormattingEnabled = true;
            this.cbosy.Items.AddRange(new object[] {
            "2014-2015",
            "2015-2016",
            "2016-2017",
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022"});
            this.cbosy.Location = new System.Drawing.Point(480, 339);
            this.cbosy.Name = "cbosy";
            this.cbosy.Size = new System.Drawing.Size(211, 21);
            this.cbosy.TabIndex = 81;
            this.cbosy.Text = "2014-2015";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(373, 340);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(99, 17);
            this.Label10.TabIndex = 77;
            this.Label10.Text = "Acaemic Year:";
            // 
            // frmSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 537);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboSemester);
            this.Controls.Add(this.cboYearLevel);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtLecUnit);
            this.Controls.Add(this.txtLabUnit);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.cboPrerequisite);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.cbosy);
            this.Controls.Add(this.Label10);
            this.Name = "frmSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curriculumn Form";
            this.Load += new System.EventHandler(this.frmSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.ComboBox cboSemester;
        internal System.Windows.Forms.ComboBox cboYearLevel;
        internal System.Windows.Forms.ComboBox cboCourse;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.DataGridView dtgList;
        internal System.Windows.Forms.RichTextBox txtDesc;
        internal System.Windows.Forms.TextBox txtLecUnit;
        internal System.Windows.Forms.TextBox txtLabUnit;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.TextBox txtSubjectId;
        internal System.Windows.Forms.ComboBox cboPrerequisite;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cbosy;
        internal System.Windows.Forms.Label Label10;
    }
}