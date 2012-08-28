/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry BOUQUET
 * Date: 14/04/2011
 * Heure: 20:38
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace EarthLiveWallpaper
{
	/// <summary>
	/// Form options for the program.
	/// </summary>
	public partial class OptionForm : Form
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
		
		const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x1;
        const int SPIF_SENDWININICHANGE = 0x2;
		
        // Initialize Var and const.
		public string Urlfile;
		public int Delai;
		public string TileWP;
		public string StyleWP;
		public string PosWP;
		public bool launchWin;
		public string launch;
		public string[] XP;
		public string[] VistaSeven;
		public string ScrWidth;
		public int WinVersion = Environment.OSVersion.Version.Major;
		public string ImgLoc = Application.StartupPath + "\\Image\\Wallpaper.bmp";
		public string autolaunch = Application.StartupPath + "\\EarthLiveWallpaper.exe";
		public string Mercator;
		public string MercatorThumb = Application.StartupPath + "\\Miniatures\\Mercator.jpg";
		public string Peters;
		public string PetersThumb = Application.StartupPath + "\\Miniatures\\Peters.jpg";
		public string Mollweide;
		public string MollweideThumb = Application.StartupPath + "\\Miniatures\\Mollweide.jpg";
		public string Rectangular;
		public string RectangularThumb = Application.StartupPath + "\\Miniatures\\Rectangular.jpg";
		
		public OptionForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			GetWidthScreen();
			Urlfile = new Registre().ReadRegUrlfile(Urlfile);// Read Urlfile var from Windows reg
			Delai = new Registre().ReadRegDelai(Delai);// Read Delai var from Windows reg
			launch = new Registre().ReadRegAutolaunch(launch);// Read Autorun var from Windows reg
			TileWP = new Registre().ReadRegTilewp(TileWP); // Read the Tilewallpaper var from Windows reg
			StyleWP = new Registre().ReadRegStylewp(StyleWP); // Read the WallpaperStyle var from Windows reg
			//Call methods.
			InitComboBoxList();
			InitRadioButtons();
			InitNumUpDown();
			InitLaunchChkBox();
			InitTypeWP();
		}
		
		#region Init. form var.
		
		public void InitComboBoxList()// Initialize ComboBox Items for XP or Vista and Seven
		{
			XP = new string[3] {"Etirer", "Centrer", "Mosaique"};
			VistaSeven = new string[5] {"Remplissage", "Ajuster", "Etirer", "Centrer", "Mosaique"};
			
			if (WinVersion == 5) {
				comboBoxPosWP.Items.AddRange(XP);
			}
			else
			{
				comboBoxPosWP.Items.AddRange(VistaSeven);
			}
		}
		
		public void InitRadioButtons() //Method to initialize radiobuttons components
		{
			if (Urlfile == Mercator) {
				radioButtonMercator.Checked = true;
				radioButtonPeters.Checked = false;
				radioButtonMollweide.Checked = false;
				radioButtonRectangular.Checked = false;
				pictureBoxPreview.ImageLocation = MercatorThumb;
				pictureBoxPreview.Load();
				return;
			} 
			if (Urlfile == Peters) {
				radioButtonMercator.Checked = false;
				radioButtonPeters.Checked = true;
				radioButtonMollweide.Checked = false;
				radioButtonRectangular.Checked = false;
				pictureBoxPreview.ImageLocation = PetersThumb;
				pictureBoxPreview.Load();
				return;
			}
			if (Urlfile == Mollweide) {
				radioButtonMercator.Checked = false;
				radioButtonPeters.Checked = false;
				radioButtonMollweide.Checked = true;
				radioButtonRectangular.Checked = false;
				pictureBoxPreview.ImageLocation = MollweideThumb;
				pictureBoxPreview.Load();
				return;
			}
			if (Urlfile == Rectangular) {
				radioButtonMercator.Checked = false;
				radioButtonPeters.Checked = false;
				radioButtonMollweide.Checked = false;
				radioButtonRectangular.Checked = true;
				pictureBoxPreview.ImageLocation = RectangularThumb;
				pictureBoxPreview.Load();
				return;
			}
		}
		
		public void InitNumUpDown()// Method to initialize NumericUpDown component
		{
			numericUpDownChangeWP.Value = Delai;
		}
		
		public void InitLaunchChkBox()// Method to initialize CheckBox component
		{
			if (launch == autolaunch) {
				checkBoxLaunchWin.Checked = true;
			}
			else {
				checkBoxLaunchWin.Checked = false;
			}
		}
		
		public void InitTypeWP()// Method to initialize ComboBox component
		{
			string STWP = StyleWP + "," + TileWP;
			
			switch (STWP) 
			{
				case "10,0":
					comboBoxPosWP.Text = "Remplissage";
					break;
				case "6,0":
					comboBoxPosWP.Text = "Ajuster";
					break;
				case "2,0":
					comboBoxPosWP.Text = "Etirer";
					break;
				case "0,10":
					comboBoxPosWP.Text = "Mosaique";
					break;
				case "0,0":
					comboBoxPosWP.Text = "Centrer";
					break;
			}
		}
		
		public void GetWidthScreen()
		{
			
			// On récupère le périphérique d'affichage principal
			Screen Scr = Screen.PrimaryScreen;
			// On récupère ensuite la hauteur et la largeur
			ScrWidth = Scr.Bounds.Width.ToString();
			
			if (Scr.Bounds.Width > 1600) {
				ScrWidth = "1600";
			}
			//int hauteur = ecran.Bounds.Height;
			Mercator = "http://static.die.net/earth/mercator/"+ ScrWidth +".jpg";
			Peters = "http://static.die.net/earth/peters/"+ ScrWidth +".jpg";
			Mollweide = "http://static.die.net/earth/mollweide/"+ ScrWidth +".jpg";
			Rectangular = "http://static.die.net/earth/rectangular/"+ ScrWidth +".jpg";
			
			switch (Urlfile) {
				case null:
					Urlfile = Mercator;
					break;
				default:
					
					break;
			}
			
		}
		
		#endregion
		

		#region events handler
		void ButtonOFCancelClick(object sender, EventArgs e) //Cancel all user modification on the Option Form
		{
			this.Dispose();
		}
		
		void ButtonOFValidateClick(object sender, EventArgs e)
		{
			new Registre().WriteRegUrlfile(Urlfile);// Write new user Urlfile value into Windows reg
			new Registre().WriteRegDelai(Delai);// Write new user Delai value into Windows reg
			new ChangeWP(PosWP);// Call method to write new user Wallpaper effect into Windows reg
			if (WinVersion == 5) {
				new Registre().WriteRegWallpaperXP(ImgLoc);
			}
			else{
				new Registre().WriteRegWallpaper(ImgLoc);// Write Wallpaper picture location into Windows reg
			}
			new ConnectToNet();//Verify internet connection before launch download
			new ImgWP(); // Refresh Wallpaper
			
			switch (launchWin) {
				case false:
					if (launch != String.Empty) {
						new Registre().DelRegAutolaunch();
					}
					break;
				case true:
					if (launch == String.Empty) {
						new Registre().WriteRegAutolaunch(autolaunch);
					}
					break;
			}
			
			this.Dispose();// Free all OptionForm res.
		}
		
		void RadioButtonMercatorCheckedChanged(object sender, EventArgs e)
		{
			switch (radioButtonMercator.Checked) 
			{
				case true:
					Urlfile = Mercator;
					pictureBoxPreview.ImageLocation = MercatorThumb;
					pictureBoxPreview.Load();
					break;
				default:
					
					break;
			}
		}
		
		void RadioButtonPetersCheckedChanged(object sender, EventArgs e)
		{
			switch (radioButtonPeters.Checked) 
			{
				case true:
					Urlfile = Peters;
					pictureBoxPreview.ImageLocation = PetersThumb;
					pictureBoxPreview.Load();
					break;
				default:
					
					break;
			}
		}
		
		void RadioButtonMollweideCheckedChanged(object sender, EventArgs e)
		{
			switch (radioButtonMollweide.Checked) 
			{
				case true:
					Urlfile = Mollweide;
					pictureBoxPreview.ImageLocation = MollweideThumb;
					pictureBoxPreview.Load();
					break;
				default:
					
					break;
			}
		}
		
		void RadioButtonRectangularCheckedChanged(object sender, EventArgs e)
		{
			switch (radioButtonRectangular.Checked) 
			{
				case true:
					Urlfile = Rectangular;
					pictureBoxPreview.ImageLocation = RectangularThumb;
					pictureBoxPreview.Load();
					break;
				default:
					
					break;
			}
		}
		
		void NumericUpDownChangeWPValueChanged(object sender, EventArgs e)
		{
			Delai = (int)numericUpDownChangeWP.Value;//Récupère la fréquence de rafraichissement.
		}
		
		void ComboBoxPosWPSelectedIndexChanged(object sender, EventArgs e)
		{
			PosWP = comboBoxPosWP.Text;//Récupère le format de l'image à l'écran.
			new ChangeWP(PosWP);
			new ImgWP();
		}
		
		void CheckBoxLaunchWinCheckedChanged(object sender, EventArgs e)
		{
			launchWin = checkBoxLaunchWin.Checked;//Récupère l'état du lancement à l'ouverture de session.
		}
		
		void AProposToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form AboutBox = new AboutBox();
			AboutBox.Show();
		}
		
		void AideToolStripMenuItemClick(object sender, EventArgs e)
		{
			string helpbox = "file://"+ Application.StartupPath+"\\EarthLWP.chm";
			Help.ShowHelp(this, helpbox, HelpNavigator.TableOfContents);
		}
		
		void MisesÀJourToolStripMenuItemClick(object sender, EventArgs e)
		{
			new CheckUpdate();
		}
				
		#endregion
		
	}
}
