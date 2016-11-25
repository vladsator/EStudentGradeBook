namespace EStudentGradeBook_PL
{
    partial class AddStudent
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
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_secondname = new System.Windows.Forms.TextBox();
            this.textBox_groupid = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(84, 7);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(192, 20);
            this.textBox_surname.TabIndex = 0;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(84, 33);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(192, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_secondname
            // 
            this.textBox_secondname.Location = new System.Drawing.Point(84, 59);
            this.textBox_secondname.Name = "textBox_secondname";
            this.textBox_secondname.Size = new System.Drawing.Size(192, 20);
            this.textBox_secondname.TabIndex = 2;
            // 
            // textBox_groupid
            // 
            this.textBox_groupid.Location = new System.Drawing.Point(84, 85);
            this.textBox_groupid.Name = "textBox_groupid";
            this.textBox_groupid.Size = new System.Drawing.Size(192, 20);
            this.textBox_groupid.TabIndex = 3;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(84, 111);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(192, 20);
            this.textBox_email.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 137);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(264, 35);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Secondname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group №:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email:";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 177);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_groupid);
            this.Controls.Add(this.textBox_secondname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_secondname;
        private System.Windows.Forms.TextBox textBox_groupid;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}