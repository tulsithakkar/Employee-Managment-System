namespace Employee_Managment_System_case_study
{
    partial class emp_leave
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_logoe = new System.Windows.Forms.PictureBox();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.groupBox1_leave = new System.Windows.Forms.GroupBox();
            this.radio4_vacation = new System.Windows.Forms.RadioButton();
            this.radioB3_other = new System.Windows.Forms.RadioButton();
            this.radiob2_Maternity = new System.Windows.Forms.RadioButton();
            this.radiob1_sick = new System.Windows.Forms.RadioButton();
            this.date2_lto = new System.Windows.Forms.DateTimePicker();
            this.date1_lfrom = new System.Windows.Forms.DateTimePicker();
            this.btn_apply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.l_type = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1_ldisplay = new System.Windows.Forms.GroupBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.dataGridView1_display = new System.Windows.Forms.DataGridView();
            this.btn_backhome = new System.Windows.Forms.Button();
            this.toolTip1_cox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1_backhome = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1_apply = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1_display = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            this.groupBox1_leave.SuspendLayout();
            this.groupBox1_ldisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_display)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.pic_logoe);
            this.panel1.Controls.Add(this.pic_home);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 127);
            this.panel1.TabIndex = 7;
            // 
            // pic_logoe
            // 
            this.pic_logoe.Image = global::Employee_Managment_System_case_study.Properties.Resources.logo2_epage_;
            this.pic_logoe.Location = new System.Drawing.Point(740, 19);
            this.pic_logoe.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pic_logoe.Name = "pic_logoe";
            this.pic_logoe.Size = new System.Drawing.Size(87, 83);
            this.pic_logoe.TabIndex = 3;
            this.pic_logoe.TabStop = false;
            // 
            // pic_home
            // 
            this.pic_home.Image = global::Employee_Managment_System_case_study.Properties.Resources.leave_page_1;
            this.pic_home.Location = new System.Drawing.Point(43, 19);
            this.pic_home.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(87, 83);
            this.pic_home.TabIndex = 2;
            this.pic_home.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Leave managment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbox_id
            // 
            this.cbox_id.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_id.FormattingEnabled = true;
            this.cbox_id.Location = new System.Drawing.Point(455, 160);
            this.cbox_id.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbox_id.Name = "cbox_id";
            this.cbox_id.Size = new System.Drawing.Size(93, 26);
            this.cbox_id.TabIndex = 9;
            this.cbox_id.SelectedIndexChanged += new System.EventHandler(this.cbox_id_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Employee Name";
            // 
            // txt_empname
            // 
            this.txt_empname.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empname.Location = new System.Drawing.Point(255, 209);
            this.txt_empname.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(177, 28);
            this.txt_empname.TabIndex = 30;
            this.txt_empname.TextChanged += new System.EventHandler(this.txt_empname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Employee  role";
            // 
            // txt_role
            // 
            this.txt_role.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.Location = new System.Drawing.Point(630, 207);
            this.txt_role.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(177, 28);
            this.txt_role.TabIndex = 32;
            this.txt_role.TextChanged += new System.EventHandler(this.txt_role_TextChanged);
            // 
            // groupBox1_leave
            // 
            this.groupBox1_leave.Controls.Add(this.radio4_vacation);
            this.groupBox1_leave.Controls.Add(this.radioB3_other);
            this.groupBox1_leave.Controls.Add(this.radiob2_Maternity);
            this.groupBox1_leave.Controls.Add(this.radiob1_sick);
            this.groupBox1_leave.Controls.Add(this.date2_lto);
            this.groupBox1_leave.Controls.Add(this.date1_lfrom);
            this.groupBox1_leave.Controls.Add(this.btn_apply);
            this.groupBox1_leave.Controls.Add(this.label6);
            this.groupBox1_leave.Controls.Add(this.l_type);
            this.groupBox1_leave.Controls.Add(this.label5);
            this.groupBox1_leave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1_leave.Location = new System.Drawing.Point(76, 250);
            this.groupBox1_leave.Name = "groupBox1_leave";
            this.groupBox1_leave.Size = new System.Drawing.Size(374, 208);
            this.groupBox1_leave.TabIndex = 33;
            this.groupBox1_leave.TabStop = false;
            this.groupBox1_leave.Text = "Apply Leave";
            // 
            // radio4_vacation
            // 
            this.radio4_vacation.AutoSize = true;
            this.radio4_vacation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio4_vacation.Location = new System.Drawing.Point(145, 65);
            this.radio4_vacation.Name = "radio4_vacation";
            this.radio4_vacation.Size = new System.Drawing.Size(101, 22);
            this.radio4_vacation.TabIndex = 38;
            this.radio4_vacation.TabStop = true;
            this.radio4_vacation.Text = "Vacation";
            this.radio4_vacation.UseVisualStyleBackColor = true;
            this.radio4_vacation.CheckedChanged += new System.EventHandler(this.radio4_vacation_CheckedChanged);
            // 
            // radioB3_other
            // 
            this.radioB3_other.AutoSize = true;
            this.radioB3_other.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB3_other.Location = new System.Drawing.Point(256, 65);
            this.radioB3_other.Name = "radioB3_other";
            this.radioB3_other.Size = new System.Drawing.Size(74, 22);
            this.radioB3_other.TabIndex = 37;
            this.radioB3_other.TabStop = true;
            this.radioB3_other.Text = "Other";
            this.radioB3_other.UseVisualStyleBackColor = true;
            this.radioB3_other.CheckedChanged += new System.EventHandler(this.radioB3_other_CheckedChanged);
            // 
            // radiob2_Maternity
            // 
            this.radiob2_Maternity.AutoSize = true;
            this.radiob2_Maternity.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiob2_Maternity.Location = new System.Drawing.Point(222, 37);
            this.radiob2_Maternity.Name = "radiob2_Maternity";
            this.radiob2_Maternity.Size = new System.Drawing.Size(108, 22);
            this.radiob2_Maternity.TabIndex = 36;
            this.radiob2_Maternity.TabStop = true;
            this.radiob2_Maternity.Text = "Maternity";
            this.radiob2_Maternity.UseVisualStyleBackColor = true;
            this.radiob2_Maternity.CheckedChanged += new System.EventHandler(this.radiob2_Maternity_CheckedChanged);
            // 
            // radiob1_sick
            // 
            this.radiob1_sick.AutoSize = true;
            this.radiob1_sick.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiob1_sick.Location = new System.Drawing.Point(145, 37);
            this.radiob1_sick.Name = "radiob1_sick";
            this.radiob1_sick.Size = new System.Drawing.Size(61, 22);
            this.radiob1_sick.TabIndex = 34;
            this.radiob1_sick.TabStop = true;
            this.radiob1_sick.Text = "Sick";
            this.radiob1_sick.UseVisualStyleBackColor = true;
            this.radiob1_sick.CheckedChanged += new System.EventHandler(this.radiob1_sick_CheckedChanged);
            // 
            // date2_lto
            // 
            this.date2_lto.CustomFormat = "yyyy-MM-dd";
            this.date2_lto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2_lto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2_lto.Location = new System.Drawing.Point(145, 125);
            this.date2_lto.Name = "date2_lto";
            this.date2_lto.Size = new System.Drawing.Size(176, 26);
            this.date2_lto.TabIndex = 35;
            // 
            // date1_lfrom
            // 
            this.date1_lfrom.CustomFormat = "yyyy-MM-dd";
            this.date1_lfrom.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1_lfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1_lfrom.Location = new System.Drawing.Point(145, 93);
            this.date1_lfrom.Name = "date1_lfrom";
            this.date1_lfrom.Size = new System.Drawing.Size(176, 26);
            this.date1_lfrom.TabIndex = 34;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(125, 166);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(90, 29);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date To";
            // 
            // l_type
            // 
            this.l_type.AutoSize = true;
            this.l_type.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_type.Location = new System.Drawing.Point(22, 37);
            this.l_type.Name = "l_type";
            this.l_type.Size = new System.Drawing.Size(96, 18);
            this.l_type.TabIndex = 1;
            this.l_type.Text = "Leave type";
            this.l_type.Click += new System.EventHandler(this.l_type_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date From";
            // 
            // groupBox1_ldisplay
            // 
            this.groupBox1_ldisplay.Controls.Add(this.btn_display);
            this.groupBox1_ldisplay.Controls.Add(this.dataGridView1_display);
            this.groupBox1_ldisplay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1_ldisplay.Location = new System.Drawing.Point(469, 250);
            this.groupBox1_ldisplay.Name = "groupBox1_ldisplay";
            this.groupBox1_ldisplay.Size = new System.Drawing.Size(338, 208);
            this.groupBox1_ldisplay.TabIndex = 34;
            this.groupBox1_ldisplay.TabStop = false;
            this.groupBox1_ldisplay.Text = "Display Leave";
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(111, 173);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(90, 29);
            this.btn_display.TabIndex = 4;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // dataGridView1_display
            // 
            this.dataGridView1_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_display.Location = new System.Drawing.Point(21, 25);
            this.dataGridView1_display.Name = "dataGridView1_display";
            this.dataGridView1_display.Size = new System.Drawing.Size(285, 142);
            this.dataGridView1_display.TabIndex = 0;
            // 
            // btn_backhome
            // 
            this.btn_backhome.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backhome.Location = new System.Drawing.Point(321, 469);
            this.btn_backhome.Name = "btn_backhome";
            this.btn_backhome.Size = new System.Drawing.Size(200, 30);
            this.btn_backhome.TabIndex = 41;
            this.btn_backhome.Text = "Back  to Home";
            this.btn_backhome.UseVisualStyleBackColor = true;
            this.btn_backhome.Click += new System.EventHandler(this.btn_backhome_Click);
            // 
            // emp_leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btn_backhome);
            this.Controls.Add(this.groupBox1_ldisplay);
            this.Controls.Add(this.groupBox1_leave);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_empname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "emp_leave";
            this.Text = "Employee Leave Managment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            this.groupBox1_leave.ResumeLayout(false);
            this.groupBox1_leave.PerformLayout();
            this.groupBox1_ldisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_logoe;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_empname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.GroupBox groupBox1_leave;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioB3_other;
        private System.Windows.Forms.RadioButton radiob2_Maternity;
        private System.Windows.Forms.RadioButton radiob1_sick;
        private System.Windows.Forms.DateTimePicker date2_lto;
        private System.Windows.Forms.DateTimePicker date1_lfrom;
        private System.Windows.Forms.RadioButton radio4_vacation;
        private System.Windows.Forms.GroupBox groupBox1_ldisplay;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView dataGridView1_display;
        private System.Windows.Forms.Button btn_backhome;
        private System.Windows.Forms.ToolTip toolTip1_cox;
        private System.Windows.Forms.ToolTip toolTip1_backhome;
        private System.Windows.Forms.ToolTip toolTip1_apply;
        private System.Windows.Forms.ToolTip toolTip1_display;
    }
}