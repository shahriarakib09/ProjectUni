
namespace projectuni1
{
    partial class AdminDelete
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
            this.adminInfoButton = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.txtAdminDeleteId = new System.Windows.Forms.TextBox();
            this.adminUserNameLabel = new System.Windows.Forms.Label();
            this.dataGridViewAllAdmin = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.adminInfoButton);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.deleteAdminButton);
            this.panel1.Controls.Add(this.txtAdminDeleteId);
            this.panel1.Controls.Add(this.adminUserNameLabel);
            this.panel1.Controls.Add(this.dataGridViewAllAdmin);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 297);
            this.panel1.TabIndex = 3;
            // 
            // adminInfoButton
            // 
            this.adminInfoButton.BackColor = System.Drawing.SystemColors.Control;
            this.adminInfoButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminInfoButton.Location = new System.Drawing.Point(207, 214);
            this.adminInfoButton.Name = "adminInfoButton";
            this.adminInfoButton.Size = new System.Drawing.Size(113, 35);
            this.adminInfoButton.TabIndex = 7;
            this.adminInfoButton.Text = "View Admin ";
            this.adminInfoButton.UseVisualStyleBackColor = false;
            this.adminInfoButton.Click += new System.EventHandler(this.adminInfoButton_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(393, 255);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteAdminButton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdminButton.Location = new System.Drawing.Point(207, 255);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(113, 30);
            this.deleteAdminButton.TabIndex = 5;
            this.deleteAdminButton.Text = "Delete Admin";
            this.deleteAdminButton.UseVisualStyleBackColor = false;
            this.deleteAdminButton.Click += new System.EventHandler(this.deleteAdminButton_Click);
            // 
            // txtAdminDeleteId
            // 
            this.txtAdminDeleteId.Location = new System.Drawing.Point(166, 187);
            this.txtAdminDeleteId.MaxLength = 6;
            this.txtAdminDeleteId.Name = "txtAdminDeleteId";
            this.txtAdminDeleteId.Size = new System.Drawing.Size(203, 20);
            this.txtAdminDeleteId.TabIndex = 3;
            this.txtAdminDeleteId.TextChanged += new System.EventHandler(this.txtAdminDeleteId_TextChanged);
            this.txtAdminDeleteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdminDeleteId_KeyPress);
            // 
            // adminUserNameLabel
            // 
            this.adminUserNameLabel.AutoSize = true;
            this.adminUserNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserNameLabel.Location = new System.Drawing.Point(74, 186);
            this.adminUserNameLabel.Name = "adminUserNameLabel";
            this.adminUserNameLabel.Size = new System.Drawing.Size(86, 19);
            this.adminUserNameLabel.TabIndex = 2;
            this.adminUserNameLabel.Text = "Admin Id :";
            this.adminUserNameLabel.Click += new System.EventHandler(this.adminUserNameLabel_Click);
            // 
            // dataGridViewAllAdmin
            // 
            this.dataGridViewAllAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllAdmin.Location = new System.Drawing.Point(12, 0);
            this.dataGridViewAllAdmin.Name = "dataGridViewAllAdmin";
            this.dataGridViewAllAdmin.Size = new System.Drawing.Size(494, 150);
            this.dataGridViewAllAdmin.TabIndex = 0;
            // 
            // AdminDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 299);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDelete";
            this.Load += new System.EventHandler(this.AdminDelete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button deleteAdminButton;
        private System.Windows.Forms.TextBox txtAdminDeleteId;
        private System.Windows.Forms.Label adminUserNameLabel;
        private System.Windows.Forms.DataGridView dataGridViewAllAdmin;
        private System.Windows.Forms.Button adminInfoButton;
    }
}