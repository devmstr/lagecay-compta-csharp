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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.UI;

namespace compta;

public class frmEtatJournaux : XtraForm
{
	private DataTable dtjournaux = new DataTable();

	private OleDbDataAdapter adjournaux;

	private List<DataRowView> selectedRows = new List<DataRowView>();

	private IContainer components;

	private LayoutControl layoutControl1;

	private LayoutControlGroup Root;

	private SimpleButton simpleButton1;

	private SpinEdit au;

	private SpinEdit du;

	private SpinEdit exer;

	private LayoutControlItem layoutControlItem1;

	private LayoutControlItem layoutControlItem2;

	private LayoutControlItem layoutControlItem3;

	private LayoutControlItem layoutControlItem4;

	private LayoutControlItem layoutControlItem6;

	private EmptySpaceItem emptySpaceItem2;

	private EmptySpaceItem emptySpaceItem3;

	private EmptySpaceItem emptySpaceItem4;

	private DataSet1 dataSet1;

	private BindingSource dossiersBindingSource;

	private DossiersTableAdapter dossiersTableAdapter;

	private SearchLookUpEdit dos;

	private GridView searchLookUpEdit1View;

	private GridColumn colUNI;

	private GridColumn colLIB1;

	private LayoutControlGroup layoutControlGroup2;

	private GridControl gridControl1;

	private GridView gridView1;

	private LayoutControlItem layoutControlItem7;

	private BindingSource journauxBindingSource;

	private JournauxTableAdapter journauxTableAdapter;

	private GridColumn colJA;

	private GridColumn colLIB;

	private GridColumn colLIBAR;

	public frmEtatJournaux()
	{
		InitializeComponent();
	}

	private void frmEtatJournaux_Load(object sender, EventArgs e)
	{
		string connection = monModule.gConnString;
		dossiersTableAdapter.Connection.ConnectionString = connection;
		journauxTableAdapter.Connection.ConnectionString = connection;
		dossiersTableAdapter.Fill(dataSet1.Dossiers);
		journauxTableAdapter.Fill(dataSet1.Journaux);
		exer.EditValue = monModule.gExercice;
		dos.EditValue = monModule.gUNI;
		adjournaux = new OleDbDataAdapter("Select JA, JA & ' ' & LIB as LIB FROM Journaux", monModule.gbase);
		dtjournaux.Clear();
		adjournaux.Fill(dtjournaux);
		gridControl1.DataSource = dtjournaux;
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		rptJournaux report = new rptJournaux();
		DataTable dt = new DataTable();
		string exe = exer.Text;
		string min = du.Text;
		string ila = au.Text;
		string uni = (monModule.eUNI = dos.EditValue.ToString());
		monModule.eExercice = exe;
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + uni + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			monModule.eUNILIB = foundRows[0]["LIB"].ToString();
		}
		string s = "";
		selectedRows.Clear();
		int[] selectedRowHandles = gridView1.GetSelectedRows();
		for (int i = 0; i < selectedRowHandles.Length; i++)
		{
			DataRow row = gridView1.GetDataRow(selectedRowHandles[i]);
			s = s + " OR  (Ecritures.JA='" + row["JA"].ToString() + "')";
		}
		string where = s.Substring(3);
		where = ((!(where != "")) ? ("(Ecritures.Exercice=" + exe + ")  and (Ecritures.UNI='" + uni + "') and  (Month([DAT])>=" + min + " AND Month([DAT])<=" + ila + ")") : ("(Ecritures.Exercice=" + exe + ")  and (Ecritures.UNI='" + uni + "')  and  (Month([DAT])>=" + min + " AND Month([DAT])<=" + ila + ")  and (" + s.Substring(3) + ")"));
		string sql = "SELECT Ecritures.JA,Ecritures.DAT, Journaux.LIB AS LIBJA,  Month([DAT]) AS MM, Ecritures.NOP, Ecritures.CPT, Ecritures.LIB AS LIBECR, Ecritures.DEB, Ecritures.CRE  FROM Journaux INNER JOIN Ecritures ON Journaux.JA = Ecritures.JA  Where  (" + where + " )  GROUP BY Ecritures.JA, Journaux.LIB, Month([DAT]), Ecritures.NOP, Ecritures.CPT, Ecritures.LIB, Ecritures.DAT, Ecritures.DEB, Ecritures.CRE,  Ecritures.LIG  ORDER BY  Ecritures.JA, Month([DAT]), Ecritures.NOP, Ecritures.LIG;";
		Console.WriteLine(" -- " + sql);
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sql, monModule.gbase);
		dt.Clear();
		oleDbDataAdapter.Fill(dt);
		report.DataSource = dt;
		ReportPrintTool reportPrintTool = new ReportPrintTool(report);
		reportPrintTool.PreviewForm.PrintControl.SetPageView(1, 1);
		Close();
		reportPrintTool.ShowPreview();
	}

	private void au_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			du.Focus();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmEtatJournaux));
		DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.gridControl1 = new DevExpress.XtraGrid.GridControl();
		this.journauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colJA = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIBAR = new DevExpress.XtraGrid.Columns.GridColumn();
		this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
		this.au = new DevExpress.XtraEditors.SpinEdit();
		this.du = new DevExpress.XtraEditors.SpinEdit();
		this.exer = new DevExpress.XtraEditors.SpinEdit();
		this.dos = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.dossiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
		this.dossiersTableAdapter = new compta.DataSet1TableAdapters.DossiersTableAdapter();
		this.journauxTableAdapter = new compta.DataSet1TableAdapters.JournauxTableAdapter();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.gridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.au.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.du.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.exer.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem7).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Controls.Add(this.gridControl1);
		this.layoutControl1.Controls.Add(this.simpleButton1);
		this.layoutControl1.Controls.Add(this.au);
		this.layoutControl1.Controls.Add(this.du);
		this.layoutControl1.Controls.Add(this.exer);
		this.layoutControl1.Controls.Add(this.dos);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(430, 352);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.gridControl1.DataSource = this.journauxBindingSource;
		this.gridControl1.Location = new System.Drawing.Point(12, 79);
		this.gridControl1.MainView = this.gridView1;
		this.gridControl1.Name = "gridControl1";
		this.gridControl1.Size = new System.Drawing.Size(406, 235);
		this.gridControl1.TabIndex = 6;
		this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[1] { this.gridView1 });
		this.journauxBindingSource.DataMember = "Journaux";
		this.journauxBindingSource.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colJA, this.colLIB, this.colLIBAR });
		this.gridView1.GridControl = this.gridControl1;
		this.gridView1.Name = "gridView1";
		this.gridView1.OptionsCustomization.AllowGroup = false;
		this.gridView1.OptionsSelection.MultiSelect = true;
		this.gridView1.OptionsView.ShowDetailButtons = false;
		this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
		this.gridView1.OptionsView.ShowGroupPanel = false;
		this.gridView1.OptionsView.ShowIndicator = false;
		this.colJA.FieldName = "JA";
		this.colJA.Name = "colJA";
		this.colJA.OptionsColumn.AllowEdit = false;
		this.colJA.OptionsColumn.AllowFocus = false;
		this.colJA.Visible = true;
		this.colJA.VisibleIndex = 0;
		this.colJA.Width = 177;
		this.colLIB.FieldName = "LIB";
		this.colLIB.Name = "colLIB";
		this.colLIB.OptionsColumn.AllowEdit = false;
		this.colLIB.OptionsColumn.AllowFocus = false;
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 1;
		this.colLIB.Width = 656;
		this.colLIBAR.FieldName = "LIBAR";
		this.colLIBAR.Name = "colLIBAR";
		this.colLIBAR.OptionsColumn.AllowEdit = false;
		this.colLIBAR.OptionsColumn.AllowFocus = false;
		this.colLIBAR.Visible = true;
		this.colLIBAR.VisibleIndex = 2;
		this.colLIBAR.Width = 660;
		this.simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
		this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton1.Location = new System.Drawing.Point(148, 318);
		this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton1.Name = "simpleButton1";
		this.simpleButton1.Size = new System.Drawing.Size(133, 22);
		this.simpleButton1.StyleController = this.layoutControl1;
		this.simpleButton1.TabIndex = 5;
		this.simpleButton1.Text = "Imprimer";
		this.simpleButton1.Click += new System.EventHandler(simpleButton1_Click);
		this.au.EditValue = new decimal(new int[4] { 12, 0, 0, 0 });
		this.au.EnterMoveNextControl = true;
		this.au.Location = new System.Drawing.Point(156, 60);
		this.au.Margin = new System.Windows.Forms.Padding(2);
		this.au.Name = "au";
		this.au.Properties.Appearance.Options.UseTextOptions = true;
		this.au.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.au.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.au.Properties.DisplayFormat.FormatString = "{0:00}";
		this.au.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.au.Properties.IsFloatValue = false;
		this.au.Properties.Mask.EditMask = "N00";
		this.au.Properties.MaxValue = new decimal(new int[4] { 12, 0, 0, 0 });
		this.au.Properties.MinValue = new decimal(new int[4] { 1, 0, 0, 0 });
		this.au.Size = new System.Drawing.Size(42, 20);
		this.au.StyleController = this.layoutControl1;
		this.au.TabIndex = 3;
		this.au.KeyDown += new System.Windows.Forms.KeyEventHandler(au_KeyDown);
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
		this.exer.Size = new System.Drawing.Size(143, 20);
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
		this.dos.Size = new System.Drawing.Size(363, 20);
		this.dos.StyleController = this.layoutControl1;
		this.dos.TabIndex = 0;
		this.dos.KeyDown += new System.Windows.Forms.KeyEventHandler(dos_KeyDown);
		this.dossiersBindingSource.DataMember = "Dossiers";
		this.dossiersBindingSource.DataSource = this.dataSet1;
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
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[9] { this.layoutControlItem1, this.layoutControlItem2, this.layoutControlItem3, this.layoutControlItem4, this.emptySpaceItem2, this.emptySpaceItem3, this.emptySpaceItem4, this.layoutControlGroup2, this.layoutControlItem7 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(430, 352);
		this.Root.TextVisible = false;
		this.layoutControlItem1.Control = this.dos;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(410, 24);
		this.layoutControlItem1.Text = "Dossier";
		this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
		this.layoutControlItem2.Control = this.exer;
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(190, 24);
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
		this.layoutControlItem4.Control = this.au;
		this.layoutControlItem4.Location = new System.Drawing.Point(101, 48);
		this.layoutControlItem4.MaxSize = new System.Drawing.Size(89, 19);
		this.layoutControlItem4.MinSize = new System.Drawing.Size(89, 19);
		this.layoutControlItem4.Name = "layoutControlItem4";
		this.layoutControlItem4.Size = new System.Drawing.Size(89, 19);
		this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.layoutControlItem4.Text = "Au";
		this.layoutControlItem4.TextSize = new System.Drawing.Size(40, 13);
		this.emptySpaceItem2.AllowHotTrack = false;
		this.emptySpaceItem2.Location = new System.Drawing.Point(91, 48);
		this.emptySpaceItem2.Name = "emptySpaceItem2";
		this.emptySpaceItem2.Size = new System.Drawing.Size(10, 19);
		this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem3.AllowHotTrack = false;
		this.emptySpaceItem3.Location = new System.Drawing.Point(190, 48);
		this.emptySpaceItem3.Name = "emptySpaceItem3";
		this.emptySpaceItem3.Size = new System.Drawing.Size(220, 19);
		this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem4.AllowHotTrack = false;
		this.emptySpaceItem4.Location = new System.Drawing.Point(190, 24);
		this.emptySpaceItem4.Name = "emptySpaceItem4";
		this.emptySpaceItem4.Size = new System.Drawing.Size(220, 24);
		this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup2.GroupBordersVisible = false;
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem6 });
		this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 306);
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
		this.layoutControlGroup2.Size = new System.Drawing.Size(410, 26);
		this.layoutControlGroup2.Text = "layoutControlGroup1";
		this.layoutControlGroup2.TextVisible = false;
		this.layoutControlItem6.Control = this.simpleButton1;
		this.layoutControlItem6.Location = new System.Drawing.Point(136, 0);
		this.layoutControlItem6.Name = "layoutControlItem6";
		this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem6.Size = new System.Drawing.Size(137, 26);
		this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem6.TextVisible = false;
		this.layoutControlItem7.Control = this.gridControl1;
		this.layoutControlItem7.Location = new System.Drawing.Point(0, 67);
		this.layoutControlItem7.Name = "layoutControlItem7";
		this.layoutControlItem7.Size = new System.Drawing.Size(410, 239);
		this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem7.TextVisible = false;
		this.dossiersTableAdapter.ClearBeforeFill = true;
		this.journauxTableAdapter.ClearBeforeFill = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(430, 352);
		base.Controls.Add(this.layoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmEtatJournaux";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		base.Load += new System.EventHandler(frmEtatJournaux_Load);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.gridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.au.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.du.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.exer.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem7).EndInit();
		base.ResumeLayout(false);
	}
}
