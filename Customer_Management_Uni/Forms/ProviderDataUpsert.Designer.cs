namespace Customer_Management_Uni.Forms
{
    partial class ProviderDataUpsert
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
            this.NameData = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ServiceTypeLabel = new System.Windows.Forms.Label();
            this.ServiceTypeData = new System.Windows.Forms.TextBox();
            this.NumberData = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.EmailAddressData = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameData
            // 
            this.NameData.Location = new System.Drawing.Point(91, 28);
            this.NameData.Name = "NameData";
            this.NameData.Size = new System.Drawing.Size(100, 20);
            this.NameData.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(47, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // ServiceTypeLabel
            // 
            this.ServiceTypeLabel.AutoSize = true;
            this.ServiceTypeLabel.Location = new System.Drawing.Point(12, 73);
            this.ServiceTypeLabel.Name = "ServiceTypeLabel";
            this.ServiceTypeLabel.Size = new System.Drawing.Size(73, 13);
            this.ServiceTypeLabel.TabIndex = 2;
            this.ServiceTypeLabel.Text = "Service Type:";
            // 
            // ServiceTypeData
            // 
            this.ServiceTypeData.Location = new System.Drawing.Point(91, 70);
            this.ServiceTypeData.Name = "ServiceTypeData";
            this.ServiceTypeData.Size = new System.Drawing.Size(100, 20);
            this.ServiceTypeData.TabIndex = 5;
            // 
            // NumberData
            // 
            this.NumberData.Location = new System.Drawing.Point(91, 113);
            this.NumberData.Name = "NumberData";
            this.NumberData.Size = new System.Drawing.Size(100, 20);
            this.NumberData.TabIndex = 9;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(38, 116);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(47, 13);
            this.NumberLabel.TabIndex = 8;
            this.NumberLabel.Text = "Number:";
            // 
            // EmailAddressData
            // 
            this.EmailAddressData.Location = new System.Drawing.Point(91, 162);
            this.EmailAddressData.Name = "EmailAddressData";
            this.EmailAddressData.Size = new System.Drawing.Size(100, 20);
            this.EmailAddressData.TabIndex = 11;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(12, 169);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.EmailAddressLabel.TabIndex = 10;
            this.EmailAddressLabel.Text = "EmailAddress:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 214);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(116, 214);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProviderDataUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 280);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmailAddressData);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.NumberData);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NameData);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ServiceTypeData);
            this.Controls.Add(this.ServiceTypeLabel);
            this.Name = "ProviderDataUpsert";
            this.Text = "ProviderDataUpsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameData;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ServiceTypeLabel;
        private System.Windows.Forms.TextBox ServiceTypeData;
        private System.Windows.Forms.TextBox NumberData;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox EmailAddressData;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}