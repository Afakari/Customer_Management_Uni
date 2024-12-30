namespace Customer_Management_Uni.Forms
{
    partial class UserForm
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
            this.UpdateData = new System.Windows.Forms.Button();
            this.InsertData = new System.Windows.Forms.Button();
            this.DeleteData = new System.Windows.Forms.Button();
            this.RefershForm = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateData
            // 
            this.UpdateData.Location = new System.Drawing.Point(12, 174);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(75, 23);
            this.UpdateData.TabIndex = 9;
            this.UpdateData.Text = "Update";
            this.UpdateData.UseVisualStyleBackColor = true;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // InsertData
            // 
            this.InsertData.Location = new System.Drawing.Point(12, 224);
            this.InsertData.Name = "InsertData";
            this.InsertData.Size = new System.Drawing.Size(75, 23);
            this.InsertData.TabIndex = 8;
            this.InsertData.Text = "Insert";
            this.InsertData.UseVisualStyleBackColor = true;
            this.InsertData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // DeleteData
            // 
            this.DeleteData.Location = new System.Drawing.Point(12, 119);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(75, 23);
            this.DeleteData.TabIndex = 7;
            this.DeleteData.Text = "Delete";
            this.DeleteData.UseVisualStyleBackColor = true;
            this.DeleteData.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // RefershForm
            // 
            this.RefershForm.Location = new System.Drawing.Point(12, 69);
            this.RefershForm.Name = "RefershForm";
            this.RefershForm.Size = new System.Drawing.Size(75, 23);
            this.RefershForm.TabIndex = 6;
            this.RefershForm.Text = "Refersh";
            this.RefershForm.UseVisualStyleBackColor = true;
            this.RefershForm.Click += new System.EventHandler(this.RefershForm_Click);
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(110, 12);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.Size = new System.Drawing.Size(342, 483);
            this.DataView.TabIndex = 5;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 530);
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.InsertData);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.RefershForm);
            this.Controls.Add(this.DataView);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdateData;
        private System.Windows.Forms.Button InsertData;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.Button RefershForm;
        private System.Windows.Forms.DataGridView DataView;
    }
}