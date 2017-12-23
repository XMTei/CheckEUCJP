using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CheckEUCJP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string[] m_strExtensionsToBeChecked = {".cpp",".c",".h",".inl"};
		private string m_strOK= "OK";
		private string m_strBad = "Bad";
		private string m_strErr = "Err";

		#region Properties
		private int m_nNG=0;
		[Browsable(false), DefaultValue(0), Localizable(false)]
		public int NumberOfNG
		{
			get
			{
				return m_nNG;
			}
			set
			{
				m_nNG = value;
				ShowNGPerTotalFiles();
			}
		}
		private int m_nTotalFiles=0;
		[Browsable(false), DefaultValue(0), Localizable(false)]
		public int TotalFiles
		{
			get
			{
				return m_nTotalFiles;
			}
			set
			{
				m_nTotalFiles = value;
				ShowNGPerTotalFiles();
			}
		}
		#endregion Properties

		//************************************************************************
		//Name: 	OnSelectDirectoryBtnClick
		//Author: 	Zheng XM (2010/6/1)
		//Modify: 	
		//Return:  
		//Description: 选择源代码的位置
		//		
		private void OnSelectDirectoryBtnClick(object sender, EventArgs e)
		{
			FolderBrowserDialog oSelectForlder = new FolderBrowserDialog();
			oSelectForlder.ShowNewFolderButton = false;

			if (textBoxTargetDirectory.Text.Equals(""))
			{	//如果还没有设定过Dir的话就使用当前的Dir
				oSelectForlder.SelectedPath = Environment.CurrentDirectory;
			}
			else
			{	//如果已经设定过，就使用其
				oSelectForlder.SelectedPath = textBoxTargetDirectory.Text;
			}

			// Show the FolderBrowserDialog.
			DialogResult result = oSelectForlder.ShowDialog();
			if (result == DialogResult.OK)
			{	//选择好DIR了
				textBoxTargetDirectory.Text = oSelectForlder.SelectedPath;
			}
		}

		//************************************************************************
		//Name: 	OnCheckThemClick
		//Author: 	Zheng XM (2010/6/1)
		//Modify: 	
		//Return:  
		//Description: 实施检查
		//		
		private void OnCheckThemClick(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;	//显示等待
			listBoxCheckresult.Items.Clear();
			if (!textBoxTargetDirectory.Text.Equals(""))
			{	//有DIR的指定
				NumberOfNG = 0;
				TotalFiles = 0;
				CheckDirectory(textBoxTargetDirectory.Text);
			}
			Cursor.Current = Cursors.Default;	//恢复
		}

		//************************************************************************
		//Name: 	CheckDirectory
		//Author: 	Zheng XM (2010/6/1)
		//Modify: 	
		//Return:  
		//Description: 检查一个DIR之下的相关文件，并递归调用此，检查其下的DIR
		//		
		private void CheckDirectory(string strParentDirectory)
		{
			if (Directory.Exists(strParentDirectory))
			{
				string[] strFileNames = Directory.GetFiles(strParentDirectory);
				foreach (string strFileName in strFileNames)
				{
					if (File.Exists(strFileName))
					{	//此文件存在
						FileInfo oFileInfo = new FileInfo(strFileName);
						if (IsTargetFile(oFileInfo.Extension))
						{	//此文件书与处理对象
							TotalFiles++;
							CheckFile(strFileName);
						}
					}
				}
				//继续处理此Dir之下的DIR
				string[] strDirectories = Directory.GetDirectories(strParentDirectory);
				foreach (string strDirectory in strDirectories)
				{	//递归调用次函数
					CheckDirectory(strDirectory);
				}
			}
		}

		//************************************************************************
		//Name: 	CheckFile
		//Author: 	Zheng XM (2010/6/1)
		//Modify: 	
		//Return:  
		//Description: 检查一个文件
		//		
		private void CheckFile(string strFileFullName)
		{
			string strStatus = m_strOK;
			Encoding oEncodingByECUJP = Encoding.GetEncoding(20932);	//EUC-JP
			try
			{
				string strAllText = File.ReadAllText(strFileFullName, oEncodingByECUJP);

				if (strAllText.Contains("\r"))
				{
					strStatus = m_strBad;
					NumberOfNG++;
				}
			}
			catch (Exception e)
			{
				strStatus = m_strErr;
			}

			string strTest = String.Format("{0}\t{1}", strStatus, strFileFullName);
			listBoxCheckresult.Items.Add(strTest);
		}

		//************************************************************************
		//Name: 	IsTargetFile
		//Author: 	Zheng XM (2010/6/1)
		//Modify: 	
		//Return:  
		//Description: 检查给出的文件扩充名是否是处理对象文件
		//		
		private bool IsTargetFile(string strFileExtension)
		{
			bool bRcd = false;

			strFileExtension.ToLower();	//一定要以小写字来比较
			foreach(string strExtensionToBeCheced in m_strExtensionsToBeChecked)
			{
				if (strExtensionToBeCheced.Equals(strFileExtension))
				{
					bRcd = true;
					break;
				}
			}

			return bRcd;
		}

		//************************************************************************
		//Name: 	OnDrawListBoxItem
		//Author: 	Zheng XM (2010/6/1)
		//Modify: 	
		//Return:  
		//Description: 自己画每一个ListBox的Item
		//		
		private void OnDrawListBoxItem(object sender, DrawItemEventArgs e)
		{
			if (sender is ListBox)
			{
				ListBox oListBox = sender as ListBox;
				e.DrawBackground();

				if (e.Index >= 0)
				{
					Brush oBrush = Brushes.Black;

					string strItem = oListBox.Items[e.Index].ToString();

					if (strItem.IndexOf(m_strBad) == 0)
					{	//此Item为BadItem，画为红色
						oBrush = Brushes.Red;
					}
					else if (strItem.IndexOf(m_strErr) == 0)
					{
						oBrush = Brushes.Blue;
					}

					StringFormat oStringFormat = StringFormat.GenericDefault;
					float[] tabStops = { 40.0f, 60.0f };
					oStringFormat.SetTabStops(0.0f, tabStops);
					e.Graphics.DrawString(strItem, e.Font, oBrush, e.Bounds, oStringFormat);
					e.DrawFocusRectangle();
				}
			}
		}
		//************************************************************************
		//Name: 	ShowNGPerTotalFiles
		//Author: 	Zheng XM (2010/6/4)
		//Modify: 	
		//Return:  
		//Description: 在指定TextBox中显示  问题文件数量/文件总数
		//		
		private void ShowNGPerTotalFiles()
		{
			textBoxNumberOfNG.Text = String.Format("{0} / {1}", m_nNG, m_nTotalFiles);
		}

		//************************************************************************
		//Name: 	OnAboutClicked
		//Author: 	Zheng XM (2012/4/18)
		//Modify: 	
		//Return:  
		//Description: Show about
		//		
		private void OnAboutClicked(object sender, EventArgs e)
		{
			ITLAbout oAboutDlg = new ITLAbout();

			oAboutDlg.ShowDialog();
		}
	}
}
