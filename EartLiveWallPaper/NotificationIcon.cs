/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry BOUQUET
 * Date: 14/04/2011
 * Heure: 20:35
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace EarthLiveWallpaper
{
	
	public sealed class NotificationIcon
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		
		#region Initialize icon and menu
		public NotificationIcon()
		{
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());
			
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			notifyIcon.ContextMenu = notificationMenu;
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("Refresh now", menuRefreshClick),
                new MenuItem("Options", menuOptionsClick),
                new MenuItem("A Propos", menuAboutClick),
				new MenuItem("Quitter", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
	public class Timer 
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			int DelaiValue = 15;
			DelaiValue = new Registre().ReadRegDelai(DelaiValue);
	 		System.Timers.Timer aTimer = new System.Timers.Timer();//Initialisation du timer
       		aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);// Evenement déclenché par le timer.       		
       		aTimer.Interval = (double) DelaiValue * 60000;// Défini l'interval choisi dans les options..
       		aTimer.Enabled = true;//Démarre le timer
       		       		
			bool isFirstInstance;
			
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "EarthLiveWallpaper", out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Text = "EarthLiveWallpaper";
					notificationIcon.notifyIcon.Visible = true;
					new OptionForm().GetWidthScreen();
					new ConnectToNet();//Verify internet connection before launch download
					new ImgWP(); // Refresh the wallpaper
					//------------------------------------
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					Application.Exit();
				}
			} // releases the Mutex
			
		}
	}
		#endregion
		
		#region Event Handlers
		
		//Ouvre la boite de dialogue "A Propos.."
		private void menuAboutClick(object sender, EventArgs e)
		{
			Form AboutBox = new AboutBox();
			AboutBox.Show();
		}
		
		//Quitte l'application
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		//Ouvre la boite de dialogue des options.
		private void menuOptionsClick(object sender, EventArgs e)
		{
			Form OptionForm = new OptionForm();// Initialize a new options Form
			OptionForm.Show(); // Open a new option form
		}

        //Ouvre la boite de dialogue des options.
        private void menuRefreshClick(object sender, EventArgs e)
        {
            OnTimedEvent(null,null);
        }
		
		public static void OnTimedEvent(object source, ElapsedEventArgs e)//Télécharge le fond d'écran à la périodicité définie
    	{
			new ConnectToNet();//Verify internet connection before launch download
			new ImgWP();// Refresh the wallpaper
    	}
		
		#endregion
	}
}
