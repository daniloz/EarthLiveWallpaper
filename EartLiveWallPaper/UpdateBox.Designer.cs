/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry
 * Date: 21/05/2011
 * Heure: 09:22
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace EarthLiveWallpaper
{
	partial class UpdateBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBox));
			this.labelPrgName = new System.Windows.Forms.Label();
			this.linkLabelMaj = new System.Windows.Forms.LinkLabel();
			this.labelTxtMaj = new System.Windows.Forms.Label();
			this.buttonNotNow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelPrgName
			// 
			this.labelPrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrgName.Image = ((System.Drawing.Image)(resources.GetObject("labelPrgName.Image")));
			this.labelPrgName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPrgName.Location = new System.Drawing.Point(12, 20);
			this.labelPrgName.Name = "labelPrgName";
			this.labelPrgName.Size = new System.Drawing.Size(290, 23);
			this.labelPrgName.TabIndex = 0;
			this.labelPrgName.Text = "EarthLiveWallPaper";
			this.labelPrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabelMaj
			// 
			this.linkLabelMaj.Location = new System.Drawing.Point(13, 111);
			this.linkLabelMaj.Name = "linkLabelMaj";
			this.linkLabelMaj.Size = new System.Drawing.Size(289, 28);
			this.linkLabelMaj.TabIndex = 1;
			this.linkLabelMaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelMaj.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMajLinkClicked);
			// 
			// labelTxtMaj
			// 
			this.labelTxtMaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTxtMaj.Location = new System.Drawing.Point(12, 60);
			this.labelTxtMaj.Name = "labelTxtMaj";
			this.labelTxtMaj.Size = new System.Drawing.Size(289, 33);
			this.labelTxtMaj.TabIndex = 2;
			this.labelTxtMaj.Text = "Une mise à jour est disponible :";
			this.labelTxtMaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonNotNow
			// 
			this.buttonNotNow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonNotNow.Location = new System.Drawing.Point(193, 172);
			this.buttonNotNow.Name = "buttonNotNow";
			this.buttonNotNow.Size = new System.Drawing.Size(108, 23);
			this.buttonNotNow.TabIndex = 3;
			this.buttonNotNow.Text = "Pas maintenant";
			this.buttonNotNow.UseVisualStyleBackColor = true;
			this.buttonNotNow.Click += new System.EventHandler(this.ButtonNotNowClick);
			// 
			// UpdateBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonNotNow;
			this.ClientSize = new System.Drawing.Size(314, 207);
			this.Controls.Add(this.buttonNotNow);
			this.Controls.Add(this.labelTxtMaj);
			this.Controls.Add(this.linkLabelMaj);
			this.Controls.Add(this.labelPrgName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdateBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mise à jour";
			this.Load += new System.EventHandler(this.UpdateBoxLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonNotNow;
		private System.Windows.Forms.Label labelPrgName;
		private System.Windows.Forms.Label labelTxtMaj;
		private System.Windows.Forms.LinkLabel linkLabelMaj;
	}
}
