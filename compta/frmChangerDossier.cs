using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using compta.Properties;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace compta;

public class frmChangerDossier : XtraForm
{
	private IContainer components;

	private LayoutControl layoutControl1;

	internal GridControl GridControl1;

	internal GridView gridView1;

	internal GridColumn colcode;

	private GridColumn gridColumn1;

	private GridColumn gridColumn2;

	internal GridView GridView3;

	internal GridColumn GridColumn7;

	internal GridColumn GridColumn8;

	internal GridColumn GridColumn9;

	internal GridColumn GridColumn10;

	internal GridColumn GridColumn11;

	internal GridColumn GridColumn12;

	internal GridColumn GridColumn13;

	internal GridColumn GridColumn14;

	internal GridColumn GridColumn15;

	internal GridColumn GridColumn16;

	internal GridColumn GridColumn17;

	internal GridColumn GridColumn18;

	internal GridColumn GridColumn19;

	internal GridColumn GridColumn20;

	internal GridColumn GridColumn21;

	internal GridColumn GridColumn22;

	internal GridColumn GridColumn23;

	internal GridColumn GridColumn24;

	internal GridColumn GridColumn25;

	internal GridColumn GridColumn26;

	internal GridColumn GridColumn27;

	internal GridColumn GridColumn28;

	internal GridColumn GridColumn29;

	internal GridColumn GridColumn30;

	internal GridColumn GridColumn31;

	internal GridColumn GridColumn32;

	internal GridColumn GridColumn33;

	private SpinEdit spinExercice;

	private LayoutControlGroup Root;

	private LayoutControlItem layoutControlItem1;

	private LayoutControlItem layoutControlItem2;

	private SimpleButton simpleButton1;

	private LayoutControlItem layoutControlItem3;

	private LayoutControlGroup layoutControlGroup2;

	private LayoutControlGroup layoutControlGroup3;

	public frmChangerDossier()
	{
		InitializeComponent();
	}

	private void frmChangerDossier_Load(object sender, EventArgs e)
	{
		monModule.dtDossiers.Clear();
		monModule.adDossiers.Fill(monModule.dtDossiers);
		GridControl1.DataSource = monModule.dtDossiers;
	}

	private void GridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
		if (monModule.dtDossiers != null)
		{
			object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UNI");
			monModule.gUNI = ((t == null) ? "" : t.ToString());
			ChangerDate();
		}
	}

	private void ChangerDate()
	{
		string UNI = monModule.CurrentRow(GridControl1)["UNI"].ToString();
		using OleDbCommand cmd = new OleDbCommand("Select max(Exercice) from Pieces Where UNI='" + UNI + "' ", monModule.gbase);
		object r = cmd.ExecuteScalar();
		spinExercice.EditValue = ((r == DBNull.Value) ? DateTime.Now.Year : Convert.ToInt32(r));
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		if (monModule.dtDossiers != null)
		{
			DataRow dataRow = monModule.CurrentRow(GridControl1);
			monModule.gUNI = dataRow["UNI"].ToString();
			monModule.gUNILIB = dataRow["LIB"].ToString();
			monModule.gExercice = Convert.ToInt32(spinExercice.EditValue);
			Close();
		}
	}

	private void GridControl1_DoubleClick(object sender, EventArgs e)
	{
		simpleButton1_Click(sender, e);
	}

	private void GridControl1_Click(object sender, EventArgs e)
	{
	}

	private void frmChangerDossier_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (monModule.gExercice == 0 || monModule.gUNI == "")
		{
			e.Cancel = true;
		}
	}

	private void gridView1_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Return:
		{
			DataRow dataRow = monModule.CurrentRow(GridControl1);
			monModule.gUNI = dataRow["UNI"].ToString();
			monModule.gUNILIB = dataRow["LIB"].ToString();
			monModule.gExercice = Convert.ToInt32(spinExercice.EditValue);
			Close();
			break;
		}
		case Keys.Escape:
			Close();
			break;
		}
	}

	private void frmChangerDossier_KeyDown(object sender, KeyEventArgs e)
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
		DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
		DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.spinExercice = new DevExpress.XtraEditors.SpinEdit();
		this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.spinExercice.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Controls.Add(this.GridControl1);
		this.layoutControl1.Controls.Add(this.spinExercice);
		this.layoutControl1.Controls.Add(this.simpleButton1);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(674, 416);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.GridControl1.EmbeddedNavigator.Enabled = false;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(12, 74);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(650, 280);
		this.GridControl1.TabIndex = 1;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.GridControl1.Click += new System.EventHandler(GridControl1_Click);
		this.GridControl1.DoubleClick += new System.EventHandler(GridControl1_DoubleClick);
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[3] { this.colcode, this.gridColumn1, this.gridColumn2 });
		this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(319, -670, 498, 610);
		this.gridView1.DetailHeight = 801;
		this.gridView1.FixedLineWidth = 1;
		this.gridView1.GridControl = this.GridControl1;
		this.gridView1.Name = "gridView1";
		this.gridView1.OptionsBehavior.Editable = false;
		this.gridView1.OptionsBehavior.ReadOnly = true;
		this.gridView1.OptionsCustomization.AllowGroup = false;
		this.gridView1.OptionsFind.AlwaysVisible = true;
		this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
		this.gridView1.OptionsView.ColumnAutoWidth = false;
		this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
		this.gridView1.OptionsView.EnableAppearanceOddRow = true;
		this.gridView1.OptionsView.ShowGroupPanel = false;
		this.gridView1.OptionsView.ShowIndicator = false;
		this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView1_FocusedRowChanged);
		this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(gridView1_KeyDown);
		this.colcode.AppearanceHeader.Options.UseTextOptions = true;
		this.colcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colcode.Caption = "Intitulé";
		this.colcode.FieldName = "LIB";
		this.colcode.MinWidth = 38;
		this.colcode.Name = "colcode";
		this.colcode.OptionsColumn.AllowEdit = false;
		this.colcode.OptionsColumn.AllowFocus = false;
		this.colcode.OptionsColumn.ReadOnly = true;
		this.colcode.Visible = true;
		this.colcode.VisibleIndex = 1;
		this.colcode.Width = 271;
		this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn1.Caption = "Intitulé en Arabe";
		this.gridColumn1.FieldName = "LIBAR";
		this.gridColumn1.MinWidth = 12;
		this.gridColumn1.Name = "gridColumn1";
		this.gridColumn1.OptionsColumn.AllowEdit = false;
		this.gridColumn1.OptionsColumn.AllowFocus = false;
		this.gridColumn1.Visible = true;
		this.gridColumn1.VisibleIndex = 2;
		this.gridColumn1.Width = 291;
		this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn2.Caption = "Unité";
		this.gridColumn2.FieldName = "UNI";
		this.gridColumn2.MinWidth = 12;
		this.gridColumn2.Name = "gridColumn2";
		this.gridColumn2.OptionsColumn.AllowEdit = false;
		this.gridColumn2.OptionsColumn.AllowFocus = false;
		this.gridColumn2.Visible = true;
		this.gridColumn2.VisibleIndex = 0;
		this.gridColumn2.Width = 71;
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
		this.GridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[27]
		{
			this.GridColumn7, this.GridColumn8, this.GridColumn9, this.GridColumn10, this.GridColumn11, this.GridColumn12, this.GridColumn13, this.GridColumn14, this.GridColumn15, this.GridColumn16,
			this.GridColumn17, this.GridColumn18, this.GridColumn19, this.GridColumn20, this.GridColumn21, this.GridColumn22, this.GridColumn23, this.GridColumn24, this.GridColumn25, this.GridColumn26,
			this.GridColumn27, this.GridColumn28, this.GridColumn29, this.GridColumn30, this.GridColumn31, this.GridColumn32, this.GridColumn33
		});
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
		this.GridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[1]
		{
			new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.GridColumn10, DevExpress.Data.ColumnSortOrder.Ascending)
		});
		this.GridColumn7.Caption = "الرمز";
		this.GridColumn7.FieldName = "code";
		this.GridColumn7.MinWidth = 49;
		this.GridColumn7.Name = "GridColumn7";
		this.GridColumn7.OptionsColumn.AllowEdit = false;
		this.GridColumn7.OptionsColumn.ReadOnly = true;
		this.GridColumn7.Width = 64;
		this.GridColumn8.Caption = "الإسم";
		this.GridColumn8.FieldName = "nom_ar";
		this.GridColumn8.MinWidth = 49;
		this.GridColumn8.Name = "GridColumn8";
		this.GridColumn8.OptionsColumn.ReadOnly = true;
		this.GridColumn8.Width = 63;
		this.GridColumn9.Caption = "اللقب";
		this.GridColumn9.FieldName = "prenom_ar";
		this.GridColumn9.MinWidth = 49;
		this.GridColumn9.Name = "GridColumn9";
		this.GridColumn9.Width = 237;
		this.GridColumn10.Caption = "البنك";
		this.GridColumn10.FieldName = "codebanque_";
		this.GridColumn10.MinWidth = 49;
		this.GridColumn10.Name = "GridColumn10";
		this.GridColumn10.Width = 124;
		this.GridColumn11.Caption = "nom";
		this.GridColumn11.FieldName = "nom";
		this.GridColumn11.MinWidth = 49;
		this.GridColumn11.Name = "GridColumn11";
		this.GridColumn11.Width = 63;
		this.GridColumn12.Caption = "prénom";
		this.GridColumn12.FieldName = "prenom";
		this.GridColumn12.MinWidth = 49;
		this.GridColumn12.Name = "GridColumn12";
		this.GridColumn12.Width = 63;
		this.GridColumn13.Caption = "الوظيفة";
		this.GridColumn13.FieldName = "codeposte_";
		this.GridColumn13.MinWidth = 49;
		this.GridColumn13.Name = "GridColumn13";
		this.GridColumn13.Width = 63;
		this.GridColumn14.Caption = "الدرجة";
		this.GridColumn14.FieldName = "echellon1";
		this.GridColumn14.MinWidth = 49;
		this.GridColumn14.Name = "GridColumn14";
		this.GridColumn14.Width = 63;
		this.GridColumn15.Caption = "نسبة الخبرة";
		this.GridColumn15.FieldName = "tauxiep1";
		this.GridColumn15.MinWidth = 49;
		this.GridColumn15.Name = "GridColumn15";
		this.GridColumn15.Width = 63;
		this.GridColumn16.Caption = "الوظيفة النوعية";
		this.GridColumn16.FieldName = "codefoncspec_";
		this.GridColumn16.MinWidth = 49;
		this.GridColumn16.Name = "GridColumn16";
		this.GridColumn16.Width = 63;
		this.GridColumn17.Caption = "السكن";
		this.GridColumn17.FieldName = "ville";
		this.GridColumn17.MinWidth = 49;
		this.GridColumn17.Name = "GridColumn17";
		this.GridColumn17.Width = 63;
		this.GridColumn18.Caption = "رقم الحساب";
		this.GridColumn18.FieldName = "numcompte";
		this.GridColumn18.MinWidth = 49;
		this.GridColumn18.Name = "GridColumn18";
		this.GridColumn18.Width = 63;
		this.GridColumn19.Caption = "يستفيد من سكن";
		this.GridColumn19.FieldName = "a1logfonc";
		this.GridColumn19.MinWidth = 49;
		this.GridColumn19.Name = "GridColumn19";
		this.GridColumn19.Width = 221;
		this.GridColumn20.Caption = "الحالة";
		this.GridColumn20.FieldName = "codeblocage_";
		this.GridColumn20.MinWidth = 49;
		this.GridColumn20.Name = "GridColumn20";
		this.GridColumn20.Width = 63;
		this.GridColumn21.Caption = "الحالة العائلية";
		this.GridColumn21.FieldName = "codesitfam_";
		this.GridColumn21.MinWidth = 49;
		this.GridColumn21.Name = "GridColumn21";
		this.GridColumn21.Width = 63;
		this.GridColumn22.Caption = "عدد الأولاد";
		this.GridColumn22.FieldName = "nbenf1";
		this.GridColumn22.MinWidth = 49;
		this.GridColumn22.Name = "GridColumn22";
		this.GridColumn22.Width = 63;
		this.GridColumn23.Caption = "الأجر الوحيد";
		this.GridColumn23.FieldName = "salunique";
		this.GridColumn23.MinWidth = 49;
		this.GridColumn23.Name = "GridColumn23";
		this.GridColumn23.Width = 63;
		this.GridColumn24.Caption = "المتمدرسين";
		this.GridColumn24.FieldName = "scolarise";
		this.GridColumn24.MinWidth = 49;
		this.GridColumn24.Name = "GridColumn24";
		this.GridColumn24.Width = 63;
		this.GridColumn25.Caption = "الإدارة";
		this.GridColumn25.FieldName = "codetyprend_";
		this.GridColumn25.MinWidth = 49;
		this.GridColumn25.Name = "GridColumn25";
		this.GridColumn25.Width = 63;
		this.GridColumn26.Caption = "تاريخ التوظيف";
		this.GridColumn26.FieldName = "dateembauche";
		this.GridColumn26.MinWidth = 49;
		this.GridColumn26.Name = "GridColumn26";
		this.GridColumn26.Width = 63;
		this.GridColumn27.Caption = "تاريخ الميلاد";
		this.GridColumn27.FieldName = "datenaiss";
		this.GridColumn27.MinWidth = 49;
		this.GridColumn27.Name = "GridColumn27";
		this.GridColumn27.Width = 63;
		this.GridColumn28.Caption = "فارق في الدخل";
		this.GridColumn28.FieldName = "dr";
		this.GridColumn28.MinWidth = 49;
		this.GridColumn28.Name = "GridColumn28";
		this.GridColumn28.Width = 63;
		this.GridColumn29.Caption = "ت فارق في الدخل";
		this.GridColumn29.FieldName = "idr";
		this.GridColumn29.MinWidth = 49;
		this.GridColumn29.Name = "GridColumn29";
		this.GridColumn29.Width = 63;
		this.GridColumn30.Caption = "زيادة %10";
		this.GridColumn30.FieldName = "majech";
		this.GridColumn30.MinWidth = 49;
		this.GridColumn30.Name = "GridColumn30";
		this.GridColumn30.Width = 63;
		this.GridColumn31.Caption = "رقم الضمان";
		this.GridColumn31.FieldName = "numeross";
		this.GridColumn31.MinWidth = 49;
		this.GridColumn31.Name = "GridColumn31";
		this.GridColumn31.Width = 63;
		this.GridColumn32.Caption = "ذكر او أنثى";
		this.GridColumn32.FieldName = "sexe";
		this.GridColumn32.MinWidth = 49;
		this.GridColumn32.Name = "GridColumn32";
		this.GridColumn32.Width = 63;
		this.GridColumn33.Caption = "نسية الإعاقة";
		this.GridColumn33.FieldName = "tauxhand";
		this.GridColumn33.MinWidth = 49;
		this.GridColumn33.Name = "GridColumn33";
		this.GridColumn33.Width = 63;
		this.spinExercice.EditValue = new decimal(new int[4] { 2010, 0, 0, 0 });
		this.spinExercice.EnterMoveNextControl = true;
		this.spinExercice.Location = new System.Drawing.Point(234, 40);
		this.spinExercice.Name = "spinExercice";
		this.spinExercice.Properties.Appearance.Options.UseTextOptions = true;
		this.spinExercice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.spinExercice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.spinExercice.Properties.IsFloatValue = false;
		this.spinExercice.Properties.Mask.EditMask = "f0";
		this.spinExercice.Properties.MaxValue = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.spinExercice.Properties.MinValue = new decimal(new int[4] { 2010, 0, 0, 0 });
		this.spinExercice.Size = new System.Drawing.Size(206, 20);
		this.spinExercice.StyleController = this.layoutControl1;
		this.spinExercice.TabIndex = 0;
		this.simpleButton1.ImageOptions.Image = compta.Properties.Resources.open_16x16;
		this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton1.Location = new System.Drawing.Point(234, 370);
		this.simpleButton1.Name = "simpleButton1";
		this.simpleButton1.Size = new System.Drawing.Size(206, 22);
		this.simpleButton1.StyleController = this.layoutControl1;
		this.simpleButton1.TabIndex = 4;
		this.simpleButton1.Text = "Ouvrir";
		this.simpleButton1.Click += new System.EventHandler(simpleButton1_Click);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.layoutControlItem2, this.layoutControlGroup2, this.layoutControlGroup3 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(674, 416);
		this.Root.TextVisible = false;
		this.layoutControlItem2.Control = this.GridControl1;
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 62);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(654, 284);
		this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem2.TextVisible = false;
		this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem3 });
		this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 346);
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
		this.layoutControlGroup2.Size = new System.Drawing.Size(654, 50);
		this.layoutControlGroup2.Text = "layoutControlGroup1";
		this.layoutControlGroup2.TextVisible = false;
		this.layoutControlItem3.Control = this.simpleButton1;
		this.layoutControlItem3.Location = new System.Drawing.Point(210, 0);
		this.layoutControlItem3.Name = "layoutControlItem3";
		this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem3.Size = new System.Drawing.Size(210, 26);
		this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem3.TextVisible = false;
		this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem1 });
		this.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup3.Name = "layoutControlGroup3";
		columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition4.Width = 33.333333333333336;
		columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition5.Width = 33.333333333333336;
		columnDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition6.Width = 33.333333333333336;
		this.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[3] { columnDefinition4, columnDefinition5, columnDefinition6 });
		rowDefinition2.Height = 100.0;
		rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
		this.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[1] { rowDefinition2 });
		this.layoutControlGroup3.Size = new System.Drawing.Size(654, 62);
		this.layoutControlGroup3.Text = "layoutControlGroup1";
		this.layoutControlGroup3.TextVisible = false;
		this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
		this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlItem1.Control = this.spinExercice;
		this.layoutControlItem1.Location = new System.Drawing.Point(210, 0);
		this.layoutControlItem1.MinSize = new System.Drawing.Size(52, 38);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem1.Size = new System.Drawing.Size(210, 38);
		this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.layoutControlItem1.Text = "Exercice";
		this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
		this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(674, 416);
		base.Controls.Add(this.layoutControl1);
		base.IconOptions.Image = compta.Properties.Resources.projectdirectory_32x32;
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmChangerDossier";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Changement de Dossier";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmChangerDossier_FormClosing);
		base.Load += new System.EventHandler(frmChangerDossier_Load);
		base.KeyDown += new System.Windows.Forms.KeyEventHandler(frmChangerDossier_KeyDown);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.spinExercice.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		base.ResumeLayout(false);
	}
}
