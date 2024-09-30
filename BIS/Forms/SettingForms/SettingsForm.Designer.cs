namespace BIS.UI
{
	partial class SettingsForm
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
			txtServer = new System.Windows.Forms.TextBox();
			txtDatabase = new System.Windows.Forms.TextBox();
			txtUsername = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// txtServer
			// 
			txtServer.Location = new System.Drawing.Point(231, 40);
			txtServer.Name = "txtServer";
			txtServer.Size = new System.Drawing.Size(100, 23);
			txtServer.TabIndex = 0;
			txtServer.Text = "77.245.159.27";
			// 
			// txtDatabase
			// 
			txtDatabase.Location = new System.Drawing.Point(231, 69);
			txtDatabase.Name = "txtDatabase";
			txtDatabase.Size = new System.Drawing.Size(100, 23);
			txtDatabase.TabIndex = 1;
			txtDatabase.Text = "bigintsoft";
			// 
			// txtUsername
			// 
			txtUsername.Location = new System.Drawing.Point(231, 98);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new System.Drawing.Size(100, 23);
			txtUsername.TabIndex = 2;
			txtUsername.Text = "biguser";
			// 
			// txtPassword
			// 
			txtPassword.Location = new System.Drawing.Point(231, 127);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new System.Drawing.Size(100, 23);
			txtPassword.TabIndex = 3;
			txtPassword.Text = "Bigboys2024*";
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(234, 164);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 4;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// SettingsForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(button1);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(txtDatabase);
			Controls.Add(txtServer);
			Name = "SettingsForm";
			Text = "SettingsForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.TextBox txtDatabase;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button button1;
	}
}