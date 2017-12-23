namespace CheckEUCJP
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxCheckresult = new System.Windows.Forms.ListBox();
			this.textBoxTargetDirectory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSelectDirectory = new System.Windows.Forms.Button();
			this.buttonCheck = new System.Windows.Forms.Button();
			this.textBoxNumberOfNG = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AccessibleDescription = null;
			this.label1.AccessibleName = null;
			resources.ApplyResources(this.label1, "label1");
			this.label1.Font = null;
			this.label1.Name = "label1";
			// 
			// listBoxCheckresult
			// 
			this.listBoxCheckresult.AccessibleDescription = null;
			this.listBoxCheckresult.AccessibleName = null;
			resources.ApplyResources(this.listBoxCheckresult, "listBoxCheckresult");
			this.listBoxCheckresult.BackgroundImage = null;
			this.listBoxCheckresult.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBoxCheckresult.Font = null;
			this.listBoxCheckresult.FormattingEnabled = true;
			this.listBoxCheckresult.Name = "listBoxCheckresult";
			this.listBoxCheckresult.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnDrawListBoxItem);
			// 
			// textBoxTargetDirectory
			// 
			this.textBoxTargetDirectory.AccessibleDescription = null;
			this.textBoxTargetDirectory.AccessibleName = null;
			resources.ApplyResources(this.textBoxTargetDirectory, "textBoxTargetDirectory");
			this.textBoxTargetDirectory.BackgroundImage = null;
			this.textBoxTargetDirectory.Font = null;
			this.textBoxTargetDirectory.Name = "textBoxTargetDirectory";
			this.textBoxTargetDirectory.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.AccessibleDescription = null;
			this.label2.AccessibleName = null;
			resources.ApplyResources(this.label2, "label2");
			this.label2.Font = null;
			this.label2.Name = "label2";
			// 
			// buttonSelectDirectory
			// 
			this.buttonSelectDirectory.AccessibleDescription = null;
			this.buttonSelectDirectory.AccessibleName = null;
			resources.ApplyResources(this.buttonSelectDirectory, "buttonSelectDirectory");
			this.buttonSelectDirectory.BackgroundImage = null;
			this.buttonSelectDirectory.Font = null;
			this.buttonSelectDirectory.Name = "buttonSelectDirectory";
			this.buttonSelectDirectory.UseVisualStyleBackColor = true;
			this.buttonSelectDirectory.Click += new System.EventHandler(this.OnSelectDirectoryBtnClick);
			// 
			// buttonCheck
			// 
			this.buttonCheck.AccessibleDescription = null;
			this.buttonCheck.AccessibleName = null;
			resources.ApplyResources(this.buttonCheck, "buttonCheck");
			this.buttonCheck.BackgroundImage = null;
			this.buttonCheck.Font = null;
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Click += new System.EventHandler(this.OnCheckThemClick);
			// 
			// textBoxNumberOfNG
			// 
			this.textBoxNumberOfNG.AccessibleDescription = null;
			this.textBoxNumberOfNG.AccessibleName = null;
			resources.ApplyResources(this.textBoxNumberOfNG, "textBoxNumberOfNG");
			this.textBoxNumberOfNG.BackgroundImage = null;
			this.textBoxNumberOfNG.Font = null;
			this.textBoxNumberOfNG.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxNumberOfNG.Name = "textBoxNumberOfNG";
			this.textBoxNumberOfNG.ReadOnly = true;
			// 
			// label3
			// 
			this.label3.AccessibleDescription = null;
			this.label3.AccessibleName = null;
			resources.ApplyResources(this.label3, "label3");
			this.label3.Font = null;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Name = "label3";
			// 
			// buttonAbout
			// 
			this.buttonAbout.AccessibleDescription = null;
			this.buttonAbout.AccessibleName = null;
			resources.ApplyResources(this.buttonAbout, "buttonAbout");
			this.buttonAbout.BackgroundImage = null;
			this.buttonAbout.Font = null;
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.UseVisualStyleBackColor = true;
			this.buttonAbout.Click += new System.EventHandler(this.OnAboutClicked);
			// 
			// Form1
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.buttonAbout);
			this.Controls.Add(this.textBoxNumberOfNG);
			this.Controls.Add(this.buttonCheck);
			this.Controls.Add(this.buttonSelectDirectory);
			this.Controls.Add(this.textBoxTargetDirectory);
			this.Controls.Add(this.listBoxCheckresult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxCheckresult;
		private System.Windows.Forms.TextBox textBoxTargetDirectory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSelectDirectory;
		private System.Windows.Forms.Button buttonCheck;
		private System.Windows.Forms.TextBox textBoxNumberOfNG;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonAbout;
	}
}

