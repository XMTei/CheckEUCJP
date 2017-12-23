using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckEUCJP
{
	public partial class ITLAbout : Form
	{
		public ITLAbout()
		{
			InitializeComponent();

			//获取此App的Assembly(AssemblyInfo.cpp中的内容)
			System.Reflection.Assembly oAssembly = System.Reflection.Assembly.GetExecutingAssembly();
			System.Reflection.AssemblyTitleAttribute oTiltleAttribute = System.Reflection.AssemblyTitleAttribute.GetCustomAttribute(oAssembly,typeof(System.Reflection.AssemblyTitleAttribute)) as System.Reflection.AssemblyTitleAttribute;
			System.Reflection.AssemblyCopyrightAttribute oCopyRightAttribute = System.Reflection.AssemblyCopyrightAttribute.GetCustomAttribute(oAssembly,typeof(System.Reflection.AssemblyCopyrightAttribute)) as System.Reflection.AssemblyCopyrightAttribute;

			this.labelProductName.Text = oTiltleAttribute.Title;
			System.Version oVer = oAssembly.GetName().Version;
			this.labelVersion.Text = String.Format("Ver. {0}.{1} (Build: {2})",oVer.Major,oVer.Minor,oVer.Build);

			//Hyper link -. link ITL to www.infbj.com
			linkLabelCopyrights.Text =  oCopyRightAttribute.Copyright;
			string	strITL = "INF Technologies Ltd.";
			int	nLength = strITL.Length;
			if(linkLabelCopyrights.Text.Length>=nLength)
			{
				int	nPos = linkLabelCopyrights.Text.IndexOf(strITL,System.StringComparison.OrdinalIgnoreCase);
				if(nPos>=0)
				{
					linkLabelCopyrights.Links.Add(nPos,nLength,"www.infbj.com");
				}
			}
		}

		//************************************************************************
		//Name: 	OnLinkClicked
		//Author: 	Zheng XM (2012/4/18)
		//Modify:
		//Return:  	
		//Description: show web when clicked the link
		//
		private void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(sender is System.Windows.Forms.LinkLabel)
			{
				System.Windows.Forms.LinkLabel	oLinkLabel = sender as System.Windows.Forms.LinkLabel;
				//此Link被点击过
				oLinkLabel.Links[oLinkLabel.Links.IndexOf(e.Link)].Visited = true;
				if(e.Link.LinkData!=null)
				{
					string	strTarget = e.Link.LinkData as string;
					if(!String.IsNullOrEmpty(strTarget))
					{
						System.Diagnostics.Process.Start(strTarget);
					}
				}
			}
		}
	}
}
