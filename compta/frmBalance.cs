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

public class frmBalance : XtraForm
{
	private bool bgeneral;

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

	private SpinEdit txtmois;

	private SimpleButton simpleButton1;

	private LayoutControlItem layoutControlItem4;

	private LayoutControlItem layoutControlItem6;

	private EmptySpaceItem emptySpaceItem2;

	private EmptySpaceItem emptySpaceItem3;

	private DataSet1 dataSet1;

	private BindingSource dossiersBindingSource;

	private DossiersTableAdapter dossiersTableAdapter;

	private EmptySpaceItem emptySpaceItem4;

	private LayoutControlGroup layoutControlGroup1;

	public frmBalance()
	{
		InitializeComponent();
	}

	public frmBalance(bool gen)
	{
		InitializeComponent();
		bgeneral = gen;
	}

	private void frmBalance_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		dossiersTableAdapter.Connection.ConnectionString = connection;
		dossiersTableAdapter.Fill(dataSet1.Dossiers);
		dos.EditValue = monModule.gUNI;
		txtexe.EditValue = monModule.gExercice;
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		new OleDbCommand
		{
			CommandType = CommandType.Text,
			Connection = monModule.gbase
		};
		DataTable dt = new DataTable();
		string auMM = txtmois.Text;
		string uni = (monModule.eUNI = dos.EditValue.ToString());
		monModule.eExercice = txtexe.Text;
		monModule.eMOIS = Convert.ToInt32(auMM);
		DataRow[] foundRows = monModule.dtDossiers.Select("UNI='" + uni + "'");
		monModule.eUNILIB = "";
		if (foundRows.Length != 0)
		{
			monModule.eUNILIB = foundRows[0]["LIB"].ToString();
		}
		string sql = ((!bgeneral) ? ("SELECT Ecritures.CPT as UN, Comptes.LIB, [Ecritures].[CPT] AS Compte, IIf((Sum([Ecritures].[DEB])-Sum([Ecritures].[CRE]))>0,Sum([Ecritures].[DEB])-Sum([Ecritures].[CRE]),0) AS SDEBIT, IIf((Sum([Ecritures].[DEB])-Sum([Ecritures].[CRE]))<0,Sum([Ecritures].[CRE])-Sum([Ecritures].[DEB]),0) AS SCREDIT, Sum(IIf([JA]='00',0,[CRE])) AS SCRE, Sum(IIf([JA]='00',0,[DEB])) AS SDEB, Sum(IIf([JA]<>'00',0,[CRE])) AS CREI, Sum(IIf([JA]<>'00',0,[DEB])) AS DEBI   FROM  Ecritures INNER JOIN Comptes ON (Ecritures.CPT=Comptes.CPT)   WHERE (Exercice=" + monModule.eExercice + ") and (UNI='" + monModule.eUNI + "') and (((Month([Ecritures].[dat]))<=" + auMM + "))  GROUP BY Ecritures.CPT, Comptes.LIB  HAVING (((Sum([Ecritures].[DEB])-Sum([Ecritures].[CRE]))<>0))  ORDER BY [Ecritures].[CPT]") : ("SELECT Ecritures.CPT as UN, Comptes.LIB, [Ecritures].[CPT] AS Compte, IIf((Sum([Ecritures].[DEB])-Sum([Ecritures].[CRE]))>0,Sum([Ecritures].[DEB])-Sum([Ecritures].[CRE]),0) AS SDEBIT, IIf((Sum([Ecritures].[DEB])-Sum([Ecritures].[CRE]))<0,Sum([Ecritures].[CRE])-Sum([Ecritures].[DEB]),0) AS SCREDIT, Sum(IIf([JA]='00',0,[CRE])) AS SCRE, Sum(IIf([JA]='00',0,[DEB])) AS SDEB, Sum(IIf([JA]<>'00',0,[CRE])) AS CREI, Sum(IIf([JA]<>'00',0,[DEB])) AS DEBI   FROM  Ecritures INNER JOIN Comptes ON (Ecritures.CPT=Comptes.CPT)   WHERE (Exercice=" + monModule.eExercice + ") and (UNI='" + monModule.eUNI + "') and (((Month([Ecritures].[dat]))<=" + auMM + "))  GROUP BY Ecritures.CPT, Comptes.LIB  ORDER BY [Ecritures].[CPT]"));
		Console.WriteLine("-----------------------------------");
		Console.WriteLine(sql);
		Console.WriteLine("-----------------------------------");
		OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sql, monModule.gbase);
		dt.Clear();
		oleDbDataAdapter.Fill(dt);
		if (bgeneral)
		{
			ReportPrintTool reportPrintTool = new ReportPrintTool(new rptBalanceGenerale
			{
				DataSource = dt
			});
			Close();
			reportPrintTool.ShowPreview();
		}
		else
		{
			ReportPrintTool reportPrintTool2 = new ReportPrintTool(new rptSolde
			{
				DataSource = dt
			});
			Close();
			reportPrintTool2.ShowPreview();
		}
	}

	private void txtchiffre_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtmois.Focus();
		}
	}

	private void txtmois_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtexe.Focus();
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

	private void simpleButton1_KeyDown(object sender, KeyEventArgs e)
	{
		_ = e.KeyCode;
		_ = 27;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compta.frmBalance));
		this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
		this.txtmois = new DevExpress.XtraEditors.SpinEdit();
		this.txtexe = new DevExpress.XtraEditors.SpinEdit();
		this.dos = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.dataSet1 = new compta.DataSet1();
		this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.dossiersTableAdapter = new compta.DataSet1TableAdapters.DossiersTableAdapter();
		this.dossiersBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
		this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).BeginInit();
		this.layoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.txtmois.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtexe.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).BeginInit();
		base.SuspendLayout();
		this.layoutControl1.Controls.Add(this.txtmois);
		this.layoutControl1.Controls.Add(this.txtexe);
		this.layoutControl1.Controls.Add(this.dos);
		this.layoutControl1.Controls.Add(this.simpleButton1);
		this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.layoutControl1.Location = new System.Drawing.Point(0, 0);
		this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
		this.layoutControl1.Name = "layoutControl1";
		this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(719, 0, 650, 400);
		this.layoutControl1.Root = this.Root;
		this.layoutControl1.Size = new System.Drawing.Size(489, 226);
		this.layoutControl1.TabIndex = 0;
		this.layoutControl1.Text = "layoutControl1";
		this.txtmois.EditValue = new decimal(new int[4] { 12, 0, 0, 0 });
		this.txtmois.EnterMoveNextControl = true;
		this.txtmois.Location = new System.Drawing.Point(70, 60);
		this.txtmois.Margin = new System.Windows.Forms.Padding(2);
		this.txtmois.Name = "txtmois";
		this.txtmois.Properties.Appearance.Options.UseTextOptions = true;
		this.txtmois.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtmois.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.txtmois.Properties.DisplayFormat.FormatString = "{0:00}";
		this.txtmois.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.txtmois.Properties.IsFloatValue = false;
		this.txtmois.Properties.Mask.EditMask = "N00";
		this.txtmois.Properties.MaxValue = new decimal(new int[4] { 12, 0, 0, 0 });
		this.txtmois.Properties.MinValue = new decimal(new int[4] { 1, 0, 0, 0 });
		this.txtmois.Size = new System.Drawing.Size(98, 20);
		this.txtmois.StyleController = this.layoutControl1;
		this.txtmois.TabIndex = 5;
		this.txtmois.KeyDown += new System.Windows.Forms.KeyEventHandler(txtmois_KeyDown);
		this.txtexe.EditValue = new decimal(new int[4] { 2020, 0, 0, 0 });
		this.txtexe.EnterMoveNextControl = true;
		this.txtexe.Location = new System.Drawing.Point(70, 36);
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
		this.txtexe.Size = new System.Drawing.Size(116, 20);
		this.txtexe.StyleController = this.layoutControl1;
		this.txtexe.TabIndex = 4;
		this.txtexe.KeyDown += new System.Windows.Forms.KeyEventHandler(txtexe_KeyDown);
		this.dos.EditValue = "001";
		this.dos.EnterMoveNextControl = true;
		this.dos.Location = new System.Drawing.Point(70, 12);
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
		this.dos.Size = new System.Drawing.Size(407, 20);
		this.dos.StyleController = this.layoutControl1;
		this.dos.TabIndex = 0;
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
		this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
		this.Root.GroupBordersVisible = false;
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[7] { this.layoutControlItem1, this.layoutControlItem4, this.emptySpaceItem2, this.emptySpaceItem3, this.layoutControlItem2, this.emptySpaceItem4, this.layoutControlGroup1 });
		this.Root.Name = "Root";
		this.Root.Size = new System.Drawing.Size(489, 226);
		this.Root.TextVisible = false;
		this.layoutControlItem1.Control = this.txtexe;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(178, 24);
		this.layoutControlItem1.Text = "Exercice";
		this.layoutControlItem1.TextSize = new System.Drawing.Size(55, 13);
		this.layoutControlItem4.Control = this.txtmois;
		this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
		this.layoutControlItem4.Name = "layoutControlItem4";
		this.layoutControlItem4.Size = new System.Drawing.Size(160, 24);
		this.layoutControlItem4.Text = "Balance au ";
		this.layoutControlItem4.TextSize = new System.Drawing.Size(55, 13);
		this.emptySpaceItem2.AllowHotTrack = false;
		this.emptySpaceItem2.Location = new System.Drawing.Point(160, 48);
		this.emptySpaceItem2.Name = "emptySpaceItem2";
		this.emptySpaceItem2.Size = new System.Drawing.Size(309, 24);
		this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem3.AllowHotTrack = false;
		this.emptySpaceItem3.Location = new System.Drawing.Point(178, 24);
		this.emptySpaceItem3.Name = "emptySpaceItem3";
		this.emptySpaceItem3.Size = new System.Drawing.Size(291, 24);
		this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem2.Control = this.dos;
		this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.layoutControlItem2.CustomizationFormText = "Dossier";
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(469, 24);
		this.layoutControlItem2.Text = "Dossier";
		this.layoutControlItem2.TextSize = new System.Drawing.Size(55, 13);
		this.emptySpaceItem4.AllowHotTrack = false;
		this.emptySpaceItem4.Location = new System.Drawing.Point(0, 72);
		this.emptySpaceItem4.Name = "emptySpaceItem4";
		this.emptySpaceItem4.Size = new System.Drawing.Size(469, 84);
		this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.layoutControlItem6 });
		this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 156);
		this.layoutControlGroup1.Name = "layoutControlGroup1";
		columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition1.Width = 33.333333333333336;
		columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition2.Width = 33.333333333333336;
		columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
		columnDefinition3.Width = 33.333333333333336;
		this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[3] { columnDefinition1, columnDefinition2, columnDefinition3 });
		rowDefinition1.Height = 100.0;
		rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
		this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[1] { rowDefinition1 });
		this.layoutControlGroup1.Size = new System.Drawing.Size(469, 50);
		this.layoutControlGroup1.TextVisible = false;
		this.dossiersTableAdapter.ClearBeforeFill = true;
		this.dossiersBindingSource.DataMember = "Dossiers";
		this.dossiersBindingSource.DataSource = this.dataSet1;
		this.simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
		this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton1.Location = new System.Drawing.Point(172, 180);
		this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
		this.simpleButton1.Name = "simpleButton1";
		this.simpleButton1.Size = new System.Drawing.Size(144, 22);
		this.simpleButton1.StyleController = this.layoutControl1;
		this.simpleButton1.TabIndex = 7;
		this.simpleButton1.Text = "Imprimer";
		this.simpleButton1.Click += new System.EventHandler(simpleButton1_Click);
		this.simpleButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(simpleButton1_KeyDown);
		this.layoutControlItem6.Control = this.simpleButton1;
		this.layoutControlItem6.Location = new System.Drawing.Point(148, 0);
		this.layoutControlItem6.Name = "layoutControlItem6";
		this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem6.Size = new System.Drawing.Size(148, 26);
		this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem6.TextVisible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(489, 226);
		base.Controls.Add(this.layoutControl1);
		base.Margin = new System.Windows.Forms.Padding(2);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmBalance";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		base.Load += new System.EventHandler(frmBalance_Load);
		((System.ComponentModel.ISupportInitialize)this.layoutControl1).EndInit();
		this.layoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.txtmois.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtexe.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dos.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dossiersBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).EndInit();
		base.ResumeLayout(false);
	}
}
