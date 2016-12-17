namespace EStudentGradeBook_PL.Group
{
    partial class Form_addGroup
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
            this.listBox_thisGroupStudents = new System.Windows.Forms.ListBox();
            this.listBox_allStudents = new System.Windows.Forms.ListBox();
            this.button_addAllStudents = new System.Windows.Forms.Button();
            this.button_addSelectedStudent = new System.Windows.Forms.Button();
            this.tabControl_groupTabs = new System.Windows.Forms.TabControl();
            this.tabPage_groupStudents = new System.Windows.Forms.TabPage();
            this.tabPage_groupLessons = new System.Windows.Forms.TabPage();
            this.groupBox_groupInfo = new System.Windows.Forms.GroupBox();
            this.comboBox_cource = new System.Windows.Forms.ComboBox();
            this.label_cource = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_addAllLessons = new System.Windows.Forms.Button();
            this.listBox_thisGroupLessons = new System.Windows.Forms.ListBox();
            this.button_addSelectedLesson = new System.Windows.Forms.Button();
            this.listBox_allLessons = new System.Windows.Forms.ListBox();
            this.tabControl_groupTabs.SuspendLayout();
            this.tabPage_groupStudents.SuspendLayout();
            this.tabPage_groupLessons.SuspendLayout();
            this.groupBox_groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_thisGroupStudents
            // 
            this.listBox_thisGroupStudents.FormattingEnabled = true;
            this.listBox_thisGroupStudents.Location = new System.Drawing.Point(267, 5);
            this.listBox_thisGroupStudents.Name = "listBox_thisGroupStudents";
            this.listBox_thisGroupStudents.Size = new System.Drawing.Size(206, 446);
            this.listBox_thisGroupStudents.TabIndex = 4;
            // 
            // listBox_allStudents
            // 
            this.listBox_allStudents.FormattingEnabled = true;
            this.listBox_allStudents.Location = new System.Drawing.Point(6, 6);
            this.listBox_allStudents.Name = "listBox_allStudents";
            this.listBox_allStudents.Size = new System.Drawing.Size(206, 446);
            this.listBox_allStudents.TabIndex = 1;
            // 
            // button_addAllStudents
            // 
            this.button_addAllStudents.Location = new System.Drawing.Point(218, 233);
            this.button_addAllStudents.Name = "button_addAllStudents";
            this.button_addAllStudents.Size = new System.Drawing.Size(43, 45);
            this.button_addAllStudents.TabIndex = 3;
            this.button_addAllStudents.Text = ">>";
            this.button_addAllStudents.UseVisualStyleBackColor = true;
            // 
            // button_addSelectedStudent
            // 
            this.button_addSelectedStudent.Location = new System.Drawing.Point(218, 182);
            this.button_addSelectedStudent.Name = "button_addSelectedStudent";
            this.button_addSelectedStudent.Size = new System.Drawing.Size(43, 45);
            this.button_addSelectedStudent.TabIndex = 2;
            this.button_addSelectedStudent.Text = ">";
            this.button_addSelectedStudent.UseVisualStyleBackColor = true;
            // 
            // tabControl_groupTabs
            // 
            this.tabControl_groupTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_groupTabs.Controls.Add(this.tabPage_groupStudents);
            this.tabControl_groupTabs.Controls.Add(this.tabPage_groupLessons);
            this.tabControl_groupTabs.Location = new System.Drawing.Point(3, 4);
            this.tabControl_groupTabs.Name = "tabControl_groupTabs";
            this.tabControl_groupTabs.SelectedIndex = 0;
            this.tabControl_groupTabs.Size = new System.Drawing.Size(487, 481);
            this.tabControl_groupTabs.TabIndex = 1;
            // 
            // tabPage_groupStudents
            // 
            this.tabPage_groupStudents.Controls.Add(this.button_addAllStudents);
            this.tabPage_groupStudents.Controls.Add(this.listBox_thisGroupStudents);
            this.tabPage_groupStudents.Controls.Add(this.button_addSelectedStudent);
            this.tabPage_groupStudents.Controls.Add(this.listBox_allStudents);
            this.tabPage_groupStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPage_groupStudents.Name = "tabPage_groupStudents";
            this.tabPage_groupStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_groupStudents.Size = new System.Drawing.Size(479, 455);
            this.tabPage_groupStudents.TabIndex = 0;
            this.tabPage_groupStudents.Text = "Students";
            this.tabPage_groupStudents.UseVisualStyleBackColor = true;
            // 
            // tabPage_groupLessons
            // 
            this.tabPage_groupLessons.Controls.Add(this.button_addAllLessons);
            this.tabPage_groupLessons.Controls.Add(this.listBox_thisGroupLessons);
            this.tabPage_groupLessons.Controls.Add(this.button_addSelectedLesson);
            this.tabPage_groupLessons.Controls.Add(this.listBox_allLessons);
            this.tabPage_groupLessons.Location = new System.Drawing.Point(4, 22);
            this.tabPage_groupLessons.Name = "tabPage_groupLessons";
            this.tabPage_groupLessons.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_groupLessons.Size = new System.Drawing.Size(479, 455);
            this.tabPage_groupLessons.TabIndex = 1;
            this.tabPage_groupLessons.Text = "Lessons";
            this.tabPage_groupLessons.UseVisualStyleBackColor = true;
            // 
            // groupBox_groupInfo
            // 
            this.groupBox_groupInfo.Controls.Add(this.label_cource);
            this.groupBox_groupInfo.Controls.Add(this.comboBox_cource);
            this.groupBox_groupInfo.Location = new System.Drawing.Point(496, 26);
            this.groupBox_groupInfo.Name = "groupBox_groupInfo";
            this.groupBox_groupInfo.Size = new System.Drawing.Size(193, 48);
            this.groupBox_groupInfo.TabIndex = 5;
            this.groupBox_groupInfo.TabStop = false;
            this.groupBox_groupInfo.Text = "Group info";
            // 
            // comboBox_cource
            // 
            this.comboBox_cource.FormattingEnabled = true;
            this.comboBox_cource.Location = new System.Drawing.Point(64, 19);
            this.comboBox_cource.Name = "comboBox_cource";
            this.comboBox_cource.Size = new System.Drawing.Size(121, 21);
            this.comboBox_cource.TabIndex = 6;
            // 
            // label_cource
            // 
            this.label_cource.AutoSize = true;
            this.label_cource.Location = new System.Drawing.Point(8, 22);
            this.label_cource.Name = "label_cource";
            this.label_cource.Size = new System.Drawing.Size(44, 13);
            this.label_cource.TabIndex = 8;
            this.label_cource.Text = "Cource:";
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(496, 364);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(193, 34);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(496, 444);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(193, 34);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_apply
            // 
            this.button_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_apply.Location = new System.Drawing.Point(496, 404);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(193, 34);
            this.button_apply.TabIndex = 8;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // button_addAllLessons
            // 
            this.button_addAllLessons.Location = new System.Drawing.Point(218, 232);
            this.button_addAllLessons.Name = "button_addAllLessons";
            this.button_addAllLessons.Size = new System.Drawing.Size(43, 45);
            this.button_addAllLessons.TabIndex = 3;
            this.button_addAllLessons.Text = ">>";
            this.button_addAllLessons.UseVisualStyleBackColor = true;
            // 
            // listBox_thisGroupLessons
            // 
            this.listBox_thisGroupLessons.FormattingEnabled = true;
            this.listBox_thisGroupLessons.Location = new System.Drawing.Point(267, 4);
            this.listBox_thisGroupLessons.Name = "listBox_thisGroupLessons";
            this.listBox_thisGroupLessons.Size = new System.Drawing.Size(206, 446);
            this.listBox_thisGroupLessons.TabIndex = 4;
            // 
            // button_addSelectedLesson
            // 
            this.button_addSelectedLesson.Location = new System.Drawing.Point(218, 181);
            this.button_addSelectedLesson.Name = "button_addSelectedLesson";
            this.button_addSelectedLesson.Size = new System.Drawing.Size(43, 45);
            this.button_addSelectedLesson.TabIndex = 2;
            this.button_addSelectedLesson.Text = ">";
            this.button_addSelectedLesson.UseVisualStyleBackColor = true;
            // 
            // listBox_allLessons
            // 
            this.listBox_allLessons.FormattingEnabled = true;
            this.listBox_allLessons.Location = new System.Drawing.Point(6, 5);
            this.listBox_allLessons.Name = "listBox_allLessons";
            this.listBox_allLessons.Size = new System.Drawing.Size(206, 446);
            this.listBox_allLessons.TabIndex = 1;
            // 
            // Form_addGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 489);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox_groupInfo);
            this.Controls.Add(this.tabControl_groupTabs);
            this.Name = "Form_addGroup";
            this.Text = "Adding group";
            this.tabControl_groupTabs.ResumeLayout(false);
            this.tabPage_groupStudents.ResumeLayout(false);
            this.tabPage_groupLessons.ResumeLayout(false);
            this.groupBox_groupInfo.ResumeLayout(false);
            this.groupBox_groupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_thisGroupStudents;
        private System.Windows.Forms.ListBox listBox_allStudents;
        private System.Windows.Forms.Button button_addAllStudents;
        private System.Windows.Forms.Button button_addSelectedStudent;
        private System.Windows.Forms.TabControl tabControl_groupTabs;
        private System.Windows.Forms.TabPage tabPage_groupStudents;
        private System.Windows.Forms.TabPage tabPage_groupLessons;
        private System.Windows.Forms.GroupBox groupBox_groupInfo;
        private System.Windows.Forms.Label label_cource;
        private System.Windows.Forms.ComboBox comboBox_cource;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_addAllLessons;
        private System.Windows.Forms.ListBox listBox_thisGroupLessons;
        private System.Windows.Forms.Button button_addSelectedLesson;
        private System.Windows.Forms.ListBox listBox_allLessons;
    }
}