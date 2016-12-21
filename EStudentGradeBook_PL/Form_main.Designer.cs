namespace EStudentGradeBook_PL
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_allinfo = new System.Windows.Forms.DataGridView();
            this.button_addStudent = new System.Windows.Forms.Button();
            this.button_groupManager = new System.Windows.Forms.Button();
            this.button_lessonManager = new System.Windows.Forms.Button();
            this.button_markManager = new System.Windows.Forms.Button();
            this.comboBox_groups = new System.Windows.Forms.ComboBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_group = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_allinfo
            // 
            this.dataGridView_allinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_allinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_allinfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_allinfo.MultiSelect = false;
            this.dataGridView_allinfo.Name = "dataGridView_allinfo";
            this.dataGridView_allinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_allinfo.Size = new System.Drawing.Size(572, 469);
            this.dataGridView_allinfo.TabIndex = 0;
            // 
            // button_addStudent
            // 
            this.button_addStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addStudent.Location = new System.Drawing.Point(582, 12);
            this.button_addStudent.Name = "button_addStudent";
            this.button_addStudent.Size = new System.Drawing.Size(150, 37);
            this.button_addStudent.TabIndex = 1;
            this.button_addStudent.Text = "Add student";
            this.button_addStudent.UseVisualStyleBackColor = true;
            this.button_addStudent.Click += new System.EventHandler(this.button_addStudent_Click);
            // 
            // button_groupManager
            // 
            this.button_groupManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_groupManager.Location = new System.Drawing.Point(582, 55);
            this.button_groupManager.Name = "button_groupManager";
            this.button_groupManager.Size = new System.Drawing.Size(150, 36);
            this.button_groupManager.TabIndex = 2;
            this.button_groupManager.Text = "Group manager";
            this.button_groupManager.UseVisualStyleBackColor = true;
            this.button_groupManager.Click += new System.EventHandler(this.button_groupManager_Click);
            // 
            // button_lessonManager
            // 
            this.button_lessonManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_lessonManager.Location = new System.Drawing.Point(582, 97);
            this.button_lessonManager.Name = "button_lessonManager";
            this.button_lessonManager.Size = new System.Drawing.Size(150, 36);
            this.button_lessonManager.TabIndex = 3;
            this.button_lessonManager.Text = "Lesson manager";
            this.button_lessonManager.UseVisualStyleBackColor = true;
            // 
            // button_markManager
            // 
            this.button_markManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_markManager.Location = new System.Drawing.Point(582, 139);
            this.button_markManager.Name = "button_markManager";
            this.button_markManager.Size = new System.Drawing.Size(150, 36);
            this.button_markManager.TabIndex = 4;
            this.button_markManager.Text = "Mark manager";
            this.button_markManager.UseVisualStyleBackColor = true;
            // 
            // comboBox_groups
            // 
            this.comboBox_groups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_groups.FormattingEnabled = true;
            this.comboBox_groups.Location = new System.Drawing.Point(582, 315);
            this.comboBox_groups.Name = "comboBox_groups";
            this.comboBox_groups.Size = new System.Drawing.Size(146, 21);
            this.comboBox_groups.TabIndex = 5;
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(582, 355);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(146, 20);
            this.textBox_name.TabIndex = 7;
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Location = new System.Drawing.Point(620, 390);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 8;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_group
            // 
            this.label_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_group.AutoSize = true;
            this.label_group.Location = new System.Drawing.Point(579, 299);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(39, 13);
            this.label_group.TabIndex = 9;
            this.label_group.Text = "Group:";
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(579, 339);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(76, 13);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Student name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Update table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.comboBox_groups);
            this.Controls.Add(this.button_markManager);
            this.Controls.Add(this.button_lessonManager);
            this.Controls.Add(this.button_groupManager);
            this.Controls.Add(this.button_addStudent);
            this.Controls.Add(this.dataGridView_allinfo);
            this.Name = "Form_main";
            this.Text = "ETudentsGradeBook";
            this.Load += new System.EventHandler(this.Form_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_allinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_allinfo;
        private System.Windows.Forms.Button button_addStudent;
        private System.Windows.Forms.Button button_groupManager;
        private System.Windows.Forms.Button button_lessonManager;
        private System.Windows.Forms.Button button_markManager;
        private System.Windows.Forms.ComboBox comboBox_groups;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button1;
    }
}

