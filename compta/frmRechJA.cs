using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using compta.DataSet1TableAdapters;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace compta;

public class frmRechJA : XtraForm
{
	private IContainer components;

	private LayoutControl layoutControl1;

	private LayoutControlGroup Root;

	internal GridControl GridControl1;

	internal GridView gridView1;

	private GridColumn colUNI;

	private GridColumn colLIB;

	internal GridView GridView3;

	private LayoutControlItem layoutControlItem1;

	private DataSet1 dataSet1;

	private BindingSource journauxBindingSource;

	private JournauxTableAdapter journauxTableAdapter;

	private SimpleButton simpleButton11;

	private LayoutControlGroup layoutControlGroup2;

	private LayoutControlItem layoutControlItem6;

	public frmRechJA()
	{
		InitializeComponent();
	}

	private void frmRechJA_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		journauxTableAdapter.Connection.ConnectionString = connection;
		journauxTableAdapter.Fill(dataSet1.Journaux);
	}

	protected override void OnShown(EventArgs e)
	{
		base.OnShown(e);
		GridControl1.Controls.OfType<FindControl>().FirstOrDefault().FindEdit.KeyDown += gridView1_KeyDown;
	}

	private void gridView1_KeyDown(object sender, KeyEventArgs e)
	{
		GridView view = gridView1;
		if (e.Modifiers == Keys.None && e.KeyCode == Keys.Escape)
		{
			monModule.gJA = "";
			Close();
		}
		else if (dataSet1.Journaux != null)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				monModule.gJA = "";
				if (view.FocusedRowHandle >= 0)
				{
					monModule.gJA = view.GetRowCellValue(view.FocusedRowHandle, "JA").ToString();
				}
				Close();
			}
		}
		else
		{
			monModule.gJA = "";
			Close();
		}
	}

	private void gridView1_DoubleClick(object sender, EventArgs e)
	{
		if (dataSet1.Journaux != null)
		{
			if (gridView1.FocusedRowHandle >= 0)
			{
				monModule.gJA = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JA").ToString();
			}
		}
		else
		{
			monModule.gJA = "";
		}
		Close();
	}

	private void frmRechJA_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Modifiers == Keys.None && e.KeyCode == Keys.Escape)
		{
			monModule.gJA = "";
			Close();
		}
	}

	private void simpleButton11_Click(object sender, EventArgs e)
	{
		if (dataSet1.Journaux != null)
		{
			monModule.gJA = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "JA").ToString();
		}
		else
		{
			monModule.gJA = "";
		}
		Close();
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
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.journauxBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
		this.journauxTableAdapter = new compta.DataSet1TableAdapters.JournauxTableAdapter();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Controls.Add(this.GridControl1);
		this.layoutControl1.Controls.Add(this.simpleButton11);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(633, 409);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.GridControl1.DataSource = this.journauxBindingSource;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(8, 8);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(617, 369);
		this.GridControl1.TabIndex = 47;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.GridControl1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);
		this.GridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(gridView1_KeyDown);
		this.journauxBindingSource.DataMember = "Journaux";
		this.journauxBindingSource.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.colUNI, this.colLIB });
		this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(319, -670, 498, 610);
		this.gridView1.DetailHeight = 801;
		this.gridView1.FixedLineWidth = 1;
		this.gridView1.GridControl = this.GridControl1;
		this.gridView1.Name = "gridView1";
		this.gridView1.OptionsBehavior.Editable = false;
		this.gridView1.OptionsBehavior.ReadOnly = true;
		this.gridView1.OptionsCustomization.AllowGroup = false;
		this.gridView1.OptionsFind.AlwaysVisible = true;
		this.gridView1.OptionsFind.FindNullPrompt = "";
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
		this.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);
		this.colUNI.AppearanceCell.Options.UseTextOptions = true;
		this.colUNI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.AppearanceHeader.Options.UseTextOptions = true;
		this.colUNI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.Caption = "Code Journal";
		this.colUNI.FieldName = "JA";
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
		this.colLIB.Width = 547;
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
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(214, 379);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Size = new System.Drawing.Size(204, 22);
		this.simpleButton11.StyleController = this.layoutControl1;
		this.simpleButton11.TabIndex = 5;
		this.simpleButton11.Text = "OK";
		this.simpleButton11.Click += new System.EventHandler(simpleButton11_Click);
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlItem1, this.layoutControlGroup2 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(633, 409);
		this.Root.TextVisible = false;
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(619, 371);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup2.GroupBordersVisible = false;
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem6 });
		this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 371);
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
		this.layoutControlGroup2.Size = new System.Drawing.Size(619, 24);
		this.layoutControlGroup2.Text = "layoutControlGroup1";
		this.layoutControlGroup2.TextVisible = false;
		this.layoutControlItem6.Control = this.simpleButton11;
		this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
		this.layoutControlItem6.Location = new System.Drawing.Point(206, 0);
		this.layoutControlItem6.Name = "layoutControlItem6";
		this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem6.Size = new System.Drawing.Size(206, 24);
		this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem6.TextVisible = false;
		this.journauxTableAdapter.ClearBeforeFill = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(633, 409);
		base.Controls.Add(this.layoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmRechJA";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Recherche Journal";
		base.Load += new System.EventHandler(frmRechJA_Load);
		base.KeyDown += new System.Windows.Forms.KeyEventHandler(frmRechJA_KeyDown);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.journauxBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).EndInit();
		base.ResumeLayout(false);
	}
}
