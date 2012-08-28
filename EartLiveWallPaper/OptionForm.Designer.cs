/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry
 * Date: 14/04/2011
 * Heure: 20:38
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace EarthLiveWallpaper
{
	partial class OptionForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
			this.labelChoice = new System.Windows.Forms.Label();
			this.groupBoxSelect = new System.Windows.Forms.GroupBox();
			this.radioButtonRectangular = new System.Windows.Forms.RadioButton();
			this.radioButtonMollweide = new System.Windows.Forms.RadioButton();
			this.radioButtonPeters = new System.Windows.Forms.RadioButton();
			this.radioButtonMercator = new System.Windows.Forms.RadioButton();
			this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
			this.buttonOFValidate = new System.Windows.Forms.Button();
			this.buttonOFCancel = new System.Windows.Forms.Button();
			this.comboBoxPosWP = new System.Windows.Forms.ComboBox();
			this.labelPosWP = new System.Windows.Forms.Label();
			this.labelChangeWP = new System.Windows.Forms.Label();
			this.numericUpDownChangeWP = new System.Windows.Forms.NumericUpDown();
			this.checkBoxLaunchWin = new System.Windows.Forms.CheckBox();
			this.menuStripOption = new System.Windows.Forms.MenuStrip();
			this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.misesÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxSelect.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeWP)).BeginInit();
			this.menuStripOption.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelChoice
			// 
			resources.ApplyResources(this.labelChoice, "labelChoice");
			this.labelChoice.Name = "labelChoice";
			// 
			// groupBoxSelect
			// 
			this.groupBoxSelect.Controls.Add(this.radioButtonRectangular);
			this.groupBoxSelect.Controls.Add(this.radioButtonMollweide);
			this.groupBoxSelect.Controls.Add(this.radioButtonPeters);
			this.groupBoxSelect.Controls.Add(this.radioButtonMercator);
			resources.ApplyResources(this.groupBoxSelect, "groupBoxSelect");
			this.groupBoxSelect.Name = "groupBoxSelect";
			this.groupBoxSelect.TabStop = false;
			// 
			// radioButtonRectangular
			// 
			resources.ApplyResources(this.radioButtonRectangular, "radioButtonRectangular");
			this.radioButtonRectangular.Name = "radioButtonRectangular";
			this.radioButtonRectangular.TabStop = true;
			this.radioButtonRectangular.Tag = "Sélectionne une représentation de type Equirectangular";
			this.radioButtonRectangular.UseVisualStyleBackColor = true;
			this.radioButtonRectangular.CheckedChanged += new System.EventHandler(this.RadioButtonRectangularCheckedChanged);
			// 
			// radioButtonMollweide
			// 
			resources.ApplyResources(this.radioButtonMollweide, "radioButtonMollweide");
			this.radioButtonMollweide.Name = "radioButtonMollweide";
			this.radioButtonMollweide.TabStop = true;
			this.radioButtonMollweide.Tag = "Sélectionne une représentation de type Mollweide";
			this.radioButtonMollweide.UseVisualStyleBackColor = true;
			this.radioButtonMollweide.CheckedChanged += new System.EventHandler(this.RadioButtonMollweideCheckedChanged);
			// 
			// radioButtonPeters
			// 
			resources.ApplyResources(this.radioButtonPeters, "radioButtonPeters");
			this.radioButtonPeters.Name = "radioButtonPeters";
			this.radioButtonPeters.TabStop = true;
			this.radioButtonPeters.Tag = "Sélectionne une représentation de type Peters";
			this.radioButtonPeters.UseVisualStyleBackColor = true;
			this.radioButtonPeters.CheckedChanged += new System.EventHandler(this.RadioButtonPetersCheckedChanged);
			// 
			// radioButtonMercator
			// 
			resources.ApplyResources(this.radioButtonMercator, "radioButtonMercator");
			this.radioButtonMercator.Name = "radioButtonMercator";
			this.radioButtonMercator.TabStop = true;
			this.radioButtonMercator.Tag = "Sélectionne une représentation de type Mercator";
			this.radioButtonMercator.UseVisualStyleBackColor = true;
			this.radioButtonMercator.CheckedChanged += new System.EventHandler(this.RadioButtonMercatorCheckedChanged);
			// 
			// pictureBoxPreview
			// 
			resources.ApplyResources(this.pictureBoxPreview, "pictureBoxPreview");
			this.pictureBoxPreview.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBoxPreview.Name = "pictureBoxPreview";
			this.pictureBoxPreview.TabStop = false;
			this.pictureBoxPreview.Tag = "Prévisualisation du type d\'image et de son positionnement approximatif à l\'écran";
			// 
			// buttonOFValidate
			// 
			resources.ApplyResources(this.buttonOFValidate, "buttonOFValidate");
			this.buttonOFValidate.Name = "buttonOFValidate";
			this.buttonOFValidate.Tag = "Valide et active toutes les modifications";
			this.buttonOFValidate.UseVisualStyleBackColor = true;
			this.buttonOFValidate.Click += new System.EventHandler(this.ButtonOFValidateClick);
			// 
			// buttonOFCancel
			// 
			this.buttonOFCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.buttonOFCancel, "buttonOFCancel");
			this.buttonOFCancel.Name = "buttonOFCancel";
			this.buttonOFCancel.Tag = "Annule toutes les modifications";
			this.buttonOFCancel.UseVisualStyleBackColor = true;
			this.buttonOFCancel.Click += new System.EventHandler(this.ButtonOFCancelClick);
			// 
			// comboBoxPosWP
			// 
			this.comboBoxPosWP.FormattingEnabled = true;
			resources.ApplyResources(this.comboBoxPosWP, "comboBoxPosWP");
			this.comboBoxPosWP.Name = "comboBoxPosWP";
			this.comboBoxPosWP.Tag = "Façon dont l\'image sera affichée à l\'écran";
			this.comboBoxPosWP.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPosWPSelectedIndexChanged);
			// 
			// labelPosWP
			// 
			resources.ApplyResources(this.labelPosWP, "labelPosWP");
			this.labelPosWP.Name = "labelPosWP";
			// 
			// labelChangeWP
			// 
			resources.ApplyResources(this.labelChangeWP, "labelChangeWP");
			this.labelChangeWP.Name = "labelChangeWP";
			// 
			// numericUpDownChangeWP
			// 
			resources.ApplyResources(this.numericUpDownChangeWP, "numericUpDownChangeWP");
			this.numericUpDownChangeWP.Maximum = new decimal(new int[] {
									180,
									0,
									0,
									0});
			this.numericUpDownChangeWP.Minimum = new decimal(new int[] {
									10,
									0,
									0,
									0});
			this.numericUpDownChangeWP.Name = "numericUpDownChangeWP";
			this.numericUpDownChangeWP.Tag = "Délai entre deux mises à jour de l\'image à l\'écran (entre 10 et 180 mn)";
			this.numericUpDownChangeWP.Value = new decimal(new int[] {
									15,
									0,
									0,
									0});
			this.numericUpDownChangeWP.ValueChanged += new System.EventHandler(this.NumericUpDownChangeWPValueChanged);
			// 
			// checkBoxLaunchWin
			// 
			this.checkBoxLaunchWin.CausesValidation = false;
			resources.ApplyResources(this.checkBoxLaunchWin, "checkBoxLaunchWin");
			this.checkBoxLaunchWin.Name = "checkBoxLaunchWin";
			this.checkBoxLaunchWin.Tag = "Si coché, l\'application sera lancée automatiquement au démarrage de la session";
			this.checkBoxLaunchWin.UseVisualStyleBackColor = true;
			this.checkBoxLaunchWin.CheckedChanged += new System.EventHandler(this.CheckBoxLaunchWinCheckedChanged);
			// 
			// menuStripOption
			// 
			this.menuStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aideToolStripMenuItem,
									this.aProposToolStripMenuItem,
									this.misesÀJourToolStripMenuItem});
			resources.ApplyResources(this.menuStripOption, "menuStripOption");
			this.menuStripOption.Name = "menuStripOption";
			// 
			// aideToolStripMenuItem
			// 
			resources.ApplyResources(this.aideToolStripMenuItem, "aideToolStripMenuItem");
			this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
			this.aideToolStripMenuItem.Click += new System.EventHandler(this.AideToolStripMenuItemClick);
			// 
			// aProposToolStripMenuItem
			// 
			this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
			resources.ApplyResources(this.aProposToolStripMenuItem, "aProposToolStripMenuItem");
			this.aProposToolStripMenuItem.Click += new System.EventHandler(this.AProposToolStripMenuItemClick);
			// 
			// misesÀJourToolStripMenuItem
			// 
			this.misesÀJourToolStripMenuItem.Name = "misesÀJourToolStripMenuItem";
			resources.ApplyResources(this.misesÀJourToolStripMenuItem, "misesÀJourToolStripMenuItem");
			this.misesÀJourToolStripMenuItem.Click += new System.EventHandler(this.MisesÀJourToolStripMenuItemClick);
			// 
			// OptionForm
			// 
			this.AcceptButton = this.buttonOFValidate;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonOFCancel;
			this.Controls.Add(this.checkBoxLaunchWin);
			this.Controls.Add(this.numericUpDownChangeWP);
			this.Controls.Add(this.labelChangeWP);
			this.Controls.Add(this.labelPosWP);
			this.Controls.Add(this.comboBoxPosWP);
			this.Controls.Add(this.buttonOFCancel);
			this.Controls.Add(this.buttonOFValidate);
			this.Controls.Add(this.pictureBoxPreview);
			this.Controls.Add(this.groupBoxSelect);
			this.Controls.Add(this.labelChoice);
			this.Controls.Add(this.menuStripOption);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStripOption;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionForm";
			this.groupBoxSelect.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownChangeWP)).EndInit();
			this.menuStripOption.ResumeLayout(false);
			this.menuStripOption.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem misesÀJourToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStripOption;
		private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
		public System.Windows.Forms.RadioButton radioButtonMollweide;
		public System.Windows.Forms.GroupBox groupBoxSelect;
		public System.Windows.Forms.CheckBox checkBoxLaunchWin;
		private System.Windows.Forms.Button buttonOFValidate;
		private System.Windows.Forms.Button buttonOFCancel;
		private System.Windows.Forms.Label labelChoice;
		public System.Windows.Forms.NumericUpDown numericUpDownChangeWP;
		private System.Windows.Forms.Label labelChangeWP;
		private System.Windows.Forms.Label labelPosWP;
		public System.Windows.Forms.ComboBox comboBoxPosWP;
		public System.Windows.Forms.RadioButton radioButtonRectangular;
		public System.Windows.Forms.RadioButton radioButtonPeters;
		private System.Windows.Forms.PictureBox pictureBoxPreview;
		public System.Windows.Forms.RadioButton radioButtonMercator;
	}
}
