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
using DevExpress.Data.Filtering;
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

public class frmComptes : XtraForm
{
	private bool isLoaded;

	private bool recherche;

	private string fil = "";

	private InputLanguage originalInputLang;

	private IContainer components;

	private DataLayoutControl dataLayoutControl1;

	private LayoutControlGroup Root;

	private DataSet1 dataSet1;

	private BindingSource bindingSource1;

	private ComptesTableAdapter comptesTableAdapter;

	private TextEdit txtCPT;

	private TextEdit txtLIB;

	private TextEdit txtTAG;

	private TextEdit IDTextEdit;

	private LayoutControlGroup layoutControlGroup1;

	private LayoutControlItem ItemForCPT;

	private LayoutControlItem ItemForLIB;

	private LayoutControlItem ItemForIMPUT;

	private LayoutControlItem ItemForTRS;

	private LayoutControlItem ItemForANA;

	private LayoutControlItem ItemForIMMO;

	private LayoutControlItem ItemForTAG;

	private LayoutControlItem ItemForID;

	internal GridControl GridControl1;

	internal GridView gridView1;

	private GridColumn colUNI;

	private GridColumn colLIB;

	internal GridView GridView3;

	private LayoutControlItem layoutControlItem1;

	private LayoutControlGroup layoutControlGroup2;

	private CheckEdit TRSComboBoxEdit;

	private CheckEdit IMPUTComboBoxEdit;

	private CheckEdit IMMOComboBoxEdit;

	private CheckEdit ANAComboBoxEdit;

	private SimpleButton simpleButton4;

	private SimpleButton simpleButton11;

	private SimpleButton simpleButton3;

	private SimpleButton simpleButton21;

	private LayoutControlGroup layoutControlGroup5;

	private LayoutControlItem layoutControlItem16;

	private LayoutControlItem layoutControlItem17;

	private LayoutControlItem layoutControlItem21;

	private LayoutControlItem layoutControlItem22;

	private CheckEdit checkEdit2;

	private CheckEdit checkEdit1;

	private LayoutControlItem layoutControlItem2;

	private LayoutControlItem layoutControlItem3;

	private CheckEdit checkEdit3;

	private LayoutControlItem layoutControlItem4;

	private GridColumn IMPUT;

	private TextEdit txtLIB1;

	private LayoutControlItem ItemForLIB1;

	private GridColumn colLIBAR;

	public frmComptes()
	{
		InitializeComponent();
		gridView1.OptionsFind.AlwaysVisible = false;
		ApplyModernIcons();
	}

	private void ApplyModernIcons()
	{
		IconManager.SetIcon(simpleButton11, IconManager.Icons.Save);
		IconManager.SetIcon(simpleButton21, IconManager.Icons.Add);
		IconManager.SetIcon(simpleButton3, IconManager.Icons.Delete);
		IconManager.SetIcon(simpleButton4, IconManager.Icons.Print);
	}

	public frmComptes(bool rech, string filtre = "")
	{
		InitializeComponent();
		recherche = rech;
		gridView1.Columns["IMPUT"].FilterInfo = new ColumnFilterInfo("[IMPUT] = 'O'");
		gridView1.OptionsFind.AlwaysVisible = true;
		fil = filtre;
		ApplyModernIcons();
	}

	private void frmComptes_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		comptesTableAdapter.Connection.ConnectionString = connection;
		comptesTableAdapter.Fill(dataSet1.Comptes);
		dataSet1.Comptes.Columns["IMPUT"].DefaultValue = "O";
		dataSet1.Comptes.Columns["TRS"].DefaultValue = "N";
		dataSet1.Comptes.Columns["ANA"].DefaultValue = "N";
		dataSet1.Comptes.Columns["IMMO"].DefaultValue = "N";
		dataSet1.Comptes.Columns["AMOR"].DefaultValue = "N";
		dataSet1.Comptes.Columns["PROD"].DefaultValue = "N";
		dataSet1.Comptes.Columns["DOT"].DefaultValue = "N";
		dataSet1.Comptes.Columns["TAG"].DefaultValue = "";
		bindingSource1.DataSource = dataSet1.Comptes;
		GridControl1.ForceInitialize();
		isLoaded = true;
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
	}

	protected override void OnLoad(EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		comptesTableAdapter.Connection.ConnectionString = connection;
		dataSet1.Comptes.Columns["IMPUT"].DefaultValue = "O";
		dataSet1.Comptes.Columns["TRS"].DefaultValue = "N";
		dataSet1.Comptes.Columns["ANA"].DefaultValue = "N";
		dataSet1.Comptes.Columns["IMMO"].DefaultValue = "N";
		dataSet1.Comptes.Columns["AMOR"].DefaultValue = "N";
		dataSet1.Comptes.Columns["PROD"].DefaultValue = "N";
		dataSet1.Comptes.Columns["DOT"].DefaultValue = "N";
		dataSet1.Comptes.Columns["TAG"].DefaultValue = "";
		comptesTableAdapter.Fill(dataSet1.Comptes);
		bindingSource1.DataSource = dataSet1.Comptes;
		GridControl1.ForceInitialize();
		if (recherche)
		{
			base.OnLoad(e);
			SendKeys.Send("^{F}");
		}
	}

	private void Rafraichir()
	{
		if (dataSet1.Comptes != null)
		{
			int pos = bindingSource1.Position;
			dataSet1.Comptes.Clear();
			comptesTableAdapter.Fill(dataSet1.Comptes);
			bindingSource1.Position = pos;
		}
	}

	private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
	{
		try
		{
			bindingSource1.EndEdit();
			comptesTableAdapter.Update(dataSet1.Comptes);
			dataSet1.Comptes.AcceptChanges();
			monModule.cptmodifie = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			dataSet1.Comptes.RejectChanges();
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
				comptesTableAdapter.Adapter.Update(dataSet1.Comptes);
				dataSet1.Comptes.AcceptChanges();
			}
			catch (Exception ex)
			{
				dataSet1.Comptes.RejectChanges();
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void TRSComboBoxEdit_QueryCheckStateByValue(object sender, QueryCheckStateByValueEventArgs e)
	{
		object o = e.Value;
		if (o != null)
		{
			switch (o.ToString())
			{
			case "True":
			case "O":
			case "Yes":
			case "1":
				e.CheckState = CheckState.Checked;
				break;
			case "False":
			case "No":
			case "N":
			case "0":
				e.CheckState = CheckState.Unchecked;
				break;
			default:
				e.CheckState = CheckState.Indeterminate;
				break;
			}
			e.Handled = true;
		}
	}

	private void TRSComboBoxEdit_QueryValueByCheckState(object sender, QueryValueByCheckStateEventArgs e)
	{
		object val = (sender as CheckEdit).EditValue;
		switch (e.CheckState)
		{
		case CheckState.Checked:
			if (val is bool)
			{
				e.Value = true;
			}
			else if (val is string)
			{
				e.Value = "O";
			}
			else if (val is int)
			{
				e.Value = 1;
			}
			else
			{
				e.Value = null;
			}
			break;
		case CheckState.Unchecked:
			if (val is bool)
			{
				e.Value = false;
			}
			else if (val is string)
			{
				e.Value = "N";
			}
			else if (val is int)
			{
				e.Value = 0;
			}
			else
			{
				e.Value = null;
			}
			break;
		default:
			if (val is bool)
			{
				e.Value = false;
			}
			else if (val is string)
			{
				e.Value = "?";
			}
			else if (val is int)
			{
				e.Value = -1;
			}
			else
			{
				e.Value = null;
			}
			break;
		}
		e.Handled = true;
	}

	private void frmComptes_Activated(object sender, EventArgs e)
	{
		int rowHandle = gridView1.LocateByValue("CPT", monModule.gCPT);
		if (rowHandle != int.MinValue)
		{
			gridView1.FocusedRowHandle = rowHandle;
		}
		gridView1.Focus();
	}

	private void GridControl1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtTAG.Focus();
		}
	}

	private void txtTAG_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtLIB.Focus();
		}
	}

	private void txtLIB_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			txtCPT.Focus();
		}
	}

	private void txtCPT_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void GridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
	}

	private void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
	{
		if (isLoaded)
		{
			object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CPT");
			monModule.gCPT = ((t == null) ? "" : t.ToString());
		}
	}

	private void gridView1_KeyDown(object sender, KeyEventArgs e)
	{
		GridView view = gridView1;
		if (e.Modifiers == Keys.None && e.KeyCode == Keys.Escape)
		{
			monModule.gCPT = "";
			Close();
		}
		else if (dataSet1.Comptes != null)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				monModule.gCPT = "";
				if (view.FocusedRowHandle >= 0)
				{
					monModule.gCPT = view.GetRowCellValue(view.FocusedRowHandle, "CPT").ToString();
				}
				Close();
			}
		}
		else
		{
			monModule.gCPT = "";
			Close();
		}
	}

	private void gridView1_DoubleClick(object sender, EventArgs e)
	{
		GridView view = sender as GridView;
		if (dataSet1.Comptes != null)
		{
			monModule.gCPT = view.GetRowCellValue(view.FocusedRowHandle, "CPT").ToString();
		}
		else
		{
			monModule.gCPT = "";
		}
		Close();
	}

	private void frmComptes_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Modifiers == Keys.None && e.KeyCode == Keys.Escape)
		{
			monModule.gCPT = "";
			Close();
		}
	}

	private void simpleButton21_Click(object sender, EventArgs e)
	{
		string maxVal = dataSet1.Comptes.Compute("max([CPT])", string.Empty).ToString();
		DataRowView obj = (DataRowView)bindingSource1.AddNew();
		string x = (string)(obj["CPT"] = monModule.Suivant(maxVal));
		obj["IMPUT"] = "O";
		bindingSource1.EndEdit();
		comptesTableAdapter.Update(dataSet1.Comptes);
		dataSet1.Comptes.AcceptChanges();
		Rafraichir();
		bindingSource1.Position = bindingSource1.Find("CPT", x);
	}

	private void txtLIB1_Enter(object sender, EventArgs e)
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

	private void txtLIB1_Leave(object sender, EventArgs e)
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
		this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
		this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
		this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIBAR = new DevExpress.XtraGrid.Columns.GridColumn();
		this.IMPUT = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.txtCPT = new DevExpress.XtraEditors.TextEdit();
		this.txtLIB = new DevExpress.XtraEditors.TextEdit();
		this.txtTAG = new DevExpress.XtraEditors.TextEdit();
		this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.TRSComboBoxEdit = new DevExpress.XtraEditors.CheckEdit();
		this.IMPUTComboBoxEdit = new DevExpress.XtraEditors.CheckEdit();
		this.IMMOComboBoxEdit = new DevExpress.XtraEditors.CheckEdit();
		this.ANAComboBoxEdit = new DevExpress.XtraEditors.CheckEdit();
		this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton21 = new DevExpress.XtraEditors.SimpleButton();
		this.txtLIB1 = new DevExpress.XtraEditors.TextEdit();
		this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForCPT = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForTRS = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForIMPUT = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForANA = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForTAG = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForIMMO = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIB = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIB1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.comptesTableAdapter = new compta.DataSet1TableAdapters.ComptesTableAdapter();
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).BeginInit();
		this.dataLayoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.checkEdit3.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.checkEdit2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.checkEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtCPT.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtLIB.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtTAG.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TRSComboBoxEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IMPUTComboBoxEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IMMOComboBoxEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ANAComboBoxEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.txtLIB1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCPT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTRS).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForIMPUT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForANA).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTAG).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForIMMO).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).BeginInit();
		base.SuspendLayout();
		this.dataLayoutControl1.Controls.Add(this.checkEdit3);
		this.dataLayoutControl1.Controls.Add(this.checkEdit2);
		this.dataLayoutControl1.Controls.Add(this.checkEdit1);
		this.dataLayoutControl1.Controls.Add(this.GridControl1);
		this.dataLayoutControl1.Controls.Add(this.txtCPT);
		this.dataLayoutControl1.Controls.Add(this.txtLIB);
		this.dataLayoutControl1.Controls.Add(this.txtTAG);
		this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
		this.dataLayoutControl1.Controls.Add(this.TRSComboBoxEdit);
		this.dataLayoutControl1.Controls.Add(this.IMPUTComboBoxEdit);
		this.dataLayoutControl1.Controls.Add(this.IMMOComboBoxEdit);
		this.dataLayoutControl1.Controls.Add(this.ANAComboBoxEdit);
		this.dataLayoutControl1.Controls.Add(this.simpleButton4);
		this.dataLayoutControl1.Controls.Add(this.simpleButton11);
		this.dataLayoutControl1.Controls.Add(this.simpleButton3);
		this.dataLayoutControl1.Controls.Add(this.simpleButton21);
		this.dataLayoutControl1.Controls.Add(this.txtLIB1);
		this.dataLayoutControl1.DataSource = this.bindingSource1;
		this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.ItemForID, this.layoutControlItem2, this.layoutControlItem4 });
		this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
		this.dataLayoutControl1.Name = "dataLayoutControl1";
		this.dataLayoutControl1.Root = this.Root;
		this.dataLayoutControl1.Size = new System.Drawing.Size(674, 533);
		this.dataLayoutControl1.TabIndex = 0;
		this.dataLayoutControl1.Text = "dataLayoutControl1";
		this.checkEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "PROD", true));
		this.checkEdit3.EditValue = null;
		this.checkEdit3.Location = new System.Drawing.Point(24, 211);
		this.checkEdit3.Name = "checkEdit3";
		this.checkEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
		this.checkEdit3.Properties.Caption = "Prod. Excep.";
		this.checkEdit3.Properties.ValueChecked = "O";
		this.checkEdit3.Properties.ValueUnchecked = "N";
		this.checkEdit3.Size = new System.Drawing.Size(626, 19);
		this.checkEdit3.StyleController = this.dataLayoutControl1;
		this.checkEdit3.TabIndex = 81;
		this.checkEdit3.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(TRSComboBoxEdit_QueryCheckStateByValue);
		this.checkEdit3.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(TRSComboBoxEdit_QueryValueByCheckState);
		this.bindingSource1.DataMember = "Comptes";
		this.bindingSource1.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.checkEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "DOT", true));
		this.checkEdit2.EditValue = null;
		this.checkEdit2.Location = new System.Drawing.Point(532, 113);
		this.checkEdit2.Name = "checkEdit2";
		this.checkEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
		this.checkEdit2.Properties.Caption = "Dotation";
		this.checkEdit2.Properties.ValueChecked = "O";
		this.checkEdit2.Properties.ValueUnchecked = "N";
		this.checkEdit2.Size = new System.Drawing.Size(125, 19);
		this.checkEdit2.StyleController = this.dataLayoutControl1;
		this.checkEdit2.TabIndex = 80;
		this.checkEdit2.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(TRSComboBoxEdit_QueryCheckStateByValue);
		this.checkEdit2.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(TRSComboBoxEdit_QueryValueByCheckState);
		this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "AMOR", true));
		this.checkEdit1.EditValue = null;
		this.checkEdit1.Location = new System.Drawing.Point(24, 211);
		this.checkEdit1.Name = "checkEdit1";
		this.checkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
		this.checkEdit1.Properties.Caption = "Amorissement";
		this.checkEdit1.Properties.ValueChecked = "O";
		this.checkEdit1.Properties.ValueUnchecked = "N";
		this.checkEdit1.Size = new System.Drawing.Size(314, 19);
		this.checkEdit1.StyleController = this.dataLayoutControl1;
		this.checkEdit1.TabIndex = 79;
		this.checkEdit1.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(TRSComboBoxEdit_QueryCheckStateByValue);
		this.checkEdit1.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(TRSComboBoxEdit_QueryValueByCheckState);
		this.GridControl1.DataSource = this.bindingSource1;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(12, 141);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(650, 332);
		this.GridControl1.TabIndex = 44;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.GridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(GridControl1_KeyDown);
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[4] { this.colUNI, this.colLIB, this.colLIBAR, this.IMPUT });
		this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(319, -670, 498, 610);
		this.gridView1.DetailHeight = 801;
		this.gridView1.FixedLineWidth = 1;
		this.gridView1.GridControl = this.GridControl1;
		this.gridView1.Name = "gridView1";
		this.gridView1.OptionsBehavior.Editable = false;
		this.gridView1.OptionsBehavior.ReadOnly = true;
		this.gridView1.OptionsCustomization.AllowGroup = false;
		this.gridView1.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.StartsWith;
		this.gridView1.OptionsFind.FindNullPrompt = "";
		this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
		this.gridView1.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
		this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
		this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
		this.gridView1.OptionsView.ColumnAutoWidth = false;
		this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
		this.gridView1.OptionsView.EnableAppearanceOddRow = true;
		this.gridView1.OptionsView.ShowDetailButtons = false;
		this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
		this.gridView1.OptionsView.ShowFooter = true;
		this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
		this.gridView1.OptionsView.ShowGroupPanel = false;
		this.gridView1.OptionsView.ShowIndicator = false;
		this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(GridView1_FocusedRowChanged);
		this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(gridView1_FocusedRowObjectChanged);
		this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(gridView1_KeyDown);
		this.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);
		this.colUNI.AppearanceCell.Options.UseTextOptions = true;
		this.colUNI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.AppearanceHeader.Options.UseTextOptions = true;
		this.colUNI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.Caption = "Compte";
		this.colUNI.FieldName = "CPT";
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
		this.colLIB.Width = 260;
		this.colLIBAR.AppearanceCell.Options.UseTextOptions = true;
		this.colLIBAR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.colLIBAR.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIBAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIBAR.Caption = "Intitulé en Arabe";
		this.colLIBAR.FieldName = "LIBAR";
		this.colLIBAR.MinWidth = 15;
		this.colLIBAR.Name = "colLIBAR";
		this.colLIBAR.Visible = true;
		this.colLIBAR.VisibleIndex = 2;
		this.colLIBAR.Width = 309;
		this.IMPUT.FieldName = "IMPUT";
		this.IMPUT.MinWidth = 15;
		this.IMPUT.Name = "IMPUT";
		this.IMPUT.Width = 56;
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
		this.txtCPT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CPT", true));
		this.txtCPT.EnterMoveNextControl = true;
		this.txtCPT.Location = new System.Drawing.Point(52, 12);
		this.txtCPT.Name = "txtCPT";
		this.txtCPT.Properties.Appearance.Options.UseTextOptions = true;
		this.txtCPT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtCPT.Size = new System.Drawing.Size(261, 20);
		this.txtCPT.StyleController = this.dataLayoutControl1;
		this.txtCPT.TabIndex = 4;
		this.txtCPT.KeyDown += new System.Windows.Forms.KeyEventHandler(txtCPT_KeyDown);
		this.txtLIB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIB", true));
		this.txtLIB.EnterMoveNextControl = true;
		this.txtLIB.Location = new System.Drawing.Point(49, 36);
		this.txtLIB.Name = "txtLIB";
		this.txtLIB.Size = new System.Drawing.Size(613, 20);
		this.txtLIB.StyleController = this.dataLayoutControl1;
		this.txtLIB.TabIndex = 5;
		this.txtLIB.KeyDown += new System.Windows.Forms.KeyEventHandler(txtLIB_KeyDown);
		this.txtTAG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "TAG", true));
		this.txtTAG.EnterMoveNextControl = true;
		this.txtTAG.Location = new System.Drawing.Point(340, 12);
		this.txtTAG.Name = "txtTAG";
		this.txtTAG.Properties.Appearance.Options.UseTextOptions = true;
		this.txtTAG.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.txtTAG.Size = new System.Drawing.Size(322, 20);
		this.txtTAG.StyleController = this.dataLayoutControl1;
		this.txtTAG.TabIndex = 10;
		this.txtTAG.KeyDown += new System.Windows.Forms.KeyEventHandler(txtTAG_KeyDown);
		this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ID", true));
		this.IDTextEdit.Location = new System.Drawing.Point(40, 6);
		this.IDTextEdit.Name = "IDTextEdit";
		this.IDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.IDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.IDTextEdit.Properties.Mask.EditMask = "N0";
		this.IDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.IDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.IDTextEdit.Size = new System.Drawing.Size(861, 20);
		this.IDTextEdit.StyleController = this.dataLayoutControl1;
		this.IDTextEdit.TabIndex = 11;
		this.TRSComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "TRS", true));
		this.TRSComboBoxEdit.EditValue = null;
		this.TRSComboBoxEdit.Location = new System.Drawing.Point(17, 113);
		this.TRSComboBoxEdit.Name = "TRSComboBoxEdit";
		this.TRSComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
		this.TRSComboBoxEdit.Properties.Caption = "Tiers";
		this.TRSComboBoxEdit.Size = new System.Drawing.Size(125, 19);
		this.TRSComboBoxEdit.StyleController = this.dataLayoutControl1;
		this.TRSComboBoxEdit.TabIndex = 7;
		this.TRSComboBoxEdit.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(TRSComboBoxEdit_QueryCheckStateByValue);
		this.TRSComboBoxEdit.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(TRSComboBoxEdit_QueryValueByCheckState);
		this.IMPUTComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "IMPUT", true));
		this.IMPUTComboBoxEdit.EditValue = null;
		this.IMPUTComboBoxEdit.Location = new System.Drawing.Point(146, 113);
		this.IMPUTComboBoxEdit.Name = "IMPUTComboBoxEdit";
		this.IMPUTComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
		this.IMPUTComboBoxEdit.Properties.Caption = "Imputation";
		this.IMPUTComboBoxEdit.Size = new System.Drawing.Size(125, 19);
		this.IMPUTComboBoxEdit.StyleController = this.dataLayoutControl1;
		this.IMPUTComboBoxEdit.TabIndex = 6;
		this.IMPUTComboBoxEdit.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(TRSComboBoxEdit_QueryCheckStateByValue);
		this.IMPUTComboBoxEdit.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(TRSComboBoxEdit_QueryValueByCheckState);
		this.IMMOComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "IMMO", true));
		this.IMMOComboBoxEdit.EditValue = null;
		this.IMMOComboBoxEdit.Location = new System.Drawing.Point(275, 113);
		this.IMMOComboBoxEdit.Name = "IMMOComboBoxEdit";
		this.IMMOComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
		this.IMMOComboBoxEdit.Properties.Caption = "Immobilisation";
		this.IMMOComboBoxEdit.Properties.ValueChecked = "O";
		this.IMMOComboBoxEdit.Properties.ValueUnchecked = "N";
		this.IMMOComboBoxEdit.Size = new System.Drawing.Size(125, 19);
		this.IMMOComboBoxEdit.StyleController = this.dataLayoutControl1;
		this.IMMOComboBoxEdit.TabIndex = 9;
		this.IMMOComboBoxEdit.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(TRSComboBoxEdit_QueryCheckStateByValue);
		this.IMMOComboBoxEdit.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(TRSComboBoxEdit_QueryValueByCheckState);
		this.ANAComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "ANA", true));
		this.ANAComboBoxEdit.EditValue = null;
		this.ANAComboBoxEdit.Location = new System.Drawing.Point(404, 113);
		this.ANAComboBoxEdit.Name = "ANAComboBoxEdit";
		this.ANAComboBoxEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
		this.ANAComboBoxEdit.Properties.Caption = "Analyse";
		this.ANAComboBoxEdit.Size = new System.Drawing.Size(124, 19);
		this.ANAComboBoxEdit.StyleController = this.dataLayoutControl1;
		this.ANAComboBoxEdit.TabIndex = 8;
		this.ANAComboBoxEdit.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(TRSComboBoxEdit_QueryCheckStateByValue);
		this.ANAComboBoxEdit.QueryValueByCheckState += new DevExpress.XtraEditors.Controls.QueryValueByCheckStateEventHandler(TRSComboBoxEdit_QueryValueByCheckState);
		this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton4.Location = new System.Drawing.Point(513, 488);
		this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton4.Name = "simpleButton4";
		this.simpleButton4.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton4.Size = new System.Drawing.Size(119, 22);
		this.simpleButton4.StyleController = this.dataLayoutControl1;
		this.simpleButton4.TabIndex = 78;
		this.simpleButton4.Text = "Imprimer";
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(42, 488);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton11.Size = new System.Drawing.Size(117, 22);
		this.simpleButton11.StyleController = this.dataLayoutControl1;
		this.simpleButton11.TabIndex = 75;
		this.simpleButton11.Text = "Enregistrer";
		this.simpleButton11.Click += new System.EventHandler(bindingNavigatorSaveItem_Click);
		this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton3.Location = new System.Drawing.Point(356, 488);
		this.simpleButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton3.Name = "simpleButton3";
		this.simpleButton3.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton3.Size = new System.Drawing.Size(117, 22);
		this.simpleButton3.StyleController = this.dataLayoutControl1;
		this.simpleButton3.TabIndex = 77;
		this.simpleButton3.Text = "Supprimer";
		this.simpleButton21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton21.Location = new System.Drawing.Point(199, 488);
		this.simpleButton21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton21.Name = "simpleButton21";
		this.simpleButton21.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton21.Size = new System.Drawing.Size(117, 22);
		this.simpleButton21.StyleController = this.dataLayoutControl1;
		this.simpleButton21.TabIndex = 76;
		this.simpleButton21.Text = "Ajouter";
		this.simpleButton21.Click += new System.EventHandler(simpleButton21_Click);
		this.txtLIB1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "LIBAR", true));
		this.txtLIB1.EnterMoveNextControl = true;
		this.txtLIB1.Location = new System.Drawing.Point(81, 60);
		this.txtLIB1.Name = "txtLIB1";
		this.txtLIB1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
		this.txtLIB1.Properties.Appearance.Options.UseFont = true;
		this.txtLIB1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.txtLIB1.Size = new System.Drawing.Size(581, 24);
		this.txtLIB1.StyleController = this.dataLayoutControl1;
		this.txtLIB1.TabIndex = 5;
		this.txtLIB1.Enter += new System.EventHandler(txtLIB1_Enter);
		this.txtLIB1.Leave += new System.EventHandler(txtLIB1_Leave);
		this.ItemForID.Control = this.IDTextEdit;
		this.ItemForID.Location = new System.Drawing.Point(0, 0);
		this.ItemForID.Name = "ItemForID";
		this.ItemForID.Size = new System.Drawing.Size(897, 22);
		this.ItemForID.Text = "ID";
		this.ItemForID.TextSize = new System.Drawing.Size(50, 20);
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup1, this.layoutControlGroup5 });
		this.Root.Name = "Root";
		this.Root.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
		this.Root.Size = new System.Drawing.Size(674, 533);
		this.Root.TextVisible = false;
		this.layoutControlGroup1.AllowDrawBackground = false;
		this.layoutControlGroup1.GroupBordersVisible = false;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[6] { this.ItemForCPT, this.layoutControlItem1, this.layoutControlGroup2, this.ItemForLIB, this.ItemForLIB1, this.ItemForTAG });
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup1.Name = "autoGeneratedGroup0";
		this.layoutControlGroup1.Size = new System.Drawing.Size(654, 465);
		this.ItemForCPT.Control = this.txtCPT;
		this.ItemForCPT.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForCPT.Location = new System.Drawing.Point(0, 0);
		this.ItemForCPT.MinSize = new System.Drawing.Size(94, 24);
		this.ItemForCPT.Name = "ItemForCPT";
		this.ItemForCPT.Size = new System.Drawing.Size(305, 24);
		this.ItemForCPT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
		this.ItemForCPT.Text = "Compte";
		this.ItemForCPT.TextSize = new System.Drawing.Size(37, 13);
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(0, 129);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(654, 336);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[5] { this.ItemForTRS, this.ItemForIMPUT, this.ItemForANA, this.ItemForIMMO, this.layoutControlItem3 });
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 76);
		this.layoutControlGroup2.Name = "layoutControlGroup2";
		this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
		this.layoutControlGroup2.Size = new System.Drawing.Size(654, 53);
		this.layoutControlGroup2.Text = "Compte soumis à ";
		this.ItemForTRS.Control = this.TRSComboBoxEdit;
		this.ItemForTRS.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForTRS.Location = new System.Drawing.Point(0, 0);
		this.ItemForTRS.Name = "ItemForTRS";
		this.ItemForTRS.Size = new System.Drawing.Size(129, 23);
		this.ItemForTRS.Text = "Tiers";
		this.ItemForTRS.TextSize = new System.Drawing.Size(0, 0);
		this.ItemForTRS.TextVisible = false;
		this.ItemForIMPUT.Control = this.IMPUTComboBoxEdit;
		this.ItemForIMPUT.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForIMPUT.Location = new System.Drawing.Point(129, 0);
		this.ItemForIMPUT.Name = "ItemForIMPUT";
		this.ItemForIMPUT.Size = new System.Drawing.Size(129, 23);
		this.ItemForIMPUT.Text = "Imputation";
		this.ItemForIMPUT.TextSize = new System.Drawing.Size(0, 0);
		this.ItemForIMPUT.TextVisible = false;
		this.ItemForANA.Control = this.ANAComboBoxEdit;
		this.ItemForANA.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForANA.Location = new System.Drawing.Point(387, 0);
		this.ItemForANA.Name = "ItemForANA";
		this.ItemForANA.Size = new System.Drawing.Size(128, 23);
		this.ItemForANA.Text = "Analytique";
		this.ItemForANA.TextSize = new System.Drawing.Size(0, 0);
		this.ItemForANA.TextVisible = false;
		this.ItemForTAG.Control = this.txtTAG;
		this.ItemForTAG.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForTAG.Location = new System.Drawing.Point(305, 0);
		this.ItemForTAG.Name = "ItemForTAG";
		this.ItemForTAG.Size = new System.Drawing.Size(349, 24);
		this.ItemForTAG.Text = "TAG";
		this.ItemForTAG.TextSize = new System.Drawing.Size(20, 13);
		this.ItemForIMMO.Control = this.IMMOComboBoxEdit;
		this.ItemForIMMO.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForIMMO.Location = new System.Drawing.Point(258, 0);
		this.ItemForIMMO.Name = "ItemForIMMO";
		this.ItemForIMMO.Size = new System.Drawing.Size(129, 23);
		this.ItemForIMMO.Text = "Immobilisation";
		this.ItemForIMMO.TextSize = new System.Drawing.Size(0, 0);
		this.ItemForIMMO.TextVisible = false;
		this.layoutControlItem2.Control = this.checkEdit1;
		this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(318, 23);
		this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem2.TextVisible = false;
		this.layoutControlItem3.Control = this.checkEdit2;
		this.layoutControlItem3.Location = new System.Drawing.Point(515, 0);
		this.layoutControlItem3.Name = "layoutControlItem3";
		this.layoutControlItem3.Size = new System.Drawing.Size(129, 23);
		this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem3.TextVisible = false;
		this.layoutControlItem4.Control = this.checkEdit3;
		this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem4.Name = "layoutControlItem4";
		this.layoutControlItem4.Size = new System.Drawing.Size(630, 23);
		this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem4.TextVisible = false;
		this.ItemForLIB.Control = this.txtLIB;
		this.ItemForLIB.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForLIB.Location = new System.Drawing.Point(0, 24);
		this.ItemForLIB.Name = "ItemForLIB";
		this.ItemForLIB.Size = new System.Drawing.Size(654, 24);
		this.ItemForLIB.Text = "Intitulé";
		this.ItemForLIB.TextSize = new System.Drawing.Size(34, 13);
		this.ItemForLIB1.Control = this.txtLIB1;
		this.ItemForLIB1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForLIB1.CustomizationFormText = "Intitulé";
		this.ItemForLIB1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.True;
		this.ItemForLIB1.Location = new System.Drawing.Point(0, 48);
		this.ItemForLIB1.Name = "ItemForLIB1";
		this.ItemForLIB1.Size = new System.Drawing.Size(654, 28);
		this.ItemForLIB1.Text = "Intitulé Arabe";
		this.ItemForLIB1.TextSize = new System.Drawing.Size(66, 13);
		this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.layoutControlItem16, this.layoutControlItem17, this.layoutControlItem21, this.layoutControlItem22 });
		this.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup5.Location = new System.Drawing.Point(0, 465);
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
		this.layoutControlGroup5.Size = new System.Drawing.Size(654, 48);
		this.layoutControlGroup5.Text = "layoutControlGroup1";
		this.layoutControlGroup5.TextVisible = false;
		this.layoutControlItem16.Control = this.simpleButton4;
		this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem16.CustomizationFormText = "layoutControlItem10";
		this.layoutControlItem16.Location = new System.Drawing.Point(471, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 3;
		this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem16.Size = new System.Drawing.Size(159, 24);
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
		this.layoutControlItem17.Size = new System.Drawing.Size(157, 24);
		this.layoutControlItem17.Text = "layoutControlItem7";
		this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem17.TextVisible = false;
		this.layoutControlItem21.Control = this.simpleButton3;
		this.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem21.CustomizationFormText = "layoutControlItem9";
		this.layoutControlItem21.Location = new System.Drawing.Point(314, 0);
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
		this.layoutControlItem21.Click += new System.EventHandler(bindingNavigatorDeleteItem_Click);
		this.layoutControlItem22.Control = this.simpleButton21;
		this.layoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem22.CustomizationFormText = "layoutControlItem8";
		this.layoutControlItem22.Location = new System.Drawing.Point(157, 0);
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
		this.comptesTableAdapter.ClearBeforeFill = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(674, 533);
		base.Controls.Add(this.dataLayoutControl1);
		base.IconOptions.Image = compta.Properties.Resources.map_32x32;
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmComptes";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Plan Comptable";
		base.Activated += new System.EventHandler(frmComptes_Activated);
		base.Load += new System.EventHandler(frmComptes_Load);
		base.KeyDown += new System.Windows.Forms.KeyEventHandler(frmComptes_KeyDown);
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).EndInit();
		this.dataLayoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.checkEdit3.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.checkEdit2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.checkEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtCPT.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtLIB.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtTAG.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TRSComboBoxEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IMPUTComboBoxEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IMMOComboBoxEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ANAComboBoxEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.txtLIB1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCPT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTRS).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForIMPUT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForANA).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForTAG).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForIMMO).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).EndInit();
		base.ResumeLayout(false);
	}
}
