/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry BOUQUET
 * Date: 15/04/2011
 * Heure: 08:10
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace EarthLiveWallpaper
{
	/// <summary>
	/// Télécharge l'image choisie dans les options.
	/// </summary>
	public class Download
	{
		
		string Urlfile = "";
		string ImgLoc = "";
		
		public Download()
		{
			
			Urlfile = new Registre().ReadRegUrlfile(Urlfile);
			ImgLoc = new Registre().ReadRegImgloc(ImgLoc);
			
			try
			{
				WebClient wc = new WebClient();// Création d'un objet WebClient (c'est lui qui permet de télécharger un fichier)
				wc.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)" + " (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";// Détermine le User-Agent du WebClient.
				wc.DownloadFile(Urlfile, Application.StartupPath + "\\Temp\\TempWPImg.jpg");// Lancement du téléchargement / argument 1 : url du fichier source / argument 2 : l'emplacement ou enregistrer le fichier sur le disque dur
				wc.Dispose();//Destruction de l'objet WebClient

#if DEBUG
                int Hour = 8;
                int Minute = 0;
                if ((DateTime.Now.Hour == Hour) && ((DateTime.Now.Minute >= Minute) && (DateTime.Now.Minute <= Minute+21)))
                {
                    System.IO.File.Copy(Application.StartupPath + "\\Temp\\TempWPImg.jpg",
                        Application.StartupPath + @"\SavedImages\Projection\" + DateTime.Now.ToString("yyyy_MM_dd") + String.Format("_{0:D2}_{1:D2}.jpg",Hour,Minute));
                    
                    // Download hemisphere view
                    wc = new WebClient(); // Création d'un objet WebClient (c'est lui qui permet de télécharger un fichier)
                    wc.Headers["User-Agent"] = "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)" + " (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";// Détermine le User-Agent du WebClient.
                    wc.DownloadFile(@"http://static.die.net/earth/hemisphere/1600.jpg",
                        Application.StartupPath + @"\SavedImages\Hemisphere\" + DateTime.Now.ToString("yyyy_MM_dd") + String.Format("_{0:D2}_{1:D2}.jpg", Hour, Minute));
                        // Lancement du téléchargement / argument 1 : url du fichier source / argument 2 : l'emplacement ou enregistrer le fichier sur le disque dur
                    wc.Dispose();//Destruction de l'objet WebClient
                }
#endif

				using(Image img = Image.FromFile(Application.StartupPath + "\\Temp\\TempWPImg.jpg"))
				{
                    Graphics g = Graphics.FromImage(img);
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    StringFormat strFormat = new StringFormat();
                    strFormat.Alignment = StringAlignment.Far;
                    strFormat.LineAlignment = StringAlignment.Far;
                    g.DrawString("Last update: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(), new Font("Calibri", 24, FontStyle.Regular), Brushes.Red, new Rectangle(0, 0, img.Width-100, img.Height-5), strFormat);
                    
					img.Save(Application.StartupPath + "\\Image\\Wallpaper.bmp", ImageFormat.Bmp);
                    g.Dispose();
				}
#if DEBUG
                StreamWriter log = File.AppendText(Application.StartupPath + "\\Temp\\log.txt");
                log.WriteLine(DateTime.Now.ToString());
                log.Close();
#endif

                //File.Delete(Application.StartupPath + "\\Temp\\TempWPImg.jpg");
			}
			
			catch(Exception)// Interception des erreurs.
			{
				throw;
			}
		return;
		}
	}
}
