namespace projectuni1
{
    partial class UploadFile
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
            this.txtboxCourseId = new System.Windows.Forms.TextBox();
            this.txtBoxTeachersId = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxFileName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(258, 151);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(68, 19);
            this.lblCourseId.TabIndex = 1;
            this.lblCourseId.Text = "Course Id";
            // 
            // lblTeachersId
            // 
            this.lblTeachersId.AutoSize = true;
            this.lblTeachersId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachersId.Location = new System.Drawing.Point(247, 203);
            this.lblTeachersId.Name = "lblTeachersId";
            this.lblTeachersId.Size = new System.Drawing.Size(79, 19);
            this.lblTeachersId.TabIndex = 2;
            this.lblTeachersId.Text = "Teachers Id";
            // 
            // txtboxCourseId
            // 
            this.txtboxCourseId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCourseId.Location = new System.Drawing.Point(386, 148);
            this.txtboxCourseId.MaxLength = 4;
            this.txtboxCourseId.Name = "txtboxCourseId";
            this.txtboxCourseId.Size = new System.Drawing.Size(102, 24);
            this.txtboxCourseId.TabIndex = 5;
            this.txtboxCourseId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCourseId_KeyPress);
            // 
            // txtBoxTeachersId
            // 
            this.txtBoxTeachersId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTeachersId.Location = new System.Drawing.Point(386, 198);
            this.txtBoxTeachersId.MaxLength = 6;
            this.txtBoxTeachersId.Name = "txtBoxTeachersId";
            this.txtBoxTeachersId.Size = new System.Drawing.Size(102, 24);
            this.txtBoxTeachersId.TabIndex = 6;
            this.txtBoxTeachersId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTeachersId_KeyPress);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(382, 364);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(106, 39);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(251, 269);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(81, 30);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Location = new System.Drawing.Point(386, 269);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(183, 30);
            this.txtBoxFileName.TabIndex = 9;
            this.txtBoxFileName.Text = "";
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtBoxTeachersId);
            this.Controls.Add(this.txtboxCourseId);
            this.Controls.Add(this.lblTeachersId);
            this.Controls.Add(this.lblCourseId);
            this.Name = "UploadFile";
            this.Size = new System.Drawing.Size(702, 472);
            this.Load += new System.EventHandler(this.UploadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblTeachersId;
        private System.Windows.Forms.TextBox txtboxCourseId;
        private System.Windows.Forms.TextBox txtBoxTeachersId;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtBoxFileName;
    }
}
