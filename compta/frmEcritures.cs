using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using compta.DataSet1TableAdapters;
using compta.Properties;
using DevExpress.Data;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace compta;

public class frmEcritures : XtraForm
{
	private PiecesTableAdapter adpiece = new PiecesTableAdapter();

	private TiersTableAdapter adtiers = new TiersTableAdapter();

	private ComptesTableAdapter adcomptes = new ComptesTableAdapter();

	private EcrituresTableAdapter adEcritures = new EcrituresTableAdapter();

	private DataSet1.PiecesDataTable dtpieces = new DataSet1.PiecesDataTable();

	private DataSet1.ComptesDataTable dtcomptes = new DataSet1.ComptesDataTable();

	private DataSet1.TiersDataTable dttiers = new DataSet1.TiersDataTable();

	private DataSet1.EcrituresDataTable dtEcritures = new DataSet1.EcrituresDataTable();

	private List<DataRowView> selectedRows = new List<DataRowView>();

	private bool del;

	private byte JOUR = 1;

	private byte MAXJOUR = 28;

	private byte MOIS;

	private int NOP;

	private string LIB = "-";

	private string JA = "00";

	private int LIG;

	private byte vMOIS = 1;

	private bool Nouveau;

	private bool parpiece;

	private bool canShowEditor = true;

	private IContainer components;

	private LayoutControl layoutControl1;

	private LayoutControlGroup Root;

	private DataSet1 dataSet1;

	private BindingSource journauxBindingSource;

	private JournauxTableAdapter journauxTableAdapter;

	private GridControl gridControl1;

	private TextEdit lib;

	private LayoutControlGroup layoutControlGroup1;

	private LayoutControlItem layoutControlItem4;

	private LayoutControlItem parbordereau;

	private LayoutControlItem layoutControlItem2;

	private LayoutControlGroup layoutControlGroup2;

	private LayoutControlItem layoutControlItem5;

	private TextEdit SOLDN;

	private TextEdit SOLCN;

	private TextEdit tier;

	private TextEdit Compte;

	private LayoutControlGroup layoutControlGroup3;

	private LayoutControlItem soldeN;

	private LayoutControlItem layoutControlItem11;

	private LayoutControlItem layoutControlItem12;

	private LayoutControlItem layoutControlItem13;

	private LookUpEdit mois;

	private BindingSource lesMoisBindingSource;

	private LesMoisTableAdapter lesMoisTableAdapter;

	private BindingSource ecriturestBindingSource;

	private Ecritures_tTableAdapter ecritures_tTableAdapter;

	private DateEdit dateEcriture;

	private LayoutControlItem pardate22;

	private DateEdit dat;

	private LayoutControlItem pardate;

	private BindingSource comptesBindingSource;

	private ComptesTableAdapter comptesTableAdapter;

	private RepositoryItemSpinEdit repositoryItemSpinEdit1;

	private RepositoryItemTextEdit repositoryItemTextEdit1;

	private BindingSource tiersBindingSource;

	private TiersTableAdapter tiersTableAdapter;

	private RepositoryItemSpinEdit repositoryItemSpinEdit2;

	private SimpleButton btnEnregistrer;

	private LayoutControlItem layoutControlItem10;

	private GridView gridView1;

	private GridColumn colUNI;

	private GridColumn colExercice;

	private GridColumn colLIG;

	private GridColumn colJA;

	private GridColumn colJour;

	private GridColumn colCPT;

	private GridColumn colTRS;

	private GridColumn colLIB;

	private GridColumn colDEB;

	private GridColumn colCRE;

	private EmptySpaceItem emptySpaceItem1;

	private GridColumn colNOP;

	private SpinEdit scre;

	private SpinEdit sdeb;

	private LayoutControlItem layoutControlItem14;

	private LayoutControlItem layoutControlItem15;

	private SimpleLabelItem simpleLabelItem1;

	private SimpleLabelItem simpleLabelItem2;

	private SimpleLabelItem txtSOLDN;

	private RepositoryItemTextEdit repositoryItemTextEdit3;

	private LayoutControlItem layoutControlItem16;

	private DXErrorProvider dxErrorProvider1;

	private EmptySpaceItem emptySpaceItem2;

	private EmptySpaceItem emptySpaceItem3;

	private RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit3;

	private GridView repositoryItemSearchLookUpEdit3View;

	private GridColumn colCPT1;

	private GridColumn colLIB1;

	private GridColumn colLIBAR;

	private RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;

	private GridView repositoryItemSearchLookUpEdit1View;

	private GridColumn colTRS1;

	private GridColumn colLIB2;

	private GridColumn colLIBAR1;

	private ImageCollection imageCollection1;

	private RepositoryItemTextEdit repositoryItemTextEdit2;

	private TextEdit jnl;

	private SpinEdit piece;

	private BehaviorManager behaviorManager1;

	private TextEdit DebitNM1;

	private TextEdit CreditNM1;

	private TextEdit DebitN;

	private TextEdit CreditN;

	private LayoutControlItem layoutControlItem1;

	private LayoutControlItem layoutControlItem3;

	private SimpleLabelItem simpleLabelItem3;

	private EmptySpaceItem emptySpaceItem4;

	private LayoutControlItem layoutControlItem6;

	private LayoutControlItem layoutControlItem7;

	private EmptySpaceItem emptySpaceItem5;

	private SimpleLabelItem simpleLabelItem4;

	private GridColumn colDAT;

	public frmEcritures(bool _parpiece = false)
	{
		InitializeComponent();
		parpiece = _parpiece;
	}

	private void frmEcritures_Load(object sender, EventArgs e)
	{
		if (parpiece)
		{
			parbordereau.Visibility = LayoutVisibility.Never;
			colJour.Visible = false;
		}
		else
		{
			pardate.Visibility = LayoutVisibility.Never;
			colJour.Visible = true;
		}
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		Console.WriteLine(connection);
		ecritures_tTableAdapter.Connection.ConnectionString = connection;
		journauxTableAdapter.Connection.ConnectionString = connection;
		lesMoisTableAdapter.Connection.ConnectionString = connection;
		comptesTableAdapter.Connection.ConnectionString = connection;
		tiersTableAdapter.Connection.ConnectionString = connection;
		adpiece.Connection.ConnectionString = connection;
		adtiers.Connection.ConnectionString = connection;
		adEcritures.Connection.ConnectionString = connection;
		adcomptes.Connection.ConnectionString = connection;
		tiersTableAdapter.FillByUNI1(dataSet1.Tiers, monModule.gUNI);
		comptesTableAdapter.Fill1(dataSet1.Comptes);
		journauxTableAdapter.Fill(dataSet1.Journaux);
		ecritures_tTableAdapter.Fill(dataSet1.Ecritures_t);
		lesMoisTableAdapter.Fill(dataSet1.LesMois);
		adcomptes.Fill1(dtcomptes);
		repositoryItemSearchLookUpEdit3.DataSource = dtcomptes;
		dataSet1.Ecritures_t.Columns["CPT"].DefaultValue = null;
		dataSet1.Ecritures_t.Columns["UNI"].DefaultValue = monModule.gUNI;
		dataSet1.Ecritures_t.Columns["TRS"].DefaultValue = "-";
		dataSet1.Ecritures_t.Columns["Exercice"].DefaultValue = monModule.gExercice;
		dataSet1.Ecritures_t.Columns["DAT"].DefaultValue = Convert.ToDateTime(monModule.gExercice + "-01-01");
		dat.Properties.NullDate = monModule.gExercice + "-01-01";
		adpiece.FillBy(dtpieces, monModule.gUNI, Convert.ToInt32(monModule.gExercice));
		adtiers.FillBy(dttiers, monModule.gUNI);
		gridControl1.DataSource = dataSet1.Ecritures_t;
		gridControl1.ForceInitialize();
		gridView1.ClearSorting();
		gridView1.Columns["LIG"].SortOrder = ColumnSortOrder.Ascending;
		dateEcriture.EditValue = DateTime.Today.ToString();
		jnl.EditValue = dataSet1.Journaux.Rows[0]["JA"];
		remplirPiece();
		Skin skin = CommonSkins.GetSkin(gridControl1.LookAndFeel);
		Color foreColor = skin.Colors.GetColor(CommonColors.WindowText);
		Color backColor = skin.Colors.GetColor(CommonColors.Window);
		tier.Properties.AppearanceDisabled.BackColor = backColor;
		tier.Properties.AppearanceDisabled.ForeColor = foreColor;
		Compte.Properties.AppearanceDisabled.BackColor = backColor;
		Compte.Properties.AppearanceDisabled.ForeColor = foreColor;
		SOLDN.Properties.AppearanceDisabled.BackColor = backColor;
		SOLDN.Properties.AppearanceDisabled.ForeColor = foreColor;
		SOLCN.Properties.AppearanceDisabled.BackColor = backColor;
		SOLCN.Properties.AppearanceDisabled.ForeColor = foreColor;
		sdeb.Properties.AppearanceDisabled.BackColor = backColor;
		sdeb.Properties.AppearanceDisabled.ForeColor = foreColor;
		scre.Properties.AppearanceDisabled.BackColor = backColor;
		scre.Properties.AppearanceDisabled.ForeColor = foreColor;
	}

	private void Remplir()
	{
		object obj = jnl.EditValue;
		if (obj == null)
		{
			JA = "";
			return;
		}
		JA = obj.ToString();
		obj = piece.EditValue;
		if (piece.Text == "" || piece.EditValue == null)
		{
			NOP = 0;
		}
		else
		{
			NOP = Convert.ToInt32(piece.EditValue);
		}
		DataRow[] foundRows = dtpieces.Select($"UNI='{monModule.gUNI}' AND Exercice={monModule.gExercice} AND NOP={NOP} AND JA='{JA}'");
		if (foundRows.Length != 0)
		{
			Nouveau = false;
			mois.EditValue = Convert.ToByte(foundRows[0]["Mois"]);
			MOIS = Convert.ToByte(foundRows[0]["Mois"]);
			vMOIS = (byte)((MOIS == 0) ? 1 : MOIS);
			dat.EditValue = Convert.ToDateTime(foundRows[0]["Dat"]);
			lib.EditValue = foundRows[0]["LIB"].ToString();
			LIB = foundRows[0]["LIB"].ToString();
			JOUR = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, vMOIS));
			MAXJOUR = JOUR;
			remplirPiece();
			return;
		}
		Nouveau = true;
		mois.Enabled = true;
		lib.Enabled = true;
		if (NOP == 0)
		{
			obj = dtpieces.Compute("Max(NOP)", "UNI='" + monModule.gUNI + "' AND Exercice=" + monModule.gExercice + " AND JA='" + JA + "'");
			if (obj == DBNull.Value)
			{
				NOP = 1;
			}
			else
			{
				NOP = Convert.ToInt32(obj);
				NOP++;
			}
			piece.EditValue = NOP;
		}
		MOIS = Convert.ToByte(Convert.ToInt32(NOP) % 13);
		if (parpiece)
		{
			dat.EditValue = Convert.ToDateTime("01-01-" + monModule.gExercice);
			mois.EditValue = 1;
			MAXJOUR = 31;
			JOUR = 1;
		}
		else
		{
			if (MOIS == 0)
			{
				MOIS = 1;
			}
			mois.EditValue = MOIS;
			vMOIS = (byte)((MOIS == 0) ? 1 : MOIS);
			JOUR = 1;
			MAXJOUR = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, vMOIS));
			dat.EditValue = Convert.ToDateTime("01-" + vMOIS + "-" + monModule.gExercice);
		}
		lib.EditValue = "";
		remplirPiece();
	}

	private void remplirPiece()
	{
		tier.EditValue = "";
		Compte.EditValue = "";
		SOLDN.EditValue = 0;
		SOLCN.EditValue = 0;
		btnEnregistrer.Enabled = true;
		string connectionString = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		OleDbCommand cmd = new OleDbCommand();
		OleDbTransaction transaction = null;
		cmd.CommandType = CommandType.Text;
		using (OleDbConnection gbase = new OleDbConnection(connectionString))
		{
			gbase.Open();
			cmd.Connection = gbase;
			cmd.Transaction = transaction;
			cmd.CommandText = "Delete * from Ecritures_t";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "Insert Into Ecritures_t  Select * from Ecritures WHERE Ecritures.UNI='" + monModule.gUNI + "' and  Ecritures.JA='" + JA + "' and Ecritures.NOP=" + NOP + "  AND Exercice=" + monModule.gExercice;
			cmd.ExecuteNonQuery();
		}
		repositoryItemSpinEdit1.MaxValue = MAXJOUR;
		dataSet1.Ecritures_t.Clear();
		ecritures_tTableAdapter.Fill(dataSet1.Ecritures_t);
		if (NOP != 0 && dataSet1.Ecritures_t.Rows.Count == 0)
		{
			DataRow row = dataSet1.Ecritures_t.NewRow();
			row["LIG"] = 0;
			row["JA"] = JA;
			row["NOP"] = NOP;
			row["CPT"] = null;
			row["TRS"] = "-";
			row["DEB"] = 0;
			row["CRE"] = 0;
			row["LIB"] = LIB;
			row["UNI"] = monModule.gUNI;
			row["Exercice"] = monModule.gExercice;
			if (parpiece)
			{
				row["Jour"] = Convert.ToByte(Convert.ToDateTime(dat.EditValue).Day);
				row["DAT"] = dat.EditValue;
			}
			else
			{
				row["Jour"] = JOUR;
			}
			dataSet1.Ecritures_t.Rows.Add(row);
			gridView1.FocusedColumn = gridView1.Columns["Jour"];
		}
	}

	private void lib_Validating(object sender, CancelEventArgs e)
	{
		remplirPiece();
	}

	private void gridView1_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
	{
		ColumnView view = sender as ColumnView;
		string fieldName = ((e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn).FieldName;
		if (!(fieldName == "CPT"))
		{
			if (!(fieldName == "TRS"))
			{
				return;
			}
			object rowCellValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CPT");
			if (rowCellValue == null)
			{
				e.Valid = false;
			}
			string s = rowCellValue.ToString();
			DataRow[] ro = dataSet1.Comptes.Select("CPT='" + s + "' AND TRS='O' ");
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ " + s + "  ++++ " + ro.Length);
			if (ro.Length != 0)
			{
				s = e.Value.ToString();
				if (dataSet1.Tiers.Select("TRS='" + s + "' AND TRS<>'-' AND UNI='" + monModule.gUNI + "'").Length == 0)
				{
					e.Valid = false;
				}
			}
			else
			{
				e.Valid = false;
			}
		}
		else
		{
			string s = e.Value.ToString();
			if (dataSet1.Comptes.Select("CPT='" + s + "' AND IMPUT='O'").Length == 0)
			{
				e.Valid = false;
			}
		}
	}

	private void gridView1_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
	{
		if (!(sender is ColumnView view))
		{
			return;
		}
		e.ExceptionMode = ExceptionMode.DisplayError;
		string fieldName = view.FocusedColumn.FieldName;
		if (!(fieldName == "CPT"))
		{
			if (fieldName == "TRS")
			{
				e.WindowCaption = "Erreur de saisie";
				e.ErrorText = "Code Tiers inéxistant ??????";
			}
		}
		else
		{
			e.WindowCaption = "Erreur de saisie";
			e.ErrorText = "Compte d'imputation inéxistant ";
		}
		view.HideEditor();
	}

	private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
	{
		GridView view = sender as GridView;
		if (e.Column.FieldName == "CPT")
		{
			object t = view.GetRowCellValue(view.FocusedRowHandle, "CPT");
			if (t == null || t.ToString() == "")
			{
				return;
			}
			string s = ((t == null) ? "" : t.ToString());
			DataRow[] ro = dataSet1.Comptes.Select("CPT='" + s + "' AND IMPUT='O'");
			if (ro.Length != 0)
			{
				if (ro[0]["TRS"].ToString() == "N")
				{
					view.SetRowCellValue(e.RowHandle, view.Columns["TRS"], "-");
					view.Columns["TRS"].OptionsColumn.AllowFocus = false;
					view.Columns["TRS"].OptionsColumn.AllowEdit = false;
				}
				else
				{
					view.Columns["TRS"].OptionsColumn.AllowFocus = true;
					view.Columns["TRS"].OptionsColumn.AllowEdit = true;
				}
			}
		}
		if (e.Column.FieldName == "TRS")
		{
			object t2 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CPT");
			if (t2 == null)
			{
				return;
			}
			string s2 = t2.ToString();
			if (dataSet1.Comptes.Select("CPT='" + s2 + "' AND IMPUT='O' AND TRS='O' ").Length != 0)
			{
				s2 = e.Value.ToString();
				if (dataSet1.Tiers.Select("TRS='" + s2 + "' AND TRS<>'-' AND UNI='" + monModule.gUNI + "'").Length == 0)
				{
					return;
				}
			}
		}
		if (e.Column.FieldName == "CRE")
		{
			object t3 = view.GetRowCellValue(view.FocusedRowHandle, "CRE");
			if (((t3 == null) ? 0.0 : Convert.ToDouble(t3)) != 0.0)
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["DEB"], 0);
			}
		}
		if (e.Column.FieldName == "DEB")
		{
			object t4 = view.GetRowCellValue(view.FocusedRowHandle, "DEB");
			if (((t4 == null) ? 0.0 : Convert.ToDouble(t4)) != 0.0)
			{
				view.SetRowCellValue(e.RowHandle, view.Columns["CRE"], 0);
			}
		}
		if (e.Column.FieldName == "Jour")
		{
			object t5 = view.GetRowCellValue(view.FocusedRowHandle, "Jour");
			int s3 = ((t5 == null) ? 1 : Convert.ToInt32(t5));
			int x = Convert.ToInt32(mois.EditValue);
			if (x == 0)
			{
				x = 1;
			}
			MAXJOUR = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, x));
			if (s3 > MAXJOUR)
			{
				s3 = MAXJOUR;
			}
			Console.WriteLine(monModule.gExercice + "-" + vMOIS + "-" + s3);
			view.SetRowCellValue(e.RowHandle, view.Columns["DAT"], Convert.ToDateTime(monModule.gExercice + "-" + vMOIS + "-" + s3));
		}
		Solde();
	}

	private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
	{
		e.Cancel = !canShowEditor;
		canShowEditor = true;
	}

	private void gridView1_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
	{
	}

	private void DoSomething(GridView gridView1, int FocusedRowHandle, int PrevFocusedRowHandle, GridColumn FocusedColumn, GridColumn PrevFocusedColumn)
	{
		monModule.gNOP = "";
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOP");
		monModule.gNOP = ((t == null) ? "" : t.ToString());
		monModule.gCPT = "";
		t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CPT");
		if (t == null)
		{
			gridView1.SetRowCellValue(FocusedRowHandle, gridView1.Columns["TRS"], "-");
			gridView1.Columns["TRS"].OptionsColumn.AllowFocus = false;
			gridView1.Columns["TRS"].OptionsColumn.AllowEdit = false;
			return;
		}
		string s = (monModule.gCPT = t.ToString());
		monModule.gTRS = "";
		DataRow[] ro = dataSet1.Comptes.Select("CPT='" + s + "' AND IMPUT='O'");
		if (ro.Length != 0)
		{
			monModule.gTRS = ro[0]["TRS"].ToString();
			if (ro[0]["TRS"].ToString() == "N")
			{
				gridView1.SetRowCellValue(FocusedRowHandle, gridView1.Columns["TRS"], "-");
				gridView1.Columns["TRS"].OptionsColumn.AllowFocus = false;
				gridView1.Columns["TRS"].OptionsColumn.AllowEdit = false;
			}
			else
			{
				gridView1.Columns["TRS"].OptionsColumn.AllowFocus = true;
				gridView1.Columns["TRS"].OptionsColumn.AllowEdit = true;
			}
		}
	}

	private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
		try
		{
			GridView view = sender as GridView;
			if (view.RowCount == 0)
			{
				return;
			}
			object o = view.GetRowCellValue(e.PrevFocusedRowHandle, "CPT");
			if (o == null || o.ToString() == "")
			{
				view.FocusedRowHandle = e.PrevFocusedRowHandle;
				view.FocusedColumn = view.Columns["Jour"];
			}
			else if (!del)
			{
				if (e.FocusedRowHandle == -2147483647)
				{
					gridView1.RefreshData();
					object t = gridView1.GetRowCellValue(e.PrevFocusedRowHandle, "Jour");
					JOUR = ((t != DBNull.Value && t != null) ? Convert.ToByte(t) : Convert.ToByte(1));
					t = gridView1.GetRowCellValue(e.PrevFocusedRowHandle, "LIB");
					LIB = ((t != DBNull.Value && t != null) ? t.ToString() : lib.Text);
					t = gridView1.GetRowCellValue(e.FocusedRowHandle, "LIG");
					LIG = ((t == DBNull.Value || t == null) ? 1 : Convert.ToInt32(t));
				}
				else
				{
					Solde();
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + "  " + e.FocusedRowHandle + " " + e.PrevFocusedRowHandle);
		}
	}

	private void Journal_Validated(object sender, EventArgs e)
	{
		lib.EditValue = "";
		dat.EditValue = Convert.ToDateTime("01-01-" + monModule.gExercice);
		mois.EditValue = 1;
		Remplir();
		piece.Focus();
	}

	private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e)
	{
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CPT");
		if (t == null)
		{
			e.ErrorText = "Erreur de saisie du Compte ";
			e.Valid = false;
			return;
		}
		t.ToString();
		double num = Convert.ToDouble(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DEB"));
		double y = Convert.ToDouble(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CRE"));
		if (num == 0.0 && y == 0.0)
		{
			e.Valid = true;
			return;
		}
		t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CPT");
		if (t.ToString().StartsWith("21"))
		{
			if (XtraMessageBox.Show("Voulez-vous mettre à jour les investissements ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				e.Valid = true;
			}
			else
			{
				frmAmortissement obj = new frmAmortissement(add: true);
				obj.ShowDialog();
				obj.Dispose();
				e.Valid = true;
			}
		}
		e.Valid = true;
	}

	private void Solde()
	{
		OleDbCommand cmd = new OleDbCommand();
		string cpt = "";
		decimal soldeDN = default(decimal);
		decimal soldeCN = default(decimal);
		Compte.EditValue = "";
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CPT");
		if (t != null)
		{
			cpt = t.ToString();
			dataSet1.Comptes.Clear();
			comptesTableAdapter.Fill(dataSet1.Comptes);
			DataRow[] foundRows = dataSet1.Comptes.Select("CPT='" + cpt + "'");
			Compte.EditValue = ((foundRows.Length == 0) ? "" : foundRows[0]["LIB"]);
			tier.EditValue = "";
			t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TRS");
			if (t != null)
			{
				foundRows = dttiers.Select("TRS='" + t.ToString() + "'");
				tier.EditValue = ((foundRows.Length == 0) ? "" : foundRows[0]["LIB"]);
			}
			t = dataSet1.Ecritures_t.Compute("COUNT(CPT)", "CPT IS  NULL");
			int nb = ((t != DBNull.Value) ? Convert.ToInt32(t) : 0);
			t = dataSet1.Ecritures_t.Compute("SUM(DEB)", "CPT='" + cpt + "' ");
			decimal deb = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			t = dataSet1.Ecritures_t.Compute("SUM(CRE)", "CPT='" + cpt + "' ");
			decimal cre = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			scre.Visible = false;
			sdeb.Visible = false;
			_ = deb - cre;
			decimal d = default(decimal);
			decimal c = default(decimal);
			t = dataSet1.Ecritures_t.Compute("SUM(DEB)", "");
			d = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			t = dataSet1.Ecritures_t.Compute("SUM(CRE)", "");
			c = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			if (d > c)
			{
				sdeb.EditValue = d - c;
				scre.EditValue = 0;
				scre.Visible = false;
				sdeb.Visible = true;
			}
			else
			{
				scre.EditValue = c - d;
				sdeb.EditValue = 0;
				scre.Visible = true;
				sdeb.Visible = false;
			}
			btnEnregistrer.Enabled = c == d && nb == 0;
			cmd.Connection = monModule.gbase;
			cmd.CommandText = "Select sum(deb)  from Ecritures  Where UNI='" + monModule.gUNI + "' and  JA='00' and CPT='" + cpt + "' and EXercice=" + monModule.gExercice;
			t = cmd.ExecuteScalar();
			decimal debNm1 = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			cmd.CommandText = "Select sum(cre)  from Ecritures  Where UNI='" + monModule.gUNI + "' and  JA='00' and CPT='" + cpt + "' and EXercice=" + monModule.gExercice;
			t = cmd.ExecuteScalar();
			decimal creNm1 = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			DebitNM1.EditValue = debNm1;
			CreditNM1.EditValue = creNm1;
			cmd.CommandText = "Select sum(deb)  from Ecritures  Where NOP=" + NOP + " and UNI='" + monModule.gUNI + "' and  JA='" + JA + "'   and CPT='" + cpt + "' and EXercice=" + monModule.gExercice;
			t = cmd.ExecuteScalar();
			decimal adeb = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			cmd.CommandText = "Select sum(cre)  from Ecritures  Where NOP=" + NOP + " and UNI='" + monModule.gUNI + "' and  JA='" + JA + "'   and CPT='" + cpt + "' and EXercice=" + monModule.gExercice;
			t = cmd.ExecuteScalar();
			decimal acre = ((t == DBNull.Value) ? 0m : Convert.ToDecimal(t));
			cmd.CommandText = "Select sum(deb)  from Ecritures  Where UNI='" + monModule.gUNI + "' and  JA<>'00' and CPT='" + cpt + "' and EXercice=" + monModule.gExercice;
			t = cmd.ExecuteScalar();
			decimal debN = ((t == DBNull.Value) ? 0m : (Convert.ToDecimal(t) - adeb));
			cmd.CommandText = "Select sum(cre)  from Ecritures  Where UNI='" + monModule.gUNI + "' and  JA<>'00' and CPT='" + cpt + "' and EXercice=" + monModule.gExercice;
			t = cmd.ExecuteScalar();
			decimal creN = ((t == DBNull.Value) ? 0m : (Convert.ToDecimal(t) - acre));
			soldeDN = default(decimal);
			soldeCN = default(decimal);
			if (debNm1 + debN + deb > creNm1 + creN + cre)
			{
				soldeDN = debNm1 + debN + deb - (creNm1 + creN + cre);
			}
			else
			{
				soldeCN = creNm1 + creN + cre - (debNm1 + debN + deb);
			}
			DebitN.EditValue = debN + deb;
			CreditN.EditValue = creN + cre;
			SOLCN.EditValue = soldeCN;
			SOLDN.EditValue = soldeDN;
		}
	}

	private void ModifierDates()
	{
		string x = "";
		string y = "";
		if (Nouveau)
		{
			return;
		}
		y = dtpieces.Select($"UNI='{monModule.gUNI}' AND Exercice={monModule.gExercice} AND NOP={NOP} AND JA='{JA}'")[0]["Mois"].ToString();
		x = mois.EditValue.ToString();
		if (!(x != y))
		{
			return;
		}
		int MAXNEW = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, Convert.ToByte(x)));
		for (int i = 0; i < gridView1.DataRowCount; i++)
		{
			DataRow dataRow = gridView1.GetDataRow(i);
			int xx = Convert.ToByte(dataRow["JOUR"]);
			if (xx > MAXNEW)
			{
				xx = MAXNEW;
			}
			dataRow["JOUR"] = xx;
			dataRow["DAT"] = monModule.gExercice + "-" + x + "-" + xx;
		}
	}

	private void Enregistrer()
	{
		if (!btnEnregistrer.Enabled)
		{
			return;
		}
		string x = "";
		string y = "";
		string anclib = "";
		if (!Nouveau)
		{
			if (parpiece)
			{
				DataRow[] array = dtpieces.Select($"UNI='{monModule.gUNI}' AND Exercice={monModule.gExercice} AND NOP={NOP} AND JA='{JA}'");
				y = array[0]["Dat"].ToString();
				x = dat.EditValue.ToString();
				anclib = array[0]["LIB"].ToString();
				if (x != y)
				{
					int MAXNEW = Convert.ToByte(Convert.ToDateTime(x).Day);
					for (int i = 0; i < gridView1.DataRowCount; i++)
					{
						DataRow dataRow = gridView1.GetDataRow(i);
						dataRow["JOUR"] = MAXNEW;
						dataRow["DAT"] = x;
					}
				}
			}
			else
			{
				DataRow[] array2 = dtpieces.Select($"UNI='{monModule.gUNI}' AND Exercice={monModule.gExercice} AND NOP={NOP} AND JA='{JA}'");
				y = array2[0]["Mois"].ToString();
				x = mois.EditValue.ToString();
				anclib = array2[0]["LIB"].ToString();
				if (x != y)
				{
					int MAXNEW2 = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, Convert.ToByte(x)));
					for (int j = 0; j < gridView1.DataRowCount; j++)
					{
						DataRow dataRow2 = gridView1.GetDataRow(j);
						int xx = Convert.ToByte(dataRow2["JOUR"]);
						if (xx > MAXNEW2)
						{
							xx = MAXNEW2;
						}
						dataRow2["JOUR"] = xx;
						dataRow2["DAT"] = monModule.gExercice + "-" + x + "-" + xx;
					}
				}
			}
		}
		gridView1.PostEditor();
		gridView1.UpdateCurrentRow();
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		DataRow[] array3 = dataSet1.Ecritures_t.Select("CPT is null");
		for (int k = 0; k < array3.Length; k++)
		{
			array3[k].Delete();
		}
		if (gridView1.RowCount > 0)
		{
			OrderRow("LIG");
			try
			{
				ecriturestBindingSource.EndEdit();
				ecritures_tTableAdapter.Update(dataSet1.Ecritures_t);
				dataSet1.Ecritures_t.AcceptChanges();
				dataSet1.Ecritures_t.Clear();
				ecritures_tTableAdapter.Fill(dataSet1.Ecritures_t);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + " " + ex.Source.ToString());
			}
			OleDbCommand cmd = new OleDbCommand();
			OleDbTransaction transaction = null;
			cmd.CommandType = CommandType.Text;
			using OleDbConnection gbase = new OleDbConnection(connection);
			gbase.Open();
			cmd.Connection = gbase;
			transaction = gbase.BeginTransaction();
			try
			{
				cmd.Transaction = transaction;
				if (dtpieces.Select($"UNI='{monModule.gUNI}' AND Exercice={monModule.gExercice} AND NOP={NOP} AND JA='{JA}'").Length == 0)
				{
					if (parpiece)
					{
						cmd.CommandText = $"INSERT INTO Pieces  (UNI, JA, NOP, DAT, MOIS,LIB,Exercice) VALUES ('{monModule.gUNI}', '{JA}',  {NOP}, #{dat.EditValue}#, {Convert.ToDateTime(dat.EditValue).Month}, '{lib.Text}', {monModule.gExercice})";
					}
					else
					{
						cmd.CommandText = string.Format("INSERT INTO Pieces  (UNI, JA, NOP, DAT, MOIS,LIB,Exercice) VALUES ('{0}', '{1}',  {2}, #{3}#, {4}, '{5}', {6})", monModule.gUNI, JA, NOP, monModule.gExercice + "-" + vMOIS + "-01", MOIS, lib.Text, monModule.gExercice);
					}
					cmd.ExecuteNonQuery();
				}
				else if (x != y)
				{
					if (parpiece)
					{
						cmd.CommandText = $"UPDATE Pieces SET MOIS={Convert.ToDateTime(dat.EditValue).Month}, Dat=#{dat.EditValue}#, LIB='{lib.Text}' WHERE UNI = '{monModule.gUNI}' AND Exercice = {monModule.gExercice} AND NOP = {NOP} AND JA = '{JA}'";
					}
					else
					{
						cmd.CommandText = string.Format("UPDATE Pieces SET MOIS={0}, Dat=#{1}#, LIB='{2}' WHERE UNI = '{3}' AND Exercice = {4} AND NOP = {5} AND JA = '{6}'", x, monModule.gExercice + "-" + x + "-01", lib.Text, monModule.gUNI, monModule.gExercice, NOP, JA);
					}
					cmd.ExecuteNonQuery();
				}
				else if (anclib != lib.Text)
				{
					cmd.CommandText = $"UPDATE Pieces SET LIB='{lib.Text}' WHERE UNI = '{monModule.gUNI}' AND Exercice = {monModule.gExercice} AND NOP = {NOP} AND JA = '{JA}'";
					cmd.ExecuteNonQuery();
				}
				cmd.CommandText = $"Delete * from Ecritures Where UNI = '{monModule.gUNI}' AND Exercice = {monModule.gExercice} AND NOP = {NOP} AND JA = '{JA}'";
				cmd.ExecuteNonQuery();
				cmd.CommandText = "Insert Into Ecritures  Select * from Ecritures_t";
				cmd.ExecuteNonQuery();
				transaction.Commit();
			}
			catch (Exception ex2)
			{
				transaction.Rollback();
				MessageBox.Show(ex2.Message.ToString() + " " + Nouveau);
			}
		}
		dtpieces.Clear();
		adpiece.FillBy(dtpieces, monModule.gUNI, Convert.ToInt32(monModule.gExercice));
		dataSet1.Ecritures_t.Clear();
		ecritures_tTableAdapter.Fill(dataSet1.Ecritures_t);
		Nouveau = false;
		piece.EditValue = 0;
		lib.EditValue = "";
		Remplir();
		piece.Focus();
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		Enregistrer();
	}

	private void lib_EditValueChanged(object sender, EventArgs e)
	{
		LIB = lib.EditValue.ToString();
	}

	private void mois_EditValueChanged(object sender, EventArgs e)
	{
		MOIS = Convert.ToByte(mois.EditValue);
		int MAXNEW = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, MOIS));
		repositoryItemSpinEdit1.MaxValue = MAXNEW;
		dat.EditValue = Convert.ToDateTime("01-" + MOIS + "-" + monModule.gExercice);
		ModifierDates();
	}

	private void piece_EditValueChanged(object sender, EventArgs e)
	{
		NOP = Convert.ToInt32(piece.EditValue);
	}

	private void OrderRow(string champ)
	{
		for (int i = 0; i < gridView1.DataRowCount; i++)
		{
			gridView1.SetRowCellValue(i, gridView1.Columns[champ], i);
		}
	}

	private void AddRow(DataRowView row)
	{
		if (row == null)
		{
			return;
		}
		DataRow newRow = dataSet1.Ecritures_t.NewRow();
		for (int i = 0; i < dataSet1.Ecritures_t.Columns.Count; i++)
		{
			string columnName = dataSet1.Ecritures_t.Columns[i].ColumnName;
			if (!(columnName == "ID"))
			{
				if (columnName == "LIG")
				{
					newRow[i] = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "LIG")) - 1;
				}
				else
				{
					newRow[i] = row[dataSet1.Ecritures_t.Columns[i].ColumnName];
				}
			}
		}
		dataSet1.Ecritures_t.Rows.Add(newRow);
	}

	private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
	{
		if (e.MenuType != GridMenuType.Row)
		{
			return;
		}
		DXMenuItem item = new DXMenuItem("Copier la ligne");
		item.ImageOptions.Image = imageCollection1.Images[0];
		item.Click += delegate
		{
			selectedRows.Clear();
			int[] array = gridView1.GetSelectedRows();
			for (int i = 0; i < array.Length; i++)
			{
				selectedRows.Add(gridView1.GetRow(array[i]) as DataRowView);
			}
		};
		item.BeginGroup = true;
		item.Enabled = true;
		e.Menu.Items.Add(item);
		item = new DXMenuItem("Coller la ligne");
		item.ImageOptions.Image = imageCollection1.Images[1];
		item.Click += delegate
		{
			foreach (DataRowView current in selectedRows)
			{
				AddRow(current);
			}
			OrderRow("LIG");
		};
		item.BeginGroup = true;
		item.Enabled = true;
		e.Menu.Items.Add(item);
		item = new DXMenuItem("Supprimer la ligne");
		item.ImageOptions.Image = imageCollection1.Images[2];
		item.Click += delegate
		{
			if (XtraMessageBox.Show("Etes-vous sûr de vouloir suprimer la ligne ?", "Suppression d'écriture", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				del = true;
				gridView1.GetSelectedRows();
				_ = gridControl1.FocusedView;
				gridView1.DeleteSelectedRows();
				del = false;
				OrderRow("LIG");
			}
		};
		item.BeginGroup = true;
		e.Menu.Items.Add(item);
	}

	private void gridView1_KeyDown(object sender, KeyEventArgs e)
	{
		GridView view = sender as GridView;
		_ = view.FocusedRowHandle;
		view.CloseEditor();
		if (e.KeyCode == Keys.Tab && e.Modifiers == Keys.None)
		{
			e.Handled = true;
		}
		else if (e.KeyCode == Keys.F5 && e.Modifiers == Keys.None)
		{
			Enregistrer();
		}
		else if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
		{
			if (view.FocusedColumn.FieldName == "Jour")
			{
				view.FocusedColumn = view.Columns["CPT"];
				e.Handled = true;
			}
			else if (view.FocusedColumn.FieldName == "CPT")
			{
				string s = view.GetRowCellValue(view.FocusedRowHandle, "CPT").ToString();
				DataRow[] ro = dataSet1.Comptes.Select("CPT='" + s + "' AND IMPUT='O'");
				if (ro.Length != 0)
				{
					if (ro[0]["TRS"].ToString() == "N")
					{
						gridView1.SetRowCellValue(view.FocusedRowHandle, view.Columns["TRS"], "-");
						gridView1.FocusedColumn = view.Columns["LIB"];
					}
					else
					{
						view.FocusedColumn = view.Columns["TRS"];
					}
				}
				e.Handled = true;
			}
			else if (view.FocusedColumn.FieldName == "TRS")
			{
				string s2 = view.GetRowCellValue(view.FocusedRowHandle, "TRS").ToString();
				if (dataSet1.Tiers.Select("TRS='" + s2 + "' AND TRS<>'-' AND UNI='" + monModule.gUNI + "'").Length != 0)
				{
					gridView1.FocusedColumn = view.Columns["LIB"];
				}
				e.Handled = true;
			}
			else if (view.FocusedColumn.FieldName == "LIB")
			{
				view.FocusedColumn = view.Columns["DEB"];
				e.Handled = true;
			}
			else if (view.FocusedColumn.FieldName == "DEB")
			{
				view.FocusedColumn = view.Columns["CRE"];
				e.Handled = true;
			}
			else
			{
				if (!(view.FocusedColumn.FieldName == "CRE"))
				{
					return;
				}
				if (view.IsLastRow)
				{
					double num = Convert.ToDouble(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DEB"));
					double y = Convert.ToDouble(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CRE"));
					object o = view.GetRowCellValue(view.FocusedRowHandle, "CPT");
					if (num + y == 0.0 || o.ToString() == "")
					{
						e.Handled = true;
						return;
					}
					_ = view.DataRowCount;
					view.PostEditor();
					view.UpdateCurrentRow();
					view.CloseEditor();
					gridView1.AddNewRow();
					view.MoveNext();
					view.UpdateCurrentRow();
					view.CloseEditor();
					view.FocusedColumn = view.Columns["Jour"];
					view.MoveNext();
					e.Handled = true;
				}
				else
				{
					e.Handled = true;
					view.FocusedColumn = view.Columns["Jour"];
					view.MoveNext();
				}
			}
		}
		else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
		{
			if (XtraMessageBox.Show("Supprimer l'écriture ?", "Suppression d'écriture", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				view.DeleteRow(view.FocusedRowHandle);
				for (int i = 0; i < view.DataRowCount; i++)
				{
					view.SetRowCellValue(i, view.Columns["LIG"], i);
				}
				e.Handled = true;
			}
		}
		else if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
		{
			if (view.IsEditing)
			{
				view.CloseEditor();
				return;
			}
			if (MessageBox.Show("Voulez-vous annuler les dernières modifications", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				Enregistrer();
				e.Handled = true;
				return;
			}
			piece.EditValue = 0;
			lib.EditValue = "";
			Remplir();
			piece.Focus();
			e.Handled = true;
		}
		else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F1 && string.Compare(view.FocusedColumn.FieldName, "CPT") == 0)
		{
			OuvrirRechCPT();
			e.Handled = true;
		}
		else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F1 && string.Compare(view.FocusedColumn.FieldName, "TRS") == 0)
		{
			OuvrirRechTRS();
			e.Handled = true;
		}
		else if (e.KeyCode == Keys.Insert && e.Modifiers == Keys.None)
		{
			double num2 = Convert.ToDouble(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DEB"));
			double y2 = Convert.ToDouble(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CRE"));
			if (num2 + y2 != 0.0)
			{
				object t = view.GetRowCellValue(view.FocusedRowHandle, "LIB");
				LIB = ((t != null) ? t.ToString() : lib.EditValue.ToString());
				t = view.GetRowCellValue(view.FocusedRowHandle, "Jour");
				JOUR = ((t != null) ? Convert.ToByte(t) : JOUR);
				t = dataSet1.Ecritures_t.Compute("SUM(DEB)", "");
				double deb = ((t == DBNull.Value) ? 0.0 : Convert.ToDouble(t));
				t = dataSet1.Ecritures_t.Compute("SUM(CRE)", "");
				double cre = ((t == DBNull.Value) ? 0.0 : Convert.ToDouble(t));
				int foc = view.GetDataSourceRowIndex(view.FocusedRowHandle) + 1;
				DataRow row = dataSet1.Ecritures_t.NewRow();
				row["LIG"] = foc;
				row["JA"] = JA;
				row["NOP"] = NOP;
				row["CPT"] = null;
				row["TRS"] = "-";
				row["DEB"] = ((deb < cre) ? (cre - deb) : 0.0);
				row["CRE"] = ((cre < deb) ? (deb - cre) : 0.0);
				row["LIB"] = LIB;
				row["UNI"] = monModule.gUNI;
				row["Exercice"] = monModule.gExercice;
				if (parpiece)
				{
					row["Jour"] = Convert.ToDateTime(dat.EditValue).Day;
					row["DAT"] = dat.EditValue;
				}
				else
				{
					row["Jour"] = JOUR;
					row["DAT"] = monModule.gExercice + "-" + vMOIS + "-" + JOUR;
				}
				dataSet1.Ecritures_t.Rows.InsertAt(row, foc);
				for (int j = 0; j < view.DataRowCount; j++)
				{
					view.SetRowCellValue(j, view.Columns["LIG"], j);
				}
				ecriturestBindingSource.EndEdit();
				ecritures_tTableAdapter.Update(dataSet1.Ecritures_t);
				dataSet1.Ecritures_t.AcceptChanges();
				dataSet1.Ecritures_t.Clear();
				ecritures_tTableAdapter.Fill(dataSet1.Ecritures_t);
				view.FocusedRowHandle = view.GetRowHandle(foc);
				e.Handled = true;
			}
		}
		else if (e.KeyCode == Keys.Next)
		{
			e.Handled = true;
			e.SuppressKeyPress = false;
			int p = gridView1.FocusedRowHandle;
			if (gridView1.FocusedRowHandle == gridView1.RowCount - 1)
			{
				gridView1.AddNewRow();
				gridView1.FocusedRowHandle = p;
			}
			e.Handled = true;
		}
	}

	private void piece_Validated(object sender, EventArgs e)
	{
		Remplir();
	}

	private void OuvrirRechCPT()
	{
		gridView1.CloseEditor();
		monModule.gCPT = "";
		frmComptes obj = new frmComptes(rech: true);
		obj.ShowDialog();
		obj.Dispose();
		if (monModule.gCPT != "")
		{
			gridView1.SetFocusedValue(monModule.gCPT);
			SendKeys.Send("{TAB}");
		}
	}

	private void OuvrirRechTRS()
	{
		gridView1.CloseEditor();
		monModule.gTRS = "";
		frmTiers obj = new frmTiers(rech: true);
		obj.ShowDialog();
		obj.Dispose();
		if (monModule.gTRS != "")
		{
			gridView1.SetFocusedValue(monModule.gTRS);
			SendKeys.Send("{TAB}");
		}
	}

	private void piece_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
		{
			jnl.Focus();
		}
	}

	private void mois_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
		{
			piece.Focus();
		}
	}

	private void lib_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
		{
			if (parpiece)
			{
				dat.Focus();
			}
			else
			{
				mois.Focus();
			}
		}
		else if (e.KeyCode == Keys.Return && e.Modifiers == Keys.None)
		{
			gridView1.FocusedColumn = gridView1.Columns["Jour"];
		}
	}

	private void gridView1_ShownEditor(object sender, EventArgs e)
	{
		ColumnView view = (ColumnView)sender;
		if (view.FocusedRowHandle == -2147483647)
		{
			view.ActiveEditor.IsModified = true;
		}
		if (view.FocusedColumn.FieldName == "LIB")
		{
			TextEdit obj = view.ActiveEditor as TextEdit;
			obj.SelectionStart = obj.Text.Length;
			obj.SelectionLength = 0;
		}
	}

	private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
	{
		GridView view = sender as GridView;
		object o = dataSet1.Ecritures_t.Compute("MAX(LIG)", "");
		LIG = ((o != DBNull.Value) ? (Convert.ToInt32(o) + 1) : 0);
		object t = dataSet1.Ecritures_t.Compute("SUM(DEB)", "");
		double deb = ((t == DBNull.Value) ? 0.0 : Convert.ToDouble(t));
		t = dataSet1.Ecritures_t.Compute("SUM(CRE)", "");
		double cre = ((t == DBNull.Value) ? 0.0 : Convert.ToDouble(t));
		view.SetRowCellValue(e.RowHandle, view.Columns["Exercice"], monModule.gExercice);
		view.SetRowCellValue(e.RowHandle, view.Columns["UNI"], monModule.gUNI);
		view.SetRowCellValue(e.RowHandle, view.Columns["JA"], JA);
		view.SetRowCellValue(e.RowHandle, view.Columns["NOP"], NOP);
		view.SetRowCellValue(e.RowHandle, view.Columns["Jour"], JOUR);
		view.SetRowCellValue(e.RowHandle, view.Columns["DAT"], dat.EditValue);
		view.SetRowCellValue(e.RowHandle, view.Columns["CPT"], null);
		view.SetRowCellValue(e.RowHandle, view.Columns["TRS"], "-");
		view.SetRowCellValue(e.RowHandle, view.Columns["LIB"], LIB);
		view.SetRowCellValue(e.RowHandle, view.Columns["DEB"], (deb < cre) ? (cre - deb) : 0.0);
		view.SetRowCellValue(e.RowHandle, view.Columns["CRE"], (deb > cre) ? (deb - cre) : 0.0);
		view.SetRowCellValue(e.RowHandle, view.Columns["LIG"], LIG);
	}

	private void Journal_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void OnDown(object sender, KeyEventArgs e)
	{
		if (e.Modifiers == Keys.None && e.KeyCode == Keys.F5)
		{
			gridView1.CloseEditor();
			Enregistrer();
		}
	}

	private void gridControl1_Enter(object sender, EventArgs e)
	{
		if (gridView1.RowCount == 0)
		{
			gridView1.AddNewRow();
			gridView1.UpdateCurrentRow();
		}
	}

	private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
	{
	}

	private void gridView1_GotFocus(object sender, EventArgs e)
	{
	}

	private void gridControl1_Leave(object sender, EventArgs e)
	{
	}

	private void frmEcritures_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F5)
		{
			gridView1.CloseEditor();
			Enregistrer();
		}
	}

	private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
	{
		Keys keyData = e.KeyData;
		if (keyData == Keys.Tab || (uint)(keyData - 37) <= 3u)
		{
			GridControl obj = sender as GridControl;
			if (gridView1.IsEditing)
			{
				gridView1.PostEditor();
				gridView1.UpdateCurrentRow();
			}
			obj.FocusedView.HideEditor();
		}
	}

	private void repositoryItemTextEdit2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Modifiers == Keys.None && e.KeyCode == Keys.F1)
		{
			e.Handled = true;
			if (gridView1.FocusedColumn.FieldName == "CPT")
			{
				monModule.enter = false;
				string s = (sender as TextEdit).Text;
				frmComptes obj = new frmComptes(rech: true, s);
				obj.ShowDialog();
				obj.Dispose();
				if (monModule.gCPT != "")
				{
					gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CPT"], monModule.gCPT);
				}
			}
		}
		else
		{
			OnDown(sender, e);
		}
	}

	private void repositoryItemTextEdit3_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Modifiers == Keys.None && e.KeyCode == Keys.F1)
		{
			e.Handled = true;
			if (gridView1.FocusedColumn.FieldName == "TRS")
			{
				monModule.enter = false;
				string s = (sender as TextEdit).Text;
				frmTiers obj = new frmTiers(rech: true, s);
				obj.ShowDialog();
				obj.Dispose();
				if (monModule.gTRS != "")
				{
					gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TRS"], monModule.gTRS);
				}
			}
		}
		else
		{
			OnDown(sender, e);
		}
	}

	private void textEdit1_Validating(object sender, CancelEventArgs e)
	{
		string s = (sender as TextEdit).Text;
		if (dataSet1.Journaux.Select("JA='" + s + "'").Length == 0)
		{
			dxErrorProvider1.SetError(jnl, "Error");
			monModule.gJA = "";
			e.Cancel = true;
		}
		else
		{
			monModule.gJA = s;
			dxErrorProvider1.SetError(jnl, null);
			e.Cancel = false;
		}
	}

	private void textEdit1_Validated(object sender, EventArgs e)
	{
		lib.EditValue = "";
		dat.EditValue = Convert.ToDateTime("01-01-" + monModule.gExercice);
		mois.EditValue = 1;
		piece.EditValue = 0;
		Remplir();
		piece.Focus();
	}

	private void textEdit1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
		{
			Close();
		}
		else if (e.Modifiers == Keys.None && e.KeyCode == Keys.F1)
		{
			frmRechJA obj = new frmRechJA();
			obj.ShowDialog();
			obj.Dispose();
			if (monModule.gJA != "")
			{
				jnl.Text = monModule.gJA;
				SendKeys.Send("{TAB}");
			}
		}
	}

	private void repositoryItemSpinEdit1_Validating(object sender, CancelEventArgs e)
	{
		int num = Convert.ToInt32((sender as SpinEdit).Text);
		int x = Convert.ToInt32(mois.EditValue);
		if (x == 0)
		{
			x = 1;
		}
		MAXJOUR = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, x));
		if (num > MAXJOUR)
		{
			(sender as SpinEdit).EditValue = MAXJOUR;
		}
	}

	private void dat_Validating(object sender, CancelEventArgs e)
	{
		if ((sender as DateEdit).DateTime.Year != monModule.gExercice)
		{
			e.Cancel = true;
		}
	}

	private void dat_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
	{
		e.ExceptionMode = ExceptionMode.NoAction;
		MessageBox.Show("Date en dehors de l'exercice", "Error");
	}

	private void dat_EnabledChanged(object sender, EventArgs e)
	{
	}

	private void dat_Validated(object sender, EventArgs e)
	{
		DateTime currentValue = (sender as DateEdit).DateTime;
		MAXJOUR = Convert.ToByte(DateTime.DaysInMonth(monModule.gExercice, currentValue.Month));
		JOUR = Convert.ToByte(currentValue.Day);
	}

	private void repositoryItemSearchLookUpEdit3_Validating(object sender, CancelEventArgs e)
	{
	}

	private void c(object sender, PrintRowEventArgs e)
	{
	}

	private void repositoryItemSearchLookUpEdit3_AddNewValue(object sender, AddNewValueEventArgs e)
	{
		new frmComptes().ShowDialog();
		comptesTableAdapter.Fill1(dataSet1.Comptes);
		repositoryItemSearchLookUpEdit3.DataSource = null;
		repositoryItemSearchLookUpEdit3.DataSource = dataSet1.Comptes;
	}

	private void repositoryItemSearchLookUpEdit3_BeforePopup(object sender, EventArgs e)
	{
		if (monModule.cptmodifie)
		{
			comptesTableAdapter.Fill1(dataSet1.Comptes);
			monModule.cptmodifie = false;
			repositoryItemSearchLookUpEdit3.DataSource = null;
			repositoryItemSearchLookUpEdit3.DataSource = dataSet1.Comptes;
		}
	}

	private void repositoryItemTextEdit2_Validating(object sender, CancelEventArgs e)
	{
		string s = (sender as TextEdit).Text ?? "";
		if (dataSet1.Comptes.Select("CPT='" + s + "' AND IMPUT='O'").Length == 0)
		{
			e.Cancel = true;
		}
	}

	private void repositoryItemTextEdit3_Validating(object sender, CancelEventArgs e)
	{
		if ((sender as TextEdit).Text == "-")
		{
			e.Cancel = true;
		}
	}

	private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
	{
	}

	private void jnl_Enter(object sender, EventArgs e)
	{
		(sender as TextEdit).SelectAll();
	}

	private void piece_Enter(object sender, EventArgs e)
	{
		(sender as TextEdit).SelectAll();
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
		DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
		DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmEcritures));
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.btnEnregistrer = new DevExpress.XtraEditors.SimpleButton();
		this.gridControl1 = new DevExpress.XtraGrid.GridControl();
		this.ecriturestBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colLIG = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colExercice = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colNOP = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colJA = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colJour = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
		this.colCPT = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
		this.colTRS = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
		this.colDEB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
		this.colCRE = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colDAT = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemSearchLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
		this.comptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.repositoryItemSearchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colCPT1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIBAR = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
		this.tiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colTRS1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIBAR1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.lib = new DevExpress.XtraEditors.TextEdit();
		this.SOLDN = new DevExpress.XtraEditors.TextEdit();
		this.SOLCN = new DevExpress.XtraEditors.TextEdit();
		this.tier = new DevExpress.XtraEditors.TextEdit();
		this.Compte = new DevExpress.XtraEditors.TextEdit();
		this.mois = new DevExpress.XtraEditors.LookUpEdit();
		this.lesMoisBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dateEcriture = new DevExpress.XtraEditors.DateEdit();
		this.dat = new DevExpress.XtraEditors.DateEdit();
		this.scre = new DevExpress.XtraEditors.SpinEdit();
		this.sdeb = new DevExpress.XtraEditors.SpinEdit();
		this.jnl = new DevExpress.XtraEditors.TextEdit();
		this.piece = new DevExpress.XtraEditors.SpinEdit();
		this.DebitNM1 = new DevExpress.XtraEditors.TextEdit();
		this.CreditNM1 = new DevExpress.XtraEditors.TextEdit();
		this.DebitN = new DevExpress.XtraEditors.TextEdit();
		this.CreditN = new DevExpress.XtraEditors.TextEdit();
		this.pardate22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
		this.parbordereau = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.pardate = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.soldeN = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
		this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
		this.txtSOLDN = new DevExpress.XtraLayout.SimpleLabelItem();
		this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.simpleLabelItem3 = new DevExpress.XtraLayout.SimpleLabelItem();
		this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.simpleLabelItem4 = new DevExpress.XtraLayout.SimpleLabelItem();
		this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
		this.journauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.journauxTableAdapter = new compta.DataSet1TableAdapters.JournauxTableAdapter();
		this.lesMoisTableAdapter = new compta.DataSet1TableAdapters.LesMoisTableAdapter();
		this.ecritures_tTableAdapter = new compta.DataSet1TableAdapters.Ecritures_tTableAdapter();
		this.comptesTableAdapter = new compta.DataSet1TableAdapters.ComptesTableAdapter();
		this.tiersTableAdapter = new compta.DataSet1TableAdapters.TiersTableAdapter();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
		this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
		this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.gridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ecriturestBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSpinEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSpinEdit2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.comptesBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit3View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tiersBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit1View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.lib.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.SOLDN.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.SOLCN.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tier.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Compte.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mois.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.lesMoisBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dateEcriture.Properties.CalendarTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dateEcriture.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dat.Properties.CalendarTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dat.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.scre.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.sdeb.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.jnl.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.piece.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DebitNM1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CreditNM1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DebitN.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CreditN.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pardate22).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.parbordereau).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pardate).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem14).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem15).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.soldeN).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem11).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem12).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem13).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtSOLDN).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem10).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dxErrorProvider1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.imageCollection1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.behaviorManager1).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
		this.layoutControl1.Appearance.ControlDisabled.ForeColor = System.Drawing.SystemColors.WindowText;
		this.layoutControl1.Appearance.ControlDisabled.Options.UseForeColor = true;
		this.layoutControl1.Controls.Add(this.btnEnregistrer);
		this.layoutControl1.Controls.Add(this.gridControl1);
		this.layoutControl1.Controls.Add(this.lib);
		this.layoutControl1.Controls.Add(this.SOLDN);
		this.layoutControl1.Controls.Add(this.SOLCN);
		this.layoutControl1.Controls.Add(this.tier);
		this.layoutControl1.Controls.Add(this.Compte);
		this.layoutControl1.Controls.Add(this.mois);
		this.layoutControl1.Controls.Add(this.dateEcriture);
		this.layoutControl1.Controls.Add(this.dat);
		this.layoutControl1.Controls.Add(this.scre);
		this.layoutControl1.Controls.Add(this.sdeb);
		this.layoutControl1.Controls.Add(this.jnl);
		this.layoutControl1.Controls.Add(this.piece);
		this.layoutControl1.Controls.Add(this.DebitNM1);
		this.layoutControl1.Controls.Add(this.CreditNM1);
		this.layoutControl1.Controls.Add(this.DebitN);
		this.layoutControl1.Controls.Add(this.CreditN);
		this.layoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.pardate22 });
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.MaximumSize = new System.Drawing.Size(1000, 800);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(813, 273, 650, 400);
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(902, 530);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.btnEnregistrer.ImageOptions.Image = compta.Properties.Resources.save_16x161;
		this.btnEnregistrer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
		this.btnEnregistrer.Location = new System.Drawing.Point(600, 380);
		this.btnEnregistrer.Name = "btnEnregistrer";
		this.btnEnregistrer.Size = new System.Drawing.Size(290, 138);
		this.btnEnregistrer.StyleController = this.layoutControl1;
		this.btnEnregistrer.TabIndex = 19;
		this.btnEnregistrer.TabStop = false;
		this.btnEnregistrer.Text = "Enregistrer \r\n (F5)";
		this.btnEnregistrer.Click += new System.EventHandler(simpleButton1_Click);
		this.gridControl1.DataSource = this.ecriturestBindingSource;
		this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
		this.gridControl1.Location = new System.Drawing.Point(12, 104);
		this.gridControl1.MainView = this.gridView1;
		this.gridControl1.Name = "gridControl1";
		this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[7] { this.repositoryItemSpinEdit1, this.repositoryItemTextEdit1, this.repositoryItemSpinEdit2, this.repositoryItemTextEdit3, this.repositoryItemSearchLookUpEdit3, this.repositoryItemSearchLookUpEdit1, this.repositoryItemTextEdit2 });
		this.gridControl1.Size = new System.Drawing.Size(878, 250);
		this.gridControl1.TabIndex = 4;
		this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.gridView1 });
		this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(gridControl1_ProcessGridKey);
		this.gridControl1.Enter += new System.EventHandler(gridControl1_Enter);
		this.gridControl1.Leave += new System.EventHandler(gridControl1_Leave);
		this.ecriturestBindingSource.DataMember = "Ecritures_t";
		this.ecriturestBindingSource.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[12]
		{
			this.colLIG, this.colUNI, this.colExercice, this.colNOP, this.colJA, this.colJour, this.colCPT, this.colTRS, this.colLIB, this.colDEB,
			this.colCRE, this.colDAT
		});
		this.gridView1.GridControl = this.gridControl1;
		this.gridView1.Name = "gridView1";
		this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
		this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
		this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
		this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.False;
		this.gridView1.OptionsBehavior.AllowPartialGroups = DevExpress.Utils.DefaultBoolean.False;
		this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
		this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
		this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
		this.gridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
		this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
		this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
		this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
		this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
		this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
		this.gridView1.OptionsView.EnableAppearanceOddRow = true;
		this.gridView1.OptionsView.ShowFooter = true;
		this.gridView1.OptionsView.ShowGroupPanel = false;
		this.gridView1.OptionsView.ShowIndicator = false;
		this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(gridView1_PopupMenuShowing);
		this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(gridView1_InitNewRow);
		this.gridView1.ShownEditor += new System.EventHandler(gridView1_ShownEditor);
		this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView1_FocusedRowChanged);
		this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(gridView1_FocusedRowObjectChanged);
		this.gridView1.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(gridView1_FocusedColumnChanged);
		this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView1_CellValueChanged);
		this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView1_CellValueChanging);
		this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(gridView1_ValidateRow);
		this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(gridView1_KeyDown);
		this.gridView1.GotFocus += new System.EventHandler(gridView1_GotFocus);
		this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(gridView1_ValidatingEditor);
		this.gridView1.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(gridView1_InvalidValueException);
		this.colLIG.FieldName = "LIG";
		this.colLIG.Name = "colLIG";
		this.colLIG.OptionsColumn.AllowEdit = false;
		this.colLIG.OptionsColumn.AllowFocus = false;
		this.colUNI.FieldName = "UNI";
		this.colUNI.Name = "colUNI";
		this.colUNI.OptionsColumn.AllowEdit = false;
		this.colUNI.OptionsColumn.AllowFocus = false;
		this.colExercice.FieldName = "Exercice";
		this.colExercice.Name = "colExercice";
		this.colExercice.OptionsColumn.AllowEdit = false;
		this.colExercice.OptionsColumn.AllowFocus = false;
		this.colNOP.FieldName = "NOP";
		this.colNOP.Name = "colNOP";
		this.colNOP.OptionsColumn.AllowEdit = false;
		this.colNOP.OptionsColumn.AllowFocus = false;
		this.colJA.FieldName = "JA";
		this.colJA.Name = "colJA";
		this.colJA.OptionsColumn.AllowEdit = false;
		this.colJA.OptionsColumn.AllowFocus = false;
		this.colJour.AppearanceCell.Options.UseTextOptions = true;
		this.colJour.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colJour.AppearanceHeader.Options.UseTextOptions = true;
		this.colJour.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colJour.Caption = "Jour";
		this.colJour.ColumnEdit = this.repositoryItemSpinEdit1;
		this.colJour.FieldName = "Jour";
		this.colJour.Name = "colJour";
		this.colJour.Visible = true;
		this.colJour.VisibleIndex = 0;
		this.colJour.Width = 31;
		this.repositoryItemSpinEdit1.AutoHeight = false;
		this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)
		});
		this.repositoryItemSpinEdit1.IsFloatValue = false;
		this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
		this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[4] { 31, 0, 0, 0 });
		this.repositoryItemSpinEdit1.MinValue = new decimal(new int[4] { 1, 0, 0, 0 });
		this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
		this.repositoryItemSpinEdit1.Validating += new System.ComponentModel.CancelEventHandler(repositoryItemSpinEdit1_Validating);
		this.colCPT.AppearanceCell.Options.UseTextOptions = true;
		this.colCPT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colCPT.AppearanceHeader.Options.UseTextOptions = true;
		this.colCPT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colCPT.Caption = "Compte";
		this.colCPT.ColumnEdit = this.repositoryItemTextEdit2;
		this.colCPT.FieldName = "CPT";
		this.colCPT.Name = "colCPT";
		this.colCPT.Visible = true;
		this.colCPT.VisibleIndex = 1;
		this.colCPT.Width = 76;
		this.repositoryItemTextEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
		this.repositoryItemTextEdit2.AutoHeight = false;
		this.repositoryItemTextEdit2.Mask.EditMask = " '[0-9]{1,6}'";
		this.repositoryItemTextEdit2.MaxLength = 6;
		this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
		this.repositoryItemTextEdit2.ValidateOnEnterKey = true;
		this.repositoryItemTextEdit2.KeyDown += new System.Windows.Forms.KeyEventHandler(repositoryItemTextEdit2_KeyDown);
		this.colTRS.AppearanceCell.Options.UseTextOptions = true;
		this.colTRS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colTRS.AppearanceHeader.Options.UseTextOptions = true;
		this.colTRS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colTRS.Caption = "Tiers";
		this.colTRS.ColumnEdit = this.repositoryItemTextEdit3;
		this.colTRS.FieldName = "TRS";
		this.colTRS.Name = "colTRS";
		this.colTRS.Visible = true;
		this.colTRS.VisibleIndex = 2;
		this.colTRS.Width = 85;
		this.repositoryItemTextEdit3.AllowFocused = false;
		this.repositoryItemTextEdit3.AutoHeight = false;
		this.repositoryItemTextEdit3.Mask.EditMask = "[0-9]{1,6}";
		this.repositoryItemTextEdit3.MaxLength = 6;
		this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
		this.repositoryItemTextEdit3.KeyDown += new System.Windows.Forms.KeyEventHandler(repositoryItemTextEdit3_KeyDown);
		this.colLIB.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB.Caption = "Intitulé";
		this.colLIB.ColumnEdit = this.repositoryItemTextEdit1;
		this.colLIB.FieldName = "LIB";
		this.colLIB.Name = "colLIB";
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 3;
		this.colLIB.Width = 266;
		this.repositoryItemTextEdit1.AutoHeight = false;
		this.repositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.repositoryItemTextEdit1.MaxLength = 30;
		this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
		this.repositoryItemTextEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(OnDown);
		this.colDEB.AppearanceHeader.Options.UseTextOptions = true;
		this.colDEB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colDEB.Caption = "Débit";
		this.colDEB.ColumnEdit = this.repositoryItemSpinEdit2;
		this.colDEB.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.colDEB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.colDEB.FieldName = "DEB";
		this.colDEB.Name = "colDEB";
		this.colDEB.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[1]
		{
			new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DEB", "{0:#,##0.00;#,##0.00; }")
		});
		this.colDEB.Visible = true;
		this.colDEB.VisibleIndex = 4;
		this.colDEB.Width = 146;
		this.repositoryItemSpinEdit2.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
		this.repositoryItemSpinEdit2.AutoHeight = false;
		this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)
		});
		this.repositoryItemSpinEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "{0:0.00#,##;-0.00#,##; }";
		this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
		this.repositoryItemSpinEdit2.KeyDown += new System.Windows.Forms.KeyEventHandler(OnDown);
		this.colCRE.AppearanceHeader.Options.UseTextOptions = true;
		this.colCRE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colCRE.Caption = "Crédit";
		this.colCRE.ColumnEdit = this.repositoryItemSpinEdit2;
		this.colCRE.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.colCRE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.colCRE.FieldName = "CRE";
		this.colCRE.Name = "colCRE";
		this.colCRE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[1]
		{
			new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CRE", "{0:#,##0.00;#,##0.00; }")
		});
		this.colCRE.Visible = true;
		this.colCRE.VisibleIndex = 5;
		this.colCRE.Width = 133;
		this.colDAT.FieldName = "DAT";
		this.colDAT.Name = "colDAT";
		this.repositoryItemSearchLookUpEdit3.AutoHeight = false;
		this.repositoryItemSearchLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.repositoryItemSearchLookUpEdit3.DataSource = this.comptesBindingSource;
		this.repositoryItemSearchLookUpEdit3.DisplayMember = "CPT";
		this.repositoryItemSearchLookUpEdit3.Name = "repositoryItemSearchLookUpEdit3";
		this.repositoryItemSearchLookUpEdit3.NullText = "";
		this.repositoryItemSearchLookUpEdit3.PopupView = this.repositoryItemSearchLookUpEdit3View;
		this.repositoryItemSearchLookUpEdit3.SelectFirstRowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
		this.repositoryItemSearchLookUpEdit3.ShowAddNewButton = true;
		this.repositoryItemSearchLookUpEdit3.ValueMember = "CPT";
		this.repositoryItemSearchLookUpEdit3.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(repositoryItemSearchLookUpEdit3_AddNewValue);
		this.repositoryItemSearchLookUpEdit3.BeforePopup += new System.EventHandler(repositoryItemSearchLookUpEdit3_BeforePopup);
		this.repositoryItemSearchLookUpEdit3.Validating += new System.ComponentModel.CancelEventHandler(repositoryItemSearchLookUpEdit3_Validating);
		this.comptesBindingSource.AllowNew = false;
		this.comptesBindingSource.DataMember = "Comptes";
		this.comptesBindingSource.DataSource = this.dataSet1;
		this.comptesBindingSource.Filter = "";
		this.repositoryItemSearchLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colCPT1, this.colLIB1, this.colLIBAR });
		this.repositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
		this.repositoryItemSearchLookUpEdit3View.Name = "repositoryItemSearchLookUpEdit3View";
		this.repositoryItemSearchLookUpEdit3View.OptionsFind.FindFilterColumns = "CPT";
		this.repositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
		this.repositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
		this.colCPT1.Caption = "Compte";
		this.colCPT1.FieldName = "CPT";
		this.colCPT1.Name = "colCPT1";
		this.colCPT1.Visible = true;
		this.colCPT1.VisibleIndex = 0;
		this.colCPT1.Width = 311;
		this.colLIB1.Caption = "Libellé";
		this.colLIB1.FieldName = "LIB";
		this.colLIB1.Name = "colLIB1";
		this.colLIB1.Visible = true;
		this.colLIB1.VisibleIndex = 1;
		this.colLIB1.Width = 551;
		this.colLIBAR.AppearanceCell.Options.UseTextOptions = true;
		this.colLIBAR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.colLIBAR.Caption = "Libellé arabe";
		this.colLIBAR.FieldName = "LIBAR";
		this.colLIBAR.Name = "colLIBAR";
		this.colLIBAR.Visible = true;
		this.colLIBAR.VisibleIndex = 2;
		this.colLIBAR.Width = 631;
		this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
		this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.repositoryItemSearchLookUpEdit1.DataSource = this.tiersBindingSource;
		this.repositoryItemSearchLookUpEdit1.DisplayMember = "TRS";
		this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
		this.repositoryItemSearchLookUpEdit1.PopupView = this.repositoryItemSearchLookUpEdit1View;
		this.repositoryItemSearchLookUpEdit1.SelectFirstRowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
		this.repositoryItemSearchLookUpEdit1.ValueMember = "TRS";
		this.tiersBindingSource.DataMember = "Tiers";
		this.tiersBindingSource.DataSource = this.dataSet1;
		this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colTRS1, this.colLIB2, this.colLIBAR1 });
		this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
		this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
		this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
		this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
		this.colTRS1.FieldName = "TRS";
		this.colTRS1.Name = "colTRS1";
		this.colTRS1.Visible = true;
		this.colTRS1.VisibleIndex = 0;
		this.colTRS1.Width = 154;
		this.colLIB2.FieldName = "LIB";
		this.colLIB2.Name = "colLIB2";
		this.colLIB2.Visible = true;
		this.colLIB2.VisibleIndex = 1;
		this.colLIB2.Width = 576;
		this.colLIBAR1.FieldName = "LIBAR";
		this.colLIBAR1.Name = "colLIBAR1";
		this.colLIBAR1.Visible = true;
		this.colLIBAR1.VisibleIndex = 2;
		this.colLIBAR1.Width = 663;
		this.lib.EnterMoveNextControl = true;
		this.lib.Location = new System.Drawing.Point(257, 68);
		this.lib.Name = "lib";
		this.lib.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.lib.Properties.MaxLength = 30;
		this.lib.Size = new System.Drawing.Size(621, 20);
		this.lib.StyleController = this.layoutControl1;
		this.lib.TabIndex = 3;
		this.lib.EditValueChanged += new System.EventHandler(lib_EditValueChanged);
		this.lib.KeyDown += new System.Windows.Forms.KeyEventHandler(lib_KeyDown);
		this.SOLDN.Enabled = false;
		this.SOLDN.Location = new System.Drawing.Point(165, 486);
		this.SOLDN.Name = "SOLDN";
		this.SOLDN.Properties.AllowFocused = false;
		this.SOLDN.Properties.Appearance.Options.UseTextOptions = true;
		this.SOLDN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.SOLDN.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info;
		this.SOLDN.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.Info;
		this.SOLDN.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.InfoText;
		this.SOLDN.Properties.AppearanceDisabled.Options.UseBackColor = true;
		this.SOLDN.Properties.AppearanceDisabled.Options.UseForeColor = true;
		this.SOLDN.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.SOLDN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.SOLDN.Properties.ReadOnly = true;
		this.SOLDN.Size = new System.Drawing.Size(137, 20);
		this.SOLDN.StyleController = this.layoutControl1;
		this.SOLDN.TabIndex = 13;
		this.SOLDN.TabStop = false;
		this.SOLCN.Enabled = false;
		this.SOLCN.Location = new System.Drawing.Point(447, 486);
		this.SOLCN.Name = "SOLCN";
		this.SOLCN.Properties.AllowFocused = false;
		this.SOLCN.Properties.Appearance.Options.UseTextOptions = true;
		this.SOLCN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.SOLCN.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info;
		this.SOLCN.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.Info;
		this.SOLCN.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.InfoText;
		this.SOLCN.Properties.AppearanceDisabled.Options.UseBackColor = true;
		this.SOLCN.Properties.AppearanceDisabled.Options.UseForeColor = true;
		this.SOLCN.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.SOLCN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.SOLCN.Properties.ReadOnly = true;
		this.SOLCN.Size = new System.Drawing.Size(137, 20);
		this.SOLCN.StyleController = this.layoutControl1;
		this.SOLCN.TabIndex = 14;
		this.SOLCN.TabStop = false;
		this.tier.Enabled = false;
		this.tier.Location = new System.Drawing.Point(165, 390);
		this.tier.Name = "tier";
		this.tier.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info;
		this.tier.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.Info;
		this.tier.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.InfoText;
		this.tier.Properties.AppearanceDisabled.Options.UseBackColor = true;
		this.tier.Properties.AppearanceDisabled.Options.UseForeColor = true;
		this.tier.Properties.ReadOnly = true;
		this.tier.Size = new System.Drawing.Size(419, 20);
		this.tier.StyleController = this.layoutControl1;
		this.tier.TabIndex = 15;
		this.tier.TabStop = false;
		this.Compte.Enabled = false;
		this.Compte.Location = new System.Drawing.Point(165, 414);
		this.Compte.Name = "Compte";
		this.Compte.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Info;
		this.Compte.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.Info;
		this.Compte.Properties.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.InfoText;
		this.Compte.Properties.AppearanceDisabled.Options.UseBackColor = true;
		this.Compte.Properties.AppearanceDisabled.Options.UseForeColor = true;
		this.Compte.Properties.ReadOnly = true;
		this.Compte.Size = new System.Drawing.Size(419, 20);
		this.Compte.StyleController = this.layoutControl1;
		this.Compte.TabIndex = 16;
		this.Compte.TabStop = false;
		this.mois.EnterMoveNextControl = true;
		this.mois.Location = new System.Drawing.Point(427, 44);
		this.mois.Name = "mois";
		this.mois.Properties.Appearance.Options.UseTextOptions = true;
		this.mois.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.mois.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.mois.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[1]
		{
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LIB", "LIB", 27, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
		});
		this.mois.Properties.DataSource = this.lesMoisBindingSource;
		this.mois.Properties.DisplayMember = "LIB";
		this.mois.Properties.NullText = "";
		this.mois.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
		this.mois.Properties.PopupSizeable = false;
		this.mois.Properties.ValueMember = "MOIS";
		this.mois.Size = new System.Drawing.Size(110, 20);
		this.mois.StyleController = this.layoutControl1;
		this.mois.TabIndex = 2;
		this.mois.EditValueChanged += new System.EventHandler(mois_EditValueChanged);
		this.mois.KeyDown += new System.Windows.Forms.KeyEventHandler(mois_KeyDown);
		this.lesMoisBindingSource.DataMember = "LesMois";
		this.lesMoisBindingSource.DataSource = this.dataSet1;
		this.dateEcriture.EditValue = null;
		this.dateEcriture.Location = new System.Drawing.Point(734, 22);
		this.dateEcriture.Name = "dateEcriture";
		this.dateEcriture.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.dateEcriture.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.dateEcriture.Size = new System.Drawing.Size(230, 20);
		this.dateEcriture.StyleController = this.layoutControl1;
		this.dateEcriture.TabIndex = 17;
		this.dat.EditValue = null;
		this.dat.EnterMoveNextControl = true;
		this.dat.Location = new System.Drawing.Point(598, 44);
		this.dat.Name = "dat";
		this.dat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
		this.dat.Properties.Appearance.Options.UseTextOptions = true;
		this.dat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.dat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.dat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.dat.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.dat.Properties.NullDate = new System.DateTime(2020, 8, 15, 12, 48, 23, 295);
		this.dat.Size = new System.Drawing.Size(109, 20);
		this.dat.StyleController = this.layoutControl1;
		this.dat.TabIndex = 18;
		this.dat.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(dat_InvalidValue);
		this.dat.EnabledChanged += new System.EventHandler(dat_EnabledChanged);
		this.dat.KeyDown += new System.Windows.Forms.KeyEventHandler(mois_KeyDown);
		this.dat.Validating += new System.ComponentModel.CancelEventHandler(dat_Validating);
		this.dat.Validated += new System.EventHandler(dat_Validated);
		this.scre.EditValue = new decimal(new int[4]);
		this.scre.Enabled = false;
		this.scre.Location = new System.Drawing.Point(747, 358);
		this.scre.Margin = new System.Windows.Forms.Padding(2);
		this.scre.Name = "scre";
		this.scre.Properties.AllowFocused = false;
		this.scre.Properties.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
		this.scre.Properties.Appearance.Options.UseBackColor = true;
		this.scre.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.scre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)
		});
		this.scre.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.scre.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.scre.Size = new System.Drawing.Size(143, 18);
		this.scre.StyleController = this.layoutControl1;
		this.scre.TabIndex = 20;
		this.scre.TabStop = false;
		this.scre.Visible = false;
		this.sdeb.EditValue = new decimal(new int[4]);
		this.sdeb.Enabled = false;
		this.sdeb.Location = new System.Drawing.Point(600, 358);
		this.sdeb.Margin = new System.Windows.Forms.Padding(2);
		this.sdeb.Name = "sdeb";
		this.sdeb.Properties.AllowFocused = false;
		this.sdeb.Properties.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
		this.sdeb.Properties.Appearance.Options.UseBackColor = true;
		this.sdeb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.sdeb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)
		});
		this.sdeb.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.sdeb.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.sdeb.Size = new System.Drawing.Size(143, 18);
		this.sdeb.StyleController = this.layoutControl1;
		this.sdeb.TabIndex = 21;
		this.sdeb.TabStop = false;
		this.sdeb.Visible = false;
		this.jnl.EnterMoveNextControl = true;
		this.jnl.Location = new System.Drawing.Point(24, 44);
		this.jnl.Margin = new System.Windows.Forms.Padding(2);
		this.jnl.Name = "jnl";
		this.jnl.Properties.Appearance.Options.UseTextOptions = true;
		this.jnl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.jnl.Properties.MaxLength = 2;
		this.jnl.Size = new System.Drawing.Size(148, 20);
		this.jnl.StyleController = this.layoutControl1;
		this.jnl.TabIndex = 0;
		this.jnl.Enter += new System.EventHandler(jnl_Enter);
		this.jnl.KeyDown += new System.Windows.Forms.KeyEventHandler(textEdit1_KeyDown);
		this.jnl.Validating += new System.ComponentModel.CancelEventHandler(textEdit1_Validating);
		this.jnl.Validated += new System.EventHandler(textEdit1_Validated);
		this.piece.EditValue = new decimal(new int[4]);
		this.piece.EnterMoveNextControl = true;
		this.piece.Location = new System.Drawing.Point(257, 44);
		this.piece.Name = "piece";
		this.piece.Properties.Appearance.Options.UseTextOptions = true;
		this.piece.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.piece.Properties.DisplayFormat.FormatString = "0;0; ";
		this.piece.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
		this.piece.Properties.IsFloatValue = false;
		this.piece.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
		this.piece.Properties.Mask.SaveLiteral = false;
		this.piece.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.piece.Properties.MaxLength = 6;
		this.piece.Properties.ValidateOnEnterKey = true;
		this.piece.Size = new System.Drawing.Size(109, 20);
		this.piece.StyleController = this.layoutControl1;
		this.piece.TabIndex = 1;
		this.piece.EditValueChanged += new System.EventHandler(piece_EditValueChanged);
		this.piece.Enter += new System.EventHandler(piece_Enter);
		this.piece.KeyDown += new System.Windows.Forms.KeyEventHandler(piece_KeyDown);
		this.piece.Validated += new System.EventHandler(piece_Validated);
		this.DebitNM1.Location = new System.Drawing.Point(165, 438);
		this.DebitNM1.Name = "DebitNM1";
		this.DebitNM1.Properties.Appearance.Options.UseTextOptions = true;
		this.DebitNM1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.DebitNM1.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.DebitNM1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.DebitNM1.Size = new System.Drawing.Size(137, 20);
		this.DebitNM1.StyleController = this.layoutControl1;
		this.DebitNM1.TabIndex = 22;
		this.CreditNM1.Location = new System.Drawing.Point(447, 438);
		this.CreditNM1.Name = "CreditNM1";
		this.CreditNM1.Properties.Appearance.Options.UseTextOptions = true;
		this.CreditNM1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.CreditNM1.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.CreditNM1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.CreditNM1.Properties.ReadOnly = true;
		this.CreditNM1.Size = new System.Drawing.Size(137, 20);
		this.CreditNM1.StyleController = this.layoutControl1;
		this.CreditNM1.TabIndex = 23;
		this.DebitN.Location = new System.Drawing.Point(165, 462);
		this.DebitN.Name = "DebitN";
		this.DebitN.Properties.Appearance.Options.UseTextOptions = true;
		this.DebitN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.DebitN.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.DebitN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.DebitN.Size = new System.Drawing.Size(137, 20);
		this.DebitN.StyleController = this.layoutControl1;
		this.DebitN.TabIndex = 24;
		this.CreditN.Location = new System.Drawing.Point(447, 462);
		this.CreditN.Name = "CreditN";
		this.CreditN.Properties.Appearance.Options.UseTextOptions = true;
		this.CreditN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.CreditN.Properties.DisplayFormat.FormatString = "{0:#,##0.00;#,##0.00; }";
		this.CreditN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.CreditN.Size = new System.Drawing.Size(137, 20);
		this.CreditN.StyleController = this.layoutControl1;
		this.CreditN.TabIndex = 25;
		this.pardate22.Control = this.dateEcriture;
		this.pardate22.Location = new System.Drawing.Point(698, 0);
		this.pardate22.Name = "pardate22";
		this.pardate22.Size = new System.Drawing.Size(390, 26);
		this.pardate22.Text = "Date";
		this.pardate22.TextSize = new System.Drawing.Size(93, 13);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[7] { this.layoutControlGroup2, this.layoutControlGroup1, this.layoutControlItem5, this.layoutControlItem14, this.layoutControlItem15, this.layoutControlGroup3, this.layoutControlItem10 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(902, 530);
		this.Root.TextVisible = false;
		this.layoutControlGroup2.AppearanceGroup.Options.UseTextOptions = true;
		this.layoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem16 });
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup2.Name = "layoutControlGroup2";
		this.layoutControlGroup2.Size = new System.Drawing.Size(176, 92);
		this.layoutControlGroup2.Text = "Journal";
		this.layoutControlItem16.Control = this.jnl;
		this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.Size = new System.Drawing.Size(152, 48);
		this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem16.TextVisible = false;
		this.layoutControlGroup1.AppearanceGroup.Options.UseTextOptions = true;
		this.layoutControlGroup1.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[5] { this.layoutControlItem4, this.parbordereau, this.layoutControlItem2, this.pardate, this.emptySpaceItem2 });
		this.layoutControlGroup1.Location = new System.Drawing.Point(176, 0);
		this.layoutControlGroup1.Name = "layoutControlGroup1";
		this.layoutControlGroup1.Size = new System.Drawing.Size(706, 92);
		this.layoutControlGroup1.Text = "Pièce";
		this.layoutControlItem4.Control = this.lib;
		this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
		this.layoutControlItem4.Name = "layoutControlItem4";
		this.layoutControlItem4.Size = new System.Drawing.Size(682, 24);
		this.layoutControlItem4.Text = "Libellé";
		this.layoutControlItem4.TextSize = new System.Drawing.Size(54, 13);
		this.parbordereau.Control = this.mois;
		this.parbordereau.Location = new System.Drawing.Point(170, 0);
		this.parbordereau.Name = "parbordereau";
		this.parbordereau.Size = new System.Drawing.Size(171, 24);
		this.parbordereau.Text = "Bordereau";
		this.parbordereau.TextSize = new System.Drawing.Size(54, 13);
		this.layoutControlItem2.Control = this.piece;
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(170, 24);
		this.layoutControlItem2.Text = "Numéro";
		this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
		this.pardate.Control = this.dat;
		this.pardate.Location = new System.Drawing.Point(341, 0);
		this.pardate.Name = "pardate";
		this.pardate.Size = new System.Drawing.Size(170, 24);
		this.pardate.Text = "Date";
		this.pardate.TextSize = new System.Drawing.Size(54, 13);
		this.emptySpaceItem2.AllowHotTrack = false;
		this.emptySpaceItem2.Location = new System.Drawing.Point(511, 0);
		this.emptySpaceItem2.Name = "emptySpaceItem2";
		this.emptySpaceItem2.Size = new System.Drawing.Size(171, 24);
		this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem5.Control = this.gridControl1;
		this.layoutControlItem5.Location = new System.Drawing.Point(0, 92);
		this.layoutControlItem5.Name = "layoutControlItem5";
		this.layoutControlItem5.Size = new System.Drawing.Size(882, 254);
		this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem5.TextVisible = false;
		this.layoutControlItem14.Control = this.scre;
		this.layoutControlItem14.Location = new System.Drawing.Point(735, 346);
		this.layoutControlItem14.Name = "layoutControlItem14";
		this.layoutControlItem14.Size = new System.Drawing.Size(147, 22);
		this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem14.TextVisible = false;
		this.layoutControlItem15.Control = this.sdeb;
		this.layoutControlItem15.Location = new System.Drawing.Point(588, 346);
		this.layoutControlItem15.Name = "layoutControlItem15";
		this.layoutControlItem15.Size = new System.Drawing.Size(147, 22);
		this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem15.TextVisible = false;
		this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[16]
		{
			this.soldeN, this.layoutControlItem11, this.layoutControlItem12, this.layoutControlItem13, this.simpleLabelItem2, this.txtSOLDN, this.emptySpaceItem3, this.simpleLabelItem1, this.layoutControlItem1, this.layoutControlItem3,
			this.simpleLabelItem3, this.emptySpaceItem4, this.layoutControlItem6, this.layoutControlItem7, this.emptySpaceItem5, this.simpleLabelItem4
		});
		this.layoutControlGroup3.Location = new System.Drawing.Point(0, 346);
		this.layoutControlGroup3.Name = "layoutControlGroup3";
		this.layoutControlGroup3.Size = new System.Drawing.Size(588, 164);
		this.layoutControlGroup3.Text = " ";
		this.soldeN.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.WindowText;
		this.soldeN.AppearanceItemCaption.Options.UseForeColor = true;
		this.soldeN.Control = this.SOLDN;
		this.soldeN.Location = new System.Drawing.Point(141, 96);
		this.soldeN.Name = "soldeN";
		this.soldeN.Size = new System.Drawing.Size(141, 24);
		this.soldeN.Text = "Solde (N)";
		this.soldeN.TextSize = new System.Drawing.Size(0, 0);
		this.soldeN.TextVisible = false;
		this.layoutControlItem11.Control = this.SOLCN;
		this.layoutControlItem11.Location = new System.Drawing.Point(423, 96);
		this.layoutControlItem11.Name = "layoutControlItem11";
		this.layoutControlItem11.Size = new System.Drawing.Size(141, 24);
		this.layoutControlItem11.Text = " ";
		this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem11.TextVisible = false;
		this.layoutControlItem12.Control = this.tier;
		this.layoutControlItem12.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.False;
		this.layoutControlItem12.Location = new System.Drawing.Point(141, 0);
		this.layoutControlItem12.Name = "layoutControlItem12";
		this.layoutControlItem12.Size = new System.Drawing.Size(423, 24);
		this.layoutControlItem12.Text = "Tiers";
		this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem12.TextVisible = false;
		this.layoutControlItem13.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.WindowText;
		this.layoutControlItem13.AppearanceItemCaption.Options.UseForeColor = true;
		this.layoutControlItem13.Control = this.Compte;
		this.layoutControlItem13.Location = new System.Drawing.Point(141, 24);
		this.layoutControlItem13.Name = "layoutControlItem13";
		this.layoutControlItem13.Size = new System.Drawing.Size(423, 24);
		this.layoutControlItem13.Text = "Compte";
		this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem13.TextVisible = false;
		this.simpleLabelItem2.AllowHotTrack = false;
		this.simpleLabelItem2.Location = new System.Drawing.Point(0, 24);
		this.simpleLabelItem2.Name = "simpleLabelItem2";
		this.simpleLabelItem2.Size = new System.Drawing.Size(141, 24);
		this.simpleLabelItem2.Text = "Compte";
		this.simpleLabelItem2.TextSize = new System.Drawing.Size(54, 13);
		this.txtSOLDN.AllowHotTrack = false;
		this.txtSOLDN.Location = new System.Drawing.Point(0, 96);
		this.txtSOLDN.MinSize = new System.Drawing.Size(111, 17);
		this.txtSOLDN.Name = "txtSOLDN";
		this.txtSOLDN.Size = new System.Drawing.Size(141, 24);
		this.txtSOLDN.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.txtSOLDN.Text = "Solde (N)";
		this.txtSOLDN.TextSize = new System.Drawing.Size(54, 13);
		this.emptySpaceItem3.AllowHotTrack = false;
		this.emptySpaceItem3.Location = new System.Drawing.Point(282, 96);
		this.emptySpaceItem3.Name = "emptySpaceItem3";
		this.emptySpaceItem3.Size = new System.Drawing.Size(141, 24);
		this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
		this.simpleLabelItem1.AllowHotTrack = false;
		this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
		this.simpleLabelItem1.Name = "simpleLabelItem1";
		this.simpleLabelItem1.Size = new System.Drawing.Size(141, 24);
		this.simpleLabelItem1.Text = "Tiers";
		this.simpleLabelItem1.TextSize = new System.Drawing.Size(54, 13);
		this.layoutControlItem1.Control = this.DebitNM1;
		this.layoutControlItem1.Location = new System.Drawing.Point(141, 48);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(141, 24);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.layoutControlItem3.Control = this.CreditNM1;
		this.layoutControlItem3.Location = new System.Drawing.Point(423, 48);
		this.layoutControlItem3.Name = "layoutControlItem3";
		this.layoutControlItem3.Size = new System.Drawing.Size(141, 24);
		this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem3.TextVisible = false;
		this.simpleLabelItem3.AllowHotTrack = false;
		this.simpleLabelItem3.Location = new System.Drawing.Point(0, 48);
		this.simpleLabelItem3.MinSize = new System.Drawing.Size(111, 17);
		this.simpleLabelItem3.Name = "simpleLabelItem3";
		this.simpleLabelItem3.Size = new System.Drawing.Size(141, 24);
		this.simpleLabelItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.simpleLabelItem3.Text = "Solde (N-1)";
		this.simpleLabelItem3.TextSize = new System.Drawing.Size(54, 13);
		this.emptySpaceItem4.AllowHotTrack = false;
		this.emptySpaceItem4.Location = new System.Drawing.Point(282, 48);
		this.emptySpaceItem4.Name = "emptySpaceItem4";
		this.emptySpaceItem4.Size = new System.Drawing.Size(141, 24);
		this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem6.Control = this.DebitN;
		this.layoutControlItem6.Location = new System.Drawing.Point(141, 72);
		this.layoutControlItem6.Name = "layoutControlItem6";
		this.layoutControlItem6.Size = new System.Drawing.Size(141, 24);
		this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem6.TextVisible = false;
		this.layoutControlItem7.Control = this.CreditN;
		this.layoutControlItem7.Location = new System.Drawing.Point(423, 72);
		this.layoutControlItem7.Name = "layoutControlItem7";
		this.layoutControlItem7.Size = new System.Drawing.Size(141, 24);
		this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem7.TextVisible = false;
		this.emptySpaceItem5.AllowHotTrack = false;
		this.emptySpaceItem5.Location = new System.Drawing.Point(282, 72);
		this.emptySpaceItem5.Name = "emptySpaceItem5";
		this.emptySpaceItem5.Size = new System.Drawing.Size(141, 24);
		this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
		this.simpleLabelItem4.AllowHotTrack = false;
		this.simpleLabelItem4.Location = new System.Drawing.Point(0, 72);
		this.simpleLabelItem4.MinSize = new System.Drawing.Size(111, 17);
		this.simpleLabelItem4.Name = "simpleLabelItem4";
		this.simpleLabelItem4.Size = new System.Drawing.Size(141, 24);
		this.simpleLabelItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.simpleLabelItem4.Text = "MVT (N)";
		this.simpleLabelItem4.TextSize = new System.Drawing.Size(54, 13);
		this.layoutControlItem10.Control = this.btnEnregistrer;
		this.layoutControlItem10.Location = new System.Drawing.Point(588, 368);
		this.layoutControlItem10.MinSize = new System.Drawing.Size(108, 26);
		this.layoutControlItem10.Name = "layoutControlItem10";
		this.layoutControlItem10.Size = new System.Drawing.Size(294, 142);
		this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem10.TextVisible = false;
		this.journauxBindingSource.DataMember = "Journaux";
		this.journauxBindingSource.DataSource = this.dataSet1;
		this.journauxTableAdapter.ClearBeforeFill = true;
		this.lesMoisTableAdapter.ClearBeforeFill = true;
		this.ecritures_tTableAdapter.ClearBeforeFill = true;
		this.comptesTableAdapter.ClearBeforeFill = true;
		this.tiersTableAdapter.ClearBeforeFill = true;
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(1134, 0);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(10, 329);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.dxErrorProvider1.ContainerControl = this;
		this.imageCollection1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imageCollection1.ImageStream");
		this.imageCollection1.InsertImage(compta.Properties.Resources.copy_16x16, "copy_16x16", typeof(compta.Properties.Resources), 0);
		this.imageCollection1.Images.SetKeyName(0, "copy_16x16");
		this.imageCollection1.InsertImage(compta.Properties.Resources.paste_16x16, "paste_16x16", typeof(compta.Properties.Resources), 1);
		this.imageCollection1.Images.SetKeyName(1, "paste_16x16");
		this.imageCollection1.InsertImage(compta.Properties.Resources.deletetablerows_16x16, "deletetablerows_16x16", typeof(compta.Properties.Resources), 2);
		this.imageCollection1.Images.SetKeyName(2, "deletetablerows_16x16");
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoSize = true;
		this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
		base.ClientSize = new System.Drawing.Size(897, 525);
		base.Controls.Add(this.layoutControl1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.IconOptions.Image = compta.Properties.Resources.showworktimeonly_32x32;
		this.MdiChildCaptionFormatString = "";
		base.Name = "frmEcritures";
		this.Text = "Ecriture Comptables";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		base.Load += new System.EventHandler(frmEcritures_Load);
		base.KeyDown += new System.Windows.Forms.KeyEventHandler(frmEcritures_KeyDown);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.gridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ecriturestBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSpinEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemTextEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSpinEdit2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.comptesBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit3View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tiersBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemSearchLookUpEdit1View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.lib.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.SOLDN.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.SOLCN.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tier.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Compte.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mois.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.lesMoisBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dateEcriture.Properties.CalendarTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dateEcriture.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dat.Properties.CalendarTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dat.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.scre.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.sdeb.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.jnl.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.piece.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DebitNM1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CreditNM1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DebitN.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CreditN.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pardate22).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.parbordereau).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pardate).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem14).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem15).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.soldeN).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem11).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem12).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem13).EndInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtSOLDN).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.simpleLabelItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem10).EndInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dxErrorProvider1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.imageCollection1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.behaviorManager1).EndInit();
		base.ResumeLayout(false);
	}
}
