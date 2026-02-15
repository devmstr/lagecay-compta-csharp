using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using DevExpress.XtraGrid;

namespace compta;

public static class monModule
{
	public static bool cptmodifie = false;

	public static bool trsmodifie = false;

	public static bool piecemodifie = false;

	public static bool immomodifie = false;
	
	public static string gConnString;
	public static string gExcelPath;

	public static string[] gMois = new string[13]
	{
		"", "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre",
		"Octobre", "Novembre", "Decembre"
	};

	public static int eMOIS;

	public static int eDu;

	public static int eAU;

	public static string eUNILIB;

	public static string eCPTLIB;

	public static string eCPT;

	public static string eExercice;

	public static string eUNI;

	public static bool gRestart;

	public static string gFile;

	public static string gUNI = "";

	public static string gUNILIB;

	public static int gExercice;

	public static string gFormule;

	public static string gnumlot;

	public static string gCPT = "";

	public static string gTRS = "";

	public static string gNOP = "";

	public static string gJA = "";

	public static bool enter = false;

	public static OleDbTransaction txn;

	public static OleDbConnection gbase = new OleDbConnection();

	public static OleDbDataAdapter adEmploye;

	public static OleDbDataAdapter adTransfert;

	public static OleDbDataAdapter adTypeTransfert;

	public static OleDbDataAdapter adDossiers;

	public static OleDbDataAdapter adFournisseur;

	public static OleDbDataAdapter adLesMois;

	public static OleDbDataAdapter adModepaiement;

	public static OleDbDataAdapter adComptes;

	public static OleDbDataAdapter adEcritures_T;

	public static OleDbDataAdapter adVilles;

	public static OleDbDataAdapter adRecette;

	public static OleDbDataAdapter adBQE;

	public static OleDbDataAdapter adJournaux;

	public static OleDbDataAdapter adDocument;

	public static OleDbDataAdapter adDepense;

	public static OleDbDataAdapter adTypeOperation;

	public static OleDbDataAdapter adEntreprise;

	public static OleDbDataAdapter adLotRappel;

	public static OleDbDataAdapter adDetRecette;

	public static OleDbDataAdapter adOperation;

	public static OleDbDataAdapter adDetDepense;

	public static OleDbDataAdapter adArticle;

	public static OleDbCommandBuilder clbEmploye;

	public static OleDbCommandBuilder clbTransfert;

	public static OleDbCommandBuilder clbTypeTransfert;

	public static OleDbCommandBuilder clbDossiers;

	public static OleDbCommandBuilder clbFournisseur;

	public static OleDbCommandBuilder clbLesMois;

	public static OleDbCommandBuilder clbModepaiement;

	public static OleDbCommandBuilder clbComptes;

	public static OleDbCommandBuilder clbEcritures_T;

	public static OleDbCommandBuilder clbVilles;

	public static OleDbCommandBuilder clbRecette;

	public static OleDbCommandBuilder clbBQE;

	public static OleDbCommandBuilder clbJournaux;

	public static OleDbCommandBuilder clbDocument;

	public static OleDbCommandBuilder clbDepense;

	public static OleDbCommandBuilder clbTypeOperation;

	public static OleDbCommandBuilder clbEntreprise;

	public static OleDbCommandBuilder clbLotRappel;

	public static OleDbCommandBuilder clbDetRecette;

	public static OleDbCommandBuilder clbOperation;

	public static OleDbCommandBuilder clbDetDepense;

	public static OleDbCommandBuilder clbArticle;

	public static DataTable dtEmploye = new DataTable();

	public static DataTable dtTransfert = new DataTable();

	public static DataTable dtTypeTransfert = new DataTable();

	public static DataTable dtDossiers = new DataTable();

	public static DataTable dtFournisseur = new DataTable();

	public static DataTable dtLesMois = new DataTable();

	public static DataTable dtModepaiement = new DataTable();

	public static DataTable dtComptes = new DataTable();

	public static DataTable dtEcritures_T = new DataTable();

	public static DataTable dtVilles = new DataTable();

	public static DataTable dtRecette = new DataTable();

	public static DataTable dtBQE = new DataTable();

	public static DataTable dtJournaux = new DataTable();

	public static DataTable dtDocument = new DataTable();

	public static DataTable dtDepense = new DataTable();

	public static DataTable dtTypeOperation = new DataTable();

	public static DataTable dtEntreprise = new DataTable();

	public static DataTable dtLotRappel = new DataTable();

	public static DataTable dtDetRecette = new DataTable();

	public static DataTable dtOperation = new DataTable();

	public static DataTable dtDetDepense = new DataTable();

	public static DataTable dtArticle = new DataTable();

	public static DataSet ds = new DataSet();

	public static DataTable returnTable(string queryString)
	{
		DataTable table = new DataTable();
		if (gbase.State == ConnectionState.Closed)
		{
			return table;
		}
		using OleDbCommand cmd = new OleDbCommand(queryString, gbase);
		cmd.CommandType = CommandType.Text;
		table.Clear();
		using OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
		sda.Fill(table);
		return table;
	}

	public static void refreshTable(DataTable table, string queryString)
	{
		using OleDbCommand cmd = new OleDbCommand(queryString, gbase);
		cmd.CommandType = CommandType.Text;
		table.Clear();
		using OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
		sda.Fill(table);
	}

	public static void FermerBase()
	{
		if (gbase.State == ConnectionState.Open)
		{
			gbase.Close();
		}
		gFile = "";
		dtEmploye.Clear();
		dtDossiers.Clear();
		dtLesMois.Clear();
		dtJournaux.Clear();
		dtComptes.Clear();
		dtEcritures_T.Clear();
		dtFournisseur.Clear();
		dtVilles.Clear();
		dtModepaiement.Clear();
		dtTypeTransfert.Clear();
		dtTransfert.Clear();
		dtDepense.Clear();
		dtTypeOperation.Clear();
		dtBQE.Clear();
		dtDetDepense.Clear();
		dtArticle.Clear();
	}

	public static int GetLastID()
	{
		if (gbase.State == ConnectionState.Closed)
		{
			gbase.Open();
		}
		return (int)new OleDbCommand("SELECT @@identity", gbase).ExecuteScalar();
	}

	public static object GetFirstID(DataTable dt, string col)
	{
		if (dt.Rows.Count == 0)
		{
			return DBNull.Value;
		}
		return dt.Rows[0][col];
	}

	public static Dictionary<string, int> maxLength(string table)
	{
		Dictionary<string, int> maxLen = new Dictionary<string, int>();
		using OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + table + " WHERE 1=2", gbase);
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd);
		DataTable test = new DataTable();
		oleDbDataAdapter.FillSchema(test, SchemaType.Source);
		for (int x = 0; x < test.Columns.Count; x++)
		{
			DataColumn dc = test.Columns[x];
			if (dc.DataType == Type.GetType("System.String"))
			{
				maxLen.Add(dc.ColumnName, dc.MaxLength);
			}
		}
		return maxLen;
	}

	public static Dictionary<string, bool> MiseAjour(DataTable dt)
	{
		Dictionary<string, bool> maj = new Dictionary<string, bool>();
		using OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + dt.TableName + " WHERE 1=2", gbase);
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd);
		DataTable test = new DataTable();
		oleDbDataAdapter.FillSchema(test, SchemaType.Source);
		for (int x = 0; x < test.Columns.Count; x++)
		{
			DataColumn dc = test.Columns[x];
			maj.Add(dc.ColumnName, value: false);
		}
		return maj;
	}

	public static Dictionary<string, int> maxLength(DataTable dt)
	{
		Dictionary<string, int> maxLen = new Dictionary<string, int>();
		using OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + dt.TableName + " WHERE 1=2", gbase);
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(cmd);
		DataTable test = new DataTable();
		oleDbDataAdapter.FillSchema(test, SchemaType.Source);
		for (int x = 0; x < test.Columns.Count; x++)
		{
			DataColumn dc = test.Columns[x];
			if (dc.DataType == Type.GetType("System.String"))
			{
				maxLen.Add(dc.ColumnName, dc.MaxLength);
			}
			if (dc.AutoIncrement)
			{
				dt.Columns[dc.ColumnName].AutoIncrement = true;
			}
		}
		return maxLen;
	}

	public static DataRow CurrentRow(GridControl aGrid)
	{
		return ((DataRowView)((CurrencyManager)aGrid.BindingContext[aGrid.DataSource, aGrid.DataMember]).Current).Row;
	}

	public static long DiffdateAF(object sdx1, object sdx2, bool a15)
	{
		if (sdx1 == null || sdx2 == null)
		{
			return 0L;
		}
		DateTime dx1 = Convert.ToDateTime(sdx1.ToString());
		DateTime dx2 = Convert.ToDateTime(sdx2.ToString());
		long m = 0L;
		if (a15)
		{
			if (dx1.Day < 15)
			{
				m = -1L;
			}
			if (dx2.Day < 15)
			{
				m--;
			}
			long b = (dx2.Year - dx1.Year) * 12 + dx2.Month - dx1.Month;
			return 30 * (b + 1) + 30 * m;
		}
		long b2 = (dx2.Year - dx1.Year) * 12 + dx2.Month - dx1.Month;
		return 30 * (b2 + 1);
	}

	public static string Suivant(string S, bool Num = false)
	{
		if (S == string.Empty)
		{
			return S;
		}
		if (!Num)
		{
			if (S.Substring(S.Length - 1).ToUpper() == "Z")
			{
				return Suivant(S.Substring(0, S.Length - 1), Num) + "0";
			}
			if (S.Substring(S.Length - 1).ToUpper() == "9")
			{
				return S.Substring(0, S.Length - 1) + "A";
			}
			return S.Substring(0, S.Length - 1) + (char)(S[S.Length - 1] + 1);
		}
		if (S.Substring(S.Length - 1).ToUpper() == "9")
		{
			return Suivant(S.Substring(0, S.Length - 1), Num) + "0";
		}
		return S.Substring(0, S.Length - 1) + (char)(S[S.Length - 1] + 1);
	}

	public static long Diffdate(object sdx1, object sdx2)
	{
		int s = 0;
		int t = 0;
		if (sdx1 == null || sdx2 == null)
		{
			return 0L;
		}
		DateTime dx1 = Convert.ToDateTime(sdx1.ToString());
		DateTime dx2 = Convert.ToDateTime(sdx2.ToString());
		int ld1 = Convert.ToDateTime("01-" + dx1.Month + "-" + dx1.Year).AddMonths(1).AddDays(-1.0)
			.Day;
		if (ld1 == dx1.Day)
		{
			s = 30 - ld1 + 1;
			if (s <= 0)
			{
				s = 1;
			}
			dx1 = dx1.AddDays(1.0);
		}
		if (dx2.Day == 1)
		{
			t = 1;
			dx2 = dx2.AddDays(-1.0);
		}
		ld1 = Convert.ToDateTime("01-" + dx1.Month + "-" + dx1.Year).AddDays(-1.0).AddMonths(1)
			.Day;
		int ld2 = Convert.ToDateTime("01-" + dx2.Month + "-" + dx2.Year).AddDays(-1.0).AddMonths(1)
			.Day;
		long b;
		int y;
		int x;
		if (Convert.ToDateTime("01-" + dx1.Month + "-" + dx1.Year) == Convert.ToDateTime("01-" + dx2.Month + "-" + dx2.Year))
		{
			int jourf = ((dx2.Day != ld2) ? dx2.Day : 30);
			int jourd = ((dx1.Day != ld1) ? dx1.Day : 30);
			b = 0L;
			y = 0;
			x = jourf - jourd + 1;
		}
		else
		{
			DateTime d1;
			if (dx1.Day == ld1)
			{
				x = 1;
				d1 = dx1;
			}
			else if (dx1.Day == 1)
			{
				x = 0;
				d1 = dx1.AddDays(-1.0);
			}
			else
			{
				x = 31 - dx1.Day;
				d1 = Convert.ToDateTime("01-" + dx1.Month + "-" + dx1.Year).AddDays(-1.0).AddMonths(1);
			}
			DateTime d2;
			if (dx2.Day == Convert.ToDateTime("01-" + dx2.Month + "-" + dx2.Year).AddDays(-1.0).AddMonths(1)
				.Day)
			{
				y = 0;
				d2 = dx2;
			}
			else
			{
				y = dx2.Day;
				d2 = Convert.ToDateTime("01-" + dx2.Month + "-" + dx2.Year).AddDays(-1.0);
			}
			b = (d2.Year - d1.Year) * 12 + d2.Month - d1.Month;
		}
		return b * 30 + x + y + s + t;
	}

	public static void Execute(string sql)
	{
		try
		{
			using OleDbCommand cmd = new OleDbCommand(sql, gbase);
			cmd.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "خطأ في قاعدة المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	public static void MakeBalance()
	{
		using OleDbConnection gbase = new OleDbConnection(monModule.gConnString);
		OleDbCommand cmd = new OleDbCommand();
		OleDbTransaction transaction = null;
		cmd.CommandType = CommandType.Text;
		gbase.Open();
		cmd.Connection = gbase;
		try
		{
			transaction = (cmd.Transaction = gbase.BeginTransaction());
			cmd.CommandText = "Delete * from Balance";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Balance ( CPT, DEB, CRE, UNI, Exercice ) " + $" SELECT Ecritures.CPT AS CPT, IIf((Sum(Ecritures.DEB)-Sum(Ecritures.CRE))>0,Sum(Ecritures.DEB)-Sum(Ecritures.CRE),0) AS SDEB, IIf((Sum(Ecritures.DEB)-Sum(Ecritures.CRE))<0,Sum(Ecritures.CRE)-Sum(Ecritures.DEB),0) AS SCRE, '{gUNI}' AS Expr1,{gExercice} AS Expr2 " + " From Ecritures " + $" WHERE (((Ecritures.UNI)='{gUNI}') AND ((Ecritures.Exercice)={gExercice})) " + " GROUP BY Ecritures.CPT;";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Balance ( CPT, DEB, CRE, UNI, Exercice ) " + $" SELECT Ecritures.CPT AS CPT, IIf((Sum(Ecritures.DEB)-Sum(Ecritures.CRE))>0,Sum(Ecritures.DEB)-Sum(Ecritures.CRE),0) AS SDEB, IIf((Sum(Ecritures.DEB)-Sum(Ecritures.CRE))<0,Sum(Ecritures.CRE)-Sum(Ecritures.DEB),0) AS SCRE, '{gUNI}' AS Expr1,{gExercice - 1} AS Expr2 " + " From Ecritures " + $" WHERE (((Ecritures.UNI)='{gUNI}') AND ((Ecritures.Exercice)={gExercice - 1})) " + " GROUP BY Ecritures.CPT;";
			cmd.ExecuteNonQuery();
			transaction.Commit();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			transaction.Rollback();
		}
	}

	public static void Cloturer()
	{
		if (DateTime.ParseExact($"31-12-{gExercice}", "dd-MM-yyyy", null) > DateTime.Today)
		{
			return;
		}
		using OleDbConnection gbase = new OleDbConnection(monModule.gConnString);
		OleDbCommand cmd = new OleDbCommand();
		OleDbTransaction transaction = null;
		cmd.CommandType = CommandType.Text;
		gbase.Open();
		cmd.Connection = gbase;
		try
		{
			transaction = (cmd.Transaction = gbase.BeginTransaction());
			cmd.CommandText = "Delete * from Ecritures00";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Ecritures00  ( UNI, CPT, TRS, DEB, CRE, LIB, DAT, Jour, NOP, JA, Exercice ) " + $" SELECT clotureTiers.UNI, clotureTiers.CPT, clotureTiers.TRS, clotureTiers.SommeDeDEB, clotureTiers.SommeDeCRE, ' REOUVERTURE ' AS Expr1, #01-01-{gExercice + 1}# AS Expr2, 1 AS Expr3, '000001' AS Expr4, '00' AS Expr5,  {gExercice + 1} as Exercice " + " FROM [SELECT Ecritures.CPT, Ecritures.TRS, Ecritures.CPT, Sum(Ecritures.DEB)-Sum(Ecritures.CRE) AS SommeDeDEB, Sum(Ecritures.CRE)-Sum(Ecritures.DEB) AS SommeDeCRE, Ecritures.UNI  FROM Tiers INNER JOIN (Comptes INNER JOIN Ecritures ON Comptes.CPT=Ecritures.CPT) ON (Tiers.TRS=Ecritures.TRS and Tiers.UNI=Ecritures.UNI) " + $" Where (Ecritures.UNI='{gUNI}' And Ecritures.exercice ={gExercice}) AND (Ecritures.CPT>='1' and Ecritures.CPT<'6' ) " + " GROUP BY Ecritures.CPT, Ecritures.TRS, Ecritures.CPT, Ecritures.UNI, Ecritures.Exercice ORDER BY Ecritures.CPT, Ecritures.TRS]. as clotureTiers   Order BY Ecritures.CPT ";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Update Ecritures00 set LIG=ID";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Update Ecritures00 set DEB=0 where DEB<0";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Update Ecritures00 set CRE=0 where CRE<0";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Select sum(deb)-sum(cre) from Ecritures00";
			object o = cmd.ExecuteScalar();
			decimal sd = default(decimal);
			decimal sc = default(decimal);
			decimal x = ((o == null) ? 0m : Convert.ToDecimal(o));
			if (x < 0m)
			{
				sd = Math.Abs(x);
			}
			else
			{
				sc = Math.Abs(x);
			}
			cmd.CommandText = $"Delete * from Pieces where JA='00' and UNI='{gUNI}' and Exercice={gExercice + 1}";
			cmd.ExecuteNonQuery();
			cmd.CommandText = $"Delete * from Ecritures where JA='00' and UNI='{gUNI}' and Exercice={gExercice + 1}";
			cmd.ExecuteNonQuery();
			cmd.CommandText = $"INSERT INTO pieces ( UNI, JA, NOP, Dat, Mois, Exercice ) SELECT '{gUNI}' as UNI, '00' AS JA, '000001' AS NOP, #01-01-{gExercice + 1}# AS dat, 1 AS MOIS, {gExercice + 1} as Exercice FROM Dossiers where Dossiers.UNI='{gUNI}' ";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "insert into Ecritures   ( UNI, CPT, TRS, DEB, CRE, LIB, DAT, Jour, NOP, JA, Exercice ) Select UNI, CPT, TRS, DEB, CRE, LIB, DAT, Jour, NOP, JA, Exercice From Ecritures00 WHERE CPT<'600000' and DEB<>CRE ";
			cmd.ExecuteNonQuery();
			cmd.CommandText = $"insert into Ecritures   ( UNI, CPT, TRS, DEB, CRE, LIB, DAT, Jour, NOP, JA, Exercice ) Select top 1 UNI, '12000' as CPT, '-' as TRS, {sd} as DEB, {sc} as CRE, ' Résultat ' as  LIB, #01-01-{gExercice + 1}# as DAT, 1 as Jour, '000001' as NOP, '00' as JA, {gExercice + 1} as Exercice from Ecritures00";
			cmd.ExecuteNonQuery();
			cmd.CommandText = $"Update Ecritures set LIG=ID where UNI='{gUNI}' and  JA='00' and Exercice={gExercice + 1}";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Update Ecritures00 set CRE=0 where CRE<0";
			cmd.ExecuteNonQuery();
			transaction.Commit();
			MessageBox.Show($"La clôture de l'exercice {gExercice} a été effectuée ");
			gExercice++;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			transaction.Rollback();
		}
	}

	public static void OuvrirTables()
	{
		try
		{
			CheckEnvironment();
			if (gbase.State == ConnectionState.Open)
			{
				gbase.Close();
			}
			gbase.ConnectionString = gConnString;
			gbase.Open();
			adDossiers = new OleDbDataAdapter("Select * from Dossiers order by UNI", gbase);
			clbDossiers = new OleDbCommandBuilder(adDossiers);
			dtDossiers.Clear();
			adDossiers.Fill(ds, "Dossiers");
			dtDossiers = ds.Tables["Dossiers"];
			adLesMois = new OleDbDataAdapter("Select * from LesMois where Mois<>0", gbase);
			clbLesMois = new OleDbCommandBuilder(adLesMois);
			dtLesMois.Clear();
			adLesMois.Fill(ds, "LesMois");
			dtLesMois = ds.Tables["LesMois"];
			adBQE = new OleDbDataAdapter("Select * from Journaux order by JA", gbase);
			clbJournaux = new OleDbCommandBuilder(adBQE);
			dtBQE.Clear();
			adBQE.Fill(ds, "Journaux");
			dtBQE = ds.Tables["Journaux"];
			adComptes = new OleDbDataAdapter("Select * from Comptes order by CPT", gbase);
			clbComptes = new OleDbCommandBuilder(adComptes);
			dtComptes.Clear();
			adComptes.Fill(ds, "Comptes");
			dtComptes = ds.Tables["Comptes"];
			adEcritures_T = new OleDbDataAdapter("Select * from Ecritures_t order by LIG", gbase);
			clbEcritures_T = new OleDbCommandBuilder(adEcritures_T);
			dtEcritures_T.Clear();
			adEcritures_T.Fill(ds, "Ecritures_t");
			dtEcritures_T = ds.Tables["Ecritures_t"];
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			Application.Exit();
		}
	}

	public static void CheckEnvironment()
	{
		// Senior Level Environment Manager
		// Ensures all directories and template files exist to avoid "File Not Found" errors.
		
		// 1. Define Paths (Global App Data is safe for writing without special permissions)
		string localData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		string appDataRoot = Path.Combine(localData, Application.ProductName); 
		string dataPath = Path.Combine(appDataRoot, "DATA");
		string excelPath = Path.Combine(appDataRoot, "EXCEL");
		
		// Installation path where the .exe and template live
		string appPath = Path.GetDirectoryName(Application.ExecutablePath);
		string templatePath = Path.Combine(appPath, "modele.mdb");

		// 2. Ensure Directories exist in ProgramData (Safe location)
		if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);
		if (!Directory.Exists(excelPath)) Directory.CreateDirectory(excelPath);

		// 3. Database File Path in the safe location
		string dbPath = Path.Combine(dataPath, "ComptaDB.mdb");
		string legacyDbPath = Path.Combine(appPath, "MyDatabase.mdb");

		// Copy template to the safe location if the actual database is missing
		if (!File.Exists(dbPath) && File.Exists(templatePath))
		{
			try {
				File.Copy(templatePath, dbPath, true);
			} catch { /* If file is locked, we can't do much here */ }
		}
		
		// ALWAYS ensure the working database is NOT read-only
		try {
			if (File.Exists(dbPath)) {
				File.SetAttributes(dbPath, FileAttributes.Normal);
			}
		} catch { }

		// Legacy Database (Required by some DevExpress report definitions)
		// We try to maintain this in the app folder for back-compat, but it's optional
		if (!File.Exists(legacyDbPath))
		{
			try {
				if (File.Exists(templatePath)) File.Copy(templatePath, legacyDbPath);
				else if (File.Exists(dbPath)) File.Copy(dbPath, legacyDbPath);
			} catch { /* Might fail due to permissions, which is expected for Program Files */ }
		}

		// 4. Set the Global Connection String (Bypassing App.Config limitations)
		gConnString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
		
		// Legacy support (optional: keep ConfigurationManager updated in-memory if possible)
		try {
			var connectionStrings = ConfigurationManager.ConnectionStrings;
			var field = typeof(ConfigurationElement).GetField("_readOnly", BindingFlags.Instance | BindingFlags.NonPublic);
			if (connectionStrings["MyBase"] != null) {
				field?.SetValue(connectionStrings["MyBase"], false);
				connectionStrings["MyBase"].ConnectionString = gConnString;
			}
		} catch { /* Silent fail */ }

		// 5. Excel Templates Handling
		string bilanTemplate = Path.Combine(appPath, "bilan.xlsx");
		string bilanFiscTemplate = Path.Combine(appPath, "bilanfisc.xlsx");
		
		string bilanDest = Path.Combine(excelPath, "bilan.xlsx");
		string bilanFiscDest = Path.Combine(excelPath, "bilanfisc.xlsx");

		// Copy Excel templates to the safe ProgramData EXCEL folder if missing
		try {
			if (!File.Exists(bilanDest) && File.Exists(bilanTemplate)) File.Copy(bilanTemplate, bilanDest);
			if (!File.Exists(bilanFiscDest) && File.Exists(bilanFiscTemplate)) File.Copy(bilanFiscTemplate, bilanFiscDest);
			
			if (File.Exists(bilanDest)) File.SetAttributes(bilanDest, FileAttributes.Normal);
			if (File.Exists(bilanFiscDest)) File.SetAttributes(bilanFiscDest, FileAttributes.Normal);
		} catch { /* Silent fail */ }

		// 6. Global State Update
		monModule.gFile = dbPath;
		monModule.gExcelPath = excelPath;
	}

	public static double SRound(double x, int i)
	{
		return Math.Round(x, i, MidpointRounding.AwayFromZero);
	}
}
