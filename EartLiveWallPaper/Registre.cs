/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry BOUQUET
 * Date: 17/04/2011
 * Heure: 22:12
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace EarthLiveWallpaper
{
	/// <summary>
	/// Lecture et écriture dans le registre.
	/// </summary>
	public class Registre
	{
		
	//Registry reading methods.
	//Méthod :
	// 1 - Open Registry Subkey
	// 2 - Read key value and put it into (var)
	// 3 - Close Registry Subkey
		
		public string ReadRegUrlfile (string Urlfile) //Lit la valeur de Urlfile
		{
			RegistryKey EarthLWPUrlfile = Registry.CurrentUser.OpenSubKey("Software\\EarthLWP",true);
			Urlfile = (string) EarthLWPUrlfile.GetValue("Urlfile", "");
			EarthLWPUrlfile.Close();
			return (Urlfile);
		}
		
		public int ReadRegDelai (int Delai) //Lit la valeur de Delai
		{
			RegistryKey EarthLWPDelai = Registry.CurrentUser.OpenSubKey("Software\\EarthLWP",true);
			Delai = (int) EarthLWPDelai.GetValue("Delai", "");
			EarthLWPDelai.Close();
			return (Delai);
		}
		
		public string ReadRegTilewp (string TileWP) //Lit la valeur de TileWallpaper
		{
			RegistryKey EarthWPTilewp = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			TileWP = (string) EarthWPTilewp.GetValue("TileWallpaper", "");
			EarthWPTilewp.Close();
			return (TileWP);
		}
		
		public string ReadRegStylewp (string StyleWP) //Lit la valeur de WallpaperStyle
		{
			RegistryKey EarthWPStylewp = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			StyleWP = (string) EarthWPStylewp.GetValue("WallpaperStyle", "");
			EarthWPStylewp.Close();
			return (StyleWP);
		}
		
		public string ReadRegImgloc (string ImgLoc) //Lit la valeur de ImgLoc
		{
			RegistryKey EarthLWPImgloc = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop",true);
			ImgLoc = (string) EarthLWPImgloc.GetValue("Wallpaper", ""); 
			EarthLWPImgloc.Close();
			return (ImgLoc);
		}
		
		public string ReadRegAutolaunch (string autolaunch) //Lit la clé de lancement automatique au démarrage de la session
		{
			RegistryKey EarthWPLaunch = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			autolaunch = (string) EarthWPLaunch.GetValue("EarthWP", "");
			EarthWPLaunch.Close();
			return (autolaunch);
		}
		
		
	//Registry writing methods.
	//Méthod :
	// 1 - Open Registry Subkey
	// 2 - Write (var) into key value
	// 3 - Close Registry Subkey
		
		public void WriteRegUrlfile (string Urlfile) //Ecrit la valeur de la clé Urlfile
		{
			RegistryKey EarthLWPUrlfile = Registry.CurrentUser.OpenSubKey("Software\\EarthLWP",true);
			EarthLWPUrlfile.SetValue("Urlfile", Urlfile);
			EarthLWPUrlfile.Close();
		}
		
		public void WriteRegDelai (int Delai) //Ecrit la valeur de la clé Delai
		{
			RegistryKey EarthLWPDelai = Registry.CurrentUser.OpenSubKey("Software\\EarthLWP",true);
			EarthLWPDelai.SetValue("Delai", Delai);
			EarthLWPDelai.Close();
		}
		
		public void WriteRegTilewp (string TileWP) //Ecrit la valeur de TileWallpaper
		{
			RegistryKey EarthWPTilewp = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			EarthWPTilewp.SetValue("TileWallpaper", TileWP);
			EarthWPTilewp.Close();
		}
		
		public void WriteRegStylewp (string StyleWP) //Ecrit la valeur de WallpaperStyle
		{
			RegistryKey EarthWPStylewp = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			EarthWPStylewp.SetValue("WallpaperStyle", StyleWP);
			EarthWPStylewp.Close();
		}
		
		public void WriteRegWallpaper (string ImgLoc) //Ecrit la valeur de WallpaperStyle
		{
			RegistryKey EarthWPStylewp = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			EarthWPStylewp.SetValue("Wallpaper", ImgLoc);
			EarthWPStylewp.Close();
		}
		
		public void WriteRegWallpaperXP (string ImgLoc) //Ecrit la valeur de WallpaperStyle
		{
			RegistryKey EarthWPStylewp = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
			EarthWPStylewp.SetValue("Wallpaper", ImgLoc);
			EarthWPStylewp.SetValue("OriginalWallpaper", ImgLoc);
			EarthWPStylewp.Close();
		}
		
		public void WriteRegAutolaunch (string autolaunch) //Ecrit la clé de démarrage automatique du programme
		{
				RegistryKey Launch = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				Launch.SetValue("EarthWP", autolaunch);
				Launch.Close();
		}
		
	//Méthode d'effacement d'une clé de registre
	//Méthode
	// 1 - Ouverture de la SubKey du registre
	// 2 - Effacement la clé du registre
	// 3 - Fermeture de la SubKey du registre
	
		public void DelRegAutolaunch () //Efface la clé de démarrage automatique du programme
		{
				RegistryKey LaunchDel = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				LaunchDel.DeleteValue("EarthWP");
				LaunchDel.Close();
		}
	}
}
