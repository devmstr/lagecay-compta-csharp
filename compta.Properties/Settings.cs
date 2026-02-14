using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace compta.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.ConnectionString)]
	[DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\MyDatabase.mdb")]
	public string NouvelleBase2014ConnectionString => (string)this["NouvelleBase2014ConnectionString"];

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Basic")]
	public string ApplicationSkinName
	{
		get
		{
			return (string)this["ApplicationSkinName"];
		}
		set
		{
			this["ApplicationSkinName"] = value;
		}
	}
}
