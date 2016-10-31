/*
 * Created by SharpDevelop.
 * User: CarlosJones
 * Date: 30/10/2016
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
namespace Dota2NickChanger
{
	/// <summary>
	/// Description of Core.
	/// </summary>
	public class Core
	{
		public String nArchivo = "rev.ini";
		public String revPath;
		public String confText = @"[Loader]
ProcName=dota2.exe -console -steam -silent -condebug /help
[Emulator]
CacheEnabled = false
CachePath = D:\Steam\SteamApps
Language = Spanish
Logging=false
SteamDll=.\Steam\Steam2.dll
SteamClient = True
SteamUser = SteamPlayer
[Log]
FileSystem=False
Account=False
UserID=False
[steamclient]
PlayerName= {0}
Logging=true
#MasterServer = 208.64.200.52:27011
ClanTag=[revcrew]
Use_avatar = true
[GameServer]
AllowOldRev74=False
AllowOldRev=False
AllowUnknown=False
Fake_player= false
RevEmu_2012 = false
AddCountPlayerInServerName = false
[GameServerNSNet]
EnableNSNetSvc = UDP
ServerIPNSNet = 127.0.0.1";
		
		public Core()
		{
			revPath=ConfigurationSettings.AppSettings["path"];
		}
		public void WriteOnRevIni(String Nickname)
		{
			String ruta = revPath + @"\"+nArchivo;
			Debug.Write(ruta);
			File.WriteAllText(ruta, "");
			File.WriteAllText(ruta, string.Format(confText,Nickname));
		}
		
		public bool RunCommand(String ejecutableName,String command)
		{
			string result=String.Empty;
			try {

				ProcessStartInfo procStartInfo = new ProcessStartInfo(ejecutableName,command);
				Debug.Write("+");
				Debug.Write(command);
				Debug.Write("+");
				procStartInfo.RedirectStandardOutput = true;
				procStartInfo.UseShellExecute = false;
				procStartInfo.CreateNoWindow = true;
				Process proc = new Process();
				proc.StartInfo = procStartInfo;
				proc.Start();
				result = proc.StandardOutput.ReadToEnd();
				Console.WriteLine(result);
			} catch (Exception objException) {
				return false;
			}
			return true;
		}
	}
}
