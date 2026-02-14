using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

public class frmAmortissement : XtraForm
{
	private string gMAT = "";

	private DataTable dtt;

	private bool _add;

	private DataSet1.ComptesDataTable amortab = new DataSet1.ComptesDataTable();

	private DataSet1.ComptesDataTable prodtab = new DataSet1.ComptesDataTable();

	private DataSet1.ComptesDataTable imotab = new DataSet1.ComptesDataTable();

	private DataSet1.ComptesDataTable dottab = new DataSet1.ComptesDataTable();

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

	private GridColumn colUNI;

	private GridColumn colLIB;

	private GridColumn colACT;

	private TextEdit UNITextEdit;

	private TextEdit textEdit1;

	private TextEdit textEdit7;

	private TextEdit textEdit10;

	private LayoutControlItem layoutControlItem6;

	private LayoutControlItem layoutControlItem8;

	private LayoutControlItem layoutControlItem9;

	private LayoutControlItem layoutControlItem12;

	private DataSet1 dataSet1;

	private LayoutControlItem layoutControlItem11;

	private BindingSource immoBindingSource;

	private ImmoTableAdapter immoTableAdapter;

	private DateEdit dateACQ;

	private TextEdit lookUpEdit2;

	private SpinEdit textEdit4;

	private DateEdit textEdit6;

	private SimpleButton simpleButton4;

	private SimpleButton simpleButton11;

	private SimpleButton simpleButton3;

	private SimpleButton simpleButton21;

	private LayoutControlGroup layoutControlGroup5;

	private LayoutControlItem layoutControlItem16;

	private LayoutControlItem layoutControlItem17;

	private LayoutControlItem layoutControlItem21;

	private LayoutControlItem layoutControlItem22;

	internal GridControl gridControl2;

	internal GridView gridView2;

	private GridColumn gridColumn1;

	private GridColumn gridColumn2;

	private GridColumn gridColumn3;

	private GridColumn gridColumn4;

	private GridColumn gridColumn5;

	internal GridView gridView4;

	private SpinEdit tauxAM;

	private TabbedControlGroup tabbedControlGroup1;

	private LayoutControlGroup layoutControlGroup2;

	private LayoutControlItem layoutControlItem2;

	private LayoutControlGroup layoutControlGroup4;

	private LayoutControlItem ItemForLIB;

	private LayoutControlItem ItemForADR;

	private LayoutControlItem ItemForUNI;

	private LayoutControlItem ItemForCodeActivite;

	private LayoutControlItem ItemForACT;

	private LayoutControlItem ItemForACT1;

	private LayoutControlItem ItemForACT2;

	private GridColumn colDATSOR;

	private SpinEdit mtACQ;

	private LayoutControlItem ItemForADR1;

	private SpinEdit mtACQ1;

	private LayoutControlItem ItemForADR2;

	private SpinEdit mtAMORANT;

	private LayoutControlItem ItemForADR3;

	private SearchLookUpEdit cptimo;

	private GridView searchLookUpEdit1View;

	private SearchLookUpEdit cptamor;

	private GridView gridView5;

	private SearchLookUpEdit cptdot;

	private GridView gridView6;

	private SearchLookUpEdit cptprod;

	private GridView gridView61;

	private LayoutControlItem ItemForACT3;

	private LayoutControlGroup layoutControlGroup3;

	private LayoutControlGroup layoutControlGroup7;

	private LayoutControlGroup layoutControlGroup6;

	private BindingSource comptesBindingSource;

	private ComptesTableAdapter comptesTableAdapter;

	private GridColumn gridColumn6;

	private GridColumn gridColumn7;

	private GridColumn gridColumn8;

	private GridColumn gridColumn9;

	private GridColumn gridColumn12;

	private GridColumn gridColumn13;

	private GridColumn gridColumn10;

	private GridColumn gridColumn11;

	private EmptySpaceItem emptySpaceItem3;

	private EmptySpaceItem emptySpaceItem2;

	private EmptySpaceItem emptySpaceItem4;

	private EmptySpaceItem emptySpaceItem1;

	public frmAmortissement(bool add = false)
	{
		InitializeComponent();
		_add = add;
	}

	private void frmAmortissement_Load(object sender, EventArgs e)
	{
		string connection = ConfigurationManager.ConnectionStrings["MyBase"].ConnectionString;
		comptesTableAdapter.Connection.ConnectionString = connection;
		comptesTableAdapter.FillByAMOR(amortab);
		comptesTableAdapter.FillByProd(prodtab);
		comptesTableAdapter.FillByDot(dottab);
		comptesTableAdapter.FillByIMO(imotab);
		cptimo.Properties.DataSource = imotab;
		cptamor.Properties.DataSource = amortab;
		cptprod.Properties.DataSource = prodtab;
		cptdot.Properties.DataSource = dottab;
		immoTableAdapter.Connection.ConnectionString = connection;
		immoTableAdapter.FillBy(dataSet1.Immo, monModule.gUNI);
		dataSet1.Immo.Columns["UNI"].DefaultValue = monModule.gUNI;
		gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
		dtt = new DataTable("tableau");
		dtt.Columns.Add("annee", typeof(int));
		dtt.Columns.Add("base", typeof(decimal));
		dtt.Columns.Add("annuite", typeof(decimal));
		dtt.Columns.Add("cumul", typeof(decimal));
		dtt.Columns.Add("vnc", typeof(decimal));
		gridControl2.DataSource = dtt;
		if (_add)
		{
			bindingNavigatorAddNewItem_Click_1(null, null);
			gridView1.Focus();
			gridView1.MoveLast();
		}
	}

	private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
	{
		try
		{
			immoBindingSource.EndEdit();
			immoTableAdapter.Update(dataSet1.Immo);
			dataSet1.Immo.AcceptChanges();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			dataSet1.Immo.RejectChanges();
		}
	}

	private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
	{
		string maxVal = dataSet1.Immo.Compute("max([MAT])", "UNI='" + monModule.gUNI + "'").ToString();
		DataRowView obj = (DataRowView)immoBindingSource.AddNew();
		obj["MAT"] = ((maxVal == string.Empty) ? "000001" : monModule.Suivant(maxVal));
		obj["DATACQ"] = DateTime.Today;
		obj["TX"] = 20;
		obj["MTACQ"] = 0;
		obj["TVA"] = 0;
		obj["MTANT"] = 0;
		obj["MTCES"] = 0;
		obj["CPT"] = monModule.GetFirstID(imotab, "CPT");
		obj["CPTAMOR"] = monModule.GetFirstID(amortab, "CPT");
		obj["CPTDOT"] = monModule.GetFirstID(dottab, "CPT");
		obj["CPTPROD"] = monModule.GetFirstID(prodtab, "CPT");
		immoBindingSource.EndEdit();
		immoTableAdapter.Update(dataSet1.Immo);
		dataSet1.Immo.AcceptChanges();
		immoBindingSource.MoveLast();
		Rafraichir();
	}

	private void Rafraichir()
	{
		if (dataSet1.Immo != null)
		{
			int pos = immoBindingSource.Position;
			dataSet1.Immo.Clear();
			immoTableAdapter.FillBy(dataSet1.Immo, monModule.gUNI);
			immoBindingSource.Position = pos;
		}
	}

	private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Etes-vous sûr de vouloir supprimer l'enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.Yes)
		{
			try
			{
				immoBindingSource.RemoveCurrent();
				immoBindingSource.ResetCurrentItem();
				immoBindingSource.EndEdit();
				immoTableAdapter.Adapter.Update(dataSet1.Immo);
				dataSet1.Immo.AcceptChanges();
			}
			catch (Exception ex)
			{
				dataSet1.Immo.RejectChanges();
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void GridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
	{
		dataSet1.Immo.RejectChanges();
	}

	private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
	{
		object t = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAT");
		gMAT = ((t == null) ? "" : t.ToString());
		if (tabbedControlGroup1.SelectedTabPageIndex == 1)
		{
			double vacq = Convert.ToDouble(mtACQ.EditValue);
			if (dateACQ.EditValue != DBNull.Value)
			{
				DateTime dateacq = Convert.ToDateTime(dateACQ.EditValue);
				int an = 2013;
				double taux = Convert.ToDouble(tauxAM.EditValue);
				VNCFE(dateacq, vacq, taux, an);
			}
		}
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

	private double Days360(DateTime StartDate, DateTime EndDate)
	{
		int StartDay = StartDate.Day;
		int StartMonth = StartDate.Month;
		int StartYear = StartDate.Year;
		int EndDay = EndDate.Day;
		int EndMonth = EndDate.Month;
		int year = EndDate.Year;
		if (StartDay == 31 || IsLastDayOfFebruary(StartDate))
		{
			StartDay = 30;
		}
		if (StartDay == 30 && EndDay == 31)
		{
			EndDay = 30;
		}
		return (year - StartYear) * 360 + (EndMonth - StartMonth) * 30 + (EndDay - StartDay);
	}

	private bool IsLastDayOfFebruary(DateTime date)
	{
		if (date.Month == 2)
		{
			return date.Day == DateTime.DaysInMonth(date.Year, date.Month);
		}
		return false;
	}

	private double VNCFE(DateTime d0, double basecalcul, double taux, int an)
	{
		dtt.Clear();
		if (taux == 0.0)
		{
			return 0.0;
		}
		DateTime dateMES = d0;
		double amortant = Convert.ToDouble(mtAMORANT.EditValue);
		basecalcul -= amortant;
		DateTime dateFIN = DateTime.ParseExact("31-12-" + dateMES.Year, "dd-MM-yyyy", null);
		double annuite = monModule.SRound(basecalcul * taux / 100.0, 2);
		double premiereAnnuite = monModule.SRound(annuite * Days360(dateMES, dateFIN) / 360.0, 2);
		int i = dateMES.Year;
		int j = an;
		j = 9999;
		double cuamort = premiereAnnuite + amortant;
		double VNC = basecalcul - premiereAnnuite;
		dtt.Rows.Add(i, basecalcul, premiereAnnuite, cuamort, VNC);
		while (i < j && VNC > 0.0)
		{
			double X = ((!(VNC < annuite)) ? annuite : VNC);
			cuamort += X;
			VNC -= X;
			i++;
			dtt.Rows.Add(i, basecalcul, X, cuamort, VNC);
		}
		if (i == j)
		{
			return VNC;
		}
		return 0.0;
	}

	private void simpleButton4_Click(object sender, EventArgs e)
	{
		double vacq = Convert.ToDouble(mtACQ.EditValue);
		DateTime dateacq = Convert.ToDateTime(dateACQ.EditValue);
		int an = 2013;
		double taux = Convert.ToDouble(tauxAM.EditValue);
		VNCFE(dateacq, vacq, taux, an);
	}

	private void tabbedControlGroup1_SelectedPageChanged(object sender, LayoutTabPageChangedEventArgs e)
	{
		if (tabbedControlGroup1.SelectedTabPageIndex == 1)
		{
			double vacq = Convert.ToDouble(mtACQ.EditValue);
			if (dateACQ.EditValue != DBNull.Value)
			{
				DateTime dateacq = Convert.ToDateTime(dateACQ.EditValue);
				int an = 2013;
				double taux = Convert.ToDouble(tauxAM.EditValue);
				VNCFE(dateacq, vacq, taux, an);
			}
		}
	}

	private void fillByAMORToolStripButton_Click(object sender, EventArgs e)
	{
		try
		{
			comptesTableAdapter.FillByAMOR(dataSet1.Comptes);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void fillByIMOToolStripButton_Click(object sender, EventArgs e)
	{
		try
		{
			comptesTableAdapter.FillByIMO(dataSet1.Comptes);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void fillByProdToolStripButton_Click(object sender, EventArgs e)
	{
		try
		{
			comptesTableAdapter.FillByProd(dataSet1.Comptes);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void fillByDotToolStripButton_Click(object sender, EventArgs e)
	{
		try
		{
			comptesTableAdapter.FillByDot(dataSet1.Comptes);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
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
		this.gridControl2 = new DevExpress.XtraGrid.GridControl();
		this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.GridControl1 = new DevExpress.XtraGrid.GridControl();
		this.immoBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.dataSet1 = new compta.DataSet1();
		this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.colUNI = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colLIB = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colACT = new DevExpress.XtraGrid.Columns.GridColumn();
		this.colDATSOR = new DevExpress.XtraGrid.Columns.GridColumn();
		this.GridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
		this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
		this.UNITextEdit = new DevExpress.XtraEditors.TextEdit();
		this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
		this.dateACQ = new DevExpress.XtraEditors.DateEdit();
		this.lookUpEdit2 = new DevExpress.XtraEditors.TextEdit();
		this.textEdit4 = new DevExpress.XtraEditors.SpinEdit();
		this.textEdit6 = new DevExpress.XtraEditors.DateEdit();
		this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
		this.simpleButton21 = new DevExpress.XtraEditors.SimpleButton();
		this.tauxAM = new DevExpress.XtraEditors.SpinEdit();
		this.mtACQ = new DevExpress.XtraEditors.SpinEdit();
		this.mtACQ1 = new DevExpress.XtraEditors.SpinEdit();
		this.mtAMORANT = new DevExpress.XtraEditors.SpinEdit();
		this.cptimo = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.comptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.cptamor = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.cptdot = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.cptprod = new DevExpress.XtraEditors.SearchLookUpEdit();
		this.gridView61 = new DevExpress.XtraGrid.Views.Grid.GridView();
		this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
		this.ItemForID = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
		this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
		this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForADR = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForADR1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForADR2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForADR3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForUNI = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForLIB = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForCodeActivite = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.ItemForACT = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForACT1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForACT2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.ItemForACT3 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
		this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
		this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
		this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
		this.immoTableAdapter = new compta.DataSet1TableAdapters.ImmoTableAdapter();
		this.comptesTableAdapter = new compta.DataSet1TableAdapters.ComptesTableAdapter();
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).BeginInit();
		this.dataLayoutControl1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.gridControl2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.immoBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit7.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit10.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dateACQ.Properties.CalendarTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dateACQ.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.lookUpEdit2.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit4.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit6.Properties.CalendarTimeProperties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit6.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tauxAM.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mtACQ.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mtACQ1.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.mtAMORANT.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.cptimo.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.comptesBindingSource).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.cptamor.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.cptdot.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.cptprod.Properties).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridView61).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem9).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem12).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Root).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.tabbedControlGroup1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCodeActivite).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup7).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem8).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem11).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).BeginInit();
		base.SuspendLayout();
		this.dataLayoutControl1.Controls.Add(this.gridControl2);
		this.dataLayoutControl1.Controls.Add(this.GridControl1);
		this.dataLayoutControl1.Controls.Add(this.IDTextEdit);
		this.dataLayoutControl1.Controls.Add(this.textEdit7);
		this.dataLayoutControl1.Controls.Add(this.textEdit10);
		this.dataLayoutControl1.Controls.Add(this.UNITextEdit);
		this.dataLayoutControl1.Controls.Add(this.textEdit1);
		this.dataLayoutControl1.Controls.Add(this.dateACQ);
		this.dataLayoutControl1.Controls.Add(this.lookUpEdit2);
		this.dataLayoutControl1.Controls.Add(this.textEdit4);
		this.dataLayoutControl1.Controls.Add(this.textEdit6);
		this.dataLayoutControl1.Controls.Add(this.simpleButton4);
		this.dataLayoutControl1.Controls.Add(this.simpleButton11);
		this.dataLayoutControl1.Controls.Add(this.simpleButton3);
		this.dataLayoutControl1.Controls.Add(this.simpleButton21);
		this.dataLayoutControl1.Controls.Add(this.tauxAM);
		this.dataLayoutControl1.Controls.Add(this.mtACQ);
		this.dataLayoutControl1.Controls.Add(this.mtACQ1);
		this.dataLayoutControl1.Controls.Add(this.mtAMORANT);
		this.dataLayoutControl1.Controls.Add(this.cptimo);
		this.dataLayoutControl1.Controls.Add(this.cptamor);
		this.dataLayoutControl1.Controls.Add(this.cptdot);
		this.dataLayoutControl1.Controls.Add(this.cptprod);
		this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.ItemForID, this.layoutControlItem9, this.layoutControlItem12 });
		this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
		this.dataLayoutControl1.Name = "dataLayoutControl1";
		this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(950, 269, 650, 400);
		this.dataLayoutControl1.Root = this.Root;
		this.dataLayoutControl1.Size = new System.Drawing.Size(904, 561);
		this.dataLayoutControl1.TabIndex = 0;
		this.dataLayoutControl1.Text = "dataLayoutControl1";
		this.gridControl2.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.gridControl2.Location = new System.Drawing.Point(126, 44);
		this.gridControl2.MainView = this.gridView2;
		this.gridControl2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.gridControl2.Name = "gridControl2";
		this.gridControl2.Size = new System.Drawing.Size(648, 238);
		this.gridControl2.TabIndex = 79;
		this.gridControl2.TabStop = false;
		this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView2, this.gridView4 });
		this.gridView2.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[5] { this.gridColumn1, this.gridColumn2, this.gridColumn3, this.gridColumn4, this.gridColumn5 });
		this.gridView2.CustomizationFormBounds = new System.Drawing.Rectangle(319, -670, 498, 610);
		this.gridView2.DetailHeight = 801;
		this.gridView2.FixedLineWidth = 1;
		this.gridView2.GridControl = this.gridControl2;
		this.gridView2.Name = "gridView2";
		this.gridView2.OptionsBehavior.Editable = false;
		this.gridView2.OptionsBehavior.ReadOnly = true;
		this.gridView2.OptionsCustomization.AllowGroup = false;
		this.gridView2.OptionsMenu.EnableGroupPanelMenu = false;
		this.gridView2.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
		this.gridView2.OptionsMenu.ShowGroupSortSummaryItems = false;
		this.gridView2.OptionsNavigation.EnterMoveNextColumn = true;
		this.gridView2.OptionsView.ColumnAutoWidth = false;
		this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
		this.gridView2.OptionsView.EnableAppearanceOddRow = true;
		this.gridView2.OptionsView.ShowDetailButtons = false;
		this.gridView2.OptionsView.ShowFooter = true;
		this.gridView2.OptionsView.ShowGroupExpandCollapseButtons = false;
		this.gridView2.OptionsView.ShowGroupPanel = false;
		this.gridView2.OptionsView.ShowIndicator = false;
		this.gridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn1.Caption = "Année";
		this.gridColumn1.FieldName = "annee";
		this.gridColumn1.MinWidth = 15;
		this.gridColumn1.Name = "gridColumn1";
		this.gridColumn1.Visible = true;
		this.gridColumn1.VisibleIndex = 0;
		this.gridColumn1.Width = 70;
		this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn2.Caption = "Base";
		this.gridColumn2.DisplayFormat.FormatString = "f2";
		this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.gridColumn2.FieldName = "base";
		this.gridColumn2.MinWidth = 15;
		this.gridColumn2.Name = "gridColumn2";
		this.gridColumn2.Visible = true;
		this.gridColumn2.VisibleIndex = 1;
		this.gridColumn2.Width = 130;
		this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn3.Caption = "Annuité";
		this.gridColumn3.DisplayFormat.FormatString = "f2";
		this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.gridColumn3.FieldName = "annuite";
		this.gridColumn3.MinWidth = 15;
		this.gridColumn3.Name = "gridColumn3";
		this.gridColumn3.Visible = true;
		this.gridColumn3.VisibleIndex = 2;
		this.gridColumn3.Width = 133;
		this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn4.Caption = "Cumul Amortissment";
		this.gridColumn4.DisplayFormat.FormatString = "f2";
		this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.gridColumn4.FieldName = "cumul";
		this.gridColumn4.MinWidth = 15;
		this.gridColumn4.Name = "gridColumn4";
		this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
		this.gridColumn4.Visible = true;
		this.gridColumn4.VisibleIndex = 3;
		this.gridColumn4.Width = 118;
		this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn5.Caption = "VNC Fin Exercice";
		this.gridColumn5.DisplayFormat.FormatString = "f2";
		this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.gridColumn5.FieldName = "vnc";
		this.gridColumn5.MinWidth = 15;
		this.gridColumn5.Name = "gridColumn5";
		this.gridColumn5.Visible = true;
		this.gridColumn5.VisibleIndex = 4;
		this.gridColumn5.Width = 152;
		this.gridView4.Appearance.EvenRow.BackColor = System.Drawing.SystemColors.Window;
		this.gridView4.Appearance.EvenRow.BackColor2 = System.Drawing.SystemColors.Window;
		this.gridView4.Appearance.EvenRow.Options.UseBackColor = true;
		this.gridView4.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
		this.gridView4.Appearance.FocusedCell.BackColor2 = System.Drawing.SystemColors.HighlightText;
		this.gridView4.Appearance.FocusedCell.Options.UseBackColor = true;
		this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
		this.gridView4.Appearance.FocusedRow.BackColor2 = System.Drawing.SystemColors.Highlight;
		this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
		this.gridView4.Appearance.OddRow.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.gridView4.Appearance.OddRow.BackColor2 = System.Drawing.SystemColors.ButtonFace;
		this.gridView4.Appearance.OddRow.Options.UseBackColor = true;
		this.gridView4.DetailHeight = 801;
		this.gridView4.FixedLineWidth = 1;
		this.gridView4.GridControl = this.gridControl2;
		this.gridView4.Name = "gridView4";
		this.gridView4.OptionsBehavior.Editable = false;
		this.gridView4.OptionsBehavior.ReadOnly = true;
		this.gridView4.OptionsNavigation.EnterMoveNextColumn = true;
		this.gridView4.OptionsView.ColumnAutoWidth = false;
		this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
		this.gridView4.OptionsView.EnableAppearanceOddRow = true;
		this.gridView4.OptionsView.ShowFooter = true;
		this.gridView4.OptionsView.ShowIndicator = false;
		this.gridView4.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
		this.GridControl1.DataSource = this.immoBindingSource;
		this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
		this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
		this.GridControl1.Location = new System.Drawing.Point(125, 298);
		this.GridControl1.MainView = this.gridView1;
		this.GridControl1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
		this.GridControl1.Name = "GridControl1";
		this.GridControl1.Size = new System.Drawing.Size(653, 203);
		this.GridControl1.TabIndex = 15;
		this.GridControl1.TabStop = false;
		this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[2] { this.gridView1, this.GridView3 });
		this.immoBindingSource.DataMember = "Immo";
		this.immoBindingSource.DataSource = this.dataSet1;
		this.dataSet1.DataSetName = "DataSet1";
		this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
		this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
		this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[4] { this.colUNI, this.colLIB, this.colACT, this.colDATSOR });
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
		this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(gridView1_KeyDown);
		this.colUNI.AppearanceCell.Options.UseTextOptions = true;
		this.colUNI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.AppearanceHeader.Options.UseTextOptions = true;
		this.colUNI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colUNI.Caption = "Code";
		this.colUNI.FieldName = "MAT";
		this.colUNI.Name = "colUNI";
		this.colUNI.Visible = true;
		this.colUNI.VisibleIndex = 0;
		this.colUNI.Width = 63;
		this.colLIB.AppearanceHeader.Options.UseTextOptions = true;
		this.colLIB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colLIB.Caption = "Désignation";
		this.colLIB.FieldName = "LIB";
		this.colLIB.Name = "colLIB";
		this.colLIB.Visible = true;
		this.colLIB.VisibleIndex = 1;
		this.colLIB.Width = 400;
		this.colACT.AppearanceCell.Options.UseTextOptions = true;
		this.colACT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colACT.AppearanceHeader.Options.UseTextOptions = true;
		this.colACT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colACT.Caption = "Date ACQ.";
		this.colACT.FieldName = "DATACQ";
		this.colACT.Name = "colACT";
		this.colACT.Visible = true;
		this.colACT.VisibleIndex = 2;
		this.colACT.Width = 87;
		this.colDATSOR.AppearanceCell.Options.UseTextOptions = true;
		this.colDATSOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.colDATSOR.Caption = "Date SORT.";
		this.colDATSOR.FieldName = "DATSOR";
		this.colDATSOR.MinWidth = 15;
		this.colDATSOR.Name = "colDATSOR";
		this.colDATSOR.Visible = true;
		this.colDATSOR.VisibleIndex = 3;
		this.colDATSOR.Width = 76;
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
		this.IDTextEdit.TabIndex = 1;
		this.textEdit7.Location = new System.Drawing.Point(73, 94);
		this.textEdit7.Name = "textEdit7";
		this.textEdit7.Properties.Appearance.Options.UseTextOptions = true;
		this.textEdit7.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
		this.textEdit7.Properties.Mask.EditMask = "N0";
		this.textEdit7.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
		this.textEdit7.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.textEdit7.Size = new System.Drawing.Size(881, 20);
		this.textEdit7.StyleController = this.dataLayoutControl1;
		this.textEdit7.TabIndex = 1;
		this.textEdit10.Location = new System.Drawing.Point(73, 142);
		this.textEdit10.Name = "textEdit10";
		this.textEdit10.Size = new System.Drawing.Size(881, 20);
		this.textEdit10.StyleController = this.dataLayoutControl1;
		this.textEdit10.TabIndex = 1;
		this.UNITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "MAT", true));
		this.UNITextEdit.EnterMoveNextControl = true;
		this.UNITextEdit.Location = new System.Drawing.Point(29, 83);
		this.UNITextEdit.Name = "UNITextEdit";
		this.UNITextEdit.Properties.Appearance.Options.UseTextOptions = true;
		this.UNITextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.UNITextEdit.Size = new System.Drawing.Size(187, 20);
		this.UNITextEdit.StyleController = this.dataLayoutControl1;
		this.UNITextEdit.TabIndex = 0;
		this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "LIB", true));
		this.textEdit1.EnterMoveNextControl = true;
		this.textEdit1.Location = new System.Drawing.Point(220, 83);
		this.textEdit1.Name = "textEdit1";
		this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
		this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.textEdit1.Size = new System.Drawing.Size(463, 20);
		this.textEdit1.StyleController = this.dataLayoutControl1;
		this.textEdit1.TabIndex = 3;
		this.dateACQ.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "DATACQ", true));
		this.dateACQ.EditValue = null;
		this.dateACQ.EnterMoveNextControl = true;
		this.dateACQ.Location = new System.Drawing.Point(29, 121);
		this.dateACQ.Name = "dateACQ";
		this.dateACQ.Properties.Appearance.Options.UseTextOptions = true;
		this.dateACQ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.dateACQ.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.dateACQ.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.dateACQ.Properties.DisplayFormat.FormatString = "";
		this.dateACQ.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
		this.dateACQ.Properties.EditFormat.FormatString = "";
		this.dateACQ.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
		this.dateACQ.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.dateACQ.Size = new System.Drawing.Size(187, 20);
		this.dateACQ.StyleController = this.dataLayoutControl1;
		this.dateACQ.TabIndex = 4;
		this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "OBS", true));
		this.lookUpEdit2.EnterMoveNextControl = true;
		this.lookUpEdit2.Location = new System.Drawing.Point(454, 257);
		this.lookUpEdit2.Name = "lookUpEdit2";
		this.lookUpEdit2.Properties.Appearance.Options.UseTextOptions = true;
		this.lookUpEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.lookUpEdit2.Size = new System.Drawing.Size(421, 20);
		this.lookUpEdit2.StyleController = this.dataLayoutControl1;
		this.lookUpEdit2.TabIndex = 14;
		this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "MTCES", true));
		this.textEdit4.EditValue = new decimal(new int[4]);
		this.textEdit4.EnterMoveNextControl = true;
		this.textEdit4.Location = new System.Drawing.Point(241, 257);
		this.textEdit4.Name = "textEdit4";
		this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
		this.textEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.textEdit4.Properties.DisplayFormat.FormatString = "f2";
		this.textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.textEdit4.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
		this.textEdit4.Properties.Mask.EditMask = "f2";
		this.textEdit4.Size = new System.Drawing.Size(209, 20);
		this.textEdit4.StyleController = this.dataLayoutControl1;
		this.textEdit4.TabIndex = 12;
		this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "DATSOR", true));
		this.textEdit6.EditValue = null;
		this.textEdit6.EnterMoveNextControl = true;
		this.textEdit6.Location = new System.Drawing.Point(29, 257);
		this.textEdit6.Name = "textEdit6";
		this.textEdit6.Properties.Appearance.Options.UseTextOptions = true;
		this.textEdit6.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.textEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.textEdit6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.textEdit6.Properties.DisplayFormat.FormatString = "";
		this.textEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
		this.textEdit6.Properties.EditFormat.FormatString = "";
		this.textEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
		this.textEdit6.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.textEdit6.Size = new System.Drawing.Size(208, 20);
		this.textEdit6.StyleController = this.dataLayoutControl1;
		this.textEdit6.TabIndex = 13;
		this.simpleButton4.ImageOptions.Image = compta.Properties.Resources.print_16x16;
		this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton4.Location = new System.Drawing.Point(687, 516);
		this.simpleButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton4.Name = "simpleButton4";
		this.simpleButton4.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton4.Size = new System.Drawing.Size(175, 22);
		this.simpleButton4.StyleController = this.dataLayoutControl1;
		this.simpleButton4.TabIndex = 78;
		this.simpleButton4.Text = "Imprimer";
		this.simpleButton4.Click += new System.EventHandler(simpleButton4_Click);
		this.simpleButton11.ImageOptions.Image = compta.Properties.Resources.save_16x16;
		this.simpleButton11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton11.Location = new System.Drawing.Point(42, 516);
		this.simpleButton11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton11.Name = "simpleButton11";
		this.simpleButton11.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton11.Size = new System.Drawing.Size(175, 22);
		this.simpleButton11.StyleController = this.dataLayoutControl1;
		this.simpleButton11.TabIndex = 75;
		this.simpleButton11.Text = "Enregistrer";
		this.simpleButton11.Click += new System.EventHandler(bindingNavigatorSaveItem_Click);
		this.simpleButton3.ImageOptions.Image = compta.Properties.Resources.delete_16x16;
		this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton3.Location = new System.Drawing.Point(472, 516);
		this.simpleButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton3.Name = "simpleButton3";
		this.simpleButton3.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton3.Size = new System.Drawing.Size(175, 22);
		this.simpleButton3.StyleController = this.dataLayoutControl1;
		this.simpleButton3.TabIndex = 77;
		this.simpleButton3.Text = "Supprimer";
		this.simpleButton3.Click += new System.EventHandler(bindingNavigatorDeleteItem_Click);
		this.simpleButton21.ImageOptions.Image = compta.Properties.Resources.add_16x16;
		this.simpleButton21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
		this.simpleButton21.Location = new System.Drawing.Point(257, 516);
		this.simpleButton21.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
		this.simpleButton21.Name = "simpleButton21";
		this.simpleButton21.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
		this.simpleButton21.Size = new System.Drawing.Size(175, 22);
		this.simpleButton21.StyleController = this.dataLayoutControl1;
		this.simpleButton21.TabIndex = 76;
		this.simpleButton21.Text = "Ajouter";
		this.simpleButton21.Click += new System.EventHandler(bindingNavigatorAddNewItem_Click_1);
		this.tauxAM.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "TX", true));
		this.tauxAM.EditValue = new decimal(new int[4]);
		this.tauxAM.EnterMoveNextControl = true;
		this.tauxAM.Location = new System.Drawing.Point(687, 83);
		this.tauxAM.Name = "tauxAM";
		this.tauxAM.Properties.Appearance.Options.UseTextOptions = true;
		this.tauxAM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.tauxAM.Properties.DisplayFormat.FormatString = "f2";
		this.tauxAM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.tauxAM.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
		this.tauxAM.Properties.Mask.EditMask = "f2";
		this.tauxAM.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.tauxAM.Properties.MaxValue = new decimal(new int[4] { 100, 0, 0, 0 });
		this.tauxAM.Size = new System.Drawing.Size(188, 20);
		this.tauxAM.StyleController = this.dataLayoutControl1;
		this.tauxAM.TabIndex = 5;
		this.mtACQ.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "MTACQ", true));
		this.mtACQ.EditValue = new decimal(new int[4]);
		this.mtACQ.EnterMoveNextControl = true;
		this.mtACQ.Location = new System.Drawing.Point(220, 121);
		this.mtACQ.Name = "mtACQ";
		this.mtACQ.Properties.Appearance.Options.UseTextOptions = true;
		this.mtACQ.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.mtACQ.Properties.DisplayFormat.FormatString = "f2";
		this.mtACQ.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.mtACQ.Properties.EditFormat.FormatString = "f2";
		this.mtACQ.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.mtACQ.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
		this.mtACQ.Properties.Mask.EditMask = "f2";
		this.mtACQ.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.mtACQ.Size = new System.Drawing.Size(198, 20);
		this.mtACQ.StyleController = this.dataLayoutControl1;
		this.mtACQ.TabIndex = 4;
		this.mtACQ1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "TVA", true));
		this.mtACQ1.EditValue = new decimal(new int[4]);
		this.mtACQ1.EnterMoveNextControl = true;
		this.mtACQ1.Location = new System.Drawing.Point(687, 121);
		this.mtACQ1.Name = "mtACQ1";
		this.mtACQ1.Properties.Appearance.Options.UseTextOptions = true;
		this.mtACQ1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.mtACQ1.Properties.DisplayFormat.FormatString = "f2";
		this.mtACQ1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.mtACQ1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.mtACQ1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
		this.mtACQ1.Properties.Mask.EditMask = "f2";
		this.mtACQ1.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.mtACQ1.Size = new System.Drawing.Size(188, 20);
		this.mtACQ1.StyleController = this.dataLayoutControl1;
		this.mtACQ1.TabIndex = 4;
		this.mtAMORANT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "MTANT", true));
		this.mtAMORANT.EditValue = new decimal(new int[4]);
		this.mtAMORANT.EnterMoveNextControl = true;
		this.mtAMORANT.Location = new System.Drawing.Point(422, 121);
		this.mtAMORANT.Name = "mtAMORANT";
		this.mtAMORANT.Properties.Appearance.Options.UseTextOptions = true;
		this.mtAMORANT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.mtAMORANT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
		this.mtAMORANT.Properties.EditFormat.FormatString = "f2";
		this.mtAMORANT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
		this.mtAMORANT.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
		this.mtAMORANT.Properties.Mask.EditMask = "f2";
		this.mtAMORANT.Properties.Mask.UseMaskAsDisplayFormat = true;
		this.mtAMORANT.Size = new System.Drawing.Size(261, 20);
		this.mtAMORANT.StyleController = this.dataLayoutControl1;
		this.mtAMORANT.TabIndex = 4;
		this.cptimo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "CPT", true));
		this.cptimo.EnterMoveNextControl = true;
		this.cptimo.Location = new System.Drawing.Point(29, 189);
		this.cptimo.Name = "cptimo";
		this.cptimo.Properties.Appearance.Options.UseTextOptions = true;
		this.cptimo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.cptimo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.cptimo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.cptimo.Properties.DataSource = this.comptesBindingSource;
		this.cptimo.Properties.DisplayMember = "CPT";
		this.cptimo.Properties.NullText = "";
		this.cptimo.Properties.PopupView = this.searchLookUpEdit1View;
		this.cptimo.Properties.ValueMember = "CPT";
		this.cptimo.Size = new System.Drawing.Size(208, 20);
		this.cptimo.StyleController = this.dataLayoutControl1;
		this.cptimo.TabIndex = 2;
		this.comptesBindingSource.AllowNew = false;
		this.comptesBindingSource.DataMember = "Comptes";
		this.comptesBindingSource.DataSource = this.dataSet1;
		this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.gridColumn6, this.gridColumn7 });
		this.searchLookUpEdit1View.DetailHeight = 253;
		this.searchLookUpEdit1View.FixedLineWidth = 1;
		this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
		this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
		this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
		this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
		this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn6.Caption = "Compte";
		this.gridColumn6.FieldName = "CPT";
		this.gridColumn6.MinWidth = 15;
		this.gridColumn6.Name = "gridColumn6";
		this.gridColumn6.Visible = true;
		this.gridColumn6.VisibleIndex = 0;
		this.gridColumn6.Width = 156;
		this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn7.Caption = "Désignation";
		this.gridColumn7.FieldName = "LIB";
		this.gridColumn7.MinWidth = 15;
		this.gridColumn7.Name = "gridColumn7";
		this.gridColumn7.Visible = true;
		this.gridColumn7.VisibleIndex = 1;
		this.gridColumn7.Width = 950;
		this.cptamor.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "CPTAMOR", true));
		this.cptamor.EnterMoveNextControl = true;
		this.cptamor.Location = new System.Drawing.Point(241, 189);
		this.cptamor.Name = "cptamor";
		this.cptamor.Properties.Appearance.Options.UseTextOptions = true;
		this.cptamor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.cptamor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.cptamor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.cptamor.Properties.DataSource = this.comptesBindingSource;
		this.cptamor.Properties.DisplayMember = "CPT";
		this.cptamor.Properties.NullText = "";
		this.cptamor.Properties.PopupView = this.gridView5;
		this.cptamor.Properties.ValueMember = "CPT";
		this.cptamor.Size = new System.Drawing.Size(209, 20);
		this.cptamor.StyleController = this.dataLayoutControl1;
		this.cptamor.TabIndex = 2;
		this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.gridColumn8, this.gridColumn9 });
		this.gridView5.DetailHeight = 253;
		this.gridView5.FixedLineWidth = 1;
		this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
		this.gridView5.Name = "gridView5";
		this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
		this.gridView5.OptionsView.ShowGroupPanel = false;
		this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn8.Caption = "Compte";
		this.gridColumn8.FieldName = "CPT";
		this.gridColumn8.MinWidth = 15;
		this.gridColumn8.Name = "gridColumn8";
		this.gridColumn8.Visible = true;
		this.gridColumn8.VisibleIndex = 0;
		this.gridColumn8.Width = 156;
		this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn9.Caption = "Désignation";
		this.gridColumn9.FieldName = "LIB";
		this.gridColumn9.MinWidth = 15;
		this.gridColumn9.Name = "gridColumn9";
		this.gridColumn9.Visible = true;
		this.gridColumn9.VisibleIndex = 1;
		this.gridColumn9.Width = 950;
		this.cptdot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "CPTDOT", true));
		this.cptdot.EnterMoveNextControl = true;
		this.cptdot.Location = new System.Drawing.Point(454, 189);
		this.cptdot.Name = "cptdot";
		this.cptdot.Properties.Appearance.Options.UseTextOptions = true;
		this.cptdot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.cptdot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.cptdot.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.cptdot.Properties.DataSource = this.comptesBindingSource;
		this.cptdot.Properties.DisplayMember = "CPT";
		this.cptdot.Properties.NullText = "";
		this.cptdot.Properties.PopupView = this.gridView6;
		this.cptdot.Properties.ValueMember = "CPT";
		this.cptdot.Size = new System.Drawing.Size(208, 20);
		this.cptdot.StyleController = this.dataLayoutControl1;
		this.cptdot.TabIndex = 2;
		this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.gridColumn12, this.gridColumn13 });
		this.gridView6.DetailHeight = 253;
		this.gridView6.FixedLineWidth = 1;
		this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
		this.gridView6.Name = "gridView6";
		this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
		this.gridView6.OptionsView.ShowGroupPanel = false;
		this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn12.Caption = "Compte";
		this.gridColumn12.FieldName = "CPT";
		this.gridColumn12.MinWidth = 15;
		this.gridColumn12.Name = "gridColumn12";
		this.gridColumn12.Visible = true;
		this.gridColumn12.VisibleIndex = 0;
		this.gridColumn12.Width = 156;
		this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn13.Caption = "Désignation";
		this.gridColumn13.FieldName = "LIB";
		this.gridColumn13.MinWidth = 15;
		this.gridColumn13.Name = "gridColumn13";
		this.gridColumn13.Visible = true;
		this.gridColumn13.VisibleIndex = 1;
		this.gridColumn13.Width = 950;
		this.cptprod.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.immoBindingSource, "CPTPROD", true));
		this.cptprod.EnterMoveNextControl = true;
		this.cptprod.Location = new System.Drawing.Point(666, 189);
		this.cptprod.Name = "cptprod";
		this.cptprod.Properties.Appearance.Options.UseTextOptions = true;
		this.cptprod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.cptprod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.cptprod.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
		this.cptprod.Properties.DataSource = this.comptesBindingSource;
		this.cptprod.Properties.DisplayMember = "CPT";
		this.cptprod.Properties.NullText = "";
		this.cptprod.Properties.PopupView = this.gridView61;
		this.cptprod.Properties.ValueMember = "CPT";
		this.cptprod.Size = new System.Drawing.Size(209, 20);
		this.cptprod.StyleController = this.dataLayoutControl1;
		this.cptprod.TabIndex = 2;
		this.gridView61.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[2] { this.gridColumn10, this.gridColumn11 });
		this.gridView61.DetailHeight = 253;
		this.gridView61.FixedLineWidth = 1;
		this.gridView61.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
		this.gridView61.Name = "gridView61";
		this.gridView61.OptionsSelection.EnableAppearanceFocusedCell = false;
		this.gridView61.OptionsView.ShowGroupPanel = false;
		this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
		this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn10.Caption = "Compte";
		this.gridColumn10.FieldName = "CPT";
		this.gridColumn10.MinWidth = 15;
		this.gridColumn10.Name = "gridColumn10";
		this.gridColumn10.Visible = true;
		this.gridColumn10.VisibleIndex = 0;
		this.gridColumn10.Width = 156;
		this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
		this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.gridColumn11.Caption = "Désignation";
		this.gridColumn11.FieldName = "LIB";
		this.gridColumn11.MinWidth = 15;
		this.gridColumn11.Name = "gridColumn11";
		this.gridColumn11.Visible = true;
		this.gridColumn11.VisibleIndex = 1;
		this.gridColumn11.Width = 950;
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
		this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[5] { this.layoutControlGroup1, this.layoutControlGroup5, this.layoutControlItem1, this.emptySpaceItem2, this.emptySpaceItem4 });
		this.Root.Name = "Root";
		this.Root.OptionsItemText.TextToControlDistance = 1;
		this.Root.Size = new System.Drawing.Size(904, 561);
		this.Root.TextVisible = false;
		this.layoutControlGroup1.AllowDrawBackground = false;
		this.layoutControlGroup1.GroupBordersVisible = false;
		this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[1] { this.tabbedControlGroup1 });
		this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup1.Name = "autoGeneratedGroup0";
		this.layoutControlGroup1.Size = new System.Drawing.Size(884, 286);
		this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
		this.tabbedControlGroup1.Name = "tabbedControlGroup1";
		this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
		this.tabbedControlGroup1.Size = new System.Drawing.Size(884, 286);
		this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[2] { this.layoutControlGroup4, this.layoutControlGroup2 });
		this.tabbedControlGroup1.SelectedPageChanged += new DevExpress.XtraLayout.LayoutTabPageChangedEventHandler(tabbedControlGroup1_SelectedPageChanged);
		this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.layoutControlGroup6, this.layoutControlGroup7, this.layoutControlGroup3 });
		this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup4.Name = "layoutControlGroup4";
		this.layoutControlGroup4.Size = new System.Drawing.Size(860, 242);
		this.layoutControlGroup4.Text = "Acquisition";
		this.layoutControlGroup6.AppearanceGroup.Options.UseTextOptions = true;
		this.layoutControlGroup6.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlGroup6.AppearanceItemCaption.Options.UseTextOptions = true;
		this.layoutControlGroup6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[7] { this.ItemForADR, this.ItemForADR1, this.ItemForADR2, this.ItemForADR3, this.ItemForUNI, this.ItemForLIB, this.ItemForCodeActivite });
		this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup6.Name = "layoutControlGroup6";
		this.layoutControlGroup6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
		this.layoutControlGroup6.Size = new System.Drawing.Size(860, 106);
		this.layoutControlGroup6.Text = "Acquisition ";
		this.ItemForADR.Control = this.dateACQ;
		this.ItemForADR.CustomizationFormText = "Date Acquisition";
		this.ItemForADR.Location = new System.Drawing.Point(0, 38);
		this.ItemForADR.Name = "ItemForADR";
		this.ItemForADR.Size = new System.Drawing.Size(191, 38);
		this.ItemForADR.Text = "Date Acquisition";
		this.ItemForADR.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForADR.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForADR1.Control = this.mtACQ;
		this.ItemForADR1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForADR1.Location = new System.Drawing.Point(191, 38);
		this.ItemForADR1.Name = "ItemForADR1";
		this.ItemForADR1.Size = new System.Drawing.Size(202, 38);
		this.ItemForADR1.Text = "MT ACQ HT";
		this.ItemForADR1.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForADR1.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForADR2.Control = this.mtACQ1;
		this.ItemForADR2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForADR2.CustomizationFormText = "Date Acquesition";
		this.ItemForADR2.Location = new System.Drawing.Point(658, 38);
		this.ItemForADR2.Name = "ItemForADR2";
		this.ItemForADR2.Size = new System.Drawing.Size(192, 38);
		this.ItemForADR2.Text = "TVA";
		this.ItemForADR2.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForADR2.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForADR3.Control = this.mtAMORANT;
		this.ItemForADR3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForADR3.CustomizationFormText = "MT ACQ HT";
		this.ItemForADR3.Location = new System.Drawing.Point(393, 38);
		this.ItemForADR3.Name = "ItemForADR3";
		this.ItemForADR3.Size = new System.Drawing.Size(265, 38);
		this.ItemForADR3.Text = "AMORT. Antérieur";
		this.ItemForADR3.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForADR3.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForUNI.AppearanceItemCaption.Options.UseTextOptions = true;
		this.ItemForUNI.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.ItemForUNI.Control = this.UNITextEdit;
		this.ItemForUNI.Location = new System.Drawing.Point(0, 0);
		this.ItemForUNI.Name = "ItemForUNI";
		this.ItemForUNI.Size = new System.Drawing.Size(191, 38);
		this.ItemForUNI.Text = "Code";
		this.ItemForUNI.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForUNI.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForLIB.AppearanceItemCaption.Options.UseTextOptions = true;
		this.ItemForLIB.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.ItemForLIB.Control = this.textEdit1;
		this.ItemForLIB.Location = new System.Drawing.Point(191, 0);
		this.ItemForLIB.Name = "ItemForLIB";
		this.ItemForLIB.Size = new System.Drawing.Size(467, 38);
		this.ItemForLIB.Text = "Intitulé";
		this.ItemForLIB.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForLIB.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForCodeActivite.AppearanceItemCaption.Options.UseTextOptions = true;
		this.ItemForCodeActivite.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.ItemForCodeActivite.Control = this.tauxAM;
		this.ItemForCodeActivite.Location = new System.Drawing.Point(658, 0);
		this.ItemForCodeActivite.Name = "ItemForCodeActivite";
		this.ItemForCodeActivite.Size = new System.Drawing.Size(192, 38);
		this.ItemForCodeActivite.Text = "Taux Amort.";
		this.ItemForCodeActivite.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForCodeActivite.TextSize = new System.Drawing.Size(95, 13);
		this.layoutControlGroup7.AppearanceGroup.Options.UseTextOptions = true;
		this.layoutControlGroup7.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.layoutControlItem8, this.layoutControlItem6, this.layoutControlItem11 });
		this.layoutControlGroup7.Location = new System.Drawing.Point(0, 174);
		this.layoutControlGroup7.Name = "layoutControlGroup7";
		this.layoutControlGroup7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
		this.layoutControlGroup7.Size = new System.Drawing.Size(860, 68);
		this.layoutControlGroup7.Text = "Cession";
		this.layoutControlItem8.AppearanceItemCaption.Options.UseTextOptions = true;
		this.layoutControlItem8.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlItem8.Control = this.textEdit6;
		this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
		this.layoutControlItem8.Name = "ItemForRC";
		this.layoutControlItem8.Size = new System.Drawing.Size(212, 38);
		this.layoutControlItem8.Text = "Date Sortie";
		this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
		this.layoutControlItem8.TextSize = new System.Drawing.Size(95, 13);
		this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
		this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlItem6.Control = this.textEdit4;
		this.layoutControlItem6.Location = new System.Drawing.Point(212, 0);
		this.layoutControlItem6.Name = "ItemForNUMAI";
		this.layoutControlItem6.Size = new System.Drawing.Size(213, 38);
		this.layoutControlItem6.Text = "Montant de Cession";
		this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
		this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 13);
		this.layoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = true;
		this.layoutControlItem11.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlItem11.Control = this.lookUpEdit2;
		this.layoutControlItem11.Location = new System.Drawing.Point(425, 0);
		this.layoutControlItem11.Name = "layoutControlItem11";
		this.layoutControlItem11.Size = new System.Drawing.Size(425, 38);
		this.layoutControlItem11.Text = "Observation";
		this.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top;
		this.layoutControlItem11.TextSize = new System.Drawing.Size(95, 13);
		this.layoutControlGroup3.AppearanceGroup.Options.UseTextOptions = true;
		this.layoutControlGroup3.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.ItemForACT, this.ItemForACT1, this.ItemForACT2, this.ItemForACT3 });
		this.layoutControlGroup3.Location = new System.Drawing.Point(0, 106);
		this.layoutControlGroup3.Name = "layoutControlGroup3";
		this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
		this.layoutControlGroup3.Size = new System.Drawing.Size(860, 68);
		this.layoutControlGroup3.Text = "Comptes";
		this.ItemForACT.AppearanceItemCaption.Options.UseTextOptions = true;
		this.ItemForACT.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.ItemForACT.Control = this.cptimo;
		this.ItemForACT.Location = new System.Drawing.Point(0, 0);
		this.ItemForACT.Name = "ItemForACT";
		this.ItemForACT.Size = new System.Drawing.Size(212, 38);
		this.ItemForACT.Text = "Compte (Actif)";
		this.ItemForACT.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForACT.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForACT1.AppearanceItemCaption.Options.UseTextOptions = true;
		this.ItemForACT1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.ItemForACT1.Control = this.cptamor;
		this.ItemForACT1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForACT1.CustomizationFormText = "Compte";
		this.ItemForACT1.Location = new System.Drawing.Point(212, 0);
		this.ItemForACT1.Name = "ItemForACT1";
		this.ItemForACT1.Size = new System.Drawing.Size(213, 38);
		this.ItemForACT1.Text = "CPT. Amort.";
		this.ItemForACT1.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForACT1.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForACT2.AppearanceItemCaption.Options.UseTextOptions = true;
		this.ItemForACT2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.ItemForACT2.Control = this.cptdot;
		this.ItemForACT2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForACT2.CustomizationFormText = "Compte";
		this.ItemForACT2.Location = new System.Drawing.Point(425, 0);
		this.ItemForACT2.Name = "ItemForACT2";
		this.ItemForACT2.Size = new System.Drawing.Size(212, 38);
		this.ItemForACT2.Text = "CPT. Dotation";
		this.ItemForACT2.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForACT2.TextSize = new System.Drawing.Size(95, 13);
		this.ItemForACT3.AppearanceItemCaption.Options.UseTextOptions = true;
		this.ItemForACT3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
		this.ItemForACT3.Control = this.cptprod;
		this.ItemForACT3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
		this.ItemForACT3.CustomizationFormText = "Compte";
		this.ItemForACT3.Location = new System.Drawing.Point(637, 0);
		this.ItemForACT3.Name = "ItemForACT3";
		this.ItemForACT3.Size = new System.Drawing.Size(213, 38);
		this.ItemForACT3.Text = "CPT. Prod. ExcP.";
		this.ItemForACT3.TextLocation = DevExpress.Utils.Locations.Top;
		this.ItemForACT3.TextSize = new System.Drawing.Size(95, 13);
		this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[3] { this.layoutControlItem2, this.emptySpaceItem3, this.emptySpaceItem1 });
		this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
		this.layoutControlGroup2.Name = "layoutControlGroup2";
		this.layoutControlGroup2.Size = new System.Drawing.Size(860, 242);
		this.layoutControlGroup2.Text = "Tableau des amortissements";
		this.layoutControlItem2.Control = this.gridControl2;
		this.layoutControlItem2.Location = new System.Drawing.Point(102, 0);
		this.layoutControlItem2.Name = "layoutControlItem2";
		this.layoutControlItem2.Size = new System.Drawing.Size(652, 242);
		this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem2.TextVisible = false;
		this.emptySpaceItem3.AllowHotTrack = false;
		this.emptySpaceItem3.Location = new System.Drawing.Point(754, 0);
		this.emptySpaceItem3.Name = "emptySpaceItem3";
		this.emptySpaceItem3.Size = new System.Drawing.Size(106, 242);
		this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem1.AllowHotTrack = false;
		this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
		this.emptySpaceItem1.Name = "emptySpaceItem1";
		this.emptySpaceItem1.Size = new System.Drawing.Size(102, 242);
		this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup1";
		this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[4] { this.layoutControlItem16, this.layoutControlItem17, this.layoutControlItem21, this.layoutControlItem22 });
		this.layoutControlGroup5.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
		this.layoutControlGroup5.Location = new System.Drawing.Point(0, 493);
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
		this.layoutControlGroup5.Size = new System.Drawing.Size(884, 48);
		this.layoutControlGroup5.Text = "layoutControlGroup1";
		this.layoutControlGroup5.TextLocation = DevExpress.Utils.Locations.Default;
		this.layoutControlGroup5.TextVisible = false;
		this.layoutControlItem16.Control = this.simpleButton4;
		this.layoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem16.CustomizationFormText = "layoutControlItem10";
		this.layoutControlItem16.Location = new System.Drawing.Point(645, 0);
		this.layoutControlItem16.Name = "layoutControlItem16";
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem16.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem16.OptionsTableLayoutItem.ColumnIndex = 3;
		this.layoutControlItem16.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem16.Size = new System.Drawing.Size(215, 24);
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
		this.layoutControlItem17.Size = new System.Drawing.Size(215, 24);
		this.layoutControlItem17.Text = "layoutControlItem7";
		this.layoutControlItem17.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem17.TextVisible = false;
		this.layoutControlItem21.Control = this.simpleButton3;
		this.layoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem21.CustomizationFormText = "layoutControlItem9";
		this.layoutControlItem21.Location = new System.Drawing.Point(430, 0);
		this.layoutControlItem21.Name = "layoutControlItem21";
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem21.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem21.OptionsTableLayoutItem.ColumnIndex = 2;
		this.layoutControlItem21.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem21.Size = new System.Drawing.Size(215, 24);
		this.layoutControlItem21.Text = "layoutControlItem9";
		this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem21.TextVisible = false;
		this.layoutControlItem22.Control = this.simpleButton21;
		this.layoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
		this.layoutControlItem22.CustomizationFormText = "layoutControlItem8";
		this.layoutControlItem22.Location = new System.Drawing.Point(215, 0);
		this.layoutControlItem22.Name = "layoutControlItem22";
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItem.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemControl.Options.UseFont = true;
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Font = new System.Drawing.Font("Arial", 10f);
		this.layoutControlItem22.OptionsPrint.AppearanceItemText.Options.UseFont = true;
		this.layoutControlItem22.OptionsTableLayoutItem.ColumnIndex = 1;
		this.layoutControlItem22.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 1, 1);
		this.layoutControlItem22.Size = new System.Drawing.Size(215, 24);
		this.layoutControlItem22.Text = "layoutControlItem8";
		this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem22.TextVisible = false;
		this.layoutControlItem1.Control = this.GridControl1;
		this.layoutControlItem1.Location = new System.Drawing.Point(113, 286);
		this.layoutControlItem1.Name = "layoutControlItem1";
		this.layoutControlItem1.Size = new System.Drawing.Size(657, 207);
		this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
		this.layoutControlItem1.TextVisible = false;
		this.emptySpaceItem2.AllowHotTrack = false;
		this.emptySpaceItem2.Location = new System.Drawing.Point(770, 286);
		this.emptySpaceItem2.Name = "emptySpaceItem2";
		this.emptySpaceItem2.Size = new System.Drawing.Size(114, 207);
		this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
		this.emptySpaceItem4.AllowHotTrack = false;
		this.emptySpaceItem4.Location = new System.Drawing.Point(0, 286);
		this.emptySpaceItem4.Name = "emptySpaceItem4";
		this.emptySpaceItem4.Size = new System.Drawing.Size(113, 207);
		this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
		this.immoTableAdapter.ClearBeforeFill = true;
		this.comptesTableAdapter.ClearBeforeFill = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(904, 561);
		base.Controls.Add(this.dataLayoutControl1);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmAmortissement";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Amortissements";
		base.Load += new System.EventHandler(frmAmortissement_Load);
		((System.ComponentModel.ISupportInitialize)this.dataLayoutControl1).EndInit();
		this.dataLayoutControl1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.gridControl2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.immoBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataSet1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.GridView3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.IDTextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit7.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit10.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.UNITextEdit.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dateACQ.Properties.CalendarTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dateACQ.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.lookUpEdit2.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit4.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit6.Properties.CalendarTimeProperties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.textEdit6.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tauxAM.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mtACQ.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mtACQ1.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.mtAMORANT.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.cptimo.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.comptesBindingSource).EndInit();
		((System.ComponentModel.ISupportInitialize)this.searchLookUpEdit1View).EndInit();
		((System.ComponentModel.ISupportInitialize)this.cptamor.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.cptdot.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.cptprod.Properties).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridView61).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForID).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem9).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem12).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Root).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.tabbedControlGroup1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForADR3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForUNI).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForLIB).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForCodeActivite).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup7).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem8).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem6).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem11).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.ItemForACT3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlGroup5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem16).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem17).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem22).EndInit();
		((System.ComponentModel.ISupportInitialize)this.layoutControlItem1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.emptySpaceItem4).EndInit();
		base.ResumeLayout(false);
	}
}
