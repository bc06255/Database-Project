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
            this.planesLbl = new System.Windows.Forms.Label();
            this.airlineIDLbl = new System.Windows.Forms.Label();
            this.planesBox = new System.Windows.Forms.TextBox();
            this.airlineBox = new System.Windows.Forms.TextBox();
            this.airlineIDBox = new System.Windows.Forms.TextBox();
            this.airlinesGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(10, 267);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(151, 60);
            this.backBtn.TabIndex = 27;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateAirlineBtn
            // 
            this.updateAirlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAirlineBtn.Location = new System.Drawing.Point(173, 196);
            this.updateAirlineBtn.Name = "updateAirlineBtn";
            this.updateAirlineBtn.Size = new System.Drawing.Size(150, 65);
            this.updateAirlineBtn.TabIndex = 26;
            this.updateAirlineBtn.Text = "Update";
            this.updateAirlineBtn.UseVisualStyleBackColor = true;
            this.updateAirlineBtn.Click += new System.EventHandler(this.updateAirlineBtn_Click);
            // 
            // addAirlineBtn
            // 
            this.addAirlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirlineBtn.Location = new System.Drawing.Point(11, 196);
            this.addAirlineBtn.Name = "addAirlineBtn";
            this.addAirlineBtn.Size = new System.Drawing.Size(150, 65);
            this.addAirlineBtn.TabIndex = 25;
            this.addAirlineBtn.Text = "Add";
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
            // planesLbl
            // 
            this.planesLbl.AutoSize = true;
            this.planesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planesLbl.Location = new System.Drawing.Point(78, 136);
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
            this.planesBox.Location = new System.Drawing.Point(174, 137);
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
            this.airlinesGridView.Size = new System.Drawing.Size(364, 315);
            this.airlinesGridView.TabIndex = 14;
            this.airlinesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.airlinesGridView_CellClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(173, 267);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 60);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // AirlinesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 340);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateAirlineBtn);
            this.Controls.Add(this.addAirlineBtn);
            this.Controls.Add(this.airlineLbl);
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
        private System.Windows.Forms.Label planesLbl;
        private System.Windows.Forms.Label airlineIDLbl;
        private System.Windows.Forms.TextBox planesBox;
        private System.Windows.Forms.TextBox airlineBox;
        private System.Windows.Forms.TextBox airlineIDBox;
        private System.Windows.Forms.DataGridView airlinesGridView;
        private System.Windows.Forms.Button deleteBtn;
    }
}