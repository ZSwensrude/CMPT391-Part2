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
            this.instructorTitle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.instructorGender = new System.Windows.Forms.ComboBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // yearStart
            // 
            this.yearStart.FormattingEnabled = true;
            this.yearStart.Location = new System.Drawing.Point(459, 192);
            this.yearStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearStart.Name = "yearStart";
            this.yearStart.Size = new System.Drawing.Size(124, 24);
            this.yearStart.TabIndex = 0;
            // 
            // num_display
            // 
            this.num_display.AutoSize = true;
            this.num_display.Font = new System.Drawing.Font("Segoe UI", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_display.ForeColor = System.Drawing.Color.White;
            this.num_display.Location = new System.Drawing.Point(967, 329);
            this.num_display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num_display.Name = "num_display";
            this.num_display.Size = new System.Drawing.Size(572, 265);
            this.num_display.TabIndex = 1;
            this.num_display.Text = "0000";
            this.num_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.Location = new System.Drawing.Point(1135, 292);
            this.total_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(245, 37);
            this.total_label.TabIndex = 2;
            this.total_label.Text = "Number of Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(283, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 501);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Instructor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(291, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Year from:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(613, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "to";
            // 
            // yearEnd
            // 
            this.yearEnd.FormattingEnabled = true;
            this.yearEnd.Location = new System.Drawing.Point(677, 192);
            this.yearEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearEnd.Name = "yearEnd";
            this.yearEnd.Size = new System.Drawing.Size(124, 24);
            this.yearEnd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(291, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 37);
            this.label8.TabIndex = 9;
            this.label8.Text = "Term:";
            // 
            // termCombo
            // 
            this.termCombo.FormattingEnabled = true;
            this.termCombo.Location = new System.Drawing.Point(459, 238);
            this.termCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termCombo.Name = "termCombo";
            this.termCombo.Size = new System.Drawing.Size(124, 24);
            this.termCombo.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(291, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "Title:";
            // 
            // courseTitle
            // 
            this.courseTitle.Location = new System.Drawing.Point(375, 348);
            this.courseTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.Size = new System.Drawing.Size(248, 22);
            this.courseTitle.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(291, 382);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 37);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dept:";
            // 
            // courseDept
            // 
            this.courseDept.FormattingEnabled = true;
            this.courseDept.Items.AddRange(new object[] {
            "Business",
            "Computer Science",
            "Mathmatics",
            "Psychology",
            "Statistics"});
            this.courseDept.Location = new System.Drawing.Point(375, 393);
            this.courseDept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseDept.Name = "courseDept";
            this.courseDept.Size = new System.Drawing.Size(248, 24);
            this.courseDept.TabIndex = 14;
            // 
            // courseCredits
            // 
            this.courseCredits.FormattingEnabled = true;
            this.courseCredits.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.courseCredits.Location = new System.Drawing.Point(553, 437);
            this.courseCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseCredits.Name = "courseCredits";
            this.courseCredits.Size = new System.Drawing.Size(69, 24);
            this.courseCredits.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(291, 426);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 37);
            this.label11.TabIndex = 16;
            this.label11.Text = "No. of Credits:";
            // 
            // instructorName
            // 
            this.instructorName.Location = new System.Drawing.Point(388, 565);
            this.instructorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instructorName.Name = "instructorName";
            this.instructorName.Size = new System.Drawing.Size(248, 22);
            this.instructorName.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(283, 553);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 37);
            this.label12.TabIndex = 18;
            this.label12.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(283, 590);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 37);
            this.label13.TabIndex = 19;
            this.label13.Text = "Title:";
            // 
            // instructorDept
            // 
            this.instructorDept.FormattingEnabled = true;
            this.instructorDept.Location = new System.Drawing.Point(388, 629);
            this.instructorDept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instructorDept.Name = "instructorDept";
            this.instructorDept.Size = new System.Drawing.Size(248, 24);
            this.instructorDept.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(283, 626);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 37);
            this.label14.TabIndex = 20;
            this.label14.Text = "Dept:";
            // 
            // instructorTitle
            // 
            this.instructorTitle.Location = new System.Drawing.Point(388, 597);
            this.instructorTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instructorTitle.Name = "instructorTitle";
            this.instructorTitle.Size = new System.Drawing.Size(248, 22);
            this.instructorTitle.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(283, 663);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 37);
            this.label15.TabIndex = 23;
            this.label15.Text = "Gender:";
            // 
            // instructorGender
            // 
            this.instructorGender.FormattingEnabled = true;
            this.instructorGender.Location = new System.Drawing.Point(388, 663);
            this.instructorGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instructorGender.Name = "instructorGender";
            this.instructorGender.Size = new System.Drawing.Size(248, 24);
            this.instructorGender.TabIndex = 24;
            // 
            // submit_btn
            // 
            this.submit_btn.AutoEllipsis = true;
            this.submit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(116)))), ((int)(((byte)(179)))));
            this.submit_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit_btn.Location = new System.Drawing.Point(289, 729);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(181, 60);
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
            this.import_btn.Location = new System.Drawing.Point(1603, 15);
            this.import_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(67, 58);
            this.import_btn.TabIndex = 26;
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.instructorGender);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.instructorTitle);
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
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.num_display);
            this.Controls.Add(this.yearStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
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
        private System.Windows.Forms.TextBox instructorTitle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox instructorGender;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

