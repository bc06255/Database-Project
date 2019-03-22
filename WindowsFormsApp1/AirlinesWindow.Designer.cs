namespace WindowsFormsApp1
{
    partial class AirlinesWindow
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
            this.backBtn = new System.Windows.Forms.Button();
            this.updateAirlineBtn = new System.Windows.Forms.Button();
            this.addAirlineBtn = new System.Windows.Forms.Button();
            this.airlineLbl = new System.Windows.Forms.Label();
            this.planeIDLbl = new System.Windows.Forms.Label();
            this.planesLbl = new System.Windows.Forms.Label();
            this.airlineIDLbl = new System.Windows.Forms.Label();
            this.planesBox = new System.Windows.Forms.TextBox();
            this.airlineBox = new System.Windows.Forms.TextBox();
            this.airlineIDBox = new System.Windows.Forms.TextBox();
            this.airlinesGridView = new System.Windows.Forms.DataGridView();
            this.planeIDBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 378);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(312, 60);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateAirlineBtn
            // 
            this.updateAirlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAirlineBtn.Location = new System.Drawing.Point(11, 307);
            this.updateAirlineBtn.Name = "updateAirlineBtn";
            this.updateAirlineBtn.Size = new System.Drawing.Size(312, 65);
            this.updateAirlineBtn.TabIndex = 26;
            this.updateAirlineBtn.Text = "Update Airline";
            this.updateAirlineBtn.UseVisualStyleBackColor = true;
            // 
            // addAirlineBtn
            // 
            this.addAirlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirlineBtn.Location = new System.Drawing.Point(12, 236);
            this.addAirlineBtn.Name = "addAirlineBtn";
            this.addAirlineBtn.Size = new System.Drawing.Size(312, 65);
            this.addAirlineBtn.TabIndex = 25;
            this.addAirlineBtn.Text = "Add Airline";
            this.addAirlineBtn.UseVisualStyleBackColor = true;
            this.addAirlineBtn.Click += new System.EventHandler(this.addAirlineBtn_Click);
            // 
            // airlineLbl
            // 
            this.airlineLbl.AutoSize = true;
            this.airlineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineLbl.Location = new System.Drawing.Point(89, 83);
            this.airlineLbl.Name = "airlineLbl";
            this.airlineLbl.Size = new System.Drawing.Size(79, 25);
            this.airlineLbl.TabIndex = 24;
            this.airlineLbl.Text = "Airline";
            // 
            // planeIDLbl
            // 
            this.planeIDLbl.AutoSize = true;
            this.planeIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeIDLbl.Location = new System.Drawing.Point(67, 138);
            this.planeIDLbl.Name = "planeIDLbl";
            this.planeIDLbl.Size = new System.Drawing.Size(101, 25);
            this.planeIDLbl.TabIndex = 22;
            this.planeIDLbl.Text = "Plane ID";
            // 
            // planesLbl
            // 
            this.planesLbl.AutoSize = true;
            this.planesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planesLbl.Location = new System.Drawing.Point(84, 193);
            this.planesLbl.Name = "planesLbl";
            this.planesLbl.Size = new System.Drawing.Size(84, 25);
            this.planesLbl.TabIndex = 21;
            this.planesLbl.Text = "Planes";
            // 
            // airlineIDLbl
            // 
            this.airlineIDLbl.AutoSize = true;
            this.airlineIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineIDLbl.Location = new System.Drawing.Point(60, 28);
            this.airlineIDLbl.Name = "airlineIDLbl";
            this.airlineIDLbl.Size = new System.Drawing.Size(108, 25);
            this.airlineIDLbl.TabIndex = 20;
            this.airlineIDLbl.Text = "Airline ID";
            // 
            // planesBox
            // 
            this.planesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planesBox.Location = new System.Drawing.Point(174, 192);
            this.planesBox.Name = "planesBox";
            this.planesBox.Size = new System.Drawing.Size(149, 26);
            this.planesBox.TabIndex = 19;
            // 
            // airlineBox
            // 
            this.airlineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineBox.Location = new System.Drawing.Point(174, 82);
            this.airlineBox.Name = "airlineBox";
            this.airlineBox.Size = new System.Drawing.Size(149, 26);
            this.airlineBox.TabIndex = 16;
            // 
            // airlineIDBox
            // 
            this.airlineIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineIDBox.Location = new System.Drawing.Point(174, 27);
            this.airlineIDBox.Name = "airlineIDBox";
            this.airlineIDBox.Size = new System.Drawing.Size(149, 26);
            this.airlineIDBox.TabIndex = 15;
            // 
            // airlinesGridView
            // 
            this.airlinesGridView.AllowUserToOrderColumns = true;
            this.airlinesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airlinesGridView.Location = new System.Drawing.Point(333, 12);
            this.airlinesGridView.Name = "airlinesGridView";
            this.airlinesGridView.Size = new System.Drawing.Size(567, 426);
            this.airlinesGridView.TabIndex = 14;
            this.airlinesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // planeIDBox
            // 
            this.planeIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeIDBox.Location = new System.Drawing.Point(174, 137);
            this.planeIDBox.Name = "planeIDBox";
            this.planeIDBox.Size = new System.Drawing.Size(149, 26);
            this.planeIDBox.TabIndex = 28;
            // 
            // AirlinesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.planeIDBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateAirlineBtn);
            this.Controls.Add(this.addAirlineBtn);
            this.Controls.Add(this.airlineLbl);
            this.Controls.Add(this.planeIDLbl);
            this.Controls.Add(this.planesLbl);
            this.Controls.Add(this.airlineIDLbl);
            this.Controls.Add(this.planesBox);
            this.Controls.Add(this.airlineBox);
            this.Controls.Add(this.airlineIDBox);
            this.Controls.Add(this.airlinesGridView);
            this.Name = "AirlinesWindow";
            this.Text = "AirlinesWindow";
            this.Load += new System.EventHandler(this.AirlinesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlinesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateAirlineBtn;
        private System.Windows.Forms.Button addAirlineBtn;
        private System.Windows.Forms.Label airlineLbl;
        private System.Windows.Forms.Label planeIDLbl;
        private System.Windows.Forms.Label planesLbl;
        private System.Windows.Forms.Label airlineIDLbl;
        private System.Windows.Forms.TextBox planesBox;
        private System.Windows.Forms.TextBox airlineBox;
        private System.Windows.Forms.TextBox airlineIDBox;
        private System.Windows.Forms.DataGridView airlinesGridView;
        private System.Windows.Forms.TextBox planeIDBox;
    }
}