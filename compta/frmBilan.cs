using System;
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

public class frmBilan : XtraForm
{
	private int etat;

	private IContainer components;

	private LayoutControl layoutControl1;

	private SpinEdit txtexe;

	private LayoutControlGroup Root;

	private LayoutControlItem layoutControlItem1;

	private SearchLookUpEdit dos;

	private GridView searchLookUpEdit1View;

	private GridColumn colUNI;

	private GridColumn colLIB1;

	private LayoutControlItem layoutControlItem2;

	private EmptySpaceItem emptySpaceItem1;

	private EmptySpaceItem emptySpaceItem3;

	private DataSet1 dataSet1;

	private BindingSource dossiersBindingSource;

	private DossiersTableAdapter dossiersTableAdapter;

	private SimpleButton simpleButton11;

	private LayoutControlGroup layoutControlGroup2;

	private LayoutControlItem layoutControlItem3;

	public frmBilan(int _etat = 0)
	{
		InitializeComponent();
		etat = _etat;
	}

	private void frmBalance_Load(object sender, EventArgs e)
	{
		string connection = monModule.gConnString;
		dossiersTableAdapter.Connection.ConnectionString = connection;
		dossiersTableAdapter.Fill(dataSet1.Dossiers);
		dos.EditValue = monModule.gUNI;
		txtexe.EditValue = monModule.gExercice;
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		if (etat == 0)
		{
			centarlisation();
		}
		else
		{
			dossierclient();
		}
	}

	private void dossierclient()
	{
		new OleDbCommand
		{
			CommandType = CommandType.Text,
			Connection = monModule.gbase
		};
		DataTable dt = new DataTable();
		string uni = (monModule.eUNI = dos.EditValue.ToString());
		monModule.eExercice = txtexe.Text;
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + uni + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			monModule.eUNILIB = foundRows[0]["LIB"].ToString();
		}
		string obj = "SELECT 'Centralisation de l''exercice " + monModule.eExercice + "' as Exercice, Month([DAT]) AS MM, Ecritures.JA AS JA, Journaux.LIB as LIBJA, Sum(Ecritures.DEB) AS SDEB, Sum(Ecritures.CRE) AS SCRE  FROM Ecritures INNER JOIN Journaux ON Ecritures.JA = Journaux.JA  WHERE Ecritures.Exercice=" + monModule.eExercice + " and Ecritures.UNI='" + monModule.eUNI + "' GROUP BY Month([DAT]), Ecritures.JA, Journaux.LIB, 'Centralisation de l''exercice " + monModule.eExercice + "'  ORDER BY Month([DAT]), Ecritures.JA ";
		Console.WriteLine(obj);
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(obj, monModule.gbase);
		dt.Clear();
		oleDbDataAdapter.Fill(dt);
		ReportPrintTool reportPrintTool = new ReportPrintTool(new rptCentralisation
		{
			DataSource = dt
		});
		Close();
		reportPrintTool.ShowPreview();
	}

	private void centarlisation()
	{
		new OleDbCommand
		{
			CommandType = CommandType.Text,
			Connection = monModule.gbase
		};
		DataTable dt = new DataTable();
		string uni = (monModule.eUNI = dos.EditValue.ToString());
		monModule.eExercice = txtexe.Text;
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + uni + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			monModule.eUNILIB = foundRows[0]["LIB"].ToString();
		}
		string obj = "SELECT 'Centralisation de l''exercice " + monModule.eExercice + "' as Exercice, Month([DAT]) AS MM, Ecritures.JA AS JA, Journaux.LIB as LIBJA, Sum(Ecritures.DEB) AS SDEB, Sum(Ecritures.CRE) AS SCRE  FROM Ecritures INNER JOIN Journaux ON Ecritures.JA = Journaux.JA  WHERE Ecritures.Exercice=" + monModule.eExercice + " and Ecritures.UNI='" + monModule.eUNI + "' GROUP BY Month([DAT]), Ecritures.JA, Journaux.LIB, 'Centralisation de l''exercice " + monModule.eExercice + "'  ORDER BY Month([DAT]), Ecritures.JA ";
		Console.WriteLine(obj);
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(obj, monModule.gbase);
		dt.Clear();
		oleDbDataAdapter.Fill(dt);
		ReportPrintTool reportPrintTool = new ReportPrintTool(new rptCentralisation
		{
			DataSource = dt
		});
		Close();
		reportPrintTool.ShowPreview();
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

	private void simpleButton1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtexe.Focus();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmBilan));
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.txtexe = new DevExpress.XtraEditors.SpinEdit();
		this.dos = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.dossiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.dossiersTableAdapter = new compta.DataSet1TableAdapters.DossiersTableAdapter();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.txtexe.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Controls.Add(this.txtexe);
		this.layoutControl1.Controls.Add(this.dos);
		this.layoutControl1.Controls.Add(this.simpleButton11);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(381, 151);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.txtexe.EditValue = new decimal(new int[4] { 2020, 0, 0, 0 });
		this.txtexe.EnterMoveNextControl = true;
		this.txtexe.Location = new System.Drawing.Point(55, 36);
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
		this.txtexe.Size = new System.Drawing.Size(90, 20);
		this.txtexe.StyleController = this.layoutControl1;
		this.txtexe.TabIndex = 4;
		this.txtexe.KeyDown += new System.Windows.Forms.KeyEventHandler(txtexe_KeyDown);
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
		this.dos.Size = new System.Drawing.Size(314, 20);
		this.dos.StyleController = this.layoutControl1;
		this.dos.TabIndex = 0;
		this.dos.KeyDown += new System.Windows.Forms.KeyEventHandler(dos_KeyDown);
		this.dossiersBindingSource.DataMember = "Dossiers";
		this.dossiersBindingSource.DataSource = this.dataSet1;
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
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[5] { this.layoutControlItem1, this.emptySpaceItem1, this.emptySpaceItem3, this.layoutControlItem2, this.layoutControlGroup2 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(381, 151);
		this.Root.TextVisible = false;
		this.layoutControlItem1.Control = this.txtexe;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(137, 24);
		this.layoutControlItem1.Text = "Exercice";
		this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(361, 57);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem3.AllowHotTrack = false;
		this.emptySpaceItem3.Location = new System.Drawing.Point(137, 24);
		this.emptySpaceItem3.Name = "emptySpaceItem3";
		this.emptySpaceItem3.Size = new System.Drawing.Size(224, 24);
		this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem2.Control = this.dos;
		this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem2.CustomizationFormText = "Dossier";
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(361, 24);
		this.layoutControlItem2.Text = "Dossier";
		this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 13);
		this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup2.GroupBordersVisible = false;
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem3 });
		this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 105);
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
		this.layoutControlGroup2.Size = new System.Drawing.Size(361, 26);
		this.layoutControlGroup2.Text = "layoutControlGroup1";
		this.layoutControlGroup2.TextVisible = false;
		this.dossiersTableAdapter.ClearBeforeFill = true;
		this.simpleButton11.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton11.ImageOptions.Image");
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(132, 117);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Size = new System.Drawing.Size(116, 22);
		this.simpleButton11.StyleController = this.layoutControl1;
		this.simpleButton11.TabIndex = 7;
		this.simpleButton11.Text = "Imprimer";
		this.simpleButton11.Click += new System.EventHandler(simpleButton1_Click);
		this.simpleButton11.KeyDown += new System.Windows.Forms.KeyEventHandler(simpleButton1_KeyDown);
		this.layoutControlItem3.Control = this.simpleButton11;
		this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem3.CustomizationFormText = "layoutControlItem6";
		this.layoutControlItem3.Location = new System.Drawing.Point(120, 0);
		this.layoutControlItem3.Name = "layoutControlItem3";
		this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem3.Size = new System.Drawing.Size(120, 26);
		this.layoutControlItem3.Text = "layoutControlItem6";
		this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem3.TextVisible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(381, 151);
		base.Controls.Add(this.layoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmBilan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		base.Load += new System.EventHandler(frmBalance_Load);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.txtexe.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		base.ResumeLayout(false);
	}
}
