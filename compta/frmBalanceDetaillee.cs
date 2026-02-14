using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using compta.DataSet1TableAdapters;
using DevExpress.Data;
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

public class frmBalanceDetaillee : XtraForm
{
	private TiersTableAdapter adtiers = new TiersTableAdapter();

	private DataSet1.TiersDataTable dttiers = new DataSet1.TiersDataTable();

	private IContainer components;

	private LayoutControl layoutControl1;

	private SpinEdit txtexe;

	private SpinEdit txtau;

	private SearchLookUpEdit dos;

	private GridView searchLookUpEdit1View;

	private GridColumn colUNI;

	private GridColumn colLIB1;

	private LayoutControlGroup Root;

	private LayoutControlGroup Root1;

	private LayoutControlItem layoutControlItem1;

	private LayoutControlItem layoutControlItem5;

	private EmptySpaceItem emptySpaceItem3;

	private LayoutControlItem layoutControlItem2;

	private EmptySpaceItem emptySpaceItem4;

	private LayoutControlItem layoutControlItem3;

	private DataSet1 dataSet1;

	private BindingSource dossiersBindingSource;

	private DossiersTableAdapter dossiersTableAdapter;

	private BindingSource comptesBindingSource;

	private ComptesTableAdapter comptesTableAdapter;

	private LookUpEdit txtcompte1;

	private LookUpEdit txtcompte2;

	private LayoutControlItem layoutControlItem10;

	private BindingSource tiersBindingSource;

	private TiersTableAdapter tiersTableAdapter;

	private EmptySpaceItem emptySpaceItem1;

	private EmptySpaceItem emptySpaceItem2;

	private EmptySpaceItem emptySpaceItem5;

	private SimpleButton simpleButton12;

	private LayoutControlGroup layoutControlGroup2;

	private LayoutControlItem layoutControlItem4;

	public frmBalanceDetaillee()
	{
		InitializeComponent();
	}

	private void frmGrandLivre_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		dossiersTableAdapter.Connection.ConnectionString = connection;
		comptesTableAdapter.Connection.ConnectionString = connection;
		tiersTableAdapter.Connection.ConnectionString = connection;
		tiersTableAdapter.Fill(dataSet1.Tiers);
		comptesTableAdapter.Fill1(dataSet1.Comptes);
		dossiersTableAdapter.Fill(dataSet1.Dossiers);
		dos.EditValue = monModule.gUNI;
		txtexe.EditValue = monModule.gExercice;
	}

	private void simpleButton11_Click(object sender, EventArgs e)
	{
		new OleDbCommand
		{
			CommandType = CommandType.Text,
			Connection = monModule.gbase
		};
		rptBalanceDetaillee report = new rptBalanceDetaillee();
		DataTable dt = new DataTable();
		monModule.eAU = Convert.ToInt32(txtau.Text);
		monModule.eUNI = dos.EditValue.ToString();
		monModule.eExercice = txtexe.Text;
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + monModule.eUNI + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			monModule.eUNILIB = foundRows[0]["LIB"].ToString();
		}
		string cpt1 = ((!txtcompte1.Text.Equals(string.Empty)) ? (txtcompte1.Text + "000000") : "000000");
		string cpt2 = ((!txtcompte2.Text.Equals(string.Empty)) ? (txtcompte2.Text + "000000") : "999999");
		cpt1 = cpt1.Substring(0, 5);
		cpt2 = cpt2.Substring(0, 5);
		string gWhere = "(Ecritures.UNI='" + monModule.eUNI + "') and (Ecritures.Exercice=" + monModule.eExercice + " ) AND  ( Month([DAT])<=" + monModule.eAU + ")  AND  (Ecritures.CPT >='" + cpt1 + "' AND Ecritures.CPT <='" + cpt2 + "' ) ";
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT First(IIf(Ecritures.TRS='-',COMPTES.LIB,Tiers.LIB)) AS LIB, [Ecritures].[CPT] AS Compte, Sum([Ecritures].[DEB]) as SDEB, Sum([Ecritures].[CRE]) AS SCRE, Tiers.TRS,    IIf(Sum([deb])-Sum([cre])>0,Sum([deb])-Sum([cre]),0) AS SCDEB, IIf(Sum([deb])-Sum([cre])<=0,-Sum([deb])+Sum([cre]),0) AS SCCRE  FROM  Tiers INNER JOIN (COMPTES INNER JOIN Ecritures ON COMPTES.CPT = Ecritures.CPT) ON (Tiers.TRS = Ecritures.TRS) AND (Tiers.UNI = Ecritures.UNI)  Where " + gWhere + " GROUP BY Comptes.LIB, [Ecritures].[CPT], Tiers.TRS   ORDER BY [Ecritures].[CPT], Tiers.TRS ", monModule.gbase);
		dt.Clear();
		oleDbDataAdapter.Fill(dt);
		report.DataSource = dt;
		ReportPrintTool reportPrintTool = new ReportPrintTool(report);
		Close();
		reportPrintTool.ShowPreview();
	}

	private void dos_EditValueChanged(object sender, EventArgs e)
	{
		monModule.eUNI = dos.EditValue.ToString();
		dttiers.Clear();
		adtiers.FillBy(dttiers, monModule.eUNI);
	}

	private void simpleButton11_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtcompte2.Focus();
		}
	}

	private void txtcompte2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtcompte1.Focus();
		}
	}

	private void txtau_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtexe.Focus();
		}
	}

	private void txtcompte1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtau.Focus();
		}
	}

	private void txtexe_KeyDown(object sender, KeyEventArgs e)
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
		DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmBalanceDetaillee));
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.txtexe = new DevExpress.XtraEditors.SpinEdit();
		this.txtau = new DevExpress.XtraEditors.SpinEdit();
		this.dos = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.dataSet1 = new compta.DataSet1();
		this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.txtcompte1 = new DevExpress.XtraEditors.LookUpEdit();
		this.txtcompte2 = new DevExpress.XtraEditors.LookUpEdit();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.Root1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.dossiersTableAdapter = new compta.DataSet1TableAdapters.DossiersTableAdapter();
		this.comptesTableAdapter = new compta.DataSet1TableAdapters.ComptesTableAdapter();
		this.tiersTableAdapter = new compta.DataSet1TableAdapters.TiersTableAdapter();
		this.dossiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.comptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.tiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
		this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.txtexe.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtau.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtcompte1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtcompte2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem10).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.comptesBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tiersBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Controls.Add(this.txtexe);
		this.layoutControl1.Controls.Add(this.txtau);
		this.layoutControl1.Controls.Add(this.dos);
		this.layoutControl1.Controls.Add(this.txtcompte1);
		this.layoutControl1.Controls.Add(this.txtcompte2);
		this.layoutControl1.Controls.Add(this.simpleButton12);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(837, 324, 650, 400);
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(483, 245);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.txtexe.EditValue = new decimal(new int[4] { 2020, 0, 0, 0 });
		this.txtexe.EnterMoveNextControl = true;
		this.txtexe.Location = new System.Drawing.Point(76, 46);
		this.txtexe.Margin = new System.Windows.Forms.Padding(2);
		this.txtexe.Name = "txtexe";
		this.txtexe.Properties.Appearance.Options.UseTextOptions = true;
		this.txtexe.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtexe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.txtexe.Properties.IsFloatValue = false;
		this.txtexe.Properties.Mask.EditMask = "\\d\\d\\d\\d";
		this.txtexe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
		this.txtexe.Properties.MaxValue = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.txtexe.Properties.MinValue = new decimal(new int[4] { 1900, 0, 0, 0 });
		this.txtexe.Size = new System.Drawing.Size(110, 20);
		this.txtexe.StyleController = this.layoutControl1;
		this.txtexe.TabIndex = 4;
		this.txtexe.KeyDown += new System.Windows.Forms.KeyEventHandler(txtexe_KeyDown);
		this.txtau.EditValue = new decimal(new int[4] { 12, 0, 0, 0 });
		this.txtau.EnterMoveNextControl = true;
		this.txtau.Location = new System.Drawing.Point(76, 70);
		this.txtau.Margin = new System.Windows.Forms.Padding(2);
		this.txtau.Name = "txtau";
		this.txtau.Properties.Appearance.Options.UseTextOptions = true;
		this.txtau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.txtau.Properties.DisplayFormat.FormatString = "{0:00}";
		this.txtau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.txtau.Properties.IsFloatValue = false;
		this.txtau.Properties.Mask.EditMask = "N00";
		this.txtau.Properties.MaxValue = new decimal(new int[4] { 12, 0, 0, 0 });
		this.txtau.Properties.MinValue = new decimal(new int[4] { 1, 0, 0, 0 });
		this.txtau.Size = new System.Drawing.Size(75, 20);
		this.txtau.StyleController = this.layoutControl1;
		this.txtau.TabIndex = 6;
		this.txtau.KeyDown += new System.Windows.Forms.KeyEventHandler(txtau_KeyDown);
		this.dos.EditValue = "001";
		this.dos.EnterMoveNextControl = true;
		this.dos.Location = new System.Drawing.Point(76, 22);
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
		this.dos.Size = new System.Drawing.Size(385, 20);
		this.dos.StyleController = this.layoutControl1;
		this.dos.TabIndex = 0;
		this.dos.EditValueChanged += new System.EventHandler(dos_EditValueChanged);
		this.dos.KeyDown += new System.Windows.Forms.KeyEventHandler(dos_KeyDown);
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
		this.txtcompte1.EditValue = "";
		this.txtcompte1.EnterMoveNextControl = true;
		this.txtcompte1.Location = new System.Drawing.Point(76, 94);
		this.txtcompte1.Margin = new System.Windows.Forms.Padding(2);
		this.txtcompte1.Name = "txtcompte1";
		this.txtcompte1.Properties.Appearance.Options.UseTextOptions = true;
		this.txtcompte1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtcompte1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.txtcompte1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[1]
		{
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CPT", "CPT", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
		});
		this.txtcompte1.Properties.DataSource = this.comptesBindingSource;
		this.txtcompte1.Properties.DisplayMember = "CPT";
		this.txtcompte1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
		this.txtcompte1.Properties.NullText = "";
		this.txtcompte1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
		this.txtcompte1.Properties.ValueMember = "CPT";
		this.txtcompte1.Size = new System.Drawing.Size(163, 20);
		this.txtcompte1.StyleController = this.layoutControl1;
		this.txtcompte1.TabIndex = 5;
		this.txtcompte1.KeyDown += new System.Windows.Forms.KeyEventHandler(txtcompte1_KeyDown);
		this.txtcompte2.EditValue = "";
		this.txtcompte2.EnterMoveNextControl = true;
		this.txtcompte2.Location = new System.Drawing.Point(76, 118);
		this.txtcompte2.Margin = new System.Windows.Forms.Padding(2);
		this.txtcompte2.Name = "txtcompte2";
		this.txtcompte2.Properties.Appearance.Options.UseTextOptions = true;
		this.txtcompte2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtcompte2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.txtcompte2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[1]
		{
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CPT", "CPT", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
		});
		this.txtcompte2.Properties.DataSource = this.comptesBindingSource;
		this.txtcompte2.Properties.DisplayMember = "CPT";
		this.txtcompte2.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
		this.txtcompte2.Properties.NullText = "";
		this.txtcompte2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
		this.txtcompte2.Properties.ValueMember = "CPT";
		this.txtcompte2.Size = new System.Drawing.Size(163, 20);
		this.txtcompte2.StyleController = this.layoutControl1;
		this.txtcompte2.TabIndex = 5;
		this.txtcompte2.KeyDown += new System.Windows.Forms.KeyEventHandler(txtcompte2_KeyDown);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.Root1, this.layoutControlGroup2 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(483, 245);
		this.Root.TextVisible = false;
		this.Root1.CustomizationFormText = "Root";
		this.Root1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root1.GroupBordersVisible = false;
		this.Root1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[10] { this.layoutControlItem1, this.layoutControlItem5, this.emptySpaceItem3, this.layoutControlItem2, this.emptySpaceItem4, this.emptySpaceItem1, this.layoutControlItem3, this.layoutControlItem10, this.emptySpaceItem2, this.emptySpaceItem5 });
		this.Root1.Location = new System.Drawing.Point(0, 0);
		this.Root1.Name = "Root1";
		this.Root1.Size = new System.Drawing.Size(463, 199);
		this.Root1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
		this.Root1.Text = "Root";
		this.Root1.TextVisible = false;
		this.layoutControlItem1.Control = this.txtexe;
		this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem1.CustomizationFormText = "Exercice";
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(168, 24);
		this.layoutControlItem1.Text = "Exercice";
		this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 13);
		this.layoutControlItem5.Control = this.txtau;
		this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem5.CustomizationFormText = "Balance à ";
		this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
		this.layoutControlItem5.Name = "layoutControlItem5";
		this.layoutControlItem5.Size = new System.Drawing.Size(133, 24);
		this.layoutControlItem5.Text = "Au mois";
		this.layoutControlItem5.TextSize = new System.Drawing.Size(51, 13);
		this.emptySpaceItem3.AllowHotTrack = false;
		this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
		this.emptySpaceItem3.Location = new System.Drawing.Point(168, 24);
		this.emptySpaceItem3.Name = "emptySpaceItem3";
		this.emptySpaceItem3.Size = new System.Drawing.Size(275, 24);
		this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem2.Control = this.dos;
		this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem2.CustomizationFormText = "Dossier";
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(443, 24);
		this.layoutControlItem2.Text = "Dossier";
		this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
		this.emptySpaceItem4.AllowHotTrack = false;
		this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
		this.emptySpaceItem4.Location = new System.Drawing.Point(0, 120);
		this.emptySpaceItem4.Name = "emptySpaceItem4";
		this.emptySpaceItem4.Size = new System.Drawing.Size(443, 59);
		this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(133, 48);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(310, 24);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem3.Control = this.txtcompte1;
		this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem3.CustomizationFormText = "Balance au ";
		this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
		this.layoutControlItem3.Name = "layoutControlItem3";
		this.layoutControlItem3.Size = new System.Drawing.Size(221, 24);
		this.layoutControlItem3.Text = "Du compte";
		this.layoutControlItem3.TextSize = new System.Drawing.Size(51, 13);
		this.layoutControlItem10.Control = this.txtcompte2;
		this.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem10.CustomizationFormText = "Balance au ";
		this.layoutControlItem10.Location = new System.Drawing.Point(0, 96);
		this.layoutControlItem10.Name = "layoutControlItem10";
		this.layoutControlItem10.Size = new System.Drawing.Size(221, 24);
		this.layoutControlItem10.Text = "Au compte";
		this.layoutControlItem10.TextSize = new System.Drawing.Size(51, 13);
		this.emptySpaceItem2.AllowHotTrack = false;
		this.emptySpaceItem2.Location = new System.Drawing.Point(221, 72);
		this.emptySpaceItem2.Name = "emptySpaceItem2";
		this.emptySpaceItem2.Size = new System.Drawing.Size(222, 24);
		this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem5.AllowHotTrack = false;
		this.emptySpaceItem5.Location = new System.Drawing.Point(221, 96);
		this.emptySpaceItem5.Name = "emptySpaceItem5";
		this.emptySpaceItem5.Size = new System.Drawing.Size(222, 24);
		this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup2.GroupBordersVisible = false;
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem4 });
		this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 199);
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
		this.layoutControlGroup2.Size = new System.Drawing.Size(463, 26);
		this.layoutControlGroup2.Text = "layoutControlGroup1";
		this.layoutControlGroup2.TextVisible = false;
		this.dossiersTableAdapter.ClearBeforeFill = true;
		this.comptesTableAdapter.ClearBeforeFill = true;
		this.tiersTableAdapter.ClearBeforeFill = true;
		this.dossiersBindingSource.DataMember = "Dossiers";
		this.dossiersBindingSource.DataSource = this.dataSet1;
		this.comptesBindingSource.DataMember = "Comptes";
		this.comptesBindingSource.DataSource = this.dataSet1;
		this.tiersBindingSource.DataMember = "Tiers";
		this.tiersBindingSource.DataSource = this.dataSet1;
		this.simpleButton12.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton12.ImageOptions.Image");
		this.simpleButton12.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton12.Location = new System.Drawing.Point(166, 211);
		this.simpleButton12.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton12.Name = "simpleButton12";
		this.simpleButton12.Size = new System.Drawing.Size(150, 22);
		this.simpleButton12.StyleController = this.layoutControl1;
		this.simpleButton12.TabIndex = 7;
		this.simpleButton12.Text = "Imprimer";
		this.simpleButton12.Click += new System.EventHandler(simpleButton11_Click);
		this.simpleButton12.KeyDown += new System.Windows.Forms.KeyEventHandler(simpleButton11_KeyDown);
		this.layoutControlItem4.Control = this.simpleButton12;
		this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem4.CustomizationFormText = "layoutControlItem6";
		this.layoutControlItem4.Location = new System.Drawing.Point(154, 0);
		this.layoutControlItem4.Name = "layoutControlItem4";
		this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem4.Size = new System.Drawing.Size(154, 26);
		this.layoutControlItem4.Text = "layoutControlItem6";
		this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem4.TextVisible = false;
		this.layoutControlItem4.Click += new System.EventHandler(simpleButton11_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(483, 245);
		base.Controls.Add(this.layoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmBalanceDetaillee";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		base.Load += new System.EventHandler(frmGrandLivre_Load);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.txtexe.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtau.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtcompte1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtcompte2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem10).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.comptesBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tiersBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).EndInit();
		base.ResumeLayout(false);
	}
}
