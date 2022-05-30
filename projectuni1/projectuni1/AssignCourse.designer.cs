namespace projectuni1
{
    partial class AssignCourse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblTeachersId = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtboxCourseId = new System.Windows.Forms.TextBox();
            this.txtboxTeachersId = new System.Windows.Forms.TextBox();
            this.txtboxStudentId = new System.Windows.Forms.TextBox();
            this.btnAssignCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(248, 251);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(70, 16);
            this.lblCourseId.TabIndex = 0;
            this.lblCourseId.Text = "Course ID ";
            this.lblCourseId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTeachersId
            // 
            this.lblTeachersId.AutoSize = true;
            this.lblTeachersId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachersId.Location = new System.Drawing.Point(248, 180);
            this.lblTeachersId.Name = "lblTeachersId";
            this.lblTeachersId.Size = new System.Drawing.Size(85, 16);
            this.lblTeachersId.TabIndex = 1;
            this.lblTeachersId.Text = "Teachers ID ";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(248, 111);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(69, 16);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "Student ID";
            // 
            // txtboxCourseId
            // 
            this.txtboxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCourseId.Location = new System.Drawing.Point(388, 248);
            this.txtboxCourseId.MaxLength = 4;
            this.txtboxCourseId.Name = "txtboxCourseId";
            this.txtboxCourseId.Size = new System.Drawing.Size(100, 22);
            this.txtboxCourseId.TabIndex = 3;
            this.txtboxCourseId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCourseId_KeyPress);
            // 
            // txtboxTeachersId
            // 
            this.txtboxTeachersId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTeachersId.Location = new System.Drawing.Point(388, 173);
            this.txtboxTeachersId.MaxLength = 6;
            this.txtboxTeachersId.Name = "txtboxTeachersId";
            this.txtboxTeachersId.Size = new System.Drawing.Size(100, 22);
            this.txtboxTeachersId.TabIndex = 5;
            this.txtboxTeachersId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTeachersId_KeyPress);
            // 
            // txtboxStudentId
            // 
            this.txtboxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStudentId.Location = new System.Drawing.Point(388, 111);
            this.txtboxStudentId.MaxLength = 6;
            this.txtboxStudentId.Name = "txtboxStudentId";
            this.txtboxStudentId.Size = new System.Drawing.Size(100, 22);
            this.txtboxStudentId.TabIndex = 6;
            this.txtboxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxStudentId_KeyPress);
            // 
            // btnAssignCourse
            // 
            this.btnAssignCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignCourse.Location = new System.Drawing.Point(333, 351);
            this.btnAssignCourse.Name = "btnAssignCourse";
            this.btnAssignCourse.Size = new System.Drawing.Size(118, 30);
            this.btnAssignCourse.TabIndex = 7;
            this.btnAssignCourse.Text = "Assign Course";
            this.btnAssignCourse.UseVisualStyleBackColor = true;
            this.btnAssignCourse.Click += new System.EventHandler(this.btnAssignCourse_Click);
            // 
            // AssignCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAssignCourse);
            this.Controls.Add(this.txtboxStudentId);
            this.Controls.Add(this.txtboxTeachersId);
            this.Controls.Add(this.txtboxCourseId);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblTeachersId);
            this.Controls.Add(this.lblCourseId);
            this.Name = "AssignCourse";
            this.Size = new System.Drawing.Size(772, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblTeachersId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtboxCourseId;
        private System.Windows.Forms.TextBox txtboxTeachersId;
        private System.Windows.Forms.TextBox txtboxStudentId;
        private System.Windows.Forms.Button btnAssignCourse;
    }
}
