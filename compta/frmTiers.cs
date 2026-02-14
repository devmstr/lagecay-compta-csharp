using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using compta.DataSet1TableAdapters;
using compta.Properties;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace compta;

public class frmTiers : XtraForm
{
	private BindingSource bs;

	private DataTable dt;

	private OleDbDataAdapter ad;

	private bool recherche;

	private string fil = "";

	private InputLanguage originalInputLang;

	private IContainer components;

	private DataLayoutControl dataLayoutControl1;

	private LayoutControlGroup Root;

	private BindingSource bindingSource1;

	private DataSet1 dataSet1;

	private TiersTableAdapter tiersTableAdapter;

	private TextEdit UNITextEdit;

	private TextEdit TRSTextEdit;

	private TextEdit LIBTextEdit;

	private TextEdit ACTTextEdit;

	private TextEdit ADRTextEdit;

	private LookUpEdit CPLookUpEdit;

	private TextEdit RCTextEdit;

	private TextEdit NUMIFTextEdit;

	private TextEdit NUMAITextEdit;

	private TextEdit IDTextEdit;

	private ComboBoxEdit TypeTiersComboBoxEdit;

	private TextEdit CFTextEdit;

	private TextEdit TELTextEdit;

	private TextEdit FAXTextEdit;

	private TextEdit PORTTextEdit;

	private TextEdit MAILTextEdit;

	private TextEdit NISTextEdit;

	private LayoutControlGroup layoutControlGroup1;

	private LayoutControlItem ItemForUNI;

	private LayoutControlItem ItemForID;

	private LayoutControlItem ItemForFAX;

	internal GridControl GridControl1;

	internal GridView GridView3;

	private LayoutControlItem layoutControlItem1;

	private SharedImageCollection sharedImageCollection1;

	private BindingSource villesBindingSource;

	private VillesTableAdapter villesTableAdapter;

	private GridView gridView1;

	private GridColumn colUNI;

	private GridColumn colLIB;

	private GridColumn colACT;

	private SimpleButton simpleButton4;

	private SimpleButton simpleButton11;

	private SimpleButton simpleButton3;

	private SimpleButton simpleButton21;

	private LayoutControlGroup layoutControlGroup5;

	private LayoutControlItem layoutControlItem16;

	private LayoutControlItem layoutControlItem17;

	private LayoutControlItem layoutControlItem21;

	private LayoutControlItem layoutControlItem22;

	private TextEdit LIBTextEdit1;

	private TextEdit ACTTextEdit1;

	private TextEdit ADRTextEdit1;

	private TabbedControlGroup tabbedControlGroup1;

	private LayoutControlGroup layoutControlGroup2;

	private LayoutControlItem ItemForTRS;

	private LayoutControlItem ItemForTypeTiers;

	private EmptySpaceItem emptySpaceItem1;

	private LayoutControlItem ItemForLIB;

	private LayoutControlItem ItemForACT;

	private LayoutControlItem ItemForADR;

	private LayoutControlItem ItemForCP;

	private LayoutControlItem ItemForRC;

	private LayoutControlItem ItemForCF;

	private LayoutControlItem ItemForNUMIF;

	private LayoutControlItem ItemForNUMAI;

	private LayoutControlItem ItemForNIS;

	private LayoutControlItem ItemForMAIL;

	private LayoutControlItem ItemForPORT;

	private LayoutControlItem ItemForTEL;

	private LayoutControlGroup layoutControlGroup3;

	private LayoutControlItem ItemForADR1;

	private LayoutControlItem ItemForACT1;

	private LayoutControlItem ItemForLIB1;

	public frmTiers()
	{
		InitializeComponent();
		recherche = false;
		fil = "";
		gridView1.OptionsFind.AlwaysVisible = false;
		bs = bindingSource1;
		dt = dataSet1.Tiers;
		ad = tiersTableAdapter.Adapter;
		ApplyModernIcons();
	}

	private void ApplyModernIcons()
	{
		IconManager.SetIcon(simpleButton11, IconManager.Icons.Save);
		IconManager.SetIcon(simpleButton21, IconManager.Icons.Add);
		IconManager.SetIcon(simpleButton3, IconManager.Icons.Delete);
		IconManager.SetIcon(simpleButton4, IconManager.Icons.Print);
	}

	public frmTiers(bool rech, string filtre = "")
	{
		InitializeComponent();
		recherche = rech;
		fil = filtre;
		gridView1.OptionsFind.AlwaysVisible = true;
		bs = bindingSource1;
		dt = dataSet1.Tiers;
		ad = tiersTableAdapter.Adapter;
		ApplyModernIcons();
	}

	protected override void OnLoad(EventArgs e)
	{
		if (recherche)
		{
			base.OnLoad(e);
			SendKeys.Send("^{F}");
		}
		else
		{
			base.OnLoad(e);
		}
	}

	protected override void OnShown(EventArgs e)
	{
		if (recherche)
		{
			base.OnShown(e);
			gridView1.Focus();
			SendKeys.Send("^{F}");
			gridView1.FindFilterText = fil;
			SendKeys.Send("^{RIGHT}");
		}
		else
		{
			base.OnShown(e);
		}
	}

	private void frmTiers_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		villesTableAdapter.Connection.ConnectionString = connection;
		tiersTableAdapter.Connection.ConnectionString = connection;
		tiersTableAdapter.FillBy(dataSet1.Tiers, monModule.gUNI);
		villesTableAdapter.Fill(dataSet1.Villes);
		dataSet1.Tiers.Columns["TypeTiers"].DefaultValue = "X";
		dataSet1.Tiers.Columns["UNI"].DefaultValue = monModule.gUNI;
	}

	private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
	{
		try
		{
			bindingSource1.EndEdit();
			tiersTableAdapter.Update(dataSet1.Tiers);
			dataSet1.Tiers.AcceptChanges();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			dataSet1.Tiers.RejectChanges();
		}
	}

	private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
	{
		string maxVal = dataSet1.Tiers.Compute("max([TRS])", string.Empty).ToString();
		((DataRowView)bindingSource1.AddNew())["TRS"] = monModule.Suivant(maxVal);
		bindingSource1.EndEdit();
		tiersTableAdapter.Update(dataSet1.Tiers);
		dataSet1.Tiers.AcceptChanges();
		Rafraichir();
	}

	private void Rafraichir()
	{
		if (dataSet1.Tiers != null)
		{
			int pos = bindingSource1.Position;
			dataSet1.Tiers.Clear();
			tiersTableAdapter.FillBy(dataSet1.Tiers, monModule.gUNI);
			bindingSource1.Position = pos;
		}
	}

	private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
	{
		object cod = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TRS");
		if (cod == null || cod.ToString() == "-" || MessageBox.Show("هل تريد فعلا حدف المعلومات", "أكد الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) != DialogResult.Yes)
		{
			return;
		}
		try
		{
			bindingSource1.RemoveCurrent();
			bindingSource1.ResetCurrentItem();
			bindingSource1.EndEdit();
			tiersTableAdapter.Adapter.Update(dataSet1.Tiers);
			dataSet1.Tiers.AcceptChanges();
		}
		catch (Exception ex)
		{
			dataSet1.Tiers.RejectChanges();
			MessageBox.Show(ex.Message);
		}
	}

	private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TRS");
		monModule.gTRS = ((t == null) ? "" : t.ToString());
	}

	private void gridView1_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Return:
			monModule.enter = true;
			Close();
			break;
		case Keys.Escape:
			monModule.enter = false;
			Close();
			break;
		}
	}

	private void LIBTextEdit1_Enter(object sender, EventArgs e)
	{
		originalInputLang = InputLanguage.CurrentInputLanguage;
		InputLanguage lang = (from l in InputLanguage.InstalledInputLanguages.OfType<InputLanguage>()
			where l.Culture.Name.StartsWith("ar")
			select l).FirstOrDefault();
		if (lang != null)
		{
			InputLanguage.CurrentInputLanguage = lang;
		}
	}

	private void LIBTextEdit1_Leave(object sender, EventArgs e)
	{
		InputLanguage.CurrentInputLanguage = originalInputLang;
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
		DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmTiers));
		this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colACT = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.UNITextEdit = new DevExpress.XtraEditors.TextEdit();
		this.TRSTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.LIBTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.ACTTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.ADRTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.CPLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
		this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.RCTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.NUMIFTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.NUMAITextEdit = new DevExpress.XtraEditors.TextEdit();
		this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.TypeTiersComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
		this.CFTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.TELTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.FAXTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.PORTTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.MAILTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.NISTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton21 = new DevExpress.XtraEditors.SimpleButton();
		this.LIBTextEdit1 = new DevExpress.XtraEditors.TextEdit();
		this.ACTTextEdit1 = new DevExpress.XtraEditors.TextEdit();
		this.ADRTextEdit1 = new DevExpress.XtraEditors.TextEdit();
		this.ItemForUNI = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForFAX = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.tiersTableAdapter = new compta.DataSet1TableAdapters.TiersTableAdapter();
		this.sharedImageCollection1 = new DevExpress.Utils.SharedImageCollection(this.components);
		this.villesTableAdapter = new compta.DataSet1TableAdapters.VillesTableAdapter();
		this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForTRS = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForTypeTiers = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.ItemForLIB = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForACT = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForADR = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForCP = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForRC = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForCF = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForNUMIF = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForNUMAI = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForNIS = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForMAIL = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForPORT = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForTEL = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForADR1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForACT1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIB1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).BeginInit();
		this.dataLayoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TRSTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ACTTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ADRTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CPLookUpEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RCTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.NUMIFTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.NUMAITextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TypeTiersComboBoxEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CFTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TELTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.FAXTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PORTTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.MAILTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.NISTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ACTTextEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ADRTextEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForFAX).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1.ImageSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tabbedControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTRS).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTypeTiers).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCP).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForRC).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCF).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNUMIF).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNUMAI).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNIS).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForMAIL).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForPORT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTEL).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).BeginInit();
		base.SuspendLayout();
		this.dataLayoutControl1.Controls.Add(this.GridControl1);
		this.dataLayoutControl1.Controls.Add(this.UNITextEdit);
		this.dataLayoutControl1.Controls.Add(this.TRSTextEdit);
		this.dataLayoutControl1.Controls.Add(this.LIBTextEdit);
		this.dataLayoutControl1.Controls.Add(this.ACTTextEdit);
		this.dataLayoutControl1.Controls.Add(this.ADRTextEdit);
		this.dataLayoutControl1.Controls.Add(this.CPLookUpEdit);
		this.dataLayoutControl1.Controls.Add(this.RCTextEdit);
		this.dataLayoutControl1.Controls.Add(this.NUMIFTextEdit);
		this.dataLayoutControl1.Controls.Add(this.NUMAITextEdit);
		this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
		this.dataLayoutControl1.Controls.Add(this.TypeTiersComboBoxEdit);
		this.dataLayoutControl1.Controls.Add(this.CFTextEdit);
		this.dataLayoutControl1.Controls.Add(this.TELTextEdit);
		this.dataLayoutControl1.Controls.Add(this.FAXTextEdit);
		this.dataLayoutControl1.Controls.Add(this.PORTTextEdit);
		this.dataLayoutControl1.Controls.Add(this.MAILTextEdit);
		this.dataLayoutControl1.Controls.Add(this.NISTextEdit);
		this.dataLayoutControl1.Controls.Add(this.simpleButton4);
		this.dataLayoutControl1.Controls.Add(this.simpleButton11);
		this.dataLayoutControl1.Controls.Add(this.simpleButton3);
		this.dataLayoutControl1.Controls.Add(this.simpleButton21);
		this.dataLayoutControl1.Controls.Add(this.LIBTextEdit1);
		this.dataLayoutControl1.Controls.Add(this.ACTTextEdit1);
		this.dataLayoutControl1.Controls.Add(this.ADRTextEdit1);
		this.dataLayoutControl1.DataSource = this.bindingSource1;
		this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.ItemForUNI, this.ItemForID, this.ItemForFAX });
		this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
		this.dataLayoutControl1.Name = "dataLayoutControl1";
		this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(727, 156, 650, 400);
		this.dataLayoutControl1.Root = this.Root;
		this.dataLayoutControl1.Size = new System.Drawing.Size(671, 434);
		this.dataLayoutControl1.TabIndex = 0;
		this.dataLayoutControl1.Text = "dataLayoutControl1";
		this.GridControl1.DataSource = this.bindingSource1;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(12, 200);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(647, 174);
		this.GridControl1.TabIndex = 23;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.bindingSource1.DataMember = "Tiers";
		this.bindingSource1.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colUNI, this.colLIB, this.colACT });
		this.gridView1.DetailHeight = 801;
		this.gridView1.FixedLineWidth = 1;
		this.gridView1.GridControl = this.GridControl1;
		this.gridView1.Name = "gridView1";
		this.gridView1.OptionsBehavior.Editable = false;
		this.gridView1.OptionsBehavior.ReadOnly = true;
		this.gridView1.OptionsCustomization.AllowGroup = false;
		this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
		this.gridView1.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
		this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
		this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
		this.gridView1.OptionsView.ColumnAutoWidth = false;
		this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
		this.gridView1.OptionsView.EnableAppearanceOddRow = true;
		this.gridView1.OptionsView.ShowDetailButtons = false;
		this.gridView1.OptionsView.ShowFooter = true;
		this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
		this.gridView1.OptionsView.ShowGroupPanel = false;
		this.gridView1.OptionsView.ShowIndicator = false;
		this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView1_FocusedRowChanged);
		this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(gridView1_KeyDown);
		this.colUNI.AppearanceCell.Options.UseTextOptions = true;
		this.colUNI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.AppearanceHeader.Options.UseTextOptions = true;
		this.colUNI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.Caption = "Code";
		this.colUNI.FieldName = "TRS";
		this.colUNI.Name = "colUNI";
		this.colUNI.Visible = true;
		this.colUNI.VisibleIndex = 0;
		this.colUNI.Width = 63;
		this.colLIB.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB.Caption = "Intitulé";
		this.colLIB.FieldName = "LIB";
		this.colLIB.Name = "colLIB";
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 1;
		this.colLIB.Width = 247;
		this.colACT.AppearanceCell.Options.UseTextOptions = true;
		this.colACT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.colACT.AppearanceHeader.Options.UseTextOptions = true;
		this.colACT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colACT.Caption = "Intitulé en Arabe";
		this.colACT.FieldName = "LIBAR";
		this.colACT.Name = "colACT";
		this.colACT.Visible = true;
		this.colACT.VisibleIndex = 2;
		this.colACT.Width = 317;
		this.GridView3.Appearance.EvenRow.BackColor = System.Drawing.SystemColors.Window;
		this.GridView3.Appearance.EvenRow.BackColor2 = System.Drawing.SystemColors.Window;
		this.GridView3.Appearance.EvenRow.Options.UseBackColor = true;
		this.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
		this.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.SystemColors.HighlightText;
		this.GridView3.Appearance.FocusedCell.Options.UseBackColor = true;
		this.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
		this.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.SystemColors.Highlight;
		this.GridView3.Appearance.FocusedRow.Options.UseBackColor = true;
		this.GridView3.Appearance.OddRow.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.GridView3.Appearance.OddRow.BackColor2 = System.Drawing.SystemColors.ButtonFace;
		this.GridView3.Appearance.OddRow.Options.UseBackColor = true;
		this.GridView3.DetailHeight = 801;
		this.GridView3.FixedLineWidth = 1;
		this.GridView3.GridControl = this.GridControl1;
		this.GridView3.Name = "GridView3";
		this.GridView3.OptionsBehavior.Editable = false;
		this.GridView3.OptionsBehavior.ReadOnly = true;
		this.GridView3.OptionsNavigation.EnterMoveNextColumn = true;
		this.GridView3.OptionsView.ColumnAutoWidth = false;
		this.GridView3.OptionsView.EnableAppearanceEvenRow = true;
		this.GridView3.OptionsView.EnableAppearanceOddRow = true;
		this.GridView3.OptionsView.ShowFooter = true;
		this.GridView3.OptionsView.ShowIndicator = false;
		this.GridView3.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.UNITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "UNI", true));
		this.UNITextEdit.Location = new System.Drawing.Point(59, 6);
		this.UNITextEdit.Name = "UNITextEdit";
		this.UNITextEdit.Size = new System.Drawing.Size(711, 20);
		this.UNITextEdit.StyleController = this.dataLayoutControl1;
		this.UNITextEdit.TabIndex = 4;
		this.TRSTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "TRS", true));
		this.TRSTextEdit.EnterMoveNextControl = true;
		this.TRSTextEdit.Location = new System.Drawing.Point(52, 44);
		this.TRSTextEdit.Name = "TRSTextEdit";
		this.TRSTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.TRSTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.TRSTextEdit.Size = new System.Drawing.Size(106, 20);
		this.TRSTextEdit.StyleController = this.dataLayoutControl1;
		this.TRSTextEdit.TabIndex = 5;
		this.LIBTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIB", true));
		this.LIBTextEdit.EnterMoveNextControl = true;
		this.LIBTextEdit.Location = new System.Drawing.Point(61, 68);
		this.LIBTextEdit.Name = "LIBTextEdit";
		this.LIBTextEdit.Size = new System.Drawing.Size(270, 20);
		this.LIBTextEdit.StyleController = this.dataLayoutControl1;
		this.LIBTextEdit.TabIndex = 6;
		this.ACTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ACT", true));
		this.ACTTextEdit.EnterMoveNextControl = true;
		this.ACTTextEdit.Location = new System.Drawing.Point(374, 68);
		this.ACTTextEdit.Name = "ACTTextEdit";
		this.ACTTextEdit.Size = new System.Drawing.Size(273, 20);
		this.ACTTextEdit.StyleController = this.dataLayoutControl1;
		this.ACTTextEdit.TabIndex = 7;
		this.ADRTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ADR", true));
		this.ADRTextEdit.EnterMoveNextControl = true;
		this.ADRTextEdit.Location = new System.Drawing.Point(66, 92);
		this.ADRTextEdit.Name = "ADRTextEdit";
		this.ADRTextEdit.Size = new System.Drawing.Size(336, 20);
		this.ADRTextEdit.StyleController = this.dataLayoutControl1;
		this.ADRTextEdit.TabIndex = 8;
		this.CPLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CP", true));
		this.CPLookUpEdit.EnterMoveNextControl = true;
		this.CPLookUpEdit.Location = new System.Drawing.Point(427, 92);
		this.CPLookUpEdit.Name = "CPLookUpEdit";
		this.CPLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.CPLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[3]
		{
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CP", "CP", 22, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LIB", "LIB", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
			new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LIBAR", "LIBAR", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
		});
		this.CPLookUpEdit.Properties.DataSource = this.villesBindingSource;
		this.CPLookUpEdit.Properties.DisplayMember = "LIB";
		this.CPLookUpEdit.Properties.NullText = "";
		this.CPLookUpEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
		this.CPLookUpEdit.Properties.ValueMember = "CP";
		this.CPLookUpEdit.Size = new System.Drawing.Size(220, 20);
		this.CPLookUpEdit.StyleController = this.dataLayoutControl1;
		this.CPLookUpEdit.TabIndex = 9;
		this.villesBindingSource.DataMember = "Villes";
		this.villesBindingSource.DataSource = this.dataSet1;
		this.RCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "RC", true));
		this.RCTextEdit.EnterMoveNextControl = true;
		this.RCTextEdit.Location = new System.Drawing.Point(49, 116);
		this.RCTextEdit.Name = "RCTextEdit";
		this.RCTextEdit.Size = new System.Drawing.Size(282, 20);
		this.RCTextEdit.StyleController = this.dataLayoutControl1;
		this.RCTextEdit.TabIndex = 10;
		this.NUMIFTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "NUMIF", true));
		this.NUMIFTextEdit.EnterMoveNextControl = true;
		this.NUMIFTextEdit.Location = new System.Drawing.Point(59, 140);
		this.NUMIFTextEdit.Name = "NUMIFTextEdit";
		this.NUMIFTextEdit.Size = new System.Drawing.Size(194, 20);
		this.NUMIFTextEdit.StyleController = this.dataLayoutControl1;
		this.NUMIFTextEdit.TabIndex = 11;
		this.NUMAITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "NUMAI", true));
		this.NUMAITextEdit.EnterMoveNextControl = true;
		this.NUMAITextEdit.Location = new System.Drawing.Point(293, 140);
		this.NUMAITextEdit.Name = "NUMAITextEdit";
		this.NUMAITextEdit.Size = new System.Drawing.Size(156, 20);
		this.NUMAITextEdit.StyleController = this.dataLayoutControl1;
		this.NUMAITextEdit.TabIndex = 12;
		this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ID", true));
		this.IDTextEdit.Location = new System.Drawing.Point(59, 182);
		this.IDTextEdit.Name = "IDTextEdit";
		this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.IDTextEdit.Properties.Mask.EditMask = "N0";
		this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.IDTextEdit.Size = new System.Drawing.Size(711, 20);
		this.IDTextEdit.StyleController = this.dataLayoutControl1;
		this.IDTextEdit.TabIndex = 13;
		this.TypeTiersComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "TypeTiers", true));
		this.TypeTiersComboBoxEdit.EnterMoveNextControl = true;
		this.TypeTiersComboBoxEdit.Location = new System.Drawing.Point(215, 44);
		this.TypeTiersComboBoxEdit.Name = "TypeTiersComboBoxEdit";
		this.TypeTiersComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.TypeTiersComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.TypeTiersComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.TypeTiersComboBoxEdit.Properties.Items.AddRange(new object[4] { "C", "F", "S", "X" });
		this.TypeTiersComboBoxEdit.Size = new System.Drawing.Size(82, 20);
		this.TypeTiersComboBoxEdit.StyleController = this.dataLayoutControl1;
		this.TypeTiersComboBoxEdit.TabIndex = 14;
		this.CFTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CF", true));
		this.CFTextEdit.EnterMoveNextControl = true;
		this.CFTextEdit.Location = new System.Drawing.Point(359, 116);
		this.CFTextEdit.Name = "CFTextEdit";
		this.CFTextEdit.Size = new System.Drawing.Size(288, 20);
		this.CFTextEdit.StyleController = this.dataLayoutControl1;
		this.CFTextEdit.TabIndex = 15;
		this.TELTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "TEL", true));
		this.TELTextEdit.EnterMoveNextControl = true;
		this.TELTextEdit.Location = new System.Drawing.Point(77, 164);
		this.TELTextEdit.Name = "TELTextEdit";
		this.TELTextEdit.Size = new System.Drawing.Size(116, 20);
		this.TELTextEdit.StyleController = this.dataLayoutControl1;
		this.TELTextEdit.TabIndex = 16;
		this.FAXTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "FAX", true));
		this.FAXTextEdit.EnterMoveNextControl = true;
		this.FAXTextEdit.Location = new System.Drawing.Point(213, 180);
		this.FAXTextEdit.Name = "FAXTextEdit";
		this.FAXTextEdit.Size = new System.Drawing.Size(118, 20);
		this.FAXTextEdit.StyleController = this.dataLayoutControl1;
		this.FAXTextEdit.TabIndex = 17;
		this.PORTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "PORT", true));
		this.PORTTextEdit.EnterMoveNextControl = true;
		this.PORTTextEdit.Location = new System.Drawing.Point(240, 164);
		this.PORTTextEdit.Name = "PORTTextEdit";
		this.PORTTextEdit.Size = new System.Drawing.Size(147, 20);
		this.PORTTextEdit.StyleController = this.dataLayoutControl1;
		this.PORTTextEdit.TabIndex = 18;
		this.MAILTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "MAIL", true));
		this.MAILTextEdit.EnterMoveNextControl = true;
		this.MAILTextEdit.Location = new System.Drawing.Point(412, 164);
		this.MAILTextEdit.Name = "MAILTextEdit";
		this.MAILTextEdit.Size = new System.Drawing.Size(235, 20);
		this.MAILTextEdit.StyleController = this.dataLayoutControl1;
		this.MAILTextEdit.TabIndex = 19;
		this.NISTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "NIS", true));
		this.NISTextEdit.EnterMoveNextControl = true;
		this.NISTextEdit.Location = new System.Drawing.Point(473, 140);
		this.NISTextEdit.Name = "NISTextEdit";
		this.NISTextEdit.Size = new System.Drawing.Size(174, 20);
		this.NISTextEdit.StyleController = this.dataLayoutControl1;
		this.NISTextEdit.TabIndex = 20;
		this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton4.Location = new System.Drawing.Point(512, 389);
		this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton4.Name = "simpleButton4";
		this.simpleButton4.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton4.Size = new System.Drawing.Size(117, 22);
		this.simpleButton4.StyleController = this.dataLayoutControl1;
		this.simpleButton4.TabIndex = 78;
		this.simpleButton4.TabStop = false;
		this.simpleButton4.Text = "Imprimer";
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(42, 389);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton11.Size = new System.Drawing.Size(116, 22);
		this.simpleButton11.StyleController = this.dataLayoutControl1;
		this.simpleButton11.TabIndex = 75;
		this.simpleButton11.TabStop = false;
		this.simpleButton11.Text = "Enregistrer";
		this.simpleButton11.Click += new System.EventHandler(bindingNavigatorSaveItem_Click);
		this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton3.Location = new System.Drawing.Point(355, 389);
		this.simpleButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton3.Name = "simpleButton3";
		this.simpleButton3.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton3.Size = new System.Drawing.Size(117, 22);
		this.simpleButton3.StyleController = this.dataLayoutControl1;
		this.simpleButton3.TabIndex = 77;
		this.simpleButton3.TabStop = false;
		this.simpleButton3.Text = "Supprimer";
		this.simpleButton3.Click += new System.EventHandler(bindingNavigatorDeleteItem_Click);
		this.simpleButton21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton21.Location = new System.Drawing.Point(198, 389);
		this.simpleButton21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton21.Name = "simpleButton21";
		this.simpleButton21.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton21.Size = new System.Drawing.Size(117, 22);
		this.simpleButton21.StyleController = this.dataLayoutControl1;
		this.simpleButton21.TabIndex = 76;
		this.simpleButton21.TabStop = false;
		this.simpleButton21.Text = "Ajouter";
		this.simpleButton21.Click += new System.EventHandler(bindingNavigatorAddNewItem_Click_1);
		this.LIBTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIBAR", true));
		this.LIBTextEdit1.EnterMoveNextControl = true;
		this.LIBTextEdit1.Location = new System.Drawing.Point(93, 68);
		this.LIBTextEdit1.Name = "LIBTextEdit1";
		this.LIBTextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.LIBTextEdit1.Size = new System.Drawing.Size(554, 20);
		this.LIBTextEdit1.StyleController = this.dataLayoutControl1;
		this.LIBTextEdit1.TabIndex = 6;
		this.LIBTextEdit1.Enter += new System.EventHandler(LIBTextEdit1_Enter);
		this.LIBTextEdit1.Leave += new System.EventHandler(LIBTextEdit1_Leave);
		this.ACTTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ACTAR", true));
		this.ACTTextEdit1.EnterMoveNextControl = true;
		this.ACTTextEdit1.Location = new System.Drawing.Point(408, 44);
		this.ACTTextEdit1.Name = "ACTTextEdit1";
		this.ACTTextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.ACTTextEdit1.Size = new System.Drawing.Size(239, 20);
		this.ACTTextEdit1.StyleController = this.dataLayoutControl1;
		this.ACTTextEdit1.TabIndex = 7;
		this.ACTTextEdit1.Enter += new System.EventHandler(LIBTextEdit1_Enter);
		this.ACTTextEdit1.Leave += new System.EventHandler(LIBTextEdit1_Leave);
		this.ADRTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ADRAR", true));
		this.ADRTextEdit1.EnterMoveNextControl = true;
		this.ADRTextEdit1.Location = new System.Drawing.Point(98, 44);
		this.ADRTextEdit1.Name = "ADRTextEdit1";
		this.ADRTextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.ADRTextEdit1.Size = new System.Drawing.Size(235, 20);
		this.ADRTextEdit1.StyleController = this.dataLayoutControl1;
		this.ADRTextEdit1.TabIndex = 8;
		this.ADRTextEdit1.Enter += new System.EventHandler(LIBTextEdit1_Enter);
		this.ADRTextEdit1.Leave += new System.EventHandler(LIBTextEdit1_Leave);
		this.ItemForUNI.Control = this.UNITextEdit;
		this.ItemForUNI.Location = new System.Drawing.Point(0, 0);
		this.ItemForUNI.Name = "ItemForUNI";
		this.ItemForUNI.Size = new System.Drawing.Size(766, 22);
		this.ItemForUNI.Text = "UNI";
		this.ItemForUNI.TextSize = new System.Drawing.Size(50, 13);
		this.ItemForID.Control = this.IDTextEdit;
		this.ItemForID.Location = new System.Drawing.Point(0, 176);
		this.ItemForID.Name = "ItemForID";
		this.ItemForID.Size = new System.Drawing.Size(766, 22);
		this.ItemForID.Text = "ID";
		this.ItemForID.TextSize = new System.Drawing.Size(50, 13);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup1, this.layoutControlGroup5 });
		this.Root.Name = "Root";
		this.Root.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
		this.Root.Size = new System.Drawing.Size(671, 434);
		this.Root.TextVisible = false;
		this.layoutControlGroup1.AllowDrawBackground = false;
		this.layoutControlGroup1.GroupBordersVisible = false;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlItem1, this.tabbedControlGroup1 });
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup1.Name = "autoGeneratedGroup0";
		this.layoutControlGroup1.Size = new System.Drawing.Size(651, 366);
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 188);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(651, 178);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.ItemForFAX.Control = this.FAXTextEdit;
		this.ItemForFAX.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForFAX.Location = new System.Drawing.Point(180, 168);
		this.ItemForFAX.Name = "ItemForFAX";
		this.ItemForFAX.Size = new System.Drawing.Size(143, 24);
		this.ItemForFAX.Text = "Fax";
		this.ItemForFAX.TextSize = new System.Drawing.Size(18, 13);
		this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.layoutControlItem16, this.layoutControlItem17, this.layoutControlItem21, this.layoutControlItem22 });
		this.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup5.Location = new System.Drawing.Point(0, 366);
		this.layoutControlGroup5.Name = "layoutControlGroup5";
		this.layoutControlGroup5.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlGroup5.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
		this.layoutControlGroup5.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlGroup5.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlGroup5.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlGroup5.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlGroup5.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlGroup5.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition1.Width = 25.0;
		columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition2.Width = 25.0;
		columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition3.Width = 25.0;
		columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition4.Width = 25.0;
		this.layoutControlGroup5.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[4] { columnDefinition1, columnDefinition2, columnDefinition3, columnDefinition4 });
		rowDefinition1.Height = 100.0;
		rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
		this.layoutControlGroup5.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[1] { rowDefinition1 });
		this.layoutControlGroup5.Size = new System.Drawing.Size(651, 48);
		this.layoutControlGroup5.Text = "layoutControlGroup1";
		this.layoutControlGroup5.TextVisible = false;
		this.layoutControlItem16.Control = this.simpleButton4;
		this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem16.CustomizationFormText = "layoutControlItem10";
		this.layoutControlItem16.Location = new System.Drawing.Point(470, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 3;
		this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem16.Size = new System.Drawing.Size(157, 24);
		this.layoutControlItem16.Text = "layoutControlItem10";
		this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem16.TextVisible = false;
		this.layoutControlItem17.Control = this.simpleButton11;
		this.layoutControlItem17.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem17.CustomizationFormText = "layoutControlItem7";
		this.layoutControlItem17.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem17.Name = "layoutControlItem17";
		this.layoutControlItem17.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem17.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem17.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem17.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem17.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem17.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem17.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem17.Size = new System.Drawing.Size(156, 24);
		this.layoutControlItem17.Text = "layoutControlItem7";
		this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem17.TextVisible = false;
		this.layoutControlItem21.Control = this.simpleButton3;
		this.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem21.CustomizationFormText = "layoutControlItem9";
		this.layoutControlItem21.Location = new System.Drawing.Point(313, 0);
		this.layoutControlItem21.Name = "layoutControlItem21";
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem21.OptionsTableLayoutItem.ColumnIndex = 2;
		this.layoutControlItem21.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem21.Size = new System.Drawing.Size(157, 24);
		this.layoutControlItem21.Text = "layoutControlItem9";
		this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem21.TextVisible = false;
		this.layoutControlItem22.Control = this.simpleButton21;
		this.layoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem22.CustomizationFormText = "layoutControlItem8";
		this.layoutControlItem22.Location = new System.Drawing.Point(156, 0);
		this.layoutControlItem22.Name = "layoutControlItem22";
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem22.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem22.Size = new System.Drawing.Size(157, 24);
		this.layoutControlItem22.Text = "layoutControlItem8";
		this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem22.TextVisible = false;
		this.tiersTableAdapter.ClearBeforeFill = true;
		this.sharedImageCollection1.ImageSource.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("sharedImageCollection1.ImageSource.ImageStream");
		this.sharedImageCollection1.ImageSource.InsertImage(compta.Properties.Resources.images, "images", typeof(compta.Properties.Resources), 0);
		this.sharedImageCollection1.ImageSource.Images.SetKeyName(0, "images");
		this.sharedImageCollection1.ParentControl = this;
		this.villesTableAdapter.ClearBeforeFill = true;
		this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.tabbedControlGroup1.Name = "tabbedControlGroup1";
		this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
		this.tabbedControlGroup1.Size = new System.Drawing.Size(651, 188);
		this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup2, this.layoutControlGroup3 });
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[15]
		{
			this.ItemForTRS, this.ItemForTypeTiers, this.emptySpaceItem1, this.ItemForLIB, this.ItemForACT, this.ItemForADR, this.ItemForCP, this.ItemForRC, this.ItemForCF, this.ItemForNUMIF,
			this.ItemForNUMAI, this.ItemForNIS, this.ItemForMAIL, this.ItemForPORT, this.ItemForTEL
		});
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup2.Name = "layoutControlGroup2";
		this.layoutControlGroup2.Size = new System.Drawing.Size(627, 144);
		this.layoutControlGroup2.Text = "Informations";
		this.ItemForTRS.Control = this.TRSTextEdit;
		this.ItemForTRS.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForTRS.Location = new System.Drawing.Point(0, 0);
		this.ItemForTRS.MaxSize = new System.Drawing.Size(138, 22);
		this.ItemForTRS.MinSize = new System.Drawing.Size(138, 22);
		this.ItemForTRS.Name = "ItemForTRS";
		this.ItemForTRS.Size = new System.Drawing.Size(138, 24);
		this.ItemForTRS.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.ItemForTRS.Text = "Code";
		this.ItemForTRS.TextSize = new System.Drawing.Size(25, 13);
		this.ItemForTypeTiers.Control = this.TypeTiersComboBoxEdit;
		this.ItemForTypeTiers.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForTypeTiers.Location = new System.Drawing.Point(138, 0);
		this.ItemForTypeTiers.Name = "ItemForTypeTiers";
		this.ItemForTypeTiers.Size = new System.Drawing.Size(139, 24);
		this.ItemForTypeTiers.Text = "Type Tiers";
		this.ItemForTypeTiers.TextSize = new System.Drawing.Size(50, 13);
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(277, 0);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(350, 24);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.ItemForLIB.Control = this.LIBTextEdit;
		this.ItemForLIB.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForLIB.Location = new System.Drawing.Point(0, 24);
		this.ItemForLIB.Name = "ItemForLIB";
		this.ItemForLIB.Size = new System.Drawing.Size(311, 24);
		this.ItemForLIB.Text = "Intitulé";
		this.ItemForLIB.TextSize = new System.Drawing.Size(34, 13);
		this.ItemForACT.Control = this.ACTTextEdit;
		this.ItemForACT.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForACT.Location = new System.Drawing.Point(311, 24);
		this.ItemForACT.Name = "ItemForACT";
		this.ItemForACT.Size = new System.Drawing.Size(316, 24);
		this.ItemForACT.Text = "Activité";
		this.ItemForACT.TextSize = new System.Drawing.Size(36, 13);
		this.ItemForADR.Control = this.ADRTextEdit;
		this.ItemForADR.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForADR.Location = new System.Drawing.Point(0, 48);
		this.ItemForADR.Name = "ItemForADR";
		this.ItemForADR.Size = new System.Drawing.Size(382, 24);
		this.ItemForADR.Text = "Adresse";
		this.ItemForADR.TextSize = new System.Drawing.Size(39, 13);
		this.ItemForCP.Control = this.CPLookUpEdit;
		this.ItemForCP.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForCP.Location = new System.Drawing.Point(382, 48);
		this.ItemForCP.Name = "ItemForCP";
		this.ItemForCP.Size = new System.Drawing.Size(245, 24);
		this.ItemForCP.Text = "Ville";
		this.ItemForCP.TextSize = new System.Drawing.Size(18, 13);
		this.ItemForRC.Control = this.RCTextEdit;
		this.ItemForRC.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForRC.Location = new System.Drawing.Point(0, 72);
		this.ItemForRC.Name = "ItemForRC";
		this.ItemForRC.Size = new System.Drawing.Size(311, 24);
		this.ItemForRC.Text = "R.C.";
		this.ItemForRC.TextSize = new System.Drawing.Size(22, 13);
		this.ItemForCF.Control = this.CFTextEdit;
		this.ItemForCF.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForCF.Location = new System.Drawing.Point(311, 72);
		this.ItemForCF.Name = "ItemForCF";
		this.ItemForCF.Size = new System.Drawing.Size(316, 24);
		this.ItemForCF.Text = "C.F.";
		this.ItemForCF.TextSize = new System.Drawing.Size(21, 13);
		this.ItemForNUMIF.Control = this.NUMIFTextEdit;
		this.ItemForNUMIF.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForNUMIF.Location = new System.Drawing.Point(0, 96);
		this.ItemForNUMIF.Name = "ItemForNUMIF";
		this.ItemForNUMIF.Size = new System.Drawing.Size(233, 24);
		this.ItemForNUMIF.Text = "NUMIF";
		this.ItemForNUMIF.TextSize = new System.Drawing.Size(32, 13);
		this.ItemForNUMAI.Control = this.NUMAITextEdit;
		this.ItemForNUMAI.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForNUMAI.Location = new System.Drawing.Point(233, 96);
		this.ItemForNUMAI.Name = "ItemForNUMAI";
		this.ItemForNUMAI.Size = new System.Drawing.Size(196, 24);
		this.ItemForNUMAI.Text = "NUMAI";
		this.ItemForNUMAI.TextSize = new System.Drawing.Size(33, 13);
		this.ItemForNIS.Control = this.NISTextEdit;
		this.ItemForNIS.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForNIS.Location = new System.Drawing.Point(429, 96);
		this.ItemForNIS.Name = "ItemForNIS";
		this.ItemForNIS.Size = new System.Drawing.Size(198, 24);
		this.ItemForNIS.Text = "NIS";
		this.ItemForNIS.TextSize = new System.Drawing.Size(17, 13);
		this.ItemForMAIL.Control = this.MAILTextEdit;
		this.ItemForMAIL.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForMAIL.Location = new System.Drawing.Point(367, 120);
		this.ItemForMAIL.Name = "ItemForMAIL";
		this.ItemForMAIL.Size = new System.Drawing.Size(260, 24);
		this.ItemForMAIL.Text = "Mail";
		this.ItemForMAIL.TextSize = new System.Drawing.Size(18, 13);
		this.ItemForPORT.Control = this.PORTTextEdit;
		this.ItemForPORT.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForPORT.Location = new System.Drawing.Point(173, 120);
		this.ItemForPORT.Name = "ItemForPORT";
		this.ItemForPORT.Size = new System.Drawing.Size(194, 24);
		this.ItemForPORT.Text = "Portable";
		this.ItemForPORT.TextSize = new System.Drawing.Size(40, 13);
		this.ItemForTEL.Control = this.TELTextEdit;
		this.ItemForTEL.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForTEL.Location = new System.Drawing.Point(0, 120);
		this.ItemForTEL.Name = "ItemForTEL";
		this.ItemForTEL.Size = new System.Drawing.Size(173, 24);
		this.ItemForTEL.Text = "Téléphone";
		this.ItemForTEL.TextSize = new System.Drawing.Size(50, 13);
		this.ItemForADR1.Control = this.ADRTextEdit1;
		this.ItemForADR1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForADR1.CustomizationFormText = "Adresse";
		this.ItemForADR1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForADR1.Location = new System.Drawing.Point(0, 0);
		this.ItemForADR1.Name = "ItemForADR1";
		this.ItemForADR1.Size = new System.Drawing.Size(313, 24);
		this.ItemForADR1.Text = "Adresse Arabe";
		this.ItemForADR1.TextSize = new System.Drawing.Size(71, 13);
		this.ItemForACT1.Control = this.ACTTextEdit1;
		this.ItemForACT1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForACT1.CustomizationFormText = "Activité";
		this.ItemForACT1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForACT1.Location = new System.Drawing.Point(313, 0);
		this.ItemForACT1.Name = "ItemForACT1";
		this.ItemForACT1.Size = new System.Drawing.Size(314, 24);
		this.ItemForACT1.Text = "Activité Arabe";
		this.ItemForACT1.TextSize = new System.Drawing.Size(68, 13);
		this.ItemForLIB1.Control = this.LIBTextEdit1;
		this.ItemForLIB1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForLIB1.CustomizationFormText = "Intitulé";
		this.ItemForLIB1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForLIB1.Location = new System.Drawing.Point(0, 24);
		this.ItemForLIB1.Name = "ItemForLIB1";
		this.ItemForLIB1.Size = new System.Drawing.Size(627, 120);
		this.ItemForLIB1.Text = "Intitulé Arabe";
		this.ItemForLIB1.TextSize = new System.Drawing.Size(66, 13);
		this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.ItemForADR1, this.ItemForACT1, this.ItemForLIB1 });
		this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup3.Name = "layoutControlGroup3";
		this.layoutControlGroup3.Size = new System.Drawing.Size(627, 144);
		this.layoutControlGroup3.Text = "Inormations en Arabe";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(671, 434);
		base.Controls.Add(this.dataLayoutControl1);
		base.IconOptions.Image = compta.Properties.Resources.team_32x32;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmTiers";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Tiers";
		base.Load += new System.EventHandler(frmTiers_Load);
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).EndInit();
		this.dataLayoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TRSTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ACTTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ADRTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CPLookUpEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RCTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.NUMIFTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.NUMAITextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TypeTiersComboBoxEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CFTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TELTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.FAXTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PORTTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.MAILTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.NISTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ACTTextEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ADRTextEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForFAX).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).EndInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1.ImageSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.sharedImageCollection1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tabbedControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTRS).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTypeTiers).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCP).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForRC).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCF).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNUMIF).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNUMAI).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNIS).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForMAIL).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForPORT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTEL).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).EndInit();
		base.ResumeLayout(false);
	}
}
