namespace WindowsFormsApp1
{
    partial class userSelectWindow
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
            this.employeebtn = new System.Windows.Forms.Button();
            this.customerbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeebtn
            // 
            this.employeebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.employeebtn.Location = new System.Drawing.Point(104, 171);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(220, 70);
            this.employeebtn.TabIndex = 0;
            this.employeebtn.Text = "Employee";
            this.employeebtn.UseVisualStyleBackColor = true;
            // 
            // customerbtn
            // 
            this.customerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.customerbtn.Location = new System.Drawing.Point(473, 171);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(220, 70);
            this.customerbtn.TabIndex = 1;
            this.customerbtn.Text = "Customer";
            this.customerbtn.UseVisualStyleBackColor = true;
            // 
            // userSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerbtn);
            this.Controls.Add(this.employeebtn);
            this.Name = "userSelectWindow";
            this.Text = "User Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button customerbtn;
    }
}

