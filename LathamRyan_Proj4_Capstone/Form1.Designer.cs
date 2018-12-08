namespace LathamRyan_Proj4_Capstone
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNmbrCrs = new System.Windows.Forms.TextBox();
            this.txtFullNm = new System.Windows.Forms.TextBox();
            this.calRegDate = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRegDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classRegDataSet = new LathamRyan_Proj4_Capstone.ClassRegDataSet();
            this.grpClassType = new System.Windows.Forms.GroupBox();
            this.rdbOnline = new System.Windows.Forms.RadioButton();
            this.rdbHybrid = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNmbrCrsDsp = new System.Windows.Forms.TextBox();
            this.txtFullNmDsp = new System.Windows.Forms.TextBox();
            this.txtRegDateDsp = new System.Windows.Forms.TextBox();
            this.txtCrsSlctDsp = new System.Windows.Forms.TextBox();
            this.txtCrsTypDsp = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseTableAdapter = new LathamRyan_Proj4_Capstone.ClassRegDataSetTableAdapters.CourseTableAdapter();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new LathamRyan_Proj4_Capstone.ClassRegDataSetTableAdapters.TableAdapterManager();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCrsSlct = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegDataSet)).BeginInit();
            this.grpClassType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of courses taking this semester:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First and last name of registrant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preferred date in";
            // 
            // txtNmbrCrs
            // 
            this.txtNmbrCrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmbrCrs.Location = new System.Drawing.Point(261, 59);
            this.txtNmbrCrs.Name = "txtNmbrCrs";
            this.txtNmbrCrs.Size = new System.Drawing.Size(100, 22);
            this.txtNmbrCrs.TabIndex = 1;
            this.txtNmbrCrs.Tag = "Numer of Registrant Courses";
            // 
            // txtFullNm
            // 
            this.txtFullNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullNm.Location = new System.Drawing.Point(211, 118);
            this.txtFullNm.Name = "txtFullNm";
            this.txtFullNm.Size = new System.Drawing.Size(150, 22);
            this.txtFullNm.TabIndex = 2;
            this.txtFullNm.Tag = "Registrant\'s Name";
            // 
            // calRegDate
            // 
            this.calRegDate.Location = new System.Drawing.Point(134, 179);
            this.calRegDate.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.calRegDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.calRegDate.Name = "calRegDate";
            this.calRegDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select course for registration:";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.classRegDataSetBindingSource;
            // 
            // classRegDataSetBindingSource
            // 
            this.classRegDataSetBindingSource.DataSource = this.classRegDataSet;
            this.classRegDataSetBindingSource.Position = 0;
            // 
            // classRegDataSet
            // 
            this.classRegDataSet.DataSetName = "ClassRegDataSet";
            this.classRegDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpClassType
            // 
            this.grpClassType.Controls.Add(this.rdbOnline);
            this.grpClassType.Controls.Add(this.rdbHybrid);
            this.grpClassType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpClassType.Location = new System.Drawing.Point(151, 417);
            this.grpClassType.Name = "grpClassType";
            this.grpClassType.Size = new System.Drawing.Size(210, 76);
            this.grpClassType.TabIndex = 5;
            this.grpClassType.TabStop = false;
            this.grpClassType.Text = "Class Type";
            // 
            // rdbOnline
            // 
            this.rdbOnline.AutoSize = true;
            this.rdbOnline.Location = new System.Drawing.Point(138, 33);
            this.rdbOnline.Name = "rdbOnline";
            this.rdbOnline.Size = new System.Drawing.Size(64, 20);
            this.rdbOnline.TabIndex = 1;
            this.rdbOnline.TabStop = true;
            this.rdbOnline.Text = "Online";
            this.rdbOnline.UseVisualStyleBackColor = true;
            // 
            // rdbHybrid
            // 
            this.rdbHybrid.AutoSize = true;
            this.rdbHybrid.Location = new System.Drawing.Point(28, 33);
            this.rdbHybrid.Name = "rdbHybrid";
            this.rdbHybrid.Size = new System.Drawing.Size(66, 20);
            this.rdbHybrid.TabIndex = 0;
            this.rdbHybrid.TabStop = true;
            this.rdbHybrid.Text = "Hybrid";
            this.rdbHybrid.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(13, 510);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(348, 57);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Click Here to &Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = " January for class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "to begin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Select class format:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Registrant\'s number of courses:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(409, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Registrant\'s first and last name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(409, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Registrant\'s preferred date to start:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(409, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Registrant\'s selected course:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(409, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Registrant\'s selected class type:";
            // 
            // txtNmbrCrsDsp
            // 
            this.txtNmbrCrsDsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmbrCrsDsp.Location = new System.Drawing.Point(650, 62);
            this.txtNmbrCrsDsp.Name = "txtNmbrCrsDsp";
            this.txtNmbrCrsDsp.ReadOnly = true;
            this.txtNmbrCrsDsp.Size = new System.Drawing.Size(137, 22);
            this.txtNmbrCrsDsp.TabIndex = 18;
            // 
            // txtFullNmDsp
            // 
            this.txtFullNmDsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullNmDsp.Location = new System.Drawing.Point(650, 115);
            this.txtFullNmDsp.Name = "txtFullNmDsp";
            this.txtFullNmDsp.ReadOnly = true;
            this.txtFullNmDsp.Size = new System.Drawing.Size(137, 22);
            this.txtFullNmDsp.TabIndex = 19;
            // 
            // txtRegDateDsp
            // 
            this.txtRegDateDsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegDateDsp.Location = new System.Drawing.Point(650, 175);
            this.txtRegDateDsp.Name = "txtRegDateDsp";
            this.txtRegDateDsp.ReadOnly = true;
            this.txtRegDateDsp.Size = new System.Drawing.Size(137, 22);
            this.txtRegDateDsp.TabIndex = 20;
            // 
            // txtCrsSlctDsp
            // 
            this.txtCrsSlctDsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrsSlctDsp.Location = new System.Drawing.Point(650, 232);
            this.txtCrsSlctDsp.Name = "txtCrsSlctDsp";
            this.txtCrsSlctDsp.ReadOnly = true;
            this.txtCrsSlctDsp.Size = new System.Drawing.Size(137, 22);
            this.txtCrsSlctDsp.TabIndex = 21;
            // 
            // txtCrsTypDsp
            // 
            this.txtCrsTypDsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrsTypDsp.Location = new System.Drawing.Point(650, 284);
            this.txtCrsTypDsp.Name = "txtCrsTypDsp";
            this.txtCrsTypDsp.ReadOnly = true;
            this.txtCrsTypDsp.Size = new System.Drawing.Size(137, 22);
            this.txtCrsTypDsp.TabIndex = 22;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDisplay.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(412, 347);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(375, 57);
            this.btnDisplay.TabIndex = 23;
            this.btnDisplay.Text = "Click Here to &Display Registrant Info";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(403, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 434);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Registrant\'s Information";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.classRegDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.UpdateOrder = LathamRyan_Proj4_Capstone.ClassRegDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.classRegDataSet;
            // 
            // courseBindingSource3
            // 
            this.courseBindingSource3.DataMember = "Course";
            this.courseBindingSource3.DataSource = this.classRegDataSetBindingSource;
            // 
            // cmbCrsSlct
            // 
            this.cmbCrsSlct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.courseBindingSource1, "CourseNum", true));
            this.cmbCrsSlct.DataSource = this.courseBindingSource1;
            this.cmbCrsSlct.DisplayMember = "CourseNum";
            this.cmbCrsSlct.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCrsSlct.FormattingEnabled = true;
            this.cmbCrsSlct.Location = new System.Drawing.Point(196, 357);
            this.cmbCrsSlct.Name = "cmbCrsSlct";
            this.cmbCrsSlct.Size = new System.Drawing.Size(165, 24);
            this.cmbCrsSlct.TabIndex = 0;
            this.cmbCrsSlct.ValueMember = "CourseNum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCrsSlct);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 574);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Registrant\'s Information";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(524, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 69);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "E&xit Registrant System";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 611);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtCrsTypDsp);
            this.Controls.Add(this.txtCrsSlctDsp);
            this.Controls.Add(this.txtRegDateDsp);
            this.Controls.Add(this.txtFullNmDsp);
            this.Controls.Add(this.txtNmbrCrsDsp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpClassType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calRegDate);
            this.Controls.Add(this.txtFullNm);
            this.Controls.Add(this.txtNmbrCrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classRegDataSet)).EndInit();
            this.grpClassType.ResumeLayout(false);
            this.grpClassType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNmbrCrs;
        private System.Windows.Forms.TextBox txtFullNm;
        private System.Windows.Forms.MonthCalendar calRegDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpClassType;
        private System.Windows.Forms.RadioButton rdbOnline;
        private System.Windows.Forms.RadioButton rdbHybrid;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNmbrCrsDsp;
        private System.Windows.Forms.TextBox txtFullNmDsp;
        private System.Windows.Forms.TextBox txtRegDateDsp;
        private System.Windows.Forms.TextBox txtCrsSlctDsp;
        private System.Windows.Forms.TextBox txtCrsTypDsp;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource classRegDataSetBindingSource;
        private ClassRegDataSet classRegDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ClassRegDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private ClassRegDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private System.Windows.Forms.BindingSource courseBindingSource3;
        private System.Windows.Forms.ComboBox cmbCrsSlct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
    }
}

