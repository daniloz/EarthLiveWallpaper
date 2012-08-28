/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry
 * Date: 21/05/2011
 * Heure: 09:22
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EarthLiveWallpaper
{
	/// <summary>
	/// Description of UpdateBox.
	/// </summary>
	public partial class UpdateBox : Form
	{
		public UpdateBox()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LinkLabelMajLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
				this.Dispose();
			} catch (Exception) {
				
				throw;
			}
		}
		
		void UpdateBoxLoad(object sender, EventArgs e)
		{
			linkLabelMaj.Text = "Télécharger la nouvelle version.";
    		linkLabelMaj.Links.Add(0, 32, "http://sourceforge.net/projects/tbo1374.u/files/");
		}
		
		void ButtonNotNowClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
