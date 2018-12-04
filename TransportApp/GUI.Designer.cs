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
            this.lblEndstation = new System.Windows.Forms.Label();
            this.lblStartstation = new System.Windows.Forms.Label();
            this.libConnection = new System.Windows.Forms.ListBox();
            this.btnConnectionboard = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtStartstation = new System.Windows.Forms.TextBox();
            this.txtEndstation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(11, 396);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.libConnection.TabIndex = 8;
            this.libConnection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.libConnection_KeyDown);
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
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(12, 302);
            this.dtpDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(260, 26);
            this.dtpDate.TabIndex = 5;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(87, 346);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(110, 29);
            this.dtpTime.TabIndex = 6;
            // 
            // txtStartstation
            // 
            this.txtStartstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartstation.Location = new System.Drawing.Point(11, 157);
            this.txtStartstation.Name = "txtStartstation";
            this.txtStartstation.Size = new System.Drawing.Size(260, 38);
            this.txtStartstation.TabIndex = 3;
            this.txtStartstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartstation_KeyDown);
            // 
            // txtEndstation
            // 
            this.txtEndstation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndstation.Location = new System.Drawing.Point(11, 245);
            this.txtEndstation.Name = "txtEndstation";
            this.txtEndstation.Size = new System.Drawing.Size(260, 38);
            this.txtEndstation.TabIndex = 4;
            this.txtEndstation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndstation_KeyDown);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 431);
            this.Controls.Add(this.txtEndstation);
            this.Controls.Add(this.txtStartstation);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEndstation);
            this.Controls.Add(this.lblStartstation);
            this.Controls.Add(this.libConnection);
            this.Controls.Add(this.btnConnectionboard);
            this.Controls.Add(this.btnConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Transport App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEndstation;
        private System.Windows.Forms.Label lblStartstation;
        private System.Windows.Forms.ListBox libConnection;
        private System.Windows.Forms.Button btnConnectionboard;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtStartstation;
        private System.Windows.Forms.TextBox txtEndstation;
    }
}