namespace projectuni1
{
    partial class ViewCourseRequest
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
            this.btnViewCourseRequest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewCourseRequest
            // 
            this.btnViewCourseRequest.Location = new System.Drawing.Point(216, 330);
            this.btnViewCourseRequest.Name = "btnViewCourseRequest";
            this.btnViewCourseRequest.Size = new System.Drawing.Size(166, 43);
            this.btnViewCourseRequest.TabIndex = 0;
            this.btnViewCourseRequest.Text = "Show Course Request";
            this.btnViewCourseRequest.UseVisualStyleBackColor = true;
            this.btnViewCourseRequest.Click += new System.EventHandler(this.btnViewCourseRequest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // ViewCourseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewCourseRequest);
            this.Name = "ViewCourseRequest";
            this.Size = new System.Drawing.Size(580, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewCourseRequest;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
