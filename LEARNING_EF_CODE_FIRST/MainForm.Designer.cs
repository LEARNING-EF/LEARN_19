namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.emailAddressTextBox = new System.Windows.Forms.TextBox();
			this.ageErrorMessageLabel = new System.Windows.Forms.Label();
			this.fullNameErrorMessageLabel = new System.Windows.Forms.Label();
			this.emailAddressErrorMessageLabel = new System.Windows.Forms.Label();
			this.createButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ageTextBox
			// 
			this.ageTextBox.Location = new System.Drawing.Point(12, 12);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(260, 20);
			this.ageTextBox.TabIndex = 0;
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Location = new System.Drawing.Point(12, 51);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(260, 20);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// emailAddressTextBox
			// 
			this.emailAddressTextBox.Location = new System.Drawing.Point(12, 90);
			this.emailAddressTextBox.Name = "emailAddressTextBox";
			this.emailAddressTextBox.Size = new System.Drawing.Size(260, 20);
			this.emailAddressTextBox.TabIndex = 2;
			// 
			// ageErrorMessageLabel
			// 
			this.ageErrorMessageLabel.AutoSize = true;
			this.ageErrorMessageLabel.Location = new System.Drawing.Point(12, 35);
			this.ageErrorMessageLabel.Name = "ageErrorMessageLabel";
			this.ageErrorMessageLabel.Size = new System.Drawing.Size(26, 13);
			this.ageErrorMessageLabel.TabIndex = 3;
			this.ageErrorMessageLabel.Text = "Age";
			this.ageErrorMessageLabel.Visible = false;
			// 
			// fullNameErrorMessageLabel
			// 
			this.fullNameErrorMessageLabel.AutoSize = true;
			this.fullNameErrorMessageLabel.Location = new System.Drawing.Point(9, 74);
			this.fullNameErrorMessageLabel.Name = "fullNameErrorMessageLabel";
			this.fullNameErrorMessageLabel.Size = new System.Drawing.Size(54, 13);
			this.fullNameErrorMessageLabel.TabIndex = 4;
			this.fullNameErrorMessageLabel.Text = "Full Name";
			this.fullNameErrorMessageLabel.Visible = false;
			// 
			// emailAddressErrorMessageLabel
			// 
			this.emailAddressErrorMessageLabel.AutoSize = true;
			this.emailAddressErrorMessageLabel.Location = new System.Drawing.Point(9, 113);
			this.emailAddressErrorMessageLabel.Name = "emailAddressErrorMessageLabel";
			this.emailAddressErrorMessageLabel.Size = new System.Drawing.Size(73, 13);
			this.emailAddressErrorMessageLabel.TabIndex = 5;
			this.emailAddressErrorMessageLabel.Text = "Email Address";
			this.emailAddressErrorMessageLabel.Visible = false;
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(12, 129);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(75, 23);
			this.createButton.TabIndex = 6;
			this.createButton.Text = "&Create";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 160);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.emailAddressErrorMessageLabel);
			this.Controls.Add(this.fullNameErrorMessageLabel);
			this.Controls.Add(this.ageErrorMessageLabel);
			this.Controls.Add(this.emailAddressTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.ageTextBox);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.TextBox emailAddressTextBox;
		private System.Windows.Forms.Label ageErrorMessageLabel;
		private System.Windows.Forms.Label fullNameErrorMessageLabel;
		private System.Windows.Forms.Label emailAddressErrorMessageLabel;
		private System.Windows.Forms.Button createButton;
	}
}
