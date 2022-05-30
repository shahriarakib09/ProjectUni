
namespace projectuni1
{
    partial class Registration
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminname = new System.Windows.Forms.TextBox();
            this.txtAdminId = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblBloodG = new System.Windows.Forms.Label();
            this.txtBloodG = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(108, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 59;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(243, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 33);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(195, 278);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(189, 59);
            this.txtAddress.TabIndex = 55;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPhone.Location = new System.Drawing.Point(195, 349);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(189, 23);
            this.txtPhone.TabIndex = 49;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(195, 141);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 23);
            this.txtEmail.TabIndex = 47;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAdminPassword.Location = new System.Drawing.Point(195, 112);
            this.txtAdminPassword.Multiline = true;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(189, 23);
            this.txtAdminPassword.TabIndex = 46;
            this.txtAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdminname
            // 
            this.txtAdminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAdminname.Location = new System.Drawing.Point(195, 83);
            this.txtAdminname.Multiline = true;
            this.txtAdminname.Name = "txtAdminname";
            this.txtAdminname.Size = new System.Drawing.Size(189, 23);
            this.txtAdminname.TabIndex = 45;
            this.txtAdminname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdminId
            // 
            this.txtAdminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminId.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAdminId.Location = new System.Drawing.Point(195, 54);
            this.txtAdminId.Multiline = true;
            this.txtAdminId.Name = "txtAdminId";
            this.txtAdminId.Size = new System.Drawing.Size(189, 23);
            this.txtAdminId.TabIndex = 44;
            this.txtAdminId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdminId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdminId_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddress.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 278);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 23);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(30, 348);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(129, 23);
            this.lblPhoneNumber.TabIndex = 40;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.BackColor = System.Drawing.SystemColors.Control;
            this.lblDob.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(27, 175);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(112, 23);
            this.lblDob.TabIndex = 39;
            this.lblDob.Text = "Date of Birth:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.Control;
            this.lblGender.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(27, 214);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(71, 23);
            this.lblGender.TabIndex = 38;
            this.lblGender.Text = "Gender:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(27, 112);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 23);
            this.lblPassword.TabIndex = 36;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(27, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 23);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdminName.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(27, 83);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(111, 23);
            this.lblAdminName.TabIndex = 34;
            this.lblAdminName.Text = "Admin Name:";
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdminId.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAdminId.Location = new System.Drawing.Point(27, 54);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(81, 23);
            this.lblAdminId.TabIndex = 33;
            this.lblAdminId.Text = "Admin Id:";
            // 
            // lblBloodG
            // 
            this.lblBloodG.AutoSize = true;
            this.lblBloodG.BackColor = System.Drawing.SystemColors.Control;
            this.lblBloodG.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodG.Location = new System.Drawing.Point(27, 244);
            this.lblBloodG.Name = "lblBloodG";
            this.lblBloodG.Size = new System.Drawing.Size(110, 23);
            this.lblBloodG.TabIndex = 60;
            this.lblBloodG.Text = "Blood group:";
            // 
            // txtBloodG
            // 
            this.txtBloodG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodG.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtBloodG.Location = new System.Drawing.Point(195, 249);
            this.txtBloodG.MaxLength = 3;
            this.txtBloodG.Multiline = true;
            this.txtBloodG.Name = "txtBloodG";
            this.txtBloodG.Size = new System.Drawing.Size(189, 23);
            this.txtBloodG.TabIndex = 61;
            this.txtBloodG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtGender.Location = new System.Drawing.Point(195, 215);
            this.txtGender.MaxLength = 6;
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(189, 23);
            this.txtGender.TabIndex = 62;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDob
            // 
            this.txtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDob.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDob.Location = new System.Drawing.Point(195, 176);
            this.txtDob.Multiline = true;
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(189, 23);
            this.txtDob.TabIndex = 63;
            this.txtDob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 495);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtBloodG);
            this.Controls.Add(this.lblBloodG);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminname);
            this.Controls.Add(this.txtAdminId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblAdminId);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminname;
        private System.Windows.Forms.TextBox txtAdminId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label lblBloodG;
        private System.Windows.Forms.TextBox txtBloodG;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDob;
    }
}