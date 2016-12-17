namespace EStudentGradeBook_PL
{
    partial class FormGroup
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
            this.dataGridView_groups = new System.Windows.Forms.DataGridView();
            this.button_addGroup = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_groups
            // 
            this.dataGridView_groups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groups.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_groups.MultiSelect = false;
            this.dataGridView_groups.Name = "dataGridView_groups";
            this.dataGridView_groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_groups.Size = new System.Drawing.Size(501, 453);
            this.dataGridView_groups.TabIndex = 0;
            // 
            // button_addGroup
            // 
            this.button_addGroup.Location = new System.Drawing.Point(508, 11);
            this.button_addGroup.Name = "button_addGroup";
            this.button_addGroup.Size = new System.Drawing.Size(127, 181);
            this.button_addGroup.TabIndex = 1;
            this.button_addGroup.Text = "Create group";
            this.button_addGroup.UseVisualStyleBackColor = true;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(508, 384);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(127, 58);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "Remove group\r\n(Danger)";
            this.button_remove.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(508, 198);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(127, 180);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update group data";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 454);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_addGroup);
            this.Controls.Add(this.dataGridView_groups);
            this.Name = "FormGroup";
            this.Text = "All group";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_groups;
        private System.Windows.Forms.Button button_addGroup;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_update;
    }
}