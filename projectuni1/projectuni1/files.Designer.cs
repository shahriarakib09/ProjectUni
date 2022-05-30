
namespace projectuni1
{
    partial class files
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtboxCourseId = new System.Windows.Forms.TextBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(178, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(214, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtboxCourseId
            // 
            this.txtboxCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCourseId.Location = new System.Drawing.Point(292, 159);
            this.txtboxCourseId.Name = "txtboxCourseId";
            this.txtboxCourseId.Size = new System.Drawing.Size(100, 26);
            this.txtboxCourseId.TabIndex = 11;
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseId.Location = new System.Drawing.Point(174, 161);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(103, 20);
            this.lblCourseId.TabIndex = 10;
            this.lblCourseId.Text = "COURSE ID ";
            // 
            // files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxCourseId);
            this.Controls.Add(this.lblCourseId);
            this.Name = "files";
            this.Size = new System.Drawing.Size(615, 591);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtboxCourseId;
        private System.Windows.Forms.Label lblCourseId;
    }
}
