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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.airlineLbl = new System.Windows.Forms.Label();
            this.modelCompanyLbl = new System.Windows.Forms.Label();
            this.modelLbl = new System.Windows.Forms.Label();
            this.planesLbl = new System.Windows.Forms.Label();
            this.airlineIDLbl = new System.Windows.Forms.Label();
            this.planesBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.modelCompanyBox = new System.Windows.Forms.TextBox();
            this.airlineBox = new System.Windows.Forms.TextBox();
            this.airlineIDBox = new System.Windows.Forms.TextBox();
            this.airlinesGridView = new System.Windows.Forms.DataGridView();
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(174, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 70);
            this.button2.TabIndex = 26;
            this.button2.Text = "Update Airport";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Airport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // airlineLbl
            // 
            this.airlineLbl.AutoSize = true;
            this.airlineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineLbl.Location = new System.Drawing.Point(103, 84);
            this.airlineLbl.Name = "airlineLbl";
            this.airlineLbl.Size = new System.Drawing.Size(70, 24);
            this.airlineLbl.TabIndex = 24;
            this.airlineLbl.Text = "Airline";
            // 
            // modelCompanyLbl
            // 
            this.modelCompanyLbl.AutoSize = true;
            this.modelCompanyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelCompanyLbl.Location = new System.Drawing.Point(6, 139);
            this.modelCompanyLbl.Name = "modelCompanyLbl";
            this.modelCompanyLbl.Size = new System.Drawing.Size(162, 24);
            this.modelCompanyLbl.TabIndex = 23;
            this.modelCompanyLbl.Text = "Model Company";
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLbl.Location = new System.Drawing.Point(100, 194);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(68, 24);
            this.modelLbl.TabIndex = 22;
            this.modelLbl.Text = "Model";
            // 
            // planesLbl
            // 
            this.planesLbl.AutoSize = true;
            this.planesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planesLbl.Location = new System.Drawing.Point(93, 249);
            this.planesLbl.Name = "planesLbl";
            this.planesLbl.Size = new System.Drawing.Size(73, 24);
            this.planesLbl.TabIndex = 21;
            this.planesLbl.Text = "Planes";
            // 
            // airlineIDLbl
            // 
            this.airlineIDLbl.AutoSize = true;
            this.airlineIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airlineIDLbl.Location = new System.Drawing.Point(71, 29);
            this.airlineIDLbl.Name = "airlineIDLbl";
            this.airlineIDLbl.Size = new System.Drawing.Size(95, 24);
            this.airlineIDLbl.TabIndex = 20;
            this.airlineIDLbl.Text = "Airline ID";
            // 
            // planesBox
            // 
            this.planesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planesBox.Location = new System.Drawing.Point(174, 247);
            this.planesBox.Name = "planesBox";
            this.planesBox.Size = new System.Drawing.Size(149, 26);
            this.planesBox.TabIndex = 19;
            // 
            // modelBox
            // 
            this.modelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelBox.Location = new System.Drawing.Point(174, 192);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(149, 26);
            this.modelBox.TabIndex = 18;
            // 
            // modelCompanyBox
            // 
            this.modelCompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelCompanyBox.Location = new System.Drawing.Point(174, 137);
            this.modelCompanyBox.Name = "modelCompanyBox";
            this.modelCompanyBox.Size = new System.Drawing.Size(149, 26);
            this.modelCompanyBox.TabIndex = 17;
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
            // AirlinesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.airlineLbl);
            this.Controls.Add(this.modelCompanyLbl);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.planesLbl);
            this.Controls.Add(this.airlineIDLbl);
            this.Controls.Add(this.planesBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.modelCompanyBox);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label airlineLbl;
        private System.Windows.Forms.Label modelCompanyLbl;
        private System.Windows.Forms.Label modelLbl;
        private System.Windows.Forms.Label planesLbl;
        private System.Windows.Forms.Label airlineIDLbl;
        private System.Windows.Forms.TextBox planesBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox modelCompanyBox;
        private System.Windows.Forms.TextBox airlineBox;
        private System.Windows.Forms.TextBox airlineIDBox;
        private System.Windows.Forms.DataGridView airlinesGridView;
    }
}