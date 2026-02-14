using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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

public class frmVilles : XtraForm
{
	private InputLanguage originalInputLang;

	private IContainer components;

	private DataLayoutControl dataLayoutControl1;

	private LayoutControlGroup Root;

	private DataSet1 dataSet1;

	private BindingSource villesBindingSource;

	private VillesTableAdapter villesTableAdapter;

	private TextEdit CPTextEdit;

	private TextEdit LIBTextEdit;

	private TextEdit LIBARTextEdit;

	private LayoutControlGroup layoutControlGroup1;

	private LayoutControlItem ItemForCP;

	private LayoutControlItem ItemForLIB;

	private LayoutControlItem ItemForLIBAR;

	internal GridControl GridControl1;

	internal GridView gridView1;

	private GridColumn colCP;

	private GridColumn colLIB;

	private GridColumn colLIBAR;

	internal GridView GridView3;

	private LayoutControlItem layoutControlItem1;

	private SimpleButton simpleButton4;

	private SimpleButton simpleButton11;

	private SimpleButton simpleButton3;

	private SimpleButton simpleButton21;

	private LayoutControlGroup layoutControlGroup5;

	private LayoutControlItem layoutControlItem16;

	private LayoutControlItem layoutControlItem17;

	private LayoutControlItem layoutControlItem21;

	private LayoutControlItem layoutControlItem22;

	private EmptySpaceItem emptySpaceItem1;

	public frmVilles()
	{
		InitializeComponent();
		ApplyModernIcons();
	}

	private void ApplyModernIcons()
	{
		IconManager.SetIcon(simpleButton11, IconManager.Icons.Save);
		IconManager.SetIcon(simpleButton21, IconManager.Icons.Add);
		IconManager.SetIcon(simpleButton3, IconManager.Icons.Delete);
		IconManager.SetIcon(simpleButton4, IconManager.Icons.Print);
	}

	private void frmVilles_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		villesTableAdapter.Connection.ConnectionString = connection;
		villesTableAdapter.Fill(dataSet1.Villes);
	}

	private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
	{
		string maxVal = dataSet1.Villes.Compute("max([CP])", string.Empty).ToString();
		((DataRowView)villesBindingSource.AddNew())["CP"] = monModule.Suivant(maxVal);
		villesBindingSource.EndEdit();
		villesTableAdapter.Update(dataSet1.Villes);
		dataSet1.Villes.AcceptChanges();
		Rafraichir();
	}

	private void Rafraichir()
	{
		if (dataSet1.Villes != null)
		{
			int pos = villesBindingSource.Position;
			dataSet1.Villes.Clear();
			villesTableAdapter.Fill(dataSet1.Villes);
			villesBindingSource.Position = pos;
		}
	}

	private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("هل تريد فعلا حدف المعلومات", "أكد الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
		{
			try
			{
				villesBindingSource.RemoveCurrent();
				villesBindingSource.ResetCurrentItem();
				villesBindingSource.EndEdit();
				villesTableAdapter.Update(dataSet1.Villes);
				dataSet1.Villes.AcceptChanges();
			}
			catch (Exception ex)
			{
				dataSet1.Villes.RejectChanges();
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
	{
		try
		{
			villesBindingSource.EndEdit();
			villesTableAdapter.Update(dataSet1.Villes);
			dataSet1.Villes.AcceptChanges();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			dataSet1.Villes.RejectChanges();
		}
	}

	private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
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
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colCP = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIBAR = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.CPTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.LIBTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.LIBARTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton21 = new DevExpress.XtraEditors.SimpleButton();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForCP = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIB = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIBAR = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.villesTableAdapter = new compta.DataSet1TableAdapters.VillesTableAdapter();
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).BeginInit();
		this.dataLayoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CPTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.LIBARTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCP).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIBAR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).BeginInit();
		base.SuspendLayout();
		this.dataLayoutControl1.Controls.Add(this.GridControl1);
		this.dataLayoutControl1.Controls.Add(this.CPTextEdit);
		this.dataLayoutControl1.Controls.Add(this.LIBTextEdit);
		this.dataLayoutControl1.Controls.Add(this.LIBARTextEdit);
		this.dataLayoutControl1.Controls.Add(this.simpleButton4);
		this.dataLayoutControl1.Controls.Add(this.simpleButton11);
		this.dataLayoutControl1.Controls.Add(this.simpleButton3);
		this.dataLayoutControl1.Controls.Add(this.simpleButton21);
		this.dataLayoutControl1.DataSource = this.villesBindingSource;
		this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
		this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
		this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(2);
		this.dataLayoutControl1.Name = "dataLayoutControl1";
		this.dataLayoutControl1.Root = this.Root;
		this.dataLayoutControl1.Size = new System.Drawing.Size(693, 412);
		this.dataLayoutControl1.TabIndex = 0;
		this.dataLayoutControl1.Text = "dataLayoutControl1";
		this.GridControl1.DataSource = this.villesBindingSource;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(12, 84);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(669, 268);
		this.GridControl1.TabIndex = 45;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.villesBindingSource.DataMember = "Villes";
		this.villesBindingSource.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colCP, this.colLIB, this.colLIBAR });
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
		this.gridView1.OptionsView.ShowFooter = true;
		this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
		this.gridView1.OptionsView.ShowGroupPanel = false;
		this.gridView1.OptionsView.ShowIndicator = false;
		this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[1]
		{
			new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCP, DevExpress.Data.ColumnSortOrder.Ascending)
		});
		this.colCP.AppearanceCell.Options.UseTextOptions = true;
		this.colCP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colCP.AppearanceHeader.Options.UseTextOptions = true;
		this.colCP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colCP.Caption = "Code Postal";
		this.colCP.FieldName = "CP";
		this.colCP.MinWidth = 15;
		this.colCP.Name = "colCP";
		this.colCP.Visible = true;
		this.colCP.VisibleIndex = 0;
		this.colCP.Width = 85;
		this.colLIB.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB.Caption = "Intitulé";
		this.colLIB.FieldName = "LIB";
		this.colLIB.MinWidth = 15;
		this.colLIB.Name = "colLIB";
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 1;
		this.colLIB.Width = 268;
		this.colLIBAR.AppearanceCell.Options.UseTextOptions = true;
		this.colLIBAR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.colLIBAR.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIBAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIBAR.Caption = "Intitulé Arabe";
		this.colLIBAR.FieldName = "LIBAR";
		this.colLIBAR.MinWidth = 15;
		this.colLIBAR.Name = "colLIBAR";
		this.colLIBAR.Visible = true;
		this.colLIBAR.VisibleIndex = 2;
		this.colLIBAR.Width = 248;
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
		this.CPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.villesBindingSource, "CP", true));
		this.CPTextEdit.EnterMoveNextControl = true;
		this.CPTextEdit.Location = new System.Drawing.Point(72, 12);
		this.CPTextEdit.Margin = new System.Windows.Forms.Padding(2);
		this.CPTextEdit.Name = "CPTextEdit";
		this.CPTextEdit.Properties.Mask.EditMask = "\\d{5}";
		this.CPTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
		this.CPTextEdit.Size = new System.Drawing.Size(272, 20);
		this.CPTextEdit.StyleController = this.dataLayoutControl1;
		this.CPTextEdit.TabIndex = 4;
		this.LIBTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.villesBindingSource, "LIB", true));
		this.LIBTextEdit.EnterMoveNextControl = true;
		this.LIBTextEdit.Location = new System.Drawing.Point(49, 36);
		this.LIBTextEdit.Margin = new System.Windows.Forms.Padding(2);
		this.LIBTextEdit.Name = "LIBTextEdit";
		this.LIBTextEdit.Size = new System.Drawing.Size(632, 20);
		this.LIBTextEdit.StyleController = this.dataLayoutControl1;
		this.LIBTextEdit.TabIndex = 5;
		this.LIBARTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.villesBindingSource, "LIBAR", true));
		this.LIBARTextEdit.EnterMoveNextControl = true;
		this.LIBARTextEdit.Location = new System.Drawing.Point(81, 60);
		this.LIBARTextEdit.Margin = new System.Windows.Forms.Padding(2);
		this.LIBARTextEdit.Name = "LIBARTextEdit";
		this.LIBARTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.LIBARTextEdit.Size = new System.Drawing.Size(600, 20);
		this.LIBARTextEdit.StyleController = this.dataLayoutControl1;
		this.LIBARTextEdit.TabIndex = 6;
		this.LIBARTextEdit.Enter += new System.EventHandler(textEdit14_Enter);
		this.LIBARTextEdit.Leave += new System.EventHandler(textEdit14_Leave);
		this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton4.Location = new System.Drawing.Point(528, 367);
		this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton4.Name = "simpleButton4";
		this.simpleButton4.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton4.Size = new System.Drawing.Size(123, 22);
		this.simpleButton4.StyleController = this.dataLayoutControl1;
		this.simpleButton4.TabIndex = 78;
		this.simpleButton4.TabStop = false;
		this.simpleButton4.Text = "Imprimer";
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(42, 367);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton11.Size = new System.Drawing.Size(122, 22);
		this.simpleButton11.StyleController = this.dataLayoutControl1;
		this.simpleButton11.TabIndex = 75;
		this.simpleButton11.TabStop = false;
		this.simpleButton11.Text = "Enregistrer";
		this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton3.Location = new System.Drawing.Point(366, 367);
		this.simpleButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton3.Name = "simpleButton3";
		this.simpleButton3.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton3.Size = new System.Drawing.Size(122, 22);
		this.simpleButton3.StyleController = this.dataLayoutControl1;
		this.simpleButton3.TabIndex = 77;
		this.simpleButton3.TabStop = false;
		this.simpleButton3.Text = "Supprimer";
		this.simpleButton21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton21.Location = new System.Drawing.Point(204, 367);
		this.simpleButton21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton21.Name = "simpleButton21";
		this.simpleButton21.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton21.Size = new System.Drawing.Size(122, 22);
		this.simpleButton21.StyleController = this.dataLayoutControl1;
		this.simpleButton21.TabIndex = 76;
		this.simpleButton21.TabStop = false;
		this.simpleButton21.Text = "Ajouter";
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.layoutControlGroup1, this.layoutControlItem1, this.layoutControlGroup5 });
		this.Root.Name = "Root";
		this.Root.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
		this.Root.Size = new System.Drawing.Size(693, 412);
		this.Root.TextVisible = false;
		this.layoutControlGroup1.AllowDrawBackground = false;
		this.layoutControlGroup1.GroupBordersVisible = false;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.ItemForCP, this.ItemForLIB, this.ItemForLIBAR, this.emptySpaceItem1 });
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup1.Name = "autoGeneratedGroup0";
		this.layoutControlGroup1.Size = new System.Drawing.Size(673, 72);
		this.ItemForCP.Control = this.CPTextEdit;
		this.ItemForCP.Location = new System.Drawing.Point(0, 0);
		this.ItemForCP.Name = "ItemForCP";
		this.ItemForCP.Size = new System.Drawing.Size(336, 24);
		this.ItemForCP.Text = "Code Postal";
		this.ItemForCP.TextSize = new System.Drawing.Size(57, 13);
		this.ItemForLIB.Control = this.LIBTextEdit;
		this.ItemForLIB.Location = new System.Drawing.Point(0, 24);
		this.ItemForLIB.Name = "ItemForLIB";
		this.ItemForLIB.Size = new System.Drawing.Size(673, 24);
		this.ItemForLIB.Text = "Intitulé";
		this.ItemForLIB.TextSize = new System.Drawing.Size(34, 13);
		this.ItemForLIBAR.Control = this.LIBARTextEdit;
		this.ItemForLIBAR.Location = new System.Drawing.Point(0, 48);
		this.ItemForLIBAR.Name = "ItemForLIBAR";
		this.ItemForLIBAR.Size = new System.Drawing.Size(673, 24);
		this.ItemForLIBAR.Text = "Intitulé Arabe";
		this.ItemForLIBAR.TextSize = new System.Drawing.Size(66, 13);
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(336, 0);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(337, 24);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(673, 272);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.layoutControlItem16, this.layoutControlItem17, this.layoutControlItem21, this.layoutControlItem22 });
		this.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup5.Location = new System.Drawing.Point(0, 344);
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
		this.layoutControlGroup5.Size = new System.Drawing.Size(673, 48);
		this.layoutControlGroup5.Text = "layoutControlGroup1";
		this.layoutControlGroup5.TextVisible = false;
		this.layoutControlItem16.Control = this.simpleButton4;
		this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem16.CustomizationFormText = "layoutControlItem10";
		this.layoutControlItem16.Location = new System.Drawing.Point(486, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 3;
		this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem16.Size = new System.Drawing.Size(163, 24);
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
		this.layoutControlItem17.Size = new System.Drawing.Size(162, 24);
		this.layoutControlItem17.Text = "layoutControlItem7";
		this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem17.TextVisible = false;
		this.layoutControlItem21.Control = this.simpleButton3;
		this.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem21.CustomizationFormText = "layoutControlItem9";
		this.layoutControlItem21.Location = new System.Drawing.Point(324, 0);
		this.layoutControlItem21.Name = "layoutControlItem21";
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem21.OptionsTableLayoutItem.ColumnIndex = 2;
		this.layoutControlItem21.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem21.Size = new System.Drawing.Size(162, 24);
		this.layoutControlItem21.Text = "layoutControlItem9";
		this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem21.TextVisible = false;
		this.layoutControlItem22.Control = this.simpleButton21;
		this.layoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem22.CustomizationFormText = "layoutControlItem8";
		this.layoutControlItem22.Location = new System.Drawing.Point(162, 0);
		this.layoutControlItem22.Name = "layoutControlItem22";
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem22.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem22.Size = new System.Drawing.Size(162, 24);
		this.layoutControlItem22.Text = "layoutControlItem8";
		this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem22.TextVisible = false;
		this.villesTableAdapter.ClearBeforeFill = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(693, 428);
		base.Controls.Add(this.dataLayoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmVilles";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Villes";
		base.Load += new System.EventHandler(frmVilles_Load);
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).EndInit();
		this.dataLayoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.villesBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CPTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.LIBARTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCP).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIBAR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).EndInit();
		base.ResumeLayout(false);
	}
}
