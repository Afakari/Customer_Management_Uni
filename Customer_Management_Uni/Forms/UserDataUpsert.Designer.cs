namespace Customer_Management_Uni.Forms
{
    partial class UserDataUpsert
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EmailAddressData = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.NumberData = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NameData = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(120, 175);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(18, 175);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // EmailAddressData
            // 
            this.EmailAddressData.Location = new System.Drawing.Point(95, 123);
            this.EmailAddressData.Name = "EmailAddressData";
            this.EmailAddressData.Size = new System.Drawing.Size(100, 20);
            this.EmailAddressData.TabIndex = 21;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(16, 130);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.EmailAddressLabel.TabIndex = 20;
            this.EmailAddressLabel.Text = "EmailAddress:";
            // 
            // NumberData
            // 
            this.NumberData.Location = new System.Drawing.Point(95, 74);
            this.NumberData.Name = "NumberData";
            this.NumberData.Size = new System.Drawing.Size(100, 20);
            this.NumberData.TabIndex = 19;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(42, 77);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(47, 13);
            this.NumberLabel.TabIndex = 18;
            this.NumberLabel.Text = "Number:";
            // 
            // NameData
            // 
            this.NameData.Location = new System.Drawing.Point(95, 27);
            this.NameData.Name = "NameData";
            this.NameData.Size = new System.Drawing.Size(100, 20);
            this.NameData.TabIndex = 17;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(51, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Name:";
            // 
            // UserDataUpsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 245);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmailAddressData);
            this.Controls.Add(this.EmailAddressLabel);
            this.Controls.Add(this.NumberData);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NameData);
            this.Controls.Add(this.NameLabel);
            this.Name = "UserDataUpsert";
            this.Text = "UserDataUpsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox EmailAddressData;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox NumberData;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NameData;
        private System.Windows.Forms.Label NameLabel;
    }
}