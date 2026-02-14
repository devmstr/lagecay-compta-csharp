using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using compta.DataSet1TableAdapters;
using compta.Properties;
using DevExpress.Utils;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace compta;

public class frmPieces : XtraForm
{
	private static DateTime adat;

	private static DateTime ndat;

	private IContainer components;

	private DataLayoutControl dataLayoutControl1;

	private LayoutControlGroup Root;

	private DataSet1 dataSet1;

	private BindingSource bindingSource1;

	private PiecesTableAdapter piecesTableAdapter;

	private TextEdit UNITextEdit;

	private TextEdit ExerciceTextEdit;

	private DateEdit DatDateEdit;

	private TextEdit MoisTextEdit;

	private TextEdit LIBTextEdit;

	private TextEdit IDTextEdit;

	private LookUpEdit JATextEdit;

	private LayoutControlItem ItemForUNI;

	private LayoutControlItem ItemForExercice;

	private LayoutControlGroup layoutControlGroup1;

	private LayoutControlItem ItemForJA;

	private LayoutControlItem ItemForNOP;

	private LayoutControlItem ItemForDat;

	private LayoutControlItem ItemForMois;

	private LayoutControlItem ItemForLIB;

	private LayoutControlItem ItemForID;

	private BindingSource journauxBindingSource;

	private JournauxTableAdapter journauxTableAdapter;

	internal GridControl GridControl1;

	internal GridView gridView1;

	private GridColumn colUNI;

	private GridColumn colLIB;

	internal GridView GridView3;

	private LayoutControlItem layoutControlItem1;

	private GridColumn gridColumn1;

	private SimpleButton simpleButton4;

	private SimpleButton simpleButton11;

	private SimpleButton simpleButton3;

	private SimpleButton simpleButton21;

	private LayoutControlGroup layoutControlGroup5;

	private LayoutControlItem layoutControlItem16;

	private LayoutControlItem layoutControlItem17;

	private LayoutControlItem layoutControlItem21;

	private LayoutControlItem layoutControlItem22;

	private SpinEdit NOPTextEdit;

	private GridColumn colJA;

	private RepositoryItemLookUpEdit repositoryItemLookUpEdit1;

	private GridColumn colID;

	public frmPieces()
	{
		InitializeComponent();
	}

	private static void Column_Changed(object sender, DataColumnChangeEventArgs e)
	{
		ndat = Convert.ToDateTime(e.Row["Dat"]);
		adat = Convert.ToDateTime(e.Row["Dat", DataRowVersion.Original]);
	}

	private void frmPieces_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		journauxTableAdapter.Connection.ConnectionString = connection;
		journauxTableAdapter.Fill(dataSet1.Journaux);
		piecesTableAdapter.Connection.ConnectionString = connection;
		piecesTableAdapter.FillBy(dataSet1.Pieces, monModule.gUNI, Convert.ToInt32(monModule.gExercice));
		dataSet1.Pieces.ColumnChanged += Column_Changed;
	}

	private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
	{
		try
		{
			bindingSource1.EndEdit();
			piecesTableAdapter.Update(dataSet1.Pieces);
			dataSet1.Pieces.AcceptChanges();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			dataSet1.Pieces.RejectChanges();
		}
	}

	private void GridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
	{
		ndat = adat;
		dataSet1.Pieces.RejectChanges();
	}

	private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOP");
		monModule.gNOP = ((t == null) ? "" : t.ToString());
	}

	private void GridControl1_KeyDown(object sender, KeyEventArgs e)
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

	private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Attention !!\nLa suppression de cette Pièce  effacera toutes les écritures qu'elle contient.\nSouhaitez-vous continuer ?", "Confirmation de la suppression d'une Pièce", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes && gridView1.RowCount > 0)
		{
			int ID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"));
			string connectionString = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
			bindingSource1.EndEdit();
			OleDbCommand cmd = new OleDbCommand();
			OleDbTransaction transaction = null;
			cmd.CommandType = CommandType.Text;
			using (OleDbConnection gbase = new OleDbConnection(connectionString))
			{
				gbase.Open();
				transaction = gbase.BeginTransaction();
				cmd.Connection = gbase;
				cmd.Transaction = transaction;
				cmd.CommandText = $"Delete * from Pieces where ID={ID}";
				cmd.ExecuteNonQuery();
				transaction.Commit();
			}
			piecesTableAdapter.FillBy(dataSet1.Pieces, monModule.gUNI, Convert.ToInt32(monModule.gExercice));
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
		DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
		this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colJA = new DevExpress.XtraGrid.Columns.GridColumn();
		this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
		this.journauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.UNITextEdit = new DevExpress.XtraEditors.TextEdit();
		this.ExerciceTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.DatDateEdit = new DevExpress.XtraEditors.DateEdit();
		this.MoisTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.LIBTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.JATextEdit = new DevExpress.XtraEditors.LookUpEdit();
		this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton21 = new DevExpress.XtraEditors.SimpleButton();
		this.NOPTextEdit = new DevExpress.XtraEditors.SpinEdit();
		this.ItemForUNI = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForExercice = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForMois = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForLIB = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForNOP = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForDat = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForJA = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.piecesTableAdapter = new compta.DataSet1TableAdapters.PiecesTableAdapter();
		this.journauxTableAdapter = new compta.DataSet1TableAdapters.JournauxTableAdapter();
		this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).BeginInit();
		this.dataLayoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemLookUpEdit1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ExerciceTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DatDateEdit.Properties.CalendarTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.DatDateEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.MoisTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.JATextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.NOPTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForExercice).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForMois).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNOP).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForDat).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForJA).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).BeginInit();
		base.SuspendLayout();
		this.dataLayoutControl1.Controls.Add(this.GridControl1);
		this.dataLayoutControl1.Controls.Add(this.UNITextEdit);
		this.dataLayoutControl1.Controls.Add(this.ExerciceTextEdit);
		this.dataLayoutControl1.Controls.Add(this.DatDateEdit);
		this.dataLayoutControl1.Controls.Add(this.MoisTextEdit);
		this.dataLayoutControl1.Controls.Add(this.LIBTextEdit);
		this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
		this.dataLayoutControl1.Controls.Add(this.JATextEdit);
		this.dataLayoutControl1.Controls.Add(this.simpleButton4);
		this.dataLayoutControl1.Controls.Add(this.simpleButton11);
		this.dataLayoutControl1.Controls.Add(this.simpleButton3);
		this.dataLayoutControl1.Controls.Add(this.simpleButton21);
		this.dataLayoutControl1.Controls.Add(this.NOPTextEdit);
		this.dataLayoutControl1.DataSource = this.bindingSource1;
		this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.ItemForUNI, this.ItemForExercice, this.ItemForMois, this.ItemForID });
		this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
		this.dataLayoutControl1.Name = "dataLayoutControl1";
		this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(794, 321, 650, 400);
		this.dataLayoutControl1.Root = this.Root;
		this.dataLayoutControl1.Size = new System.Drawing.Size(703, 416);
		this.dataLayoutControl1.TabIndex = 0;
		this.dataLayoutControl1.Text = "dataLayoutControl1";
		this.GridControl1.DataSource = this.bindingSource1;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(12, 60);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[1] { this.repositoryItemLookUpEdit1 });
		this.GridControl1.Size = new System.Drawing.Size(679, 320);
		this.GridControl1.TabIndex = 24;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.GridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(GridControl1_KeyDown);
		this.bindingSource1.DataMember = "Pieces";
		this.bindingSource1.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[5] { this.colUNI, this.colLIB, this.gridColumn1, this.colJA, this.colID });
		this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(319, -670, 498, 610);
		this.gridView1.DetailHeight = 801;
		this.gridView1.FixedLineWidth = 1;
		this.gridView1.GridControl = this.GridControl1;
		this.gridView1.Name = "gridView1";
		this.gridView1.OptionsBehavior.Editable = false;
		this.gridView1.OptionsBehavior.ReadOnly = true;
		this.gridView1.OptionsCustomization.AllowGroup = false;
		this.gridView1.OptionsDetail.ShowDetailTabs = false;
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
		this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(GridView1_FocusedRowObjectChanged);
		this.colUNI.AppearanceCell.Options.UseTextOptions = true;
		this.colUNI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.AppearanceHeader.Options.UseTextOptions = true;
		this.colUNI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.Caption = "N° Pièce";
		this.colUNI.FieldName = "NOP";
		this.colUNI.Name = "colUNI";
		this.colUNI.OptionsColumn.AllowEdit = false;
		this.colUNI.OptionsColumn.AllowFocus = false;
		this.colUNI.Visible = true;
		this.colUNI.VisibleIndex = 0;
		this.colUNI.Width = 63;
		this.colLIB.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB.Caption = "Intitulé";
		this.colLIB.FieldName = "LIB";
		this.colLIB.Name = "colLIB";
		this.colLIB.OptionsColumn.AllowEdit = false;
		this.colLIB.OptionsColumn.AllowFocus = false;
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 1;
		this.colLIB.Width = 256;
		this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn1.Caption = "CJournal";
		this.gridColumn1.FieldName = "JA";
		this.gridColumn1.FieldNameSortGroup = "JA";
		this.gridColumn1.Name = "gridColumn1";
		this.gridColumn1.OptionsColumn.AllowEdit = false;
		this.gridColumn1.OptionsColumn.AllowFocus = false;
		this.gridColumn1.Visible = true;
		this.gridColumn1.VisibleIndex = 2;
		this.gridColumn1.Width = 36;
		this.colJA.AppearanceHeader.Options.UseTextOptions = true;
		this.colJA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colJA.Caption = "Intitulé";
		this.colJA.ColumnEdit = this.repositoryItemLookUpEdit1;
		this.colJA.FieldName = "JA";
		this.colJA.Name = "colJA";
		this.colJA.OptionsColumn.AllowEdit = false;
		this.colJA.OptionsColumn.AllowFocus = false;
		this.colJA.Visible = true;
		this.colJA.VisibleIndex = 3;
		this.colJA.Width = 300;
		this.repositoryItemLookUpEdit1.AutoHeight = false;
		this.repositoryItemLookUpEdit1.DataSource = this.journauxBindingSource;
		this.repositoryItemLookUpEdit1.DisplayMember = "LIB";
		this.repositoryItemLookUpEdit1.KeyMember = "JA";
		this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
		this.repositoryItemLookUpEdit1.ValueMember = "JA";
		this.journauxBindingSource.DataMember = "Journaux";
		this.journauxBindingSource.DataSource = this.dataSet1;
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
		this.UNITextEdit.Location = new System.Drawing.Point(49, 6);
		this.UNITextEdit.Name = "UNITextEdit";
		this.UNITextEdit.Size = new System.Drawing.Size(689, 20);
		this.UNITextEdit.StyleController = this.dataLayoutControl1;
		this.UNITextEdit.TabIndex = 4;
		this.ExerciceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Exercice", true));
		this.ExerciceTextEdit.Location = new System.Drawing.Point(49, 6);
		this.ExerciceTextEdit.Name = "ExerciceTextEdit";
		this.ExerciceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.ExerciceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.ExerciceTextEdit.Properties.Mask.EditMask = "N0";
		this.ExerciceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.ExerciceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.ExerciceTextEdit.Size = new System.Drawing.Size(689, 20);
		this.ExerciceTextEdit.StyleController = this.dataLayoutControl1;
		this.ExerciceTextEdit.TabIndex = 5;
		this.DatDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Dat", true));
		this.DatDateEdit.EditValue = null;
		this.DatDateEdit.EnterMoveNextControl = true;
		this.DatDateEdit.Location = new System.Drawing.Point(161, 12);
		this.DatDateEdit.Name = "DatDateEdit";
		this.DatDateEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.DatDateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.DatDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.DatDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.DatDateEdit.Size = new System.Drawing.Size(138, 20);
		this.DatDateEdit.StyleController = this.dataLayoutControl1;
		this.DatDateEdit.TabIndex = 8;
		this.MoisTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Mois", true));
		this.MoisTextEdit.Location = new System.Drawing.Point(30, 50);
		this.MoisTextEdit.Name = "MoisTextEdit";
		this.MoisTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.MoisTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.MoisTextEdit.Properties.Mask.EditMask = "N0";
		this.MoisTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.MoisTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.MoisTextEdit.Size = new System.Drawing.Size(708, 20);
		this.MoisTextEdit.StyleController = this.dataLayoutControl1;
		this.MoisTextEdit.TabIndex = 9;
		this.LIBTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIB", true));
		this.LIBTextEdit.EnterMoveNextControl = true;
		this.LIBTextEdit.Location = new System.Drawing.Point(49, 36);
		this.LIBTextEdit.Name = "LIBTextEdit";
		this.LIBTextEdit.Size = new System.Drawing.Size(642, 20);
		this.LIBTextEdit.StyleController = this.dataLayoutControl1;
		this.LIBTextEdit.TabIndex = 10;
		this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ID", true));
		this.IDTextEdit.Location = new System.Drawing.Point(30, 50);
		this.IDTextEdit.Name = "IDTextEdit";
		this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.IDTextEdit.Properties.Mask.EditMask = "N0";
		this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.IDTextEdit.Size = new System.Drawing.Size(708, 20);
		this.IDTextEdit.StyleController = this.dataLayoutControl1;
		this.IDTextEdit.TabIndex = 11;
		this.JATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "JA", true));
		this.JATextEdit.Enabled = false;
		this.JATextEdit.EnterMoveNextControl = true;
		this.JATextEdit.Location = new System.Drawing.Point(341, 12);
		this.JATextEdit.Name = "JATextEdit";
		this.JATextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.JATextEdit.Properties.DataSource = this.journauxBindingSource;
		this.JATextEdit.Properties.DisplayMember = "LIB";
		this.JATextEdit.Properties.NullText = "";
		this.JATextEdit.Properties.ValueMember = "JA";
		this.JATextEdit.Size = new System.Drawing.Size(350, 20);
		this.JATextEdit.StyleController = this.dataLayoutControl1;
		this.JATextEdit.TabIndex = 6;
		this.simpleButton4.ImageOptions.Image = compta.Properties.Resources.print_16x16;
		this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton4.Location = new System.Drawing.Point(542, 383);
		this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton4.Name = "simpleButton4";
		this.simpleButton4.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton4.Size = new System.Drawing.Size(131, 22);
		this.simpleButton4.StyleController = this.dataLayoutControl1;
		this.simpleButton4.TabIndex = 78;
		this.simpleButton4.TabStop = false;
		this.simpleButton4.Text = "Imprimer";
		this.simpleButton11.ImageOptions.Image = compta.Properties.Resources.save_16x16;
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(30, 383);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton11.Size = new System.Drawing.Size(130, 22);
		this.simpleButton11.StyleController = this.dataLayoutControl1;
		this.simpleButton11.TabIndex = 75;
		this.simpleButton11.TabStop = false;
		this.simpleButton11.Text = "Enregistrer";
		this.simpleButton11.Click += new System.EventHandler(bindingNavigatorSaveItem_Click);
		this.simpleButton3.ImageOptions.Image = compta.Properties.Resources.delete_16x16;
		this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton3.Location = new System.Drawing.Point(371, 383);
		this.simpleButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton3.Name = "simpleButton3";
		this.simpleButton3.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton3.Size = new System.Drawing.Size(131, 22);
		this.simpleButton3.StyleController = this.dataLayoutControl1;
		this.simpleButton3.TabIndex = 77;
		this.simpleButton3.TabStop = false;
		this.simpleButton3.Text = "Supprimer";
		this.simpleButton3.Click += new System.EventHandler(bindingNavigatorDeleteItem_Click);
		this.simpleButton21.ImageOptions.Image = compta.Properties.Resources.add_16x16;
		this.simpleButton21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton21.Location = new System.Drawing.Point(200, 383);
		this.simpleButton21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton21.Name = "simpleButton21";
		this.simpleButton21.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton21.Size = new System.Drawing.Size(131, 22);
		this.simpleButton21.StyleController = this.dataLayoutControl1;
		this.simpleButton21.TabIndex = 76;
		this.simpleButton21.TabStop = false;
		this.simpleButton21.Text = "Ajouter";
		this.NOPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "NOP", true));
		this.NOPTextEdit.EditValue = new decimal(new int[4]);
		this.NOPTextEdit.Location = new System.Drawing.Point(55, 12);
		this.NOPTextEdit.Name = "NOPTextEdit";
		this.NOPTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.NOPTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.NOPTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
		this.NOPTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
		this.NOPTextEdit.Size = new System.Drawing.Size(76, 20);
		this.NOPTextEdit.StyleController = this.dataLayoutControl1;
		this.NOPTextEdit.TabIndex = 7;
		this.ItemForUNI.Control = this.UNITextEdit;
		this.ItemForUNI.Location = new System.Drawing.Point(0, 0);
		this.ItemForUNI.Name = "ItemForUNI";
		this.ItemForUNI.Size = new System.Drawing.Size(734, 22);
		this.ItemForUNI.Text = "UNI";
		this.ItemForUNI.TextSize = new System.Drawing.Size(40, 20);
		this.ItemForExercice.Control = this.ExerciceTextEdit;
		this.ItemForExercice.Location = new System.Drawing.Point(0, 0);
		this.ItemForExercice.Name = "ItemForExercice";
		this.ItemForExercice.Size = new System.Drawing.Size(734, 22);
		this.ItemForExercice.Text = "Exercice";
		this.ItemForExercice.TextSize = new System.Drawing.Size(40, 13);
		this.ItemForMois.Control = this.MoisTextEdit;
		this.ItemForMois.Location = new System.Drawing.Point(0, 44);
		this.ItemForMois.Name = "ItemForMois";
		this.ItemForMois.Size = new System.Drawing.Size(734, 22);
		this.ItemForMois.Text = "Mois";
		this.ItemForMois.TextSize = new System.Drawing.Size(40, 13);
		this.ItemForID.Control = this.IDTextEdit;
		this.ItemForID.Location = new System.Drawing.Point(0, 44);
		this.ItemForID.Name = "ItemForID";
		this.ItemForID.Size = new System.Drawing.Size(734, 541);
		this.ItemForID.Text = "ID";
		this.ItemForID.TextSize = new System.Drawing.Size(40, 13);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup1, this.layoutControlGroup5 });
		this.Root.Name = "Root";
		this.Root.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
		this.Root.Size = new System.Drawing.Size(703, 416);
		this.Root.TextVisible = false;
		this.layoutControlGroup1.AllowDrawBackground = false;
		this.layoutControlGroup1.GroupBordersVisible = false;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[5] { this.ItemForLIB, this.ItemForNOP, this.ItemForDat, this.ItemForJA, this.layoutControlItem1 });
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup1.Name = "autoGeneratedGroup0";
		this.layoutControlGroup1.Size = new System.Drawing.Size(683, 372);
		this.ItemForLIB.Control = this.LIBTextEdit;
		this.ItemForLIB.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForLIB.Location = new System.Drawing.Point(0, 24);
		this.ItemForLIB.Name = "ItemForLIB";
		this.ItemForLIB.Size = new System.Drawing.Size(683, 24);
		this.ItemForLIB.Text = "Intitulé";
		this.ItemForLIB.TextSize = new System.Drawing.Size(34, 13);
		this.ItemForNOP.Control = this.NOPTextEdit;
		this.ItemForNOP.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForNOP.Location = new System.Drawing.Point(0, 0);
		this.ItemForNOP.Name = "ItemForNOP";
		this.ItemForNOP.Size = new System.Drawing.Size(123, 24);
		this.ItemForNOP.Text = "N° Pièce";
		this.ItemForNOP.TextSize = new System.Drawing.Size(40, 13);
		this.ItemForDat.Control = this.DatDateEdit;
		this.ItemForDat.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForDat.Location = new System.Drawing.Point(123, 0);
		this.ItemForDat.Name = "ItemForDat";
		this.ItemForDat.Size = new System.Drawing.Size(168, 24);
		this.ItemForDat.Text = "Date";
		this.ItemForDat.TextSize = new System.Drawing.Size(23, 13);
		this.ItemForJA.Control = this.JATextEdit;
		this.ItemForJA.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForJA.Location = new System.Drawing.Point(291, 0);
		this.ItemForJA.Name = "ItemForJA";
		this.ItemForJA.Size = new System.Drawing.Size(392, 24);
		this.ItemForJA.Text = "Journal";
		this.ItemForJA.TextSize = new System.Drawing.Size(35, 13);
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(683, 324);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup5.GroupBordersVisible = false;
		this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.layoutControlItem16, this.layoutControlItem17, this.layoutControlItem21, this.layoutControlItem22 });
		this.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup5.Location = new System.Drawing.Point(0, 372);
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
		this.layoutControlGroup5.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 7, 6, 6);
		this.layoutControlGroup5.Size = new System.Drawing.Size(683, 24);
		this.layoutControlGroup5.Text = "layoutControlGroup1";
		this.layoutControlGroup5.TextVisible = false;
		this.layoutControlItem16.Control = this.simpleButton4;
		this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem16.CustomizationFormText = "layoutControlItem10";
		this.layoutControlItem16.Location = new System.Drawing.Point(512, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 3;
		this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem16.Size = new System.Drawing.Size(171, 24);
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
		this.layoutControlItem17.Size = new System.Drawing.Size(170, 24);
		this.layoutControlItem17.Text = "layoutControlItem7";
		this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem17.TextVisible = false;
		this.layoutControlItem21.Control = this.simpleButton3;
		this.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem21.CustomizationFormText = "layoutControlItem9";
		this.layoutControlItem21.Location = new System.Drawing.Point(341, 0);
		this.layoutControlItem21.Name = "layoutControlItem21";
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem21.OptionsTableLayoutItem.ColumnIndex = 2;
		this.layoutControlItem21.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem21.Size = new System.Drawing.Size(171, 24);
		this.layoutControlItem21.Text = "layoutControlItem9";
		this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem21.TextVisible = false;
		this.layoutControlItem22.Control = this.simpleButton21;
		this.layoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem22.CustomizationFormText = "layoutControlItem8";
		this.layoutControlItem22.Location = new System.Drawing.Point(170, 0);
		this.layoutControlItem22.Name = "layoutControlItem22";
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem22.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem22.Size = new System.Drawing.Size(171, 24);
		this.layoutControlItem22.Text = "layoutControlItem8";
		this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem22.TextVisible = false;
		this.piecesTableAdapter.ClearBeforeFill = true;
		this.journauxTableAdapter.ClearBeforeFill = true;
		this.colID.FieldName = "ID";
		this.colID.Name = "colID";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(703, 416);
		base.Controls.Add(this.dataLayoutControl1);
		base.IconOptions.Image = compta.Properties.Resources.engineering_32x32;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmPieces";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Pieces";
		base.Load += new System.EventHandler(frmPieces_Load);
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).EndInit();
		this.dataLayoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.repositoryItemLookUpEdit1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ExerciceTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DatDateEdit.Properties.CalendarTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.DatDateEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.MoisTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.LIBTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.JATextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.NOPTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForExercice).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForMois).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForNOP).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForDat).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForJA).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).EndInit();
		base.ResumeLayout(false);
	}
}
