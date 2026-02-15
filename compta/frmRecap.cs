using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using compta.DataSet1TableAdapters;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.UI;

namespace compta;

public class frmRecap : XtraForm
{
	private bool tva;

	private DataTable dtcompte = new DataTable();

	private OleDbDataAdapter adcompte;

	private IContainer components;

	private LayoutControl layoutControl1;

	private LayoutControlGroup Root;

	private SimpleButton simpleButton1;

	private SpinEdit du;

	private SpinEdit exer;

	private LayoutControlItem layoutControlItem1;

	private LayoutControlItem layoutControlItem2;

	private LayoutControlItem layoutControlItem3;

	private LayoutControlItem layoutControlItem6;

	private EmptySpaceItem emptySpaceItem2;

	private EmptySpaceItem emptySpaceItem4;

	private DataSet1 dataSet1;

	private BindingSource dossiersBindingSource;

	private DossiersTableAdapter dossiersTableAdapter;

	private SearchLookUpEdit dos;

	private GridView searchLookUpEdit1View;

	private GridColumn colUNI;

	private GridColumn colLIB1;

	private ListBoxControl listBoxControl1;

	private LayoutControlItem layoutControlItem5;

	private ListBoxControl listBoxControl2;

	private LayoutControlItem layoutControlItem7;

	private EmptySpaceItem emptySpaceItem1;

	private LayoutControlGroup layoutControlGroup2;

	public frmRecap(bool _tva)
	{
		InitializeComponent();
		tva = _tva;
	}

	private void frmEtatJournaux_Load(object sender, EventArgs e)
	{
		string connection = monModule.gConnString;
		dossiersTableAdapter.Connection.ConnectionString = connection;
		dossiersTableAdapter.Fill(dataSet1.Dossiers);
		exer.EditValue = monModule.gExercice;
		dos.EditValue = monModule.gUNI;
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		DataTable dt = new DataTable();
		string eExercice = exer.Text;
		string min = du.Text;
		monModule.eMOIS = Convert.ToInt32(min);
		string uni = (monModule.eUNI = dos.EditValue.ToString());
		monModule.eExercice = eExercice;
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + uni + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			monModule.eUNILIB = foundRows[0]["LIB"].ToString();
		}
		string ll = "";
		string rr = "";
		string lc = "";
		string sql = ((!tva) ? "SELECT   Tiers.NUMIF AS NIFTRS, Tiers.NUMAI AS AITRS, Tiers.RC AS RCTRS, Tiers.TRS AS CODETRS, Tiers.LIB AS NOMTRS, Tiers.ADR & ' ' & Villes.LIB AS ADRTRS, Ecritures.LIB AS LIBECR, Ecritures.DAT AS DATEECR," : "SELECT   Tiers.NUMIF AS NIFTRS, Tiers.NUMAI AS AITRS, Tiers.RC AS RCTRS, Tiers.TRS AS CODETRS, Tiers.LIB AS NOMTRS, Tiers.ADR & ' ' & Villes.LIB AS ADRTRS, ");
		foreach (DataRowView row in (IEnumerable<object>)listBoxControl1.SelectedItems)
		{
			ll = ll + "OR  (Ecritures.CPT='" + row.Row["CPT"].ToString() + "')";
		}
		sql = ((!(ll != "")) ? (sql + " 0 AS CL1") : (sql + " SUM(iif(" + ll.Substring(2) + ", ABS(Ecritures.DEB - Ecritures.CRE), 0)) AS CL1,"));
		foreach (DataRowView row2 in (IEnumerable<object>)listBoxControl1.SelectedItems)
		{
			rr = rr + "OR  (Ecritures.CPT='" + row2.Row["CPT"].ToString() + "')";
		}
		sql = ((!(rr != "")) ? (sql + " 0 AS CL2") : (sql + " SUM(iif(" + rr.Substring(2) + ", ABS(Ecritures.DEB - Ecritures.CRE), 0)) AS CL2"));
		lc = ((ll != "") ? ("(" + rr.Substring(2) + " " + rr + ")") : ((!(rr != "")) ? "(Ecritures.CPT='-')" : rr.Substring(2)));
		sql = ((!tva) ? (sql + "  FROM Villes INNER JOIN (Tiers INNER JOIN (Comptes INNER JOIN Ecritures ON Comptes.CPT = Ecritures.CPT) ON (Tiers.TRS = Ecritures.TRS) AND (Tiers.UNI = Ecritures.UNI)) ON Villes.CP = Tiers.CP  Where (Ecritures.Exercice= " + monModule.eExercice + " and Ecritures.UNI= '" + monModule.eUNI + "') And (Comptes.TRS= 'O') and (" + lc + ")  and (month(Ecritures.DAT)=" + min + ")   GROUP BY Tiers.NUMIF, Tiers.NUMAI, Tiers.RC,Tiers.TRS, Tiers.LIB, Tiers.ADR & ' ' & Villes.LIB, Ecritures.LIB, Ecritures.DAT, Ecritures.JA, Ecritures.NOP  ORDER BY Tiers.TRS, Ecritures.DAT ") : (sql + " FROM Villes INNER JOIN(Tiers INNER JOIN (Comptes INNER JOIN Ecritures ON Comptes.CPT = Ecritures.CPT) ON(Tiers.TRS = Ecritures.TRS) AND(Tiers.UNI = Ecritures.UNI)) ON Villes.CP = Tiers.CP  Where (Ecritures.Exercice= " + monModule.eExercice + " and Ecritures.UNI= '" + monModule.eUNI + "') And (Comptes.TRS= 'O') and (" + lc + ")    GROUP BY Tiers.NUMIF, Tiers.NUMAI, Tiers.RC,Tiers.TRS, Tiers.LIB, Tiers.ADR & ' ' & Villes.LIB ORDER BY Tiers.TRS  "));
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sql, monModule.gbase);
		dt.Clear();
		oleDbDataAdapter.Fill(dt);
		if (tva)
		{
			ReportPrintTool reportPrintTool = new ReportPrintTool(new rptTVA
			{
				DataSource = dt
			});
			Close();
			reportPrintTool.ShowPreview();
		}
		else
		{
			ReportPrintTool reportPrintTool2 = new ReportPrintTool(new rptAchat
			{
				DataSource = dt
			});
			Close();
			reportPrintTool2.ShowPreview();
		}
	}

	private void listBoxControl1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
		{
			listBoxControl1.SelectAll();
			return;
		}
		if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
		{
			listBoxControl1.UnSelectAll();
			return;
		}
		switch (e.KeyCode)
		{
		case Keys.Return:
			simpleButton1_Click(sender, null);
			break;
		case Keys.Escape:
			du.Focus();
			break;
		}
	}

	private void du_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			exer.Focus();
		}
	}

	private void exer_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			dos.Focus();
		}
	}

	private void dos_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void dos_EditValueChanged(object sender, EventArgs e)
	{
		monModule.eUNI = dos.EditValue.ToString();
		adcompte = new OleDbDataAdapter("SELECT DISTINCT CPT  From Ecritures where UNI='" + monModule.eUNI + "' and TRS<>'-'", monModule.gbase);
		dtcompte.Clear();
		adcompte.Fill(dtcompte);
		listBoxControl1.DataSource = dtcompte;
		listBoxControl2.DataSource = dtcompte;
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
		DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmRecap));
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
		this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
		this.du = new DevExpress.XtraEditors.SpinEdit();
		this.exer = new DevExpress.XtraEditors.SpinEdit();
		this.dos = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.dossiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.dossiersTableAdapter = new compta.DataSet1TableAdapters.DossiersTableAdapter();
		this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
		this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.listBoxControl2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.listBoxControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.du.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.exer.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Controls.Add(this.listBoxControl2);
		this.layoutControl1.Controls.Add(this.listBoxControl1);
		this.layoutControl1.Controls.Add(this.simpleButton1);
		this.layoutControl1.Controls.Add(this.du);
		this.layoutControl1.Controls.Add(this.exer);
		this.layoutControl1.Controls.Add(this.dos);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(392, 333);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.listBoxControl2.DisplayMember = "CPT";
		this.listBoxControl2.Location = new System.Drawing.Point(201, 79);
		this.listBoxControl2.Margin = new System.Windows.Forms.Padding(2);
		this.listBoxControl2.Name = "listBoxControl2";
		this.listBoxControl2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
		this.listBoxControl2.Size = new System.Drawing.Size(179, 216);
		this.listBoxControl2.StyleController = this.layoutControl1;
		this.listBoxControl2.TabIndex = 6;
		this.listBoxControl2.ValueMember = "CPT";
		this.listBoxControl1.DisplayMember = "CPT";
		this.listBoxControl1.Location = new System.Drawing.Point(12, 79);
		this.listBoxControl1.Margin = new System.Windows.Forms.Padding(2);
		this.listBoxControl1.Name = "listBoxControl1";
		this.listBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
		this.listBoxControl1.Size = new System.Drawing.Size(175, 216);
		this.listBoxControl1.StyleController = this.layoutControl1;
		this.listBoxControl1.TabIndex = 4;
		this.listBoxControl1.ValueMember = "CPT";
		this.listBoxControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(listBoxControl1_KeyDown);
		this.du.EditValue = new decimal(new int[4] { 1, 0, 0, 0 });
		this.du.EnterMoveNextControl = true;
		this.du.Location = new System.Drawing.Point(55, 60);
		this.du.Margin = new System.Windows.Forms.Padding(2);
		this.du.Name = "du";
		this.du.Properties.Appearance.Options.UseTextOptions = true;
		this.du.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.du.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.du.Properties.DisplayFormat.FormatString = "{0:00}";
		this.du.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.du.Properties.IsFloatValue = false;
		this.du.Properties.Mask.EditMask = "N00";
		this.du.Properties.MaxValue = new decimal(new int[4] { 12, 0, 0, 0 });
		this.du.Properties.MinValue = new decimal(new int[4] { 1, 0, 0, 0 });
		this.du.Size = new System.Drawing.Size(44, 20);
		this.du.StyleController = this.layoutControl1;
		this.du.TabIndex = 2;
		this.du.KeyDown += new System.Windows.Forms.KeyEventHandler(du_KeyDown);
		this.exer.EditValue = new decimal(new int[4] { 1999, 0, 0, 0 });
		this.exer.EnterMoveNextControl = true;
		this.exer.Location = new System.Drawing.Point(55, 36);
		this.exer.Margin = new System.Windows.Forms.Padding(2);
		this.exer.Name = "exer";
		this.exer.Properties.Appearance.Options.UseTextOptions = true;
		this.exer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.exer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.exer.Properties.DisplayFormat.FormatString = "{0:0000}";
		this.exer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.exer.Properties.IsFloatValue = false;
		this.exer.Properties.Mask.EditMask = "\\d\\d\\d\\d";
		this.exer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
		this.exer.Properties.MaxValue = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.exer.Properties.MinValue = new decimal(new int[4] { 1999, 0, 0, 0 });
		this.exer.Size = new System.Drawing.Size(108, 20);
		this.exer.StyleController = this.layoutControl1;
		this.exer.TabIndex = 1;
		this.exer.KeyDown += new System.Windows.Forms.KeyEventHandler(exer_KeyDown);
		this.dos.EditValue = "001";
		this.dos.EnterMoveNextControl = true;
		this.dos.Location = new System.Drawing.Point(55, 12);
		this.dos.Margin = new System.Windows.Forms.Padding(2);
		this.dos.Name = "dos";
		this.dos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.dos.Properties.DataSource = this.dossiersBindingSource;
		this.dos.Properties.DisplayMember = "LIB";
		this.dos.Properties.NullText = "";
		this.dos.Properties.PopupView = this.searchLookUpEdit1View;
		this.dos.Properties.ValueMember = "UNI";
		this.dos.Size = new System.Drawing.Size(325, 20);
		this.dos.StyleController = this.layoutControl1;
		this.dos.TabIndex = 0;
		this.dos.EditValueChanged += new System.EventHandler(dos_EditValueChanged);
		this.dos.KeyDown += new System.Windows.Forms.KeyEventHandler(dos_KeyDown);
		this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.colUNI, this.colLIB1 });
		this.searchLookUpEdit1View.DetailHeight = 253;
		this.searchLookUpEdit1View.FixedLineWidth = 1;
		this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
		this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
		this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
		this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
		this.colUNI.Caption = "Code";
		this.colUNI.FieldName = "UNI";
		this.colUNI.MinWidth = 15;
		this.colUNI.Name = "colUNI";
		this.colUNI.Visible = true;
		this.colUNI.VisibleIndex = 0;
		this.colUNI.Width = 22;
		this.colLIB1.Caption = "Intitulé";
		this.colLIB1.FieldName = "LIB";
		this.colLIB1.MinWidth = 15;
		this.colLIB1.Name = "colLIB1";
		this.colLIB1.Visible = true;
		this.colLIB1.VisibleIndex = 1;
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[9] { this.layoutControlItem1, this.layoutControlItem2, this.layoutControlItem3, this.emptySpaceItem2, this.emptySpaceItem4, this.layoutControlItem5, this.layoutControlItem7, this.emptySpaceItem1, this.layoutControlGroup2 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(392, 333);
		this.Root.TextVisible = false;
		this.layoutControlItem1.Control = this.dos;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(372, 24);
		this.layoutControlItem1.Text = "Dossier";
		this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
		this.layoutControlItem2.Control = this.exer;
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(155, 24);
		this.layoutControlItem2.Text = "Exercice";
		this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 13);
		this.layoutControlItem3.Control = this.du;
		this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
		this.layoutControlItem3.MaxSize = new System.Drawing.Size(91, 19);
		this.layoutControlItem3.MinSize = new System.Drawing.Size(91, 19);
		this.layoutControlItem3.Name = "layoutControlItem3";
		this.layoutControlItem3.Size = new System.Drawing.Size(91, 19);
		this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.layoutControlItem3.Text = "Du";
		this.layoutControlItem3.TextSize = new System.Drawing.Size(40, 13);
		this.emptySpaceItem2.AllowHotTrack = false;
		this.emptySpaceItem2.Location = new System.Drawing.Point(91, 48);
		this.emptySpaceItem2.Name = "emptySpaceItem2";
		this.emptySpaceItem2.Size = new System.Drawing.Size(281, 19);
		this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem4.AllowHotTrack = false;
		this.emptySpaceItem4.Location = new System.Drawing.Point(155, 24);
		this.emptySpaceItem4.Name = "emptySpaceItem4";
		this.emptySpaceItem4.Size = new System.Drawing.Size(217, 24);
		this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem5.Control = this.listBoxControl1;
		this.layoutControlItem5.Location = new System.Drawing.Point(0, 67);
		this.layoutControlItem5.Name = "layoutControlItem5";
		this.layoutControlItem5.Size = new System.Drawing.Size(179, 220);
		this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem5.TextVisible = false;
		this.layoutControlItem7.Control = this.listBoxControl2;
		this.layoutControlItem7.Location = new System.Drawing.Point(189, 67);
		this.layoutControlItem7.Name = "layoutControlItem7";
		this.layoutControlItem7.Size = new System.Drawing.Size(183, 220);
		this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem7.TextVisible = false;
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(179, 67);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(10, 220);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup2.GroupBordersVisible = false;
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem6 });
		this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 287);
		this.layoutControlGroup2.Name = "layoutControlGroup2";
		columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition1.Width = 33.333333333333336;
		columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition2.Width = 33.333333333333336;
		columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition3.Width = 33.333333333333336;
		this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[3] { columnDefinition1, columnDefinition2, columnDefinition3 });
		rowDefinition1.Height = 100.0;
		rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
		this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[1] { rowDefinition1 });
		this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
		this.layoutControlGroup2.Size = new System.Drawing.Size(372, 26);
		this.layoutControlGroup2.Text = "layoutControlGroup1";
		this.layoutControlGroup2.TextVisible = false;
		this.dossiersBindingSource.DataMember = "Dossiers";
		this.dossiersBindingSource.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.dossiersTableAdapter.ClearBeforeFill = true;
		this.simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
		this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton1.Location = new System.Drawing.Point(136, 299);
		this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton1.Name = "simpleButton1";
		this.simpleButton1.Size = new System.Drawing.Size(120, 22);
		this.simpleButton1.StyleController = this.layoutControl1;
		this.simpleButton1.TabIndex = 5;
		this.simpleButton1.Text = "Imprimer";
		this.simpleButton1.Click += new System.EventHandler(simpleButton1_Click);
		this.layoutControlItem6.Control = this.simpleButton1;
		this.layoutControlItem6.Location = new System.Drawing.Point(124, 0);
		this.layoutControlItem6.Name = "layoutControlItem6";
		this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem6.Size = new System.Drawing.Size(124, 26);
		this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem6.TextVisible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(392, 333);
		base.Controls.Add(this.layoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmRecap";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		base.Load += new System.EventHandler(frmEtatJournaux_Load);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.listBoxControl2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.listBoxControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.du.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.exer.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).EndInit();
		base.ResumeLayout(false);
	}
}
