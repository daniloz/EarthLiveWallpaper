/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry BOUQUET
 * Date: 16/04/2011
 * Heure: 18:04
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EarthLiveWallpaper
{
	/// <summary>
	/// Description of ChangeWP.
	/// </summary>
	[Serializable]
	public class ChangeWP
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
 
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x1;
        const int SPIF_SENDWININICHANGE = 0x2;
       	string bPath = Application.StartupPath + "\\Image\\Wallpaper.bmp";
        
		public ChangeWP(string PosWP)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
 
            switch( PosWP )
 
            {
 
                case "Remplissage" :
 
                    key.SetValue(@"WallpaperStyle", "10") ;
 
                    key.SetValue(@"TileWallpaper", "0") ;
 
                    break;
            	
            	case "Etirer" :
 
                    key.SetValue(@"WallpaperStyle", "2") ;
 
                    key.SetValue(@"TileWallpaper", "0") ;
 
                    break;
                    
                case "Ajuster" :
 
                    key.SetValue(@"WallpaperStyle", "6") ;
 
                    key.SetValue(@"TileWallpaper", "0") ;
 
                    break;
 
                case "Centrer" :
 
                    key.SetValue(@"WallpaperStyle", "0") ;
 
                    key.SetValue(@"TileWallpaper", "0") ;
 
                    break;
 
                case "Mosaique" :
 
                    key.SetValue(@"WallpaperStyle", "0") ;
 
                    key.SetValue(@"TileWallpaper", "1") ;
 
                    break;
 
            }
 
            key.Close();
            
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0,bPath,SPIF_UPDATEINIFILE);
		}
	}
	
	public class ImgWP
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x1;
        const int SPIF_SENDWININICHANGE = 0x2;
        string bPath = Application.StartupPath + "\\Image\\Wallpaper.bmp";
        
		public ImgWP()
		{
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0,bPath,SPIF_UPDATEINIFILE);
		}
	}
	
}
