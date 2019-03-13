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
            this.searchLbl = new System.Windows.Forms.Label();
            this.airportBtn = new System.Windows.Forms.Button();
            this.airlineBtn = new System.Windows.Forms.Button();
            this.flightBtn = new System.Windows.Forms.Button();
            this.planeModelBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeebtn
            // 
            this.employeebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.employeebtn.Location = new System.Drawing.Point(12, 12);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(291, 133);
            this.employeebtn.TabIndex = 0;
            this.employeebtn.Text = "Employee";
            this.employeebtn.UseVisualStyleBackColor = true;
            // 
            // customerbtn
            // 
            this.customerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.customerbtn.Location = new System.Drawing.Point(12, 155);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(291, 133);
            this.customerbtn.TabIndex = 1;
            this.customerbtn.Text = "Customer";
            this.customerbtn.UseVisualStyleBackColor = true;
            this.customerbtn.Click += new System.EventHandler(this.customerbtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.Location = new System.Drawing.Point(12, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(291, 42);
            this.searchLbl.TabIndex = 2;
            this.searchLbl.Text = "Search For:";
            this.searchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchLbl.Click += new System.EventHandler(this.searchLbl_Click);
            // 
            // airportBtn
            // 
            this.airportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportBtn.Location = new System.Drawing.Point(12, 45);
            this.airportBtn.Name = "airportBtn";
            this.airportBtn.Size = new System.Drawing.Size(291, 55);
            this.airportBtn.TabIndex = 3;
            this.airportBtn.Text = "Airport";
            this.airportBtn.UseVisualStyleBackColor = true;
            this.airportBtn.Click += new System.EventHandler(this.airportBtn_Click);
            // 
            // airlineBtn
            // 
            this.airlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineBtn.Location = new System.Drawing.Point(12, 106);
            this.airlineBtn.Name = "airlineBtn";
            this.airlineBtn.Size = new System.Drawing.Size(291, 55);
            this.airlineBtn.TabIndex = 4;
            this.airlineBtn.Text = "Airline";
            this.airlineBtn.UseVisualStyleBackColor = true;
            // 
            // flightBtn
            // 
            this.flightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightBtn.Location = new System.Drawing.Point(12, 167);
            this.flightBtn.Name = "flightBtn";
            this.flightBtn.Size = new System.Drawing.Size(291, 55);
            this.flightBtn.TabIndex = 5;
            this.flightBtn.Text = "Flight";
            this.flightBtn.UseVisualStyleBackColor = true;
            // 
            // planeModelBtn
            // 
            this.planeModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeModelBtn.Location = new System.Drawing.Point(12, 228);
            this.planeModelBtn.Name = "planeModelBtn";
            this.planeModelBtn.Size = new System.Drawing.Size(291, 55);
            this.planeModelBtn.TabIndex = 6;
            this.planeModelBtn.Text = "Plane Model";
            this.planeModelBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 294);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(291, 34);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // userSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 335);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.planeModelBtn);
            this.Controls.Add(this.flightBtn);
            this.Controls.Add(this.airlineBtn);
            this.Controls.Add(this.airportBtn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.customerbtn);
            this.Controls.Add(this.employeebtn);
            this.Name = "userSelectWindow";
            this.Text = "User Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeebtn;
        private System.Windows.Forms.Button customerbtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button airportBtn;
        private System.Windows.Forms.Button airlineBtn;
        private System.Windows.Forms.Button flightBtn;
        private System.Windows.Forms.Button planeModelBtn;
        private System.Windows.Forms.Button backBtn;
    }
}

