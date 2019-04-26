﻿namespace WindowsFormsApp1
{
    partial class AirportsWindow
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
            this.airportsGridView = new System.Windows.Forms.DataGridView();
            this.airportIDBox = new System.Windows.Forms.TextBox();
            this.airportNameBox = new System.Windows.Forms.TextBox();
            this.airportCityBox = new System.Windows.Forms.TextBox();
            this.airportStateBox = new System.Windows.Forms.TextBox();
            this.passPerYearBox = new System.Windows.Forms.TextBox();
            this.airportIDLbl = new System.Windows.Forms.Label();
            this.passPerYearLbl = new System.Windows.Forms.Label();
            this.airportStateLbl = new System.Windows.Forms.Label();
            this.airportCityLbl = new System.Windows.Forms.Label();
            this.airportNameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.airportsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // airportsGridView
            // 
            this.airportsGridView.AllowUserToOrderColumns = true;
            this.airportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airportsGridView.Location = new System.Drawing.Point(302, 12);
            this.airportsGridView.Name = "airportsGridView";
            this.airportsGridView.Size = new System.Drawing.Size(567, 426);
            this.airportsGridView.TabIndex = 0;
            this.airportsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // airportIDBox
            // 
            this.airportIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportIDBox.Location = new System.Drawing.Point(135, 27);
            this.airportIDBox.Name = "airportIDBox";
            this.airportIDBox.Size = new System.Drawing.Size(149, 26);
            this.airportIDBox.TabIndex = 1;
            // 
            // airportNameBox
            // 
            this.airportNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportNameBox.Location = new System.Drawing.Point(135, 191);
            this.airportNameBox.Name = "airportNameBox";
            this.airportNameBox.Size = new System.Drawing.Size(149, 26);
            this.airportNameBox.TabIndex = 2;
            this.airportNameBox.TextChanged += new System.EventHandler(this.airportNameBox_TextChanged);
            // 
            // airportCityBox
            // 
            this.airportCityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportCityBox.Location = new System.Drawing.Point(135, 137);
            this.airportCityBox.Name = "airportCityBox";
            this.airportCityBox.Size = new System.Drawing.Size(149, 26);
            this.airportCityBox.TabIndex = 3;
            this.airportCityBox.TextChanged += new System.EventHandler(this.airportCityBox_TextChanged);
            // 
            // airportStateBox
            // 
            this.airportStateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportStateBox.Location = new System.Drawing.Point(135, 82);
            this.airportStateBox.Name = "airportStateBox";
            this.airportStateBox.Size = new System.Drawing.Size(149, 26);
            this.airportStateBox.TabIndex = 4;
            // 
            // passPerYearBox
            // 
            this.passPerYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passPerYearBox.Location = new System.Drawing.Point(135, 247);
            this.passPerYearBox.Name = "passPerYearBox";
            this.passPerYearBox.Size = new System.Drawing.Size(149, 26);
            this.passPerYearBox.TabIndex = 5;
            // 
            // airportIDLbl
            // 
            this.airportIDLbl.AutoSize = true;
            this.airportIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportIDLbl.Location = new System.Drawing.Point(32, 29);
            this.airportIDLbl.Name = "airportIDLbl";
            this.airportIDLbl.Size = new System.Drawing.Size(97, 24);
            this.airportIDLbl.TabIndex = 6;
            this.airportIDLbl.Text = "Airport ID";
            // 
            // passPerYearLbl
            // 
            this.passPerYearLbl.AutoSize = true;
            this.passPerYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passPerYearLbl.Location = new System.Drawing.Point(10, 249);
            this.passPerYearLbl.Name = "passPerYearLbl";
            this.passPerYearLbl.Size = new System.Drawing.Size(119, 24);
            this.passPerYearLbl.TabIndex = 7;
            this.passPerYearLbl.Text = "Passengers";
            // 
            // airportStateLbl
            // 
            this.airportStateLbl.AutoSize = true;
            this.airportStateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportStateLbl.Location = new System.Drawing.Point(73, 84);
            this.airportStateLbl.Name = "airportStateLbl";
            this.airportStateLbl.Size = new System.Drawing.Size(56, 24);
            this.airportStateLbl.TabIndex = 8;
            this.airportStateLbl.Text = "State";
            // 
            // airportCityLbl
            // 
            this.airportCityLbl.AutoSize = true;
            this.airportCityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportCityLbl.Location = new System.Drawing.Point(85, 139);
            this.airportCityLbl.Name = "airportCityLbl";
            this.airportCityLbl.Size = new System.Drawing.Size(44, 24);
            this.airportCityLbl.TabIndex = 9;
            this.airportCityLbl.Text = "City";
            // 
            // airportNameLbl
            // 
            this.airportNameLbl.AutoSize = true;
            this.airportNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportNameLbl.Location = new System.Drawing.Point(64, 193);
            this.airportNameLbl.Name = "airportNameLbl";
            this.airportNameLbl.Size = new System.Drawing.Size(65, 24);
            this.airportNameLbl.TabIndex = 10;
            this.airportNameLbl.Text = "Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Airport";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(154, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 70);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update Airport";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 378);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(272, 60);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AirportsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.airportNameLbl);
            this.Controls.Add(this.airportCityLbl);
            this.Controls.Add(this.airportStateLbl);
            this.Controls.Add(this.passPerYearLbl);
            this.Controls.Add(this.airportIDLbl);
            this.Controls.Add(this.passPerYearBox);
            this.Controls.Add(this.airportCityBox);
            this.Controls.Add(this.airportNameBox);
            this.Controls.Add(this.airportIDBox);
            this.Controls.Add(this.airportsGridView);
            this.Controls.Add(this.airportStateBox);
            this.Name = "AirportsWindow";
            this.Text = "AirportsWindow";
            this.Load += new System.EventHandler(this.AirportsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView airportsGridView;
        private System.Windows.Forms.TextBox airportIDBox;
        private System.Windows.Forms.TextBox airportNameBox;
        private System.Windows.Forms.TextBox airportCityBox;
        private System.Windows.Forms.TextBox airportStateBox;
        private System.Windows.Forms.TextBox passPerYearBox;
        private System.Windows.Forms.Label airportIDLbl;
        private System.Windows.Forms.Label passPerYearLbl;
        private System.Windows.Forms.Label airportStateLbl;
        private System.Windows.Forms.Label airportCityLbl;
        private System.Windows.Forms.Label airportNameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button backBtn;
    }
}