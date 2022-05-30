
namespace projectuni1
{
    partial class StudentMarks
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
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtboxGrade = new System.Windows.Forms.TextBox();
            this.txtboxCourseId = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(199, 110);
            this.textBoxStudentId.MaxLength = 6;
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(100, 26);
            this.textBoxStudentId.TabIndex = 18;
            this.textBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudentId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Student ID ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 217);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(87, 293);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(52, 20);
            this.lblGrade.TabIndex = 15;
            this.lblGrade.Text = "Marks";
            // 
            // txtboxGrade
            // 
            this.txtboxGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxGrade.Location = new System.Drawing.Point(199, 293);
            this.txtboxGrade.Name = "txtboxGrade";
            this.txtboxGrade.Size = new System.Drawing.Size(100, 26);
            this.txtboxGrade.TabIndex = 14;
            // 
            // txtboxCourseId
            // 
            this.txtboxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCourseId.Location = new System.Drawing.Point(199, 159);
            this.txtboxCourseId.MaxLength = 4;
            this.txtboxCourseId.Name = "txtboxCourseId";
            this.txtboxCourseId.Size = new System.Drawing.Size(100, 26);
            this.txtboxCourseId.TabIndex = 13;
            this.txtboxCourseId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCourseId_KeyPress);
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(81, 161);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(85, 20);
            this.lblCourseId.TabIndex = 12;
            this.lblCourseId.Text = "Course ID ";
            // 
            // StudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtboxGrade);
            this.Controls.Add(this.txtboxCourseId);
            this.Controls.Add(this.lblCourseId);
            this.Name = "StudentMarks";
            this.Size = new System.Drawing.Size(401, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtboxGrade;
        private System.Windows.Forms.TextBox txtboxCourseId;
        private System.Windows.Forms.Label lblCourseId;
    }
}
