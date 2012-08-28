/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry
 * Date: 14/05/2011
 * Heure: 15:59
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Xml;
using System.Windows.Forms;

namespace EarthLiveWallpaper
{
	/// <summary>
	/// Description of CheckUpdate.
	/// </summary>
	public class CheckUpdate
	{
		public CheckUpdate()
		{
			string AppVersion = Application.ProductVersion;
			string NewVersion = null;
			
			XmlTextReader TxtRead = new XmlTextReader("http://sourceforge.net/projects/tbo1374.u/files/EarthLWP/Version.xml");
			
			while (TxtRead.Read()) 
            {
                switch (TxtRead.NodeType)
                {
                    case XmlNodeType.Text: //Display the text in each element.
                		NewVersion = TxtRead.Value.Substring(2,7);
                        break;
                }
			}
			
			switch (AppVersion == NewVersion) {
				case true:
					const string msg = "Votre programme est à jour.";
    				const string caption = "EarthLiveWallpaper";
    				var result = MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
    			default:
					Form UpdateBox = new UpdateBox();
					UpdateBox.Show();
					break;
			}
                
			
		}
	}
}
