using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using compta.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Functions;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSpreadsheet;

namespace compta;

public class FrmPrincipale : XtraForm
{
	private IContainer components;

	private BarManager barManager1;

	private Bar bar2;

	private BarSubItem barFichiers;

	private BarButtonItem barCompacter;

	private BarButtonItem barOuvrir;

	private BarButtonItem barEnregisterSous;

	private BarButtonItem barCloturer;

	private BarButtonItem barQuitter;

	private BarSubItem barTables;

	private BarButtonItem barDossiers;

	private BarButtonItem barJournaux;

	private BarButtonItem barPlanComptable;

	private BarButtonItem barPieces;

	private BarButtonItem barTiers;

	private BarButtonItem barInvestissements;

	private BarButtonItem barVilles;

	private BarSubItem barTraitements;

	private BarButtonItem barEcrituresBord;

	private BarButtonItem barImporterEcritures;

	private BarButtonItem barChangerDossier;

	private BarButtonItem barAmortissement;

	private BarButtonItem barPointageEcritures;

	private BarButtonItem barRapprochement;

	private BarSubItem barEditions;

	private BarButtonItem barEdJournaux;

	private BarButtonItem barEdJournalOuverture;

	private BarButtonItem barEdGrandLivre;

	private BarButtonItem barEdCentralisation;

	private BarButtonItem barEdBalanceSoldes;

	private BarButtonItem barEdBalanceGenerale;

	private BarButtonItem barEdBalanceComptes;

	private BarButtonItem barEdHistoriqueCompte;

	private BarButtonItem barEdRecapAchatsVentes;

	private BarButtonItem barEdEtatClient;

	private BarButtonItem barEdBilan;

	private BarButtonItem barEdDiversEtats;

	private Bar bar3;

	private BarDockControl barDockControlTop;

	private BarDockControl barDockControlBottom;

	private BarDockControl barDockControlLeft;

	private BarDockControl barDockControlRight;

	private BarLinkContainerItem barLinkContainerItem1;

	private SkinBarSubItem skinBarSubItem1;

	private Bar bar1;

	private BarButtonItem barButtonItem1;

	private SharedImageCollection sharedImageCollection1;

	private BarButtonItem barButtonItem2;

	private BarLargeButtonItem barLargeEcrPiece;

	private BarLargeButtonItem barLargeButtonItem2;

	private BarLargeButtonItem barLargeButtonItem3;

	private BarLargeButtonItem barLargeButtonItem4;

	private BarLargeButtonItem barLargeButtonItem5;

	private BarLargeButtonItem barLargeButtonItem6;

	private BarLargeButtonItem barLargeButtonItem7;

	private BarLargeButtonItem barLargeButtonItem8;

	private BarLargeButtonItem barLargeButtonItem9;

	private BarButtonItem barButtonItem3;

	private BarButtonItem barButtonItem4;

	private BarButtonItem barButtonItem5;

	private BarHeaderItem titre;

	private BarLargeButtonItem barLargeButtonItem10;

	private BarButtonItem barExporterDossier;

	private BarLargeButtonItem barLargeBilanExcel;

	private BarStaticItem barDOS;

	private BarLargeButtonItem barLargeEcrBordereau;

	private BarButtonItem barEcrituresPCS;

	private BarLargeButtonItem barSubItem3;
	private PopupMenu popupEcritures;

	private BarLargeButtonItem barSubItem1;
	private PopupMenu popupBalance;

	private BarLargeButtonItem barSubItem2;
	private PopupMenu popupExcel;

	private BehaviorManager behaviorManager1;

	private BarLargeButtonItem barLargeButtonItem1;

	private BarButtonItem barButtonItem6;

	private BarLargeButtonItem barSubItem4;
	private PopupMenu popupBilans;

	private BarLargeButtonItem barLargeButtonItem11;

	private BarLargeButtonItem barLargeButtonItem12;

	private BarButtonItem barButtonItem7;

	private BarButtonItem barButtonItem8;

	private BarButtonItem barButtonItem9;

	public FrmPrincipale()
	{
		InitializeComponent();
		BonusSkins.Register();
		SkinManager.EnableFormSkins();
		SkinManager.EnableMdiFormSkins();
		Application.EnableVisualStyles();
		
		// Force a modern, sleek skin
		UserLookAndFeel.Default.SetSkinStyle("The Bezier", "Office White");
		
		ApplyModernIcons();
		
		monModule.gUNI = "";
		monModule.gExercice = 0;
	}

	private void ApplyModernIcons()
	{
		// Senior Level approach: Centralized icon management via IconManager (FontAwesome Sharp)
		// FontAwesome vector icons provide a crisp, modern look across all display scales.
		
		// Parent Menu Items
		IconManager.SetIcon(barFichiers, IconManager.Icons.Files);
		IconManager.SetIcon(barTables, IconManager.Icons.Table);
		IconManager.SetIcon(barTraitements, IconManager.Icons.Tools);
		IconManager.SetIcon(barEditions, IconManager.Icons.Print);

		// --- Fichiers Menu ---
		IconManager.SetIcon(barOuvrir, IconManager.Icons.Open);
		IconManager.SetIcon(barEnregisterSous, IconManager.Icons.Save);
		IconManager.SetIcon(barExporterDossier, IconManager.Icons.ExportXlsx); // Exporter Dossier
		IconManager.SetIcon(barCompacter, IconManager.Icons.Database);
		IconManager.SetIcon(barCloturer, IconManager.Icons.Close); // Cloturer -> Close/Lock
		IconManager.SetIcon(barQuitter, IconManager.Icons.Close);

		// --- Tables Menu ---
		IconManager.SetIcon(barDossiers, IconManager.Icons.Business);
		IconManager.SetIcon(barVilles, IconManager.Icons.Map);
		IconManager.SetIcon(barTiers, IconManager.Icons.Users);
		IconManager.SetIcon(barPlanComptable, IconManager.Icons.Accounts);
		IconManager.SetIcon(barJournaux, IconManager.Icons.Journals);
		IconManager.SetIcon(barPieces, IconManager.Icons.Pieces);
		IconManager.SetIcon(barInvestissements, IconManager.Icons.Investments);

		// --- Traitements Menu ---
		IconManager.SetIcon(barEcrituresBord, IconManager.Icons.Board);
		IconManager.SetIcon(barEcrituresPCS, IconManager.Icons.Pieces); // Ecritures par Pièce
		IconManager.SetIcon(barImporterEcritures, IconManager.Icons.Import);
		IconManager.SetIcon(barChangerDossier, IconManager.Icons.Exchange);
		IconManager.SetIcon(barAmortissement, IconManager.Icons.Percentage);
		IconManager.SetIcon(barPointageEcritures, IconManager.Icons.Check);
		IconManager.SetIcon(barRapprochement, IconManager.Icons.Balance);

		// --- Editions Menu ---
		IconManager.SetIcon(barEdJournaux, IconManager.Icons.Journals);
		IconManager.SetIcon(barEdJournalOuverture, IconManager.Icons.DoorOpen);
		IconManager.SetIcon(barEdGrandLivre, IconManager.Icons.Reading);
		IconManager.SetIcon(barEdHistoriqueCompte, IconManager.Icons.History);
		IconManager.SetIcon(barEdBalanceSoldes, IconManager.Icons.Balance);
		IconManager.SetIcon(barEdBalanceGenerale, IconManager.Icons.ShowAll);
		IconManager.SetIcon(barEdBalanceComptes, IconManager.Icons.Table);
		IconManager.SetIcon(barEdCentralisation, IconManager.Icons.Centralisation);
		IconManager.SetIcon(barEdRecapAchatsVentes, IconManager.Icons.Shopping);
		IconManager.SetIcon(barEdEtatClient, IconManager.Icons.UserTag);
		IconManager.SetIcon(barEdBilan, IconManager.Icons.Contract);
		IconManager.SetIcon(barEdDiversEtats, IconManager.Icons.Others);
		IconManager.SetIcon(barButtonItem9, IconManager.Icons.Users); // Dossier Client report
		IconManager.SetIcon(skinBarSubItem1, IconManager.Icons.Palette); // Themes menu

		// Large Buttons (Header Bar) - Preserving existing assignments
		IconManager.SetIcon(barSubItem3, IconManager.Icons.Edit, true);
		IconManager.SetIcon(barLargeEcrPiece, IconManager.Icons.Pieces, true);
		IconManager.SetIcon(barLargeEcrBordereau, IconManager.Icons.Today, true);
		
		IconManager.SetIcon(barLargeButtonItem2, IconManager.Icons.Users, true);
		IconManager.SetIcon(barLargeButtonItem3, IconManager.Icons.Open, true);
		IconManager.SetIcon(barLargeButtonItem4, IconManager.Icons.Journals, true);
		IconManager.SetIcon(barLargeButtonItem1, IconManager.Icons.Centralisation, true);
		IconManager.SetIcon(barLargeButtonItem5, IconManager.Icons.Reading, true);
		
		IconManager.SetIcon(barSubItem1, IconManager.Icons.Accounting, true);
		IconManager.SetIcon(barLargeButtonItem8, IconManager.Icons.Calculator, true);
		IconManager.SetIcon(barLargeButtonItem7, IconManager.Icons.Accounting, true);
		IconManager.SetIcon(barLargeButtonItem6, IconManager.Icons.Today, true);
		
		IconManager.SetIcon(barSubItem4, IconManager.Icons.ShowAll, true);
		IconManager.SetIcon(barLargeButtonItem11, IconManager.Icons.Table, true);
		IconManager.SetIcon(barLargeButtonItem12, IconManager.Icons.Pies, true);
		
		IconManager.SetIcon(barLargeButtonItem9, IconManager.Icons.Report, true);
		
		IconManager.SetIcon(barSubItem2, IconManager.Icons.ExportXlsx, true);
		IconManager.SetIcon(barLargeBilanExcel, IconManager.Icons.ExportXlsx, true);
		IconManager.SetIcon(barLargeButtonItem10, IconManager.Icons.WorkWeek, true);
	}

	private void OpenFile()
	{
		using OpenFileDialog openFileDialog1 = new OpenFileDialog();
		openFileDialog1.Title = "Ouvrir une base de données";
		openFileDialog1.Filter = "Fichiers mdb (*.mdb)|*.mdb";
		if (openFileDialog1.ShowDialog() == DialogResult.OK)
		{
			try
			{
				monModule.gFile = openFileDialog1.FileName;
				
				// Update connection string in memory (config.Save() would fail in Program Files)
				var connectionStrings = ConfigurationManager.ConnectionStrings;
				var field = typeof(ConfigurationElement).GetField("_readOnly", BindingFlags.Instance | BindingFlags.NonPublic);
				if (connectionStrings["MyBase"] != null) {
					field?.SetValue(connectionStrings["MyBase"], false);
					connectionStrings["MyBase"].ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + monModule.gFile;
				}
				
				openFileDialog1.Dispose();
				monModule.OuvrirTables();
				return;
			}
			catch (SecurityException ex)
			{
				MessageBox.Show("Security error.\n\nError message: " + ex.Message + "\n\n");
				Application.Exit();
				return;
			}
		}
	}

	private void MiseAjour()
	{
		using OleDbConnection gbase = new OleDbConnection(monModule.gConnString);
		OleDbCommand cmd = new OleDbCommand();
		OleDbTransaction transaction = null;
		cmd.CommandType = CommandType.Text;
		gbase.Open();
		cmd.Connection = gbase;
		cmd.CommandText = "DELETE * FROM Ecritures WHERE (Len([CPT])>5);";
		cmd.ExecuteNonQuery();
		cmd.CommandText = "DELETE * FROM Comptes WHERE (Len([CPT])>5);";
		cmd.ExecuteNonQuery();
		cmd.CommandText = "Select TOP 1 LIBAR From Tiers ";
		bool exists = true;
		try
		{
			cmd.ExecuteScalar();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			exists = false;
		}
		if (!exists)
		{
			transaction = (cmd.Transaction = gbase.BeginTransaction());
			cmd.CommandText = "Alter Table Tiers ALTER Column ACT TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Tiers ALTER Column ADR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Tiers ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Tiers ADD Column ADRAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Tiers ADD Column ACTAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Dossiers ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Dossiers ADD Column ADRAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Dossiers ADD Column ACTAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Villes ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Comptes ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Journaux ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Pieces ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table LesMois ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Immo ADD Column LIBAR TEXT(80) DEFAULT \"\"";
			cmd.ExecuteNonQuery();
			transaction.Commit();
		}
		cmd.CommandText = "Select TOP 1 AMOR From Comptes ";
		exists = true;
		try
		{
			cmd.ExecuteScalar();
		}
		catch (Exception ex2)
		{
			Console.WriteLine(ex2.Message);
			exists = false;
		}
		if (!exists)
		{
			transaction = (cmd.Transaction = gbase.BeginTransaction());
			cmd.CommandText = "Alter Table Comptes ADD Column AMOR TEXT(1) DEFAULT \"N\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Comptes ADD Column DOT TEXT(1)  DEFAULT \"N\" ";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Comptes ADD Column PROD TEXT(1)  DEFAULT \"N\" ";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Update Comptes SET AMOR='N', DOT='N', PROD='N'";
			cmd.ExecuteNonQuery();
			transaction.Commit();
		}
		cmd.CommandText = "Select TOP 1 CPTAMOR From Immo ";
		exists = true;
		try
		{
			cmd.ExecuteScalar();
		}
		catch (Exception ex3)
		{
			Console.WriteLine(ex3.Message);
			exists = false;
		}
		if (!exists)
		{
			transaction = (cmd.Transaction = gbase.BeginTransaction());
			cmd.CommandText = "Alter Table Immo ADD Column CPTAMOR TEXT(6) ";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Immo ADD Column CPTDOT TEXT(6) ";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Alter Table Immo ADD Column CPTPROD TEXT(6) ";
			cmd.ExecuteNonQuery();
			transaction.Commit();
		}
	}

	private bool CompactDatabaseACE(string SourceDb)
	{
		bool retVal = false;
		string Temp1Db = Path.Combine(Path.GetDirectoryName(SourceDb), Path.GetFileNameWithoutExtension(SourceDb) + ".cmp");
		string Temp2Db = Path.Combine(Path.GetDirectoryName(SourceDb), Path.GetFileNameWithoutExtension(SourceDb) + ".old");
		if (File.Exists(Temp1Db))
		{
			File.Delete(Temp1Db);
		}
		if (File.Exists(Temp2Db))
		{
			File.Delete(Temp2Db);
		}
		
		object DBE = null;
		try {
			object[] oParams = new object[2] { SourceDb, Temp1Db };
			DBE = Activator.CreateInstance(Type.GetTypeFromProgID("DAO.DBEngine.120"));
			DBE.GetType().InvokeMember("CompactDatabase", BindingFlags.InvokeMethod, null, DBE, oParams);
			
			if (File.Exists(Temp1Db))
			{
				try
				{
					File.Move(SourceDb, Temp2Db);
				}
				catch
				{
				}
				if (File.Exists(Temp2Db))
				{
					try
					{
						File.Move(Temp1Db, SourceDb);
					}
					catch
					{
					}
					if (File.Exists(SourceDb))
					{
						retVal = true;
					}
				}
				if (File.Exists(Temp1Db))
				{
					File.Delete(Temp1Db);
				}
				if (File.Exists(Temp2Db))
				{
					File.Delete(Temp2Db);
				}
			}
			MessageBox.Show("La base de données a été compactée !");
		}
		finally {
			if (DBE != null) {
				Marshal.ReleaseComObject(DBE);
				DBE = null;
			}
		}
		return retVal;
	}

	private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
	{
		try
		{
			monModule.gbase.Close();
			
			// Clear pooling and wait a bit for file handles to release
			OleDbConnection.ReleaseObjectPool();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			System.Threading.Thread.Sleep(500); 

			CompactDatabaseACE(monModule.gFile);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Erreur lors du compactage : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally
		{
			monModule.OuvrirTables();
		}
	}

	private void barOuvrir_ItemClick(object sender, ItemClickEventArgs e)
	{
		OpenFile();
		MiseAjour();
		frmChangerDossier obj = new frmChangerDossier();
		obj.ShowDialog();
		obj.Dispose();
		if (monModule.gUNI != string.Empty)
		{
			barDOS.Caption = monModule.gUNILIB + "    Exercice : " + monModule.gExercice;
		}
	}

	private void barDossiers_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmDossiers obj = new frmDossiers();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barTiers_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmTiers obj = new frmTiers();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void FrmPrincipale_Load(object sender, EventArgs e)
	{
		try
		{
			// 1. Setup Environment (Paths, DB copy, Excel copy, In-memory connection string)
			monModule.CheckEnvironment();
			
			// 2. Refresh database connectivity
			MiseAjour();
			monModule.OuvrirTables();

			// 3. User Login/Selection UI
			frmChangerDossier obj = new frmChangerDossier();
			obj.ShowDialog();
			obj.Dispose();
			
			barDOS.Caption = "";
			if (monModule.gUNI != string.Empty)
			{
				barDOS.Caption = monModule.gUNILIB + "    Exercice : " + monModule.gExercice;
			}
		}
		catch (SecurityException ex)
		{
			MessageBox.Show("Security error.\n\nError message: " + ex.Message + "\n\n");
			Application.Exit();
		}
	}

	private void barPlanComptable_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmComptes obj = new frmComptes();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barJournaux_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmJournaux obj = new frmJournaux();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barPieces_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmPieces obj = new frmPieces();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEcrituresBord_ItemClick(object sender, ItemClickEventArgs e)
	{
		bool exists = false;
		foreach (Form openForm in Application.OpenForms)
		{
			if (openForm.Name == "frmEcritures")
			{
				exists = true;
			}
		}
		if (!exists)
		{
			frmEcritures obj = new frmEcritures();
			obj.MdiParent = this;
			obj.Show();
		}
	}

	private void barEdJournaux_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmEtatJournaux obj = new frmEtatJournaux();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdBalanceSoldes_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmBalance obj = new frmBalance();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdJournalOuverture_ItemClick(object sender, ItemClickEventArgs e)
	{
		rptSolde report = new rptSolde(ouverture: true);
		DataTable dt = new DataTable();
		monModule.eExercice = monModule.gExercice.ToString();
		monModule.eUNI = monModule.gUNI;
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + monModule.gUNI + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			monModule.eUNILIB = foundRows[0]["LIB"].ToString();
		}
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT mid(Ecritures.CPT ,1,1) as UN, Ecritures.CPT as Compte, Comptes.LIB, IIf(Sum([deb])-Sum([cre])>0,Sum([deb])-Sum([cre]),0) AS SDEBIT, IIf(Sum([deb])-Sum([cre])<=0,-Sum([deb])+Sum([cre]),0) AS SCREDIT  FROM Comptes INNER JOIN Ecritures ON Comptes.CPT = Ecritures.CPT  Where (((Ecritures.uni) = '" + monModule.eUNI + "') And ((Ecritures.exercice) =" + monModule.eExercice + ") And ((Ecritures.ja) = '00')) GROUP BY mid(Ecritures.CPT ,1,1), Ecritures.CPT, Comptes.LIB  ORDER BY Ecritures.CPT;", monModule.gbase);
		dt.Clear();
		oleDbDataAdapter.Fill(dt);
		report.DataSource = dt;
		new ReportPrintTool(report).ShowPreview();
	}

	private void barEdGrandLivre_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmGrandLivre obj = new frmGrandLivre();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdBalanceComptes_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmBalanceDetaillee obj = new frmBalanceDetaillee();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdBalanceGenerale_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmBalance obj = new frmBalance(gen: true);
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdCentralisation_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmBilan obj = new frmBilan();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdHistoriqueCompte_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmHistCompte obj = new frmHistCompte();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdRecapAchatsVentes_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmRecap obj = new frmRecap(_tva: false);
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdEtatClient_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmRecap obj = new frmRecap(_tva: true);
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barEdDiversEtats_ItemClick(object sender, ItemClickEventArgs e)
	{
		monModule.MakeBalance();
		frmExcel obj = new frmExcel();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barChangerDossier_ItemClick(object sender, ItemClickEventArgs e)
	{
		bool exists = false;
		foreach (Form openForm in Application.OpenForms)
		{
			if (openForm.Name == "frmEcritures")
			{
				exists = true;
			}
		}
		if (!exists)
		{
			frmChangerDossier obj = new frmChangerDossier();
			obj.ShowDialog();
			obj.Dispose();
			if (monModule.gUNI != string.Empty)
			{
				barDOS.Caption = monModule.gUNILIB + "    Exercice : " + monModule.gExercice;
			}
		}
	}

	private void barCloturer_ItemClick(object sender, ItemClickEventArgs e)
	{
		monModule.Cloturer();
	}

	private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
	{
	}

	private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	private void ImprimerBilan(string fic)
	{
		SpreadsheetControl spreadsheetControl = new SpreadsheetControl();
		IWorkbook workbook = spreadsheetControl.Document;
		NIF _nif = new NIF();
		ACT _act = new ACT();
		Client _nom = new Client();
		ADRS _adr = new ADRS();
		ACTAR _actar = new ACTAR();
		ClientAR _nomar = new ClientAR();
		ADRSAR _adrar = new ADRSAR();
		Ville _ville = new Ville();
		Commune _commune = new Commune();
		VilleAR _villear = new VilleAR();
		CommuneAR _communear = new CommuneAR();
		Recette _recette = new Recette();
		Inspection _inspection = new Inspection();
		CodePostal _codepostal = new CodePostal();
		Exercice _exercice = new Exercice();
		CodeActivite _codeactivite = new CodeActivite();
		NUMAI _numai = new NUMAI();
		SD _sd = new SD();
		SC _sc = new SC();
		SDP _sdp = new SDP();
		SCP _scp = new SCP();
		SDPF _sdpf = new SDPF();
		SCPF _scpf = new SCPF();
		S _s = new S();
		SS _ss = new SS();
		SP _sp = new SP();
		SSP _ssp = new SSP();
		SF _sf = new SF();
		SPF _spf = new SPF();
		SCF _scf = new SCF();
		SDF _sdf = new SDF();
		MC _mc = new MC();
		MD _md = new MD();
		MCF _mcf = new MCF();
		MDF _mdf = new MDF();
		workbook.DocumentSettings.Calculation.FullCalculationOnLoad = true;
		spreadsheetControl.Options.CalculationMode = WorkbookCalculationMode.Automatic;
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_numai.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_numai);
			ICustomFunctionDescriptionsRegisterService service = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments = new CustomFunctionArgumentsDescriptionsCollection();
			service.RegisterFunctionDescriptions(_numai.Name, "Numéro d'Article d'Imposition", arguments);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_codeactivite.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_codeactivite);
			ICustomFunctionDescriptionsRegisterService service2 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service2 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments2 = new CustomFunctionArgumentsDescriptionsCollection();
			service2.RegisterFunctionDescriptions(_codeactivite.Name, "Code Activité", arguments2);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_exercice.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_exercice);
			ICustomFunctionDescriptionsRegisterService service3 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service3 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments3 = new CustomFunctionArgumentsDescriptionsCollection();
			service3.RegisterFunctionDescriptions(_exercice.Name, "Exercice Fiscal", arguments3);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_codepostal.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_codepostal);
			ICustomFunctionDescriptionsRegisterService service4 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service4 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments4 = new CustomFunctionArgumentsDescriptionsCollection();
			service4.RegisterFunctionDescriptions(_codepostal.Name, "Code Postal", arguments4);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_inspection.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_inspection);
			ICustomFunctionDescriptionsRegisterService service5 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service5 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments5 = new CustomFunctionArgumentsDescriptionsCollection();
			service5.RegisterFunctionDescriptions(_inspection.Name, "Inspection", arguments5);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_recette.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_recette);
			ICustomFunctionDescriptionsRegisterService service6 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service6 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments6 = new CustomFunctionArgumentsDescriptionsCollection();
			service6.RegisterFunctionDescriptions(_recette.Name, "Recette", arguments6);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_commune.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_commune);
			ICustomFunctionDescriptionsRegisterService service7 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service7 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments7 = new CustomFunctionArgumentsDescriptionsCollection();
			service7.RegisterFunctionDescriptions(_commune.Name, "Commune", arguments7);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_ville.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_ville);
			ICustomFunctionDescriptionsRegisterService service8 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service8 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments8 = new CustomFunctionArgumentsDescriptionsCollection();
			service8.RegisterFunctionDescriptions(_ville.Name, "Ville", arguments8);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_communear.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_communear);
			ICustomFunctionDescriptionsRegisterService service9 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service9 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments9 = new CustomFunctionArgumentsDescriptionsCollection();
			service9.RegisterFunctionDescriptions(_communear.Name, "Commune", arguments9);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_villear.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_villear);
			ICustomFunctionDescriptionsRegisterService service10 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service10 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments10 = new CustomFunctionArgumentsDescriptionsCollection();
			service10.RegisterFunctionDescriptions(_villear.Name, "Ville", arguments10);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_nif.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_nif);
			ICustomFunctionDescriptionsRegisterService service11 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service11 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments11 = new CustomFunctionArgumentsDescriptionsCollection();
			service11.RegisterFunctionDescriptions(_nif.Name, "Numéro d'Identification Fiscale", arguments11);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_act.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_act);
			ICustomFunctionDescriptionsRegisterService service12 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service12 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments12 = new CustomFunctionArgumentsDescriptionsCollection();
			service12.RegisterFunctionDescriptions(_act.Name, "Activité de l'entreprise", arguments12);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_nom.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_nom);
			ICustomFunctionDescriptionsRegisterService service13 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service13 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments13 = new CustomFunctionArgumentsDescriptionsCollection();
			service13.RegisterFunctionDescriptions(_nom.Name, "Nom de l'entreprise", arguments13);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_adr.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_adr);
			ICustomFunctionDescriptionsRegisterService service14 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service14 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments14 = new CustomFunctionArgumentsDescriptionsCollection();
			service14.RegisterFunctionDescriptions(_adr.Name, "Adresse de l'entreprise", arguments14);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_actar.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_actar);
			ICustomFunctionDescriptionsRegisterService service15 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service15 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments15 = new CustomFunctionArgumentsDescriptionsCollection();
			service15.RegisterFunctionDescriptions(_actar.Name, "Activité de l'entreprise", arguments15);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_nomar.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_nomar);
			ICustomFunctionDescriptionsRegisterService service16 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service16 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments16 = new CustomFunctionArgumentsDescriptionsCollection();
			service16.RegisterFunctionDescriptions(_nomar.Name, "Nom de l'entreprise", arguments16);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_adrar.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_adrar);
			ICustomFunctionDescriptionsRegisterService service17 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service17 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments17 = new CustomFunctionArgumentsDescriptionsCollection();
			service17.RegisterFunctionDescriptions(_adrar.Name, "Adresse de l'entreprise", arguments17);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sd.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sd);
			ICustomFunctionDescriptionsRegisterService service18 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service18 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments18 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments18.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service18.RegisterFunctionDescriptions(_sd.Name, "Solde débit d'un compte", arguments18);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sc.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sc);
			ICustomFunctionDescriptionsRegisterService service19 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service19 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments19 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments19.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service19.RegisterFunctionDescriptions(_sc.Name, "Solde crédit d'un compte", arguments19);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sdp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sdp);
			ICustomFunctionDescriptionsRegisterService service20 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service20 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments20 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments20.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service20.RegisterFunctionDescriptions(_sdp.Name, "Solde débit de l'exercice précédent", arguments20);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_scp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_scp);
			ICustomFunctionDescriptionsRegisterService service21 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service21 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments21 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments21.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "nombre"));
			service21.RegisterFunctionDescriptions(_scp.Name, "Solde crédit de l'exercice précédent", arguments21);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_s.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_s);
			ICustomFunctionDescriptionsRegisterService service22 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service22 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments22 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments22.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service22.RegisterFunctionDescriptions(_s.Name, "Solde d'un compte.", arguments22);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sf);
			ICustomFunctionDescriptionsRegisterService service23 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service23 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments23 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments23.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service23.RegisterFunctionDescriptions(_sf.Name, "Solde d'un compte.", arguments23);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_spf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_spf);
			ICustomFunctionDescriptionsRegisterService service24 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service24 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments24 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments24.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service24.RegisterFunctionDescriptions(_spf.Name, "Solde d'un compte.", arguments24);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_scf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_scf);
			ICustomFunctionDescriptionsRegisterService service25 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service25 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments25 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments25.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service25.RegisterFunctionDescriptions(_scf.Name, "Solde d'un compte.", arguments25);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sdf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sdf);
			ICustomFunctionDescriptionsRegisterService service26 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service26 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments26 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments26.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service26.RegisterFunctionDescriptions(_sdf.Name, "Solde Débit Finace d'un compte.", arguments26);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_mc.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_mc);
			ICustomFunctionDescriptionsRegisterService service27 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service27 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments27 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments27.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service27.RegisterFunctionDescriptions(_mc.Name, "Mouvement Crédit d'un compte.", arguments27);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_md.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_md);
			ICustomFunctionDescriptionsRegisterService service28 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service28 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments28 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments28.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service28.RegisterFunctionDescriptions(_md.Name, "Mouvement Débit d'un compte.", arguments28);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sp);
			ICustomFunctionDescriptionsRegisterService service29 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service29 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments29 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments29.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service29.RegisterFunctionDescriptions(_sp.Name, "Solde Précédent  d'un compte.", arguments29);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_ss.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_ss);
			ICustomFunctionDescriptionsRegisterService service30 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service30 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments30 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments30.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service30.RegisterFunctionDescriptions(_ss.Name, "Solde Précédent  d'un compte.", arguments30);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_ssp.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_ssp);
			ICustomFunctionDescriptionsRegisterService service31 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service31 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments31 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments31.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service31.RegisterFunctionDescriptions(_ssp.Name, "Solde Précédent  d'un compte.", arguments31);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_sdpf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_sdpf);
			ICustomFunctionDescriptionsRegisterService service32 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service32 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments32 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments32.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service32.RegisterFunctionDescriptions(_sdpf.Name, "Solde Précédent  d'un compte.", arguments32);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_scpf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_scpf);
			ICustomFunctionDescriptionsRegisterService service33 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service33 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments33 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments33.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service33.RegisterFunctionDescriptions(_scpf.Name, "Solde Précédent  d'un compte.", arguments33);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_mcf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_mcf);
			ICustomFunctionDescriptionsRegisterService service34 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service34 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments34 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments34.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service34.RegisterFunctionDescriptions(_mcf.Name, "Mouvement Crédit Arrondi  d'un compte.", arguments34);
		}
		if (!workbook.Functions.GlobalCustomFunctions.Contains(_mdf.Name))
		{
			workbook.Functions.GlobalCustomFunctions.Add(_mdf);
			ICustomFunctionDescriptionsRegisterService service35 = (ICustomFunctionDescriptionsRegisterService)workbook.GetService(typeof(ICustomFunctionDescriptionsRegisterService));
			if (service35 == null)
			{
				return;
			}
			CustomFunctionArgumentsDescriptionsCollection arguments35 = new CustomFunctionArgumentsDescriptionsCollection();
			arguments35.Add(new CustomFunctionArgumentDescription("Compte", "Compte Comlptable", "texte"));
			service35.RegisterFunctionDescriptions(_mdf.Name, "Mouvement débit Arrondi  d'un compte.", arguments35);
		}
		workbook.DocumentSettings.Calculation.FullCalculationOnLoad = true;
		spreadsheetControl.Options.CalculationMode = WorkbookCalculationMode.Automatic;
		try
		{
			spreadsheetControl.LoadDocument(fic);
			workbook.CalculateFull();
			_ = workbook.Worksheets;
			spreadsheetControl.ShowPrintPreview();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void barLargeButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
	{
		string fic = Path.Combine(monModule.gExcelPath, monModule.gUNILIB + ".xlsx");
		if (!File.Exists(fic))
		{
			string sourceTemplate = Path.Combine(monModule.gExcelPath, "bilan.xlsx");
			if (File.Exists(sourceTemplate)) {
				File.Copy(sourceTemplate, fic, overwrite: false);
				File.SetAttributes(fic, FileAttributes.Normal);
			}
		}
		monModule.MakeBalance();
		frmPrintBilan obj = new frmPrintBilan(fic);
		obj.ShowDialog();
		obj.Dispose();
	}

	private void FrmPrincipale_StyleChanged(object sender, EventArgs e)
	{
	}

	private void skinBarSubItem1_ItemClick(object sender, ItemClickEventArgs e)
	{
	}

	private void barInvestissements_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmAmortissement obj = new frmAmortissement();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void FrmPrincipale_FormClosing(object sender, FormClosingEventArgs e)
	{
		Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
		Settings.Default.Save();
	}

	private void ExporterDossier()
	{
		try
		{
			_ = monModule.gConnString;
			File.Copy(Path.GetDirectoryName(Application.ExecutablePath) + "\\modele.mdb", Path.GetDirectoryName(monModule.gFile) + "\\" + monModule.gUNI + ".mdb", overwrite: true);
			OleDbConnection destination = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Path.GetDirectoryName(monModule.gFile) + "\\" + monModule.gUNI + ".mdb");
			destination.Open();
			OleDbCommand cmd = new OleDbCommand();
			cmd.Connection = destination;
			cmd.CommandText = "INSERT INTO Villes SELECT * FROM Villes IN \"" + monModule.gFile + "\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Dossiers SELECT * FROM Dossiers IN \"" + monModule.gFile + "\" Where UNI='" + monModule.gUNI + "'";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Comptes SELECT * FROM Comptes IN \"" + monModule.gFile + "\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Journaux SELECT * FROM Journaux IN \"" + monModule.gFile + "\"";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Tiers SELECT * FROM Tiers IN \"" + monModule.gFile + "\" Where UNI='" + monModule.gUNI + "'";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Pieces SELECT * FROM Pieces IN \"" + monModule.gFile + "\" Where UNI='" + monModule.gUNI + "'";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Ecritures SELECT * FROM Ecritures IN \"" + monModule.gFile + "\" Where UNI='" + monModule.gUNI + "'";
			cmd.ExecuteNonQuery();
			destination.Close();
			MessageBox.Show("Dossier exporter dans " + Path.GetDirectoryName(monModule.gFile) + "\\" + monModule.gUNI + ".mdb");
			monModule.gExercice++;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void barExporterDossier_ItemClick(object sender, ItemClickEventArgs e)
	{
		ExporterDossier();
	}

	private void barLargeBilanExcel_ItemClick(object sender, ItemClickEventArgs e)
	{
		OuvrirBilanExcel();
	}

	private void OuvrirBilanExcel()
	{
		string fic = Path.Combine(monModule.gExcelPath, monModule.gUNILIB + ".xlsx");
		if (!File.Exists(fic))
		{
			string sourceTemplate = Path.Combine(monModule.gExcelPath, "bilan.xlsx");
			if (File.Exists(sourceTemplate)) {
				File.Copy(sourceTemplate, fic, overwrite: false);
				File.SetAttributes(fic, FileAttributes.Normal);
			}
		}
		monModule.MakeBalance();
		frmExcel obj = new frmExcel(fic);
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barVilles_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmVilles obj = new frmVilles();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barQuitter_ItemClick(object sender, ItemClickEventArgs e)
	{
		Application.Exit();
	}

	private void barEcrituresPCS_ItemClick(object sender, ItemClickEventArgs e)
	{
		bool exists = false;
		foreach (Form openForm in Application.OpenForms)
		{
			if (openForm.Name == "frmEcritures")
			{
				exists = true;
			}
		}
		if (!exists)
		{
			frmEcritures obj = new frmEcritures(_parpiece: true);
			obj.MdiParent = this;
			obj.Show();
		}
	}

	private void barEnregisterSous_ItemClick(object sender, ItemClickEventArgs e)
	{
		using SaveFileDialog saveFileDialog1 = new SaveFileDialog();
		saveFileDialog1.Title = "Enregistrer la base de données sous ...";
		saveFileDialog1.Filter = "Fichiers mdb (*.mdb)|*.mdb";
		if (saveFileDialog1.ShowDialog() == DialogResult.OK)
		{
			try
			{
				File.Copy(monModule.gFile, saveFileDialog1.FileName);
				return;
			}
			catch (SecurityException ex)
			{
				MessageBox.Show("Security error.\n\nError message: " + ex.Message + "\n\n");
				Application.Exit();
				return;
			}
		}
	}

	private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmBilan obj = new frmBilan();
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barLargeButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
	{
		string fic = Path.Combine(monModule.gExcelPath, monModule.gUNILIB + ".xlsx");
		if (!File.Exists(fic))
		{
			string sourceTemplate = Path.Combine(monModule.gExcelPath, "bilan.xlsx");
			if (File.Exists(sourceTemplate)) {
				File.Copy(sourceTemplate, fic, overwrite: false);
				File.SetAttributes(fic, FileAttributes.Normal);
			}
		}
		monModule.MakeBalance();
		frmPrintBilan obj = new frmPrintBilan(fic);
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barLargeButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
	{
		string fic = Path.Combine(monModule.gExcelPath, monModule.gUNILIB + "_FISC.xlsx");
		if (!File.Exists(fic))
		{
			string sourceTemplate = Path.Combine(monModule.gExcelPath, "bilanfisc.xlsx");
			if (File.Exists(sourceTemplate)) {
				File.Copy(sourceTemplate, fic, overwrite: false);
				File.SetAttributes(fic, FileAttributes.Normal);
			}
		}
		monModule.MakeBalance();
		frmPrintBilan obj = new frmPrintBilan(fic);
		obj.ShowDialog();
		obj.Dispose();
	}

	private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
	{
		new ReportPrintTool(new rptDossierClient()).ShowPreview();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.FrmPrincipale));
		this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
		this.bar2 = new DevExpress.XtraBars.Bar();
		this.barFichiers = new DevExpress.XtraBars.BarSubItem();
		this.barOuvrir = new DevExpress.XtraBars.BarButtonItem();
		this.barCompacter = new DevExpress.XtraBars.BarButtonItem();
		this.barEnregisterSous = new DevExpress.XtraBars.BarButtonItem();
		this.barExporterDossier = new DevExpress.XtraBars.BarButtonItem();
		this.barCloturer = new DevExpress.XtraBars.BarButtonItem();
		this.barQuitter = new DevExpress.XtraBars.BarButtonItem();
		this.barTables = new DevExpress.XtraBars.BarSubItem();
		this.barDossiers = new DevExpress.XtraBars.BarButtonItem();
		this.barJournaux = new DevExpress.XtraBars.BarButtonItem();
		this.barPlanComptable = new DevExpress.XtraBars.BarButtonItem();
		this.barPieces = new DevExpress.XtraBars.BarButtonItem();
		this.barTiers = new DevExpress.XtraBars.BarButtonItem();
		this.barInvestissements = new DevExpress.XtraBars.BarButtonItem();
		this.barVilles = new DevExpress.XtraBars.BarButtonItem();
		this.barTraitements = new DevExpress.XtraBars.BarSubItem();
		this.barEcrituresBord = new DevExpress.XtraBars.BarButtonItem();
		this.barEcrituresPCS = new DevExpress.XtraBars.BarButtonItem();
		this.barImporterEcritures = new DevExpress.XtraBars.BarButtonItem();
		this.barChangerDossier = new DevExpress.XtraBars.BarButtonItem();
		this.barAmortissement = new DevExpress.XtraBars.BarButtonItem();
		this.barPointageEcritures = new DevExpress.XtraBars.BarButtonItem();
		this.barRapprochement = new DevExpress.XtraBars.BarButtonItem();
		this.barEditions = new DevExpress.XtraBars.BarSubItem();
		this.barEdJournaux = new DevExpress.XtraBars.BarButtonItem();
		this.barEdJournalOuverture = new DevExpress.XtraBars.BarButtonItem();
		this.barEdGrandLivre = new DevExpress.XtraBars.BarButtonItem();
		this.barEdCentralisation = new DevExpress.XtraBars.BarButtonItem();
		this.barEdBalanceSoldes = new DevExpress.XtraBars.BarButtonItem();
		this.barEdBalanceGenerale = new DevExpress.XtraBars.BarButtonItem();
		this.barEdBalanceComptes = new DevExpress.XtraBars.BarButtonItem();
		this.barEdHistoriqueCompte = new DevExpress.XtraBars.BarButtonItem();
		this.barEdRecapAchatsVentes = new DevExpress.XtraBars.BarButtonItem();
		this.barEdEtatClient = new DevExpress.XtraBars.BarButtonItem();
		this.barEdBilan = new DevExpress.XtraBars.BarButtonItem();
		this.barEdDiversEtats = new DevExpress.XtraBars.BarButtonItem();
		this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
		this.barDOS = new DevExpress.XtraBars.BarStaticItem();
		this.bar3 = new DevExpress.XtraBars.Bar();
		this.bar1 = new DevExpress.XtraBars.Bar();
		this.barSubItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.popupEcritures = new DevExpress.XtraBars.PopupMenu(this.components);
		this.barLargeEcrBordereau = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeEcrPiece = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barSubItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.popupBalance = new DevExpress.XtraBars.PopupMenu(this.components);
		this.barLargeButtonItem8 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem7 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem6 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barSubItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.popupBilans = new DevExpress.XtraBars.PopupMenu(this.components);
		this.barLargeButtonItem11 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem12 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem9 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barSubItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.popupExcel = new DevExpress.XtraBars.PopupMenu(this.components);
		this.barLargeBilanExcel = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barLargeButtonItem10 = new DevExpress.XtraBars.BarLargeButtonItem();
		this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
		this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
		this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
		this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
		this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
		this.titre = new DevExpress.XtraBars.BarHeaderItem();
		this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
		this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
		this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
		this.sharedImageCollection1 = new DevExpress.Utils.SharedImageCollection(this.components);
		this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
		this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
		this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
		this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
		((System.ComponentModel.ISupportInitialize)this.barManager1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1.ImageSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.behaviorManager1).BeginInit();
		base.SuspendLayout();
		this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[3] { this.bar2, this.bar3, this.bar1 });
		this.barManager1.DockControls.Add(this.barDockControlTop);
		this.barManager1.DockControls.Add(this.barDockControlBottom);
		this.barManager1.DockControls.Add(this.barDockControlLeft);
		this.barManager1.DockControls.Add(this.barDockControlRight);
		this.barManager1.Form = this;
		this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[66]
		{
			this.barFichiers, this.barTables, this.barTraitements, this.barEditions, this.barCompacter, this.barOuvrir, this.barCloturer, this.barQuitter, this.barEnregisterSous, this.barLinkContainerItem1,
			this.barDossiers, this.barJournaux, this.barPlanComptable, this.barTiers, this.barInvestissements, this.barPieces, this.barVilles, this.barEcrituresBord, this.barChangerDossier, this.barAmortissement,
			this.barImporterEcritures, this.barPointageEcritures, this.barRapprochement, this.barEdJournaux, this.barEdJournalOuverture, this.barEdBalanceSoldes, this.barEdGrandLivre, this.barEdCentralisation, this.barEdBalanceGenerale, this.barEdBalanceComptes,
			this.barEdHistoriqueCompte, this.barEdRecapAchatsVentes, this.barEdEtatClient, this.barEdBilan, this.barEdDiversEtats, this.skinBarSubItem1, this.barButtonItem1, this.barButtonItem2, this.barLargeEcrPiece, this.barLargeButtonItem2,
			this.barLargeButtonItem3, this.barButtonItem3, this.barLargeButtonItem4, this.barLargeButtonItem5, this.barLargeButtonItem6, this.barLargeButtonItem7, this.barLargeButtonItem8, this.barLargeButtonItem9, this.titre, this.barLargeButtonItem10,
			this.barExporterDossier, this.barLargeBilanExcel, this.barDOS, this.barLargeEcrBordereau, this.barEcrituresPCS, this.barSubItem1, this.barSubItem2, this.barSubItem3, this.barButtonItem6, this.barLargeButtonItem1,
			this.barSubItem4, this.barButtonItem7, this.barButtonItem8, this.barLargeButtonItem11, this.barLargeButtonItem12, this.barButtonItem9
		});
		this.barManager1.MainMenu = this.bar2;
		this.barManager1.MaxItemId = 67;
		this.barManager1.StatusBar = this.bar3;
		this.bar2.BarItemHorzIndent = 10;
		this.bar2.BarItemVertIndent = 10;
		this.bar2.BarName = "Menu principal";
		this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
		this.bar2.DockCol = 0;
		this.bar2.DockRow = 0;
		this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
		this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barFichiers, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barTables),
			new DevExpress.XtraBars.LinkPersistInfo(this.barTraitements),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEditions),
			new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
			new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDOS, DevExpress.XtraBars.BarItemPaintStyle.Caption)
		});
		this.bar2.OptionsBar.AllowQuickCustomization = false;
		this.bar2.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.All;
		this.bar2.OptionsBar.DrawDragBorder = false;
		this.bar2.OptionsBar.UseWholeRow = true;
		this.bar2.Text = "Main menu";
		this.barFichiers.Caption = "&Fichiers";
		this.barFichiers.Id = 0;
		this.barFichiers.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barOuvrir),
			new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barCompacter, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEnregisterSous, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barExporterDossier, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barCloturer),
			new DevExpress.XtraBars.LinkPersistInfo(this.barQuitter, true)
		});
		this.barFichiers.Name = "barFichiers";
		this.barFichiers.OptionsMultiColumn.LargeImages = DevExpress.Utils.DefaultBoolean.True;
		this.barOuvrir.Caption = "&Ouvrir";
		this.barOuvrir.Id = 5;
		this.barOuvrir.ImageOptions.Image = compta.Properties.Resources.loadfrom_16x16;
		this.barOuvrir.Name = "barOuvrir";
		this.barOuvrir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barOuvrir_ItemClick);
		this.barCompacter.Caption = "&Compacter";
		this.barCompacter.Id = 4;
		this.barCompacter.ImageOptions.Image = compta.Properties.Resources.managedatasource_16x16;
		this.barCompacter.Name = "barCompacter";
		this.barCompacter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barButtonItem1_ItemClick);
		this.barEnregisterSous.Caption = "&Enregistrer Sous";
		this.barEnregisterSous.Id = 8;
		this.barEnregisterSous.ImageOptions.Image = compta.Properties.Resources.saveas_16x16;
		this.barEnregisterSous.Name = "barEnregisterSous";
		this.barEnregisterSous.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEnregisterSous_ItemClick);
		this.barExporterDossier.Caption = "Exporter Dossier";
		this.barExporterDossier.Id = 51;
		this.barExporterDossier.Name = "barExporterDossier";
		this.barExporterDossier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barExporterDossier_ItemClick);
		this.barCloturer.Caption = "&Clôturer Exercice";
		this.barCloturer.Id = 6;
		this.barCloturer.ImageOptions.Image = compta.Properties.Resources.encryptdocument_16x16;
		this.barCloturer.ImageOptions.LargeImage = compta.Properties.Resources.encryptdocument_32x32;
		this.barCloturer.Name = "barCloturer";
		this.barCloturer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barCloturer_ItemClick);
		this.barQuitter.Caption = "&Quitter";
		this.barQuitter.Id = 7;
		this.barQuitter.ImageOptions.Image = compta.Properties.Resources.close_16x161;
		this.barQuitter.ImageOptions.LargeImage = compta.Properties.Resources.close_32x321;
		this.barQuitter.Name = "barQuitter";
		this.barQuitter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barQuitter_ItemClick);
		this.barTables.Caption = "&Tables";
		this.barTables.Id = 1;
		this.barTables.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[7]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barDossiers),
			new DevExpress.XtraBars.LinkPersistInfo(this.barJournaux),
			new DevExpress.XtraBars.LinkPersistInfo(this.barPlanComptable),
			new DevExpress.XtraBars.LinkPersistInfo(this.barPieces),
			new DevExpress.XtraBars.LinkPersistInfo(this.barTiers, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barInvestissements, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barVilles, true)
		});
		this.barTables.Name = "barTables";
		this.barDossiers.Caption = "Dossiers";
		this.barDossiers.Id = 10;
		this.barDossiers.ImageOptions.Image = compta.Properties.Resources.project_16x16;
		this.barDossiers.ImageOptions.LargeImage = compta.Properties.Resources.project_32x32;
		this.barDossiers.Name = "barDossiers";
		this.barDossiers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barDossiers_ItemClick);
		this.barJournaux.Caption = "Journaux";
		this.barJournaux.Id = 11;
		this.barJournaux.ImageOptions.Image = compta.Properties.Resources.report_16x16;
		this.barJournaux.Name = "barJournaux";
		this.barJournaux.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barJournaux_ItemClick);
		this.barPlanComptable.Caption = "Plan Comptable";
		this.barPlanComptable.Id = 12;
		this.barPlanComptable.ImageOptions.Image = compta.Properties.Resources.map_16x16;
		this.barPlanComptable.Name = "barPlanComptable";
		this.barPlanComptable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barPlanComptable_ItemClick);
		this.barPieces.Caption = "Pièces";
		this.barPieces.Id = 15;
		this.barPieces.ImageOptions.Image = compta.Properties.Resources.engineering_16x16;
		this.barPieces.Name = "barPieces";
		this.barPieces.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barPieces_ItemClick);
		this.barTiers.Caption = "Tiers";
		this.barTiers.Id = 13;
		this.barTiers.ImageOptions.Image = compta.Properties.Resources.team_16x16;
		this.barTiers.Name = "barTiers";
		this.barTiers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barTiers_ItemClick);
		this.barInvestissements.Caption = "Investissements";
		this.barInvestissements.Id = 14;
		this.barInvestissements.Name = "barInvestissements";
		this.barInvestissements.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barInvestissements_ItemClick);
		this.barVilles.Caption = "Villes";
		this.barVilles.Id = 16;
		this.barVilles.ImageOptions.Image = compta.Properties.Resources.geopoint_16x16;
		this.barVilles.Name = "barVilles";
		this.barVilles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barVilles_ItemClick);
		this.barTraitements.Caption = "T&raitements";
		this.barTraitements.Id = 2;
		this.barTraitements.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[7]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barEcrituresBord),
			new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barEcrituresPCS, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
			new DevExpress.XtraBars.LinkPersistInfo(this.barImporterEcritures, true),
			new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barChangerDossier, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
			new DevExpress.XtraBars.LinkPersistInfo(this.barAmortissement, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barPointageEcritures, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barRapprochement)
		});
		this.barTraitements.Name = "barTraitements";
		this.barEcrituresBord.Caption = "Ecritures par Bordereau";
		this.barEcrituresBord.Id = 17;
		this.barEcrituresBord.ImageOptions.Image = compta.Properties.Resources.adateoccurring_16x16;
		this.barEcrituresBord.Name = "barEcrituresBord";
		this.barEcrituresBord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEcrituresBord_ItemClick);
		this.barEcrituresPCS.Caption = "Ecritures par Pièce";
		this.barEcrituresPCS.Id = 55;
		this.barEcrituresPCS.ImageOptions.Image = compta.Properties.Resources.notes_16x16;
		this.barEcrituresPCS.Name = "barEcrituresPCS";
		this.barEcrituresPCS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEcrituresPCS_ItemClick);
		this.barImporterEcritures.Caption = "Importer des Ecritures";
		this.barImporterEcritures.Id = 20;
		this.barImporterEcritures.Name = "barImporterEcritures";
		this.barChangerDossier.Caption = "Changement de Dossier";
		this.barChangerDossier.Id = 18;
		this.barChangerDossier.ImageOptions.Image = compta.Properties.Resources.projectdirectory_16x16;
		this.barChangerDossier.Name = "barChangerDossier";
		this.barChangerDossier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barChangerDossier_ItemClick);
		this.barAmortissement.Caption = "Calcul des Amortissements";
		this.barAmortissement.Id = 19;
		this.barAmortissement.Name = "barAmortissement";
		this.barPointageEcritures.Caption = "Pointage des Ecritures";
		this.barPointageEcritures.Id = 21;
		this.barPointageEcritures.Name = "barPointageEcritures";
		this.barRapprochement.Caption = "Rapprochement Bancaire";
		this.barRapprochement.Id = 22;
		this.barRapprochement.Name = "barRapprochement";
		this.barEditions.Caption = "&Editions";
		this.barEditions.Id = 3;
		this.barEditions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[13]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdJournaux),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdJournalOuverture),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdGrandLivre),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdCentralisation, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdBalanceSoldes, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdBalanceGenerale),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdBalanceComptes),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdHistoriqueCompte, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdRecapAchatsVentes),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdEtatClient),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdBilan, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barEdDiversEtats),
			new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem9, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)
		});
		this.barEditions.Name = "barEditions";
		this.barEdJournaux.Caption = "Journaux";
		this.barEdJournaux.Id = 23;
		this.barEdJournaux.ImageOptions.Image = compta.Properties.Resources.report_16x16;
		this.barEdJournaux.Name = "barEdJournaux";
		this.barEdJournaux.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdJournaux_ItemClick);
		this.barEdJournalOuverture.Caption = "Journal d'Ouverture";
		this.barEdJournalOuverture.Id = 24;
		this.barEdJournalOuverture.ImageOptions.Image = compta.Properties.Resources.inserttablecaption_16x16;
		this.barEdJournalOuverture.Name = "barEdJournalOuverture";
		this.barEdJournalOuverture.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdJournalOuverture_ItemClick);
		this.barEdGrandLivre.Caption = "Grands Livres";
		this.barEdGrandLivre.Id = 26;
		this.barEdGrandLivre.ImageOptions.Image = compta.Properties.Resources.content_16x16;
		this.barEdGrandLivre.Name = "barEdGrandLivre";
		this.barEdGrandLivre.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdGrandLivre_ItemClick);
		this.barEdCentralisation.Caption = "Centralisation";
		this.barEdCentralisation.Id = 27;
		this.barEdCentralisation.ImageOptions.Image = compta.Properties.Resources.filter_16x16;
		this.barEdCentralisation.Name = "barEdCentralisation";
		this.barEdCentralisation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdCentralisation_ItemClick);
		this.barEdBalanceSoldes.Caption = "Balance des Soldes";
		this.barEdBalanceSoldes.Id = 25;
		this.barEdBalanceSoldes.ImageOptions.Image = compta.Properties.Resources.adateoccurring_16x16;
		this.barEdBalanceSoldes.Name = "barEdBalanceSoldes";
		this.barEdBalanceSoldes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdBalanceSoldes_ItemClick);
		this.barEdBalanceGenerale.Caption = "Balance Générale";
		this.barEdBalanceGenerale.Id = 28;
		this.barEdBalanceGenerale.ImageOptions.Image = compta.Properties.Resources.navigationbar_16x16;
		this.barEdBalanceGenerale.Name = "barEdBalanceGenerale";
		this.barEdBalanceGenerale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdBalanceGenerale_ItemClick);
		this.barEdBalanceComptes.Caption = "Balance des Comptes";
		this.barEdBalanceComptes.Id = 29;
		this.barEdBalanceComptes.ImageOptions.Image = compta.Properties.Resources.accounting_16x16;
		this.barEdBalanceComptes.Name = "barEdBalanceComptes";
		this.barEdBalanceComptes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdBalanceComptes_ItemClick);
		this.barEdHistoriqueCompte.Caption = "Historique de Comptes";
		this.barEdHistoriqueCompte.Id = 30;
		this.barEdHistoriqueCompte.ImageOptions.Image = compta.Properties.Resources.historyitem_16x16;
		this.barEdHistoriqueCompte.Name = "barEdHistoriqueCompte";
		this.barEdHistoriqueCompte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdHistoriqueCompte_ItemClick);
		this.barEdRecapAchatsVentes.Caption = "Recap Achats/Ventes";
		this.barEdRecapAchatsVentes.Id = 31;
		this.barEdRecapAchatsVentes.ImageOptions.Image = compta.Properties.Resources.currency_16x16;
		this.barEdRecapAchatsVentes.Name = "barEdRecapAchatsVentes";
		this.barEdRecapAchatsVentes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdRecapAchatsVentes_ItemClick);
		this.barEdEtatClient.Caption = "Etat Client";
		this.barEdEtatClient.Id = 32;
		this.barEdEtatClient.ImageOptions.Image = compta.Properties.Resources.customer_16x16;
		this.barEdEtatClient.Name = "barEdEtatClient";
		this.barEdEtatClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdEtatClient_ItemClick);
		this.barEdBilan.Caption = "Bilan";
		this.barEdBilan.Id = 33;
		this.barEdBilan.ImageOptions.Image = compta.Properties.Resources.paneloff_16x16;
		this.barEdBilan.Name = "barEdBilan";
		this.barEdDiversEtats.Caption = "Divers Etats";
		this.barEdDiversEtats.Id = 34;
		this.barEdDiversEtats.ImageOptions.Image = compta.Properties.Resources.showworktimeonly_16x16;
		this.barEdDiversEtats.Name = "barEdDiversEtats";
		this.barEdDiversEtats.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdDiversEtats_ItemClick);
		this.skinBarSubItem1.Caption = "Thèmes";
		this.skinBarSubItem1.Id = 35;
		this.skinBarSubItem1.Name = "skinBarSubItem1";
		this.skinBarSubItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(skinBarSubItem1_ItemClick);
		this.barDOS.Caption = "ZIADI";
		this.barDOS.Id = 53;
		this.barDOS.LeftIndent = 200;
		this.barDOS.Name = "barDOS";
		this.bar3.BarName = "Status bar";
		this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
		this.bar3.DockCol = 0;
		this.bar3.DockRow = 0;
		this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
		this.bar3.OptionsBar.AllowQuickCustomization = false;
		this.bar3.OptionsBar.DrawDragBorder = false;
		this.bar3.OptionsBar.UseWholeRow = true;
		this.bar3.Text = "Status bar";
		this.bar1.BarItemHorzIndent = 10;
		this.bar1.BarItemVertIndent = 12;
		this.bar1.BarName = "Outils";
		this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
		this.bar1.DockCol = 0;
		this.bar1.DockRow = 1;
		this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
		this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[10]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem2),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem3),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem4, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem5),
			new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem9, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)
		});
		this.bar1.OptionsBar.AllowQuickCustomization = false;
		this.bar1.OptionsBar.DrawBorder = false;
		this.bar1.OptionsBar.DrawDragBorder = false;
		this.bar1.Text = "Outils";
		this.barSubItem3.Caption = "Ecritures";
		this.barSubItem3.Id = 58;
		this.barSubItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.barSubItem3.ActAsDropDown = true;
		this.barSubItem3.DropDownControl = this.popupEcritures;
		this.barSubItem3.Name = "barSubItem3";
		this.barSubItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		
		this.popupEcritures.Manager = this.barManager1;
		this.popupEcritures.Name = "popupEcritures";
		this.popupEcritures.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeEcrBordereau),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeEcrPiece)
		});
		this.barLargeEcrBordereau.Caption = "Ecritures par Bordereau";
		this.barLargeEcrBordereau.Id = 54;
		this.barLargeEcrBordereau.ImageOptions.Image = compta.Properties.Resources.today_32x32;
		this.barLargeEcrBordereau.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.M | System.Windows.Forms.Keys.Control);
		this.barLargeEcrBordereau.Name = "barLargeEcrBordereau";
		this.barLargeEcrBordereau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEcrituresBord_ItemClick);
		this.barLargeEcrPiece.Caption = "Ecritures par Pièce";
		this.barLargeEcrPiece.Id = 38;
		this.barLargeEcrPiece.ImageOptions.Image = compta.Properties.Resources.notes_32x32;
		this.barLargeEcrPiece.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Control);
		this.barLargeEcrPiece.Name = "barLargeEcrPiece";
		this.barLargeEcrPiece.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeEcrPiece.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEcrituresPCS_ItemClick);
		this.barLargeButtonItem2.Caption = "Tiers";
		this.barLargeButtonItem2.Hint = "Les tiers";
		this.barLargeButtonItem2.Id = 39;
		this.barLargeButtonItem2.ImageOptions.Image = compta.Properties.Resources.team_32x32;
		this.barLargeButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.T | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem2.Name = "barLargeButtonItem2";
		this.barLargeButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barTiers_ItemClick);
		this.barLargeButtonItem3.Caption = "Changer Dossier";
		this.barLargeButtonItem3.Id = 40;
		this.barLargeButtonItem3.ImageOptions.Image = compta.Properties.Resources.projectdirectory_32x32;
		this.barLargeButtonItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.C | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem3.Name = "barLargeButtonItem3";
		this.barLargeButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem3.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
		this.barLargeButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barChangerDossier_ItemClick);
		this.barLargeButtonItem4.Caption = "Journaux";
		this.barLargeButtonItem4.Id = 42;
		this.barLargeButtonItem4.ImageOptions.Image = compta.Properties.Resources.report_32x32;
		this.barLargeButtonItem4.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.J | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem4.Name = "barLargeButtonItem4";
		this.barLargeButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdJournaux_ItemClick);
		this.barLargeButtonItem1.Caption = "Centralisation";
		this.barLargeButtonItem1.Id = 60;
		this.barLargeButtonItem1.Name = "barLargeButtonItem1";
		this.barLargeButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barLargeButtonItem1_ItemClick);
		this.barLargeButtonItem5.Caption = "Grands Livres";
		this.barLargeButtonItem5.Id = 43;
		this.barLargeButtonItem5.ImageOptions.Image = compta.Properties.Resources.content_32x32;
		this.barLargeButtonItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.G | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem5.Name = "barLargeButtonItem5";
		this.barLargeButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdGrandLivre_ItemClick);
		this.barSubItem1.Caption = "Balance";
		this.barSubItem1.Id = 56;
		this.barSubItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.barSubItem1.ActAsDropDown = true;
		this.barSubItem1.DropDownControl = this.popupBalance;
		this.barSubItem1.Name = "barSubItem1";
		this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;

		this.popupBalance.Manager = this.barManager1;
		this.popupBalance.Name = "popupBalance";
		this.popupBalance.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem8),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem7),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem6)
		});
		this.barLargeButtonItem8.Caption = "Balance Générale";
		this.barLargeButtonItem8.Id = 46;
		this.barLargeButtonItem8.ImageOptions.Image = compta.Properties.Resources.navigationbar_32x32;
		this.barLargeButtonItem8.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.P | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem8.Name = "barLargeButtonItem8";
		this.barLargeButtonItem8.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdBalanceGenerale_ItemClick);
		this.barLargeButtonItem7.Caption = "Balance des Comptes";
		this.barLargeButtonItem7.Id = 45;
		this.barLargeButtonItem7.ImageOptions.Image = compta.Properties.Resources.accounting_32x32;
		this.barLargeButtonItem7.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Q | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem7.Name = "barLargeButtonItem7";
		this.barLargeButtonItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdBalanceComptes_ItemClick);
		this.barLargeButtonItem6.Caption = "Balance des Soldes";
		this.barLargeButtonItem6.Id = 44;
		this.barLargeButtonItem6.ImageOptions.Image = compta.Properties.Resources.adateoccurring_32x32;
		this.barLargeButtonItem6.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.R | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem6.Name = "barLargeButtonItem6";
		this.barLargeButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdBalanceSoldes_ItemClick);
		this.barSubItem4.Caption = "Bilans";
		this.barSubItem4.Id = 61;
		this.barSubItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.barSubItem4.ActAsDropDown = true;
		this.barSubItem4.DropDownControl = this.popupBilans;
		this.barSubItem4.Name = "barSubItem4";
		this.barSubItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;

		this.popupBilans.Manager = this.barManager1;
		this.popupBilans.Name = "popupBilans";
		this.popupBilans.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem11),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem12)
		});
		this.barLargeButtonItem11.Caption = "Bilan Comptable";
		this.barLargeButtonItem11.Id = 64;
		this.barLargeButtonItem11.ImageOptions.Image = compta.Properties.Resources.borderlinestyle_32x32;
		this.barLargeButtonItem11.Name = "barLargeButtonItem11";
		this.barLargeButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barLargeButtonItem11_ItemClick);
		this.barLargeButtonItem12.Caption = "Bilan Fiscal";
		this.barLargeButtonItem12.Id = 65;
		this.barLargeButtonItem12.ImageOptions.Image = compta.Properties.Resources.highlowlines_32x32;
		this.barLargeButtonItem12.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barLargeButtonItem12.ImageOptions.LargeImage");
		this.barLargeButtonItem12.Name = "barLargeButtonItem12";
		this.barLargeButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barLargeButtonItem12_ItemClick);
		this.barLargeButtonItem9.Caption = "Bilan";
		this.barLargeButtonItem9.Id = 47;
		this.barLargeButtonItem9.ImageOptions.Image = compta.Properties.Resources.paneloff_32x32;
		this.barLargeButtonItem9.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.L | System.Windows.Forms.Keys.Control);
		this.barLargeButtonItem9.Name = "barLargeButtonItem9";
		this.barLargeButtonItem9.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barLargeButtonItem9_ItemClick);
		this.barSubItem2.Caption = "Excel";
		this.barSubItem2.Id = 57;
		this.barSubItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.barSubItem2.ActAsDropDown = true;
		this.barSubItem2.DropDownControl = this.popupExcel;
		this.barSubItem2.Name = "barSubItem2";
		this.barSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;

		this.popupExcel.Manager = this.barManager1;
		this.popupExcel.Name = "popupExcel";
		this.popupExcel.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeBilanExcel),
			new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem10)
		});
		this.barLargeBilanExcel.Caption = "Bilan Excel";
		this.barLargeBilanExcel.Id = 52;
		this.barLargeBilanExcel.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barLargeBilanExcel.ImageOptions.Image");
		this.barLargeBilanExcel.Name = "barLargeBilanExcel";
		this.barLargeBilanExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barLargeBilanExcel_ItemClick);
		this.barLargeButtonItem10.Caption = "Divers Etats";
		this.barLargeButtonItem10.Id = 49;
		this.barLargeButtonItem10.ImageOptions.Image = compta.Properties.Resources.showworktimeonly_32x32;
		this.barLargeButtonItem10.Name = "barLargeButtonItem10";
		this.barLargeButtonItem10.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.barLargeButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barEdDiversEtats_ItemClick);
		this.barDockControlTop.CausesValidation = false;
		this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
		this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
		this.barDockControlTop.Manager = this.barManager1;
		this.barDockControlTop.Size = new System.Drawing.Size(979, 97);
		this.barDockControlBottom.CausesValidation = false;
		this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.barDockControlBottom.Location = new System.Drawing.Point(0, 540);
		this.barDockControlBottom.Manager = this.barManager1;
		this.barDockControlBottom.Size = new System.Drawing.Size(979, 23);
		this.barDockControlLeft.CausesValidation = false;
		this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
		this.barDockControlLeft.Location = new System.Drawing.Point(0, 97);
		this.barDockControlLeft.Manager = this.barManager1;
		this.barDockControlLeft.Size = new System.Drawing.Size(0, 443);
		this.barDockControlRight.CausesValidation = false;
		this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
		this.barDockControlRight.Location = new System.Drawing.Point(979, 97);
		this.barDockControlRight.Manager = this.barManager1;
		this.barDockControlRight.Size = new System.Drawing.Size(0, 443);
		this.barLinkContainerItem1.Caption = "--";
		this.barLinkContainerItem1.Id = 9;
		this.barLinkContainerItem1.Name = "barLinkContainerItem1";
		this.barButtonItem1.Caption = "Ecritures";
		this.barButtonItem1.Hint = "Ecritures Comptables";
		this.barButtonItem1.Id = 36;
		this.barButtonItem1.Name = "barButtonItem1";
		this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barButtonItem1_ItemClick_1);
		this.barButtonItem2.Caption = "barButtonItem2";
		this.barButtonItem2.Id = 37;
		this.barButtonItem2.Name = "barButtonItem2";
		this.barButtonItem3.Caption = "Journal";
		this.barButtonItem3.Id = 41;
		this.barButtonItem3.Name = "barButtonItem3";
		this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
		this.titre.Id = 48;
		this.titre.Name = "titre";
		this.titre.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barHeaderItem1_ItemClick);
		this.barButtonItem6.Caption = "Centralisation";
		this.barButtonItem6.Id = 59;
		this.barButtonItem6.Name = "barButtonItem6";
		this.barButtonItem7.Caption = "Bilan Comptable";
		this.barButtonItem7.Id = 62;
		this.barButtonItem7.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem7.ImageOptions.Image");
		this.barButtonItem7.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem7.ImageOptions.LargeImage");
		this.barButtonItem7.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control);
		this.barButtonItem7.Name = "barButtonItem7";
		this.barButtonItem8.Caption = "Bilan Fiscal";
		this.barButtonItem8.Id = 63;
		this.barButtonItem8.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem8.ImageOptions.Image");
		this.barButtonItem8.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem8.ImageOptions.LargeImage");
		this.barButtonItem8.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.Control);
		this.barButtonItem8.Name = "barButtonItem8";
		this.sharedImageCollection1.ImageSource.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("sharedImageCollection1.ImageSource.ImageStream");
		this.sharedImageCollection1.ImageSource.InsertImage(compta.Properties.Resources.images, "images", typeof(compta.Properties.Resources), 0);
		this.sharedImageCollection1.ImageSource.Images.SetKeyName(0, "images");
		this.sharedImageCollection1.ParentControl = this;
		this.barButtonItem4.Caption = "Journaux";
		this.barButtonItem4.Id = 23;
		this.barButtonItem4.Name = "barButtonItem4";
		this.barButtonItem5.Caption = "Journaux";
		this.barButtonItem5.Id = 23;
		this.barButtonItem5.Name = "barButtonItem5";
		this.barButtonItem9.Caption = "Dossier Comptabilité Client";
		this.barButtonItem9.Id = 66;
		this.barButtonItem9.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem9.ImageOptions.Image");
		this.barButtonItem9.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem9.ImageOptions.LargeImage");
		this.barButtonItem9.Name = "barButtonItem9";
		this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(barButtonItem9_ItemClick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(979, 563);
		base.Controls.Add(this.barDockControlLeft);
		base.Controls.Add(this.barDockControlRight);
		base.Controls.Add(this.barDockControlBottom);
		base.Controls.Add(this.barDockControlTop);
		base.IsMdiContainer = true;
		base.Name = "FrmPrincipale";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "ELDjawda Comptabilité";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FrmPrincipale_FormClosing);
		base.Load += new System.EventHandler(FrmPrincipale_Load);
		((System.ComponentModel.ISupportInitialize)this.barManager1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1.ImageSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.behaviorManager1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
