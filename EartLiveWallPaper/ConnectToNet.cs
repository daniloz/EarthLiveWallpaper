/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry BOUQUET
 * Date: 21/04/2011
 * Heure: 18:38
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EarthLiveWallpaper
{
	/// <summary>
	/// Description of ConnectToNet.
	/// </summary>
	public class ConnectToNet
	{
    	//Creating the extern function…
    	[DllImport("wininet.dll", CharSet = CharSet.Auto)]
		public static extern bool InternetGetConnectedState(ref uint connected, uint reserved);
		
		public uint Desc;
		
			public ConnectToNet()
			{
				InternetGetConnectedState( ref Desc, 0);// Check if internet connection exists.
				
					switch (Desc) 
					{
						case 16:
							
							break;
							
						case 32:
							
							break;
							
						default:
								try {
								//Ping pingSender = new Ping ();
            					//PingReply reply = pingSender.Send ("static.die.net");
            					//System.Threading.Thread.Sleep(3000);
            					//if (reply.Status == IPStatus.Success)
            					{
                					new Download();// Launch the download from internet
            					}
								} catch (Exception) {
								
								    //const string msg = "Pas de connection ou le site est indisponible";
    							    //const string caption = "EarthLiveWallpaper";
    							    //var result = MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							break;
					}
			}
	}

}