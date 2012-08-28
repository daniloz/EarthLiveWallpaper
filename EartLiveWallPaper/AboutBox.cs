/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry BOUQUET
 * Date: 15/04/2011
 * Heure: 06:51
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
	/// Description of AboutBox.
	/// </summary>
	public partial class AboutBox : Form
	{
		public AboutBox()
		{
			InitializeComponent();
		}
		
		void ButtonABOkClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void LinkLabelAbslLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
				this.Dispose();
			} catch (Exception) {
				
				throw;
			}
		}
		
		void LinkLabelFFLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try {
				System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
				this.Dispose();
			} catch (Exception) {
				
				throw;
			}
		}
		
		void AboutBoxLoad(object sender, EventArgs e)
		{
			linkLabelAbsl.Text = "L'Asbl Fibro'Aide";
    		linkLabelAbsl.Links.Add(0, 18, "www.lafibromyalgie.be/Donation.html");
			
			linkLabelFF.Text = "Fibromyalgie France";
    		linkLabelFF.Links.Add(0, 19, "www.fibromyalgie-france.org/?ADHERER_-_FAIRE_UN_DON");
			
		}
	}
}
