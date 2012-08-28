/*
 * Crée par SharpDevelop.
 * Utilisateur: Thierry
 * Date: 15/04/2011
 * Heure: 06:51
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace EarthLiveWallpaper
{
	partial class AboutBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			this.buttonABOk = new System.Windows.Forms.Button();
			this.labelPrgName = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelDevName = new System.Windows.Forms.Label();
			this.labelTextDon = new System.Windows.Forms.Label();
			this.linkLabelFF = new System.Windows.Forms.LinkLabel();
			this.linkLabelAbsl = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// buttonABOk
			// 
			this.buttonABOk.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonABOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonABOk.Location = new System.Drawing.Point(0, 200);
			this.buttonABOk.Name = "buttonABOk";
			this.buttonABOk.Size = new System.Drawing.Size(333, 23);
			this.buttonABOk.TabIndex = 0;
			this.buttonABOk.Text = "Ok";
			this.buttonABOk.UseVisualStyleBackColor = true;
			this.buttonABOk.Click += new System.EventHandler(this.ButtonABOkClick);
			// 
			// labelPrgName
			// 
			this.labelPrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrgName.Image = ((System.Drawing.Image)(resources.GetObject("labelPrgName.Image")));
			this.labelPrgName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPrgName.Location = new System.Drawing.Point(0, 9);
			this.labelPrgName.Name = "labelPrgName";
			this.labelPrgName.Size = new System.Drawing.Size(333, 23);
			this.labelPrgName.TabIndex = 1;
			this.labelPrgName.Text = "Earth Live Wallpaper";
			this.labelPrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCopyright
			// 
			this.labelCopyright.Location = new System.Drawing.Point(0, 39);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(333, 23);
			this.labelCopyright.TabIndex = 2;
			this.labelCopyright.Text = "© 2011 - License GPL";
			this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDevName
			// 
			this.labelDevName.Location = new System.Drawing.Point(0, 69);
			this.labelDevName.Name = "labelDevName";
			this.labelDevName.Size = new System.Drawing.Size(333, 23);
			this.labelDevName.TabIndex = 3;
			this.labelDevName.Text = "Thierry BOUQUET - tbo1374@gmail.com";
			this.labelDevName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTextDon
			// 
			this.labelTextDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTextDon.Location = new System.Drawing.Point(0, 98);
			this.labelTextDon.Name = "labelTextDon";
			this.labelTextDon.Size = new System.Drawing.Size(333, 41);
			this.labelTextDon.TabIndex = 4;
			this.labelTextDon.Text = "Si vous aimez ce programme, merci de faire un don\r\nà une de ces deux associations" +
			", ou aux deux ;-) :";
			this.labelTextDon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// linkLabelFF
			// 
			this.linkLabelFF.Location = new System.Drawing.Point(0, 168);
			this.linkLabelFF.Name = "linkLabelFF";
			this.linkLabelFF.Size = new System.Drawing.Size(333, 13);
			this.linkLabelFF.TabIndex = 6;
			this.linkLabelFF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelFF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelFFLinkClicked);
			// 
			// linkLabelAbsl
			// 
			this.linkLabelAbsl.Location = new System.Drawing.Point(0, 139);
			this.linkLabelAbsl.Name = "linkLabelAbsl";
			this.linkLabelAbsl.Size = new System.Drawing.Size(333, 23);
			this.linkLabelAbsl.TabIndex = 5;
			this.linkLabelAbsl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelAbsl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAbslLinkClicked);
			// 
			// AboutBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 223);
			this.Controls.Add(this.linkLabelAbsl);
			this.Controls.Add(this.linkLabelFF);
			this.Controls.Add(this.labelTextDon);
			this.Controls.Add(this.labelDevName);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.labelPrgName);
			this.Controls.Add(this.buttonABOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "A propos...";
			this.Load += new System.EventHandler(this.AboutBoxLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel linkLabelFF;
		private System.Windows.Forms.Label labelPrgName;
		private System.Windows.Forms.Label labelDevName;
		private System.Windows.Forms.Label labelTextDon;
		private System.Windows.Forms.LinkLabel linkLabelAbsl;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Button buttonABOk;
	}
}
