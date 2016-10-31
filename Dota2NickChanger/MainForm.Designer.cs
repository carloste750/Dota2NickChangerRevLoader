/*
 * Created by SharpDevelop.
 * User: CarlosJones
 * Date: 30/10/2016
 * Time: 21:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dota2NickChanger
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtNick;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCharmap;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.ErrorProvider errorProv;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtNick = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCharmap = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNick
			// 
			this.txtNick.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtNick.Font = new System.Drawing.Font("Tahoma", 12.10619F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNick.Location = new System.Drawing.Point(167, 85);
			this.txtNick.MaxLength = 12;
			this.txtNick.Name = "txtNick";
			this.txtNick.Size = new System.Drawing.Size(229, 30);
			this.txtNick.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(167, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "NickName";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
			this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGuardar.Location = new System.Drawing.Point(167, 116);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(229, 50);
			this.btnGuardar.TabIndex = 2;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnCharmap
			// 
			this.btnCharmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCharmap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCharmap.Location = new System.Drawing.Point(406, 188);
			this.btnCharmap.Name = "btnCharmap";
			this.btnCharmap.Size = new System.Drawing.Size(75, 37);
			this.btnCharmap.TabIndex = 3;
			this.btnCharmap.Text = "Charmap";
			this.btnCharmap.UseVisualStyleBackColor = true;
			this.btnCharmap.Click += new System.EventHandler(this.BtnCharmapClick);
			// 
			// btnAbout
			// 
			this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAbout.BackColor = System.Drawing.Color.DarkOrange;
			this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbout.Location = new System.Drawing.Point(487, 188);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(52, 37);
			this.btnAbout.TabIndex = 4;
			this.btnAbout.Text = "?";
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
			// 
			// errorProv
			// 
			this.errorProv.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(551, 237);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnCharmap);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNick);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(569, 282);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambiar Nombre de Dota 2";
			((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
