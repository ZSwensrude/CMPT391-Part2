namespace _391warehouse
{
    partial class Warehouse
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
            this.yearStart = new System.Windows.Forms.ComboBox();
            this.num_display = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yearEnd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.termCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.courseTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.courseDept = new System.Windows.Forms.ComboBox();
            this.courseCredits = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.instructorName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.instructorDept = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.instructorGender = new System.Windows.Forms.ComboBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.reset_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.instructorTitle = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearStart
            // 
            this.yearStart.FormattingEnabled = true;
            this.yearStart.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.yearStart.Location = new System.Drawing.Point(342, 118);
            this.yearStart.Name = "yearStart";
            this.yearStart.Size = new System.Drawing.Size(94, 21);
            this.yearStart.TabIndex = 0;
            // 
            // num_display
            // 
            this.num_display.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_display.AutoSize = true;
            this.num_display.Font = new System.Drawing.Font("Segoe UI", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_display.ForeColor = System.Drawing.Color.White;
            this.num_display.Location = new System.Drawing.Point(78, 204);
            this.num_display.Name = "num_display";
            this.num_display.Size = new System.Drawing.Size(457, 212);
            this.num_display.TabIndex = 1;
            this.num_display.Text = "0000";
            this.num_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_label
            // 
            this.total_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.Location = new System.Drawing.Point(210, 136);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(193, 30);
            this.total_label.TabIndex = 2;
            this.total_label.Text = "Number of Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(210, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Instructor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(216, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Year from:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(458, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 30);
            this.label7.TabIndex = 7;
            this.label7.Text = "to";
            // 
            // yearEnd
            // 
            this.yearEnd.FormattingEnabled = true;
            this.yearEnd.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.yearEnd.Location = new System.Drawing.Point(506, 118);
            this.yearEnd.Name = "yearEnd";
            this.yearEnd.Size = new System.Drawing.Size(94, 21);
            this.yearEnd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(216, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "Term:";
            // 
            // termCombo
            // 
            this.termCombo.FormattingEnabled = true;
            this.termCombo.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring/Summer",
            "All"});
            this.termCombo.Location = new System.Drawing.Point(342, 155);
            this.termCombo.Name = "termCombo";
            this.termCombo.Size = new System.Drawing.Size(94, 21);
            this.termCombo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(216, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "Title:";
            // 
            // courseTitle
            // 
            this.courseTitle.Location = new System.Drawing.Point(279, 245);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(187, 20);
            this.courseTitle.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(216, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 30);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dept:";
            // 
            // courseDept
            // 
            this.courseDept.FormattingEnabled = true;
            this.courseDept.Items.AddRange(new object[] {
            "Business",
            "Computer Science",
            "Mathematics",
            "Psychology",
            "Statistics"});
            this.courseDept.Location = new System.Drawing.Point(279, 281);
            this.courseDept.Name = "courseDept";
            this.courseDept.Size = new System.Drawing.Size(187, 21);
            this.courseDept.TabIndex = 14;
            // 
            // courseCredits
            // 
            this.courseCredits.FormattingEnabled = true;
            this.courseCredits.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.courseCredits.Location = new System.Drawing.Point(413, 317);
            this.courseCredits.Name = "courseCredits";
            this.courseCredits.Size = new System.Drawing.Size(53, 21);
            this.courseCredits.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(216, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 30);
            this.label11.TabIndex = 16;
            this.label11.Text = "No. of Credits:";
            // 
            // instructorName
            // 
            this.instructorName.Location = new System.Drawing.Point(289, 421);
            this.instructorName.Name = "instructorName";
            this.instructorName.Size = new System.Drawing.Size(187, 20);
            this.instructorName.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(210, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 30);
            this.label12.TabIndex = 18;
            this.label12.Text = "Name:";
            // 
            // instructorTitle
            // 
            this.instructorTitle.FormattingEnabled = true;
            this.instructorTitle.Items.AddRange(new object[] {
            "Assistant Professor",
            "Full Professor",
            "Associate Professor"});
            this.instructorTitle.Location = new System.Drawing.Point(289, 448);
            this.instructorTitle.Name = "instructorTitle";
            this.instructorTitle.Size = new System.Drawing.Size(187, 21);
            this.instructorTitle.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(210, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 30);
            this.label13.TabIndex = 19;
            this.label13.Text = "Title:";
            // 
            // instructorDept
            // 
            this.instructorDept.FormattingEnabled = true;
            this.instructorDept.Items.AddRange(new object[] {
            "Business",
            "Computer Science",
            "Mathematics",
            "Psychology",
            "Statistics"});
            this.instructorDept.Location = new System.Drawing.Point(289, 473);
            this.instructorDept.Name = "instructorDept";
            this.instructorDept.Size = new System.Drawing.Size(187, 21);
            this.instructorDept.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(210, 471);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "Dept:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(210, 501);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 30);
            this.label15.TabIndex = 23;
            this.label15.Text = "Gender:";
            // 
            // instructorGender
            // 
            this.instructorGender.FormattingEnabled = true;
            this.instructorGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.instructorGender.Location = new System.Drawing.Point(289, 501);
            this.instructorGender.Name = "instructorGender";
            this.instructorGender.Size = new System.Drawing.Size(187, 21);
            this.instructorGender.TabIndex = 24;
            // 
            // submit_btn
            // 
            this.submit_btn.AutoEllipsis = true;
            this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(116)))), ((int)(((byte)(179)))));
            this.submit_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit_btn.Location = new System.Drawing.Point(373, 554);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(136, 49);
            this.submit_btn.TabIndex = 25;
            this.submit_btn.Text = "Lookup";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // import_btn
            // 
            this.import_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_btn.ForeColor = System.Drawing.Color.White;
            this.import_btn.Image = global::_391warehouse.Properties.Resources.upload;
            this.import_btn.Location = new System.Drawing.Point(1202, 12);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(50, 47);
            this.import_btn.TabIndex = 26;
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // reset_button
            // 
            this.reset_button.AutoEllipsis = true;
            this.reset_button.BackColor = System.Drawing.Color.White;
            this.reset_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(116)))), ((int)(((byte)(179)))));
            this.reset_button.Location = new System.Drawing.Point(215, 554);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(136, 49);
            this.reset_button.TabIndex = 27;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.num_display, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.total_label, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(650, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 681);
            this.tableLayoutPanel1.TabIndex = 28;
          
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.instructorTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.instructorGender);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.instructorDept);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.instructorName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.courseCredits);
            this.Controls.Add(this.courseDept);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.courseTitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.termCombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yearEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yearStart;
        private System.Windows.Forms.Label num_display;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox yearEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox termCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox courseTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox courseDept;
        private System.Windows.Forms.ComboBox courseCredits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox instructorName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox instructorDept;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox instructorGender;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox instructorTitle;
    }
}

