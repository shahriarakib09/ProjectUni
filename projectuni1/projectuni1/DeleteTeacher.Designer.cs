
namespace projectuni1
{
    partial class DeleteTeacher
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
            this.deleteStuffButton = new System.Windows.Forms.Button();
            this.txtTeacherDeleteId = new System.Windows.Forms.TextBox();
            this.adminUserNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteStuffButton);
            this.panel1.Controls.Add(this.txtTeacherDeleteId);
            this.panel1.Controls.Add(this.adminUserNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 385);
            this.panel1.TabIndex = 1;
            // 
            // deleteStuffButton
            // 
            this.deleteStuffButton.BackColor = System.Drawing.Color.Red;
            this.deleteStuffButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStuffButton.Location = new System.Drawing.Point(101, 204);
            this.deleteStuffButton.Name = "deleteStuffButton";
            this.deleteStuffButton.Size = new System.Drawing.Size(154, 30);
            this.deleteStuffButton.TabIndex = 8;
            this.deleteStuffButton.Text = "Delete ";
            this.deleteStuffButton.UseVisualStyleBackColor = false;
            this.deleteStuffButton.Click += new System.EventHandler(this.deleteStuffButton_Click);
            // 
            // txtTeacherDeleteId
            // 
            this.txtTeacherDeleteId.Location = new System.Drawing.Point(120, 144);
            this.txtTeacherDeleteId.MaxLength = 6;
            this.txtTeacherDeleteId.Name = "txtTeacherDeleteId";
            this.txtTeacherDeleteId.Size = new System.Drawing.Size(203, 20);
            this.txtTeacherDeleteId.TabIndex = 7;
            this.txtTeacherDeleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeacherDeleteId_KeyPress);
            // 
            // adminUserNameLabel
            // 
            this.adminUserNameLabel.AutoSize = true;
            this.adminUserNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserNameLabel.Location = new System.Drawing.Point(18, 144);
            this.adminUserNameLabel.Name = "adminUserNameLabel";
            this.adminUserNameLabel.Size = new System.Drawing.Size(96, 19);
            this.adminUserNameLabel.TabIndex = 6;
            this.adminUserNameLabel.Text = "Teacher Id :";
            // 
            // DeleteTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DeleteTeacher";
            this.Size = new System.Drawing.Size(350, 385);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteStuffButton;
        private System.Windows.Forms.TextBox txtTeacherDeleteId;
        private System.Windows.Forms.Label adminUserNameLabel;
    }
}
