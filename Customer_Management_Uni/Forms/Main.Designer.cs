namespace Customer_Management_Uni.Forms
{
    partial class Main
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
            this.ActiveReservesView = new System.Windows.Forms.DataGridView();
            this.ActiveReservationsText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveReservesView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveReservesView
            // 
            this.ActiveReservesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveReservesView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActiveReservesView.Location = new System.Drawing.Point(12, 50);
            this.ActiveReservesView.Name = "ActiveReservesView";
            this.ActiveReservesView.Size = new System.Drawing.Size(280, 448);
            this.ActiveReservesView.TabIndex = 0;
            // 
            // ActiveReservationsText
            // 
            this.ActiveReservationsText.AutoSize = true;
            this.ActiveReservationsText.Location = new System.Drawing.Point(9, 34);
            this.ActiveReservationsText.Name = "ActiveReservationsText";
            this.ActiveReservationsText.Size = new System.Drawing.Size(105, 13);
            this.ActiveReservationsText.TabIndex = 1;
            this.ActiveReservationsText.Text = "Active Reservations:";
            this.ActiveReservationsText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 659);
            this.Controls.Add(this.ActiveReservationsText);
            this.Controls.Add(this.ActiveReservesView);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveReservesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ActiveReservesView;
        private System.Windows.Forms.Label ActiveReservationsText;
    }
}