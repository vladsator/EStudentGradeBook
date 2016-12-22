namespace EStudentGradeBook_PL
{
    partial class MarkAdder
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_group = new System.Windows.Forms.ComboBox();
            this.comboBox_student = new System.Windows.Forms.ComboBox();
            this.comboBox_lesson = new System.Windows.Forms.ComboBox();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add mark\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_group
            // 
            this.comboBox_group.FormattingEnabled = true;
            this.comboBox_group.Location = new System.Drawing.Point(83, 23);
            this.comboBox_group.Name = "comboBox_group";
            this.comboBox_group.Size = new System.Drawing.Size(121, 21);
            this.comboBox_group.TabIndex = 1;
            this.comboBox_group.SelectedIndexChanged += new System.EventHandler(this.comboBox_group_SelectedIndexChanged);
            // 
            // comboBox_student
            // 
            this.comboBox_student.FormattingEnabled = true;
            this.comboBox_student.Location = new System.Drawing.Point(83, 50);
            this.comboBox_student.Name = "comboBox_student";
            this.comboBox_student.Size = new System.Drawing.Size(121, 21);
            this.comboBox_student.TabIndex = 2;
            // 
            // comboBox_lesson
            // 
            this.comboBox_lesson.FormattingEnabled = true;
            this.comboBox_lesson.Location = new System.Drawing.Point(83, 77);
            this.comboBox_lesson.Name = "comboBox_lesson";
            this.comboBox_lesson.Size = new System.Drawing.Size(121, 21);
            this.comboBox_lesson.TabIndex = 3;
            this.comboBox_lesson.SelectedIndexChanged += new System.EventHandler(this.comboBox_lesson_SelectedIndexChanged);
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(83, 104);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(121, 20);
            this.textBox_value.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lesson:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value:";
            // 
            // MarkAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 168);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.comboBox_lesson);
            this.Controls.Add(this.comboBox_student);
            this.Controls.Add(this.comboBox_group);
            this.Controls.Add(this.button1);
            this.Name = "MarkAdder";
            this.Text = "MarkAdder";
            this.Load += new System.EventHandler(this.MarkAdder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_group;
        private System.Windows.Forms.ComboBox comboBox_student;
        private System.Windows.Forms.ComboBox comboBox_lesson;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}