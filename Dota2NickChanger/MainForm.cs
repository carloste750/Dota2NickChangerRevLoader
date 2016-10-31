/*
 * Created by SharpDevelop.
 * User: CarlosJones
 * Date: 30/10/2016
 * Time: 21:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dota2NickChanger
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Core core;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Inicializar();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void Inicializar(){
			core =new Core();
		}
		public bool IsVerified(){
			if(string.IsNullOrEmpty(txtNick.Text)){
				errorProv.SetError(txtNick,"Debes Poner Algo");
				return false;
			}
			return true;
		}
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(IsVerified()){
				try{
					core.WriteOnRevIni(txtNick.Text);
					Application.Exit();
				} catch(Exception E){
					MessageBox.Show("No Pudimos Actualizar tu Nombre","	ERROR");
					throw new Exception(E.Message);
				}
			}
			
			
		}
		void BtnCharmapClick(object sender, EventArgs e)
		{
			core.RunCommand("charmap","");
		}
		void BtnAboutClick(object sender, EventArgs e)
		{
			new About().ShowDialog();
		}
	}
}
