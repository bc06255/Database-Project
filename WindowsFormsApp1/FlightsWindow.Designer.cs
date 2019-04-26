namespace WindowsFormsApp1
{
    partial class FlightsWindow
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.airportNameLbl = new System.Windows.Forms.Label();
            this.airportCityLbl = new System.Windows.Forms.Label();
            this.flightDateLbl = new System.Windows.Forms.Label();
            this.passPerYearLbl = new System.Windows.Forms.Label();
            this.flightIDLbl = new System.Windows.Forms.Label();
            this.planeIDBox = new System.Windows.Forms.TextBox();
            this.sourceBox = new System.Windows.Forms.TextBox();
            this.destBox = new System.Windows.Forms.TextBox();
            this.flightIDBox = new System.Windows.Forms.TextBox();
            this.flightsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.crewIDBox = new System.Windows.Forms.TextBox();
            this.flightDateBox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(152, 423);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(130, 60);
            this.deleteBtn.TabIndex = 29;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(10, 423);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 60);
            this.backBtn.TabIndex = 28;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(152, 347);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(130, 70);
            this.updateBtn.TabIndex = 27;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(10, 347);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(130, 70);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // airportNameLbl
            // 
            this.airportNameLbl.AutoSize = true;
            this.airportNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportNameLbl.Location = new System.Drawing.Point(14, 193);
            this.airportNameLbl.Name = "airportNameLbl";
            this.airportNameLbl.Size = new System.Drawing.Size(113, 24);
            this.airportNameLbl.TabIndex = 25;
            this.airportNameLbl.Text = "Destination";
            // 
            // airportCityLbl
            // 
            this.airportCityLbl.AutoSize = true;
            this.airportCityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportCityLbl.Location = new System.Drawing.Point(50, 139);
            this.airportCityLbl.Name = "airportCityLbl";
            this.airportCityLbl.Size = new System.Drawing.Size(77, 24);
            this.airportCityLbl.TabIndex = 24;
            this.airportCityLbl.Text = "Source";
            // 
            // flightDateLbl
            // 
            this.flightDateLbl.AutoSize = true;
            this.flightDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDateLbl.Location = new System.Drawing.Point(17, 84);
            this.flightDateLbl.Name = "flightDateLbl";
            this.flightDateLbl.Size = new System.Drawing.Size(110, 24);
            this.flightDateLbl.TabIndex = 23;
            this.flightDateLbl.Text = "Flight Date";
            // 
            // passPerYearLbl
            // 
            this.passPerYearLbl.AutoSize = true;
            this.passPerYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passPerYearLbl.Location = new System.Drawing.Point(45, 249);
            this.passPerYearLbl.Name = "passPerYearLbl";
            this.passPerYearLbl.Size = new System.Drawing.Size(82, 24);
            this.passPerYearLbl.TabIndex = 22;
            this.passPerYearLbl.Text = "PlaneID";
            // 
            // flightIDLbl
            // 
            this.flightIDLbl.AutoSize = true;
            this.flightIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightIDLbl.Location = new System.Drawing.Point(40, 27);
            this.flightIDLbl.Name = "flightIDLbl";
            this.flightIDLbl.Size = new System.Drawing.Size(87, 24);
            this.flightIDLbl.TabIndex = 21;
            this.flightIDLbl.Text = "Flight ID";
            // 
            // planeIDBox
            // 
            this.planeIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeIDBox.Location = new System.Drawing.Point(133, 247);
            this.planeIDBox.Name = "planeIDBox";
            this.planeIDBox.Size = new System.Drawing.Size(149, 26);
            this.planeIDBox.TabIndex = 20;
            // 
            // sourceBox
            // 
            this.sourceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceBox.Location = new System.Drawing.Point(133, 137);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(149, 26);
            this.sourceBox.TabIndex = 18;
            // 
            // destBox
            // 
            this.destBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destBox.Location = new System.Drawing.Point(133, 191);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(149, 26);
            this.destBox.TabIndex = 17;
            // 
            // flightIDBox
            // 
            this.flightIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightIDBox.Location = new System.Drawing.Point(133, 27);
            this.flightIDBox.Name = "flightIDBox";
            this.flightIDBox.Size = new System.Drawing.Size(149, 26);
            this.flightIDBox.TabIndex = 16;
            // 
            // flightsGridView
            // 
            this.flightsGridView.AllowUserToOrderColumns = true;
            this.flightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsGridView.Location = new System.Drawing.Point(302, 13);
            this.flightsGridView.Name = "flightsGridView";
            this.flightsGridView.Size = new System.Drawing.Size(645, 471);
            this.flightsGridView.TabIndex = 15;
            this.flightsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightsGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "CrewID";
            // 
            // crewIDBox
            // 
            this.crewIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crewIDBox.Location = new System.Drawing.Point(133, 306);
            this.crewIDBox.Name = "crewIDBox";
            this.crewIDBox.Size = new System.Drawing.Size(149, 26);
            this.crewIDBox.TabIndex = 30;
            // 
            // flightDateBox
            // 
            this.flightDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDateBox.Location = new System.Drawing.Point(133, 82);
            this.flightDateBox.Name = "flightDateBox";
            this.flightDateBox.Size = new System.Drawing.Size(149, 26);
            this.flightDateBox.TabIndex = 32;
            // 
            // FlightsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 496);
            this.Controls.Add(this.flightDateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crewIDBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.airportNameLbl);
            this.Controls.Add(this.airportCityLbl);
            this.Controls.Add(this.flightDateLbl);
            this.Controls.Add(this.passPerYearLbl);
            this.Controls.Add(this.flightIDLbl);
            this.Controls.Add(this.planeIDBox);
            this.Controls.Add(this.sourceBox);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.flightIDBox);
            this.Controls.Add(this.flightsGridView);
            this.Name = "FlightsWindow";
            this.Text = "FlightsWindow";
            this.Load += new System.EventHandler(this.FlightsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label airportNameLbl;
        private System.Windows.Forms.Label airportCityLbl;
        private System.Windows.Forms.Label flightDateLbl;
        private System.Windows.Forms.Label passPerYearLbl;
        private System.Windows.Forms.Label flightIDLbl;
        private System.Windows.Forms.TextBox planeIDBox;
        private System.Windows.Forms.TextBox sourceBox;
        private System.Windows.Forms.TextBox destBox;
        private System.Windows.Forms.TextBox flightIDBox;
        private System.Windows.Forms.DataGridView flightsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox crewIDBox;
        private System.Windows.Forms.DateTimePicker flightDateBox;
    }
}