
namespace projectuni1
{
    partial class EditTeacher
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
            this.btnDeleteteacher = new System.Windows.Forms.Button();
            this.btnUpdateteacher = new System.Windows.Forms.Button();
            this.btnAddteacher = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnDeleteteacher);
            this.panel1.Controls.Add(this.btnUpdateteacher);
            this.panel1.Controls.Add(this.btnAddteacher);
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
            // btnDeleteteacher
            // 
            this.btnDeleteteacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteteacher.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteteacher.Location = new System.Drawing.Point(0, 86);
            this.btnDeleteteacher.Name = "btnDeleteteacher";
            this.btnDeleteteacher.Size = new System.Drawing.Size(200, 37);
            this.btnDeleteteacher.TabIndex = 2;
            this.btnDeleteteacher.Text = "Delete Teacher";
            this.btnDeleteteacher.UseVisualStyleBackColor = true;
            this.btnDeleteteacher.Click += new System.EventHandler(this.btnDeleteteacher_Click);
            // 
            // btnUpdateteacher
            // 
            this.btnUpdateteacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateteacher.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateteacher.Location = new System.Drawing.Point(0, 40);
            this.btnUpdateteacher.Name = "btnUpdateteacher";
            this.btnUpdateteacher.Size = new System.Drawing.Size(200, 46);
            this.btnUpdateteacher.TabIndex = 1;
            this.btnUpdateteacher.Text = "Update Teacher";
            this.btnUpdateteacher.UseVisualStyleBackColor = true;
            this.btnUpdateteacher.Click += new System.EventHandler(this.btnUpdateteacher_Click);
            // 
            // btnAddteacher
            // 
            this.btnAddteacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddteacher.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddteacher.Location = new System.Drawing.Point(0, 0);
            this.btnAddteacher.Name = "btnAddteacher";
            this.btnAddteacher.Size = new System.Drawing.Size(200, 40);
            this.btnAddteacher.TabIndex = 0;
            this.btnAddteacher.Text = "Add Teacher";
            this.btnAddteacher.UseVisualStyleBackColor = true;
            this.btnAddteacher.Click += new System.EventHandler(this.btnAddteacher_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeacher.Location = new System.Drawing.Point(200, 0);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(566, 688);
            this.panelTeacher.TabIndex = 2;
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 688);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.panel1);
            this.Name = "EditTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTeacher_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteteacher;
        private System.Windows.Forms.Button btnUpdateteacher;
        private System.Windows.Forms.Button btnAddteacher;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelTeacher;
    }
}