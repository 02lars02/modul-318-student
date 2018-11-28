namespace TransportApp
{
    partial class Connectionsboard
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
            this.cobStation = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.libConnectionsboard = new System.Windows.Forms.ListBox();
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
            // cobStation
            // 
            this.cobStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobStation.FormattingEnabled = true;
            this.cobStation.Location = new System.Drawing.Point(11, 157);
            this.cobStation.Name = "cobStation";
            this.cobStation.Size = new System.Drawing.Size(260, 47);
            this.cobStation.TabIndex = 14;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(7, 134);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(64, 20);
            this.lblStation.TabIndex = 13;
            this.lblStation.Text = "Station:";
            // 
            // libConnectionsboard
            // 
            this.libConnectionsboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libConnectionsboard.FormattingEnabled = true;
            this.libConnectionsboard.ItemHeight = 42;
            this.libConnectionsboard.Location = new System.Drawing.Point(290, 90);
            this.libConnectionsboard.Name = "libConnectionsboard";
            this.libConnectionsboard.Size = new System.Drawing.Size(489, 340);
            this.libConnectionsboard.TabIndex = 12;
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
            // Connectionsboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 428);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cobStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.libConnectionsboard);
            this.Controls.Add(this.btnConnectionboard);
            this.Controls.Add(this.btnConnection);
            this.Name = "Connectionsboard";
            this.Text = "Connectionsboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cobStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ListBox libConnectionsboard;
        private System.Windows.Forms.Button btnConnectionboard;
        private System.Windows.Forms.Button btnConnection;
    }
}