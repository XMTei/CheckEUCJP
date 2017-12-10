namespace CheckEUCJPWithLinux
{
	partial class ITLAbout
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
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.linkLabelCopyrights = new System.Windows.Forms.LinkLabel();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Location = new System.Drawing.Point(18, 21);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(35, 15);
			this.labelProductName.TabIndex = 0;
			this.labelProductName.Text = "label1";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Location = new System.Drawing.Point(18, 48);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(35, 15);
			this.labelVersion.TabIndex = 1;
			this.labelVersion.Text = "label2";
			// 
			// linkLabelCopyrights
			// 
			this.linkLabelCopyrights.AutoSize = true;
			this.linkLabelCopyrights.Location = new System.Drawing.Point(18, 75);
			this.linkLabelCopyrights.Name = "linkLabelCopyrights";
			this.linkLabelCopyrights.Size = new System.Drawing.Size(115, 15);
			this.linkLabelCopyrights.TabIndex = 2;
			this.linkLabelCopyrights.TabStop = true;
			this.linkLabelCopyrights.Text = "INF Technologies Ltd.";
			this.linkLabelCopyrights.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(147, 105);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// ITLAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 137);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.linkLabelCopyrights);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelProductName);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ITLAbout";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About this application";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.LinkLabel linkLabelCopyrights;
		private System.Windows.Forms.Button buttonOK;
	}
}