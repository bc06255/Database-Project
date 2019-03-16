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
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.airportCodeLbl = new System.Windows.Forms.Label();
            this.airportCodeBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.passengersBox = new System.Windows.Forms.TextBox();
            this.passengersLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeebtn
            // 
            this.employeebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.employeebtn.Location = new System.Drawing.Point(12, 12);
            this.employeebtn.Name = "employeebtn";
            this.employeebtn.Size = new System.Drawing.Size(446, 160);
            this.employeebtn.TabIndex = 0;
            this.employeebtn.Text = "Employee";
            this.employeebtn.UseVisualStyleBackColor = true;
            // 
            // customerbtn
            // 
            this.customerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.customerbtn.Location = new System.Drawing.Point(12, 177);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(446, 160);
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
            this.searchLbl.Size = new System.Drawing.Size(446, 42);
            this.searchLbl.TabIndex = 2;
            this.searchLbl.Text = "Search By:";
            this.searchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchLbl.Click += new System.EventHandler(this.searchLbl_Click);
            // 
            // airportBtn
            // 
            this.airportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportBtn.Location = new System.Drawing.Point(12, 45);
            this.airportBtn.Name = "airportBtn";
            this.airportBtn.Size = new System.Drawing.Size(446, 68);
            this.airportBtn.TabIndex = 3;
            this.airportBtn.Text = "Airport";
            this.airportBtn.UseVisualStyleBackColor = true;
            this.airportBtn.Click += new System.EventHandler(this.airportBtn_Click);
            // 
            // airlineBtn
            // 
            this.airlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineBtn.Location = new System.Drawing.Point(12, 119);
            this.airlineBtn.Name = "airlineBtn";
            this.airlineBtn.Size = new System.Drawing.Size(446, 68);
            this.airlineBtn.TabIndex = 4;
            this.airlineBtn.Text = "Airline";
            this.airlineBtn.UseVisualStyleBackColor = true;
            // 
            // flightBtn
            // 
            this.flightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightBtn.Location = new System.Drawing.Point(12, 193);
            this.flightBtn.Name = "flightBtn";
            this.flightBtn.Size = new System.Drawing.Size(446, 68);
            this.flightBtn.TabIndex = 5;
            this.flightBtn.Text = "Flight";
            this.flightBtn.UseVisualStyleBackColor = true;
            // 
            // planeModelBtn
            // 
            this.planeModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeModelBtn.Location = new System.Drawing.Point(12, 267);
            this.planeModelBtn.Name = "planeModelBtn";
            this.planeModelBtn.Size = new System.Drawing.Size(446, 68);
            this.planeModelBtn.TabIndex = 6;
            this.planeModelBtn.Text = "Plane Model";
            this.planeModelBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 343);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(446, 34);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(12, 45);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(446, 28);
            this.searchBox.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(12, 302);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(446, 35);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // airportCodeLbl
            // 
            this.airportCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportCodeLbl.Location = new System.Drawing.Point(12, 76);
            this.airportCodeLbl.Name = "airportCodeLbl";
            this.airportCodeLbl.Size = new System.Drawing.Size(446, 26);
            this.airportCodeLbl.TabIndex = 10;
            this.airportCodeLbl.Text = "AirportCode";
            this.airportCodeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // airportCodeBox
            // 
            this.airportCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportCodeBox.Location = new System.Drawing.Point(158, 105);
            this.airportCodeBox.Name = "airportCodeBox";
            this.airportCodeBox.Size = new System.Drawing.Size(149, 31);
            this.airportCodeBox.TabIndex = 11;
            this.airportCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityBox
            // 
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityBox.Location = new System.Drawing.Point(87, 168);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(300, 31);
            this.cityBox.TabIndex = 13;
            this.cityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityLbl
            // 
            this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLbl.Location = new System.Drawing.Point(12, 139);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(446, 26);
            this.cityLbl.TabIndex = 12;
            this.cityLbl.Text = "City";
            this.cityLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passengersBox
            // 
            this.passengersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengersBox.Location = new System.Drawing.Point(87, 231);
            this.passengersBox.Name = "passengersBox";
            this.passengersBox.Size = new System.Drawing.Size(300, 31);
            this.passengersBox.TabIndex = 15;
            this.passengersBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passengersLbl
            // 
            this.passengersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengersLbl.Location = new System.Drawing.Point(12, 202);
            this.passengersLbl.Name = "passengersLbl";
            this.passengersLbl.Size = new System.Drawing.Size(446, 26);
            this.passengersLbl.TabIndex = 14;
            this.passengersLbl.Text = "Passengers Per Year";
            this.passengersLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorLbl
            // 
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(13, 273);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(445, 26);
            this.errorLbl.TabIndex = 16;
            this.errorLbl.Text = "NO AIRPORT SELECTED";
            this.errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 389);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.planeModelBtn);
            this.Controls.Add(this.flightBtn);
            this.Controls.Add(this.airlineBtn);
            this.Controls.Add(this.airportBtn);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.passengersBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.airportCodeBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.airportCodeLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.passengersLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.customerbtn);
            this.Controls.Add(this.employeebtn);
            this.Controls.Add(this.searchLbl);
            this.Name = "userSelectWindow";
            this.Text = "User Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label airportCodeLbl;
        private System.Windows.Forms.TextBox airportCodeBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.TextBox passengersBox;
        private System.Windows.Forms.Label passengersLbl;
        private System.Windows.Forms.Label errorLbl;
    }
}

