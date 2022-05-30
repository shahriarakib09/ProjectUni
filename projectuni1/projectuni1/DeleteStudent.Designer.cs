
namespace projectuni1
{
    partial class DeleteStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.txtStudentDeleteId = new System.Windows.Forms.TextBox();
            this.adminUserNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteStudentButton);
            this.panel1.Controls.Add(this.txtStudentDeleteId);
            this.panel1.Controls.Add(this.adminUserNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 385);
            this.panel1.TabIndex = 1;
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.BackColor = System.Drawing.Color.Red;
            this.deleteStudentButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudentButton.Location = new System.Drawing.Point(101, 204);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(154, 30);
            this.deleteStudentButton.TabIndex = 8;
            this.deleteStudentButton.Text = "Delete ";
            this.deleteStudentButton.UseVisualStyleBackColor = false;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // txtStudentDeleteId
            // 
            this.txtStudentDeleteId.Location = new System.Drawing.Point(120, 144);
            this.txtStudentDeleteId.MaxLength = 6;
            this.txtStudentDeleteId.Name = "txtStudentDeleteId";
            this.txtStudentDeleteId.Size = new System.Drawing.Size(203, 20);
            this.txtStudentDeleteId.TabIndex = 7;
            this.txtStudentDeleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentDeleteId_KeyPress);
            // 
            // adminUserNameLabel
            // 
            this.adminUserNameLabel.AutoSize = true;
            this.adminUserNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserNameLabel.Location = new System.Drawing.Point(18, 143);
            this.adminUserNameLabel.Name = "adminUserNameLabel";
            this.adminUserNameLabel.Size = new System.Drawing.Size(96, 19);
            this.adminUserNameLabel.TabIndex = 6;
            this.adminUserNameLabel.Text = "Student Id :";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DeleteStudent";
            this.Size = new System.Drawing.Size(350, 385);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.TextBox txtStudentDeleteId;
        private System.Windows.Forms.Label adminUserNameLabel;
    }
}
