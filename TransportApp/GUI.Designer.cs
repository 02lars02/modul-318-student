namespace TransportApp
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.btnSearch = new System.Windows.Forms.Button();
            this.cobEndstation = new System.Windows.Forms.ComboBox();
            this.lblEndstation = new System.Windows.Forms.Label();
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
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cobEndstation
            // 
            this.cobEndstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobEndstation.FormattingEnabled = true;
            this.cobEndstation.Location = new System.Drawing.Point(11, 245);
            this.cobEndstation.Name = "cobEndstation";
            this.cobEndstation.Size = new System.Drawing.Size(260, 39);
            this.cobEndstation.TabIndex = 4;
            this.cobEndstation.DropDown += new System.EventHandler(this.cobEndstation_DropDown);
            // 
            // lblEndstation
            // 
            this.lblEndstation.AutoSize = true;
            this.lblEndstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndstation.Location = new System.Drawing.Point(7, 222);
            this.lblEndstation.Name = "lblEndstation";
            this.lblEndstation.Size = new System.Drawing.Size(50, 20);
            this.lblEndstation.TabIndex = 0;
            this.lblEndstation.Text = "Nach:";
            // 
            // cobStartstation
            // 
            this.cobStartstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobStartstation.FormattingEnabled = true;
            this.cobStartstation.Location = new System.Drawing.Point(11, 157);
            this.cobStartstation.Name = "cobStartstation";
            this.cobStartstation.Size = new System.Drawing.Size(260, 39);
            this.cobStartstation.TabIndex = 3;
            this.cobStartstation.DropDown += new System.EventHandler(this.cobStartstation_DropDown);
            // 
            // lblStartstation
            // 
            this.lblStartstation.AutoSize = true;
            this.lblStartstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartstation.Location = new System.Drawing.Point(7, 134);
            this.lblStartstation.Name = "lblStartstation";
            this.lblStartstation.Size = new System.Drawing.Size(42, 20);
            this.lblStartstation.TabIndex = 0;
            this.lblStartstation.Text = "Von:";
            // 
            // libConnection
            // 
            this.libConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libConnection.FormattingEnabled = true;
            this.libConnection.ItemHeight = 42;
            this.libConnection.Location = new System.Drawing.Point(290, 90);
            this.libConnection.Name = "libConnection";
            this.libConnection.Size = new System.Drawing.Size(594, 340);
            this.libConnection.TabIndex = 12;
            // 
            // btnConnectionboard
            // 
            this.btnConnectionboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectionboard.Location = new System.Drawing.Point(143, 90);
            this.btnConnectionboard.Name = "btnConnectionboard";
            this.btnConnectionboard.Size = new System.Drawing.Size(150, 27);
            this.btnConnectionboard.TabIndex = 2;
            this.btnConnectionboard.Text = "Anzeigetafel";
            this.btnConnectionboard.UseVisualStyleBackColor = true;
            this.btnConnectionboard.Click += new System.EventHandler(this.btnConnectionboard_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(-5, 90);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(150, 27);
            this.btnConnection.TabIndex = 1;
            this.btnConnection.Text = "Verbindungen";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 431);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cobEndstation);
            this.Controls.Add(this.lblEndstation);
            this.Controls.Add(this.cobStartstation);
            this.Controls.Add(this.lblStartstation);
            this.Controls.Add(this.libConnection);
            this.Controls.Add(this.btnConnectionboard);
            this.Controls.Add(this.btnConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "Transport App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cobEndstation;
        private System.Windows.Forms.Label lblEndstation;
        private System.Windows.Forms.ComboBox cobStartstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.ListBox libConnection;
        private System.Windows.Forms.Button btnConnectionboard;
        private System.Windows.Forms.Button btnConnection;
    }
}