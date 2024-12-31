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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ActiveReservesView = new System.Windows.Forms.DataGridView();
            this.ActiveReservationsText = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SettingDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddReservation = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteReservation = new System.Windows.Forms.Button();
            this.UpdateReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveReservesView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActiveReservesView
            // 
            this.ActiveReservesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveReservesView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActiveReservesView.Location = new System.Drawing.Point(154, 41);
            this.ActiveReservesView.Name = "ActiveReservesView";
            this.ActiveReservesView.ReadOnly = true;
            this.ActiveReservesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActiveReservesView.Size = new System.Drawing.Size(322, 411);
            this.ActiveReservesView.TabIndex = 0;
            // 
            // ActiveReservationsText
            // 
            this.ActiveReservationsText.AutoSize = true;
            this.ActiveReservationsText.Location = new System.Drawing.Point(163, 25);
            this.ActiveReservationsText.Name = "ActiveReservationsText";
            this.ActiveReservationsText.Size = new System.Drawing.Size(105, 13);
            this.ActiveReservationsText.TabIndex = 1;
            this.ActiveReservationsText.Text = "Active Reservations:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingDropDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(767, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SettingDropDown
            // 
            this.SettingDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.providersToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.SettingDropDown.Image = ((System.Drawing.Image)(resources.GetObject("SettingDropDown.Image")));
            this.SettingDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingDropDown.Name = "SettingDropDown";
            this.SettingDropDown.Size = new System.Drawing.Size(62, 22);
            this.SettingDropDown.Text = "Settings";
            // 
            // providersToolStripMenuItem
            // 
            this.providersToolStripMenuItem.Name = "providersToolStripMenuItem";
            this.providersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.providersToolStripMenuItem.Text = "Providers";
            this.providersToolStripMenuItem.Click += new System.EventHandler(this.providersToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // AddReservation
            // 
            this.AddReservation.Location = new System.Drawing.Point(31, 182);
            this.AddReservation.Name = "AddReservation";
            this.AddReservation.Size = new System.Drawing.Size(75, 23);
            this.AddReservation.TabIndex = 3;
            this.AddReservation.Text = "Add";
            this.AddReservation.UseVisualStyleBackColor = true;
            this.AddReservation.Click += new System.EventHandler(this.AddReservation_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(31, 120);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // DeleteReservation
            // 
            this.DeleteReservation.Location = new System.Drawing.Point(31, 315);
            this.DeleteReservation.Name = "DeleteReservation";
            this.DeleteReservation.Size = new System.Drawing.Size(75, 23);
            this.DeleteReservation.TabIndex = 5;
            this.DeleteReservation.Text = "Delete";
            this.DeleteReservation.UseVisualStyleBackColor = true;
            this.DeleteReservation.Click += new System.EventHandler(this.DeleteReservation_Click);
            // 
            // UpdateReservation
            // 
            this.UpdateReservation.Location = new System.Drawing.Point(31, 249);
            this.UpdateReservation.Name = "UpdateReservation";
            this.UpdateReservation.Size = new System.Drawing.Size(75, 23);
            this.UpdateReservation.TabIndex = 6;
            this.UpdateReservation.Text = "Update";
            this.UpdateReservation.UseVisualStyleBackColor = true;
            this.UpdateReservation.Click += new System.EventHandler(this.UpdateReservation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 528);
            this.Controls.Add(this.UpdateReservation);
            this.Controls.Add(this.DeleteReservation);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddReservation);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ActiveReservationsText);
            this.Controls.Add(this.ActiveReservesView);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveReservesView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ActiveReservesView;
        private System.Windows.Forms.Label ActiveReservationsText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton SettingDropDown;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Button AddReservation;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteReservation;
        private System.Windows.Forms.Button UpdateReservation;
    }
}