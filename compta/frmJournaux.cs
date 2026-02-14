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

public class frmJournaux : XtraForm
{
	private InputLanguage originalInputLang;

	private IContainer components;

	private DataLayoutControl dataLayoutControl1;

	private LayoutControlGroup Root;

	private DataSet1 dataSet1;

	private BindingSource bindingSource1;

	private JournauxTableAdapter journauxTableAdapter;

	private TextEdit JATextEdit;

	private TextEdit LIBTextEdit;

	private TextEdit IDTextEdit;

	private LayoutControlGroup layoutControlGroup1;

	private LayoutControlItem ItemForJA;

	private LayoutControlItem ItemForLIB;

	private LayoutControlItem ItemForID;

	internal GridControl GridControl1;

	internal GridView gridView1;

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

	private TextEdit LIBTextEdit1;

	private LayoutControlItem ItemForLIB1;

	private GridColumn colJA;

	private GridColumn colLIB;

	private GridColumn colLIB1;

	public frmJournaux()
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

	private void frmJournaux_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		journauxTableAdapter.Connection.ConnectionString = connection;
		journauxTableAdapter.Fill(dataSet1.Journaux);
	}

	private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
	{
		string maxVal = dataSet1.Journaux.Compute("max([JA])", string.Empty).ToString();
		((DataRowView)bindingSource1.AddNew())["JA"] = monModule.Suivant(maxVal);
		bindingSource1.EndEdit();
		journauxTableAdapter.Update(dataSet1.Journaux);
		dataSet1.Journaux.AcceptChanges();
		Rafraichir();
	}

	private void Rafraichir()
	{
		if (dataSet1.Journaux != null)
		{
			int pos = bindingSource1.Position;
			dataSet1.Journaux.Clear();
			journauxTableAdapter.Fill(dataSet1.Journaux);
			bindingSource1.Position = pos;
		}
	}

	private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("هل تريد فعلا حدف المعلومات", "أكد الحدف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
		{
			try
			{
				bindingSource1.RemoveCurrent();
				bindingSource1.ResetCurrentItem();
				bindingSource1.EndEdit();
				journauxTableAdapter.Update(dataSet1.Journaux);
				dataSet1.Journaux.AcceptChanges();
			}
			catch (Exception ex)
			{
				dataSet1.Journaux.RejectChanges();
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
	{
		try
		{
			bindingSource1.EndEdit();
			journauxTableAdapter.Update(dataSet1.Journaux);
			dataSet1.Journaux.AcceptChanges();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			dataSet1.Journaux.RejectChanges();
		}
	}

	private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JA");
		monModule.gJA = ((t == null) ? "" : t.ToString());
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
		this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colJA = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.JATextEdit = new DevExpress.XtraEditors.TextEdit();
		this.LIBTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton21 = new DevExpress.XtraEditors.SimpleButton();
		this.LIBTextEdit1 = new DevExpress.XtraEditors.TextEdit();
		this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForJA = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIB = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIB1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.journauxTableAdapter = new compta.DataSet1TableAdapters.JournauxTableAdapter();
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).BeginInit();
		this.dataLayoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.JATextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForJA).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).BeginInit();
		base.SuspendLayout();
		this.dataLayoutControl1.Controls.Add(this.GridControl1);
		this.dataLayoutControl1.Controls.Add(this.JATextEdit);
		this.dataLayoutControl1.Controls.Add(this.LIBTextEdit);
		this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
		this.dataLayoutControl1.Controls.Add(this.simpleButton4);
		this.dataLayoutControl1.Controls.Add(this.simpleButton11);
		this.dataLayoutControl1.Controls.Add(this.simpleButton3);
		this.dataLayoutControl1.Controls.Add(this.simpleButton21);
		this.dataLayoutControl1.Controls.Add(this.LIBTextEdit1);
		this.dataLayoutControl1.DataSource = this.bindingSource1;
		this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.ItemForID });
		this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
		this.dataLayoutControl1.Name = "dataLayoutControl1";
		this.dataLayoutControl1.Root = this.Root;
		this.dataLayoutControl1.Size = new System.Drawing.Size(684, 429);
		this.dataLayoutControl1.TabIndex = 0;
		this.dataLayoutControl1.Text = "dataLayoutControl1";
		this.GridControl1.DataSource = this.bindingSource1;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(12, 84);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(660, 285);
		this.GridControl1.TabIndex = 44;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.bindingSource1.DataMember = "Journaux";
		this.bindingSource1.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colJA, this.colLIB, this.colLIB1 });
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
		this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView1_FocusedRowChanged);
		this.colJA.AppearanceCell.Options.UseTextOptions = true;
		this.colJA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colJA.AppearanceHeader.Options.UseTextOptions = true;
		this.colJA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colJA.Caption = "Code";
		this.colJA.FieldName = "JA";
		this.colJA.MinWidth = 15;
		this.colJA.Name = "colJA";
		this.colJA.Visible = true;
		this.colJA.VisibleIndex = 0;
		this.colJA.Width = 56;
		this.colLIB.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB.Caption = "Intitulé";
		this.colLIB.FieldName = "LIB";
		this.colLIB.MinWidth = 15;
		this.colLIB.Name = "colLIB";
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 1;
		this.colLIB.Width = 264;
		this.colLIB1.AppearanceCell.Options.UseTextOptions = true;
		this.colLIB1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.colLIB1.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB1.Caption = "Intitulé en Arabe";
		this.colLIB1.FieldName = "LIBAR";
		this.colLIB1.MinWidth = 15;
		this.colLIB1.Name = "colLIB1";
		this.colLIB1.Visible = true;
		this.colLIB1.VisibleIndex = 2;
		this.colLIB1.Width = 310;
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
		this.JATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "JA", true));
		this.JATextEdit.EnterMoveNextControl = true;
		this.JATextEdit.Location = new System.Drawing.Point(50, 12);
		this.JATextEdit.Name = "JATextEdit";
		this.JATextEdit.Size = new System.Drawing.Size(622, 20);
		this.JATextEdit.StyleController = this.dataLayoutControl1;
		this.JATextEdit.TabIndex = 4;
		this.LIBTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIB", true));
		this.LIBTextEdit.EnterMoveNextControl = true;
		this.LIBTextEdit.Location = new System.Drawing.Point(49, 36);
		this.LIBTextEdit.Name = "LIBTextEdit";
		this.LIBTextEdit.Size = new System.Drawing.Size(623, 20);
		this.LIBTextEdit.StyleController = this.dataLayoutControl1;
		this.LIBTextEdit.TabIndex = 5;
		this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ID", true));
		this.IDTextEdit.Location = new System.Drawing.Point(24, 6);
		this.IDTextEdit.Name = "IDTextEdit";
		this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.IDTextEdit.Properties.Mask.EditMask = "N0";
		this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.IDTextEdit.Size = new System.Drawing.Size(680, 20);
		this.IDTextEdit.StyleController = this.dataLayoutControl1;
		this.IDTextEdit.TabIndex = 6;
		this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton4.Location = new System.Drawing.Point(522, 384);
		this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton4.Name = "simpleButton4";
		this.simpleButton4.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton4.Size = new System.Drawing.Size(120, 22);
		this.simpleButton4.StyleController = this.dataLayoutControl1;
		this.simpleButton4.TabIndex = 78;
		this.simpleButton4.TabStop = false;
		this.simpleButton4.Text = "Imprimer";
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(42, 384);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton11.Size = new System.Drawing.Size(120, 22);
		this.simpleButton11.StyleController = this.dataLayoutControl1;
		this.simpleButton11.TabIndex = 75;
		this.simpleButton11.TabStop = false;
		this.simpleButton11.Text = "Enregistrer";
		this.simpleButton11.Click += new System.EventHandler(bindingNavigatorSaveItem_Click);
		this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton3.Location = new System.Drawing.Point(362, 384);
		this.simpleButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton3.Name = "simpleButton3";
		this.simpleButton3.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton3.Size = new System.Drawing.Size(120, 22);
		this.simpleButton3.StyleController = this.dataLayoutControl1;
		this.simpleButton3.TabIndex = 77;
		this.simpleButton3.TabStop = false;
		this.simpleButton3.Text = "Supprimer";
		this.simpleButton3.Click += new System.EventHandler(bindingNavigatorDeleteItem_Click);
		this.simpleButton21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton21.Location = new System.Drawing.Point(202, 384);
		this.simpleButton21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton21.Name = "simpleButton21";
		this.simpleButton21.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton21.Size = new System.Drawing.Size(120, 22);
		this.simpleButton21.StyleController = this.dataLayoutControl1;
		this.simpleButton21.TabIndex = 76;
		this.simpleButton21.TabStop = false;
		this.simpleButton21.Text = "Ajouter";
		this.simpleButton21.Click += new System.EventHandler(bindingNavigatorAddNewItem_Click);
		this.LIBTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIBAR", true));
		this.LIBTextEdit1.EnterMoveNextControl = true;
		this.LIBTextEdit1.Location = new System.Drawing.Point(81, 60);
		this.LIBTextEdit1.Name = "LIBTextEdit1";
		this.LIBTextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.LIBTextEdit1.Size = new System.Drawing.Size(591, 20);
		this.LIBTextEdit1.StyleController = this.dataLayoutControl1;
		this.LIBTextEdit1.TabIndex = 5;
		this.LIBTextEdit1.Enter += new System.EventHandler(textEdit14_Enter);
		this.LIBTextEdit1.Leave += new System.EventHandler(textEdit14_Leave);
		this.ItemForID.Control = this.IDTextEdit;
		this.ItemForID.Location = new System.Drawing.Point(0, 0);
		this.ItemForID.Name = "ItemForID";
		this.ItemForID.Size = new System.Drawing.Size(700, 22);
		this.ItemForID.Text = "ID";
		this.ItemForID.TextSize = new System.Drawing.Size(50, 20);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup1, this.layoutControlGroup5 });
		this.Root.Name = "Root";
		this.Root.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
		this.Root.Size = new System.Drawing.Size(684, 429);
		this.Root.TextVisible = false;
		this.layoutControlGroup1.AllowDrawBackground = false;
		this.layoutControlGroup1.GroupBordersVisible = false;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.ItemForJA, this.ItemForLIB, this.layoutControlItem1, this.ItemForLIB1 });
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup1.Name = "autoGeneratedGroup0";
		this.layoutControlGroup1.Size = new System.Drawing.Size(664, 361);
		this.ItemForJA.Control = this.JATextEdit;
		this.ItemForJA.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForJA.Location = new System.Drawing.Point(0, 0);
		this.ItemForJA.Name = "ItemForJA";
		this.ItemForJA.Size = new System.Drawing.Size(664, 24);
		this.ItemForJA.Text = "Journal";
		this.ItemForJA.TextSize = new System.Drawing.Size(35, 13);
		this.ItemForLIB.Control = this.LIBTextEdit;
		this.ItemForLIB.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForLIB.Location = new System.Drawing.Point(0, 24);
		this.ItemForLIB.Name = "ItemForLIB";
		this.ItemForLIB.Size = new System.Drawing.Size(664, 24);
		this.ItemForLIB.Text = "Intitulé";
		this.ItemForLIB.TextSize = new System.Drawing.Size(34, 13);
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(664, 289);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.ItemForLIB1.Control = this.LIBTextEdit1;
		this.ItemForLIB1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForLIB1.CustomizationFormText = "Intitulé";
		this.ItemForLIB1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForLIB1.Location = new System.Drawing.Point(0, 48);
		this.ItemForLIB1.Name = "ItemForLIB1";
		this.ItemForLIB1.Size = new System.Drawing.Size(664, 24);
		this.ItemForLIB1.Text = "Intitulé Arabe";
		this.ItemForLIB1.TextSize = new System.Drawing.Size(66, 13);
		this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.layoutControlItem16, this.layoutControlItem17, this.layoutControlItem21, this.layoutControlItem22 });
		this.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup5.Location = new System.Drawing.Point(0, 361);
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
		this.layoutControlGroup5.Size = new System.Drawing.Size(664, 48);
		this.layoutControlGroup5.Text = "layoutControlGroup1";
		this.layoutControlGroup5.TextVisible = false;
		this.layoutControlItem16.Control = this.simpleButton4;
		this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem16.CustomizationFormText = "layoutControlItem10";
		this.layoutControlItem16.Location = new System.Drawing.Point(480, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 3;
		this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem16.Size = new System.Drawing.Size(160, 24);
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
		this.layoutControlItem17.Size = new System.Drawing.Size(160, 24);
		this.layoutControlItem17.Text = "layoutControlItem7";
		this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem17.TextVisible = false;
		this.layoutControlItem21.Control = this.simpleButton3;
		this.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem21.CustomizationFormText = "layoutControlItem9";
		this.layoutControlItem21.Location = new System.Drawing.Point(320, 0);
		this.layoutControlItem21.Name = "layoutControlItem21";
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem21.OptionsTableLayoutItem.ColumnIndex = 2;
		this.layoutControlItem21.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem21.Size = new System.Drawing.Size(160, 24);
		this.layoutControlItem21.Text = "layoutControlItem9";
		this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem21.TextVisible = false;
		this.layoutControlItem22.Control = this.simpleButton21;
		this.layoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem22.CustomizationFormText = "layoutControlItem8";
		this.layoutControlItem22.Location = new System.Drawing.Point(160, 0);
		this.layoutControlItem22.Name = "layoutControlItem22";
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem22.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem22.Size = new System.Drawing.Size(160, 24);
		this.layoutControlItem22.Text = "layoutControlItem8";
		this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem22.TextVisible = false;
		this.journauxTableAdapter.ClearBeforeFill = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(684, 429);
		base.Controls.Add(this.dataLayoutControl1);
		base.IconOptions.Image = compta.Properties.Resources.notes_32x32;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmJournaux";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Journaux";
		base.Load += new System.EventHandler(frmJournaux_Load);
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).EndInit();
		this.dataLayoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.JATextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForJA).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).EndInit();
		base.ResumeLayout(false);
	}
}
