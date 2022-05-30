
namespace projectuni1
{
    partial class EditStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeletestudent = new System.Windows.Forms.Button();
            this.btnUpdatestudent = new System.Windows.Forms.Button();
            this.btnAddstudent = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnDeletestudent);
            this.panel1.Controls.Add(this.btnUpdatestudent);
            this.panel1.Controls.Add(this.btnAddstudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 688);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 123);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 37);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeletestudent
            // 
            this.btnDeletestudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeletestudent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletestudent.Location = new System.Drawing.Point(0, 86);
            this.btnDeletestudent.Name = "btnDeletestudent";
            this.btnDeletestudent.Size = new System.Drawing.Size(200, 37);
            this.btnDeletestudent.TabIndex = 2;
            this.btnDeletestudent.Text = "Delete Student";
            this.btnDeletestudent.UseVisualStyleBackColor = true;
            this.btnDeletestudent.Click += new System.EventHandler(this.btnDeletestudent_Click);
            // 
            // btnUpdatestudent
            // 
            this.btnUpdatestudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdatestudent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatestudent.Location = new System.Drawing.Point(0, 40);
            this.btnUpdatestudent.Name = "btnUpdatestudent";
            this.btnUpdatestudent.Size = new System.Drawing.Size(200, 46);
            this.btnUpdatestudent.TabIndex = 1;
            this.btnUpdatestudent.Text = "Update Student";
            this.btnUpdatestudent.UseVisualStyleBackColor = true;
            this.btnUpdatestudent.Click += new System.EventHandler(this.btnUpdatestudent_Click);
            // 
            // btnAddstudent
            // 
            this.btnAddstudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddstudent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddstudent.Location = new System.Drawing.Point(0, 0);
            this.btnAddstudent.Name = "btnAddstudent";
            this.btnAddstudent.Size = new System.Drawing.Size(200, 40);
            this.btnAddstudent.TabIndex = 0;
            this.btnAddstudent.Text = "Add Student";
            this.btnAddstudent.UseVisualStyleBackColor = true;
            this.btnAddstudent.Click += new System.EventHandler(this.btnAddstudent_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStudent.Location = new System.Drawing.Point(200, 0);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(566, 688);
            this.panelStudent.TabIndex = 2;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 688);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panel1);
            this.Name = "EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStudent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditStudent_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeletestudent;
        private System.Windows.Forms.Button btnUpdatestudent;
        private System.Windows.Forms.Button btnAddstudent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelStudent;
    }
}