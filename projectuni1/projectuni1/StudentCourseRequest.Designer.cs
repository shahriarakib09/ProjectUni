
namespace projectuni1
{
    partial class StudentCourseRequest
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtboxStudentId = new System.Windows.Forms.TextBox();
            this.txtboxCourseId = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(249, 292);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(100, 23);
            this.btnRequest.TabIndex = 14;
            this.btnRequest.Text = "REQUEST";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(94, 166);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(109, 20);
            this.lblStudentId.TabIndex = 13;
            this.lblStudentId.Text = "STUDENT ID ";
            this.lblStudentId.Click += new System.EventHandler(this.lblStudentId_Click);
            // 
            // txtboxStudentId
            // 
            this.txtboxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStudentId.Location = new System.Drawing.Point(249, 160);
            this.txtboxStudentId.MaxLength = 6;
            this.txtboxStudentId.Name = "txtboxStudentId";
            this.txtboxStudentId.Size = new System.Drawing.Size(100, 26);
            this.txtboxStudentId.TabIndex = 12;
            this.txtboxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxStudentId_KeyPress);
            // 
            // txtboxCourseId
            // 
            this.txtboxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCourseId.Location = new System.Drawing.Point(249, 213);
            this.txtboxCourseId.MaxLength = 4;
            this.txtboxCourseId.Name = "txtboxCourseId";
            this.txtboxCourseId.Size = new System.Drawing.Size(100, 26);
            this.txtboxCourseId.TabIndex = 11;
            this.txtboxCourseId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCourseId_KeyPress);
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(94, 213);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(103, 20);
            this.lblCourseId.TabIndex = 10;
            this.lblCourseId.Text = "COURSE ID ";
            // 
            // StudentCourseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtboxStudentId);
            this.Controls.Add(this.txtboxCourseId);
            this.Controls.Add(this.lblCourseId);
            this.Name = "StudentCourseRequest";
            this.Size = new System.Drawing.Size(486, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtboxStudentId;
        private System.Windows.Forms.TextBox txtboxCourseId;
        private System.Windows.Forms.Label lblCourseId;
    }
}
