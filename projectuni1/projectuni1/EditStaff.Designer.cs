
namespace projectuni1
{
    partial class EditStaff
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
            this.btnDeletestuff = new System.Windows.Forms.Button();
            this.btnUpdatestuff = new System.Windows.Forms.Button();
            this.btnAddstuff = new System.Windows.Forms.Button();
            this.panelStuff = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnDeletestuff);
            this.panel1.Controls.Add(this.btnUpdatestuff);
            this.panel1.Controls.Add(this.btnAddstuff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 688);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 123);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeletestuff
            // 
            this.btnDeletestuff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeletestuff.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletestuff.Location = new System.Drawing.Point(0, 86);
            this.btnDeletestuff.Name = "btnDeletestuff";
            this.btnDeletestuff.Size = new System.Drawing.Size(200, 37);
            this.btnDeletestuff.TabIndex = 2;
            this.btnDeletestuff.Text = "Delete Stuff";
            this.btnDeletestuff.UseVisualStyleBackColor = true;
            this.btnDeletestuff.Click += new System.EventHandler(this.btnDeletestuff_Click);
            // 
            // btnUpdatestuff
            // 
            this.btnUpdatestuff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdatestuff.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatestuff.Location = new System.Drawing.Point(0, 40);
            this.btnUpdatestuff.Name = "btnUpdatestuff";
            this.btnUpdatestuff.Size = new System.Drawing.Size(200, 46);
            this.btnUpdatestuff.TabIndex = 1;
            this.btnUpdatestuff.Text = "Update Stuff";
            this.btnUpdatestuff.UseVisualStyleBackColor = true;
            this.btnUpdatestuff.Click += new System.EventHandler(this.btnUpdatestuff_Click);
            // 
            // btnAddstuff
            // 
            this.btnAddstuff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddstuff.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddstuff.Location = new System.Drawing.Point(0, 0);
            this.btnAddstuff.Name = "btnAddstuff";
            this.btnAddstuff.Size = new System.Drawing.Size(200, 40);
            this.btnAddstuff.TabIndex = 0;
            this.btnAddstuff.Text = "Add Staff";
            this.btnAddstuff.UseVisualStyleBackColor = true;
            this.btnAddstuff.Click += new System.EventHandler(this.btnAddstuff_Click);
            // 
            // panelStuff
            // 
            this.panelStuff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStuff.Location = new System.Drawing.Point(200, 0);
            this.panelStuff.Name = "panelStuff";
            this.panelStuff.Size = new System.Drawing.Size(566, 688);
            this.panelStuff.TabIndex = 1;
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 688);
            this.Controls.Add(this.panelStuff);
            this.Controls.Add(this.panel1);
            this.Name = "EditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditStaff_FormClosing);
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeletestuff;
        private System.Windows.Forms.Button btnUpdatestuff;
        private System.Windows.Forms.Button btnAddstuff;
        private System.Windows.Forms.Panel panelStuff;
        private System.Windows.Forms.Button btnBack;
    }
}