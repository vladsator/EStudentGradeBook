namespace EStudentGradeBook_PL
{
    partial class StudentManager
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
            this.dataGridView_students = new System.Windows.Forms.DataGridView();
            this.button_addstudent = new System.Windows.Forms.Button();
            this.button_removestudent = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_students
            // 
            this.dataGridView_students.AllowUserToAddRows = false;
            this.dataGridView_students.AllowUserToDeleteRows = false;
            this.dataGridView_students.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_students.Location = new System.Drawing.Point(2, 1);
            this.dataGridView_students.MultiSelect = false;
            this.dataGridView_students.Name = "dataGridView_students";
            this.dataGridView_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_students.Size = new System.Drawing.Size(652, 429);
            this.dataGridView_students.TabIndex = 0;
            // 
            // button_addstudent
            // 
            this.button_addstudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addstudent.Location = new System.Drawing.Point(660, 12);
            this.button_addstudent.Name = "button_addstudent";
            this.button_addstudent.Size = new System.Drawing.Size(151, 52);
            this.button_addstudent.TabIndex = 1;
            this.button_addstudent.Text = "Add";
            this.button_addstudent.UseVisualStyleBackColor = true;
            this.button_addstudent.Click += new System.EventHandler(this.button_addstudent_Click);
            // 
            // button_removestudent
            // 
            this.button_removestudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_removestudent.Location = new System.Drawing.Point(660, 70);
            this.button_removestudent.Name = "button_removestudent";
            this.button_removestudent.Size = new System.Drawing.Size(151, 52);
            this.button_removestudent.TabIndex = 2;
            this.button_removestudent.Text = "Remove";
            this.button_removestudent.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.Location = new System.Drawing.Point(660, 128);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(151, 52);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // StudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 431);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_removestudent);
            this.Controls.Add(this.button_addstudent);
            this.Controls.Add(this.dataGridView_students);
            this.Name = "StudentManager";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.StudentManager_Activated);
            this.Load += new System.EventHandler(this.StudentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_students;
        private System.Windows.Forms.Button button_addstudent;
        private System.Windows.Forms.Button button_removestudent;
        private System.Windows.Forms.Button button_update;
    }
}

