﻿namespace TransportApp
{
    partial class Connection
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.datConnection = new System.Windows.Forms.DateTimePicker();
            this.cobEndstation = new System.Windows.Forms.ComboBox();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.cobStartstation = new System.Windows.Forms.ComboBox();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.libConnection = new System.Windows.Forms.ListBox();
            this.btnConnectionboard = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(11, 372);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // datConnection
            // 
            this.datConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datConnection.Location = new System.Drawing.Point(11, 319);
            this.datConnection.Name = "datConnection";
            this.datConnection.Size = new System.Drawing.Size(260, 26);
            this.datConnection.TabIndex = 17;
            // 
            // cobEndstation
            // 
            this.cobEndstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobEndstation.FormattingEnabled = true;
            this.cobEndstation.Location = new System.Drawing.Point(11, 245);
            this.cobEndstation.Name = "cobEndstation";
            this.cobEndstation.Size = new System.Drawing.Size(260, 47);
            this.cobEndstation.TabIndex = 16;
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndStation.Location = new System.Drawing.Point(7, 222);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(90, 20);
            this.lblEndStation.TabIndex = 15;
            this.lblEndStation.Text = "Endstation:";
            // 
            // cobStartstation
            // 
            this.cobStartstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobStartstation.FormattingEnabled = true;
            this.cobStartstation.Location = new System.Drawing.Point(11, 157);
            this.cobStartstation.Name = "cobStartstation";
            this.cobStartstation.Size = new System.Drawing.Size(260, 47);
            this.cobStartstation.TabIndex = 14;
            // 
            // lblStartstation
            // 
            this.lblStartstation.AutoSize = true;
            this.lblStartstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartstation.Location = new System.Drawing.Point(7, 134);
            this.lblStartstation.Name = "lblStartstation";
            this.lblStartstation.Size = new System.Drawing.Size(96, 20);
            this.lblStartstation.TabIndex = 13;
            this.lblStartstation.Text = "Startstation:";
            // 
            // libConnection
            // 
            this.libConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libConnection.FormattingEnabled = true;
            this.libConnection.ItemHeight = 42;
            this.libConnection.Location = new System.Drawing.Point(290, 90);
            this.libConnection.Name = "libConnection";
            this.libConnection.Size = new System.Drawing.Size(489, 340);
            this.libConnection.TabIndex = 12;
            // 
            // btnConnectionboard
            // 
            this.btnConnectionboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectionboard.Location = new System.Drawing.Point(143, 90);
            this.btnConnectionboard.Name = "btnConnectionboard";
            this.btnConnectionboard.Size = new System.Drawing.Size(150, 27);
            this.btnConnectionboard.TabIndex = 11;
            this.btnConnectionboard.Text = "Connectionboard";
            this.btnConnectionboard.UseVisualStyleBackColor = true;
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(-5, 90);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(150, 27);
            this.btnConnection.TabIndex = 10;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 431);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.datConnection);
            this.Controls.Add(this.cobEndstation);
            this.Controls.Add(this.lblEndStation);
            this.Controls.Add(this.cobStartstation);
            this.Controls.Add(this.lblStartstation);
            this.Controls.Add(this.libConnection);
            this.Controls.Add(this.btnConnectionboard);
            this.Controls.Add(this.btnConnection);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker datConnection;
        private System.Windows.Forms.ComboBox cobEndstation;
        private System.Windows.Forms.Label lblEndStation;
        private System.Windows.Forms.ComboBox cobStartstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.ListBox libConnection;
        private System.Windows.Forms.Button btnConnectionboard;
        private System.Windows.Forms.Button btnConnection;
    }
}