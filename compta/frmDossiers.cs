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

public class frmDossiers : XtraForm
{
	private InputLanguage originalInputLang;

	private IContainer components;

	private DataLayoutControl dataLayoutControl1;

	private LayoutControlGroup Root;

	private TextEdit IDTextEdit;

	private LayoutControlItem ItemForID;

	private LayoutControlGroup layoutControlGroup1;

	internal GridControl GridControl1;

	internal GridView gridView1;

	internal GridView GridView3;

	private LayoutControlItem layoutControlItem1;

	private BindingSource bindingSource1;

	private GridColumn colUNI;

	private GridColumn colLIB;

	private GridColumn colACT;

	private TextEdit UNITextEdit;

	private TextEdit textEdit1;

	private TextEdit textEdit2;

	private LookUpEdit lookUpEdit1;

	private TextEdit textEdit3;

	private TextEdit textEdit4;

	private TextEdit textEdit5;

	private TextEdit textEdit6;

	private TextEdit textEdit7;

	private TextEdit textEdit8;

	private TextEdit textEdit10;

	private TextEdit textEdit11;

	private TextEdit textEdit12;

	private TextEdit textEdit13;

	private TextEdit textEdit16;

	private TextEdit textEdit17;

	private LayoutControlItem ItemForUNI;

	private LayoutControlItem layoutControlItem5;

	private LayoutControlItem layoutControlItem6;

	private LayoutControlItem layoutControlItem8;

	private LayoutControlItem layoutControlItem9;

	private LayoutControlItem layoutControlItem12;

	private LayoutControlItem layoutControlItem14;

	private LayoutControlItem layoutControlItem15;

	private LayoutControlItem layoutControlItem18;

	private LayoutControlItem layoutControlItem19;

	private DataSet1 dataSet1;

	private DossiersTableAdapter dossiersTableAdapter;

	private LayoutControlGroup layoutControlGroup3;

	private LookUpEdit lookUpEdit2;

	private BindingSource villesBindingSource;

	private VillesTableAdapter villesTableAdapter;

	private BindingSource villesBindingSource1;

	private SimpleButton simpleButton4;

	private SimpleButton simpleButton11;

	private SimpleButton simpleButton3;

	private SimpleButton simpleButton2;

	private LayoutControlGroup layoutControlGroup5;

	private LayoutControlItem layoutControlItem16;

	private LayoutControlItem layoutControlItem17;

	private LayoutControlItem layoutControlItem21;

	private LayoutControlItem layoutControlItem22;

	private TabbedControlGroup tabbedControlGroup1;

	private LayoutControlGroup layoutControlGroup4;

	private LayoutControlItem ItemForLIB;

	private LayoutControlItem ItemForADR;

	private LayoutControlItem ItemForACT;

	private LayoutControlItem ItemForCP;

	private LayoutControlItem ItemForMAIL;

	private LayoutControlItem ItemForTEL;

	private LayoutControlItem layoutControlItem11;

	private LayoutControlGroup layoutControlGroup2;

	private TextEdit textEdit14;

	private LayoutControlItem ItemForLIB1;

	private TextEdit textEdit51;

	private LayoutControlItem ItemForACT1;

	private TextEdit textEdit21;

	private LayoutControlItem ItemForADR1;

	public frmDossiers()
	{
		InitializeComponent();
		ApplyModernIcons();
	}

	private void ApplyModernIcons()
	{
		IconManager.SetIcon(simpleButton11, IconManager.Icons.Save);
		IconManager.SetIcon(simpleButton2, IconManager.Icons.Add);
		IconManager.SetIcon(simpleButton3, IconManager.Icons.Delete);
		IconManager.SetIcon(simpleButton4, IconManager.Icons.Print);
	}

	private void frmDossiers_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		villesTableAdapter.Connection.ConnectionString = connection;
		dossiersTableAdapter.Connection.ConnectionString = connection;
		dossiersTableAdapter.Fill(dataSet1.Dossiers);
		villesTableAdapter.Fill(dataSet1.Villes);
	}

	private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UNI");
		monModule.gUNI = ((t == null) ? "" : t.ToString());
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

	private void toolStripButton1_Click(object sender, EventArgs e)
	{
		try
		{
			bindingSource1.EndEdit();
			dossiersTableAdapter.Update(dataSet1.Dossiers);
			dataSet1.Dossiers.AcceptChanges();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			dataSet1.Dossiers.RejectChanges();
		}
	}

	private void UNITextEdit_DoubleClick(object sender, EventArgs e)
	{
	}

	private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
	{
		string connectionString = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		string maxVal = dataSet1.Dossiers.Compute("max([UNI])", string.Empty).ToString();
		maxVal = monModule.Suivant(maxVal);
		OleDbTransaction transaction = null;
		string cp = monModule.GetFirstID(dataSet1.Villes, "CP").ToString();
		OleDbCommand cmd = new OleDbCommand
		{
			CommandType = CommandType.Text
		};
		using (OleDbConnection gbase = new OleDbConnection(connectionString))
		{
			gbase.Open();
			cmd.Connection = gbase;
			transaction = (cmd.Transaction = gbase.BeginTransaction());
			cmd.CommandText = "INSERT INTO Dossiers  (UNI, CP, CPWilaya, CPCommune) VALUES ('" + maxVal + "', '" + cp + "','" + cp + "','" + cp + "')";
			cmd.ExecuteNonQuery();
			cmd.CommandText = "INSERT INTO Tiers  (UNI, TRS) VALUES ('" + maxVal + "', '-')";
			cmd.ExecuteNonQuery();
			transaction.Commit();
		}
		dataSet1.Dossiers.Clear();
		dossiersTableAdapter.Fill(dataSet1.Dossiers);
		bindingSource1.MoveLast();
	}

	private void textEdit14_Enter(object sender, EventArgs e)
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

	private void textEdit14_Leave(object sender, EventArgs e)
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
		this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
		this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
		this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.villesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colACT = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.UNITextEdit = new DevExpress.XtraEditors.TextEdit();
		this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
		this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
		this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit13 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit16 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit17 = new DevExpress.XtraEditors.TextEdit();
		this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
		this.textEdit14 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit51 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit21 = new DevExpress.XtraEditors.TextEdit();
		this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForUNI = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
		this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
		this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForLIB = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForADR = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForACT = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForCP = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForMAIL = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForTEL = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForLIB1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForACT1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForADR1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.dossiersTableAdapter = new compta.DataSet1TableAdapters.DossiersTableAdapter();
		this.villesTableAdapter = new compta.DataSet1TableAdapters.VillesTableAdapter();
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).BeginInit();
		this.dataLayoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.lookUpEdit2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.lookUpEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit3.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit4.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit5.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit6.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit7.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit8.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit10.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit11.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit12.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit13.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit16.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit17.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit14.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit51.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit21.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem12).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem14).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem8).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem18).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem19).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem15).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tabbedControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCP).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForMAIL).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTEL).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem11).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).BeginInit();
		base.SuspendLayout();
		this.dataLayoutControl1.Controls.Add(this.lookUpEdit2);
		this.dataLayoutControl1.Controls.Add(this.GridControl1);
		this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
		this.dataLayoutControl1.Controls.Add(this.UNITextEdit);
		this.dataLayoutControl1.Controls.Add(this.textEdit1);
		this.dataLayoutControl1.Controls.Add(this.textEdit2);
		this.dataLayoutControl1.Controls.Add(this.lookUpEdit1);
		this.dataLayoutControl1.Controls.Add(this.textEdit3);
		this.dataLayoutControl1.Controls.Add(this.textEdit4);
		this.dataLayoutControl1.Controls.Add(this.textEdit5);
		this.dataLayoutControl1.Controls.Add(this.textEdit6);
		this.dataLayoutControl1.Controls.Add(this.textEdit7);
		this.dataLayoutControl1.Controls.Add(this.textEdit8);
		this.dataLayoutControl1.Controls.Add(this.textEdit10);
		this.dataLayoutControl1.Controls.Add(this.textEdit11);
		this.dataLayoutControl1.Controls.Add(this.textEdit12);
		this.dataLayoutControl1.Controls.Add(this.textEdit13);
		this.dataLayoutControl1.Controls.Add(this.textEdit16);
		this.dataLayoutControl1.Controls.Add(this.textEdit17);
		this.dataLayoutControl1.Controls.Add(this.simpleButton4);
		this.dataLayoutControl1.Controls.Add(this.simpleButton11);
		this.dataLayoutControl1.Controls.Add(this.simpleButton3);
		this.dataLayoutControl1.Controls.Add(this.simpleButton2);
		this.dataLayoutControl1.Controls.Add(this.textEdit14);
		this.dataLayoutControl1.Controls.Add(this.textEdit51);
		this.dataLayoutControl1.Controls.Add(this.textEdit21);
		this.dataLayoutControl1.DataSource = this.bindingSource1;
		this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.ItemForID, this.layoutControlItem9, this.layoutControlItem12 });
		this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
		this.dataLayoutControl1.Name = "dataLayoutControl1";
		this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(950, 269, 650, 400);
		this.dataLayoutControl1.Root = this.Root;
		this.dataLayoutControl1.Size = new System.Drawing.Size(698, 489);
		this.dataLayoutControl1.TabIndex = 0;
		this.dataLayoutControl1.Text = "dataLayoutControl1";
		this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CPCommune", true));
		this.lookUpEdit2.Location = new System.Drawing.Point(538, 92);
		this.lookUpEdit2.Name = "lookUpEdit2";
		this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.lookUpEdit2.Properties.DataSource = this.villesBindingSource1;
		this.lookUpEdit2.Properties.DisplayMember = "LIB";
		this.lookUpEdit2.Properties.NullText = "";
		this.lookUpEdit2.Properties.ValueMember = "CP";
		this.lookUpEdit2.Size = new System.Drawing.Size(136, 20);
		this.lookUpEdit2.StyleController = this.dataLayoutControl1;
		this.lookUpEdit2.TabIndex = 43;
		this.bindingSource1.DataMember = "Dossiers";
		this.bindingSource1.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.villesBindingSource1.DataMember = "Villes";
		this.villesBindingSource1.DataSource = this.dataSet1;
		this.GridControl1.DataSource = this.bindingSource1;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(12, 230);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(674, 199);
		this.GridControl1.TabIndex = 22;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colUNI, this.colLIB, this.colACT });
		this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(319, -670, 498, 610);
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
		this.colUNI.FieldName = "UNI";
		this.colUNI.Name = "colUNI";
		this.colUNI.Visible = true;
		this.colUNI.VisibleIndex = 0;
		this.colUNI.Width = 63;
		this.colLIB.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB.FieldName = "LIB";
		this.colLIB.Name = "colLIB";
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 1;
		this.colLIB.Width = 277;
		this.colACT.AppearanceCell.Options.UseTextOptions = true;
		this.colACT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.colACT.AppearanceHeader.Options.UseTextOptions = true;
		this.colACT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colACT.Caption = "Intitulé en Arabe";
		this.colACT.FieldName = "LIBAR";
		this.colACT.Name = "colACT";
		this.colACT.Visible = true;
		this.colACT.VisibleIndex = 2;
		this.colACT.Width = 307;
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
		this.IDTextEdit.Location = new System.Drawing.Point(74, 6);
		this.IDTextEdit.Name = "IDTextEdit";
		this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.IDTextEdit.Properties.Mask.EditMask = "N0";
		this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.IDTextEdit.Size = new System.Drawing.Size(880, 20);
		this.IDTextEdit.StyleController = this.dataLayoutControl1;
		this.IDTextEdit.TabIndex = 11;
		this.UNITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "UNI", true));
		this.UNITextEdit.Location = new System.Drawing.Point(40, 12);
		this.UNITextEdit.Name = "UNITextEdit";
		this.UNITextEdit.Size = new System.Drawing.Size(112, 20);
		this.UNITextEdit.StyleController = this.dataLayoutControl1;
		this.UNITextEdit.TabIndex = 23;
		this.UNITextEdit.DoubleClick += new System.EventHandler(UNITextEdit_DoubleClick);
		this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIB", true));
		this.textEdit1.Location = new System.Drawing.Point(63, 68);
		this.textEdit1.Name = "textEdit1";
		this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.textEdit1.Size = new System.Drawing.Size(323, 20);
		this.textEdit1.StyleController = this.dataLayoutControl1;
		this.textEdit1.TabIndex = 24;
		this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ADR", true));
		this.textEdit2.Location = new System.Drawing.Point(66, 92);
		this.textEdit2.Name = "textEdit2";
		this.textEdit2.Size = new System.Drawing.Size(228, 20);
		this.textEdit2.StyleController = this.dataLayoutControl1;
		this.textEdit2.TabIndex = 25;
		this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CPWilaya", true));
		this.lookUpEdit1.Location = new System.Drawing.Point(319, 92);
		this.lookUpEdit1.Name = "lookUpEdit1";
		this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.lookUpEdit1.Properties.DataSource = this.villesBindingSource;
		this.lookUpEdit1.Properties.DisplayMember = "LIB";
		this.lookUpEdit1.Properties.NullText = "";
		this.lookUpEdit1.Properties.ValueMember = "CP";
		this.lookUpEdit1.Size = new System.Drawing.Size(165, 20);
		this.lookUpEdit1.StyleController = this.dataLayoutControl1;
		this.lookUpEdit1.TabIndex = 26;
		this.villesBindingSource.DataMember = "Villes";
		this.villesBindingSource.DataSource = this.dataSet1;
		this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "NUMIF", true));
		this.textEdit3.Location = new System.Drawing.Point(54, 201);
		this.textEdit3.Name = "textEdit3";
		this.textEdit3.Size = new System.Drawing.Size(125, 20);
		this.textEdit3.StyleController = this.dataLayoutControl1;
		this.textEdit3.TabIndex = 27;
		this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "NUMAI", true));
		this.textEdit4.Location = new System.Drawing.Point(389, 201);
		this.textEdit4.Name = "textEdit4";
		this.textEdit4.Size = new System.Drawing.Size(123, 20);
		this.textEdit4.StyleController = this.dataLayoutControl1;
		this.textEdit4.TabIndex = 28;
		this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ACT", true));
		this.textEdit5.Location = new System.Drawing.Point(431, 68);
		this.textEdit5.Name = "textEdit5";
		this.textEdit5.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.textEdit5.Size = new System.Drawing.Size(243, 20);
		this.textEdit5.StyleController = this.dataLayoutControl1;
		this.textEdit5.TabIndex = 29;
		this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "RC", true));
		this.textEdit6.Location = new System.Drawing.Point(535, 201);
		this.textEdit6.Name = "textEdit6";
		this.textEdit6.Size = new System.Drawing.Size(146, 20);
		this.textEdit6.StyleController = this.dataLayoutControl1;
		this.textEdit6.TabIndex = 30;
		this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ID", true));
		this.textEdit7.Location = new System.Drawing.Point(73, 94);
		this.textEdit7.Name = "textEdit7";
		this.textEdit7.Properties.Appearance.Options.UseTextOptions = true;
		this.textEdit7.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.textEdit7.Properties.Mask.EditMask = "N0";
		this.textEdit7.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.textEdit7.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.textEdit7.Size = new System.Drawing.Size(881, 20);
		this.textEdit7.StyleController = this.dataLayoutControl1;
		this.textEdit7.TabIndex = 31;
		this.textEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "TEL", true));
		this.textEdit8.Location = new System.Drawing.Point(77, 116);
		this.textEdit8.Name = "textEdit8";
		this.textEdit8.Size = new System.Drawing.Size(150, 20);
		this.textEdit8.StyleController = this.dataLayoutControl1;
		this.textEdit8.TabIndex = 32;
		this.textEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CF", true));
		this.textEdit10.Location = new System.Drawing.Point(73, 142);
		this.textEdit10.Name = "textEdit10";
		this.textEdit10.Size = new System.Drawing.Size(881, 20);
		this.textEdit10.StyleController = this.dataLayoutControl1;
		this.textEdit10.TabIndex = 34;
		this.textEdit11.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "MAIL", true));
		this.textEdit11.Location = new System.Drawing.Point(252, 116);
		this.textEdit11.Name = "textEdit11";
		this.textEdit11.Size = new System.Drawing.Size(422, 20);
		this.textEdit11.StyleController = this.dataLayoutControl1;
		this.textEdit11.TabIndex = 35;
		this.textEdit12.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "NIS", true));
		this.textEdit12.Location = new System.Drawing.Point(205, 201);
		this.textEdit12.Name = "textEdit12";
		this.textEdit12.Size = new System.Drawing.Size(142, 20);
		this.textEdit12.StyleController = this.dataLayoutControl1;
		this.textEdit12.TabIndex = 36;
		this.textEdit13.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CodeActivite", true));
		this.textEdit13.Location = new System.Drawing.Point(223, 12);
		this.textEdit13.Name = "textEdit13";
		this.textEdit13.Size = new System.Drawing.Size(463, 20);
		this.textEdit13.StyleController = this.dataLayoutControl1;
		this.textEdit13.TabIndex = 37;
		this.textEdit16.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Inspection", true));
		this.textEdit16.Location = new System.Drawing.Point(70, 177);
		this.textEdit16.Name = "textEdit16";
		this.textEdit16.Size = new System.Drawing.Size(277, 20);
		this.textEdit16.StyleController = this.dataLayoutControl1;
		this.textEdit16.TabIndex = 40;
		this.textEdit17.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Recette", true));
		this.textEdit17.Location = new System.Drawing.Point(392, 177);
		this.textEdit17.Name = "textEdit17";
		this.textEdit17.Size = new System.Drawing.Size(289, 20);
		this.textEdit17.StyleController = this.dataLayoutControl1;
		this.textEdit17.TabIndex = 41;
		this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton4.Location = new System.Drawing.Point(531, 444);
		this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton4.Name = "simpleButton4";
		this.simpleButton4.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton4.Size = new System.Drawing.Size(125, 22);
		this.simpleButton4.StyleController = this.dataLayoutControl1;
		this.simpleButton4.TabIndex = 78;
		this.simpleButton4.TabStop = false;
		this.simpleButton4.Text = "Imprimer";
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(42, 444);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton11.Size = new System.Drawing.Size(123, 22);
		this.simpleButton11.StyleController = this.dataLayoutControl1;
		this.simpleButton11.TabIndex = 75;
		this.simpleButton11.TabStop = false;
		this.simpleButton11.Text = "Enregistrer";
		this.simpleButton11.Click += new System.EventHandler(toolStripButton1_Click);
		this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton3.Location = new System.Drawing.Point(368, 444);
		this.simpleButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton3.Name = "simpleButton3";
		this.simpleButton3.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton3.Size = new System.Drawing.Size(123, 22);
		this.simpleButton3.StyleController = this.dataLayoutControl1;
		this.simpleButton3.TabIndex = 77;
		this.simpleButton3.TabStop = false;
		this.simpleButton3.Text = "Supprimer";
		this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton2.Location = new System.Drawing.Point(205, 444);
		this.simpleButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton2.Name = "simpleButton2";
		this.simpleButton2.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton2.Size = new System.Drawing.Size(123, 22);
		this.simpleButton2.StyleController = this.dataLayoutControl1;
		this.simpleButton2.TabIndex = 76;
		this.simpleButton2.TabStop = false;
		this.simpleButton2.Text = "Ajouter";
		this.simpleButton2.Click += new System.EventHandler(bindingNavigatorAddNewItem_Click);
		this.textEdit14.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIBAR", true));
		this.textEdit14.Location = new System.Drawing.Point(93, 68);
		this.textEdit14.Name = "textEdit14";
		this.textEdit14.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.textEdit14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.textEdit14.Size = new System.Drawing.Size(581, 20);
		this.textEdit14.StyleController = this.dataLayoutControl1;
		this.textEdit14.TabIndex = 24;
		this.textEdit14.Enter += new System.EventHandler(textEdit14_Enter);
		this.textEdit14.Leave += new System.EventHandler(textEdit14_Leave);
		this.textEdit51.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ACTAR", true));
		this.textEdit51.Location = new System.Drawing.Point(95, 92);
		this.textEdit51.Name = "textEdit51";
		this.textEdit51.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.textEdit51.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.textEdit51.Size = new System.Drawing.Size(579, 20);
		this.textEdit51.StyleController = this.dataLayoutControl1;
		this.textEdit51.TabIndex = 29;
		this.textEdit51.Enter += new System.EventHandler(textEdit14_Enter);
		this.textEdit51.Leave += new System.EventHandler(textEdit14_Leave);
		this.textEdit21.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ADRAR", true));
		this.textEdit21.Location = new System.Drawing.Point(98, 116);
		this.textEdit21.Name = "textEdit21";
		this.textEdit21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.textEdit21.Size = new System.Drawing.Size(576, 20);
		this.textEdit21.StyleController = this.dataLayoutControl1;
		this.textEdit21.TabIndex = 25;
		this.textEdit21.Enter += new System.EventHandler(textEdit14_Enter);
		this.textEdit21.Leave += new System.EventHandler(textEdit14_Leave);
		this.ItemForID.Control = this.IDTextEdit;
		this.ItemForID.Location = new System.Drawing.Point(0, 0);
		this.ItemForID.Name = "item0";
		this.ItemForID.Size = new System.Drawing.Size(950, 22);
		this.ItemForID.Text = "ID";
		this.ItemForID.TextSize = new System.Drawing.Size(50, 20);
		this.layoutControlItem9.Control = this.textEdit7;
		this.layoutControlItem9.Location = new System.Drawing.Point(0, 88);
		this.layoutControlItem9.Name = "ItemForID";
		this.layoutControlItem9.Size = new System.Drawing.Size(950, 22);
		this.layoutControlItem9.Text = "ID";
		this.layoutControlItem9.TextSize = new System.Drawing.Size(64, 13);
		this.layoutControlItem12.Control = this.textEdit10;
		this.layoutControlItem12.Location = new System.Drawing.Point(0, 136);
		this.layoutControlItem12.Name = "ItemForCF";
		this.layoutControlItem12.Size = new System.Drawing.Size(950, 22);
		this.layoutControlItem12.Text = "CF";
		this.layoutControlItem12.TextSize = new System.Drawing.Size(64, 13);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup1, this.layoutControlGroup5 });
		this.Root.Name = "Root";
		this.Root.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
		this.Root.Size = new System.Drawing.Size(698, 489);
		this.Root.TextVisible = false;
		this.layoutControlGroup1.AllowDrawBackground = false;
		this.layoutControlGroup1.GroupBordersVisible = false;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[5] { this.ItemForUNI, this.layoutControlItem1, this.layoutControlGroup3, this.layoutControlItem15, this.tabbedControlGroup1 });
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup1.Name = "autoGeneratedGroup0";
		this.layoutControlGroup1.Size = new System.Drawing.Size(678, 421);
		this.ItemForUNI.Control = this.UNITextEdit;
		this.ItemForUNI.Location = new System.Drawing.Point(0, 0);
		this.ItemForUNI.Name = "ItemForUNI";
		this.ItemForUNI.Size = new System.Drawing.Size(144, 24);
		this.ItemForUNI.Text = "Code";
		this.ItemForUNI.TextSize = new System.Drawing.Size(25, 13);
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 218);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(678, 203);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[6] { this.layoutControlItem5, this.layoutControlItem14, this.layoutControlItem6, this.layoutControlItem8, this.layoutControlItem18, this.layoutControlItem19 });
		this.layoutControlGroup3.Location = new System.Drawing.Point(0, 140);
		this.layoutControlGroup3.Name = "layoutControlGroup3";
		this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
		this.layoutControlGroup3.Size = new System.Drawing.Size(678, 78);
		this.layoutControlGroup3.Text = "Informations Fiscales";
		this.layoutControlItem5.Control = this.textEdit3;
		this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
		this.layoutControlItem5.Name = "ItemForNUMIF";
		this.layoutControlItem5.Size = new System.Drawing.Size(166, 24);
		this.layoutControlItem5.Text = "NUMIF";
		this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
		this.layoutControlItem5.TextSize = new System.Drawing.Size(32, 13);
		this.layoutControlItem5.TextToControlDistance = 5;
		this.layoutControlItem14.Control = this.textEdit12;
		this.layoutControlItem14.Location = new System.Drawing.Point(166, 24);
		this.layoutControlItem14.Name = "ItemForNIS";
		this.layoutControlItem14.Size = new System.Drawing.Size(168, 24);
		this.layoutControlItem14.Text = "NIS";
		this.layoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
		this.layoutControlItem14.TextSize = new System.Drawing.Size(17, 13);
		this.layoutControlItem14.TextToControlDistance = 5;
		this.layoutControlItem6.Control = this.textEdit4;
		this.layoutControlItem6.Location = new System.Drawing.Point(334, 24);
		this.layoutControlItem6.Name = "ItemForNUMAI";
		this.layoutControlItem6.Size = new System.Drawing.Size(165, 24);
		this.layoutControlItem6.Text = "NUMAI";
		this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
		this.layoutControlItem6.TextSize = new System.Drawing.Size(33, 13);
		this.layoutControlItem6.TextToControlDistance = 5;
		this.layoutControlItem8.Control = this.textEdit6;
		this.layoutControlItem8.Location = new System.Drawing.Point(499, 24);
		this.layoutControlItem8.Name = "ItemForRC";
		this.layoutControlItem8.Size = new System.Drawing.Size(169, 24);
		this.layoutControlItem8.Text = "RC";
		this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
		this.layoutControlItem8.TextSize = new System.Drawing.Size(14, 13);
		this.layoutControlItem8.TextToControlDistance = 5;
		this.layoutControlItem18.Control = this.textEdit16;
		this.layoutControlItem18.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem18.Name = "ItemForInspection";
		this.layoutControlItem18.Size = new System.Drawing.Size(334, 24);
		this.layoutControlItem18.Text = "Inspection";
		this.layoutControlItem18.TextSize = new System.Drawing.Size(50, 13);
		this.layoutControlItem19.Control = this.textEdit17;
		this.layoutControlItem19.Location = new System.Drawing.Point(334, 0);
		this.layoutControlItem19.Name = "ItemForRecette";
		this.layoutControlItem19.Size = new System.Drawing.Size(334, 24);
		this.layoutControlItem19.Text = "Recette";
		this.layoutControlItem19.TextSize = new System.Drawing.Size(38, 13);
		this.layoutControlItem15.Control = this.textEdit13;
		this.layoutControlItem15.Location = new System.Drawing.Point(144, 0);
		this.layoutControlItem15.Name = "ItemForCodeActivite";
		this.layoutControlItem15.Size = new System.Drawing.Size(534, 24);
		this.layoutControlItem15.Text = "Code Activite";
		this.layoutControlItem15.TextSize = new System.Drawing.Size(64, 13);
		this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 24);
		this.tabbedControlGroup1.Name = "tabbedControlGroup1";
		this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
		this.tabbedControlGroup1.Size = new System.Drawing.Size(678, 116);
		this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup4, this.layoutControlGroup2 });
		this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[7] { this.ItemForLIB, this.ItemForADR, this.ItemForACT, this.ItemForCP, this.ItemForMAIL, this.ItemForTEL, this.layoutControlItem11 });
		this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup4.Name = "layoutControlGroup4";
		this.layoutControlGroup4.Size = new System.Drawing.Size(654, 72);
		this.layoutControlGroup4.Text = "Informtions Client";
		this.ItemForLIB.Control = this.textEdit1;
		this.ItemForLIB.Location = new System.Drawing.Point(0, 0);
		this.ItemForLIB.Name = "ItemForLIB";
		this.ItemForLIB.Size = new System.Drawing.Size(366, 24);
		this.ItemForLIB.Text = "Intitulé";
		this.ItemForLIB.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
		this.ItemForLIB.TextSize = new System.Drawing.Size(34, 13);
		this.ItemForLIB.TextToControlDistance = 5;
		this.ItemForADR.Control = this.textEdit2;
		this.ItemForADR.Location = new System.Drawing.Point(0, 24);
		this.ItemForADR.Name = "ItemForADR";
		this.ItemForADR.Size = new System.Drawing.Size(274, 24);
		this.ItemForADR.Text = "Adresse";
		this.ItemForADR.TextSize = new System.Drawing.Size(39, 13);
		this.ItemForACT.Control = this.textEdit5;
		this.ItemForACT.Location = new System.Drawing.Point(366, 0);
		this.ItemForACT.Name = "ItemForACT";
		this.ItemForACT.Size = new System.Drawing.Size(288, 24);
		this.ItemForACT.Text = "Activité";
		this.ItemForACT.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
		this.ItemForACT.TextSize = new System.Drawing.Size(36, 13);
		this.ItemForACT.TextToControlDistance = 5;
		this.ItemForCP.Control = this.lookUpEdit1;
		this.ItemForCP.Location = new System.Drawing.Point(274, 24);
		this.ItemForCP.Name = "ItemForCP";
		this.ItemForCP.Size = new System.Drawing.Size(190, 24);
		this.ItemForCP.Text = "Ville";
		this.ItemForCP.TextSize = new System.Drawing.Size(18, 13);
		this.ItemForMAIL.Control = this.textEdit11;
		this.ItemForMAIL.Location = new System.Drawing.Point(207, 48);
		this.ItemForMAIL.Name = "ItemForMAIL";
		this.ItemForMAIL.Size = new System.Drawing.Size(447, 24);
		this.ItemForMAIL.Text = "Mail";
		this.ItemForMAIL.TextSize = new System.Drawing.Size(18, 13);
		this.ItemForTEL.Control = this.textEdit8;
		this.ItemForTEL.Location = new System.Drawing.Point(0, 48);
		this.ItemForTEL.Name = "ItemForTEL";
		this.ItemForTEL.Size = new System.Drawing.Size(207, 24);
		this.ItemForTEL.Text = "Téléphone";
		this.ItemForTEL.TextSize = new System.Drawing.Size(50, 13);
		this.layoutControlItem11.Control = this.lookUpEdit2;
		this.layoutControlItem11.Location = new System.Drawing.Point(464, 24);
		this.layoutControlItem11.Name = "layoutControlItem11";
		this.layoutControlItem11.Size = new System.Drawing.Size(190, 24);
		this.layoutControlItem11.Text = "Commune";
		this.layoutControlItem11.TextSize = new System.Drawing.Size(47, 13);
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.ItemForLIB1, this.ItemForACT1, this.ItemForADR1 });
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup2.Name = "layoutControlGroup2";
		this.layoutControlGroup2.Size = new System.Drawing.Size(654, 72);
		this.layoutControlGroup2.Text = "Information en Arabe";
		this.ItemForLIB1.Control = this.textEdit14;
		this.ItemForLIB1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForLIB1.CustomizationFormText = "Intitulé";
		this.ItemForLIB1.Location = new System.Drawing.Point(0, 0);
		this.ItemForLIB1.Name = "ItemForLIB1";
		this.ItemForLIB1.Size = new System.Drawing.Size(654, 24);
		this.ItemForLIB1.Text = "Intitulé Arabe";
		this.ItemForLIB1.TextSize = new System.Drawing.Size(66, 13);
		this.ItemForACT1.Control = this.textEdit51;
		this.ItemForACT1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForACT1.CustomizationFormText = "Activité";
		this.ItemForACT1.Location = new System.Drawing.Point(0, 24);
		this.ItemForACT1.Name = "ItemForACT1";
		this.ItemForACT1.Size = new System.Drawing.Size(654, 24);
		this.ItemForACT1.Text = "Activité Arabe";
		this.ItemForACT1.TextSize = new System.Drawing.Size(68, 13);
		this.ItemForADR1.Control = this.textEdit21;
		this.ItemForADR1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForADR1.CustomizationFormText = "Adresse";
		this.ItemForADR1.Location = new System.Drawing.Point(0, 48);
		this.ItemForADR1.Name = "ItemForADR1";
		this.ItemForADR1.Size = new System.Drawing.Size(654, 24);
		this.ItemForADR1.Text = "Adresse Arabe";
		this.ItemForADR1.TextSize = new System.Drawing.Size(71, 13);
		this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.layoutControlItem16, this.layoutControlItem17, this.layoutControlItem21, this.layoutControlItem22 });
		this.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup5.Location = new System.Drawing.Point(0, 421);
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
		this.layoutControlGroup5.Size = new System.Drawing.Size(678, 48);
		this.layoutControlGroup5.Text = "layoutControlGroup1";
		this.layoutControlGroup5.TextVisible = false;
		this.layoutControlItem16.Control = this.simpleButton4;
		this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem16.CustomizationFormText = "layoutControlItem10";
		this.layoutControlItem16.Location = new System.Drawing.Point(489, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 3;
		this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem16.Size = new System.Drawing.Size(165, 24);
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
		this.layoutControlItem17.Size = new System.Drawing.Size(163, 24);
		this.layoutControlItem17.Text = "layoutControlItem7";
		this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem17.TextVisible = false;
		this.layoutControlItem21.Control = this.simpleButton3;
		this.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem21.CustomizationFormText = "layoutControlItem9";
		this.layoutControlItem21.Location = new System.Drawing.Point(326, 0);
		this.layoutControlItem21.Name = "layoutControlItem21";
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem21.OptionsTableLayoutItem.ColumnIndex = 2;
		this.layoutControlItem21.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem21.Size = new System.Drawing.Size(163, 24);
		this.layoutControlItem21.Text = "layoutControlItem9";
		this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem21.TextVisible = false;
		this.layoutControlItem22.Control = this.simpleButton2;
		this.layoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem22.CustomizationFormText = "layoutControlItem8";
		this.layoutControlItem22.Location = new System.Drawing.Point(163, 0);
		this.layoutControlItem22.Name = "layoutControlItem22";
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem22.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem22.Size = new System.Drawing.Size(163, 24);
		this.layoutControlItem22.Text = "layoutControlItem8";
		this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem22.TextVisible = false;
		this.dossiersTableAdapter.ClearBeforeFill = true;
		this.villesTableAdapter.ClearBeforeFill = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(698, 489);
		base.Controls.Add(this.dataLayoutControl1);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmDossiers";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Dossiers";
		base.Load += new System.EventHandler(frmDossiers_Load);
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).EndInit();
		this.dataLayoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.lookUpEdit2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.lookUpEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit3.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit4.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit5.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit6.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit7.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit8.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit10.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit11.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit12.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit13.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit16.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit17.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit14.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit51.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit21.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem12).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem14).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem8).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem18).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem19).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem15).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tabbedControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCP).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForMAIL).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTEL).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem11).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).EndInit();
		base.ResumeLayout(false);
	}
}
