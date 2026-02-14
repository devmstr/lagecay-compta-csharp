using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Management;
using System.Runtime;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using compta.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using IntelliLock.Licensing;

namespace compta;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		if (ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.IsFirstRun)
		{
			string appPath = Application.StartupPath;
			string winPath = Environment.GetEnvironmentVariable("WINDIR");
			Process process = new Process();
			Directory.SetCurrentDirectory(appPath);
			process.EnableRaisingEvents = false;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = winPath + "\\Microsoft.NET\\Framework\\v2.0.50727\\ngen.exe";
			process.StartInfo.Arguments = "uninstall " + Application.ProductName + "  /nologo /silent";
			process.Start();
			process.WaitForExit();
			process.StartInfo.FileName = winPath + "\\Microsoft.NET\\Framework\\v2.0.50727\\ngen.exe";
			process.StartInfo.Arguments = "install " + Application.ProductName + "  /nologo /silent";
			process.Start();
			process.WaitForExit();
		}
		ProfileOptimization.SetProfileRoot(AppDomain.CurrentDomain.BaseDirectory);
		ProfileOptimization.StartProfile("Profile");
		WindowsFormsSettings.LoadApplicationSettings();
		if (SystemInformation.TerminalServerSession)
		{
			SkinManager.DisableFormSkins();
			SkinManager.DisableMdiFormSkins();
			Application.VisualStyleState = VisualStyleState.NoneEnabled;
			UserLookAndFeel.Default.UseWindowsXPTheme = false;
			UserLookAndFeel.Default.Style = LookAndFeelStyle.Flat;
			WindowsFormsSettings.AnimationMode = AnimationMode.DisableAll;
			WindowsFormsSettings.AllowHoverAnimation = DefaultBoolean.False;
			BarAndDockingController.Default.PropertiesBar.MenuAnimationType = AnimationType.None;
			BarAndDockingController.Default.PropertiesBar.SubmenuHasShadow = false;
			BarAndDockingController.Default.PropertiesBar.AllowLinkLighting = false;
		}
		Application.Run(new FrmPrincipale());
	}

	private static bool isVirtualMachine()
	{
		foreach (ManagementBaseObject item in new ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
		{
			string manufacturer = item["Manufacturer"].ToString().ToLower();
			if (manufacturer.Contains("microsoft corporation") || manufacturer.Contains("vmware"))
			{
				return true;
			}
			if (item["Model"] != null)
			{
				string model = item["Model"].ToString().ToLower();
				if (model.Contains("microsoft corporation") || model.Contains("vmware") || model.Contains("virtualbox"))
				{
					return true;
				}
			}
		}
		return false;
	}

	private static void ReadAdditonalLicenseInformation()
	{
		if (isVirtualMachine())
		{
			Application.Exit();
		}
		if (IsValidLicenseAvailable() && EvaluationMonitor.CurrentLicense.ExpirationDate_Enabled)
		{
			DateTime expiration_date = EvaluationMonitor.CurrentLicense.ExpirationDate;
			if (DateTime.Today.AddDays(15.0) > expiration_date)
			{
				monModule.gRestart = false;
				string msg = "Votre licence expire le " + expiration_date.ToShortDateString() + "\n Saisissez le chemin de la nouvelle licence";
				frmRegister obj = new frmRegister(HardwareID.GetHardwareID(CPU: true, HDD: true, MAC: false, Mainboard: true, BIOS: true, OS: false), msg);
				Application.Run(obj);
				obj.Dispose();
				if (monModule.gRestart)
				{
					Application.Restart();
				}
			}
		}
		if (!IsValidLicenseAvailable())
		{
			monModule.gRestart = false;
			frmRegister obj2 = new frmRegister(HardwareID.GetHardwareID(CPU: true, HDD: true, MAC: false, Mainboard: true, BIOS: true, OS: false), "Licence expirée");
			Application.Run(obj2);
			obj2.Dispose();
			if (monModule.gRestart)
			{
				Application.Restart();
			}
			else
			{
				Application.Exit();
			}
			return;
		}
		ProfileOptimization.SetProfileRoot(AppDomain.CurrentDomain.BaseDirectory);
		ProfileOptimization.StartProfile("Profile");
		WindowsFormsSettings.LoadApplicationSettings();
		CultureInfo culture = CultureInfo.CreateSpecificCulture("fr");
		Thread.CurrentThread.CurrentUICulture = culture;
		Thread.CurrentThread.CurrentCulture = culture;
		CultureInfo.DefaultThreadCurrentCulture = culture;
		CultureInfo.DefaultThreadCurrentUICulture = culture;
		Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
		WindowsFormsSettings.AnimationMode = AnimationMode.DisableAll;
		WindowsFormsSettings.AllowHoverAnimation = DefaultBoolean.False;
		BonusSkins.Register();
		SkinManager.EnableFormSkins();
		SkinManager.EnableMdiFormSkins();
		SkinManager.EnableFormSkins();
		Application.EnableVisualStyles();
		SkinManager.EnableFormSkins();
		UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
		Application.Run(new FrmPrincipale());
	}

	private static bool IsValidLicenseAvailable()
	{
		return EvaluationMonitor.CurrentLicense.LicenseStatus == LicenseStatus.Licensed;
	}

	private static void CheckNumberOfInstancesLock()
	{
		_ = EvaluationMonitor.CurrentLicense.Instances_Enabled;
		_ = EvaluationMonitor.CurrentLicense.Instances;
	}
}
